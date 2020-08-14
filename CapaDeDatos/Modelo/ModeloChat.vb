Public Class ModeloChat
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdDiagnostico As String
    Public Mensaje As String
    Public Destinatario As Integer = 12345672

    Public Sub EnviarMensaje()
        Command.CommandText = "
            INSERT INTO
                Atiende(ci_persona_medico, ci_persona_paciente, id_diagnostico, conversacion, leido, destinatario)
            VALUES
                (12345672, " + Me.Pwd + ", " + Me.IdDiagnostico + ", '" + Me.Mensaje + "', 0, 12345672)
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
    End Sub

    Public Function BuscarMensajesNuevos()
        Command.CommandText = "
            SELECT
                conversacion
            FROM 
                atiende
            WHERE
                id_diagnostico = " + Me.IdDiagnostico + "
                AND
                destinatario = " + Me.Pwd + "
                AND
                leido = 0
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
                id = (SELECT
                        MAX(id)
                     FROM
                        atiende
                     WHERE
                        destinatario = " + Me.Pwd + "
                     )
        "
        Command.ExecuteNonQuery()
        Me.Connect.Close()
        Return resultado

    End Function
End Class
