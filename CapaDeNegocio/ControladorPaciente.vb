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

    Public Sub CambiarDatos(nombre As String,
                            apellido As String,
                            correo As String,
                            sexo As String,
                            fecha As String,
                            enfermedades As List(Of String),
                            medicaciones As List(Of String))
        Dim p As New ModeloPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = nombre,
            .Apellido = apellido,
            .Mail = correo,
            .Sexo = sexo,
            .FechaNacimiento = fecha,
            .Enfermedades = enfermedades,
            .Medicaciones = medicaciones
        }

        p.CambiarDatos()
    End Sub
End Module
