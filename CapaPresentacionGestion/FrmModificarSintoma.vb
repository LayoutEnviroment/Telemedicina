Imports CapaDeNegocio

Public Class FrmModificarSintoma

    Public SintomaOriginal As String

    Private Sub FrmModificarSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintoma()

    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombre()

            While LectorSintomas.Read
                CmbSintomas.Items.Add(LectorSintomas(0))
            End While

        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("No pudimos cargar los sintomas, intente reiniciar la aplicacion", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        TxtSintoma.Text = CmbSintomas.SelectedItem.ToString()
        SintomaOriginal = TxtSintoma.Text
        BtnAceptar.Enabled = False
    End Sub

    Private Sub TxtSintoma_TextChanged(sender As Object, e As EventArgs) Handles TxtSintoma.TextChanged
        BtnAceptar.Enabled = Not Equals(TxtSintoma.Text, SintomaOriginal)

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            ControladorSintoma.CambiarNombreDeSintoma(TxtSintoma.Text)
            MsgBox("Sintoma modificado con exito")
            TxtSintoma.Text = ""
            RecargarSintomas()
        Catch ex As Exception
            MsgBox("Error modificando el sintoma seleccionado" + ex.ToString)
        End Try

    End Sub

    Private Sub RecargarSintomas()
        CmbSintomas.Items.Clear()
        CargarSintoma()

    End Sub

End Class