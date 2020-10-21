Imports CapaDeNegocio
Imports System.Net.Mail

Public Class Frm_BajaUsuario

    Dim rol(3) As Boolean
    Private Sub Frm_BajaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CmbCI.Items.Clear()
        While lector.Read
            CmbCI.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub DatosPersona()
        Dim DatosPersona As IDataReader
        Try
            DatosPersona = ControladorUsuario.TraerNombreApellidoMail(CmbCI.SelectedItem.ToString())
            LeerDatos(DatosPersona)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub LeerDatos(LectorDatos As IDataReader)
        While LectorDatos.Read
            TxtNombre.Text = LectorDatos(0).ToString
            TxtApellido.Text = LectorDatos(1).ToString
            TxtMail.Text = LectorDatos(2).ToString

        End While
    End Sub

    Private Sub EsPaciente()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 1) = 1 Then
            rol(1) = True
            ChbPaciente.Checked = True
            ChbPaciente.Enabled = False
        Else
            rol(1) = False
            ChbPaciente.Checked = False
            ChbPaciente.Enabled = True
        End If

    End Sub

    Private Sub EsMedico()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 2) = 1 Then
            rol(2) = True
            ChbMedico.Checked = True
            ChbMedico.Enabled = False
        Else
            rol(2) = False
            ChbMedico.Checked = False
            ChbMedico.Enabled = True
        End If

    End Sub

    Private Sub EsAdministrativo()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 3) = 1 Then
            rol(3) = True
            ChbAdministrador.Checked = True
            ChbAdministrador.Enabled = False
        Else
            rol(3) = False
            ChbAdministrador.Checked = False
            ChbAdministrador.Enabled = True
        End If
    End Sub

    Private Sub CmbCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCI.SelectedIndexChanged
        LimpiarCampos()
        DatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        HabilitarEliminar()
    End Sub

    Private Sub HabilitarEliminar()
        If ChbAdministrador.Checked = True Or ChbMedico.Checked = True Or ChbPaciente.Checked = True Then
            BtnEliminar.Enabled = True
        Else
            BtnEliminar.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            Select Case MsgBox("Esta seguro que desea eliminar", MsgBoxStyle.YesNo)
                Case DialogResult.Yes
                    Try
                        ControladorUsuario.EliminarPersona(CmbCI.SelectedItem)
                        CmbCI.Items.Clear()
                    Catch ex As Exception
                        MsgBox("No se puede eliminar al usuario", MsgBoxStyle.Critical)
                    End Try
                Case DialogResult.No

            End Select

        Catch
        End Try
    End Sub

    Private Sub LimpiarCampos()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtMail.Clear()
        ChbPaciente.Checked = False
        ChbMedico.Checked = False
        ChbAdministrador.Checked = False

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarCampos()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        FrmMenuGestion.Show()
        Me.Dispose()

    End Sub

End Class