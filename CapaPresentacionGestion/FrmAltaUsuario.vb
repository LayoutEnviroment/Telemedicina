Imports CapaDeNegocio
Imports System.Net.Mail
Public Class FrmAltaUsuario

    Dim TipoUsuario(3) As Boolean
    Dim FechaNacimiento As String
    Dim EnfermedadesCronicas As New List(Of String)
    Dim Medicamentos As New List(Of String)
    Dim Sexo As String
    Dim Contra As String

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged, TxtNombre.Validated

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        If ChbPaciente.Checked Then
            CamposPaciente(True)
        Else
            CamposPaciente(False)

        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Contra = CrearContra()
        MsgBox(Contra)
        ObtenerTipoUsuario()
        EnviarMail()

    End Sub

    Private Sub ObtenerTipoUsuario()
        If ChbAdministrador.Checked Then
            TipoUsuario(2) = True

        End If

        If ChbMedico.Checked Then
            TipoUsuario(1) = True

        End If

        If ChbPaciente.Checked Then
            CargarPaciente()
        End If

        CrearPersona()

    End Sub

    Private Function CrearContra()
        Dim rdm As New Random()
        Dim Caracteres() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        Dim Pass As String = ""

        For i As Integer = 0 To 8
            Pass += Caracteres(rdm.Next(0, Caracteres.Length))
        Next

        Return Pass

    End Function

    Private Sub CargarPaciente()
        TipoUsuario(0) = True

        FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString() + "-" + DtpFechaNacimiento.Value.Month.ToString() + "-" + DtpFechaNacimiento.Value.Day.ToString()

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

    Private Sub CrearPersona()
        Try
            ControladorUsuario.CrearPersona(TxtNombre.Text.Trim,
                                            TxtApellido.Text.Trim,
                                            TxtCI.Text.Trim,
                                            TxtMail.Text.Trim,
                                            TipoUsuario,
                                            FechaNacimiento,
                                            Sexo,
                                            EnfermedadesCronicas,
                                            Medicamentos,
                                            Contra)
        Catch ex As Exception
            MsgBox("Error al crear usuario")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuGestion.Show()
        Me.Close()

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click
        LstEnfermedadCronica.Items.Add(TxtEnfermedadCronica.Text)
        TxtEnfermedadCronica.Clear()

    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click
        LstMedicacion.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Clear()

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
                MsgBox("Usa este link capo: https: //myaccount.google.com/lesssecureapps")
            Else
                MsgBox(ex.ToString)
            End If
        End Try
        Limpiar()

    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        If ChbAdministrador.Checked Then
            TipoUsuario(2) = True

        End If

        If ChbMedico.Checked Then
            TipoUsuario(1) = True

        End If

        If ChbPaciente.Checked Then
            TipoUsuario(0) = True
        End If
        MsgBox(TipoUsuario(0).ToString + ", " + TipoUsuario(1).ToString + ", " + TipoUsuario(2).ToString)

    End Sub

End Class