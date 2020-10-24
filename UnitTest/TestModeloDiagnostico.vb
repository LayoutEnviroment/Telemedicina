Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloDiagnostico

    <TestMethod()> Public Sub TestNuevo()
        Dim resultado As Boolean

        Dim sintomaPrueba As New List(Of String) From {
            "Sintoma de prueba"
        }
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .IdSintomas = sintomaPrueba,
            .IdEnfermedad = "8"
        }
        Try
            d.Nuevo()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub ObtenerId()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
     .Cedula = "1111"
  }
        Dim buscarInformacion As Boolean
        Try
            d.ObtenerId()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)

    End Sub

    <TestMethod()> Public Sub TestTodosMisDiagnosticos()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .Cedula = "1111"
        }
        Dim buscarInformacion As Boolean
        Try
            d.TodosMisDiagnosticos()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadDiagnosticada()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .Id = "4"
        }
        Dim buscarInformacion As Boolean
        Try
            d.EnfermedadDiagnosticada()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)

    End Sub

    <TestMethod()> Public Sub TestSintomasEnfermedadDiagnosticada()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .Id = "2"
        }
        Dim buscarInformacion As Boolean
        Try
            d.SintomasEnfermedadDiagnosticada()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)

    End Sub

    <TestMethod()> Public Sub TestMedicoDiagnostico()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .Id = "3"
        }
        Dim buscarInformacion As Boolean
        Try
            d.MedicoDiagnostico()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)

    End Sub

    <TestMethod()> Public Sub TestMensajesDiagnostico()
        Dim d As New ModeloDiagnostico("1111", "Todes123") With {
            .Id = "2"
        }
        Dim buscarInformacion As Boolean
        Try
            d.MensajesDiagnostico()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub

    <TestMethod()> Public Sub TestExistenMensajes()

    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaPertenece()

    End Sub
End Class