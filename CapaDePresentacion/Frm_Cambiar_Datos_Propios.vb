Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Cambiar_Datos_Propios

    Dim Nombre As Boolean
    Dim Apellido As Boolean
    Dim Correo As Boolean
    Dim Sexo As String
    Dim FechaNacimiento As String
    Dim Enfermedades As New List(Of String)
    Dim Medicaciones As New List(Of String)

    Private Sub Frm_Cambiar_Datos_Propios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()
        DttFecha.MaxDate = Today

    End Sub

    Public Sub ObtenerDatosPersona()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerTodo()
            CargarTextBoxes(Lector)
        Catch ex As Exception
            MsgBox("No se pudieron obtener sus datos")
        End Try

    End Sub

    Public Sub CargarTextBoxes(Lector As IDataReader)
        While Lector.Read
            TxtCedula.Text = Lector(0).ToString
            TxtNombre.Text = Lector(1).ToString
            TxtApellido.Text = Lector(2).ToString
            TxtCorreo.Text = Lector(3).ToString
            If Lector(4).ToString = 0 Then
                RdbMasculino.Checked = True
            Else
                RdbMujer.Checked = True
            End If
            AdaptarFecha(Lector(5).ToString)

        End While

    End Sub

    Public Sub AdaptarFecha(fecha As Date)
        DttFecha.Value = fecha.Date

    End Sub

    Public Sub ObtenerMedicacionesPaciente()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerMedicaciones()
            CargarListaMedicaciones(Lector)
        Catch ex As Exception
            MsgBox("No se pudieron obtener sus medicaciones")
        End Try

    End Sub

    Public Sub CargarListaMedicaciones(Lector As IDataReader)
        LstMedicaciones.Clear()
        While Lector.Read
            LstMedicaciones.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Public Sub ObtenerEnfermedadesCronicas()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerEnfermedades()
            CargarListaEnfermedades(Lector)
        Catch ex As Exception
            MsgBox("No se pudieron obtene sus enfermedades")
        End Try

    End Sub

    Public Sub CargarListaEnfermedades(Lector As IDataReader)
        LstEnfermedadesCronicas.Clear()
        While Lector.Read
            LstEnfermedadesCronicas.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Private Sub TxtAgregarEnfermedad_TextChanged(sender As Object, e As EventArgs) Handles TxtAgregarEnfermedad.TextChanged
        If TxtAgregarEnfermedad.Text <> " " Then
            BtnAgregarEnfermedad.Enabled = True
        Else
            BtnAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click
        LstEnfermedadesCronicas.Items.Add(TxtAgregarEnfermedad.Text)
        TxtAgregarEnfermedad.Text = ""

    End Sub

    Private Sub TxtAgregarMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtAgregarMedicacion.TextChanged
        If TxtAgregarMedicacion.Text <> " " Then
            BtnAgregarMedicacion.Enabled = True
        Else
            BtnAgregarMedicacion.Enabled = False

        End If

    End Sub

    Private Sub AgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click
        LstMedicaciones.Items.Add(TxtAgregarMedicacion.Text)
        TxtAgregarMedicacion.Text = ""

    End Sub

    Public Sub DeterminarSexo()
        If RdbMasculino.Checked = True Then
            Sexo = 0
        Else
            Sexo = 1
        End If

    End Sub

    Public Sub AsignarListas()
        Enfermedades.Clear()
        Medicaciones.Clear()
        For x = 0 To LstEnfermedadesCronicas.Items.Count() - 1
            Enfermedades.Add(LstEnfermedadesCronicas.Items(x).Text)

        Next

        For x = 0 To LstMedicaciones.Items.Count() - 1
            Medicaciones.Add(LstMedicaciones.Items(x).Text)

        Next
    End Sub

    Public Sub DeterminarFecha()
        FechaNacimiento = DttFecha.Value.Year.ToString + "/" + DttFecha.Value.Month.ToString + "/" + DttFecha.Value.Day.ToString

    End Sub

    Private Sub LstEnfermedadesCronicas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedadesCronicas.SelectedIndexChanged
        If LstEnfermedadesCronicas.SelectedItems.Count > 0 Then
            BtnEliminarEnfermedad.Enabled = True
        Else
            BtnEliminarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click
        LstEnfermedadesCronicas.Items.Remove(LstEnfermedadesCronicas.SelectedItems(0))
        AsignarListas()

    End Sub

    Private Sub LstMedicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicaciones.SelectedIndexChanged
        If LstMedicaciones.SelectedItems.Count > 0 Then
            BtnEliminarMedicacion.Enabled = True
        Else
            BtnEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click
        LstMedicaciones.Items.Remove(LstMedicaciones.SelectedItems(0))
        AsignarListas()

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
            TxtNombre.ForeColor = Color.Black
            Nombre = True
        Else
            TxtNombre.ForeColor = Color.Red
            Nombre = False
        End If

        HabilitarAceptar()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z]+$") Then
            TxtApellido.ForeColor = Color.Black
            Apellido = True
        Else
            TxtApellido.ForeColor = Color.Red
            Apellido = False
        End If
        HabilitarAceptar()

    End Sub

    Private Sub TxtCorreo_TextChanged(sender As Object, e As EventArgs) Handles TxtCorreo.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCorreo.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtCorreo.ForeColor = Color.Black
            Correo = True
        Else
            TxtCorreo.ForeColor = Color.Red
            Correo = False
        End If

        HabilitarAceptar()

    End Sub

    Public Sub HabilitarAceptar()
        If Nombre And Apellido And Correo Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        DeterminarSexo()
        AsignarListas()
        DeterminarFecha()
        GuardarValores()

    End Sub

    Public Sub GuardarValores()
        Try
            ControladorPaciente.CambiarDatos(TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtCorreo.Text,
                                             Sexo,
                                             FechaNacimiento,
                                             Enfermedades,
                                             Medicaciones)
            MsgBox("Cambios realizados con exito!", MsgBoxStyle.Information, "Cambio de usuario")
        Catch ex As Exception
            MsgBox("No se pudieron actualizar sus datos")
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Frm_Menu.Show()
        Me.Dispose()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()

    End Sub

End Class