Public Class ModeloPaciente
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public CI As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String
    Public Sexo As String
    Public FechaNacimiento As String
    Public Enfermedades As List(Of String)
    Public Medicaciones As List(Of String)

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

    Public Sub CambiarDatos()
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
                        nombre = '" + Me.Nombre + "',
                        apellido = '" + Me.Apellido + "',
                        mail = '" + Me.Mail + "'
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
                            fecha_nac = '" + Me.FechaNacimiento + "'
                        WHERE
                            ci_persona = " + Me.Pwd + "
                    "
                    MsgBox(FechaNacimiento)
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
                                    MsgBox(enfermedad)
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

                                    Command.CommandText = "COMMIT"
                                    Command.ExecuteNonQuery()
                                Catch ex As Exception
                                    MsgBox("Error en insertar medicaciones" + ex.ToString)
                                End Try
                            Catch ex As Exception
                                MsgBox("Error en insertar enfermedades" + ex.ToString)
                            End Try
                        Catch ex As Exception
                            MsgBox("Error en borrar medicaciones" + ex.ToString)
                        End Try
                    Catch ex As Exception
                        MsgBox("Error en insertar enfermedades" + ex.ToString)
                    End Try
                Catch ex As Exception
                    MsgBox("Error en actualizar paciente" + ex.ToString)
                End Try
            Catch ex As Exception
                MsgBox("Error en actualizar personas" + ex.ToString)
            End Try
        Catch ex As Exception
            MsgBox("Error en iniciar transaccion" + ex.ToString)
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()
        End Try
    End Sub

    Public Function ObtenerCI()
        Command.CommandText = "
            SELECT
                ci_persona
            FROM
                paciente  
            WHERE
                activo = 1 "
       Reader = Command.ExecuteReader()
        Return Reader
    End Function
End Class
