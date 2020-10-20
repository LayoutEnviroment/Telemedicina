Imports CapaDeNegocio

Public Class FrmLogin

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            If AutenticarPaciente(TxtUser.Text, TxtPass.Text) = 1 Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                Frm_Menu.Show()
            Else
                MsgBox("Usuario invalido")

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("Usuario Invalido")

        End Try

    End Sub

    Private Function AutenticarPaciente(usuario As String, contra As String)
        Return ControladorLogin.Autentificar(usuario, contra, 1)

    End Function

    Private Sub SetearSesion(usuario As String, contra As String)
        Try
            ControladorSesion.User = usuario
            ControladorSesion.Pass = contra
            ControladorSesion.Cedula = TxtUser.Text

        Catch ex As Exception
            MsgBox("Error en setear sesion" + ex.ToString)
            'MsgBox("Usuario Invalido")

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
