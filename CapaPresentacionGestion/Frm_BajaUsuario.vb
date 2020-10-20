Imports CapaDeNegocio
Imports System.Net.Mail

Public Class Frm_BajaUsuario
    Private Sub Frm_BajaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCedulas()
    End Sub

    Private Sub CmbCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCI.SelectedIndexChanged
        Dim LeerDatosDePersona As IDataReader
        LeerDatosDePersona = ControladorUsuario.TraerNombreApellidoMail(CmbCI.SelectedItem.ToString())
        While LeerDatosDePersona.Read
            TxtNombre.Text = LeerDatosDePersona.GetValue(0)
            TxtApellido.Text = LeerDatosDePersona.GetValue(1)
            TxtMail.Text = LeerDatosDePersona.GetValue(2)
        End While
    End Sub


    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Select Case MsgBox("Esta seguro que desea eliminar", MsgBoxStyle.YesNo)
                Case DialogResult.Yes
                    Try
                        ControladorUsuario.EliminarPersona(CmbCI.Text)
                        CmbCI.Items.Clear()
                    Catch ex As Exception
                        MsgBox("No se puede eliminar al usuario", MsgBoxStyle.Critical)
                    End Try
                Case DialogResult.No

            End Select

        Catch
        End Try
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
        CmbCI.Items.Clear()
        While lector.Read
            CmbCI.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtMail.Clear()
        ChbPaciente.Checked = False
        ChbMedico.Checked = False
        ChbAdministrador.Checked = False

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged

        If ControladorUsuario.ChequearPaciente(ci_persona:=0) Then
            ChbPaciente.Enabled = True
        Else
            ChbPaciente.Enabled = False
        End If

    End Sub

    Private Sub ChbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMedico.CheckedChanged

        If ControladorUsuario.ChequearMedico(ci_persona:=0) Then
            ChbMedico.Enabled = True
        Else
            ChbMedico.Enabled = False

        End If

    End Sub

    Private Sub ChbAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChbAdministrador.CheckedChanged

        If ControladorUsuario.ChequearAdministrativo(ci_persona:=0) Then
            ChbAdministrador.Enabled = True
        Else
            ChbAdministrador.Enabled = False

        End If

    End Sub

    Private Sub HabilitarEliminar()
        If ChbAdministrador.Checked = True Or ChbMedico.Checked = True Or ChbPaciente.Checked = True Then
            BtnEliminar.Enabled = True
        Else
            BtnEliminar.Enabled = False
        End If

    End Sub


    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuGestion.Show()
        Me.Close()

    End Sub

End Class