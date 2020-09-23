Imports CapaDeDatos

Public Module ControladorUsuario

    Public Function CrearPersona(Nombre As String, Apellido As String, CI As String, Mail As String, TipoUsuario() As Boolean, FechaNacimiento As String, Sexo As String, EnfermedadesCronicas As List(Of String), Medicamentos As List(Of String))
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass) With {
            .Nombre = Nombre,
            .Apellido = Apellido,
            .CI = CI,
            .Mail = Mail,
            .FechaNacimiento = FechaNacimiento,
            .Sexo = Sexo,
            .Medicacion = Medicamentos,
            .EnfermedadCronica = EnfermedadesCronicas,
            .TipoDeUsuario = TipoUsuario
        }
        Return u.NuevaPersona()


    End Function

    Public Function ObtenerCorreo()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        Return u.ObtenerCorreo()
    End Function

    Public Function ObtenerNombreApellidoCedula()
        Dim u As New ModeloUsuario(ControladorSesion.User, ControladorSesion.Pass)

        Return u.ObtenerNombreApellidoCedula
    End Function
End Module
