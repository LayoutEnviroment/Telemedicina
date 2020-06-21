Public Class ModeloCompone
    Inherits ModeloBaseDeDatos

    Public IdSintomas As New List(Of String)
    Public IdEnfermedad As String

    Public Function EnfermedadesPosibles()
        Command.CommandText = "SELECT"
        Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())
        Dim Where As String = String.Format("WHERE c.id_sintoma_compone IN ({0})", values)
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
            " + Where + "
            GROUP BY
                c.id_enfermedad_compone
                ORDER BY
            COUNT(*) DESC,
                e.nombre 
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

End Class
