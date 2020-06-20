Imports CapaDeNegocio


Public Class FormEnfermedad
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        Me.Hide()
        FormABMEnfermedad.Show()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.Hide()
        FormABMEnfermedad.Show()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.Hide()
        FormABMEnfermedad.Show()
    End Sub

    Private Sub EnfermedadesCargadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles EnfermedadesCargadas.CellContentClick

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub
End Class