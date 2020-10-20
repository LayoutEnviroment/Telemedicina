Imports CapaDeNegocio

Public Class Frm_Menu

    Dim IdDiagnostico As String
    Dim CiPaciente As String
    Dim Nombre As String
    Dim Apellido As String

    Private Sub MenuMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TmrBuscarMensajesNuevos.Stop()
        ObtenerMisDatos()

    End Sub

    Private Sub ObtenerMisDatos()
        Dim LectorDatos As IDataReader
        Try
            LectorDatos = ControladorUsuario.ObtenerNombreApellidoCedula()
            TmrBuscarChats.Start()
            GuardarMisDatos(LectorDatos)
        Catch ex As Exception
            MsgBox("Error al setear las credenciales" + ex.ToString)

        End Try

    End Sub

    Private Sub GuardarMisDatos(lector As IDataReader)
        While lector.Read
            Nombre = lector(0)
            Apellido = lector(1)
        End While

    End Sub

    Private Sub DgvEnEspera_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEnEspera.CellContentClick
        If DgvEnEspera.SelectedRows.Count() > 0 Then
            BtnIniciarChat.Enabled = True
        Else
            BtnIniciarChat.Enabled = False
        End If

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        IdDiagnostico = DgvEnEspera.Item(0, DgvEnEspera.CurrentCell.RowIndex).Value
        CiPaciente = DgvEnEspera.Item(1, DgvEnEspera.CurrentCell.RowIndex).Value
        CargarDatosConsulta(IdDiagnostico, CiPaciente)

    End Sub

    Private Sub CargarDatosConsulta(Id, Ci)
        MsgBox(Ci)
        Try
            ControladorChat.AceptarSolicitud(Id, Ci, Nombre, Apellido)
            MsgBox(ControladorPaciente.ObtenerNombre(Ci))
            AgregarMensajes("<p>Chat iniciado con el paciente " + ControladorPaciente.ObtenerNombre(Ci) + "</p>", 0)
            EmpezarChat()
            TraerInformacionPaciente(Ci)
            TmrBuscarChats.Stop()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub EmpezarChat()
        TmrBuscarMensajesNuevos.Start()
        RealizarCambios(True)

    End Sub

    Public Sub RealizarCambios(estado As Boolean)
        RtbMensaje.Enabled = estado
        BtnEnviar.Enabled = estado
        BtnFinalizarChat.Enabled = estado
        BtnIniciarChat.Enabled = estado
        DgvEnEspera.Enabled = Not estado
        BtnConultas.Enabled = Not estado
        BtnRecomendaciones.Enabled = Not estado
        LstEnfermedades.Clear()
        LstMedicaciones.Clear()

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
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub CargarLabelsPaciente(Lector As IDataReader)
        While Lector.Read
            LblNombrePaciente.Text = Lector(0).ToString + " " + Lector(1).ToString
            LblSexoPaciente.Text = ObtenerSexo(Lector(3).ToString())
            LblEdadPaciente.Text = ObtenerEdadPaciente(Lector(4).ToString) + " Años"
            MostrarDatosPaciente(True)
        End While

    End Sub

    Private Function ObtenerSexo(Sexo As String)
        If Sexo = 0 Then
            Return "Hombre"
        Else
            Return "Mujer"
        End If

    End Function

    Private Function ObtenerEdadPaciente(FechaNacimiento As Date)
        Return DateDiff(DateInterval.Year, FechaNacimiento, Date.Now).ToString()

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

    Private Sub TmrBuscarChats_Tick(sender As Object, e As EventArgs) Handles TmrBuscarChats.Tick
        Dim Tabla As New DataTable
        Try
            Tabla.Load(ControladorChat.BuscarSolicitud())
            DgvEnEspera.DataSource = Tabla

        Catch ex As Exception
            MsgBox("No se pudieron encontrar solicitudes" + ex.ToString)
        End Try

    End Sub

    Private Sub TmrBuscarMensajesNuevos_Tick_1(sender As Object, e As EventArgs) Handles TmrBuscarMensajesNuevos.Tick
        Dim Tabla As New DataTable
        Try
            Tabla = ControladorChat.BuscarMensajesNuevos(IdDiagnostico)
            AgregarChat(Tabla)

        Catch ex As Exception
            MsgBox("Error buscando mensajes" + ex.ToString)

        End Try

    End Sub

    Public Sub AgregarChat(tabla As DataTable)
        Try
            If tabla.Rows.Count > 0 Then

                ControladorChat.MarcarComoLeido(IdDiagnostico)
                For Each fila As DataRow In tabla.Rows
                    If fila(5).ToString = "Iniciado" Then
                        AgregarMensajes("<p>" + ControladorPaciente.ObtenerNombre(fila(1).ToString) + ": " + fila(2).ToString + "</p>", 1)

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
            ControladorChat.EnviarMensajeMedico(IdDiagnostico, RtbMensaje.Text, CiPaciente)
            AgregarMensajes("<p> Yo: " + RtbMensaje.Text + "</p>", 1)
            'AgregarChat()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub AgregarMensajes(Mensaje As String, Emisor As Integer)
        WbbConversacion.DocumentText += Mensaje
        RtbMensaje.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
        Frm_Login.Close()

    End Sub

    Private Sub CambiosEnForm()
        RealizarCambios(False)
        TmrBuscarChats.Start()
        WbbConversacion.DocumentText = ""
        RtbMensaje.Clear()

    End Sub

    Private Sub MenuMedico_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If IdDiagnostico <> "" Then
            FinalizarConversacion()
        End If

    End Sub

    Private Sub BtnFinalizarChat_Click(sender As Object, e As EventArgs) Handles BtnFinalizarChat.Click
        Select Case MsgBox("Esto hara que la enfermedad vuelva a estar activa", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                FinalizarConversacion()

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub FinalizarConversacion()
        Try
            ControladorChat.FinalizarChatMedico(IdDiagnostico, CiPaciente)
            ControladorChat.MarcarComoFinalizado(IdDiagnostico)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        MostrarDatosPaciente(False)
        CambiosEnForm()

    End Sub

    Private Sub BtnRecomendaciones_Click(sender As Object, e As EventArgs) Handles BtnRecomendaciones.Click
        Me.Hide()
        Frm_Enviar_Recomendaciones.Show()

    End Sub

    Private Sub BtnConultas_Click(sender As Object, e As EventArgs) Handles BtnConultas.Click
        TmrBuscarChats.Stop()
        Me.Hide()
        FrmConsultas.Show()

    End Sub



End Class
