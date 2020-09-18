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

    Public Function CrearAdministrativo(Nombre As String, Tipo)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
           .Nombre = Nombre
           }
        Return u.NuevoAdministrativo()

    End Function
    Public Function CrearMedico(Nombre As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre
        }
        Return u.NuevoMedico()
    End Function

    Public Function CrearPaciente(FechaNacimiento As String, Sexo As String, Medicacion As List(Of String), EnfermedadCronica As List(Of String))

        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicacion,
            .EnfermedadCronica = EnfermedadCronica
        }
        Return u.NuevoPaciente()
    End Function
End Module
