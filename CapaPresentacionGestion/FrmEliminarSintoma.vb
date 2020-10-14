Imports CapaDeNegocio

Public Class FrmEliminarSintoma
    Private Sub FrmEliminarSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintoma()

    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()

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
        BtnAceptar.Enabled = True
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Select Case MsgBox("¿Seguro desea eliminar este sintoma? Esta operación NO puede deshacerse", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    ControladorSintoma.EliminarSintomaPorNombre(TxtSintoma.Text)
                    MsgBox("Sintoma eliminado con exito")
                    TxtSintoma.Text = ""
                    BtnAceptar.Enabled = False
                Catch ex As Exception
                    MsgBox("Error al eliminar el sintoma" + ex.ToString)
                End Try

            Case MsgBoxResult.No

        End Select
    End Sub

    Private Sub FrmEliminarSintoma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        FrmMenuGestion.Show()
    End Sub
End Class