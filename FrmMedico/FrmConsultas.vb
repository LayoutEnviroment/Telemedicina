Imports CapaDeNegocio

Public Class FrmConsultas
    Private Sub FrmConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TablaConsultas As New DataTable
        Try
            TablaConsultas.Load(ControladorChat.ObtenerIdFechaMisChat())
            DgvConsultas.DataSource = TablaConsultas
        Catch ex As Exception
            MsgBox("No se pudo obtener las consultas" + ex.ToString)
        End Try
    End Sub
End Class