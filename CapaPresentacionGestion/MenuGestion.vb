Imports CapaDeNegocio

Public Class MenuGestion
    Private Sub btnEnfermedad_Click(sender As Object, e As EventArgs) Handles btnEnfermedad.Click
        Me.Hide()
        FormEnfermedad.Show()
    End Sub

    Private Sub btnSintoma_Click(sender As Object, e As EventArgs) Handles btnSintoma.Click
        Me.Hide()
        FormSintoma.Show()
    End Sub

    Private Sub btnCompone_Click(sender As Object, e As EventArgs) Handles btnCompone.Click
        Me.Hide()
        FormCompone.Show()
    End Sub
End Class
