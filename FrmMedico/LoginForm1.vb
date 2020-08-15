Imports CapaDeNegocio
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Try
            If Autentificar(TxtUser.Text, TxtPass.Text) = 2 Then
                SetearSesion(TxtUser.Text, TxtPass.Text)
                Me.Hide()
                MenuMedico.Show()
            Else
                MsgBox("Usuario Invalido")
            End If

        Catch ex As Exception
            MsgBox("Usuario Invalido")
        End Try

    End Sub

    Private Function Autentificar(usuario As String, contra As String)
        'MsgBox("Visual envio: " + usuario + "," + contra)
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
