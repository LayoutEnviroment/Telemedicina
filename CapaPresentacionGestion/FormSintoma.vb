Imports CapaDeNegocio


Public Class FormSintoma
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Me.Hide()
        FormABMSintoma.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Hide()
        FormABMSintoma.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Hide()
        FormABMSintoma.Show()
    End Sub

    Private Sub SintomasCargados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SintomasCargados.CellContentClick

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub
End Class