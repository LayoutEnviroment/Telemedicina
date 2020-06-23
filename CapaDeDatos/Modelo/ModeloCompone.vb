Public Class ModeloCompone
    Inherits ModeloBaseDeDatos

    Public IdSintomas As New List(Of String)
    Public IdEnfermedad As String

    Public Function EnfermedadesPosibles()
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())
        Dim Nombre As String = String.Format("({0})", values)
        MsgBox(IdSintomas.ToString)
        MsgBox(values)
        MsgBox(Nombre)
        Command.CommandText = "         
            SELECT
                c.id_enfermedad_compone,
                e.nombre AS Enfermedad,
                group_concat(s.Nombre SEPARATOR ',') AS Sintomas,
                COUNT(*)
            FROM
                compone c
                JOIN
                sintoma s ON c.id_sintoma_compone = s.id_sintoma
                JOIN
                enfermedad e ON c.id_enfermedad_compone = e.id_enfermedad
            WHERE
                c.id_sintoma_compone IN (
                    SELECT 
                        id_sintoma
                    FROM
                        sintoma
                    WHERE
                        nombre IN(
                            " + values + "
                        )
                )
            GROUP BY
                c.id_enfermedad_compone
                ORDER BY
            COUNT(*) DESC,
                e.nombre"

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Sub Insertar()
        Try
            For Each Nombre In IdSintomas
                'MsgBox("Variables:" + IdEnfermedad + "," + IdSintomas.Item(0).ToString)
                Command.CommandText = "
            INSERT INTO
                compone(id_sintoma_compone, id_enfermedad_compone)
            VALUES
                ((SELECT
                    id_sintoma
                  FROM
                    sintoma
                  WHERE
                    nombre = '" + Nombre + "'),
                  (SELECT
                    id_enfermedad
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
