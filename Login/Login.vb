Imports CapaDeNegocio

Public Class Login
    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim Credenciales(2) As String
        Credenciales(1) = TxtUsuario.Text
        Credenciales(2) = TxtPassword.Text
        ControladorLogin.Login(Credenciales)
    End Sub
End Class
