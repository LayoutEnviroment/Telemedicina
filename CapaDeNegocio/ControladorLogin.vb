Imports CapaDeDatos

Public Module ControladorLogin

    Public Function Autentificar(User As String, Pass As String)
        Dim l As New ModeloLogin(User, Pass)

        Return l.ObtenerRol()

    End Function


End Module
