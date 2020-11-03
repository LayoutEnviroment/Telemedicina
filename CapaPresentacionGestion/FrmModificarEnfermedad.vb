Imports CapaDeNegocio

Public Class FrmModificarEnfermedad

    Public IdEnfermedad As String

    Private Sub FrmModificarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerEnfermedades()
    End Sub

    Private Sub ObtenerEnfermedades()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            CargarEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox("No se pudieron traer las enfermedades")
        End Try
    End Sub

    Private Sub CargarEnfermedades(lector)
        CmbEnfermedades.Items.Clear()
        While lector.Read
            CmbEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedades.SelectedIndexChanged
        TxtNombre.Text = CmbEnfermedades.Text
        Try
            IdEnfermedad = ControladorEnfermedad.ObtenerId(CmbEnfermedades.SelectedItem.ToString)
            ObtenerDatos()
            If ChbModificarSintomas.Checked Then
                TraerSintomas(True)
            End If
        Catch ex As Exception
            MsgBox("No pudimos identificar la enfermedad")
        End Try
    End Sub

    Private Sub ObtenerDatos()
        Try
            TxtDescripcion.Text = ControladorEnfermedad.ObtenerDescripcion(IdEnfermedad)
            CmbPrioridad.Text = ControladorEnfermedad.ObtenerPrioridad(IdEnfermedad)
            HabilitarCampos()
        Catch ex As Exception
            MsgBox("No pudimos cargar los datos de la enfermedad")
        End Try

    End Sub

    Private Sub HabilitarCampos()
        TxtNombre.Enabled = True
        TxtDescripcion.Enabled = True
        CmbPrioridad.Enabled = True
        ChbModificarSintomas.Enabled = True

    End Sub

    Private Sub CbxModificarSintomas_CheckedChanged(sender As Object, e As EventArgs) Handles ChbModificarSintomas.CheckedChanged
        HabilitarSintomas(ChbModificarSintomas.Checked)
        TraerSintomas(ChbModificarSintomas.Checked)
        CargarSintomas()

    End Sub

    Private Sub HabilitarSintomas(estado As Boolean)
        LblSintomas.Enabled = estado
        CmbSintomas.Enabled = estado
        LstSintomas.Enabled = estado

    End Sub

    Private Sub TraerSintomas(estado As Boolean)
        If estado Then
            LstSintomas.Clear()
            Try
                Dim LectorSintomas As IDataReader = ControladorCompone.ObtenerSintomasEnfermedad(IdEnfermedad)
                While LectorSintomas.Read
                    LstSintomas.Items.Add(LectorSintomas(0).ToString)
                End While
            Catch ex As Exception
                MsgBox("error")
            End Try
        Else
            LstSintomas.Clear()
        End If


    End Sub

    Private Sub CargarSintomas()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()
            CargarCmbSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox("No se pudieron cargar los sintomas para la enfermedad")
        End Try

    End Sub

    Private Sub CargarCmbSintomas(lector)
        Dim i As Integer = 0
        CmbSintomas.Items.Clear()
        While lector.Read
            i = 0
            For x = 0 To LstSintomas.Items.Count() - 1
                If lector(0).ToString = LstSintomas.Items(x).Text Then
                    i = 1
                End If
            Next
            If i = 0 Then
                CmbSintomas.Items.Add(lector(0).ToString)
            End If

        End While

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        BtnAgregar.Enabled = True

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim index As Integer = CmbSintomas.SelectedIndex
        LstSintomas.Items.Add(CmbSintomas.Items(index))
        CmbSintomas.Items.RemoveAt(index)
        BtnAgregar.Enabled = False

    End Sub

    Private Sub LstSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstSintomas.SelectedIndexChanged
        BtnQuitar.Enabled = True

    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        CmbSintomas.Items.Add(LstSintomas.Items(LstSintomas.SelectedIndices(0)).Text)
        LstSintomas.Items.RemoveAt(LstSintomas.SelectedIndices(0))
        BtnQuitar.Enabled = False

    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If ChbModificarSintomas.Checked Then
            ValidarEnfermedadYSintoma()
        Else
            ValidarEnfermedad()
        End If

    End Sub

    Private Sub ValidarEnfermedadYSintoma()
        If TxtNombre.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Ninguno de los campos pueden estar vacios")

        ElseIf LstSintomas.Items.Count() <= 0 Then
            MsgBox("Debe existir por lo menos un sintoma")
        Else
            Dim Sintomas As New List(Of String)
            For x = 0 To LstSintomas.Items.Count() - 1
                Sintomas.Add(LstSintomas.Items(x).Text)
            Next
            CambiarEnfermedadYSintomas(Sintomas)
        End If

    End Sub

    Private Sub CambiarEnfermedadYSintomas(sintomas As List(Of String))
        Try
            ControladorEnfermedad.CambiarEnfermedadYSintomas(IdEnfermedad,
                                                             TxtNombre.Text,
                                                             TxtDescripcion.Text,
                                                             CmbPrioridad.SelectedItem.ToString,
                                                             sintomas)
            MsgBox("Se modifico la enfermedad y su composicion con exito!")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudieron actualizar los datos" + ex.ToString)
        End Try
    End Sub

    Private Sub ValidarEnfermedad()
        If TxtNombre.Text = "" Or TxtDescripcion.Text = "" Then
            MsgBox("Ninguno de los campos pueden estar vacios")
        Else
            CambiarEnfermedad()
        End If

    End Sub

    Private Sub CambiarEnfermedad()
        Try
            ControladorEnfermedad.CambiarEnfermedad(IdEnfermedad,
                                                    TxtNombre.Text,
                                                    TxtDescripcion.Text,
                                                    CmbPrioridad.SelectedItem.ToString)
            MsgBox("enfermedad modificada con exito!")
            Limpiar()
        Catch ex As Exception
            MsgBox("No se pudieron modificar los datos de la enfermedad")
        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Limpiar()
        Me.Dispose()
        FrmMenuGestion.Show()

    End Sub

    Private Sub Limpiar()
        If ChbModificarSintomas.Checked Then
            LimpiarEnfermedad()
            LimpiarSintomas()
        Else
            LimpiarEnfermedad()
        End If
        CmbPrioridad.Text = ""
        TxtDescripcion.Enabled = False
        TxtNombre.Enabled = False
        CmbPrioridad.Enabled = False

    End Sub

    Private Sub LimpiarEnfermedad()
        CmbPrioridad.Text = ""
        TxtDescripcion.Text = ""
        TxtNombre.Text = ""
        CmbEnfermedades.SelectedItem = -1
        ObtenerEnfermedades()

    End Sub

    Private Sub LimpiarSintomas()
        LstSintomas.Clear()
        CmbSintomas.Items.Clear()
        CmbSintomas.SelectedItem = -1
        ChbModificarSintomas.Checked = False

    End Sub

End Class