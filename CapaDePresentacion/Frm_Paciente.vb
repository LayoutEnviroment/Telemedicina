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
        End Try
        MostrarResultado(LectorEnfermedad)

    End Sub
    Private Sub MostrarResultado(Lector As IDataReader)
        Try
            While Lector.Read
                TxtEnfermedad.Text = Lector(0)
                TxtPrioridad.Text = Lector(1)
                TxtDescripcion.Text = Lector(2)
            End While
        Catch ex As Exception
            MsgBox("Debe ingresar algún sintoma, entre mas preciso sea, mejor")
        End Try
        MostrarResultado()

    End Sub

    Private Sub MostrarResultado()
        If ListaSintomas.Count > 0 Then
            MsgBox("No encontramos una enfermedad adecuada para esos sintomas, de todas maneras puede iniciar un chat con un Medico", MsgBoxStyle.Information)
            PanelChat.Visible = True
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

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        PanelChat.Visible = False
        LvSintomas.Clear()
        ActualizarLista()

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click

    End Sub
End Class