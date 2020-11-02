Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloDiagnostico

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestNuevo()
        Dim resultado As Boolean

        Dim sintomaPrueba As New List(Of String) From {
            "Sintoma de prueba"
        }
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .IdSintomas = sintomaPrueba,
            .IdEnfermedad = "8"
        }

        Try
            d.Nuevo()
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub ObtenerId()
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Cedula = Paciente
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Cedula = Paciente
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
            .Id = Diagnostico
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
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
           .Id = Diagnostico
       }
        Dim buscarInformacion As Boolean
        Try
            d.ExistenMensajes()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaPertenece()
        Resultado = False
        Dim d As New ModeloDiagnostico(Paciente, PacPass) With {
          .Id = Diagnostico
        }

        Try
            d.ObtenerCedulaPertenece()
            Resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(Resultado)
    End Sub
End Class