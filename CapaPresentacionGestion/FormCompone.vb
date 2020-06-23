Imports CapaDeNegocio


Public Class FormCompone
    Private Sub CmbEnfermedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedad.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSintoma.CellContentClick

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim Sintomas As New List(Of String)
        For x = 0 To dgvSintoma.Rows.Count() - 1
            Dim check As Boolean
            check = dgvSintoma.Rows(x).Cells(0).Value
            If check Then
                'MsgBox(dgvSintoma.Item("Sintoma", x).Value.ToString)
                Sintomas.Add(dgvSintoma.Item("Sintoma", x).Value.ToString)
            End If
        Next
        ControladorCompone.Insertar(Sintomas, CmbEnfermedad.Text)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub FormCompone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim tabla As New DataTable
            tabla.Load(ControladorEnfermedad.ListarEnfermedad)
            CmbEnfermedad.DataSource = tabla
            CmbEnfermedad.DisplayMember = "Nombre"
            CmbEnfermedad.ValueMember = "ID"

            Dim tablaSintoma As New DataTable
            tablaSintoma.Load(ControladorSintoma.ListarNombre)
            dgvSintoma.DataSource = tablaSintoma
        Catch ex As Exception
            MsgBox("Saca el cutuchillo de ahi carajo")
        End Try

    End Sub
End Class