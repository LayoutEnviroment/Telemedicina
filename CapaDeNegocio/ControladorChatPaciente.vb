Imports CapaDeDatos

Public Module ControladorChatPaciente

    Public Sub EnviarSolicitud(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }
        c.EnviarSolicitud()
    End Sub

    Public Sub EnviarMensaje(id As String, mensaje As String, destinatario As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .Destinatario = destinatario
        }

        c.EnviarMensaje()
    End Sub

    Public Function BuscarMensajesNuevos(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return c.BuscarMensajesNuevos
    End Function

    Public Sub MarcarComoLeido(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        c.MarcarComoLeido()
    End Sub

    Public Sub FinalizarChat(id As String, destinatario As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Destinatario = destinatario
        }

        c.FinalizarChat()
    End Sub

    Public Sub MarcarComoFinalizado(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        c.MarcarComoFinalizado()
    End Sub
End Module
