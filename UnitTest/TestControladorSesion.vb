Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSesion

    <TestMethod()> Public Sub TestSesion()
        Dim resultado As Boolean
        Try
            ControladorSesion.User = 1111
            ControladorSesion.Pass = "Todes123"
            ControladorSesion.Cedula = 1111
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try
        Assert.IsTrue(resultado)

    End Sub

End Class