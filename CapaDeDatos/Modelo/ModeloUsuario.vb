Public Class ModeloUsuario
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub


    Public TipoDeUsuario(3) As Boolean
    Public Nombre As String
    Public Apellido As String
    Public CI As String
    Public Mail As String
    Public FechaNacimiento As String
    Public Sexo As String
    Public EnfermedadCronica As List(Of String)
    Public Medicacion As List(Of String)

    Public Function NuevaPersona()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Try

                Command.CommandText = "INSERT INTO persona (ci, nombre, apellido, mail, activo)
                          VALUES('" + Me.CI + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')"
                Command.ExecuteNonQuery()

                Command.CommandText = "CREATE USER '" + Me.Mail + "'@'localhost' identified by '" + Me.CI + "'"
                Command.ExecuteNonQuery()
                MsgBox("cree user")
                MsgBox(TipoDeUsuario(1).ToString)

                If Me.TipoDeUsuario(3) = True Then
                    MsgBox("entre al if administrador")
                    Command.CommandText = "INSERT INTO administrativo (ci_persona)
                          VALUES('" + Me.CI + "')"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "INSERT INTO roles (ci_persona, usuario, rol)
                          VALUES('" + Me.CI + "','" + Me.Mail + "', 3)"
                    Command.ExecuteNonQuery()
                    MsgBox("cree roles")

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             *.*
                                        TO
                                       '" + Me.Mail + "'@'localhost' WITH GRANT OPTION"
                    Command.ExecuteNonQuery()
                    MsgBox("le di privilegios")
                    Command.CommandText = "FLUSH PRIVILEGES"
                    Command.ExecuteNonQuery()
                End If
                If Me.TipoDeUsuario(2) = True Then
                    Command.CommandText = "INSERT INTO medico (ci_persona)
                          VALUES('" + Me.CI + "')"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "INSERT INTO roles (ci_persona, usuario, rol)
                          VALUES('" + Me.CI + "', '" + Me.Mail + "', 2)"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             *.*
                                        TO
                                       '" + Me.Mail + "'@'localhost'"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "FLUSH PRIVILEGES"
                    Command.ExecuteNonQuery()
                End If

                If Me.TipoDeUsuario(1) = True Then
                    MsgBox("entre a crear usuario paciente")

                    Command.CommandText = "INSERT INTO paciente (ci_persona, sexo, fecha_nac, activo)
                          VALUES('" + Me.CI + "','" + Me.Sexo + "','" + Me.FechaNacimiento + "',1)"
                    Command.ExecuteNonQuery()

                    For Each Enfermedad In EnfermedadCronica

                        Command.CommandText = "INSERT INTO enfermedades_cronicas (ci_persona_paciente, enfermedad)
                          VALUES('" + Me.CI + "','" + Enfermedad + "')"
                        Command.ExecuteNonQuery()
                    Next

                    For Each Medicamento In Medicacion

                        Command.CommandText = "INSERT INTO medicaciones (ci_persona_paciente, medicacion)
                          VALUES('" + Me.CI + "','" + Medicamento + "')"
                        Command.ExecuteNonQuery()
                    Next

                    Command.CommandText = "INSERT INTO roles (ci_persona, usuario, rol)
                          VALUES('" + Me.CI + "','" + Me.Mail + "', 1)"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             *.*
                                        TO
                                       '" + Me.Mail + "'@'localhost'"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "FLUSH PRIVILEGES"
                    Command.ExecuteNonQuery()
                Else

                    Command.CommandText = "ROLLBACK"
                    Command.ExecuteNonQuery()

                End If
                Command.CommandText = "COMMIT"
                Command.ExecuteNonQuery()


                Return 1
            Catch ex As Exception
                MsgBox(ex.ToString)
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()

                Return 2
            End Try
        Catch ex As Exception
            MsgBox(ex.ToString)
            Command.CommandText = "ROLLBACK"
            Command.ExecuteNonQuery()

            Return 3
        End Try
    End Function


    Public Function ObtenerCorreo()
        Command.CommandText = "
            SELECT
                mail
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Return Command.ExecuteScalar.ToString()
    End Function

    Public Function ObtenerNombre()
        MsgBox(Me.CI)
        Command.CommandText = "
            SELECT
                nombre
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Return Command.ExecuteScalar.ToString
    End Function

    Public Function ObtenerNombreApellidoCedula()
        Command.CommandText = "
            SELECT
                nombre,
                apellido,
                ci
            FROM
                persona
            WHERE
                ci = " + Me.CI + "
        "
        Reader = Command.ExecuteReader()
        Return Reader
    End Function

    Public Function ObtenerCedula()
        Command.CommandText = "
            SELECT
                p.ci
            FROM
                persona p
                    JOIN
                        roles r
                            ON 
                                p.ci = r.ci_persona
            WHERE
                r.usuario = '" + Me.Uid + "'
        "

        Return Command.ExecuteScalar.ToString
    End Function

End Class
