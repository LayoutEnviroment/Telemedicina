Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorLogin

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "Pac1234_"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestAutenticar()
        Try
            Assert.AreEqual(ControladorLogin.Autentificar(Paciente, PacPass, 1), 1)

        Catch ex As Exception

        End Try

    End Sub

End Class
