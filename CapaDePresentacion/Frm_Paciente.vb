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
            CargarTextBoxes(LectorEnfermedad)
        Catch ex As Exception
            MsgBox("Hubo un error buscando la enfermedad")
        End Try

    End Sub

    Private Sub CargarTextBoxes(Lector As IDataReader)
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
        If TxtEnfermedad.Text = "" Then
            MsgBox("No se encontró un resultado con los sintomas ingresados", MsgBoxStyle.Information)
        Else
            Try
                ControladorDiagnostico.Nuevo(ListaSintomas, TxtEnfermedad.Text)
                PanelChat.Visible = True
            Catch ex As Exception
                MsgBox("No existe ninguna enfermedad relacionada a esos sintomas", MsgBoxStyle.Information)
            End Try
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