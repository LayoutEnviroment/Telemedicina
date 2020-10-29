Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorGenera

    <TestMethod()> Public Sub TestObtenerIdEnfermedadGenerada()

        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerIdEnfermedadGenerada()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreEnfermedad()
        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerNombreEnfermedad("2")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreSintomas()
        Dim resultado As Boolean
        Try
            ControladorGenera.ObtenerNombreSintomas("1")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub


End Class