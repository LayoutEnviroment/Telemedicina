﻿Imports CapaDeNegocio

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
        TxtSintomaPaciente.AppendText(SintomaSistema.CurrentCell.Value.ToString)
        Lst.Items.Add(SintomaSistema.CurrentCell.Value.ToString)
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim BuscarPor(Lst.Items.Count) As String
        For x = 0 To Lst.Items.Count - 1
            ControladorSintoma.ObtenerId(BuscarPor)
        Next

    End Sub
End Class