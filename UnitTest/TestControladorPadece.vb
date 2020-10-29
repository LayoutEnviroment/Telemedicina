Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorPadece

    <TestMethod()> Public Sub TestGuardarSintomasPadecidos()

        Dim resultado As Boolean
        Dim sintomasPadecidosTest As New List(Of String)
        sintomasPadecidosTest.Add("Sintoma de prueba")

        Try
            ControladorPadece.GuardarSintomasPadecidos(sintomasPadecidosTest)
            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)

        End Try

        Assert.IsTrue(resultado)

    End Sub

End Class