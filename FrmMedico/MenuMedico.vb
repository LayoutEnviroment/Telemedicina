Imports CapaDeNegocio

Public Class MenuMedico
    Private Sub TmrBuscarChats_Tick(sender As Object, e As EventArgs) Handles TmrBuscarChats.Tick
        Dim TablaChats As New DataTable
        TablaChats.Load(ControladorChat.BuscarSolicitud())
        DgvEnEspera.DataSource = TablaChats
    End Sub
End Class
