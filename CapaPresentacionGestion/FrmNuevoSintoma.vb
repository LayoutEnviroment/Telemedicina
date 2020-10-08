Imports CapaDeNegocio

Public Class FrmNuevoSintoma

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If ControladorSintoma.ObtenerExistencia(TxtNombre.Text) = 1 Or TxtNombre.Text = "" Then
            ModificarLabel(True)
            ModificarBoton(True)
        Else
            ModificarLabel(False)
            ModificarBoton(False)
        End If
    End Sub

    Private Sub ModificarLabel(estado As Boolean)
        If estado = True Then
            LblDisponibilidad.Text = "Texto vacío o sintoma existente"
        Else
            LblDisponibilidad.Text = "Sintoma inexistente"
        End If

    End Sub

    Private Sub ModificarBoton(estado As Boolean)
        BtnAceptar.Enabled = Not estado
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            ControladorSintoma.CrearSintoma(TxtNombre.Text)
            MsgBox("Sintoma creado con exito")
            TxtNombre.Text = ""
        Catch ex As Exception
            MsgBox("No se pudo crear el sintoma" + ex.ToString)
        End Try
    End Sub

    Private Sub FrmNuevoSintoma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MenuGestion.Show()
    End Sub
End Class