Imports CapaDeNegocio

Public Class FrmNuevoSintoma

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If ControladorSintoma.ObtenerExistencia(TxtNombre.Text) = 1 Then
            ModificarLabel(True)
            ModificarBoton(True)
        Else
            ModificarLabel(False)
            ModificarBoton(False)
        End If
    End Sub

    Private Sub ModificarLabel(estado As Boolean)
        If estado = True Then
            LblDisponibilidad.Text = "El nombre del sintoma ya esta en uso"
        Else
            LblDisponibilidad.Text = "Sintoma inexistente"
        End If

    End Sub

    Private Sub ModificarBoton(estado As Boolean)
        BtnAceptar.Enabled = Not estado
    End Sub
End Class