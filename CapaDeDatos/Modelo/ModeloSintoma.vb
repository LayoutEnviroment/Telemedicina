Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public IdSintoma As String
    Public Nombre As String

    Public Function Listar()
        Command.CommandText = "SELECT
                                nombre
                               FROM
                                sintoma
                               WHERE
                                sintoma.nombre LIKE '" + Me.Nombre + "%'"
        Reader = Command.ExecuteReader()
        Return Reader
    End Function
End Class
