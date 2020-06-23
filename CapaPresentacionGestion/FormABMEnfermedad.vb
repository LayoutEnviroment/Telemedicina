Imports CapaDeNegocio

Public Class FormABMEnfermedad
    Public opcionFormulario As String

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If opcionFormulario = "INSERTAR" Then
            Try
                FormEnfermedad.Show()
                ControladorEnfermedad.CrearEnfermedad(txtNombreEnfermedad.Text.Trim, txtDescripcionEnfermedad.Text, cmbPrioridad.Text)
            Catch ex As Exception
                MsgBox(ex.ToString())

            End Try

            Me.Close()
        ElseIf opcionFormulario = "MODIFICAR" Then
            Try
                ControladorEnfermedad.CambiarNombreDeEnfermedad(txtIdEnfermedad.Text, txtNombreEnfermedad.Text, txtDescripcionEnfermedad.Text, cmbPrioridad.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormEnfermedad.Show()
        ElseIf opcionFormulario = "ELIMINAR" Then
            Try
                ControladorEnfermedad.EliminarEnfermedad(txtIdEnfermedad.Text)
            Catch ex As Exception

            End Try
            FormEnfermedad.Show()
        End If
        Me.Close()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Try
            Me.Hide()
            FormEnfermedad.Show()
        Catch ex As Exception

        End Try

    End Sub

End Class