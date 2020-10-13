Imports CapaDeNegocio

Public Class FrmModificarMedico
    Private Sub ModificarUsuarioMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCedulas()

    End Sub

    Private Sub CargarCedulas()
        Dim LectorCiMedico As IDataReader
        LectorCiMedico = ControladorUsuario.ObtenerCedulaMedico

        While LectorCiMedico.Read
            CmbCIMedico.Items.Add(LectorCiMedico.GetValue(0))
        End While

    End Sub

    Private Sub CmbCIMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCIMedico.SelectedIndexChanged
        TraerDatosDeMedico()

    End Sub

    Private Sub TraerDatosDeMedico()
        Dim LeerDatosDeMedico As IDataReader
        LeerDatosDeMedico = ControladorUsuario.TraerNombreApellidoMail(CmbCIMedico.Text)
        CargarDatos(LeerDatosDeMedico)

    End Sub

    Private Sub CargarDatos(LeerDatosDeMedico As IDataReader)
        While LeerDatosDeMedico.Read
            TxtNombreMedico.Text = LeerDatosDeMedico.GetValue(0)
            TxtApellidoMedico.Text = LeerDatosDeMedico.GetValue(1)
            TxtMailMedico.Text = LeerDatosDeMedico.GetValue(2)

        End While

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            ControladorUsuario.ModificarPersona(TxtNombreMedico.Text,
                                                TxtApellidoMedico.Text,
                                                TxtMailMedico.Text,
                                                CmbCIMedico.Text)
            MsgBox("Modificacion realizada con exito")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo modificar la informacion")

        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        MenuGestion.Show()
        Me.Close()

    End Sub

    Private Sub Limpiar()
        TxtApellidoMedico.Text = ""
        TxtNombreMedico.Text = ""
        TxtMailMedico.Text = ""

    End Sub




End Class