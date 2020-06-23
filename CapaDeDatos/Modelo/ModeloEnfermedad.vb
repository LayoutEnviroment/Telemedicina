Public Class ModeloEnfermedad
    Inherits ModeloBaseDeDatos

    Public IdEnfermedad As String
    Public Nombre As String
    Public Descripcion As String
    Public Prioridad As String

    Public Function Listar()
        Command.CommandText = "SELECT
                                id_enfermedad AS ID, 
                                nombre AS Nombre,
                                descripcion AS Descripcion,
                                prioridad AS Prioridad
                               FROM
                                enfermedad
                               "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ListarNombreEnfermedad()
        Command.CommandText = "SELECT nombre as Enfermedad FROM enfermedad"
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarTodo()
        Command.CommandText = "SELECT
                                id_enfermedad AS ID, 
                                nombre AS Nombre,
                                descripcion AS Descripcion,
                                prioridad AS Prioridad
                               FROM
                                enfermedad"

        Reader = Command.ExecuteReader
        Return Reader

    End Function
    Public Sub Insertar()
        Command.CommandText = "INSERT INTO enfermedad(nombre,descripcion,prioridad) VALUES('" + Me.Nombre + "','" + Me.Descripcion + "','" + Me.Prioridad + "')"
        Command.ExecuteNonQuery()

    End Sub
    Public Sub Modificar()
        Command.CommandText = "UPDATE enfermedad SET nombre = '" + Me.Nombre + "',descripcion = '" + Me.Descripcion + "',prioridad ='" + Me.Prioridad + "' WHERE id_enfermedad = " + Me.IdEnfermedad + ""
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "UPDATE enfermedad SET activo = 0 WHERE id_enfermedad = " + Me.IdEnfermedad + ""
        Command.ExecuteNonQuery()

    End Sub

End Class

