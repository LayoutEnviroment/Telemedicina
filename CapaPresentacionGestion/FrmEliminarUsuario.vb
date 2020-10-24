Imports CapaDeNegocio
Imports System.Net.Mail

Public Class FrmEliminarUsuario

    Dim rol(3) As Boolean
    Dim RolesAEliminar(3) As Boolean

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

    Private Sub CmbCI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCI.SelectedIndexChanged
        LimpiarCampos()
        ObtenerDatosPersona()
        EsPaciente()
        EsMedico()
        EsAdministrativo()
        HabilitarEliminar()

    End Sub

    Private Sub ObtenerDatosPersona()
        Dim DatosPersona As IDataReader
        Try
            DatosPersona = ControladorUsuario.TraerNombreApellidoMail(CmbCI.SelectedItem.ToString())
            CargarDatos(DatosPersona)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(1).ToString
            TxtMail.Text = lector(2).ToString

        End While

    End Sub

    Private Sub EsPaciente()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 1) = 1 Then
            rol(1) = True
            ChbPaciente.Checked = True
            ChbPaciente.Enabled = True
        Else
            rol(1) = False
            ChbPaciente.Checked = False
            ChbPaciente.Enabled = False
        End If

    End Sub

    Private Sub EsMedico()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 2) = 1 Then
            rol(2) = True
            ChbMedico.Checked = True
            ChbMedico.Enabled = True
        Else
            rol(2) = False
            ChbMedico.Checked = False
            ChbMedico.Enabled = False
        End If

    End Sub

    Private Sub EsAdministrativo()
        If ControladorUsuario.ExisteRol(CmbCI.SelectedItem.ToString, 3) = 1 Then
            rol(3) = True
            ChbAdministrador.Checked = True
            ChbAdministrador.Enabled = True
        Else
            rol(3) = False
            ChbAdministrador.Checked = False
            ChbAdministrador.Enabled = False
        End If

    End Sub

    Private Sub ChbPaciente_CheckedChanged(sender As Object, e As EventArgs) Handles ChbPaciente.CheckedChanged
        HabilitarEliminar()

    End Sub

    Private Sub ChbMedico_CheckedChanged(sender As Object, e As EventArgs) Handles ChbMedico.CheckedChanged
        HabilitarEliminar()

    End Sub

    Private Sub ChbAdministrador_CheckedChanged(sender As Object, e As EventArgs) Handles ChbAdministrador.CheckedChanged
        HabilitarEliminar()

    End Sub


    Private Sub HabilitarEliminar()
        If ChbAdministrador.Checked = Not rol(3) Or ChbMedico.Checked = Not rol(2) Or ChbPaciente.Checked = Not rol(1) Then
            BtnEliminar.Enabled = True
        Else
            BtnEliminar.Enabled = False
        End If

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        MensajeDeConfirmacion()
        'Try
        '    Select Case MsgBox("Esta seguro que desea eliminar", MsgBoxStyle.YesNo)
        '        Case DialogResult.Yes
        '            Try
        '                ControladorUsuario.EliminarPersona(CmbCI.SelectedItem)
        '                CmbCI.Items.Clear()
        '            Catch ex As Exception
        '                MsgBox("No se puede eliminar al usuario", MsgBoxStyle.Critical)
        '            End Try
        '        Case DialogResult.No

        '    End Select

        'Catch
        'End Try
    End Sub

    Private Sub MensajeDeConfirmacion()
        Dim Mensaje As String = "El usuario " + TxtNombre.Text + " será eliminado de: "
        If ChbPaciente.Checked = False And rol(0) = True Then
            Mensaje += "Rol paciente"
            RolesAEliminar(0) = True
        End If
        If ChbMedico.Checked = False And rol(1) = True Then
            Mensaje += "Rol Médico"
            RolesAEliminar(1) = True
        End If
        If ChbAdministrador.Checked = False And rol(2) = True Then
            Mensaje += "Rol Administrativo"
            RolesAEliminar(2) = True
        End If
        Dim i As Integer = 0
        For x = 0 To 3
            If rol(x) = RolesAEliminar(x) Then
                i += 1
            End If
        Next
        If i = 3 Then
            Mensaje += "Se eliminará a la persona"
        End If
        MsgBox(Mensaje)
        Mensaje = ""
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