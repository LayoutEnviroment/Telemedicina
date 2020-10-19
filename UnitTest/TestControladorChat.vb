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
            MsgBox(ex.ToString)
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
            ControladorChat.AceptarSolicitud("1", "1111", "super", "pruebas")
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
            ControladorChat.EnviarMensajePaciente(2, "haré cualquiera", "1111")
            resultado = True
        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajeMedico(1, "como el tester", "33334445")
            resultado = True
        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
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

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Dim resultado As Boolean
        Try
            ControladorChat.FinalizarChatMedico(2, "1111")
            resultado = True
        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)
    End Sub

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

    <TestMethod()> Public Sub TestMarcarComoFinalizado()
        Dim resultado As Boolean
        Try
            ControladorChat.MarcarComoFinalizado("1")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()

        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.ObtenerIdFechaMisChat.GetType(), TablaEsperada.GetType())

        Catch ex As Exception

        End Try
    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()
        Dim resultado As Boolean
        Try
            ControladorChat.ObtenerMensajesDelDiagnostico(1)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
End Class