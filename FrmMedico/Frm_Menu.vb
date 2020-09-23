Imports CapaDeNegocio

Public Class Frm_Menu

    Dim IdDiagnostico As String
    Dim CiPaciente As String
    Dim Nombre As String
    Dim Apellido As String

    Private Sub MenuMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrBuscarMensajesNuevos.Stop()
        Dim LectorDatos As IDataReader

        Try
            LectorDatos = ControladorChatMedico.ObtenerMiNombreApellido()
            GuardarMisDatos(LectorDatos)

        Catch ex As Exception
            MsgBox("Error al setear las credenciales" + ex.ToString)

        End Try
        TmrBuscarChats.Start()
    End Sub

    Private Sub GuardarMisDatos(lector As IDataReader)
        While lector.Read
            Nombre = lector(0)
            Apellido = lector(1)

        End While

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        IdDiagnostico = DgvEnEspera.Item(0, DgvEnEspera.CurrentCell.RowIndex).Value
        CiPaciente = DgvEnEspera.Item(1, DgvEnEspera.CurrentCell.RowIndex).Value

        Try
            ControladorChatMedico.AceptarSolicitud(IdDiagnostico, CiPaciente, Nombre, Apellido)
            RtbConversacion.Text += "Chat iniciado con el paciente " + CiPaciente + Environment.NewLine
            WbbConversacion.DocumentText += ""
            EmpezarChat(IdDiagnostico, CiPaciente)
            TraerInformacionPaciente(CiPaciente)
            TmrBuscarChats.Stop()
        Catch ex As Exception
            MsgBox("Error al aceptar la solicitud")

        End Try

    End Sub

    Private Sub EmpezarChat(diagnostico As String, paciente As String)
        IdDiagnostico = diagnostico
        CiPaciente = paciente
        TmrBuscarMensajesNuevos.Start()
        RealizarCambios(True)

    End Sub

    Private Sub TraerInformacionPaciente(CedulaPaciente As String)
        Dim LectorDatos, LectorEnfermedades, LectorMedicaciones As IDataReader
        Try
            LectorDatos = ControladorPaciente.ObtenerTodo(CedulaPaciente)
            LectorEnfermedades = ControladorPaciente.ObtenerEnfermedades(CedulaPaciente)
            LectorMedicaciones = ControladorPaciente.ObtenerMedicaciones(CedulaPaciente)
            CargarLabelsPaciente(LectorDatos)
            CargarListaEnfermedades(LectorEnfermedades)
            CargarListaMedicaciones(LectorMedicaciones)
            MostrarDatosPaciente(True)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CargarLabelsPaciente(Lector As IDataReader)
        While Lector.Read
            LblNombrePaciente.Text = Lector(0).ToString + " " + Lector(1).ToString
            If Lector(2).ToString = 0 Then
                LblSexoPaciente.Text = "Hombre"
            Else
                LblSexoPaciente.Text = "Mujer"
            End If
            LblEdadPaciente.Text = ObtenerEdadPaciente(Lector(3).ToString) + " Años"

        End While
    End Sub

    Private Function ObtenerEdadPaciente(FechaNacimiento As Date)
        Return DateDiff(DateInterval.Year, FechaNacimiento, Date.Now)

    End Function

    Private Sub CargarListaEnfermedades(Enfermedades As IDataReader)
        While Enfermedades.Read
            LstEnfermedades.Items.Add(Enfermedades(0).ToString)
        End While
    End Sub

    Private Sub CargarListaMedicaciones(Medicaciones As IDataReader)
        While Medicaciones.Read
            LstMedicaciones.Items.Add(Medicaciones(0).ToString)
        End While
    End Sub

    Private Sub MostrarDatosPaciente(estado As Boolean)
        LblNombrePaciente.Visible = estado
        LblEdadPaciente.Visible = estado
        LblSexoPaciente.Visible = estado
        LstEnfermedades.Visible = estado
        LstMedicaciones.Visible = estado
    End Sub

    Public Sub RealizarCambios(estado As Boolean)
        BtnEnviar.Enabled = estado
        BtnFinalizarChat.Enabled = estado
        RtbMensaje.Enabled = estado
        BtnIniciarChat.Enabled = Not estado
        DgvEnEspera.Enabled = Not estado
        LstEnfermedades.Clear()
        LstMedicaciones.Clear()
    End Sub

    Private Sub TmrBuscarChats_Tick(sender As Object, e As EventArgs) Handles TmrBuscarChats.Tick
        Dim Tabla As New DataTable

        Try
            Tabla.Load(ControladorChatMedico.BuscarSolicitud())
            DgvEnEspera.DataSource = Tabla
        Catch ex As Exception
            MsgBox("No se pudieron encontrar solicitudes")
        End Try
    End Sub

    Private Sub TmrBuscarMensajesNuevos_Tick_1(sender As Object, e As EventArgs) Handles TmrBuscarMensajesNuevos.Tick
        Dim Tabla As New DataTable

        Try
            Tabla = ControladorChatMedico.BuscarMensajesNuevos(IdDiagnostico)
            AgregarChat(Tabla)

        Catch ex As Exception
            MsgBox("Error buscando mensajes" + ex.ToString)

        End Try

    End Sub

    Public Sub AgregarChat(tabla As DataTable)
        Try

            If tabla.Rows.Count > 0 Then
                ControladorChatMedico.MarcarComoLeido(IdDiagnostico)
                For Each fila As DataRow In tabla.Rows
                    If fila(5).ToString = "Iniciado" Then
                        RtbConversacion.Text += fila(1).ToString + ": " + Environment.NewLine + fila(2).ToString + Environment.NewLine

                    ElseIf fila(5).ToString = "Finalizado" Then
                        Threading.Thread.Sleep(1000)
                        Me.CambiosEnForm()

                    End If

                Next

            End If

        Catch ex As Exception
            MsgBox("Error en la conexion del chat" + ex.ToString)

        End Try

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            ControladorChatMedico.EnviarMensaje(IdDiagnostico, RtbMensaje.Text, CiPaciente)
            AgregarChat()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub AgregarChat()
        RtbConversacion.Text += "YO:" + Environment.NewLine + RtbMensaje.Text + Environment.NewLine
        RtbMensaje.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        Frm_Login.Close()

    End Sub

    Private Sub CambiosEnForm()
        RealizarCambios(False)
        TmrBuscarChats.Start()
        RtbConversacion.Clear()
        RtbMensaje.Clear()

    End Sub

    Private Sub MenuMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            ControladorChatMedico.FinalizarChat(IdDiagnostico, CiPaciente)

        Catch ex As Exception
            MsgBox("Error en la actualizacion del estado del chat")

        End Try

        CambiosEnForm()

    End Sub

    Private Sub BtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles BtnFinalizarChat.Click
        Try
            ControladorChatMedico.FinalizarChat(IdDiagnostico, CiPaciente)

        Catch ex As Exception
            MsgBox("Error en la actualizacion del estado del chat")

        End Try

        CambiosEnForm()

    End Sub

    Private Sub BtnRecomendaciones_Click(sender As Object, e As EventArgs) Handles BtnRecomendaciones.Click
        Me.Hide()
        Frm_Enviar_Recomendaciones.Show()

    End Sub
End Class
