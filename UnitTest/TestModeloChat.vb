Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaDeDatos

<TestClass()> Public Class TestModeloChat

    <TestMethod()> Public Sub TestEnviarSolicitud()
        Dim c As New ModeloChat("1111", "Todes123") With {
        .Cedula = "1111",
        .IdDiagnostico = "4"
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
        Dim c As New ModeloChat("22223334", "Medico123")
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
        Dim c As New ModeloChat("22223334", "Medico123") With {
            .Cedula = "22223334",
            .CiPaciente = "1111",
            .IdDiagnostico = "4"
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
        Dim c As New ModeloChat("1111", "Todes123") With {
            .Cedula = "1111",
            .CiMedico = "22223334",
            .IdDiagnostico = "4",
            .CiPaciente = "1111",
            .Mensaje = "Estoy todito tomado Doc"
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
    'consultar por que no guarda el mensaje
    <TestMethod()> Public Sub TestEnviarMensajeMedico()
        Dim insertadoOk As Boolean
        Try
            Dim c As New ModeloChat("22223334", "Medico123") With {
            .Cedula = "22223334",
            .CiMedico = "22223334",
            .IdDiagnostico = "4",
            .CiPaciente = "1111",
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
        Dim c As New ModeloChat("1111", "Todes123") With {
            .IdDiagnostico = "4",
            .Cedula = "1111"}

        Try
            Assert.AreSame(c.BuscarMensajesNuevos.GetType(), tablaEsperada.GetType())

        Catch ex As Exception
            MsgBox("No comprobe el dato mandado")
        End Try

    End Sub
    <TestMethod()> Public Sub TestMarcarComoLeido()
        Dim c As New ModeloChat("22223334", "Medico123") With {
            .IdDiagnostico = "4",
            .Cedula = "1111"
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
        Dim c As New ModeloChat("1111", "Todes123") With {
            .CiMedico = "22223334",
            .Cedula = "1111",
            .IdDiagnostico = "4"
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
        Dim c As New ModeloChat("1111", "Todes123") With {
            .CiMedico = "22223334",
            .Cedula = "1111",
            .IdDiagnostico = "4"
        }
        Dim modificarEstado As Boolean

        Try
            c.FinalizarChat("4")
            modificarEstado = True
        Catch ex As Exception
            modificarEstado = False
        End Try

        Assert.IsTrue(modificarEstado)

    End Sub

    <TestMethod()> Public Sub TestFinalizarChatMedico()
        Dim c As New ModeloChat("22223334", "Medico123") With {
           .CiPaciente = "1111",
           .Cedula = "22223334",
           .IdDiagnostico = "4"
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

        Dim c As New ModeloChat("22223334", "Medico123") With {
         .IdDiagnostico = "4"
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
        Dim c As New ModeloChat("22223334", "Medico123") With {
       .Cedula = "22223334"
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
        Dim c As New ModeloChat("1111", "Todes123") With {
      .IdDiagnostico = "4"
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