Imports CapaDeNegocio

Public Class FrmEliminarEnfermedad

    Public Id As String

    Private Sub FrmEliminarEnfermedad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraerDatos()

    End Sub

    Private Sub TraerDatos()
        Dim LectorEnfermedades As IDataReader
        Try
            LectorEnfermedades = ControladorEnfermedad.ListarNombreEnfermedadesActivas()
            CargarCmbEnfermedades(LectorEnfermedades)
        Catch ex As Exception
            MsgBox(ex.ToString + "Error al cargar enfermedades")
        End Try

    End Sub

    Private Sub CargarCmbEnfermedades(lector As IDataReader)
        CmbEnfermedades.Items.Clear()
        While lector.Read
            CmbEnfermedades.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub CmbEnfermedades_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbEnfermedades.SelectedIndexChanged
        Try
            ObtenerDatos(ControladorEnfermedad.ObtenerId(CmbEnfermedades.SelectedItem.ToString))
        Catch ex As Exception
            MsgBox("No se pudo identificar la enfermedad")
        End Try
    End Sub

    Private Sub ObtenerDatos(id As String)
        Try
            TxtDescripcion.Text = ControladorEnfermedad.ObtenerDescripcion(id)
            TxtPrioridad.Text = ControladorEnfermedad.ObtenerPrioridad(id)
            ObtenerSintomas(id)
        Catch ex As Exception
            MsgBox("No se pudieron Obtener los datos")
        End Try

    End Sub

    Private Sub ObtenerSintomas(idEnfermedad)
        Id = idEnfermedad
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorCompone.ObtenerSintomasEnfermedad(idEnfermedad)
            MostrarSintomas(LectorSintomas)
        Catch ex As Exception
            MsgBox("No se pudieron obtener los sintomas de la enfermedad")
        End Try

    End Sub

    Private Sub MostrarSintomas(lector)
        LstSintomas.Clear()
        While lector.Read
            LstSintomas.Items.Add(lector(0).ToString)
        End While

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            ControladorEnfermedad.EliminarEnfermedad(Id)
            Limpiar()
            TraerDatos()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub Limpiar()
        TxtDescripcion.Text = ""
        TxtPrioridad.Text = ""
        LstSintomas.Clear()
    End Sub
End Class