Imports CapaDeNegocio

Public Class FrmModificarAdministrativo
    Private Sub FrmModificarAdministrativo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCedulas()

    End Sub

    Private Sub CargarCedulas()
        Dim LectorCedula As IDataReader
        LectorCedula = ControladorUsuario.ObtenerCedulaAdministrativo()

        While LectorCedula.Read
            CmbCi.Items.Add(LectorCedula(0).ToString)
        End While

    End Sub

    Private Sub CmbCi_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbCi.SelectedIndexChanged
        TraerDatos()

    End Sub

    Private Sub TraerDatos()
        Dim LectorDatos As IDataReader
        LectorDatos = ControladorUsuario.TraerNombreApellidoMail(CmbCi.Text)
        CargarDatos(LectorDatos)

    End Sub

    Private Sub CargarDatos(lector As IDataReader)
        While lector.Read
            TxtNombre.Text = lector(0).ToString
            TxtApellido.Text = lector(1).ToString
            TxtMail.Text = lector(2).ToString

        End While

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            ControladorUsuario.ModificarPersona(TxtNombre.Text,
                                                TxtApellido.Text,
                                                TxtMail.Text,
                                                CmbCi.Text)
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
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtMail.Text = ""

    End Sub
End Class