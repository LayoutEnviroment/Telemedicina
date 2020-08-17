Imports CapaDeDatos

Public Module ControladorPaciente

    Public Function ObtenerNombre()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerNombre()
    End Function

End Module
