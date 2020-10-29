Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloLogin

    <TestMethod()> Public Sub TestObtenerRol()
        Dim resultado As Boolean
        Dim l As New ModeloLogin("11112223", "Admin123") With {
          .Cedula = "11112223"
       }

        Try

            l.ObtenerRol("1")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class