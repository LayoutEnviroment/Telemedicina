Imports CapaDeDatos

Public Module ControladorLogin

    Public Function Autentificar(User As String, Pass As String, rol As String)
        Dim l As New ModeloLogin(User, Pass) With {
            .Cedula = User
        }
        Try
            Return l.ObtenerRol(rol)
            Return True

        Catch ex As Exception
            Return False

        End Try


    End Function


End Module
