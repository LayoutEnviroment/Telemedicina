﻿Imports CapaDeNegocio

Public Class MenuGestion
    Private Sub BtnEnfermedad_Click(sender As Object, e As EventArgs)
        Me.Hide()
        FormEnfermedad.Show()
    End Sub

    'Private Sub BtnSintoma_Click(sender As Object, e As EventArgs)
    '    Me.Hide()
    '    FormSintoma.Show()
    'End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Me.Hide()
        AltaUsuario.Show()

    End Sub

    Private Sub PacienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PacienteToolStripMenuItem.Click
        Me.Hide()
        ModificarUsuarioPaciente.Show()
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
        ModificarUsuarioMedico.Show()

    End Sub

    Private Sub ModificarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem1.Click
        Me.Hide()
        FrmModificarSintoma.Show()

    End Sub

    Private Sub NuevoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem1.Click
        Me.Hide()
        FrmNuevoSintoma.Show()

    End Sub
End Class
