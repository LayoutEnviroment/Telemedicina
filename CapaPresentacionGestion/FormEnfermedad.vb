Imports CapaDeNegocio


Public Class FormEnfermedad
    Private Sub btnInsertar_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        FormABMEnfermedad.opcionFormulario = "INSERTAR"
        Me.Hide()
        FormABMEnfermedad.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FormABMEnfermedad.opcionFormulario = "MODIFICAR"
        CargarTxt()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        FormABMEnfermedad.opcionFormulario = "ELIMINAR"
        CargarTxt()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub FormEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaEnfermedad As New DataTable
        TablaEnfermedad.Load(ControladorEnfermedad.ListarEnfermedad)
        EnfermedadesCargadas.DataSource = TablaEnfermedad
    End Sub

    Public Sub CargarTxt()
        Me.Hide()
        FormABMEnfermedad.Show()
        FormABMEnfermedad.txtIdEnfermedad.Text = EnfermedadesCargadas.Item("ID", EnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.txtNombreEnfermedad.Text = EnfermedadesCargadas.Item("Nombre", EnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.txtDescripcionEnfermedad.Text = EnfermedadesCargadas.Item("Descripcion", EnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.cmbPrioridad.Text = EnfermedadesCargadas.Item("Prioridad", EnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString

    End Sub

End Class