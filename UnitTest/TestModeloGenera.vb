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
    Private ReadOnly Diagnostico As String = "1"

    <TestMethod()> Public Sub TestObtenerEnfermedadGenerada()
        Dim resultado As Boolean
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .Cedula = Paciente
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
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .IdDiagnostico = Diagnostico
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
        Dim g As New ModeloGenera(Paciente, PacPass) With {
           .IdDiagnostico = Diagnostico
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