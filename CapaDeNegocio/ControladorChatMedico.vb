Imports CapaDeDatos

Public Module ControladorChatMedico



    Public Function BuscarSolicitud()
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass)
        Return c.BuscarSolicitud

    End Function




End Module
