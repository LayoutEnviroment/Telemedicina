Imports CapaDeNegocio

Public Class FrmModificarUsuario

    Dim rol(3) As Boolean
    Public Nombre, Apellido, Mail As Boolean

    Private Sub FrmModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCedulas()
    End Sub

    Private Sub ObtenerCedulas()
        Dim LectorCedula As IDataReader
        Try
            LectorCedula = ControladorUsuario.ObtenerTodasLasCedulas()
            CargarCedulas(LectorCedula)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CargarCedulas(lector As IDataReader)
        CmbCi.Items.Clear()
        While lector.Read
            CmbCi.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbCi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCi.SelectedIndexChanged
        HabilitarPersona(True)
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()

    End Sub

    Private Sub HabilitarPersona(estado As Boolean)
        TxtNombre.Enabled = estado
        TxtApellido.Enabled = estado
        TxtMail.Enabled = estado
        ChbPaciente.Enabled = estado
        ChbMedico.Enabled = estado
        ChbAdministrador.Enabled = estado
        LblNombre.Enabled = estado
        LblApellido.Enabled = estado
        LblMail.Enabled = estado
        LblUsuario.Enabled = estado

    End Sub

    Private Sub ObtenerDatosPersona()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorUsuario.TraerNombreApellidoMail(CmbCi.SelectedItem.ToString())
            CargarDatos(LectorDatos)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(0).ToString
            TxtMail.Text = lector(0).ToString

        End While
    End Sub

    Private Sub EsPaciente()
        Try
            If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString(), 1) = 1 Then
                rol(0) = True
                ChbPaciente.Checked = True
                ChbPaciente.Enabled = False
                ObtenerDatosPaciente()
                ObtenerEnfermedadesCronicas()
                ObtenerMedicacion()
            Else
                rol(0) = False
                ChbPaciente.Enabled = True
                ChbPaciente.Checked = False

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub ObtenerDatosPaciente()
        Dim LectorPaciente As IDataReader
        Try
            LectorPaciente = ControladorPaciente.ObtenerTodo(CmbCi.SelectedItem.ToString)
            CargarDatosPaciente(LectorPaciente)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarDatosPaciente(lector As IDataReader)
        While lector.Read
            AdaptarFecha(lector(4).ToString)
            If lector(3).ToString = 0 Then
                RdbH.Checked = True
            Else
                RdbM.Checked = True
            End If
        End While

    End Sub

    Private Sub AdaptarFecha(fecha As Date)
        MsgBox(fecha.ToString)
        DtpFechaNacimiento.Value = fecha.Date

    End Sub

    Private Sub ObtenerEnfermedadesCronicas()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorPaciente.ObtenerEnfermedades()
            CargarEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub CargarEnfermedades(lector As IDataReader)
        LstEnfermedades.Clear()
        While lector.Read
            LstEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub ObtenerMedicacion()
        Dim LectorMedicaciones As IDataReader
        Try
            LectorMedicaciones = ControladorPaciente.ObtenerMedicaciones()
            CargarMedicaciones(LectorMedicaciones)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarMedicaciones(lector As IDataReader)
        LstMedicaciones.Clear()
        While lector.Read
            LstMedicaciones.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub EsMedico()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 2) = 1 Then
            rol(1) = True
            ChbMedico.Checked = True
            ChbMedico.Enabled = False
        Else
            rol(1) = False
            ChbMedico.Checked = False
            ChbMedico.Enabled = True
        End If

    End Sub

    Private Sub EsAdministrativo()
        If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString, 3) = 1 Then
            rol(2) = True
            ChbAdministrador.Checked = True
            ChbAdministrador.Enabled = False
        Else
            rol(2) = False
            ChbAdministrador.Checked = False
            ChbAdministrador.Enabled = True
        End If

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        MostrarDatosPaciente(ChbPaciente.Checked)
        HabilitarModificacion()

    End Sub

    Private Sub MostrarDatosPaciente(estado As Boolean)
        LblFechaNacimiento.Enabled = estado
        DtpFechaNacimiento.Enabled = estado
        RdbH.Enabled = estado
        RdbM.Enabled = estado
        LblEnfermedadCronica.Enabled = estado
        TxtEnfermedadCronica.Enabled = estado
        BtnAgregarEnfermedad.Enabled = estado
        LstEnfermedades.Enabled = estado
        LblMedicacion.Enabled = estado
        BtnAgregarMedicacion.Enabled = estado
        TxtMedicacion.Enabled = estado

    End Sub



    Private Sub TxtEnfermedadCronica_TextChanged(sender As Object, e As EventArgs) Handles TxtEnfermedadCronica.TextChanged
        If TxtEnfermedadCronica.Text <> "" Then
            BtnAgregarEnfermedad.Enabled = True
        Else
            BtnAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click
        LstEnfermedades.Items.Add(TxtEnfermedadCronica.Text)

    End Sub

    Private Sub LstEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedades.SelectedIndexChanged
        BtnAgregarEnfermedad.Enabled = True

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click
        LstEnfermedades.Items.Remove(LstEnfermedades.SelectedItems(0))

    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged
        If TxtMedicacion.Text <> "" Then
            BtnAgregarMedicacion.Enabled = True
        Else
            BtnAgregarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click
        LstMedicaciones.Items.Add(TxtMedicacion.Text)

    End Sub

    Private Sub LstMedicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicaciones.SelectedIndexChanged
        BtnEliminarMedicacion.Enabled = True

    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click
        LstMedicaciones.Items.Remove(LstMedicaciones.SelectedItems(0))

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
            TxtNombre.ForeColor = Color.Black
            Nombre = True
        Else
            TxtNombre.ForeColor = Color.Red
            Nombre = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z]+$") Then
            TxtApellido.ForeColor = Color.Black
            Apellido = True
        Else
            TxtApellido.ForeColor = Color.Red
            Apellido = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub TxtMail_TextChanged(sender As Object, e As EventArgs) Handles TxtMail.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtMail.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtMail.ForeColor = Color.Black
            Mail = True
        Else
            TxtMail.ForeColor = Color.Red
            Mail = False
        End If
        HabilitarModificacion()

    End Sub

    Private Sub HabilitarModificacion()
        If ChbPaciente.Checked = False And ChbMedico.Checked = False And ChbAdministrador.Checked = False Then
            BtnAceptar.Enabled = False
        Else
            If Nombre And Apellido And Mail Then
                BtnAceptar.Enabled = True
            Else
                BtnAceptar.Enabled = False
            End If

        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        For Each r As String In rol
            MsgBox(r)
        Next
        If ChbPaciente.Checked And rol(0) = True Then
            'ModificarPersonaYPaciente()
            MsgBox("Modificar Paciente")
        ElseIf ChbPaciente.CheckAlign And rol(0) = False Then

            MsgBox("Agregar a paciente")
        End If

        If ChbMedico.Checked And rol(1) = True Then
            'ControladorUsuario.ModificarPersona(TxtNombre.Text, TxtApellido.Text, TxtMail.Text)
            MsgBox("Modificar Persona -medico-")
        ElseIf ChbMedico.Checked And rol(1) = False Then
            MsgBox("Agregar a medico")
        End If

        If ChbAdministrador.Checked And rol(2) = True Then
            MsgBox("Modifico Administrador")
        ElseIf ChbAdministrador.Checked And rol(2) = False Then
            MsgBox("Agrego Administrador")

        End If


    End Sub

    Private Sub ModificarPersonaYPaciente()
        Try
            ControladorPaciente.CambiarDatos(TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtMail.Text,
                                             ObtenerSexo(),
                                             ObtenerFecha(),
                                             CargarListaEnfermedades(),
                                             CargarListaMedicinas(),
                                             CmbCi.SelectedItem())
            MsgBox("Paciente modificado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Function ObtenerSexo()
        If RdbH.Checked Then
            Return 0
        Else
            Return 1
        End If

    End Function

    Private Function ObtenerFecha()
        Return DtpFechaNacimiento.Value.Year.ToString + "-" +
            DtpFechaNacimiento.Value.Month.ToString + "-" +
            DtpFechaNacimiento.Value.Day

    End Function

    Private Function CargarListaEnfermedades()
        Dim Enfermedades As List(Of String)
        Enfermedades.Clear()
        For x = 0 To LstEnfermedades.Items.Count() - 1
            Enfermedades.Add(LstEnfermedades.Items(x).ToString())
        Next
        Return Enfermedades

    End Function

    Private Function CargarListaMedicinas()

        Dim Medicinas As List(Of String)
        Medicinas.Clear()
        For x = 0 To LstEnfermedades.Items.Count() - 1
            Medicinas.Add(LstEnfermedades.Items(x).ToString())
        Next
        Return Medicinas

    End Function

End Class