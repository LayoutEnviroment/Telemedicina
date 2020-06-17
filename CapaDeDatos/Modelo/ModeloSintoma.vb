Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public IdSintoma As String
    Public Prioridad As String
    Public Descripcion As String
    Public Nombre As String

    Public Function Listar()
        Command.CommandText = "SELECT
                                name
                               FROM
                                sintoma
                               WHERE
                                sintoma.name LIKE " + Me.Nombre + "%"
        Command.ExecuteNonQuery()
        Return Reader
    End Function
End Class
