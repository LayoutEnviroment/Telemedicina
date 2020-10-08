Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Iniciar_Chat

    Public Sub Frm_Iniciar_Chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim idEnfermedad As String
        Try
            idEnfermedad = ControladorGenera.ObtenerIdEnfermedadGenerada()
            ObtenerDiagnostico()
            CargarTextBoxes(idEnfermedad)
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("No pudimos guardar el identificador de la enfermedad")
        End Try

    End Sub


    Private Sub ObtenerDiagnostico()
        Try
            TxtIdDiagnostico.Text = ControladorDiagnostico.ObtenerID()
        Catch ex As Exception
            MsgBox("Me activaron")
        End Try

    End Sub

    Public Sub CargarTextBoxes(idEnfermedad As String)
        Dim Lector As IDataReader
        Try
            Lector = ControladorEnfermedad.ObtenerTodo(idEnfermedad)
            While Lector.Read
                TxtEnfermedad.Text = Lector(0)
                TxtDescripcion.Text = Lector(1)
                TxtPrioridad.Text = Lector(2)
            End While
        Catch ex As Exception
            'MsgBox("Error cargando text boxes" + ex.ToString)
            TxtDescripcion.Text = "No se pudieron cargar los datos"
        End Try

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        Try
            ControladorChat.EnviarSolicitud(TxtIdDiagnostico.Text)
            Me.Hide()
            Frm_Chat.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
            'MsgBox("No pudimos ponerlo en cola de espera")

        End Try

    End Sub

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        Frm_Menu.Show()
    End Sub

    Private Sub Frm_Iniciar_Chat_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ObtenerDiagnostico()
    End Sub
End Class