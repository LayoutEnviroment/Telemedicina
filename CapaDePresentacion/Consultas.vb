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

    Private Sub DgvDiagnosticos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDiagnosticos.CellContentClick
        PnlInformacion.Visible = True
        Dim IdDiagnostico As String = DgvDiagnosticos.Item("Id", DgvDiagnosticos.CurrentCell.RowIndex).Value.ToString

        CargarEnfermedad(IdDiagnostico)
        CargarSintomas(IdDiagnostico)
        CargarMedico(IdDiagnostico)
        CargarConversacion(IdDiagnostico)

    End Sub

    Private Sub CargarEnfermedad(id As String)
        Try
            Dim Enfermedad As IDataReader
            Enfermedad = ControladorDiagnostico.EnfermedadDiagnosticada(id)

            While Enfermedad.Read
                LblNombreEnfermedad.Text = Enfermedad(0)
                LblPrioridadEnfermedad.Text = Enfermedad(1)
                RtbDescripcion.Text = Enfermedad(2)
            End While

        Catch ex As Exception
            MsgBox("No se pudo obtener la enfermedad para este diagnostico")

        End Try

    End Sub

    Private Sub CargarSintomas(id As String)
        Try
            Dim Sintomas As New DataTable
            Sintomas.Load(ControladorDiagnostico.SintomasEnfermedadDiagnosticada(id))
            DgvSintomas.DataSource = Sintomas

        Catch ex As Exception
            MsgBox("No se pudieron obtener los sintomas para este diagnostico" + ex.ToString)

        End Try

    End Sub

    Private Sub CargarMedico(id As String)
        Try
            Dim Medico As IDataReader
            Medico = ControladorDiagnostico.MedicoDiagnostico(id)

            While Medico.Read
                LblMedico.Text = Medico(0) + " " + Medico(1)
            End While

        Catch ex As Exception
            MsgBox("No se pudo cargar al medico" + ex.ToString)
        End Try

    End Sub

    Private Sub CargarConversacion(idDiagnostico As String)
        Try

        Catch ex As Exception

        End Try
    End Sub






End Class
