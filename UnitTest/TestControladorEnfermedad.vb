Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorEnfermedad

    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly PacPass As String = "Pac1234_"

    <TestMethod()> Public Sub TestListarNombreEnfermedadesActivas()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Dim listaSintomaPrueba As New List(Of String) From {
            "4",
            "43",
            "47",
            "48",
            "49",
            "50"
        }
        Try
            ControladorEnfermedad.CrearEnfermedad("Hartnup", "Mala absorción de los aminoácidos", "ALTA", listaSintomaPrueba)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.EstaInactivo("Acne")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestActivarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ActivarEnfermedad("Acne")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.CambiarEnfermedad("5", "Bronquitis", "Inflamacion de los conductos bronquiales, las vias respiratorias que llevan oxigeno a sus pulmones.", "ALTA")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestCambiarEnfermedadYSintomas()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Dim listaSintomaPrueba As New List(Of String) From {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "41"
        }
        Try
            ControladorEnfermedad.CambiarEnfermedadYSintomas("1", "Apendicitis", "Afeccion en la cual el apendice se inflama", "ALTA", listaSintomaPrueba)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestEliminarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.EliminarEnfermedad("3")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerId()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ObtenerId("Aftas Bucales")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestObtenerPrioridad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ObtenerPrioridad("7")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerDescripcion()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ObtenerDescripcion("8")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ObtenerTodo("1")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestObtenerExistencia()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ObtenerExistencia("Parkinson")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestReactivarEnfermedad()
        ControladorSesion.User = Admin
        ControladorSesion.Pass = AdmPass
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ReactivarEnfermedad("Alergia")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

End Class