Imports CapaDeNegocio


Public Class FormABMEnfermedad
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            Me.Hide()
            FormEnfermedad.Show()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Hide()
            FormEnfermedad.Show()
        Catch ex As Exception

        End Try

    End Sub
End Class