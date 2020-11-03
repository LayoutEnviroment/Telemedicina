Imports CapaDeNegocio

Public Class FrmNuevaEnfermedad

    Public ListaSintomas As New List(Of String)
    Public Nombre, Descripcion, Prioridad, Sintomas, Reactivacion As Boolean

    Private Sub FrmNuevaEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSintomas()
    End Sub

    Private Sub CargarSintomas()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()
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
        ListaSintomas.Add(CmbSintomas.SelectedItem.ToString)
        CmbSintomas.Items.RemoveAt(CmbSintomas.SelectedIndex())
        Prioridad = True
        CargarListado()

    End Sub

    Private Sub CargarListado()
        LstSintomasSeleccionados.Clear()
        For Each sintoma In ListaSintomas
            LstSintomasSeleccionados.Items.Add(sintoma)
        Next
        VerificarCantidad()

    End Sub

    Private Sub LstSintomasSeleccionados_DoubleClick(sender As Object, e As EventArgs) Handles LstSintomasSeleccionados.DoubleClick
        CmbSintomas.Items.Add(LstSintomasSeleccionados.Items(LstSintomasSeleccionados.SelectedIndices(0)).Text)
        LstSintomasSeleccionados.Items.RemoveAt(LstSintomasSeleccionados.SelectedIndices(0))
        ActualizarLista()

    End Sub

    Private Sub DevolverSintomasAlCmb()
        For x = 0 To LstSintomasSeleccionados.Items.Count() - 1
            CmbSintomas.Items.Add(LstSintomasSeleccionados.Items(x).Text)
        Next

    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LstSintomasSeleccionados.Items.Count - 1
            ListaSintomas.Add(LstSintomasSeleccionados.Items(x).Text)
        Next
        VerificarCantidad()
    End Sub

    Private Sub VerificarCantidad()
        If LstSintomasSeleccionados.Items.Count() > 0 Then
            Sintomas = True
        Else
            Sintomas = False
        End If
        HabilitarCreacion(False)
    End Sub

    Private Sub TxtDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TxtDescripcion.TextChanged
        If TxtDescripcion.Text <> "" Then
            Descripcion = True
        Else
            Descripcion = False
        End If

        HabilitarCreacion(False)
    End Sub


    Private Sub TxtNombre_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

        If ControladorEnfermedad.ObtenerExistencia(TxtNombre.Text) = 1 Then
            AveriguarInactividad()

        ElseIf TxtNombre.Text = "" Then
            LblDisponible.Text = "El nombre no puede estar vacio"
            Nombre = False
            Reactivacion = False

        Else
            LblDisponible.Text = "Nombre disponible"
            Nombre = True
            Reactivacion = False

        End If
        HabilitarCreacion(Reactivacion)
    End Sub

    Private Sub AveriguarInactividad()
        If ControladorEnfermedad.EstaInactivo(TxtNombre.Text) = 1 Then
            BtnReactivar.Enabled = True
            Reactivacion = True
            LblDisponible.Text = "Esta enfermedad se encuentra inactiva, pulse reacitvar para volver a activarla"

        Else
            Reactivacion = False
            BtnReactivar.Enabled = False
            LblDisponible.Text = "El nombre de esta enfermedad ya esta en uso"

        End If

    End Sub

    Private Sub HabilitarCreacion(Reactivacion As Boolean)
        If Reactivacion Then
            BtnReactivar.Enabled = Reactivacion
            BtnCrear.Enabled = False

        ElseIf Nombre And Descripcion And Prioridad And LstSintomasSeleccionados.Items.Count() > 0 Then
            BtnReactivar.Enabled = Reactivacion
            BtnCrear.Enabled = True

        Else
            BtnReactivar.Enabled = Reactivacion
            BtnCrear.Enabled = False

        End If

    End Sub

    Private Sub BtnCrear_Click(sender As Object, e As EventArgs) Handles BtnCrear.Click
        If BtnCrear.Text = "Activar" Then
            Actualizar()
        Else
            Crear()
        End If

    End Sub

    Private Sub Actualizar()
        Try
            ControladorEnfermedad.ActivarEnfermedad(TxtNombre.Text)
        Catch ex As Exception
            MsgBox("No se pudo actualizar la enfermedad")
        End Try
    End Sub

    Private Sub Crear()
        Try
            ControladorEnfermedad.CrearEnfermedad(TxtNombre.Text,
                                                  TxtDescripcion.Text,
                                                  CmbPrioridad.SelectedItem.ToString,
                                                  ListaSintomas)
            MsgBox("Enfermedad creada exitosamente", MsgBoxStyle.Information)
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.ToString + "No se pudo ingresar la enfermedad")
        End Try
    End Sub

    Private Sub BtnReactivar_EnabledChanged(sender As Object, e As EventArgs) Handles BtnReactivar.EnabledChanged
        TxtDescripcion.Enabled = Not BtnReactivar.Enabled
        CmbPrioridad.Enabled = Not BtnReactivar.Enabled
        CmbSintomas.Enabled = Not BtnReactivar.Enabled
        LstSintomasSeleccionados.Enabled = Not BtnReactivar.Enabled

    End Sub

    Private Sub BtnReactivar_Click(sender As Object, e As EventArgs) Handles BtnReactivar.Click
        Select Case MsgBox("Esto hara que la enfermedad vuelva a estar activa", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                ReactivarEnfermedad()

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub ReactivarEnfermedad()
        Try
            ControladorEnfermedad.ReactivarEnfermedad(TxtNombre.Text)
            MsgBox("Enfermedad reactivada con exito!")
            Limpiar()

        Catch ex As Exception
            MsgBox("No se pudo reactivar la enfermedad" + ex.ToString)

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()

    End Sub

    Private Sub Limpiar()
        DevolverSintomasAlCmb()
        TxtNombre.Clear()
        TxtDescripcion.Clear()
        LstSintomasSeleccionados.Clear()
        ListaSintomas.Clear()

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

End Class