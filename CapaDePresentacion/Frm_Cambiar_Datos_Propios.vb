Imports CapaDeNegocio

Public Class Frm_Cambiar_Datos_Propios
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
            Dim Fecha As Date = Lector(5)
            DttFechaNacimiento.Value = Fecha
            'MsgBox(Fecha)
            'MsgBox(Fecha.Year.ToString)
            'MsgBox(Lector(5).ToString.Substring(0, 10))
            'DttFechaNacimiento.Value = Lector(5).ToString.Substring(0, 10)
            'MsgBox(Lector(5).ToString)
        End While

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
        Dim Nombre As String = TxtNombre.Text
        Dim Apellido As String = TxtApellido.Text
        Dim Correo As String = TxtCorreo.Text
        Dim Sexo As Boolean
        If RdbMasculino.Checked = True Then
            Sexo = 0
        Else
            Sexo = 1
        End If
        Dim Enfermedades As List(Of String)
        For Each enfermedad As String In LstEnfermedadesCronicas.Items
            Enfermedades.Add(enfermedad)
        Next
        GuardarValores(Nombre, Apellido, Correo, Sexo)
    End Sub

    Public Sub GuardarValores(Nombre As String, Apellido As String, Correo As String, Sexo As String)
        ControladorPaciente.CambiarDatos(Nombre, Apellido, Correo, Sexo)
    End Sub
End Class