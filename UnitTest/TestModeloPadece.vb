Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloPadece

    <TestMethod()> Public Sub TestGuardarPadecimientos()
        Dim resultado As Boolean
        Dim listaPrueba As New List(Of String) From {
            "Sintoma de prueba"
            }
        Dim p As New ModeloPadece("11112223", "Admin123") With {
            .ListadoSintomas = listaPrueba,
            .Cedula = "1111"
        }

        Try
            p.GuardarPadecimientos()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class