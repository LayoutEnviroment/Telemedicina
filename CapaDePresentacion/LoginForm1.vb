Imports CapaDeNegocio

Public Class FrmLogin

    Private Sub BtnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngresar.Click
        Try
            ControladorLogin.ExistePersona(TxtUser.Text, TxtUser.Text)
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            MsgBox("Uy Casi, pero no...")
        End Try

    End Sub

End Class
