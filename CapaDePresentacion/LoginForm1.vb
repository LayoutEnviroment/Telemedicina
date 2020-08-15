Imports CapaDeNegocio

Public Class FrmLogin

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click

        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) = 1 Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                Frm_Paciente.Show()
            Else
                MsgBox("Usuario invalido")
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function AutenticarPaciente(usuario As String, contra As String)
        'MsgBox("Visual envio: " + usuario + "," + contra)
        Return ControladorLogin.Autentificar(usuario, contra)
    End Function

    Private Sub SetearSesion(usuario As String, contra As String)
        ControladorSesion.User = usuario
        ControladorSesion.Pass = contra
    End Sub
End Class
