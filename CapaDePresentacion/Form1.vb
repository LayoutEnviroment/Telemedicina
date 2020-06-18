Imports CapaDeNegocio

Public Class ObtenerDiagnostico
    Private Sub TxtSintoma_Click(sender As Object, e As EventArgs) Handles TxtSintoma.Click
        TxtSintoma.ForeColor = Color.Black
    End Sub

    Private Sub TxtSintoma_TextChanged(sender As Object, e As EventArgs) Handles TxtSintoma.TextChanged

        Try
            Dim Table As New DataTable
            Table.Load(ControladorSintoma.ListarSintoma(TxtSintoma.Text))
            SintomaSistema.DataSource = Table
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub SintomaSistema_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SintomaSistema.CellMouseDown
        SintomaSistema.DoDragDrop(SintomaSistema.CurrentCell.Value.ToString, DragDropEffects.Copy)
    End Sub


    Private Sub SintomaPaciente_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SintomaPaciente.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub SintomaPaciente_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SintomaPaciente.DragDrop
        Dim AgregarSintoma As String = SintomaSistema.CurrentCell.Value.ToString()
        Dim Sintoma As New ListViewItem
        Sintoma = SintomaPaciente.Items.Add(AgregarSintoma)
    End Sub

    Private Sub SintomaPaciente_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SintomaPaciente.MouseDown
        SintomaPaciente.DoDragDrop(SintomaPaciente.SelectedItems.ToString, DragDropEffects.Copy)
    End Sub

    Private Sub ObtenerDiagnostico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
