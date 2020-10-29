Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorLogin

    <TestMethod()> Public Sub TestAutenticar()
        Dim resultado As Boolean
        Try
            Assert.IsTrue(ControladorLogin.Autentificar("1111", "Todes123", "3"))
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
    End Sub

End Class
