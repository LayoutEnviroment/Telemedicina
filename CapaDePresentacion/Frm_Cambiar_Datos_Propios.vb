Imports CapaDeNegocio

Public Class Frm_Cambiar_Datos_Propios

    Dim Nombre As String
    Dim Apellido As String
    Dim Correo As String
    Dim Sexo As String
    Dim FechaNacimiento As String
    Dim Enfermedades As New List(Of String)
    Dim Medicaciones As New List(Of String)

    Private Sub Frm_Cambiar_Datos_Propios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerDatosPersona()
        ObtenerMedicacionesPaciente()
        ObtenerEnfermedadesCronicas()
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

        End Try
    End Sub

    Public Sub CargarListaMedicaciones(Lector As IDataReader)
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

        End Try
    End Sub

    Public Sub CargarListaEnfermedades(Lector As IDataReader)
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
    End Sub

    Private Sub TxtAgregarMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtAgregarMedicacion.TextChanged
        If TxtAgregarMedicacion.Text <> " " Then
            BtnEliminarMedicacion.Enabled = True
        Else
            BtnEliminarMedicacion.Enabled = False

        End If
    End Sub

    Private Sub AgregarMedicacion_Click(sender As Object, e As EventArgs) Handles AgregarMedicacion.Click
        LstMedicaciones.Items.Add(TxtAgregarMedicacion.Text)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Nombre = TxtNombre.Text
        Apellido = TxtApellido.Text
        Correo = TxtCorreo.Text
        DeterminarSexo()
        AsignarListas()
        DeterminarFecha()
        GuardarValores()

    End Sub

    Public Sub DeterminarSexo()
        If RdbMasculino.Checked = True Then
            Sexo = 0
        Else
            Sexo = 1
        End If

    End Sub

    Public Sub AsignarListas()

        For x = 0 To LstEnfermedadesCronicas.Items.Count() - 1
            Try
                Enfermedades.Add(LstEnfermedadesCronicas.Items(x).Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next

        For x = 0 To LstMedicaciones.Items.Count() - 1
            Try
                Medicaciones.Add(LstMedicaciones.Items(x).Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Next
    End Sub

    Public Sub DeterminarFecha()
        FechaNacimiento = DttFecha.Value.Year.ToString + "/" + DttFecha.Value.Month.ToString + "/" + DttFecha.Value.Day.ToString

    End Sub

    Public Sub GuardarValores()
        Try
            MsgBox(Sexo)
            ControladorPaciente.CambiarDatos(Nombre, Apellido, Correo, Sexo, FechaNacimiento, Enfermedades, Medicaciones)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DttFecha_ValueChanged(sender As Object, e As EventArgs) Handles DttFecha.ValueChanged

    End Sub
End Class