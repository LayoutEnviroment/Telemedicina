Imports CapaDeNegocio

Public Class FrmModificarUsuario

    Dim rol(3) As Boolean
    Public Enfermedades As New List(Of String)
    Public Medicaciones As New List(Of String)
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
        Limpiar()
        HabilitarPersona(True)
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        HabilitarModificacion()

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
            TxtApellido.Text = lector(1).ToString
            TxtMail.Text = lector(2).ToString

        End While
    End Sub

    Private Sub EsPaciente()
        Try
            If ControladorUsuario.ExisteRol(CmbCi.SelectedItem.ToString(), 1) = 1 Then
                MsgBox("Soy paciente")
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
        DtpFechaNacimiento.Value = fecha.Date

    End Sub

    Private Sub ObtenerEnfermedadesCronicas()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorPaciente.ObtenerEnfermedades(CmbCi.SelectedItem)
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
            LectorMedicaciones = ControladorPaciente.ObtenerMedicaciones(CmbCi.SelectedItem)
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
        TxtMedicacion.Enabled = estado
        BtnAgregarMedicacion.Enabled = estado
        LstMedicaciones.Enabled = estado

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
        TxtEnfermedadCronica.Text = ""
    End Sub

    Private Sub LstEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedades.SelectedIndexChanged
        BtnEliminarEnfermedad.Enabled = True

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click
        LstEnfermedades.Items.Remove(LstEnfermedades.SelectedItems(0))
        BtnEliminarEnfermedad.Enabled = False

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
        TxtMedicacion.Text = ""

    End Sub

    Private Sub LstMedicaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicaciones.SelectedIndexChanged
        If LstMedicaciones.SelectedItems.Count() > 0 Then
            BtnEliminarMedicacion.Enabled = True
        Else
            BtnEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click
        LstMedicaciones.Items.Remove(LstMedicaciones.SelectedItems(0))
        BtnEliminarMedicacion.Enabled = False

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
        If ChbPaciente.Checked And rol(0) = True Then
            ModificarPersonaYPaciente()
        ElseIf ChbPaciente.Checked And rol(0) = False Then
            AgregarAPaciente()
        End If

        If ChbMedico.Checked And rol(1) = True Then
            ModificarPersona(2)
        ElseIf ChbMedico.Checked And rol(1) = False Then
            AgregarAMedico()
        End If

        If ChbAdministrador.Checked And rol(2) = True Then
            ModificarPersona(3)
        ElseIf ChbAdministrador.Checked And rol(2) = False Then
            AgregarAAdministrador()

        End If
        Limpiar()

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

    Private Sub AgregarAPaciente()
        Try
            ControladorUsuario.AgregarNuevoPaciente(CmbCi.SelectedItem(),
                                                    ObtenerSexo(),
                                                    ObtenerFecha(),
                                                    CargarListaEnfermedades(),
                                                    CargarListaMedicinas())
            MsgBox("Usuario actualizado como paciente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub AgregarAMedico()
        Try
            ControladorUsuario.AgregarNuevoMedico(CmbCi.SelectedItem,
                                                  TxtNombre.Text,
                                                  TxtApellido.Text,
                                                  TxtMail.Text)
            MsgBox("Usuario agregado como medico")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub AgregarAAdministrador()
        Try
            ControladorUsuario.AgregarNuevoAdministrativo(CmbCi.SelectedItem,
                                                        TxtNombre.Text,
                                                        TxtApellido.Text,
                                                        TxtMail.Text)
            MsgBox("Usuario agregado como administrador")
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub ModificarPersona(Usuario As Integer)
        Try
            ControladorUsuario.ModificarPersona(TxtNombre.Text,
                                                TxtApellido.Text,
                                                TxtMail.Text,
                                                CmbCi.SelectedItem)
            If Usuario = 2 Then
                MsgBox("Medico actualizado con exito!")
            Else
                MsgBox("Administrador actualizado con exito!")
            End If

        Catch ex As Exception
            If Usuario = 2 Then
                MsgBox("Error al acutalizar al medico")
            Else
                MsgBox("Error al acutalizar al adminsitrador")
            End If

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
            DtpFechaNacimiento.Value.Day.ToString

    End Function

    Private Function CargarListaEnfermedades()
        Enfermedades.Clear()
        For x = 0 To LstEnfermedades.Items.Count() - 1
            Enfermedades.Add(LstEnfermedades.Items(x).Text)
        Next
        Return Enfermedades

    End Function

    Private Function CargarListaMedicinas()
        Medicaciones.Clear()
        For x = 0 To LstMedicaciones.Items.Count() - 1
            Medicaciones.Add(LstMedicaciones.Items(x).Text)
        Next
        Return Medicaciones

    End Function



    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtMail.Text = ""
        ChbPaciente.Checked = False
        ChbMedico.Checked = False
        ChbAdministrador.Checked = False
        ChbPaciente.Enabled = False
        ChbMedico.Enabled = False
        ChbAdministrador.Enabled = False
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        LstEnfermedades.Items.Clear()
        LstMedicaciones.Items.Clear()
        MostrarDatosPaciente(False)

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

End Class