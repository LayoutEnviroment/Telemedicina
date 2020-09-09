Imports CapaDeNegocio
Public Class Frm_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) <> "" Then
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
        Return ControladorLogin.Autentificar(usuario, contra)

    End Function

    Private Sub SetearSesion(usuario As String, contra As String)
        ControladorSesion.User = usuario
        ControladorSesion.Pass = contra

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

End Class
