Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloChat

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim c As New ModeloChat("1111", "Todes123") With {
        .Cedula = "1111",
        .IdDiagnostico = "4"
        }

        Dim resultado As Boolean
        Try
            c.EnviarSolicitud()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim c As New ModeloChat("22223334", "Medico123")
        Dim consultaOk As Boolean

        Try
            c.BuscarSolicitud()
            consultaOk = True
        Catch ex As Exception
            consultaOk = False
        End Try
        Assert.IsTrue(consultaOk)
    End Sub
    <TestMethod()> Public Sub TestAceptarSolicitud()

    End Sub
    <TestMethod()> Public Sub TestEnviarMensajePaciente()

    End Sub
    <TestMethod()> Public Sub TestEnviarMensajeMedico()

    End Sub
    <TestMethod()> Public Sub TestBuscarMensajesNuevos()


    End Sub
    <TestMethod()> Public Sub TestMarcarComoLeido()


    End Sub
    <TestMethod()> Public Sub TestFinalizarChatPaciente()

    End Sub
    <TestMethod()> Public Sub TestFinalizarChat()


    End Sub
    <TestMethod()> Public Sub TestFinalizarChatMedico()

    End Sub
    <TestMethod()> Public Sub TestMarcarComoFinalizado()


    End Sub
    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()

    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()

    End Sub
End Class