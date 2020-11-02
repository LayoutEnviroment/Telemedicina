Imports System.ComponentModel
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
        CargarMensajes(IdDiagnostico)

    End Sub

    Private Sub ObtenerCedulaPaciente(Id As String)
        Try
            Dim CedulaPaciente As String = ControladorDiagnostico.ObtenerCedulaPaciente(Id)
            ObtenerDatosPaciente(CedulaPaciente)
            ObtenerEnfermedadesCronicas(CedulaPaciente)
            ObtenerMedicacionesPaciente(CedulaPaciente)
            ObtenerSintomasyEnfermedadDiag(Id)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ObtenerDatosPaciente(cedula As String)
        Try
            Dim LectorDatos As IDataReader = ControladorPaciente.ObtenerTodo(cedula)
            CargarDatosPersonales(LectorDatos, cedula)
        Catch ex As Exception

        End Try

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

    Private Sub ObtenerEnfermedadesCronicas(cedula As String)
        Try
            Dim LectorEnfermedades As IDataReader = ControladorPaciente.ObtenerEnfermedades(cedula)
            CargarEnfermedadesCronicas(LectorEnfermedades)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarEnfermedadesCronicas(enfermedades As IDataReader)
        LstEnfermedades.Items.Clear()
        While enfermedades.Read
            LstEnfermedades.Items.Add(enfermedades(0).ToString)
        End While

    End Sub

    Private Sub ObtenerMedicacionesPaciente(cedula As String)
        Try
            Dim LectorMedicaciones As IDataReader = ControladorPaciente.ObtenerMedicaciones(cedula)
            CargarMedicaciones(LectorMedicaciones)
        Catch ex As Exception
            MsgBox("No se pudieron obtener las medicaciones")
        End Try

    End Sub

    Private Sub CargarMedicaciones(medicaciones As IDataReader)
        LstMedicaciones.Items.Clear()
        While medicaciones.Read
            LstMedicaciones.Items.Add(medicaciones(0).ToString)
        End While

    End Sub

    Private Sub ObtenerSintomasyEnfermedadDiag(id As String)
        Try
            Dim LectorEnfermedad As IDataReader = ControladorDiagnostico.EnfermedadDiagnosticada(id)
            Dim LectorSintomas As IDataReader = ControladorDiagnostico.SintomasEnfermedadDiagnosticada(id)
            CargarEnfermedadDiagnosticada(LectorEnfermedad)
            CargarSintomasConsultados(LectorSintomas)
        Catch ex As Exception
            MsgBox("Error obteniendo datos del diagnostico " + ex.ToString)
        End Try

    End Sub

    Private Sub CargarEnfermedadDiagnosticada(lector As IDataReader)
        While lector.Read
            TxtEnfermedad.Text = lector(0)
        End While

    End Sub

    Private Sub CargarSintomasConsultados(lector As IDataReader)
        LstSintomas.Items.Clear()
        While lector.Read
            LstSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Public Sub CargarMensajes(idDiagnostico As String)
        RtbChat.Text = ""
        Dim Lector As IDataReader
        Try
            Lector = ControladorChat.ObtenerMensajesDelDiagnostico(idDiagnostico)
            While Lector.Read
                RtbChat.Text += Lector(1).ToString + Environment.NewLine
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        Frm_Menu.Show()
    End Sub

End Class