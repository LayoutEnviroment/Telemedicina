Public Class ModeloCompone
    Inherits ModeloBaseDeDatos

    Public IdSintomas As New List(Of String)
    Public IdEnfermedad As String

    Public Function EnfermedadesPosibles()
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())
        Dim NuevoNombre As String = "Sintomas en comun"

        Command.CommandText = "         
            SELECT
                e.nombre AS Enfermedad,
                COUNT(*) AS  '" + NuevoNombre + "'
            FROM
                compone c
                JOIN
                sintoma s ON c.id_sintoma = s.id
                JOIN
                enfermedad e ON c.id_enfermedad = e.id
            WHERE
                c.id_sintoma IN (
                    SELECT 
                        id
                    FROM
                        sintoma
                    WHERE
                        nombre IN(
                            " + values + "
                        )
                )
            GROUP BY
                c.id_enfermedad
            ORDER BY
                COUNT(*) DESC,
                e.nombre
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
