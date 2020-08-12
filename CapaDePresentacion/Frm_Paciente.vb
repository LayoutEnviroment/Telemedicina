Imports CapaDeNegocio

Public Class Frm_Paciente
    'Esto vendra de la base de datos
    Dim Usuario As String = "Usuario"
    Dim ListaSintomas As New List(Of String)

    Private Sub Frm_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSaludo.Text = "Bienvenido, " + Usuario + ""
        CargarSintoma()
    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        LectorSintomas = ControladorSintoma.ListarNombre()
        While LectorSintomas.Read
            CmbSintomas.Items.Add(LectorSintomas(0))
        End While
    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        ListaSintomas.Add(CmbSintomas.SelectedItem.ToString())
        CargarListado(ListaSintomas)
    End Sub

    Private Sub CargarListado(ListaSintomas As List(Of String))
        LvSintomas.Clear()
        For Each sintoma In ListaSintomas
            LvSintomas.Items.Add(sintoma)
        Next

    End Sub

    Private Sub BtnDiagnostico_Click(sender As Object, e As EventArgs) Handles BtnDiagnostico.Click
        Dim LectorEnfermedad As IDataReader

        Try
            LectorEnfermedad = ControladorCompone.EnfermedadesPosibles(ListaSintomas)
        Catch ex As Exception
            MsgBox("Upss")
        End Try
        MostrarResultado(LectorEnfermedad)

    End Sub
    Private Sub MostrarResultado(Lector As IDataReader)
        While Lector.Read
            TxtEnfermedad.Text = Lector(0)
        End While

        If TxtEnfermedad.Text = "" Then
            MsgBox("No encontramos una enfermedad adecuada para esos sintomas", MsgBoxStyle.Information)
        End If


    End Sub

    Private Sub LvSintomas_DoubleClick(sender As Object, e As EventArgs) Handles LvSintomas.DoubleClick
        LvSintomas.Items.RemoveAt(LvSintomas.SelectedIndices(0))
        ActualizarLista()
    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LvSintomas.Items.Count - 1
            ListaSintomas.Add(LvSintomas.Items(x).Text)
        Next
    End Sub
End Class