Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorPaciente

    <TestMethod()> Public Sub TestObtenerNombre()
        'ControladorSesion.User = "paciente"
        'ControladorSesion.Pass = "1"
        Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    End Sub

    <TestMethod()> Public Sub TestObtenerTodo()
        Assert.IsTrue(ControladorPaciente.ObtenerTodo())
    End Sub

    <TestMethod()> Public Sub TestObtenerMedicaciones()
        Assert.IsTrue(ControladorPaciente.ObtenerMedicaciones())
    End Sub

    <TestMethod()> Public Sub TestObtenerEnfermedades()
        Assert.IsTrue(ControladorPaciente.ObtenerEnfermedades())
    End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

    '<TestMethod()> Public Sub TestObtenerNombre()
    '    Assert.IsTrue(ControladorPaciente.ObtenerNombre())
    'End Sub

End Class