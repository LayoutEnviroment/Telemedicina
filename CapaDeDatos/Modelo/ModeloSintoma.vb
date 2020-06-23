Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public IdSintoma As String
    Public Nombre As String
    Public Activo As String

    Public Function Listar()
        Command.CommandText = "SELECT
                                nombre
                               FROM
                                sintoma
                               WHERE
                                sintoma.nombre LIKE '%" + Me.Nombre + "%'"
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ListarTodo()
        Command.CommandText = "SELECT
                                id_sintoma AS ID, nombre AS Nombre
                               FROM
                                sintoma
                               WHERE
                                activo = 1"

        Reader = Command.ExecuteReader
        Return Reader

    End Function
    Public Sub Insertar()
        Command.CommandText = "INSERT INTO sintoma(nombre) VALUES('" + Me.Nombre + "')"
        Command.ExecuteNonQuery()

    End Sub
    Public Sub Modificar()
        Command.CommandText = "UPDATE sintoma SET nombre = '" + Me.Nombre + "' WHERE id_sintoma = " + Me.IdSintoma + ""
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "UPDATE sintoma SET activo = 0 WHERE id_sintoma = " + Me.IdSintoma + ""
        Command.ExecuteNonQuery()

    End Sub
End Class
