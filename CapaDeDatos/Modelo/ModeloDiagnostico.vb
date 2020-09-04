Public Class ModeloDiagnostico
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

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
                Try
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
                             " + Me.IdEnfermedad + "
                            )
                    "
                        Command.ExecuteNonQuery()
                    Next

                    Command.CommandText = "COMMIT"
                    Command.ExecuteNonQuery()
                    Command.CommandText = "UNLOCK TABLES"
                    Command.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox("Error en insert genera")
                    MsgBox(ex.ToString)
                End Try

            Catch ex As Exception
                MsgBox("Error en diagnostcio")
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()
                Command.CommandText = "UNLOCK TABLES"
                Command.ExecuteNonQuery()
            End Try
        Catch ex As Exception
            MsgBox("Error en transaccion")
        End Try

    End Sub

    Public Function ObtenerId()
        Command.CommandText = "
            SELECT
                MAX(id)
            FROM
                diagnostico
            "

        Return Command.ExecuteScalar.ToString()

    End Function

End Class
