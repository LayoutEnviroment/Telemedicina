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

    Public Function TodosMisDiagnosticos()
        Command.CommandText = "
            SELECT
                Id,
                Fecha
            FROM
                diagnostico
            WHERE
                pertenece = " + Me.Pwd + "
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
                DISTINCT(s.nombre)
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

    Public Function ExistenMensajes()
        Command.CommandText = "
            SELECT 0 = (
                SELECT 
                    count(id_diagnostico) 
                FROM 
                    atiende
                WHERE 
                    id_diagnostico = " + Me.Id + ")
            "

        Return Command.ExecuteScalar.ToString
    End Function
End Class
