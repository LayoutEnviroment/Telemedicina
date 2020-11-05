Imports CapaDeNegocio

Public Class FrmEliminarSintoma

    Private Sub FrmEliminarSintoma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerSintomas()

    End Sub

    Private Sub ObtenerSintomas()

        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()
            CargarSintomas(LectorSintomas)

        Catch ex As Exception
            MsgBox("No pudimos cargar los sintomas, intente reiniciar la aplicacion", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub CargarSintomas(lector As IDataReader)
        CmbSintomas.Items.Clear()
        While lector.Read
            CmbSintomas.Items.Add(lector(0))
        End While

    End Sub
    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        TxtSintoma.Text = CmbSintomas.SelectedItem.ToString()
        PctAceptar.Enabled = True

    End Sub

    Private Sub PctAceptar_Click(sender As Object, e As EventArgs) Handles PctAceptar.Click
        Select Case MsgBox("¿Seguro desea eliminar este sintoma? Esta operación NO puede deshacerse", MsgBoxStyle.YesNo)
            Case MsgBoxResult.Yes
                Try
                    ControladorSintoma.EliminarSintoma(ControladorSintoma.ObtenerId(TxtSintoma.Text))
                    MsgBox("Sintoma eliminado con exito", MsgBoxStyle.Information)
                    TxtSintoma.Text = ""
                    ObtenerSintomas()
                    PctAceptar.Enabled = False
                Catch ex As Exception
                    MsgBox("Error al intenar eliminar el sintoma", MsgBoxStyle.Critical)
                End Try

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub FrmEliminarSintoma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub Limpiar()
        TxtSintoma.Text = ""
        CmbSintomas.ResetText()

    End Sub

    Private Sub PctSalir_MouseEnter(sender As Object, e As EventArgs) Handles PctSalir.MouseEnter
        PctSalir.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalir_MouseLeave(sender As Object, e As EventArgs) Handles PctSalir.MouseLeave
        PctSalir.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalir_MouseClick(sender As Object, e As EventArgs) Handles PctSalir.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub PctAceptar_MouseEnter(sender As Object, e As EventArgs) Handles PctAceptar.MouseEnter
        PctAceptar.Image = My.Resources.Aceptar2

    End Sub

    Private Sub PctAceptar_MouseLeave(sender As Object, e As EventArgs) Handles PctAceptar.MouseLeave
        PctAceptar.Image = My.Resources.Aceptar1

    End Sub

End Class