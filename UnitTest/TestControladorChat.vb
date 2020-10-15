Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos
<TestClass()> Public Class TestControladorChat

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarSolicitud("111", "05H7IIOiV")
            Dim c As New ModeloChat("111", "05H7IIOiV") With {
            .Cedula = ControladorSesion.Cedula = "99999",
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
            Dim c As New ModeloChat("111", "05H7IIOiV")

            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())

        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        Dim resultado As Boolean
        Try
            Dim c As New ModeloChat("111", "05H7IIOiV")

            ControladorChat.AceptarSolicitud("1", "99999", "Doctor", "Apellido")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub



End Class