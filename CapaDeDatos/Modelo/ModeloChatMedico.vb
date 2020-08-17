Public Class ModeloChatMedico
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdMedico As String = Me.Pwd
    Public IdDiagnostico As String
    Public Mensaje As String
    Public Destinatario As String
    Public MiNombre As String
    Public MiApellido As String

    Public Function BuscarSolicitud()
        Command.CommandText = "
            SELECT 
                DISTINCT(a.id_diagnostico) AS id, 
                a.ci_persona_paciente AS Paciente, 
                e.prioridad 
            FROM 
                atiende a 
                JOIN 
                diagnostico d 
                    ON a.id_diagnostico = d.id 
                JOIN 
                genera g 
                    ON g.id_diagnostico = d.id 
                JOIN compone c 
                    ON c.id_enfermedad = g.id_enfermedad_compone 
                JOIN enfermedad e 
                    ON e.id = c.id_enfermedad 
            WHERE 
                leido = 0 
                AND 
                status = 'Esperando' 
            ORDER BY 
                FIELD(prioridad,'ALTA','MEDIA','BAJA'),
                a.fecha_hora asc;
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerMiNombreApellido()
        Command.CommandText = "
            SELECT 
                p.nombre, p.apellido 
            FROM 
                atiende a 
                JOIN 
                    medico m 
                        ON 
                            m.ci_persona = a.ci_persona_medico 
                JOIN 
                    persona p 
                        ON 
                            p.ci = m.ci_persona
            WHERE
                a.ci_persona_medico = " + Me.Pwd + "
            LIMIT
                1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub AceptarSolicitud()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES(
                " + Me.Pwd + ",
                " + Me.Destinatario + ",
                " + Me.IdDiagnostico + ",
                'Buen día, soy el doctor " + Me.MiNombre + " " + Me.MiApellido + ", como puedo ayudarle hoy? ',
                0,
                " + Me.Destinatario + ",
                'Iniciado'
                )                            
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub EnviarMensaje()
        Command.CommandText = "
            INSERT INTO
                atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, mensaje, leido, destinatario, status)
            VALUES
                (" + Me.IdMedico + ", " + Me.Destinatario + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, " + Me.Destinatario + ", 'Iniciado' )
            
        "
        Command.ExecuteNonQuery()
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
                id_diagnostico = (
                                SELECT
                                    MAX(id_diagnostico)
                                FROM
                                    atiende
                                WHERE
                                    destinatario = " + Me.Pwd + "
                                )
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
                (" + Me.IdMedico + ", " + Me.Destinatario + ", " + Me.IdDiagnostico + ", 'La conexion a sido terminada por el medico', 0, " + Me.Destinatario + ", 'Finalizado' )
            
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
