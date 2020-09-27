Imports System.ComponentModel
Imports CapaDeNegocio

Public Class Frm_Consultas

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Diagnosticos As New DataTable
        Try
            Diagnosticos.Load(ControladorDiagnostico.TodosMisDiagnosticos())
            DgvDiagnosticos.DataSource = Diagnosticos
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MsgBox("No pudimos cargar sus diagnosticos")
        End Try
    End Sub

    Private Sub DgvDiagnosticos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDiagnosticos.CellContentClick
        RtbDescripcion.Text = ""
        RtbChat.Text = ""
        PnlInformacion.Visible = True
        Dim IdDiagnostico As String = DgvDiagnosticos.Item("Id", DgvDiagnosticos.CurrentCell.RowIndex).Value.ToString

        CargarEnfermedad(IdDiagnostico)
        CargarSintomas(IdDiagnostico)
        ExistenMensajes(IdDiagnostico)

    End Sub

    Private Sub CargarEnfermedad(id As String)
        Try
            Dim Enfermedad As IDataReader
            Enfermedad = ControladorDiagnostico.EnfermedadDiagnosticada(id)

            While Enfermedad.Read
                LblNombreEnfermedad.Text = Enfermedad(0)
                LblPrioridadEnfermedad.Text = Enfermedad(1)
                RtbDescripcion.Text = Enfermedad(2)
            End While

        Catch ex As Exception
            MsgBox("No se pudo obtener la enfermedad para este diagnostico" + ex.ToString)

        End Try

    End Sub

    Private Sub CargarSintomas(id As String)
        Try
            Dim Sintomas As New DataTable
            Sintomas.Load(ControladorDiagnostico.SintomasEnfermedadDiagnosticada(id))
            DgvSintomas.DataSource = Sintomas

        Catch ex As Exception
            MsgBox("No se pudieron obtener los sintomas para este diagnostico" + ex.ToString)

        End Try

    End Sub

    'Esta sub rutina obtiene TRUE o FALSE para saber si existen mensajes a este diagnostico
    Private Sub ExistenMensajes(idDiagnostico As String)

        Try
            Dim Existen As String = ControladorDiagnostico.ExistenMensajes(idDiagnostico)
            If Existen = 0 Then
                CargarMedico(idDiagnostico)
                CargarMensajes(idDiagnostico)
            Else
                RtbChat.Text = "No existio una conversacion para este diagnostico"
            End If

        Catch ex As Exception
            MsgBox("Error en el existen mensajes" + ex.ToString)
        End Try
    End Sub

    Private Sub CargarMedico(id As String)
        Try
            Dim Medico As IDataReader
            Medico = ControladorDiagnostico.MedicoDiagnostico(id)

            While Medico.Read
                LblMedico.Text = Medico(0) + " " + Medico(1)
            End While

        Catch ex As Exception
            MsgBox("No se pudo cargar al medico" + ex.ToString)
        End Try

    End Sub

    Public Sub CargarMensajes(idDiagnostico As String)
        Dim Lector As IDataReader
        Try
            Lector = ControladorChat.ObtenerMensajesDelDiagnostico(idDiagnostico)
            While Lector.Read
                RtbChat.Text += Lector(1).ToString + Environment.NewLine
            End While
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Frm_Consultas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Frm_Menu.Show()
    End Sub
End Class
