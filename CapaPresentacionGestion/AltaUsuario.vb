Imports CapaDeNegocio
Public Class AltaUsuario
    Private Sub AltaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged

        If ChbPaciente.CheckState = 1 Then
            MuestraCampoPaciente()
        Else
            OcultaCampoPaciente()


        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        ControladorUsuario.CrearAdministrativo(TxtNombre.Text.Trim, TxtApellido.Text.Trim, TxtCI.Text.Trim, TxtMail.Text.Trim)



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
        DtFechaNacimiento.Checked = False
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
        DtFechaNacimiento.Visible = True
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
        DtFechaNacimiento.Visible = False
        LblFechaNacimiento.Visible = False
        LblEnfermedadCronica.Visible = False
        LblMedicacion.Visible = False
        LblSexo.Visible = False
    End Sub
End Class