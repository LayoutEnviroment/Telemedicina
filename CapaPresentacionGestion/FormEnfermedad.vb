Imports CapaDeNegocio


Public Class FormEnfermedad
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        FormABMEnfermedad.opcionFormulario = "INSERTAR"
        Me.Hide()
        FormABMEnfermedad.Show()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        FormABMEnfermedad.opcionFormulario = "MODIFICAR"
        CargarTxt()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        FormABMEnfermedad.opcionFormulario = "ELIMINAR"
        CargarTxt()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub FormEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEnfermedad()
    End Sub

    Public Sub CargarTxt()
        Me.Hide()
        FormABMEnfermedad.Show()
        FormABMEnfermedad.TxtIdEnfermedad.Text = DgvEnfermedadesCargadas.Item("ID", DgvEnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.TxtNombreEnfermedad.Text = DgvEnfermedadesCargadas.Item("Nombre", DgvEnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.TxtDescripcionEnfermedad.Text = DgvEnfermedadesCargadas.Item("Descripcion", DgvEnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString
        FormABMEnfermedad.CmbPrioridad.Text = DgvEnfermedadesCargadas.Item("Prioridad", DgvEnfermedadesCargadas.CurrentCell.RowIndex).Value.ToString

    End Sub

    Public Sub CargarEnfermedad()
        Try
            Dim TablaEnfermedad As New DataTable
            TablaEnfermedad.Load(ControladorEnfermedad.ListarEnfermedad)
            DgvEnfermedadesCargadas.DataSource = TablaEnfermedad
        Catch ex As Exception
            MsgBox("Error al cargar enfermedades")
        End Try
    End Sub

End Class