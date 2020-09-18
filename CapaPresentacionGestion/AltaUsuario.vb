Imports CapaDeNegocio
Public Class AltaUsuario

    Dim TipoUsuario As Boolean()
    Dim FechaNacimiento As String
    Dim EnfermedadesCronicas As New List(Of String)
    Dim Medicamentos As New List(Of String)
    Dim Sexo As String

    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged

        If ChbPaciente.Checked Then
            MuestraCampoPaciente()
        Else
            OcultaCampoPaciente()


        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        ControladorUsuario.CrearPersona(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtCI.Text.Trim, TxtMail.Text.Trim)

        If ChbAdministrador.Checked Then
            TipoUsuario(1) = True
        End If

        If ChbMedico.Checked Then
            TipoUsuario(2) = True
        End If

        If ChbPaciente.Checked Then
            TipoUsuario(3) = True
            FechaNacimiento = DtpFechaNacimiento.Value.Year.ToString() + "-" + DtpFechaNacimiento.Value.Month.ToString() + "-" + DtpFechaNacimiento.Value.Day.ToString()

            For x = 0 To LstEnfermedadCronica.Items.Count - 1
                EnfermedadesCronicas.Add(LstEnfermedadCronica.Items(x).ToString)
            Next

            For y = 0 To LstMedicacion.Items.Count - 1
                Medicamentos.Add(LstMedicacion.Items(y).ToString)
            Next

            If RdbF.Checked() Then
                Sexo = "F"

            End If
            If RdbM.Checked() Then
                Sexo = "M"

            End If

            ControladorUsuario.CrearPaciente(FechaNacimiento, Sexo, Medicamentos, EnfermedadesCronicas)

        End If



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

    Private Sub RdbM_CheckedChanged(sender As Object, e As EventArgs) Handles RdbM.CheckedChanged

    End Sub

    Private Sub RdbF_CheckedChanged(sender As Object, e As EventArgs) Handles RdbF.CheckedChanged

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
    End Sub
End Class