Imports CapaDeNegocio

Public Class MenuGestion
    Private Sub BtnEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnEnfermedad.Click
        Me.Hide()
        FormEnfermedad.Show()
    End Sub

    Private Sub BtnSintoma_Click(sender As Object, e As EventArgs) Handles BtnSintoma.Click
        Me.Hide()
        FormSintoma.Show()
    End Sub

    Private Sub BtnCompone_Click(sender As Object, e As EventArgs) Handles BtnCompone.Click
        Me.Hide()
        FormCompone.Show()
    End Sub

End Class
