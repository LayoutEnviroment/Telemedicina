Imports CapaDeDatos

Public Module ControladorUsuario

    Public Function CrearAdministrativo(Nombre As String, Apellido As String, CI As String, Mail As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail
        }
        Return u.NuevoAdministrativo()


    End Function

    Public Function CrearMedico(Nombre As String, Apellido As String, CI As String, Mail As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail
        }
        Return u.NuevoMedico()
    End Function

    Public Function CrearPaciente(CI As String, FechaNacimiento As String, Sexo As String, Medicacion As List(Of String), EnfermedadCronica As List(Of String))

        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = CI,
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicacion,
            .EnfermedadCronica = EnfermedadCronica
        }
        Return u.NuevoPaciente()
    End Function

    Public Function ObtenerCorreo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        u.ObtenerCorreo()

    End Function

End Module
