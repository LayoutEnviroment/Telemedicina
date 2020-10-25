Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloPaciente

    <TestMethod()> Public Sub TestObtenerNombre()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
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
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
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
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
       }

        Try
            p.ObtenerPersonaSexoNacimineto("1111")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerMedicaciones()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
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
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
       }

        Try
            p.ObtenerMedicaciones("1111")

            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
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
        Dim p As New ModeloPaciente("1111", "Todes123") With {
           .Cedula = "1111"
       }

        Try
            p.ObtenerEnfermedades("1111")

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

        Dim p As New ModeloPaciente("1111", "Todes123") With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Cedula = "1111",
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

        Dim p As New ModeloPaciente("1111", "Todes123") With {
            .Nombre = "Super",
            .Apellido = "Pruebas",
            .Mail = "atoderol@gmail.com",
            .Sexo = "0",
            .FechaNacimiento = "1979-03-06",
            .Medicaciones = medicacionPrueba,
            .Enfermedades = enfermedadPrueba
       }

        Try
            p.CambiarDatos("1111")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCiPaciente()
        Dim resultado As Boolean
        Dim p As New ModeloPaciente("1111", "Todes123")

        Try
            p.ObtenerCiPaciente()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class