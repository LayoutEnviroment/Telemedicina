Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorEnfermedad

    '<TestMethod()> Public Sub TestListarEnfermedad()

    'NO ENCUENTRO DONDE PIDE ESTE METODO

    'End Sub

    '<TestMethod()> Public Sub TestListarNombreEnfermedadesInactiva()

    'NO ENCUENTRO DONDE PIDE ESTE METODO

    'End Sub
    <TestMethod()> Public Sub TestListarNombreEnfermedadesActivas()
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
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.ActivarEnfermedad("Acne")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestCambiarEnfermedad()

        Dim resultado As Boolean
        Try
            ControladorEnfermedad.CambiarEnfermedad("5", "Bronquitis", "Inflamacion de los conductos bronquiales, las vias respiratorias que llevan oxigeno a sus pulmones.", "ALTA")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestCambiarEnfermedadYSintomas()
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
        Dim resultado As Boolean
        Try
            ControladorEnfermedad.EliminarEnfermedad("3")
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
    <TestMethod()> Public Sub TestObtenerId()
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