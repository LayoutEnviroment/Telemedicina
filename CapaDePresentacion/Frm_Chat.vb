Imports CapaDeNegocio

Public Class Frm_Chat

    Dim IdMedico As String
    Dim Destinatario As String
    Dim IdDiagnostico As String = Frm_Iniciar_Chat.TxtIdDiagnostico.Text

    Private Sub Frm_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WbbConversacion.DocumentText += "<p style='background-color:MediumSeaGreen'; padding=100px; margin=100px> Un médico se pondrá en contacto con usted en la brevedad </p>"

    End Sub

    Private Sub TmrMensajesNuevos_Tick(sender As Object, e As EventArgs) Handles TmrMensajesNuevos.Tick
        Dim MensajeNuevo As New DataTable

        Try
            MensajeNuevo = ControladorChatPaciente.BuscarMensajesNuevos(IdDiagnostico)
            If MensajeNuevo.Rows.Count > 0 Then
                AgregarChat(MensajeNuevo)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Error buscando mensajes", MsgBoxStyle.ApplicationModal)

        End Try

    End Sub

    Public Sub AgregarChat(mensaje As DataTable)
        ControladorChatPaciente.MarcarComoLeido(IdDiagnostico)

        For Each fila As DataRow In mensaje.Rows
            If fila(5).ToString = "Finalizado" Then
                MsgBox("El doctor a finalizado el chat, el chat se cerrará automaticamente en 3 segundos...", MsgBoxStyle.OkOnly)
                Threading.Thread.Sleep(3000)
                Me.Hide()
                Frm_Menu.Show()

            Else
                WbbConversacion.DocumentText += "<p style ='background-color:Tomato'; align = 'left' > " + fila(4).ToString + " : " + fila(2).ToString + "</p>"
                IdMedico = fila(0).ToString
                BtnEnviar.Enabled = True
            End If

        Next

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChatPaciente.EnviarMensaje(IdDiagnostico, TxtMensaje.Text, IdMedico)
            AgregarChat()

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("No se pudo enviar el mensaje ", MsgBoxStyle.Critical)

        End Try

    End Sub

    Public Sub AgregarChat()
        RtbMensaje.Clear()
        WbbConversacion.DocumentText += "<p align = 'right'; style='line-height:6';padding=50px ><span style='background-color:MediumSeaGreen'>" + TxtMensaje.Text + " </span></p>"


    End Sub

    Private Sub RtbMensaje_TextChanged(sender As Object, e As EventArgs) Handles RtbMensaje.TextChanged
        If RtbMensaje.Text = "" Then
            BtnEnviar.Enabled = False
        Else
            BtnEnviar.Enabled = True
        End If

    End Sub

    Private Sub BbtnSalir_Click(sender As Object, e As EventArgs) Handles BbtnSalir.Click
        Select Case MsgBox("¿Seguro quiere salir del chat?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    ControladorChatPaciente.FinalizarChat(IdDiagnostico, IdMedico)
                    ControladorChatPaciente.MarcarComoFinalizado(IdDiagnostico)
                    RtbConversacion.Text = ""
                    RtbMensaje.Text = ""
                    Frm_Menu.Show()
                    Me.Hide()

                Catch ex As Exception
                    MsgBox("El chat no se pudo guardar correctamente" + ex.ToString)

                End Try

            Case MsgBoxResult.No

        End Select
    End Sub
End Class