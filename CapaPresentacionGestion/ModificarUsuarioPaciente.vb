Public Class ModificarUsuarioPaciente
    Private Sub ModificarUsuarioPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnAgregarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnAgregarEnfermedad.Click

    End Sub

    Private Sub BtnEliminarEnfermedad_Click(sender As Object, e As EventArgs) Handles BtnEliminarEnfermedad.Click

        LstEnfermedadCronica.Items.Add(TxtEnfermedadCronica.Text)
        TxtEnfermedadCronica.Clear()
    End Sub

    Private Sub BtnAgregarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnAgregarMedicacion.Click

        LstMedicacion.Items.Add(TxtMedicacion.Text)
        TxtMedicacion.Clear()
    End Sub

    Private Sub BtnEliminarMedicacion_Click(sender As Object, e As EventArgs) Handles BtnEliminarMedicacion.Click

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

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
        TxtCI.Text = ""
        TxtMail.Text = ""
        TxtEnfermedadCronica.Text = ""
        TxtMedicacion.Text = ""
        DtpFechaNacimiento.Checked = False
        LstEnfermedadCronica.Items.Clear()
        LstMedicacion.Items.Clear()
        RdbF.Checked = False
        RdbM.Checked = False

    End Sub
End Class