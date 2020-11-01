Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio

<TestClass()> Public Class TestControladorUsuario

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
        Try
            ControladorUsuario.NuevoPaciente(Paciente, "Paciente", "Prueba", "correo", "2020-05-20", 1, Enfermedades, Medicaciones, Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoPaciente()
        resultado = False
        Try
            ControladorUsuario.AgregarNuevoPaciente(Medico, 0, "1995-05-14", Enfermedades, Medicaciones)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoMedico()
        resultado = False
        Try
            ControladorUsuario.NuevoMedico(Medico, "Medico", "Prueba", "correo", Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestAgregarNuevoMedico()
        resultado = False
        Try
            ControladorUsuario.AgregarNuevoMedico(Medico)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoAdministrativo()
        resultado = False
        Try
            ControladorUsuario.NuevoAdministrativo(Admin, "Administrativo", "Prueba", "Correo", Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestAgregarNuevoAdministrativo()
        resultado = False
        Try
            ControladorUsuario.AgregarNuevoAdministrativo(Admin)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedico()
        resultado = False
        Try
            ControladorUsuario.NuevoPacienteMedico(Paciente,
                                                   "MedPac",
                                                   "Prueba",
                                                   "Correo",
                                                   "2020-05-10",
                                                   1,
                                                   Enfermedades,
                                                   Medicaciones,
                                                   Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestNuevoPacienteAdmin()
        resultado = False
        Try
            ControladorUsuario.NuevoPacienteAdmin(Paciente,
                                                  "PacAdm",
                                                  "Prueba",
                                                  "Correo",
                                                  "2020-06-10",
                                                  0,
                                                  Enfermedades,
                                                  Medicaciones,
                                                  Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoPacienteMedicoAdmin()
        resultado = False
        Try
            ControladorUsuario.NuevoPacienteMedicoAdmin("PacMedAdm",
                                                        "Prueba",
                                                        Paciente,
                                                        "Correo",
                                                        "2020-05-12",
                                                        1,
                                                        Enfermedades,
                                                        Medicaciones,
                                                        Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestNuevoMedicoAdmin()
        resultado = False
        Try
            ControladorUsuario.NuevoMedicoAdmin(Medico, "MedAdm", "Prueba", "Correo", Contra)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCorreo()
        resultado = False
        Try
            ControladorUsuario.ObtenerCorreo()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoCedula()
        resultado = False
        Try
            ControladorUsuario.ObtenerNombreApellidoCedula()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerCedulaMedico()
        resultado = False
        Try
            ControladorUsuario.ObtenerCedulaMedico()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub
    <TestMethod()> Public Sub TestObtenerCedulaAdministrativo()
        resultado = False
        Try
            ControladorUsuario.ObtenerCedulaAdministrativo()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombre()
        resultado = False
        Try
            ControladorUsuario.ObtenerNombre()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    ''CP -> Con parametro
    <TestMethod()> Public Sub TestObtenerNombreCP()
        resultado = False
        Try
            ControladorUsuario.ObtenerNombre(Paciente)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerNombreApellidoMail()
        resultado = False
        Try
            ControladorUsuario.ObtenerNombreApellidoMail(Paciente)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerTodasLasCedulas()
        resultado = False
        Try
            ControladorUsuario.ObtenerTodasLasCedulas()
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestExisteRol()
        resultado = False
        Try
            ControladorUsuario.ExisteRol(Paciente, 1)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestModificarPersona()
        resultado = False
        Try
            ControladorUsuario.ModificarPersona("Nuevo Nombre", "Prueba", "Correo", Medico)
            resultado = True
        Catch ex As Exception

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEliminarPersona()
        resultado = False
        Try
            ControladorUsuario.EliminarPersona(Paciente, Roles, 0)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)
    End Sub

End Class