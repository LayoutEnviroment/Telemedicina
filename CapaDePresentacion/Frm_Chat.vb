Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Chat

    Dim CiMedico As String
    Dim IdDiagnostico As String

    Private Sub Frm_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarMensaje("<p> Un médico se pondrá en contacto con usted en la brevedad </p>", 0)
        IdDiagnostico = ControladorDiagnostico.ObtenerID()

    End Sub

    Private Sub TmrMensajesNuevos_Tick(sender As Object, e As EventArgs) Handles TmrMensajesNuevos.Tick
        TmrMensajesNuevos.Start()
        BusquedaDeMensajes()

    End Sub

    Private Sub BusquedaDeMensajes()
        Dim MensajeNuevo As New DataTable
        Try
            MensajeNuevo = ControladorChat.BuscarMensajesNuevos(IdDiagnostico)
            If MensajeNuevo.Rows.Count > 0 Then
                AgregarChat(MensajeNuevo)
            End If
            TxtMensaje.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub AgregarChat(mensaje As DataTable)
        ControladorChat.MarcarComoLeido(IdDiagnostico)

        For Each fila As DataRow In mensaje.Rows
            If fila(5).ToString = "Finalizado" Then
                MsgBox("El doctor a finalizado el chat, el chat se cerrará automaticamente...", MsgBoxStyle.OkOnly)
                FinalizarConMedico()

            Else
                AgregarMensaje("<p style ='background-color:Tomato'; align = 'left' > " + fila(4).ToString + " : " + fila(2).ToString + "</p>", 1)
                CiMedico = fila(0).ToString
                TxtMensaje.Enabled = True

            End If

        Next

    End Sub

    Private Sub TxtMensaje_TextChanged(sender As Object, e As EventArgs) Handles TxtMensaje.TextChanged
        If TxtMensaje.Text <> "" Then
            BtnEnviar.Enabled = True
        Else
            BtnEnviar.Enabled = False
        End If

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChat.EnviarMensajePaciente(IdDiagnostico, RtbMensaje.Text, CiMedico)
            'AgregarMensaje("<p style ='background-color:Tomato'; align = 'right'>" + TxtMensaje.Text + "</p>", 0)
            AgregarMensaje("<p style ='background-color:Green'; align = 'right'>" + RtbMensaje.Text + "</p>", 0)
            BtnEnviar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub AgregarMensaje(Mensaje As String, Emisor As Integer)
        WbbConversacion.DocumentText += Mensaje
        If Emisor = 0 Then
            TxtMensaje.Text = ""
        End If

    End Sub

    Private Sub BbtnSalir_Click(sender As Object, e As EventArgs) Handles BbtnSalir.Click
        Select Case MsgBox("¿Seguro quiere salir del chat?", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                If CiMedico <> "" Then
                    FinalizarConMedico()
                Else
                    FinalizarSinMedico()
                End If

                TerminarChat()

            Case MsgBoxResult.No

        End Select
    End Sub

    Private Sub FinalizarConMedico()
        Try
            ControladorChat.FinalizarChatPaciente(IdDiagnostico, CiMedico)
            Try
                ControladorChat.MarcarComoFinalizado(IdDiagnostico)
            Catch ex As Exception
                MsgBox("Error en marcar como finalizado " + ex.ToString)
            End Try

        Catch ex As Exception
            MsgBox("Error finalizar chat paciente" + ex.ToString)
        End Try

    End Sub

    Private Sub FinalizarSinMedico()
        Try
            ControladorChat.FinalizarChat(IdDiagnostico)
            Try
                ControladorChat.MarcarComoFinalizado(IdDiagnostico)
            Catch ex As Exception
                MsgBox("marcar como finalizado" + ex.ToString)
            End Try

        Catch ex As Exception
            MsgBox("Error en finalizar chat" + ex.ToString)
        End Try

    End Sub

    Private Sub TerminarChat()
        TmrMensajesNuevos.Stop()
        WbbConversacion.DocumentText = ""
        TxtMensaje.Text = ""
        Me.Close()
        Frm_Menu.Show()

    End Sub

End Class