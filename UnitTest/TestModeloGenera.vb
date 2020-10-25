Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloGenera

    <TestMethod()> Public Sub TestObtenerEnfermedadGenerada()
        Dim resultado As Boolean
        Dim g As New ModeloGenera("1111", "Todes123") With {
           .Cedula = "1111"
       }

        Try
            g.ObtenerEnfermedadGenerada()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreEnfermedad()
        Dim resultado As Boolean
        Dim g As New ModeloGenera("1111", "Todes123") With {
           .IdDiagnostico = "4"
       }

        Try
            g.ObtenerNombreEnfermedad()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreSintomas()

        Dim resultado As Boolean
        Dim g As New ModeloGenera("1111", "Todes123") With {
           .IdDiagnostico = "4"
       }

        Try
            g.ObtenerNombreSintomas()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub






End Class