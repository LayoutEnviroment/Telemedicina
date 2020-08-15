Public Class ModeloCompone
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdSintomas As New List(Of String)
    Public IdEnfermedad As String

    Public Function EnfermedadesPosibles()
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())

        Command.CommandText = "
            SELECT 
                e.nombre, e.prioridad, e.descripcion
            FROM 
                enfermedad e JOIN compone c ON e.id = c.id_enfermedad
            GROUP BY 
                id_enfermedad
            HAVING
        "

        For Each sintoma In IdSintomas
            Command.CommandText += "
                    SUM(id_sintoma = (SELECT
                                        id
                                     FROM
                                        sintoma
                                     WHERE 
                                        nombre = '" + sintoma + "')
                        ) > 0 
                    AND         
                "

        Next
        Command.CommandText += "
                    SUM(id_sintoma NOT IN(SELECT
                                            id
                                        FROM
                                            sintoma
                                        WHERE
                                            nombre IN(
                                                " + values + ")
                                        )
                        ) = 0; 
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Sub Insertar()
        Try
            For Each Nombre In IdSintomas
                Command.CommandText = "
                    INSERT INTO
                        compone(id_sintoma, id_enfermedad)
                    VALUES
                        ((SELECT
                            id
                        FROM
                            sintoma
                        WHERE
                            nombre = '" + Nombre + "'),
                        (SELECT
                            id
                        FROM
                            enfermedad
                        WHERE
                            nombre = '" + IdEnfermedad + "'))

                "
                Command.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MsgBox("Cortaste toda la loz")
        End Try

    End Sub

End Class
