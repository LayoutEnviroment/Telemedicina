Imports CapaDeNegocio

Public Class MenuMedico


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TablaChats As New DataTable
        TablaChats.Load(ControladorChatMedico.BuscarSolicitud())
        DgvEnEspera.DataSource = TablaChats
    End Sub
End Class
