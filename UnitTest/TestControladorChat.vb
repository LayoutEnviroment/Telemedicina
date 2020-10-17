Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos
<TestClass()> Public Class TestControladorChat

    <TestMethod()> Public Sub TestFinalizarChat()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChat("2")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarSolicitud("5")

            resultado = True

        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        Dim resultado As Boolean
        Try
            ControladorChat.AceptarSolicitud("1", "1111", "Doctor", "Apellido")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
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
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajeMedico(2, "como el tester", "45556667")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarMensajesNuevo()
        Dim resultado As Boolean
        Try
            ControladorChat.BuscarMensajesNuevos("1")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

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
            ControladorChat.FinalizarChatPaciente(2, "1111")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChatMedico(2, "1111")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

    End Sub

End Class