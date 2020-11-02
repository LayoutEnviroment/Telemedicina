Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorGenera
    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly Diagnostico As String = "21"
    Dim Resultado As Boolean = False


    <TestMethod()> Public Sub TestObtenerIdEnfermedadGenerada()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorGenera.ObtenerIdEnfermedadGenerada()
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreEnfermedad()
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorGenera.ObtenerNombreEnfermedad(Diagnostico)
            Resultado = True
        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreSintomas()
        Resultado = False

        Try
            ControladorGenera.ObtenerNombreSintomas(5)
            Resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(Resultado)

    End Sub


End Class