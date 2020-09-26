Imports CapaDeNegocio

Public Class FrmLogin
    'Public Property Membership As Object

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) = 1 Then
                'Dim password As String = Membership.GeneratePassword(12, 1)
                'MsgBox(password)
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                Frm_Menu.Show()

            Else
                MsgBox("Usuario invalido")

            End If

        Catch ex As Exception
            MsgBox("Usuario Invalido" + ex.ToString)

        End Try

    End Sub

    Private Sub AutenticarPaciente(usuario As String, contra As String)
        Try
            ControladorLogin.Autentificar(usuario, contra)

        Catch ex As Exception
            MsgBox("Usuario Invalido")

        End Try

    End Sub

    Private Sub SetearSesion(usuario As String, contra As String)
        Try
            ControladorSesion.User = usuario
            ControladorSesion.Pass = contra
            ControladorSesion.Cedula = ControladorUsuario.ObtenerCedula()

        Catch ex As Exception
            MsgBox("Usuario Invalido")

        End Try

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
