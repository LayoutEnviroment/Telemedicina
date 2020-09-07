Imports CapaDeNegocio

Public Class Consultas

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Diagnosticos As New DataTable
        Try
            Diagnosticos.Load(ControladorDiagnostico.TodosLosDiagnosticos())
            DgvDiagnosticos.DataSource = Diagnosticos
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class