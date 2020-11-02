Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSesion

    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestSesion()
        Resultado = False
        Try
            ControladorSesion.User = 1111
            ControladorSesion.Pass = "Todes123_"
            ControladorSesion.Cedula = 1111
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

End Class