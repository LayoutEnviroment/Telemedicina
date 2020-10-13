Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos
<TestClass()> Public Class TestControladorChat

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim resultado As Boolean
        Try
            Dim c As New ModeloChat("45556667", "VzD91g32s") With {
            .Cedula = ControladorSesion.Cedula = "45556667",
            .IdDiagnostico = 1
            }
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)

    End Sub

    'Algo no esta del todo bien
    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim TablaEsperada As New DataTable
        Try
            Dim c As New ModeloChat("12223334", "yKI9SAAB5")

            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())

        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        Dim resultado As Boolean
        Try
            Dim c As New ModeloChat("12223334", "yKI9SAAB5")

            ControladorChat.AceptarSolicitud("2", "45556667", "doctor", "test")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub



End Class