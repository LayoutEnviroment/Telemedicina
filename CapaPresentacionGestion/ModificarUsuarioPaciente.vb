Imports CapaDeNegocio

Public Class ModificarUsuarioPaciente

    Dim Nombre As String
    Dim Apellido As String
    Dim Correo As String
    Dim Sexo As String
    Dim FechaNacimiento As String
    Dim Enfermedades As New List(Of String)
    Dim Medicaciones As New List(Of String)


    Private Sub ModificarUsuarioPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim LectorCI As IDataReader
        LectorCI = ControladorPaciente.ObtenerCi

        While LectorCI.Read
            CmbSeleccionarCI.Items.Add(LectorCI.GetValue(0))
        End While

        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click
        LstEnfermedadCronica.Items.Add(TxtEnfermedadCronica.Text)
    End Sub

    Private Sub BtnEliminarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click

        LstEnfermedadCronica.Items.Remove(LstEnfermedadCronica.SelectedItems(0))
        AsignarListas()
    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click

        LstMedicacion.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Clear()
    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click
        LstMedicacion.Items.Remove(LstMedicacion.SelectedItems(0))
        AsignarListas()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Nombre = TxtNombre.Text
        Apellido = TxtApellido.Text
        Correo = TxtMail.Text
        DeterminarSexo()
        AsignarListas()
        DeterminarFecha()
        GuardarValores()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click

        MenuGestion.Show()
        Me.Close()
    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        CmbSeleccionarCI.Items.Clear()
        TxtMail.Text = ""
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        DtpFechaNacimiento.Checked = False
        LstEnfermedadCronica.Items.Clear()
        LstMedicacion.Items.Clear()
        RdbF.Checked = False
        RdbM.Checked = False

    End Sub

    Private Sub CmbSeleccionarCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSeleccionarCI.SelectedIndexChanged

    End Sub

    Public Sub ObtenerDatosPersona()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerTodo()
            CargarTextBoxes(Lector)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub CargarTextBoxes(Lector As IDataReader)
        While Lector.Read
            CmbSeleccionarCI.Text = Lector(0).ToString
            TxtNombre.Text = Lector(1).ToString
            TxtApellido.Text = Lector(2).ToString
            TxtMail.Text = Lector(3).ToString
            If Lector(4).ToString = 1 Then
                RdbM.Checked = True
            Else
                RdbF.Checked = True
            End If
            AdaptarFecha(Lector(5).ToString)

        End While
    End Sub


    Public Sub AdaptarFecha(fecha As Date)
        DtpFechaNacimiento.Value = fecha.Date
    End Sub

    Public Sub ObtenerMedicacionesPaciente()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerMedicaciones()
            CargarListaMedicaciones(Lector)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarListaMedicaciones(Lector As IDataReader)
        While Lector.Read
            LstMedicacion.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Public Sub ObtenerEnfermedadesCronicas()
        Dim Lector As IDataReader
        Try
            Lector = ControladorPaciente.ObtenerEnfermedades()
            CargarListaEnfermedades(Lector)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CargarListaEnfermedades(Lector As IDataReader)
        While Lector.Read
            LstEnfermedadCronica.Items.Add(Lector(0).ToString)
        End While

    End Sub

    Private Sub TxtEnfermedadCronica_TextChanged(sender As Object, e As EventArgs) Handles TxtEnfermedadCronica.TextChanged

        If TxtEnfermedadCronica.Text <> " " Then
            BtnAgregarEnfermedad.Enabled = True
        Else
            BtnAgregarEnfermedad.Enabled = False

        End If
    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged
        If TxtMedicacion.Text <> " " Then
            BtnAgregarMedicacion.Enabled = True
        Else
            BtnAgregarMedicacion.Enabled = False

        End If
    End Sub

    Public Sub DeterminarSexo()
        If RdbM.Checked = True Then
            Sexo = 0
        Else
            Sexo = 1
        End If

    End Sub

    Public Sub AsignarListas()
        Enfermedades.Clear()
        Medicaciones.Clear()
        For x = 0 To LstEnfermedadCronica.Items.Count() - 1
            Try
                Enfermedades.Add(LstEnfermedadCronica.Items(x).Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next

        For x = 0 To LstMedicacion.Items.Count() - 1
            Try
                Medicaciones.Add(LstMedicacion.Items(x).Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next
    End Sub

    Public Sub DeterminarFecha()
        FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString + "/" + DtpFechaNacimiento.Value.Month.ToString + "/" + DtpFechaNacimiento.Value.Day.ToString

    End Sub

    Public Sub GuardarValores()
        Try
            MsgBox(Sexo)
            ControladorPaciente.CambiarDatos(Nombre, Apellido, Correo, Sexo, FechaNacimiento, Enfermedades, Medicaciones)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaNacimiento.ValueChanged
        Dim Aceptar As String
        If DateDiff(DateInterval.Year, DtpFechaNacimiento.Value, Date.Now) >= 18 Then
            Aceptar = "Si"
        Else
            Aceptar = ""
        End If
        HabilitarAceptar(Aceptar)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        HabilitarAceptar(TxtNombre.Text)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        HabilitarAceptar(TxtApellido.Text)

    End Sub

    Private Sub TxtMail_TextChanged(sender As Object, e As EventArgs) Handles TxtMail.TextChanged
        HabilitarAceptar(TxtMail.Text)

    End Sub

    Public Sub HabilitarAceptar(contenido As String)
        If contenido <> "" Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If
    End Sub

    Private Sub LstEnfermedadCronica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedadCronica.SelectedIndexChanged
        If LstEnfermedadCronica.SelectedItems.Count > 0 Then
            BtnEliminarEnfermedad.Enabled = True
        Else
            BtnEliminarEnfermedad.Enabled = False
        End If
    End Sub

    Private Sub LstMedicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicacion.SelectedIndexChanged

        If LstMedicacion.SelectedItems.Count > 0 Then
            BtnEliminarMedicacion.Enabled = True
        Else
            BtnEliminarMedicacion.Enabled = False
        End If

    End Sub
End Class