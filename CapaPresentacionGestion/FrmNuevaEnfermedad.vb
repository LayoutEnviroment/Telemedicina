Imports CapaDeNegocio

Public Class FrmNuevaEnfermedad

    Public ListaSintomas As New List(Of String)
    Public Nombre, Descripcion, Prioridad As Boolean

    Private Sub FrmNuevaEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintomas()
    End Sub

    Private Sub CargarSintomas()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombre()
            CargarCmbSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox(ex.ToString + "No se pudieron cargar los sintomas")
        End Try
    End Sub

    Private Sub CargarCmbSintomas(lector As IDataReader)
        While lector.Read
            CmbSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        ListaSintomas.Add(CmbSintomas.SelectedItem.ToString())
        CargarListado()
        HabilitarCreacion()
    End Sub

    Private Sub CargarListado()
        LstSintomasSeleccionados.Clear()
        For Each sintoma In ListaSintomas
            LstSintomasSeleccionados.Items.Add(sintoma)
        Next

    End Sub

    Private Sub LstSintomasSeleccionados_DoubleClick(sender As Object, e As EventArgs) Handles LstSintomasSeleccionados.DoubleClick
        LstSintomasSeleccionados.Items.RemoveAt(LstSintomasSeleccionados.SelectedIndices(0))
        ActualizarLista()

    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LstSintomasSeleccionados.Items.Count - 1
            ListaSintomas.Add(LstSintomasSeleccionados.Items(x).Text)
        Next

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        Try
            ControladorEnfermedad.CrearEnfermedad(TxtNombre.Text,
                                                  TxtDescripcion.Text,
                                                  CmbPrioridad.SelectedItem.ToString,
                                                  ListaSintomas)
        Catch ex As Exception
            MsgBox(ex.ToString + "No se pudo ingresar la enfermedad")
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged
        HabilitarCreacion()
    End Sub

    Private Sub Limpiar()
        TxtNombre.Clear()
        TxtDescripcion.Clear()
        LstSintomasSeleccionados.Clear()
        ListaSintomas.Clear()
    End Sub

    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged
        If ControladorEnfermedad.ObtenerExistencia(TxtNombre.Text) Then
            LblDisponible.Text = "Enfermedad existente"
            Nombre = False
        Else
            LblDisponible.Text = "Nombre disponible"
            Nombre = True
        End If
        HabilitarCreacion()
    End Sub

    Private Sub HabilitarCreacion()
        If Nombre And Descripcion And Prioridad And LstSintomasSeleccionados.Items.Count() > 0 Then
            BtnCrear.Enabled = True
        Else
            BtnCrear.Enabled = False
        End If

    End Sub

End Class