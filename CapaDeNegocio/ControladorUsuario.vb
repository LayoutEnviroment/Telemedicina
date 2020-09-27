Imports CapaDeDatos

Public Module ControladorUsuario

    Public Function CrearPersona(Nombre As String, Apellido As String, CI As String, Mail As String, TipoUsuario() As Boolean, FechaNacimiento As String, Sexo As String, EnfermedadesCronicas As List(Of String), Medicamentos As List(Of String), Contra As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail,
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicamentos,
            .EnfermedadCronica = EnfermedadesCronicas,
            .TipoDeUsuario = TipoUsuario,
            .Password = Contra
        }
        Return u.NuevaPersona()


    End Function

    Public Function ObtenerCorreo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }

        Return u.ObtenerCorreo()
    End Function

    Public Function ObtenerNombreApellidoCedula()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }

        Return u.ObtenerNombreApellidoCedula
    End Function

    Public Function ObtenerCedula()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCedula()
    End Function
    Public Function ObtenerCedulaMedico()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiMedico()
    End Function
    Public Function ObtenerCedulaAdministrativo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        Return u.ObtenerCiAdministrador()
    End Function

    Public Function ObtenerNombre()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .CI = ControladorSesion.Cedula
        }

        Return u.ObtenerNombre()
    End Function

    Public Function TraerDatosDeMedico(Ci As String)
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)
        u.CI = Ci
        Return u.TraerDatosDoctor()

    End Function
End Module
