Imports CapaDeDatos

Public Module ControladorChat

    Public Sub EnviarSolicitud(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarSolicitud()
    End Sub

    Public Function BuscarSolicitud()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)

        Return c.BuscarSolicitud
    End Function

    Public Sub AceptarSolicitud(id As String, destinatario As String, nombre As String, apellido As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiPaciente = destinatario,
            .MiNombre = nombre,
            .MiApellido = apellido
        }

        c.AceptarSolicitud()
    End Sub

    Public Sub EnviarMensajePaciente(id As String, mensaje As String, paciente As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .CiMedico = paciente,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarMensajePaciente()
    End Sub

    Public Sub EnviarMensajeMedico(id As String, mensaje As String, paciente As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Mensaje = mensaje,
            .CiPaciente = paciente,
            .Cedula = ControladorSesion.Cedula
        }

        c.EnviarMensajePaciente()
    End Sub

    Public Function BuscarMensajesNuevos(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        Return c.BuscarMensajesNuevos
    End Function

    Public Sub MarcarComoLeido(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .Cedula = ControladorSesion.Cedula
        }

        c.MarcarComoLeido()
    End Sub

    Public Sub FinalizarChatPaciente(id As String, ci As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiMedico = ci,
            .Cedula = ControladorSesion.Cedula
        }

        c.FinalizarChatPaciente()
    End Sub

    Public Sub FinalizarChat(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)

        c.FinalizarChat(id)
    End Sub

    Public Sub FinalizarChatMedico(id As String, ci As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id,
            .CiPaciente = ci,
            .Cedula = ControladorSesion.Cedula
        }

        c.FinalizarChatPaciente()
    End Sub

    Public Sub MarcarComoFinalizado(id As String)
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        c.MarcarComoFinalizado()
    End Sub

    Public Function ObtenerMiNombreApellido()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)

        Return c.ObtenerMiNombreApellido()
    End Function

    Public Function ObtenerIdFechaMisChat()
        Dim c As New ModeloChat(ControladorSesion.User, ControladorSesion.Pass)

        Return c.ObtenerIdFechaMisChat()
    End Function

    Public Function ObtenerMensajesDelDiagnostico(id As String)
        Dim c As New ModeloChatPaciente(ControladorSesion.User, ControladorSesion.Pass) With {
            .IdDiagnostico = id
        }

        Return c.ObtenerMensajesDelDiagnostico()
    End Function

End Module
