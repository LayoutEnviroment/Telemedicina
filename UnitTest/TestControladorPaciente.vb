Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorPaciente

    Private ReadOnly Paciente As String = "53590226"

    <TestMethod()> Public Sub TestObtenerNombre()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerNombre()

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerCi()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerCi()

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerTodo()

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerTodoConCI()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerTodo("1111")

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub


    <TestMethod()> Public Sub TestObtenerMedicaciones()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerMedicaciones()

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerMedicacionesConCI()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerMedicaciones("1111")

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedadesConCI()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerEnfermedades("1111")

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarDatos()
        Dim resultado As Boolean
        Dim enfermedadTest As New List(Of String) From {
            "diabetes"
        }
        Dim medicacionesTest As New List(Of String) From {
            "insulina"
        }
        Try
            ControladorPaciente.CambiarDatos("super", "pruebas", "atoderol@gmail.com", "0", "1979-03-06", enfermedadTest, medicacionesTest)

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarDatosConCI()
        Dim resultado As Boolean
        Dim enfermedadTest As New List(Of String) From {
            "diabetes"
        }
        Dim medicacionesTest As New List(Of String) From {
            "insulina"
        }
        Try
            ControladorPaciente.CambiarDatos("super", "pruebas", "atoderol@gmail.com", "0", "1979-03-06", enfermedadTest, medicacionesTest, "1111")

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        Dim resultado As Boolean
        Try
            ControladorPaciente.ObtenerEnfermedades()

            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

End Class