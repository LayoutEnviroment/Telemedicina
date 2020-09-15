Public Class ModeloUsuario
    Inherits ModeloBaseDeDatos

    Public Sub New(user As String, pass As String)
        MyBase.New(user, pass)
    End Sub

    Public Nombre As String
    Public Apellido As String
    Public CI As String
    Public Mail As String
    Public FechaNacimiento As String
    Public Sexo As String
    Public EnfermedadCronica As List(Of String)
    Public Medicacion As List(Of String)

    Public Function NuevoAdministrativo()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Try

                Command.CommandText = "INSERT INTO persona (ci, nombre, apellido, mail, activo)
                          VALUES('" + Me.CI + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "','1')"
                Command.ExecuteNonQuery()

                Command.CommandText = "INSERT INTO administrativo (ci)
                          VALUES('" + Me.CI + "')"
                Command.ExecuteNonQuery()

                Command.CommandText = "COMMIT"
                Command.ExecuteNonQuery()


                Return 1
            Catch ex As Exception
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()

                Return 2
            End Try
        Catch ex As Exception
            Return 3
        End Try
    End Function

    Public Function NuevoMedico()
        Try
            Command.CommandText = "SET AUTOCOMMIT = OFF"
            Command.ExecuteNonQuery()
            Command.CommandText = "START TRANSACTION"
            Command.ExecuteNonQuery()

            Try
                Command.CommandText = "INSERT INTO persona (ci, nombre, apellido, mail)
                          VALUES('" + Me.CI + "','" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
                Command.ExecuteNonQuery()

                Command.CommandText = "INSERT INTO medico (ci)
                          VALUES('" + Me.CI + "')"
                Command.ExecuteNonQuery()

                Command.CommandText = "COMMIT"
                Command.ExecuteNonQuery()
                Return 1
            Catch ex As Exception
                Command.CommandText = "ROLLBACK"
                Command.ExecuteNonQuery()
                Return 2
            End Try
        Catch ex As Exception
            Return 3
        End Try
    End Function

    Public Function NuevoPaciente()

    End Function

End Class
