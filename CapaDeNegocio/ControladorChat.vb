Imports CapaDeDatos

Public Module ControladorChat

    Public Sub EnviarSolicitud(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }
        c.EnviarSolicitud()
    End Sub

    Public Function BuscarSolicitud()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)
        Return c.BuscarSolicitud

    End Function

    Public Sub EnviarMensaje(id As String, mensaje As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje
        }

        c.EnviarMensaje()
    End Sub

    Public Function BuscarMensajesNuevos(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return c.BuscarMensajesNuevos
    End Function
End Module
