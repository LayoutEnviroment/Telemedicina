Imports CapaDeNegocio

Public Class FrmLogin

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) <> "" Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                Frm_Menu.Show()

            Else
                MsgBox("Usuario invalido")

            End If

        Catch ex As Exception
            MsgBox("Usuario Invalido")

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

        Catch ex As Exception
            MsgBox("Usuario Invalido")

        End Try

    End Sub

End Class
