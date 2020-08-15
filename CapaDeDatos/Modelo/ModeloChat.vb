Public Class ModeloChat
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdMedico As String
    Public IdDiagnostico As String
    Public Mensaje As String
    Public Destinatario As String

    Public Sub EnviarMensaje()
        MsgBox(IdMedico + ", " + IdDiagnostico + ", " + Mensaje + ", " + Destinatario)
        Command.CommandText = "
            INSERT INTO
                Atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.IdMedico + ", " + Me.Pwd + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, " + Me.Destinatario + ")
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()

    End Sub

    Public Function BuscarMensajesNuevos()
        Command.CommandText = "
            SELECT 
                a.ci_persona_medico, a.mensaje, a.destinatario, p.nombre 
            FROM 
                atiende a 
                JOIN 
                medico m ON a.ci_persona_medico = m.ci_persona 
                JOIN 
                persona p ON p.ci = m.ci_persona 
            WHERE 
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                destinatario = " + Me.Pwd + "
                AND
                leido = 0
                AND 
                status = 'Iniciado'
            LIMIT
                1
        "
        Dim resultado As New DataTable
        resultado.Load(Me.Command.ExecuteReader())
        Me.Connect.Close()
        Me.Connect.Open()
        Command.CommandText = "
            UPDATE
                atiende
            SET 
                leido = 1
            WHERE
                destinatario = " + Me.Pwd + "
        "
        Command.ExecuteNonQuery()
        '(SELECT
        '                MAX(id)
        '             FROM
        '                atiende
        '             WHERE
        '                destinatario = " + Me.Pwd + "
        '             )
        Me.Connect.Close()
        Return resultado

    End Function
End Class
