Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSesion

    <TestMethod()> Public Sub TestSesion()
        Dim resultado As Boolean
        Try
            ControladorSesion.User = "admin"
            ControladorSesion.Pass = 3
            ControladorSesion.Cedula = 3
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)

    End Sub

End Class