Imports CapaDeNegocio

Public Class Frm_Chat

    Private Sub TmrMensajesNuevos_Tick(sender As Object, e As EventArgs) Handles TmrMensajesNuevos.Tick
        Dim Tabla As New DataTable
        Try
            Tabla = ControladorChat.BuscarMensajesNuevos(Frm_Paciente.TxtIdDiagnostico.Text)
            AgregarChat(Tabla)

        Catch ex As Exception
            MsgBox("Error buscando mensajes" + ex.ToString)
        End Try
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChat.EnviarMensaje(Frm_Paciente.TxtIdDiagnostico.Text, RtbMensaje.Text)
            AgregarChat()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub AgregarChat()
        RtbConversacion.Text += "YO:" + Environment.NewLine + RtbMensaje.Text
        RtbMensaje.Clear()

    End Sub

    Public Sub AgregarChat(tabla As DataTable)
        If tabla.Rows.Count > 0 Then
            For Each fila As DataRow In tabla.Rows
                RtbConversacion.Text += Environment.NewLine + fila(1).ToString + ": " + fila(0).ToString
            Next
        End If\

    End Sub

End Class