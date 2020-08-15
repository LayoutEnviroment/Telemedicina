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
                Atiende(ci_persona_paciente, id_diagnostico)
            VALUES
                (" + Me.Pwd + ", " + Me.IdDiagnostico + ")
        "
        Command.ExecuteNonQuery()

    End Sub




End Class
