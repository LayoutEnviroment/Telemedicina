Imports CapaDeNegocio

Public Class Frm_Chat

    Dim IdMedico As String
    Dim Destinatario As String
    Dim IdDiagnostico As String

    Private Sub Frm_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RtbConversacion.Text += "Un médico se pondrá en contacto con usted en la brevedad" + Environment.NewLine
        IdDiagnostico = Frm_Paciente.TxtIdDiagnostico.Text
    End Sub

    Private Sub TmrMensajesNuevos_Tick(sender As Object, e As EventArgs) Handles TmrMensajesNuevos.Tick
        Dim TablaMensaje As New DataTable
        Try
            TablaMensaje = ControladorChatPaciente.BuscarMensajesNuevos(IdDiagnostico)
            AgregarChat(TablaMensaje)

        Catch ex As Exception
            MsgBox("Error buscando mensajes" + ex.ToString)
        End Try

    End Sub

    Public Sub AgregarChat(mensajes As DataTable)
        If mensajes.Rows.Count > 0 Then
            ControladorChatPaciente.MarcarComoLeido()
            BtnEnviar.Enabled = True

            For Each mensaje As DataRow In mensajes.Rows
                MsgBox(mensaje(5).ToString)
                If mensaje(5).ToString = "Iniciado" Then
                    IdMedico = mensaje(0).ToString
                    RtbConversacion.Text += mensaje(4).ToString + ": " + Environment.NewLine + mensaje(2).ToString + Environment.NewLine
                ElseIf mensaje(5).ToString = "Finalizado" Then
                    RtbConversacion.Text += "SISTEMA : " + mensaje(2).ToString
                    Threading.Thread.Sleep(2000)
                    Me.Close()
                End If
            Next
        End If
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChatPaciente.EnviarMensaje(IdDiagnostico, RtbMensaje.Text, IdMedico)
            AgregarChat()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub AgregarChat()
        RtbConversacion.Text += "YO: " + Environment.NewLine + RtbMensaje.Text + Environment.NewLine
        RtbMensaje.Clear()

    End Sub

    Private Sub Frm_Chat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If DialogResult.Cancel Then
            MsgBox("Porque?")
            Try
                ControladorChatPaciente.MarcarComoFinalizado(IdDiagnostico)
                ControladorChatPaciente.FinalizarChat(IdDiagnostico, IdMedico)
            Catch ex As Exception
                MsgBox("No se pudo finalizar correctamente " + ex.ToString)
            End Try
        End If


        Frm_Paciente.Show()
        Frm_Paciente.PanelChat.Hide()
    End Sub

    Private Sub RtbMensaje_TextChanged(sender As Object, e As EventArgs) Handles RtbMensaje.TextChanged
        If RtbMensaje.Text = "" Then
            BtnEnviar.Enabled = False
        End If
    End Sub
End Class