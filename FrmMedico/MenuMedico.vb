Imports CapaDeNegocio

Public Class MenuMedico

    Private Sub BtnHabilitarTimer_Click(sender As Object, e As EventArgs) Handles BtnHabilitarTimer.Click
        Dim TablaChats As New DataTable
        TablaChats.Load(ControladorChat.BuscarSolicitud())
        DgvEnEspera.DataSource = TablaChats
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        LoginForm1.Close()
    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        MsgBox(DgvEnEspera.SelectedRows)
        'ControladorChat.AceptarSolicitud(DgvEnEspera.SelectedRows("Diagnostcio"))
    End Sub

    Private Sub DgvEnEspera_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEnEspera.CellClick
        BtnIniciarChat.Enabled = True
    End Sub
End Class
