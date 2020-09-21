Imports CapaDeNegocio

Public Class Frm_Menu

    Public ListaSintomas As New List(Of String)
    Dim NombreEnfermedad As String

    Private Sub Frm_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LblSaludo.Text = "Bienvenido, " + ControladorPaciente.ObtenerNombre() + ""

        Catch ex As Exception
            LblSaludo.Text = "Bienvenido!"

        End Try

        CargarSintoma()

    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombre()

            While LectorSintomas.Read
                CmbSintomas.Items.Add(LectorSintomas(0))
            End While

        Catch ex As Exception
            MsgBox("No pudimos cargar los sintomas, intente reiniciar la aplicacion", MsgBoxStyle.Critical)

        End Try

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

        Try
            NombreEnfermedad = ControladorCompone.EnfermedadesPosibles(ListaSintomas)
        Catch ex As Exception
            Try
                NombreEnfermedad = ControladorCompone.EnfermedadesPorAproximacion(ListaSintomas)
            Catch ex1 As Exception
                MsgBox("No se pudo encontrar una enfermedad")
            End Try

        End Try
        ControladorSintoma.GuardarSintomasPadecidos(ListaSintomas)
        ObtenerIdEnfermedadDiagnosticada()

    End Sub

    Public Sub ObtenerIdEnfermedadDiagnosticada()
        Dim IdEnfermedad As String
        MsgBox(NombreEnfermedad)
        If NombreEnfermedad <> "" Then
            Try
                IdEnfermedad = ControladorEnfermedad.ObtenerId(NombreEnfermedad)
                RealizarDiagnostico(IdEnfermedad)

            Catch ex As Exception
                MsgBox("No se pudo hallar el identificador de la enfermedad")

            End Try
        End If

    End Sub

    Public Sub RealizarDiagnostico(idEnfermedad As String)
        Try
            ControladorDiagnostico.Nuevo(ListaSintomas, idEnfermedad)
            Frm_Iniciar_Chat.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("No se pudo realizar un diagnostico" + ex.ToString)
        End Try


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

    Private Sub Frm_Paciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Close()

    End Sub

    Private Sub BtnConsultaHistorial_Click(sender As Object, e As EventArgs) Handles BtnConsultaHistorial.Click
        Consultas.Show()
        Me.Hide()

    End Sub

    Private Sub BtnDatosPriopios_Click(sender As Object, e As EventArgs) Handles BtnDatosPriopios.Click
        Frm_Cambiar_Datos_Propios.Show()
        Me.Hide()
    End Sub
End Class