Imports CapaDeNegocio


Public Class FormSintoma

    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        FormABMSintoma.opcionFormulario = "INSERTAR"
        FormABMSintoma.ShowDialog()

    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FormABMSintoma.opcionFormulario = "MODIFICAR"
        CargarTxt()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        FormABMSintoma.opcionFormulario = "ELIMINAR"
        CargarTxt()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub FormSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintomas()
    End Sub

    Public Sub CargarSintomas()
        Try
            Dim TableSintoma As New DataTable
            TableSintoma.Load(ControladorSintoma.ListarSintoma)
            DgvSintomasCargados.DataSource = TableSintoma

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Public Sub CargarTxt()
        FormABMSintoma.TxtIdSintoma.Text = DgvSintomasCargados.Item("ID", DgvSintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.TxtNombreSintoma.Text = DgvSintomasCargados.Item("Nombre", DgvSintomasCargados.CurrentCell.RowIndex).Value.ToString
        FormABMSintoma.ShowDialog()
    End Sub

End Class