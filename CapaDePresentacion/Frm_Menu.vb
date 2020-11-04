Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Menu

    Public Cedula As String
    Public ListaSintomas As New List(Of String)
    Dim NombreEnfermedad As String

    Private Sub Frm_Paciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If ControladorPaciente.ObtenerSexo = 0 Then
                LblSaludo.Text = "Bienvenido, " + ControladorUsuario.ObtenerNombre() + ""
            Else
                LblSaludo.Text = "Bienvenida, " + ControladorUsuario.ObtenerNombre() + ""
            End If

        Catch ex As Exception
            LblSaludo.Text = "Bienvenido!"

        End Try

        CargarSintoma()

    End Sub

    Private Sub CargarSintoma()
        Dim LectorSintomas As IDataReader
        Try
            LectorSintomas = ControladorSintoma.ListarNombreSintomaActivo()

            While LectorSintomas.Read
                CmbSintomas.Items.Add(LectorSintomas(0))
            End While

        Catch ex As Exception
            MsgBox("No pudimos cargar los sintomas, intente reiniciar la aplicacion", MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub CmbSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSintomas.SelectedIndexChanged
        Dim index As Integer = CmbSintomas.SelectedIndex
        ListaSintomas.Add(CmbSintomas.Items(index))
        CmbSintomas.Items.RemoveAt(index)
        CargarListado(ListaSintomas)

    End Sub

    Private Sub CargarListado(ListaSintomas As List(Of String))
        LvSintomas.Clear()
        For Each sintoma In ListaSintomas
            LvSintomas.Items.Add(sintoma)
        Next
        HabilitarRealizarDiagnostico()

    End Sub

    Private Sub BtnDiagnostico_Click(sender As Object, e As EventArgs) Handles BtnDiagnostico.Click
        Try
            NombreEnfermedad = ControladorCompone.EnfermedadesPosibles(ListaSintomas)
        Catch ex As Exception
            MsgBox("No se encontró una enfermedad que coincida de manera exacta, se buscará la mas probable", MsgBoxStyle.Information)
            Try
                NombreEnfermedad = ControladorCompone.EnfermedadesPorAproximacion(ListaSintomas)
            Catch ex1 As Exception

            End Try

        End Try
        GuardarPadecimientos()
        ObtenerIdEnfermedadDiagnosticada()
        VolverACargarSintomas()
        LvSintomas.Clear()
        ListaSintomas.Clear()

    End Sub

    Private Sub VolverACargarSintomas()
        For x = 0 To ListaSintomas.Count() - 1
            CmbSintomas.Items.Add(ListaSintomas(x).ToString)
        Next

    End Sub

    Private Sub GuardarPadecimientos()
        Try
            ControladorPadece.GuardarSintomasPadecidos(ListaSintomas)
        Catch ex As Exception
            MsgBox(ex.ToString())
            'MsgBox("No se pudieron registrar los sintomas padecidos")
        End Try
    End Sub

    Public Sub ObtenerIdEnfermedadDiagnosticada()
        Dim IdEnfermedad As String
        'MsgBox(NombreEnfermedad)
        If NombreEnfermedad <> "" Then
            Try
                IdEnfermedad = ControladorEnfermedad.ObtenerId(NombreEnfermedad)
                RealizarDiagnostico(IdEnfermedad)

            Catch ex As Exception
                MsgBox("Error obteniendo id enf" + ex.ToString)
                'MsgBox("No se pudo hallar el identificador de la enfermedad")

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
        CmbSintomas.Items.Add(LvSintomas.Items(LvSintomas.SelectedIndices(0)).Text)
        LvSintomas.Items.RemoveAt(LvSintomas.SelectedIndices(0))
        ActualizarLista()

    End Sub

    Private Sub ActualizarLista()
        ListaSintomas.Clear()
        For x = 0 To LvSintomas.Items.Count - 1
            ListaSintomas.Add(LvSintomas.Items(x).Text)
        Next
        HabilitarRealizarDiagnostico()
    End Sub

    Private Sub Frm_Paciente_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FrmLogin.Close()

    End Sub

    Private Sub BtnConsultaHistorial_Click(sender As Object, e As EventArgs) Handles BtnConsultaHistorial.Click
        Frm_Consultas.Show()
        Me.Hide()

    End Sub

    Private Sub BtnDatosPriopios_Click(sender As Object, e As EventArgs) Handles BtnDatosPriopios.Click
        Frm_Cambiar_Datos_Propios.Show()
        Me.Hide()
    End Sub

    Private Sub Frm_Menu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmLogin.Close()
    End Sub

    Private Sub LvSintomas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvSintomas.SelectedIndexChanged
        HabilitarRealizarDiagnostico()

    End Sub

    Private Sub HabilitarRealizarDiagnostico()
        If LvSintomas.Items.Count() > 0 Then
            BtnDiagnostico.Enabled = True
        Else
            BtnDiagnostico.Enabled = False
        End If
        ModificarAdvertencia()
    End Sub

    Private Sub ModificarAdvertencia()
        If LvSintomas.Items.Count() < 3 Then
            LblAdvertencia.Text = "La cantidad de sintomas es muy baja," + vbCrLf + " la enfermedad resultante será poco precisa"
        Else
            LblAdvertencia.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While Panel1.Height < 528
            Panel1.Height += 1
            While Panel1.Width < 178
                Panel1.Width += 1
            End While
        End While

    End Sub
End Class