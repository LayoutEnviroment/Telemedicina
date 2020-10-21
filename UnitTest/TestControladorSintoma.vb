Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorSintoma

    <TestMethod()> Public Sub TestListarNombreSintomaActivo()
        Dim resultado As Boolean

        Try
            ControladorSintoma.ListarNombreSintomaActivo()
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestCrearSintoma()
        Dim resultado As Boolean

        Try
            ControladorSintoma.CrearSintoma("Delirio")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestCambiarNombreDeSintoma()
        Dim resultado As Boolean

        Try
            ControladorSintoma.CambiarNombreDeSintoma("47", "Delirios")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarSintoma()
        Dim resultado As Boolean

        Try
            ControladorSintoma.EliminarSintoma("44")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerExistencia()
        Dim resultado As Boolean

        Try
            ControladorSintoma.ObtenerExistencia("Bruma Sensorial")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEstaInactivo()
        Dim resultado As Boolean

        Try
            ControladorSintoma.EstaInactivo("Temblores")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerId()
        Dim resultado As Boolean

        Try
            ControladorSintoma.ObtenerId("Diarrea")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestActivarSintoma()
        Dim resultado As Boolean

        Try
            ControladorSintoma.ActivarSintoma("Temblores")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub
End Class