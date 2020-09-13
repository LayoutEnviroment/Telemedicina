﻿Public Class ModeloSintoma
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

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
End Class
