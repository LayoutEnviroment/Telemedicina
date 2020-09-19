Imports CapaDeDatos

Public Module ControladorUsuario

    Public Function CrearPersona(Nombre As String, Apellido As String, CI As String, Mail As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail
        }
        Return u.NuevaPersona()


    End Function

    Public Function CrearAdministrativo(Nombre As String, UsuarioAdministrador As Boolean)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
           .Nombre = Nombre,
           .RolDeAdministrador = UsuarioAdministrador
           }
        Return u.NuevaPersona()

    End Function
    Public Function CrearMedico(Nombre As String, UsuarioMedico As Boolean)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .RolDeMedico = UsuarioMedico
        }
        Return u.NuevaPersona()
    End Function

    Public Function CrearPaciente(FechaNacimiento As String, Sexo As String, Medicacion As List(Of String), EnfermedadCronica As List(Of String), UsuarioPaciente As Boolean)

        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicacion,
            .EnfermedadCronica = EnfermedadCronica,
            .RolDePaciente = UsuarioPaciente
        }
        Return u.NuevaPersona()
    End Function
End Module
