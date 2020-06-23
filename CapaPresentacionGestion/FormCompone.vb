Imports CapaDeNegocio


Public Class FormCompone
    Private Sub CmbEnfermedad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedad.SelectedIndexChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSintoma.CellContentClick

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Sintomas As New List(Of String)
        For x = 0 To DgvSintoma.Rows.Count() - 1
            Dim check As Boolean
            check = DgvSintoma.Rows(x).Cells(0).Value
            If check Then
                Sintomas.Add(DgvSintoma.Item("Sintoma", x).Value.ToString)
            End If
        Next
        ControladorCompone.Insertar(Sintomas, CmbEnfermedad.Text)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
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
            DgvSintoma.DataSource = tablaSintoma
        Catch ex As Exception
            MsgBox("Saca el cutuchillo de ahi carajo")
        End Try

    End Sub

    Private Sub FormCompone_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormSintoma.CargarSintomas()
    End Sub
End Class