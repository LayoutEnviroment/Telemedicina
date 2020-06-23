Imports CapaDeNegocio


Public Class FormABMSintoma
    Public opcionFormulario As String

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If opcionFormulario = "INSERTAR" Then
            Try
                ControladorSintoma.CrearSintoma(TxtNombreSintoma.Text.Trim)
                FormSintoma.CargarSintomas()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try

            Me.Close()
        ElseIf opcionFormulario = "MODIFICAR" Then
            Try
                ControladorSintoma.CambiarNombreDeSintoma(TxtIdSintoma.Text, TxtNombreSintoma.Text)
                FormSintoma.DgvSintomasCargados.Refresh()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf opcionFormulario = "ELIMINAR" Then
            Try
                ControladorSintoma.EliminarSintoma(TxtIdSintoma.Text)
            Catch ex As Exception

            End Try
        End If
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TxtIdSintoma.Text = ""
        TxtNombreSintoma.Text = ""
        Me.Hide()
        FormSintoma.Show()
    End Sub

    Private Sub FormABMSintoma_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormSintoma.CargarSintomas()
    End Sub
End Class