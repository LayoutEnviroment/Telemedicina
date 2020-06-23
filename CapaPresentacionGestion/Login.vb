Imports CapaDeNegocio

Public Class Login
    Private Sub BtnIngreso_Click(sender As Object, e As EventArgs) Handles BtnIngreso.Click

        'ControladorLogin.PermitirIngreso(TxtUsername.Text, TxtPassword.Text)
        MenuGestion.Show()
        Me.Hide()

    End Sub
End Class