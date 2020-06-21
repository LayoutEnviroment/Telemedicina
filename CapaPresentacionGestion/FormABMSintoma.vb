Imports CapaDeNegocio


Public Class FormABMSintoma
    Private Sub txtIdSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtIdSintoma.TextChanged

    End Sub

    Private Sub txtNombreSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSintoma.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        ControladorSintoma.CrearSintoma(txtNombreSintoma.Text)
        Me.Hide()
        FormSintoma.Show()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        FormSintoma.Show()
    End Sub
End Class