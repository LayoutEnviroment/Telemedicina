Imports CapaDeNegocio


Public Class FormSintoma

    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        FormABMSintoma.opcionFormulario = "INSERTAR"
        FormABMSintoma.ShowDialog()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FormABMSintoma.opcionFormulario = "MODIFICAR"
        FormABMSintoma.txtIdSintoma.Text = SintomasCargados.Item("ID", SintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.txtNombreSintoma.Text = SintomasCargados.Item("Nombre", SintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.ShowDialog()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        FormABMSintoma.opcionFormulario = "ELIMINAR"
        FormABMSintoma.txtIdSintoma.Text = SintomasCargados.Item("ID", SintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.txtNombreSintoma.Text = SintomasCargados.Item("Nombre", SintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.ShowDialog()
    End Sub

    Private Sub SintomasCargados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SintomasCargados.CellContentClick

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub


    Private Sub FormSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim Table As New DataTable
            Table.Load(ControladorSintoma.ListarSintoma)
            SintomasCargados.DataSource = Table

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class