Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloGenera

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "21"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestObtenerEnfermedadGenerada()
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .Cedula = Paciente
        }
        Resultado = False

        Try
            g.ObtenerEnfermedadGenerada()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreEnfermedad()
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .IdDiagnostico = Diagnostico
        }
        Resultado = False

        Try
            g.ObtenerNombreEnfermedad()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerNombreSintomas()
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .IdDiagnostico = Diagnostico
        }
        Resultado = False

        Try
            g.ObtenerNombreSintomas()
            Resultado = True

        Catch ex As Exception

        End Try

        Assert.IsTrue(Resultado)

    End Sub






End Class