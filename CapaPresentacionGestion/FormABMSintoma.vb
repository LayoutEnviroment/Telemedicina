Imports CapaDeNegocio


Public Class FormABMSintoma
    Public opcionFormulario As String = "INSERTAR"

    Private Sub txtIdSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtIdSintoma.TextChanged

    End Sub

    Private Sub txtNombreSintoma_TextChanged(sender As Object, e As EventArgs) Handles txtNombreSintoma.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If opcionFormulario = "INSERTAR" Then
            Try
                ControladorSintoma.CrearSintoma(txtNombreSintoma.Text.Trim)

            Catch ex As Exception
                MsgBox(ex.ToString())

            End Try

            Me.Close()
        ElseIf opcionFormulario = "MODIFICAR" Then
            Try
                ControladorSintoma.CambiarNombreDeSintoma(txtIdSintoma.Text, txtNombreSintoma.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        ElseIf opcionFormulario = "ELIMINAR" Then
            Try
                ControladorSintoma.EliminarSintoma(txtIdSintoma.Text)
            Catch ex As Exception

            End Try
        End If
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtIdSintoma.Text = ""
        txtNombreSintoma.Text = ""
        Me.Hide()
        FormSintoma.Show()
    End Sub
End Class