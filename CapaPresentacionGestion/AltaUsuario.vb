Imports CapaDeNegocio
Imports System.Net.Mail
Public Class AltaUsuario

    Dim TipoUsuario(3) As Boolean
    Dim FechaNacimiento As String
    Dim EnfermedadesCronicas As New List(Of String)
    Dim Medicamentos As New List(Of String)
    Dim Sexo As String
    Dim Contra As String

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged

        If ChbPaciente.Checked Then
            MuestraCampoPaciente()
        Else
            OcultaCampoPaciente()

        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        CrearContra()
        If ChbAdministrador.Checked Then
            TipoUsuario(3) = True

        Else
            TipoUsuario(3) = False
        End If

        If ChbMedico.Checked Then
            TipoUsuario(2) = True

        Else
            TipoUsuario(2) = False

        End If

        If ChbPaciente.Checked Then
            TipoUsuario(1) = True
            FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString() + "-" + DtpFechaNacimiento.Value.Month.ToString() + "-" + DtpFechaNacimiento.Value.Day.ToString()

            For x = 0 To LstEnfermedadCronica.Items.Count - 1
                EnfermedadesCronicas.Add(LstEnfermedadCronica.Items(x).ToString)
            Next

            For y = 0 To LstMedicacion.Items.Count - 1
                Medicamentos.Add(LstMedicacion.Items(y).ToString)
            Next

            If RdbF.Checked() Then
                Sexo = "0"

            End If
            If RdbM.Checked() Then
                Sexo = "1"

            End If
        Else
            TipoUsuario(1) = False
        End If
        Try
            ControladorUsuario.CrearPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtCI.Text.Trim, TxtMail.Text.Trim, TipoUsuario, FechaNacimiento, Sexo, EnfermedadesCronicas, Medicamentos, Contra)
            MsgBox("Usuario creado exitosamente")
            EnviarMail()
            Limpiar()
        Catch ex As Exception
            MsgBox("Error al crear usuario")
        End Try


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        MenuGestion.Show()
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

    Private Sub MuestraCampoPaciente()
        TxtEnfermedadCronica.Visible = True
        TxtMedicacion.Visible = True
        LstEnfermedadCronica.Visible = True
        LstMedicacion.Visible = True
        RdbF.Visible = True
        RdbM.Visible = True
        DtpFechaNacimiento.Visible = True
        LblFechaNacimiento.Visible = True
        LblEnfermedadCronica.Visible = True
        LblMedicacion.Visible = True
        LblSexo.Visible = True
        BtnAgregarEnfermedad.Visible = True
        BtnAgregarMedicacion.Visible = True
    End Sub

    Private Sub OcultaCampoPaciente()
        TxtEnfermedadCronica.Visible = False
        TxtMedicacion.Visible = False
        LstEnfermedadCronica.Visible = False
        LstMedicacion.Visible = False
        RdbF.Visible = False
        RdbM.Visible = False
        DtpFechaNacimiento.Visible = False
        LblFechaNacimiento.Visible = False
        LblEnfermedadCronica.Visible = False
        LblMedicacion.Visible = False
        LblSexo.Visible = False
        BtnAgregarEnfermedad.Visible = False
        BtnAgregarMedicacion.Visible = False
    End Sub
    Private Sub EnviarMail()
        Dim Correo As New MailMessage()
        Dim smtp As New SmtpClient()

        With smtp
            .UseDefaultCredentials = False
            .Credentials = New Net.NetworkCredential("cuidartegestor@gmail.com", "GesCuidarte")
            .Port = 587
            .EnableSsl = True
            .Host = "smtp.gmail.com"
        End With

        With Correo
            .From = New MailAddress("cuidartegestor@gmail.com", "Cuidarte", System.Text.Encoding.UTF8)
            .To.Add(TxtMail.Text)
            .Subject = "Credenciales De Cuidarte"
            .SubjectEncoding = System.Text.Encoding.UTF8
            .Body = "Estimado/a usuario/a. Gracias por utilizar Cuidarte. su usuario es: " + TxtMail.Text + " y su password es: " + Contra
            .BodyEncoding = System.Text.Encoding.UTF8
            .IsBodyHtml = False
        End With

        Try
            smtp.Send(Correo)
            MsgBox("Mensaje enviado")
        Catch ex As Exception
            If ex.HResult = "-2146233088" Then
                MsgBox("Usa este link capo: https: //myaccount.google.com/lesssecureapps")
            Else
                MsgBox(ex.ToString)
            End If
        End Try

    End Sub
    Private Sub CrearContra()
        Dim rdm As New Random
        Dim CarPermitidos() As Char = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLOMNOPQRSTUVWXYZ0123456789".ToCharArray()
        For i As Integer = 0 To 8
            Contra += CarPermitidos(rdm.Next(0, CarPermitidos.Length))
        Next
        MsgBox(Contra)
    End Sub


End Class