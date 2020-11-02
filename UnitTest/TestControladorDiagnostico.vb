Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorDiagnostico

    Private ReadOnly Diagnostico As String = "1"

    <TestMethod()> Public Sub TestControladorNuevo()
        Dim resultado As Boolean
        Dim listaTest As New List(Of String)
        listaTest.Add("46")

        Try
            ControladorDiagnostico.Nuevo(listaTest, 8)
            resultado = True
        Catch ex As Exception
            resultado = False
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerID()
        Try
            Assert.AreEqual(ControladorDiagnostico.ObtenerID(), 4)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    <TestMethod()> Public Sub TestTodosMisDiagnosticos()
        Dim tablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorDiagnostico.TodosMisDiagnosticos().GetType, tablaEsperada.GetType)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    <TestMethod()> Public Sub TestSintomasEnfermedadDiagnosticada()
        Dim resultado As Boolean
        Try
            ControladorDiagnostico.SintomasEnfermedadDiagnosticada(1)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestEnfermedadDiagnosticada()
        Dim resultado As Boolean
        Try
            ControladorDiagnostico.EnfermedadDiagnosticada(4)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestMedicoDiagnostico()
        Dim tablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorDiagnostico.MedicoDiagnostico(4).GetType, tablaEsperada.GetType)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    <TestMethod()> Public Sub TestExistenMensajes()
        Dim resultado As Boolean
        Try
            ControladorDiagnostico.ExistenMensajes(1)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub ObtenerCedulaPaciente()
        Dim resultado As Boolean
        Try
            ControladorDiagnostico.ObtenerCedulaPaciente(Diagnostico)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub
End Class