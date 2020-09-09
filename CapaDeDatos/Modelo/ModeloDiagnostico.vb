Public Class ModeloDiagnostico
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public IdSintomas As List(Of String)
    Public IdEnfermedad As String
    Public Id As String

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
                        diagnostico(fecha, pertenece)
                    VALUES(
                        CURDATE(), " + Me.Pwd + ")
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
                MsgBox("Error en diagnostcio" + ex.ToString)
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
            WHERE
                pertenece = " + Me.Pwd + "
            "

        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function TodosLosDiagnosticos()
        MsgBox(Me.Pwd)
        Command.CommandText = "
            SELECT
                DISTINCT(d.Id),
                d.Fecha,
                e.Nombre
            FROM
                diagnostico d 
                    JOIN
                        atiende a 
                            ON  
                                d.id = a.id_diagnostico
                    JOIN
                        genera g
                            ON  
                                d.id = g.id_diagnostico
                    JOIN
                        compone c
                            ON
                                c.id_enfermedad = g.id_enfermedad_compone
                    JOIN
                        enfermedad e
                            ON
                                e.id = c.id_enfermedad
            WHERE
                d.pertenece = " + Me.Pwd + "
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function EnfermedadDiagnosticada()
        Command.CommandText = "
            SELECT
                e.nombre,
                e.prioridad,
                e.descripcion
            FROM
                enfermedad e 
                    JOIN
                        compone c
                            ON
                                e.id = c.id_enfermedad
                    JOIN
                        genera g
                            ON
                                c.id_enfermedad = g.id_enfermedad_compone
                    JOIN
                        diagnostico d
                            ON
                                g.id_diagnostico = d.id
            WHERE
                d.id = " + Me.Id + "
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function SintomasEnfermedadDiagnosticada()
        Command.CommandText = "
            SELECT 
                s.nombre
            FROM
                sintoma s
                    JOIN
                        compone c
                            ON
                                s.id = c.id_sintoma
                    JOIN
                        genera g
                            ON
                                c.id_sintoma = g.id_sintoma_compone
                    JOIN
                        diagnostico d
                            ON
                                g.id_diagnostico = d.id
            WHERE
                d.id = " + Me.Id + "
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function MedicoDiagnostico()
        Command.CommandText = "
            SELECT
                p.nombre,
                p.apellido
            FROM
                persona p
                    JOIN
                        medico m
                            ON
                                p.ci = m.ci_persona
                    JOIN   
                        atiende a
                            ON
                                m.ci_persona = a.ci_persona_medico
                    JOIN
                        diagnostico d
                            ON
                                a.id_diagnostico = d.id
            WHERE
                d.id = " + Me.Id + "
            LIMIT 
                1
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function MensajesDiagnostico()
        Command.CommandText = "
            SELECT
                a.mensaje,
                fecha_hora,
                destinatario
            FROM
                atiende a
                    JOIN
                        diagnostico d
                            ON
                                a.id_diagnostico = d.id
            WHERE
                d.id = " + Me.Id + "
        "

        Reader = Command.ExecuteReader()
        Return Reader

    End Function

End Class
