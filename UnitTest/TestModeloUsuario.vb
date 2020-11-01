Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloUsuario

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"
    Private ReadOnly Enfermedades As New List(Of String)
    Private ReadOnly Medicaciones As New List(Of String)
    Private ReadOnly Roles(3) As Boolean
    Private ReadOnly Contra As String = "Pas1234_"
    Dim resultado As Boolean = False

    <TestMethod()> Public Sub TestNuevoPaciente()
        resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico,
            .Nombre = "Nuevo",
            .Apellido = "Paciente",
            .Mail = "Correo",
            .FechaNacimiento = "2020-05-10",
            .Sexo = 0,
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones,
            .Password = Contra
        }
        Try
            resultado = True
            u.NuevoPaciente()
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoPaciente()
        resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Paciente,
            .Sexo = 0,
            .FechaNacimiento = "2020-02-12",
            .EnfermedadCronica = Enfermedades,
            .Medicacion = Medicaciones
        }
        Try
            u.AgregarNuevoPaciente()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoMedico()
        resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico,
            .Nombre = "Nuevo",
            .Apellido = "Medico",
            .Mail = "Correo",
            .Password = Contra
        }
        Try
            u.NuevoMedico()
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoMedico()
        resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Medico
        }
        Try
            u.AgregarNuevoMedico()
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoAdministrativo()
        resultado = False
        Dim u As New ModeloUsuario(Admin, AdmPass) With {
            .CI = Admin,
            .Nombre = "Nuevo",
            .Apellido = "Admin",
            .Mail = "Corero",
            .Password = Contra
        }
        Try
            u.NuevoAdministrativo()
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    '<TestMethod()> Public Sub Test()
    '    resultado = False
    '    Dim u As New ModeloUsuario(Admin, AdmPass) With {
    '        }
    '    Try
    '        u.
    '    Catch ex As Exception

    '    End Try
    '    Assert.IsTrue(resutlado)
    'End Sub

    '<TestMethod()> Public Sub Test()
    '    resultado = False
    '    Dim u As New ModeloUsuario(Admin, AdmPass) With {
    '        }
    '    Try
    '        u.
    '    Catch ex As Exception

    '    End Try
    '    Assert.IsTrue(resutlado)
    'End Sub

    '<TestMethod()> Public Sub Test()
    '    resultado = False
    '    Dim u As New ModeloUsuario(Admin, AdmPass) With {
    '        }
    '    Try
    '        u.
    '    Catch ex As Exception

    '    End Try
    '    Assert.IsTrue(resutlado)
    'End Sub

    '<TestMethod()> Public Sub Test()
    '    resultado = False
    '    Dim u As New ModeloUsuario(Admin, AdmPass) With {
    '        }
    '    Try
    '        u.
    '    Catch ex As Exception

    '    End Try
    '    Assert.IsTrue(resutlado)
    'End Sub
End Class