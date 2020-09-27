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

    Private Sub DgvConsultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultas.CellContentClick
        Dim IdDiagnostico As String = DgvConsultas.Item("Id", DgvConsultas.CurrentCell.RowIndex).Value.ToString
        ObtenerCedulaPaciente(IdDiagnostico)
    End Sub

    Private Sub ObtenerCedulaPaciente(Id As String)
        Dim CedulaPaciente As String = ControladorDiagnostico.ObtenerCedulaPaciente(Id)
        ObtenerDatosPaciente(CedulaPaciente)

    End Sub

    Private Sub ObtenerDatosPaciente(cedula As String)
        Dim LectorDatos As IDataReader = ControladorPaciente.ObtenerTodo(cedula)
        Dim LectorEnfermedades As IDataReader = ControladorPaciente.ObtenerEnfermedades(cedula)
        Dim LectorMedicaciones As IDataReader = ControladorPaciente.ObtenerMedicaciones(cedula)
        CargarDatosPersonales(LectorDatos, cedula)
        CargarEnfermedadesCronicas(LectorEnfermedades)
        CargarMedicaciones(LectorMedicaciones)
        ObtenerSintomasyEnfermedadDiag(cedula)
    End Sub

    Private Sub CargarDatosPersonales(lector As IDataReader, cedula As String)
        While lector.Read
            TxtCedula.Text = cedula
            TxtNombre.Text = lector(0).ToString + lector(1).ToString
            TxtCorreo.Text = lector(2).ToString
            If lector(3).ToString = 0 Then
                TxtSexo.Text = "Hombre"
            Else
                TxtSexo.Text = "Mujer"
            End If
            TxtEdad.Text = ObtenerEdad(lector(4).ToString)

        End While
    End Sub

    Private Function ObtenerEdad(lectorFecha As Date)
        Dim Edad As Integer = DateDiff(DateInterval.Year, lectorFecha, Date.Now)
        Return Edad
    End Function

    Private Sub CargarEnfermedadesCronicas(enfermedades As IDataReader)
        While enfermedades.Read
            LstEnfermedades.Items.Add(enfermedades(0).ToString)
        End While

    End Sub

    Private Sub CargarMedicaciones(medicaciones As IDataReader)
        While medicaciones.Read
            LstMedicaciones.Items.Add(medicaciones(0).ToString)
        End While

    End Sub

    Private Sub ObtenerSintomasyEnfermedadDiag(cedula)

    End Sub
End Class