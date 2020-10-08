Imports CapaDeNegocio

Public Class Frm_Login

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) = 1 Then
                SetearSesion(TxtUser.Text, TxtPass.Text, Cedula)
                Me.Hide()
                MenuGestion.Show()
            Else
                MsgBox(Autentificar(TxtUser.Text, TxtPass.Text))
                MsgBox("Usuario Invalido")
            End If

        Catch ex As Exception
            MsgBox("Usuario Invalido" + ex.ToString)
        End Try
    End Sub

    Private Function Autentificar(usuario As String, contra As String)
        Return ControladorLogin.Autentificar(usuario, contra, 3)
    End Function

    Private Sub SetearSesion(usuario As String, contra As String, ci As String)
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
