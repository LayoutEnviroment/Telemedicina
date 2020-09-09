Public Class ModeloEnfermedad
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Id As String
    Public Nombre As String
    Public Descripcion As String
    Public Prioridad As String

    Public Function Listar()
        Command.CommandText = "
            SELECT
                id AS ID, 
                nombre AS Nombre,
                descripcion AS Descripcion,
                prioridad AS Prioridad
            FROM
                enfermedad
            WHERE
                activo = 1
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreEnfermedad()
        Command.CommandText = "
            SELECT 
                nombre AS Enfermedad 
            FROM 
                enfermedad
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarTodo()
        Command.CommandText = "
            SELECT
                id AS ID, 
                nombre AS Nombre,
                descripcion AS Descripcion,
                prioridad AS Prioridad
            FROM
                enfermedad
        "
        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub Insertar()
        Command.CommandText = "
            INSERT INTO 
                enfermedad(nombre,descripcion,prioridad) 
            VALUES
                ('" + Me.Nombre + "','" + Me.Descripcion + "','" + Me.Prioridad + "')
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()
        Command.CommandText = "
            UPDATE 
                enfermedad 
            SET 
                nombre = '" + Me.Nombre + "',descripcion = '" + Me.Descripcion + "',prioridad ='" + Me.Prioridad + "' 
            WHERE 
                id = " + Me.Id + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "
            UPDATE 
                enfermedad 
            SET 
                activo = 0 
            WHERE id = " + Me.Id + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Function ObtenerId()
        Command.CommandText = "
            SELECT
                id
            FROM
                enfermedad
            WHERE
                nombre = '" + Me.Nombre + "'
        "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerIdConDiagnostico()
        Command.CommandText = "
            SELECT
                MAX(DISTINCT(g.id_enfermedad_compone))
            FROM
                genera g
                    JOIN
                        diagnostico d
                            ON
                                g.id_diagnostico = d.id
            WHERE
                d.pertenece = " + Me.Pwd + "
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerPrioridad()
        Command.CommandText = "
            SELECT
                prioridad
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerDescripcion()
        Command.CommandText = "
            SELECT
                descripcion
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Return Command.ExecuteScalar.ToString()

    End Function


    Public Function ObtenerTodo()
        Command.CommandText = "
            SELECT
                nombre,
                prioridad,
                descripcion
            FROM
                enfermedad
            WHERE
                id = " + Me.Id + "
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function
End Class

