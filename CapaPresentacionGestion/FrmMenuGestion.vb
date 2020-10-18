Imports CapaDeNegocio

Public Class FrmMenuGestion
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.Hide()
        FrmAltaUsuario.Show()

    End Sub

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        Me.Hide()
        FrmModificarPaciente.Show()
    End Sub

    Private Sub MenuGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LblBienvenida.Text = "Bienvenido/a " + ControladorUsuario.ObtenerNombre()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

    Private Sub MedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedicoToolStripMenuItem.Click
        Me.Hide()
        FrmModificarMedico.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        Me.Hide()
        FrmModificarSintoma.Show()

    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        Me.Hide()
        FrmNuevoSintoma.Show()

    End Sub

    Private Sub EliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem1.Click
        Me.Hide()
        FrmEliminarSintoma.Show()

    End Sub

    Private Sub SintomaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SintomaToolStripMenuItem1.Click
        Me.Hide()
        FrmSintomasCsv.Show()
    End Sub

    Private Sub NuevoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem2.Click
        Me.Hide()
        FrmNuevaEnfermedad.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem2.Click
        Me.Hide()
        FrmEliminarEnfermedad.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem2.Click
        Me.Hide()
        FrmModificarEnfermedad.Show()
    End Sub

    Private Sub FrmMenuGestion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        Frm_Login.Close()
    End Sub

    Private Sub AdministrativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrativoToolStripMenuItem.Click
        Me.Hide()
        FrmModificarAdministrativo.Show()

    End Sub

    Private Sub UsuarioToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem1.Click
        FrmModificarUsuario.Show()
    End Sub
End Class
