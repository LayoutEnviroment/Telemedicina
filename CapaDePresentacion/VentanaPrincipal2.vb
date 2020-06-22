Imports CapaDeNegocio

Public Class VentanaPrincipal2
    Private Sub TxtSintoma_TextChanged(sender As Object, e As EventArgs) Handles TxtSintoma.TextChanged

        Try
            Dim Table As New DataTable
            Table.Load(ControladorSintoma.ListarSintoma(TxtSintoma.Text))
            SintomaSistema.DataSource = Table
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Lst.Items.Add(SintomaSistema.CurrentCell.Value.ToString)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim Sintomas As New List(Of String)
        For x = 0 To Lst.Items.Count - 1
            Sintomas.Add(Lst.Items(x).Text)

        Next

        Dim Tabla As New DataTable
        Tabla.Load(ControladorCompone.EnfermedadesPosibles(Sintomas))
        DgvOpciones.DataSource = Tabla
    End Sub
End Class