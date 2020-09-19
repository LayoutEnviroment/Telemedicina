Public Class ModeloUsuario
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public RolDeMedico As Boolean
    Public RolDePaciente As Boolean
    Public RolDeAdministrador As Boolean
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

                If Me.RolDeAdministrador = True Then


                    Command.CommandText = "INSERT INTO administrativo (ci_persona)
                          VALUES('" + Me.CI + "')"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "INSERT INTO roles (ci_persona, rol)
                          VALUES('" + Me.CI + "',3)"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "CREATE USER '" + Me.Mail + "'@'localhost' identified by '" + Me.CI + "'"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             bd_led.*
                                        TO
                                       '" + Me.Mail + "'@'localhost'
                                        FLUSH PRIVILEGES"
                    Command.ExecuteNonQuery()
                End If
                If Me.RolDeMedico = True Then
                    Command.CommandText = "INSERT INTO medico (ci_persona)
                          VALUES('" + Me.CI + "')"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "INSERT INTO roles (ci_persona, rol)
                          VALUES('" + Me.CI + "',2)"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "CREATE USER '" + Me.Mail + "'@'localhost' identified by '" + Me.CI + "'"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             bd_led.*
                                        TO
                                       '" + Me.Mail + "'@'localhost'
                                        FLUSH PRIVILEGES"
                    Command.ExecuteNonQuery()
                End If

                If Me.RolDePaciente = True Then
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

                    Command.CommandText = "INSERT INTO roles (ci_persona, rol)
                          VALUES('" + Me.CI + "',1)"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "CREATE USER '" + Me.Mail + "'@'localhost' identified by '" + Me.CI + "'"
                    Command.ExecuteNonQuery()

                    Command.CommandText = "GRANT
                                        ALL
                                        ON
                                             bd_led.*
                                        TO
                                       '" + Me.Mail + "'@'localhost'
                                        FLUSH PRIVILEGES"
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
            Return 3
        End Try
    End Function


End Class
