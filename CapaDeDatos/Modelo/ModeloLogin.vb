Public Class ModeloLogin
    Inherits ModeloBaseDeDatos

    Public Sub New(usuario As String, contra As String)
        MyBase.New(usuario, contra)
    End Sub

    Public NombreUsuario As String
    Public ContraUsuario As String
    Public Cedula As String

    Public Function ObtenerRol()
        Command.CommandText = "
            SELECT
                rol
            FROM
                roles
            WHERE
                ci_persona = '" + Me.Uid + "'
        "
        Return Command.ExecuteScalar.ToString
    End Function

End Class
