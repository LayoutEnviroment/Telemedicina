Imports CapaDeNegocio

Public Class Frm_Menu

    Dim IdDiagnostico As String
    Dim CiPaciente As String
    Dim Nombre As String
    Dim Apellido As String

    Private Sub MenuMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrBuscarMensajesNuevos.Stop()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorChatMedico.ObtenerMiNombreApellido()
            GuardarMisDatos(LectorDatos)
        Catch ex As Exception
            MsgBox("Error al setear las credenciales" + ex.ToString)
        End Try

    End Sub

    Private Sub GuardarMisDatos(lector As IDataReader)
        While lector.Read
            Nombre = lector(0)
            Apellido = lector(1)
        End While

    End Sub

    Private Sub BtnBuscarSolicitudes_Click(sender As Object, e As EventArgs) Handles BtnBuscarSolicitudes.Click
        Dim TablaChats As New DataTable
        Try
            TablaChats.Load(ControladorChatMedico.BuscarSolicitud())
            DgvEnEspera.DataSource = TablaChats
        Catch ex As Exception
            MsgBox("Error al buscar solicitudes")
        End Try

    End Sub


    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        IdDiagnostico = DgvEnEspera.Item(0, DgvEnEspera.CurrentCell.RowIndex).Value
        CiPaciente = DgvEnEspera.Item(1, DgvEnEspera.CurrentCell.RowIndex).Value
        Try
            ControladorChatMedico.AceptarSolicitud(IdDiagnostico, CiPaciente, Nombre, Apellido)
            RtbConversacion.Text += "Chat iniciado con el paciente " + CiPaciente + Environment.NewLine
            EmpezarChat(IdDiagnostico, CiPaciente)
        Catch ex As Exception
            MsgBox("Error al aceptar la solicitud")
        End Try

    End Sub

    Private Sub EmpezarChat(diagnostico As String, paciente As String)
        IdDiagnostico = diagnostico
        CiPaciente = paciente
        TmrBuscarMensajesNuevos.Start()
        RealizarCambios(True)

    End Sub

    Public Sub RealizarCambios(estado As Boolean)
        BtnEnviar.Enabled = estado
        BtnFinalizarChat.Enabled = estado
        RtbMensaje.Enabled = estado
        BtnIniciarChat.Enabled = Not estado
        BtnBuscarSolicitudes.Enabled = Not estado
        DgvEnEspera.Enabled = Not estado

    End Sub

    Private Sub TmrBuscarMensajesNuevos_Tick_1(sender As Object, e As EventArgs) Handles TmrBuscarMensajesNuevos.Tick
        Dim Tabla As New DataTable
        Try
            Tabla = ControladorChatMedico.BuscarMensajesNuevos(IdDiagnostico)
            AgregarChat(Tabla)
        Catch ex As Exception
            MsgBox("Error buscando mensajes" + ex.ToString)
        End Try
    End Sub

    Public Sub AgregarChat(tabla As DataTable)
        Try
            If tabla.Rows.Count > 0 Then
                ControladorChatMedico.MarcarComoLeido()
                For Each fila As DataRow In tabla.Rows
                    If fila(5).ToString = "Iniciado" Then
                        RtbConversacion.Text += fila(1).ToString + ": " + Environment.NewLine + fila(2).ToString + Environment.NewLine
                    ElseIf fila(5).ToString = "Finalizado" Then
                        Threading.Thread.Sleep(1000)
                        Me.HacerCosas()
                    End If
                Next

            End If
        Catch ex As Exception
            MsgBox("Error en la conexion del chat" + ex.ToString)
        End Try

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChatMedico.EnviarMensaje(IdDiagnostico, RtbMensaje.Text, CiPaciente)
            AgregarChat()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub AgregarChat()
        RtbConversacion.Text += "YO:" + Environment.NewLine + RtbMensaje.Text + Environment.NewLine
        RtbMensaje.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        Frm_Login.Close()
    End Sub

    Private Sub HacerCosas()
        RealizarCambios(False)
        BtnBuscarSolicitudes.PerformClick()
        RtbConversacion.Clear()
        RtbMensaje.Clear()
    End Sub

    Private Sub MenuMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControladorChatMedico.FinalizarChat(IdDiagnostico, CiPaciente)
        Catch ex As Exception
            MsgBox("Error en la actualizacion del estado del chat")
        End Try
        HacerCosas()
    End Sub

    Private Sub BtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles BtnFinalizarChat.Click
        Try
            ControladorChatMedico.FinalizarChat(IdDiagnostico, CiPaciente)
        Catch ex As Exception
            MsgBox("Error en la actualizacion del estado del chat")
        End Try
        HacerCosas()
    End Sub
End Class
