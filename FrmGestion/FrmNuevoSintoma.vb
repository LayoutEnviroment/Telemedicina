Imports CapaDeNegocio

Public Class FrmNuevoSintoma

    Public Reactivacion, Nombre As Boolean

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If ControladorSintoma.ObtenerExistencia(TxtNombre.Text) = 1 Then
            MsgBox("Estoy")
            AveriguarInactividad()

        ElseIf TxtNombre.Text = "" Then
            LblDisponibilidad.Text = "El nombre no puede estar vacio"
            Nombre = False
            Reactivacion = False

        Else
            LblDisponibilidad.Text = "Nombre disponible"
            Nombre = True
            Reactivacion = False

        End If
        HabilitarCreacion(Reactivacion)

    End Sub

    Private Sub AveriguarInactividad()
        If ControladorSintoma.EstaInactivo(TxtNombre.Text) = 1 Then
            BtnReactivar.Enabled = True
            Reactivacion = True
            LblDisponibilidad.Text = "Este sintoma se encuentra inactiva, pulse reacitvar para volver a activarlo"

        Else
            Reactivacion = False
            BtnReactivar.Enabled = False
            LblDisponibilidad.Text = "El nombre del sintoma ya esta en uso"

        End If

    End Sub

    Private Sub HabilitarCreacion(Reactivacion As Boolean)
        If Reactivacion Then
            BtnReactivar.Enabled = Reactivacion
            BtnAceptar.Enabled = False

        ElseIf Nombre Then
            BtnReactivar.Enabled = Reactivacion
            BtnAceptar.Enabled = True

        Else
            BtnReactivar.Enabled = Reactivacion
            BtnAceptar.Enabled = False

        End If

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            ControladorSintoma.CrearSintoma(TxtNombre.Text)
            MsgBox("Sintoma creado con exito")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudo crear el sintoma" + ex.ToString)
        End Try

    End Sub

    Private Sub BtnReactivar_Click(sender As Object, e As EventArgs) Handles BtnReactivar.Click
        Try
            ControladorSintoma.ActivarSintoma(ControladorSintoma.ObtenerId(TxtNombre.Text))
            Limpiar()
            MsgBox("Sintoma reactivado con exito!")
        Catch ex As Exception
            MsgBox("No se pudo reactivar el sintoma")
        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        Me.Hide()
        FrmMenuGestion.Show()

    End Sub

    Private Sub Limpiar()
        TxtNombre.Text = ""

    End Sub

    Private Sub FrmNuevoSintoma_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Limpiar()
        Me.Hide()
        FrmMenuGestion.Show()

    End Sub

End Class