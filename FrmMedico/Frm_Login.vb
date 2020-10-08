Imports CapaDeNegocio
Public Class Frm_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) = 1 Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                Frm_Menu.Show()

            Else
                MsgBox("Usuario Invalido")

            End If

        Catch ex As Exception
            MsgBox("Usuario Invalido" + ex.ToString)

        End Try

    End Sub

    Private Function Autentificar(usuario As String, contra As String)
        Return ControladorLogin.Autentificar(usuario, contra, 2)

    End Function

    Private Sub SetearSesion(usuario As String, contra As String)
        ControladorSesion.User = usuario
        ControladorSesion.Pass = contra
        ControladorSesion.Cedula = TxtUser.Text
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged
        If TxtUser.Text <> "" And TxtPass.Text <> "" Then
            BtnIngresar.Enabled = True
        Else
            BtnIngresar.Enabled = False
        End If

    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        If TxtUser.Text <> "" And TxtPass.Text <> "" Then
            BtnIngresar.Enabled = True
        Else
            BtnIngresar.Enabled = False
        End If

    End Sub

End Class
