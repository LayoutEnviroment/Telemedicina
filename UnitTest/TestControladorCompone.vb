Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
Imports CapaDeDatos

<TestClass()> Public Class TestControladorCompone

    <TestMethod()> Public Sub TestEnfermedadesPosibles()

        Dim resultado As Boolean
        Dim sintomasDeTest As New List(Of String)
        sintomasDeTest.Add("Sintoma de prueba")

        Try
            ControladorCompone.EnfermedadesPosibles(sintomasDeTest)
            resultado = True

        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestEnfermedadesPorAproximacion()

        Dim resultado As Boolean
        Dim sintomasTest As New List(Of String) From {
            "Fiebre",
            "Dolor",
            "Malestar",
            "Dificultad Respiratoria"
        }

        Try
            ControladorCompone.EnfermedadesPorAproximacion(sintomasTest)
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub
    'NO ENCUENTRO DONDE ESTA EN LA PARTE VISUAL
    '<TestMethod()> Public Sub TestInsertar()
    '    Dim resultado As Boolean
    '    Dim sintomasTest As New List(Of String) From {
    '         "Diarrea",
    '        "Debilidad",
    '        "Ansiedad",
    '        "Alucinaciones",
    '        "Desmayo",
    '        "Delirio"
    '    }

    '    Try
    '        ControladorCompone.Insertar(sintomasTest, "Hartnup")
    '        resultado = True

    '    Catch ex As Exception
    '        resultado = False

    '    End Try

    '    Assert.IsTrue(resultado)

    'End Sub

    <TestMethod()> Public Sub TestObtenerSintomasEnfermedad()
        Dim resultado As Boolean

        Try
            ControladorCompone.ObtenerSintomasEnfermedad("3")
            resultado = True

        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)
    End Sub

End Class