Public Class ModeloChatPaciente
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdMedico As String
    Public IdDiagnostico As String
    Public Mensaje As String
    Public Destinatario As String

    Public Sub EnviarSolicitud()
        Command.CommandText = "
            INSERT INTO
                Atiende(ci_persona_paciente, id_diagnostico, leido)
            VALUES
                (" + Me.Pwd + ", " + Me.IdDiagnostico + ", 0)
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
    End Sub

    Public Sub EnviarMensaje()
        Command.CommandText = "
            INSERT INTO 
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status) 
            VALUES
                (" + Me.Destinatario + ", " + Me.Pwd + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, " + Me.Destinatario + ", 'Iniciado')
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
    End Sub

    Public Function BuscarMensajesNuevos()
        Command.CommandText = "
            SELECT 
                a.ci_persona_medico,
                a.ci_persona_paciente,
                a.mensaje, 
                a.destinatario, 
                p.nombre,
                a.status
            FROM 
                atiende a 
                    JOIN 
                        medico m 
                            ON 
                                a.ci_persona_medico = m.ci_persona 
                    JOIN 
                        persona p 
                            ON 
                                p.ci = m.ci_persona 
            WHERE 
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                    destinatario = " + Me.Pwd + "
                AND
                    leido = 0
            LIMIT
                1
        "
        Dim Resultado As New DataTable
        Resultado.Load(Me.Command.ExecuteReader)
        Me.Connect.Close()
        Return Resultado

    End Function

    Public Sub MarcarComoLeido()
        Command.CommandText = "
            UPDATE
                atiende
            SET 
                leido = 1
            WHERE
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                    destinatario = " + Me.Pwd + "
                "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
    End Sub


    Public Sub FinalizarChat()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.Destinatario + ", " + Me.Pwd + ", " + Me.IdDiagnostico + ", 'paciente desconectado', 0," + Me.Destinatario + ", 'Finalizado')
        "
        Command.ExecuteNonQuery()
    End Sub

    Public Sub MarcarComoFinalizado()
        Command.CommandText = "
            UPDATE
                atiende
            SET
                status = 'Finalizado'
            WHERE
                id_diagnostico = " + Me.IdDiagnostico + "
        "
        Command.ExecuteNonQuery()
    End Sub
End Class
