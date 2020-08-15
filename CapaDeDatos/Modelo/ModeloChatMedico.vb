Public Class ModeloChatMedico
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdMedico As String
    Public IdDiagnostico As String
    Public Mensaje As String
    Public Destinatario As String

    Public Function BuscarSolicitud()
        Command.CommandText = "
            SELECT 
                DISTINCT(a.id_diagnostico), a.ci_persona_paciente, e.prioridad 
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
                a.fecha_hora desc;
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

End Class
