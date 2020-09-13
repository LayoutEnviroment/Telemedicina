Imports CapaDeDatos

Public Module ControladorPaciente

    Public Function ObtenerNombre()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerNombre()
    End Function

    Public Function ObtenerTodo()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerPersonaSexoNacimineto()
    End Function

    Public Function ObtenerMedicaciones()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerMedicaciones()
    End Function

    Public Function ObtenerEnfermedades()
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass)

        Return p.ObtenerEnfermedades()
    End Function

End Module
