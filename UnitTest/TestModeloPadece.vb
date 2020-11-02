Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloPadece

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"

    <TestMethod()> Public Sub TestGuardarPadecimientos()
        Dim resultado As Boolean
        Dim listaPrueba As New List(Of String) From {
            "Sintoma de prueba"
        }

        Dim p As New ModeloPadece(Paciente, PacPass) With {
            .ListadoSintomas = listaPrueba,
            .Cedula = Paciente
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