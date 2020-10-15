Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos
<TestClass()> Public Class TestControladorChat

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim resultado As Boolean

        Try
            ControladorChat.EnviarSolicitud("1")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try


    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim TablaEsperada As New DataTable
        Dim c As New ModeloChat("12223334", "yKI9SAAB5")
        Try
            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())

        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        Dim resultado As Boolean
        Try
            ControladorChat.AceptarSolicitud("2", "45556667", "doctor", "test")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajePaciente(2, "haré cualquiera", "12223334")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajePaciente(2, "como el tester", "45556667")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
    End Sub
    <TestMethod()> Public Sub TestBuscarMensajesNuevoConId()
        Dim TablaEsperada As New DataTable
        Assert.AreSame(ControladorChat.BuscarMensajesNuevo.GetType(), TablaEsperada.GetType())

    End Sub

    '<TestMethod()> Public Sub TestBuscarMensajesNuevo()
    '    Dim TablaEsperada As New DataTable
    '    Assert.AreSame(ControladorChat.BuscarMensajesNuevo.GetType(), TablaEsperada.GetType())

    'End Sub

    <TestMethod()> Public Sub TestMarcarComoLeido()
        Dim resultado As Boolean
        Try
            ControladorChat.MarcarComoLeido(1)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestFinalizarChatPaciente()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChatPaciente(2, "12223334")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

    End Sub

    <TestMethod()> Public Sub TestFinalizarChat()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChat(2)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChatMedico(2, "45556667")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

    End Sub
End Class