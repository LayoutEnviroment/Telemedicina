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
            ControladorChat.AceptarSolicitud("1", "1234", "Doctor", "Apellido")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub



End Class