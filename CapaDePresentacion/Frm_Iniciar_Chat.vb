Imports CapaDeNegocio

Public Class Frm_Iniciar_Chat

    Public Sub Frm_Iniciar_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DiagnosticarEnfermedad()
    End Sub

    'Public Sub DiagnosticarEnfermedad()
    '    Try
    '        TxtEnfermedad.Text = ControladorCompone.EnfermedadesPosibles(Frm_Menu.ListaSintomas)
    '    Catch ex As Exception
    '        Try
    '            TxtEnfermedad.Text = ControladorCompone.EnfermedadesPorAproximacion(Frm_Menu.ListaSintomas)
    '        Catch ex1 As Exception
    '            MsgBox("No se pudo encontrar una enfermedad")
    '        End Try

    '    End Try
    '    ObtenerIdEnfermedadDiagnosticada()

    'End Sub

    'Public Sub ObtenerIdEnfermedadDiagnosticada()
    '    Dim IdEnfermedad As String
    '    Try
    '        IdEnfermedad = ControladorEnfermedad.ObtenerId(TxtEnfermedad.Text)
    '        RealizarDiagnostico(IdEnfermedad)
    '    Catch ex As Exception
    '        MsgBox("No se pudo hallar el identificador de la enfermedad")
    '    End Try

    'End Sub

    'Public Sub RealizarDiagnostico(idEnfermedad As String)
    '    Try
    '        ControladorDiagnostico.Nuevo(Frm_Menu.ListaSintomas, idEnfermedad)
    '        CargarTextBoxes(idEnfermedad)
    '    Catch ex As Exception
    '        MsgBox("No se pudo realizar un diagnostico")
    '    End Try

    'End Sub

    Public Sub CargarTextBoxes(idEnfermedad As String)
        Try
            TxtIdDiagnostico.Text = ControladorDiagnostico.ObtenerID()
            TxtPrioridad.Text = ControladorEnfermedad.ObtenerPrioridad(idEnfermedad)
            TxtDescripcion.Text = ControladorEnfermedad.ObtenerDescripcion(idEnfermedad)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        Try
            ControladorChatPaciente.EnviarSolicitud(TxtIdDiagnostico.Text)
            Me.Hide()
            Frm_Chat.Show()

        Catch ex As Exception
            MsgBox("No pudimos ponerlo en cola de espera")

        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        Frm_Menu.Show()
    End Sub

End Class