Imports CapaDeNegocio

Public Class Frm_Enviar_Recomendaciones

    Dim Correo As String

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Dim LectorCorreo As IDataReader
        Try
            LectorCorreo = ControladorUsuario.ObtenerMiCorreo()
            While LectorCorreo.Read
                Correo = LectorCorreo(0)
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CmbAcciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbAcciones.SelectedIndexChanged
        CmbSobre.Enabled = True
        MsgBox("Accion " + CmbAcciones.SelectedItem.ToString)
        VerificarCmb()
    End Sub

    Private Sub CmbSobre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSobre.SelectedIndexChanged
        MsgBox(" Sobre" + CmbSobre.SelectedItem.ToString)
        VerificarCmb()
    End Sub

    Private Sub VerificarCmb()
        MsgBox("Intentando entrar " + CmbAcciones.Text)
        If CmbAcciones.Text = "Modificar" Or CmbAcciones.Text = "Eliminar" Then
            MsgBox("Soy " + CmbAcciones.Text)
            If CmbSobre.Text = "Sintoma" Then
                CargarSintomas()
            ElseIf CmbSobre.Text = "Enfermedad" Then
                CargarEnfermedades()

            End If
        End If
    End Sub

    Private Sub HabilitarCmbItems()
        CmbItem.Enabled = True
        CmbItem.Visible = True
    End Sub

    Private Sub CargarSintomas()
        LimpiarCmbItems()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombre()

            While LectorSintomas.Read
                CmbItem.Items.Add(LectorSintomas(0))
            End While
            HabilitarCmbItems()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarEnfermedades()
        LimpiarCmbItems()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombre()

            While LectorEnfermedades.Read
                CmbItem.Items.Add(LectorEnfermedades(0))
            End While
            HabilitarCmbItems()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LimpiarCmbItems()
        CmbItem.Items.Clear()
    End Sub
End Class