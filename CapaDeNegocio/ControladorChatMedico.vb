Imports CapaDeDatos

Public Module ControladorChatMedico

    Public Function BuscarSolicitud()
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass)
        Return c.BuscarSolicitud

    End Function

    Public Function ObtenerMiNombreApellido()
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass)

        Return c.ObtenerMiNombreApellido()
    End Function

    Public Sub AceptarSolicitud(id As String, destinatario As String, nombre As String, apellido As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Destinatario = destinatario,
            .MiNombre = nombre,
            .MiApellido = apellido
        }

        c.AceptarSolicitud()

    End Sub

    Public Sub EnviarMensaje(id As String, mensaje As String, paciente As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .Destinatario = paciente
        }

        c.EnviarMensaje()
    End Sub

    Public Function BuscarMensajesNuevos(id As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return c.BuscarMensajesNuevos
    End Function

    Public Sub FinalizarChat(id As String, ci As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Destinatario = ci
        }

        c.FinalizarChat()
    End Sub

    Public Sub MarcarComoLeido(id As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        c.MarcarComoLeido()
    End Sub

    Public Sub MarcarComoFinalizado(id As String)
        Dim c As New ModeloChatMedico(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        c.MarcarComoFinalizado()
    End Sub
End Module
