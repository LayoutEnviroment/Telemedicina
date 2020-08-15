Public Class ModeloPaciente
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Function ObtenerNombre()
        Command.CommandText = "
            SELECT
                nombre
            FROM
                persona
            WHERE ci = " + Me.Pwd + "
        "
        Return Command.ExecuteScalar.ToString()

    End Function

End Class
