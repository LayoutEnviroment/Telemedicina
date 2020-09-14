Public Class ModeloPaciente
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Enfermedades As List(Of String)
    Public Medicaciones As List(Of String)
    Public Sexo As String
    Public FechaNacimiento As String


    Public Function ObtenerNombre()
        Command.CommandText = "
            SELECT
                nombre
            FROM
                persona
            WHERE ci = " + Me.Pwd + "
        "
        Return Command.ExecuteScalar.ToString()

    End Function

    Public Function ObtenerPersonaSexoNacimineto()
        Command.CommandText = "
            SELECT
                p.ci,
                p.nombre,
                p.apellido,
                p.mail,
                pa.sexo,
                pa.fecha_nac
            FROM
                persona p
                    JOIN
                        paciente pa
                            ON 
                                p.ci = pa.ci_persona
            WHERE
                p.ci = " + Me.Pwd + "
            "
        Reader = Command.ExecuteReader()
        Return Reader

    End Function

    Public Function ObtenerMedicaciones()
        Command.CommandText = "
            SELECT
                medicacion
            FROM
                medicaciones
            WHERE
                ci_persona_paciente = " + Me.Pwd + "
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerEnfermedades()
        Command.CommandText = "
            SELECT
                enfermedad
            FROM
                enfermedades_cronicas
            WHERE
                ci_persona_paciente = " + Me.Pwd + "
        "

        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Sub CambiarDatos(nombre As String, apellido As String, correo As String)
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Try
                Command.CommandText = "
                    UPDATE
                        persona
                    SET
                        nombre = " + nombre + ",
                        apellido = " + apellido + "
                        mail = " + correo + "
                    WHERE
                        ci = " + Me.Pwd + "
                "
                Command.ExecuteNonQuery()

                Try
                    Command.CommandText = "
                        UPDATE
                            paciente
                        SET
                            sexo = " + Me.Sexo + ",
                            fecha_nac = " + Me.FechaNacimiento + "
                        WHERE
                            ci_persona = " + Me.Pwd + "
                    "
                    Command.ExecuteNonQuery()

                    Try
                        Command.CommandText = "
                            DELETE FROM
                                enfermedades_cronicas
                            WHERE
                                ci_persona_paciente = " + Me.Pwd + "
                        "
                        Command.ExecuteNonQuery()

                        Try
                            Command.CommandText = "
                            DELETE FROM
                                medicaciones
                            WHERE
                                ci_persona_paciente = " + Me.Pwd + "
                        "
                            Command.ExecuteNonQuery()

                            Try
                                Dim values = String.Join(",", Enfermedades.Select(Function(f) String.Format("'{0}'", f)).ToArray())
                                For Each enfermedad In Enfermedades
                                    Command.CommandText = "
                                        INSERT INTO
                                            enfermedades_cronicas(ci_persona_paciente, enfermedad)
                                        VALUES
                                            (" + Me.Pwd + ", '" + enfermedad + "')
                                    "
                                    Command.ExecuteNonQuery()
                                Next

                                Try
                                    Dim valores = String.Join(",", Medicaciones.Select(Function(f) String.Format("'{0}'", f)).ToArray())
                                    For Each medicacion In Medicaciones
                                        Command.CommandText = "
                                        INSERT INTO
                                            medicaciones(ci_persona_paciente, medicacion)
                                        VALUES
                                            (" + Me.Pwd + ", '" + medicacion + "')
                                    "
                                        Command.ExecuteNonQuery()
                                    Next
                                Catch ex As Exception

                                End Try
                            Catch ex As Exception

                            End Try

                        Catch ex As Exception

                        End Try
                    Catch ex As Exception

                    End Try
                Catch ex As Exception

                End Try
            Catch ex As Exception

            End Try
        Catch ex As Exception

        End Try
    End Sub
End Class
