Public Class ModeloDiagnostico
    Inherits ModeloBaseDeDatos

    Public IdSintomas As List(Of String)
    Public IdEnfermedad As String

    Public Sub Nuevo()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()
            'Command.CommandText = "LOCK TABLE Diagnostico READ"
            'Command.ExecuteNonQuery()
            'Command.CommandText = "LOCK TABLE Diagnostico WRITE"
            'Command.ExecuteNonQuery()
            Try
                Command.CommandText = "
                    INSERT INTO
                        diagnostico(fecha)
                    VALUES(
                        CURDATE())
                "
                Command.ExecuteNonQuery()

                Dim values = String.Join(",", IdSintomas.Select(Function(f) String.Format("'{0}'", f)).ToArray())
                For Each sintoma In IdSintomas
                    Command.CommandText = "
                        INSERT INTO
                            genera(id_diagnostico, id_sintoma_compone, id_enfermedad_compone)
                        VALUES
                            ((SELECT
                                MAX(id)
                             FROM
                                diagnostico),
                             (SELECT
                                id
                              FROM
                                sintoma
                              WHERE
                                nombre = '" + sintoma + "'),
                             (SELECT
                                id
                              FROM
                                enfermedad
                              WHERE
                                nombre = '" + Me.IdEnfermedad + "')
                            )
                    "
                    Command.ExecuteNonQuery()
                Next

                Command.CommandText = "COMMIT"
                Command.ExecuteNonQuery()
                MsgBox("Commit")
            Catch ex As Exception
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()
                MsgBox(ex.ToString)
            End Try

        Catch ex As Exception
            MsgBox("Error en transcaccion")
        End Try
        Command.CommandText = "UNLOCK TABLES"
        Command.ExecuteNonQuery()

    End Sub


End Class
