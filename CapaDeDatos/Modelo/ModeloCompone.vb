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

End Class
