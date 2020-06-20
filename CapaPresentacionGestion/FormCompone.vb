Imports CapaDeNegocio


Public Class FormCompone
    Private Sub CmbEnfermedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedad.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub
End Class