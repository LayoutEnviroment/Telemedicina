Imports CapaDeDatos

Public Module ControladorLogin

    Public Function Autentificar(usuario As String, contra As String)
        Dim l As New ModeloLogin(usuario, contra) With {
            .Cedula
        }

        Return l.ObtenerRol()

    End Function

End Module
