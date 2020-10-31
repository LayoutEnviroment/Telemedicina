Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloPaciente

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"

    <TestMethod()> Public Sub TestObtenerNombre()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerNombre()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerPersonaSexoNacimineto()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerPersonaSexoNacimineto()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerPersonaSexoNaciminetoConCi()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerPersonaSexoNacimineto(Paciente)
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerMedicaciones()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerMedicaciones()

            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerMedicacionesConCI()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerMedicaciones(Paciente)

            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerEnfermedades()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestTestObtenerEnfermedadesConCI()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass) With {
           .Cedula = Paciente
       }

        Try
            p.ObtenerEnfermedades(Paciente)

            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarDatos()
        Dim resultado As Boolean
        Dim medicacionPrueba As New List(Of String) From {
        "Insulina"
        }
        Dim enfermedadPrueba As New List(Of String) From {
        "Diabetes"
        }

        Dim p As New ModeloPaciente(Paciente, PacPass) With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Cedula = Paciente,
            .Sexo = "0",
            .FechaNacimiento = "1979-03-06",
            .Medicaciones = medicacionPrueba,
            .Enfermedades = enfermedadPrueba
       }

        Try
            p.CambiarDatos()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarDatosConCI()
        Dim resultado As Boolean
        Dim medicacionPrueba As New List(Of String) From {
        "Insulina"
        }
        Dim enfermedadPrueba As New List(Of String) From {
        "Diabetes"
        }

        Dim p As New ModeloPaciente(Paciente, PacPass) With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Sexo = "0",
            .FechaNacimiento = "1979-03-06",
            .Medicaciones = medicacionPrueba,
            .Enfermedades = enfermedadPrueba
       }

        Try
            p.CambiarDatos(Paciente)
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCiPaciente()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente(Paciente, PacPass)

        Try
            p.ObtenerCiPaciente()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class