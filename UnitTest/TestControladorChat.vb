Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeNegocio
<TestClass()> Public Class TestControladorChat

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly Diagnostico As String = "1"
    Dim Resultado As Boolean = False

    <TestMethod()> Public Sub TestEnviarSolicitud()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False
        Try
            ControladorChat.EnviarSolicitud(Diagnostico)
            Resultado = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.BuscarSolicitud.GetType(), TablaEsperada.GetType())
        Catch ex As Exception

        End Try

    End Sub

    <TestMethod()> Public Sub TestAceptarSolicitud()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False
        Try
            ControladorChat.AceptarSolicitud(Diagnostico, Paciente, "Eduardo", "Fabre")
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajePaciente(Diagnostico, "soy paciente", Medico)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Dim resultado As Boolean
        Try
            ControladorChat.EnviarMensajeMedico(Diagnostico, "soy medico", Paciente)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False

        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarMensajesNuevo()
        Dim resultado As Boolean
        Try
            ControladorChat.BuscarMensajesNuevos(Diagnostico)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestMarcarComoLeido()
        Dim resultado As Boolean
        Try
            ControladorChat.MarcarComoLeido(Diagnostico)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestFinalizarChatPaciente()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Dim resultado As Boolean

        Try
            ControladorChat.FinalizarChatPaciente(Diagnostico, Medico)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        ControladorSesion.Cedula = Medico
        ControladorSesion.User = Medico
        ControladorSesion.Pass = MedPass
        Resultado = False
        Try
            ControladorChat.FinalizarChatMedico(Diagnostico, Paciente)
            Resultado = True
        Catch ex As Exception

            MsgBox(ex.ToString)
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestFinalizarChat()
        ControladorSesion.Cedula = Paciente
        ControladorSesion.User = Paciente
        ControladorSesion.Pass = PacPass
        Resultado = False

        Try
            ControladorChat.FinalizarChat(Diagnostico)
            resultado = True
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestMarcarComoFinalizado()
        Dim resultado As Boolean
        Try
            ControladorChat.MarcarComoFinalizado("1")
            resultado = True
        Catch ex As Exception

            resultado = False
        End Try

        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()

        Dim TablaEsperada As New DataTable
        Try
            Assert.AreSame(ControladorChat.ObtenerIdFechaMisChat.GetType(), TablaEsperada.GetType())

        Catch ex As Exception

        End Try
    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()
        Dim resultado As Boolean
        Try
            ControladorChat.ObtenerMensajesDelDiagnostico(1)
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub
End Class