Imports CapaDeNegocio
Imports System.Net.Mail
Public Class FrmNuevoUsuario

    Dim TipoUsuario(3) As Boolean
    Dim FechaNacimiento As String
    Dim EnfermedadesCronicas As New List(Of String)
    Dim Medicamentos As New List(Of String)
    Dim Sexo As String
    Dim Contra As String
    Public Ci, Nombre, Apellido, Mail, FoM, Fecha As Boolean


    Private Sub FrmNuevoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DtpFechaNacimiento.MaxDate = Today()
    End Sub

    Private Sub TxtCI_TextChanged(sender As Object, e As EventArgs) Handles TxtCI.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtCI.Text, "^[0-9]+$") Then
            TxtCI.ForeColor = Color.Black
            Ci = True
        Else
            TxtCI.ForeColor = Color.Red
            Ci = False
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtNombre.Text, "^[a-zA-Z]+$") Then
            TxtNombre.ForeColor = Color.Black
            Nombre = True
        Else
            TxtNombre.ForeColor = Color.Red
            Nombre = False
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtApellido_TextChanged(sender As Object, e As EventArgs) Handles TxtApellido.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtApellido.Text, "^[a-zA-Z]+$") Then
            TxtApellido.ForeColor = Color.Black
            Apellido = True
        Else
            TxtApellido.ForeColor = Color.Red
            Apellido = False
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub TxtMail_TextChanged(sender As Object, e As EventArgs) Handles TxtMail.TextChanged
        If System.Text.RegularExpressions.Regex.IsMatch(TxtMail.Text, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$") Then
            TxtMail.ForeColor = Color.Black
            Mail = True
        Else
            TxtMail.ForeColor = Color.Red
            Mail = False
        End If

        HabilitarTipoUsuario()

    End Sub

    Private Sub HabilitarTipoUsuario()
        If Ci And Nombre And Apellido And Mail Then
            ChbPaciente.Enabled = True
            ChbMedico.Enabled = True
            ChbAdministrador.Enabled = True
        Else
            ChbPaciente.Enabled = False
            ChbMedico.Enabled = False
            ChbAdministrador.Enabled = False
            ChbPaciente.Checked = False
            ChbMedico.Checked = False
            ChbAdministrador.Checked = False
        End If

    End Sub

    Private Sub ChbAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChbAdministrador.CheckedChanged
        If ChbAdministrador.Enabled Then
            HabilitarAceptar()
        Else
            BtnAceptar.Enabled = False
        End If

    End Sub

    Private Sub ChbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMedico.CheckedChanged
        If ChbMedico.Enabled Then
            HabilitarAceptar()
        Else
            BtnAceptar.Enabled = False
        End If

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        If ChbPaciente.Checked Then
            CamposPaciente(True)
        Else
            CamposPaciente(False)
            HabilitarAceptar()
        End If

        If ChbPaciente.Enabled Then
            HabilitarAceptar()
        Else
            BtnAceptar.Enabled = False

        End If

    End Sub

    Private Sub CamposPaciente(estado As Boolean)
        TxtEnfermedadCronica.Visible = estado
        TxtMedicacion.Visible = estado
        LstEnfermedadCronica.Visible = estado
        LstMedicacion.Visible = estado
        RdbF.Visible = estado
        RdbM.Visible = estado
        DtpFechaNacimiento.Visible = estado
        LblFechaNacimiento.Visible = estado
        LblEnfermedadCronica.Visible = estado
        LblMedicacion.Visible = estado
        LblSexo.Visible = estado
        BtnAgregarEnfermedad.Visible = estado
        BtnAgregarMedicacion.Visible = estado
        BtnEliminarEnfermedad.Visible = estado
        BtnEliminarMedicacion.Visible = estado
    End Sub

    Private Sub HabilitarAceptar()
        If Ci And Nombre And Apellido And Mail And ChbPaciente.Enabled And (ChbAdministrador.Checked Or ChbMedico.Checked Or ChbPaciente.Checked) Then
            BtnAceptar.Enabled = True
        Else
            BtnAceptar.Enabled = False
        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ObtenerTipoUsuario()

    End Sub

    Private Sub ObtenerTipoUsuario()
        If ChbAdministrador.Checked And Not ChbMedico.Checked And Not ChbPaciente.Checked Then
            CrearPersona(3)

        ElseIf ChbMedico.Checked And Not ChbPaciente.Checked And Not ChbAdministrador.Checked Then
            CrearPersona(2)

        ElseIf ChbPaciente.Checked And Not ChbMedico.Checked And Not ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(1)

        ElseIf ChbAdministrador.Checked And ChbMedico.Checked And Not ChbPaciente.Checked Then
            CrearPersona(23)

        ElseIf ChbAdministrador.Checked And ChbPaciente.Checked And Not ChbMedico.Checked Then
            CargarPaciente()
            CrearPersona(13)

        ElseIf ChbMedico.Checked And ChbPaciente.Checked And Not ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(12)

        ElseIf ChbMedico.Checked And ChbPaciente.Checked And ChbAdministrador.Checked Then
            CargarPaciente()
            CrearPersona(123)

        End If

    End Sub

    Private Sub CargarPaciente()
        TipoUsuario(0) = True

        FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString() + "-" + DtpFechaNacimiento.Value.Month.ToString() + "-" + DtpFechaNacimiento.Value.Day.ToString()
        MsgBox(FechaNacimiento)
        For x = 0 To LstEnfermedadCronica.Items.Count - 1
            EnfermedadesCronicas.Add(LstEnfermedadCronica.Items(x).ToString)
        Next

        For y = 0 To LstMedicacion.Items.Count - 1
            Medicamentos.Add(LstMedicacion.Items(y).ToString)
        Next

        If RdbF.Checked() Then
            Sexo = "0"
        Else
            Sexo = "1"
        End If

    End Sub

    Private Sub TxtEnfermedadCronica_TextChanged(sender As Object, e As EventArgs) Handles TxtEnfermedadCronica.TextChanged
        If TxtEnfermedadCronica.Text <> "" Then
            BtnAgregarEnfermedad.Enabled = True
        Else
            BtnAgregarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click
        LstEnfermedadCronica.Items.Add(TxtEnfermedadCronica.Text)
        TxtEnfermedadCronica.Clear()

    End Sub

    Private Sub LstEnfermedadCronica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstEnfermedadCronica.SelectedIndexChanged
        If LstEnfermedadCronica.SelectedIndices.Count() > 0 Then
            BtnEliminarEnfermedad.Enabled = True
        Else
            BtnEliminarEnfermedad.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click
        LstEnfermedadCronica.Items.Remove(LstEnfermedadCronica.SelectedItems(0))

    End Sub

    Private Sub TxtMedicacion_TextChanged(sender As Object, e As EventArgs) Handles TxtMedicacion.TextChanged
        If TxtMedicacion.Text <> "" Then
            BtnAgregarMedicacion.Enabled = True
        Else
            BtnAgregarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click
        LstMedicacion.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Clear()

    End Sub

    Private Sub LstMedicacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstMedicacion.SelectedIndexChanged
        If LstMedicacion.SelectedIndices.Count() > 0 Then
            BtnEliminarMedicacion.Enabled = True
        Else
            BtnEliminarMedicacion.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click
        LstMedicacion.Items.Remove(LstMedicacion.SelectedItems(0))

    End Sub

    Private Sub CrearPersona(Tipo As Integer)
        CrearContra()
        If Tipo = 1 Then
            CrearPaciente()
        ElseIf Tipo = 2 Then
            CrearMedico()
        ElseIf Tipo = 3 Then
            CrearAdministrativo()
        ElseIf Tipo = 12 Then
            CrearPacienteMedico()
        ElseIf Tipo = 13 Then
            CrearPacienteAdmin()
        ElseIf Tipo = 23 Then
            CrearMedicoAdmin()
        ElseIf Tipo = 123 Then
            CrearPacienteMedicoAdmin()
        End If

    End Sub

    Private Sub CrearPaciente()
        Try
            ControladorUsuario.NuevoPaciente(TxtCI.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtMail.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("paciente creado con exito!")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al paciente" + ex.ToString)
        End Try
    End Sub

    Private Sub CrearMedico()
        Try
            ControladorUsuario.NuevoMedico(TxtCI.Text,
                                            TxtNombre.Text,
                                            TxtApellido.Text,
                                            TxtMail.Text,
                                            Contra)
            MsgBox("medico creado con exito!")
            EnviarMail()

        Catch ex As Exception
            MsgBox("Error al crear al medico")
        End Try

    End Sub

    Private Sub CrearAdministrativo()
        Try
            ControladorUsuario.NuevoAdministrativo(TxtCI.Text,
                                                   TxtNombre.Text,
                                                   TxtApellido.Text,
                                                   TxtMail.Text,
                                                   Contra)
            MsgBox("Administrativo creado con exito!")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al administrativo" + ex.ToString())

        End Try
    End Sub

    Private Sub CrearPacienteMedico()
        Try
            ControladorUsuario.NuevoPacienteMedico(TxtCI.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtMail.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("Paciente medico creado con exito")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error creando al usuario " + TxtNombre.Text + " " + ex.ToString)
        End Try
    End Sub

    Private Sub CrearPacienteAdmin()
        Try
            ControladorUsuario.NuevoPacienteAdmin(TxtCI.Text,
                                             TxtNombre.Text,
                                             TxtApellido.Text,
                                             TxtMail.Text,
                                             FechaNacimiento,
                                             Sexo,
                                             EnfermedadesCronicas,
                                             Medicamentos,
                                             Contra)
            MsgBox("El usuario se creo como paciente y administrativo")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al usuario " + ex.ToString)
        End Try

    End Sub

    Private Sub CrearMedicoAdmin()
        Try
            ControladorUsuario.NuevoMedicoAdmin(TxtCI.Text,
                                                TxtNombre.Text,
                                                TxtApellido.Text,
                                                TxtMail.Text,
                                                Contra)
            MsgBox("El usuario " + TxtNombre.Text + " fue creado con exito!")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear al administrativo, medico" + ex.ToString())

        End Try
    End Sub

    Private Sub CrearPacienteMedicoAdmin()
        Try
            ControladorUsuario.NuevoPacienteMedicoAdmin(TxtNombre.Text.Trim,
                                            TxtApellido.Text.Trim,
                                            TxtCI.Text.Trim,
                                            TxtMail.Text.Trim,
                                            FechaNacimiento,
                                            Sexo,
                                            EnfermedadesCronicas,
                                            Medicamentos,
                                            Contra)
            MsgBox("Persona creada con exito")
            EnviarMail()
        Catch ex As Exception
            MsgBox("Error al crear usuario")
        End Try
    End Sub

    Private Sub CrearContra()
        Dim rdm As New Random()
        Dim Mayus() As Char = "ABCDEFGHIJKLOMNOPQRSTUVWXYZ".ToCharArray()
        Dim Numeros() As Char = "0123456789".ToCharArray()
        Dim Especiales() As Char = "*_/".ToCharArray()
        Dim Caracteres() As Char = "abcdefghijklmnopqrstuvwxyz".ToCharArray()

        For i As Integer = 0 To 8
            If i < 6 Then
                Contra += Caracteres(rdm.Next(0, Caracteres.Length))
            ElseIf i = 6 Then
                Contra += Especiales(rdm.Next(0, Especiales.Length))
            ElseIf i = 7 Then
                Contra += Numeros(rdm.Next(0, Numeros.Length))
            Else
                Contra += Mayus(rdm.Next(0, Mayus.Length))
            End If
        Next

    End Sub

    Private Sub EnviarMail()
        Dim smtp As New SmtpClient()
        Dim Correo As New MailMessage()
        CargarSmtp(smtp)
        CargarDatos(Correo)
        EnviarMensaje(smtp, Correo)

    End Sub

    Private Sub CargarSmtp(smtp)
        With smtp
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential("cuidartegestor@gmail.com", "GesCuidarte")
            .Port = 587
            .EnableSsl = True
            .Host = "smtp.gmail.com"
        End With

    End Sub

    Private Sub CargarDatos(Correo)
        With Correo
            .From = New MailAddress("cuidartegestor@gmail.com", "Cuidarte", System.Text.Encoding.UTF8)
            Try
                .To.Add(TxtMail.Text)
            Catch ex As Exception
                If ex.HResult = -2146233033 Then
                    MsgBox("La direccion de correo no tiene un formato valido")
                End If
            End Try

            .Subject = "Credenciales De Cuidarte"
            .SubjectEncoding = System.Text.Encoding.UTF8
            .Body = "Estimado/a usuario/a. Gracias por utilizar Cuidarte. su usuario es: " + TxtCI.Text + " y su password es: " + Contra
            .BodyEncoding = System.Text.Encoding.UTF8
            .IsBodyHtml = False
        End With

    End Sub

    Private Sub EnviarMensaje(smtp, correo)
        Try
            smtp.Send(correo)
            MsgBox("Mensaje enviado")
        Catch ex As Exception
            If ex.HResult = "-2146233088" Then
                MsgBox(ex.ToString)
                'MsgBox("Usa este link capo: https: //myaccount.google.com/lesssecureapps")
            Else
                MsgBox(ex.ToString)
            End If
        End Try
        Limpiar()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCI.Text = ""
        TxtMail.Text = ""
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        DtpFechaNacimiento.Checked = False
        LstEnfermedadCronica.Items.Clear()
        LstMedicacion.Items.Clear()
        RdbF.Checked = False
        RdbM.Checked = False
        ChbAdministrador.Checked = False
        ChbMedico.Checked = False
        ChbPaciente.Checked = False

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuGestion.Show()
        Me.Close()

    End Sub


    Private Sub Btn_Click(sender As Object, e As EventArgs)
        BtnAceptar.Enabled = True

    End Sub

End Class