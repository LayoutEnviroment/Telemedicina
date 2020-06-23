Imports CapaDeNegocio

Public Class FormABMEnfermedad
    Public opcionFormulario As String

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If opcionFormulario = "INSERTAR" Then
            Try
                FormEnfermedad.Show()
                ControladorEnfermedad.CrearEnfermedad(TxtNombreEnfermedad.Text.Trim, TxtDescripcionEnfermedad.Text, CmbPrioridad.Text)
            Catch ex As Exception
                MsgBox(ex.ToString())

            End Try
            Me.Close()

        ElseIf opcionFormulario = "MODIFICAR" Then
            Try
                ControladorEnfermedad.CambiarNombreDeEnfermedad(TxtIdEnfermedad.Text, TxtNombreEnfermedad.Text, TxtDescripcionEnfermedad.Text, CmbPrioridad.Text)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FormEnfermedad.Show()

        ElseIf opcionFormulario = "ELIMINAR" Then
            Try
                FormEnfermedad.Show()
                ControladorEnfermedad.EliminarEnfermedad(TxtIdEnfermedad.Text)
            Catch ex As Exception

            End Try
            FormEnfermedad.Show()
        End If
        Me.Close()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Try
            Me.Hide()
            FormEnfermedad.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormABMEnfermedad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormEnfermedad.CargarEnfermedad()
    End Sub
End Class