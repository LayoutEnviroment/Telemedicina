Imports CapaDeNegocio

Public Class ModificarUsuarioMedico
    Private Sub ModificarUsuarioMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim LectorCiMedico As IDataReader
        LectorCiMedico = ControladorUsuario.ObtenerCedulaMedico

        While LectorCiMedico.Read
            CmbCIMedico.Items.Add(LectorCiMedico.GetValue(0))
        End While
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TraerDatosDeMedico()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        MenuGestion.Show()
        Me.Close()
    End Sub

    Private Sub TraerDatosDeMedico()
        Dim LeerDatosDeMedico As IDataReader
        LeerDatosDeMedico = ControladorUsuario.TraerDatosDeMedico(CmbCIMedico.Text)
        CargarDatos(LeerDatosDeMedico)

    End Sub

    Private Sub CargarDatos(LeerDatosDeMedico As IDataReader)

        While LeerDatosDeMedico.Read
            TxtNombreMedico.Text = LeerDatosDeMedico.GetValue(0)
            TxtApellidoMedico.Text = LeerDatosDeMedico.GetValue(1)
            TxtMailMedico.Text = LeerDatosDeMedico.GetValue(2)

        End While


    End Sub

    Private Sub CmbCIMedico_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCIMedico.SelectedIndexChanged
        TraerDatosDeMedico()

    End Sub
End Class