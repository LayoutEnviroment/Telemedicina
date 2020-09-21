Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public ListadoSintomas As List(Of String)
    Public IdSintoma As String
    Public Nombre As String
    Public Activo As String

    Public Function Listar()
        Command.CommandText = "
            SELECT
                nombre
            FROM
                sintoma
            WHERE
                nombre LIKE '%" + Me.Nombre + "%'"
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarNombreSintoma()
        Command.CommandText = "
            SELECT 
                nombre AS Sintoma 
            FROM 
                sintoma
        "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ListarTodo()
        Command.CommandText = "
            SELECT
                id AS ID, nombre AS Nombre
            FROM
                sintoma
        "

        Reader = Command.ExecuteReader
        Return Reader

    End Function

    Public Sub Insertar()
        Command.CommandText = "
            INSERT INTO 
                sintoma(nombre) 
            VALUES
                ('" + Me.Nombre + "')
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Modificar()
        Command.CommandText = "
            UPDATE 
                sintoma    
            SET 
                nombre = '" + Me.Nombre + "' 
            WHERE 
                id = " + Me.IdSintoma + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub Eliminar()
        Command.CommandText = "
            UPDATE 
                sintoma 
            SET 
                activo = 0 
            WHERE 
                id = " + Me.IdSintoma + "
        "
        Command.ExecuteNonQuery()

    End Sub

    Public Sub GuardarPadecimientos()
        For Each sintoma In ListadoSintomas
            Command.CommandText = "
            INSERT INTO
                padece(ci_persona_paciente, id_sintoma)
            VALUES(" + Me.Pwd + ", 
                (SELECT id FROM sintoma WHERE nombre = '" + sintoma + "')
                    )
        "
            Command.ExecuteNonQuery()
        Next

    End Sub

End Class
