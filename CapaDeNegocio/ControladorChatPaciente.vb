Imports CapaDeDatos

Public Module ControladorChatPaciente

    Public Sub EnviarSolicitud(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }
        c.EnviarSolicitud()
    End Sub

End Module
