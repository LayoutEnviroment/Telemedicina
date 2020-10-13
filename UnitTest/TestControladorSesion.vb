Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSesion

    <TestMethod()> Public Sub TestSesion()
        Dim resultado As Boolean
        Try
            ControladorSesion.User = 49249605
            ControladorSesion.Pass = "EGUfabre924960"
            ControladorSesion.Cedula = 49249605
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)

    End Sub

End Class