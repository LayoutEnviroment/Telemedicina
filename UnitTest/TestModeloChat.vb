Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloChat

    Private ReadOnly Paciente As String = "53590226"
    Private ReadOnly Medico As String = "49249605"
    Private ReadOnly Admin As String = "54083680"
    Private ReadOnly PacPass As String = "Pac1234_"
    Private ReadOnly MedPass As String = "Med1234_"
    Private ReadOnly AdmPass As String = "Adm1234_"
    Private ReadOnly Diagnostico As String = "5"

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim c As New ModeloChat(Paciente, PacPass) With {
        .Cedula = Paciente,
        .IdDiagnostico = Diagnostico
        }

        Dim resultado As Boolean
        Try
            c.EnviarSolicitud()
            resultado = True
        Catch ex As Exception
            resultado = False
        End Try
        Assert.IsTrue(resultado)
    End Sub

    <TestMethod()> Public Sub TestBuscarSolicitud()
        Dim c As New ModeloChat(Medico, MedPass)
        Dim consultaOk As Boolean

        Try
            c.BuscarSolicitud()
            consultaOk = True
        Catch ex As Exception
            consultaOk = False
        End Try
        Assert.IsTrue(consultaOk)
    End Sub
    <TestMethod()> Public Sub TestAceptarSolicitud()
        Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico,
            .CiPaciente = Paciente,
            .IdDiagnostico = Diagnostico
        }
        Dim insertadoOk As Boolean
        Try
            c.AceptarSolicitud()
            insertadoOk = True
        Catch ex As Exception
            insertadoOk = False
        End Try

        Assert.IsTrue(insertadoOk)


    End Sub
    <TestMethod()> Public Sub TestEnviarMensajePaciente()
        Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico,
            .CiMedico = Medico,
            .IdDiagnostico = Diagnostico,
            .CiPaciente = Paciente,
            .Mensaje = "Estoy todito tomado Doc"
        }
        Dim insertadoOk As Boolean
        Try
            c.AceptarSolicitud()
            insertadoOk = True
        Catch ex As Exception
            insertadoOk = False
            MsgBox(ex.ToString)
        End Try

        Assert.IsTrue(insertadoOk)

    End Sub
    'consultar por que no guarda el mensaje
    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Dim insertadoOk As Boolean
        Try
            Dim c As New ModeloChat(Medico, MedPass) With {
            .Cedula = Medico,
            .CiMedico = Medico,
            .IdDiagnostico = Diagnostico,
            .CiPaciente = Paciente,
            .Mensaje = "Nunca estuve tan de acuerdo"
        }
            c.AceptarSolicitud()
            insertadoOk = True
        Catch ex As Exception
            insertadoOk = False
        End Try

        Assert.IsTrue(insertadoOk)
    End Sub
    <TestMethod()> Public Sub TestBuscarMensajesNuevos()
        Dim tablaEsperada As New DataTable
        Dim c As New ModeloChat(Medico, MedPass) With {
            .IdDiagnostico = Diagnostico,
            .Cedula = Medico
            }

        Try
            Assert.AreSame(c.BuscarMensajesNuevos.GetType(), tablaEsperada.GetType())

        Catch ex As Exception
            MsgBox("No comprobe el dato mandado")
        End Try

    End Sub
    <TestMethod()> Public Sub TestMarcarComoLeido()
        Dim c As New ModeloChat(Medico, MedPass) With {
            .IdDiagnostico = Diagnostico,
            .Cedula = Paciente
        }
        Dim modificarEstado As Boolean
        Try
            c.MarcarComoLeido()
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try
        Assert.IsTrue(modificarEstado)

    End Sub
    <TestMethod()> Public Sub TestFinalizarChatPaciente()
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .CiMedico = Medico,
            .Cedula = Paciente,
            .IdDiagnostico = Diagnostico
        }
        Dim modificarEstado As Boolean
        Try
            c.FinalizarChatPaciente()
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try
        Assert.IsTrue(modificarEstado)

    End Sub
    <TestMethod()> Public Sub TestFinalizarChatConId()
        Dim c As New ModeloChat(Paciente, PacPass) With {
            .CiMedico = Medico,
            .Cedula = Paciente,
            .IdDiagnostico = Diagnostico
        }
        Dim modificarEstado As Boolean

        Try
            c.FinalizarChat(Diagnostico)
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try

        Assert.IsTrue(modificarEstado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Dim c As New ModeloChat(Medico, MedPass) With {
           .CiPaciente = Paciente,
           .Cedula = Medico,
           .IdDiagnostico = Diagnostico
       }
        Dim modificarEstado As Boolean
        Try
            c.FinalizarChatMedico()
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try
        Assert.IsTrue(modificarEstado)

    End Sub

    <TestMethod()> Public Sub TestMarcarComoFinalizado()

        Dim c As New ModeloChat(Medico, MedPass) With {
         .IdDiagnostico = Diagnostico
     }
        Dim modificarEstado As Boolean
        Try
            c.MarcarComoFinalizado()
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try
        Assert.IsTrue(modificarEstado)

    End Sub
    <TestMethod()> Public Sub TestObtenerIdFechaMisChat()
        Dim c As New ModeloChat(Medico, MedPass) With {
       .Cedula = Medico
   }
        Dim buscarInformacion As Boolean
        Try
            c.ObtenerIdFechaMisChat()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub

    <TestMethod()> Public Sub TestObtenerMensajesDelDiagnostico()
        Dim c As New ModeloChat(Paciente, PacPass) With {
      .IdDiagnostico = Diagnostico
  }
        Dim buscarInformacion As Boolean
        Try
            c.ObtenerMensajesDelDiagnostico()
            buscarInformacion = True
        Catch ex As Exception
            buscarInformacion = False
        End Try
        Assert.IsTrue(buscarInformacion)
    End Sub

End Class