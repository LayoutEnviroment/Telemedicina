Imports CapaDeNegocio

Public Class Frm_Menu

    Dim IdDiagnostico As String
    Dim CiPaciente As String
    Dim Nombre As String
    Dim Apellido As String
    Dim EstadoMenu As Boolean = False
    Dim Random As New Random()
    Dim Numero As Integer = Random.Next(1, 2)

    Private Sub MenuMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblDescripcionVentana.Text = "Buenos días, " + ControladorUsuario.ObtenerNombre()
        TmrBuscarMensajesNuevos.Stop()
        ObtenerMisDatos()
        BusquedaDeChats()

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
            PnlIniciarChat.Visible = True
        Else
            PnlIniciarChat.Visible = False
        End If

    End Sub

    Private Sub BtnIniciarChat_Click(sender As Object, e As EventArgs) Handles BtnIniciarChat.Click
        ArreglosVisuales()
        IdDiagnostico = DgvEnEspera.Item(0, DgvEnEspera.CurrentCell.RowIndex).Value
        CiPaciente = DgvEnEspera.Item(1, DgvEnEspera.CurrentCell.RowIndex).Value
        CargarDatosConsulta(IdDiagnostico, CiPaciente)

    End Sub

    Private Sub ArreglosVisuales()
        CerrarMenu()
        PctMenu.Enabled = False
        PnlIniciarChat.Visible = False
        AbrirMenuConversacion()
        PnlCerrarConversacion.Visible = True

    End Sub

    Private Sub AbrirMenuConversacion()
        PnlConversacion.BackColor = Color.FromArgb(53, 71, 94)
        While PnlConversacion.Width < 772
            PnlConversacion.Width += 4

        End While
    End Sub

    Private Sub CerrarMenuConversacion()
        PnlConversacion.BackColor = Color.FromArgb(217, 213, 233)
        While PnlConversacion.Width > 10
            PnlConversacion.Width = 10

        End While
    End Sub


    Private Sub CargarDatosConsulta(Id, Ci)

        Try
            ControladorChat.AceptarSolicitud(Id, Ci, Nombre, Apellido)
            AgregarMensajes("<p>Chat iniciado con el paciente " + ControladorUsuario.ObtenerNombre(Ci) + "</p>", 0)
            DgvEnEspera.Enabled = False
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
        BtnIniciarChat.Enabled = estado
        DgvEnEspera.Enabled = Not estado
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
            LblNombrePaciente.Text = "Nombre: " + Lector(0).ToString + " " + Lector(1).ToString
            LblSexoPaciente.Text = "Sexo: " + ObtenerSexo(Lector(3).ToString())
            LblEdadPaciente.Text = "Edad: " + ObtenerEdadPaciente(Lector(4).ToString) + " Años"
            MostrarDatosPaciente(True)
        End While

    End Sub

    Private Function ObtenerSexo(Sexo As String)
        If Sexo = 0 Then
            Return "Masculino"
        Else
            Return "Femenino"
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
        BusquedaDeChats()

    End Sub

    Private Sub BusquedaDeChats()
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
                        AgregarMensajes("<p> align = 'right'" + ControladorUsuario.ObtenerNombre(fila(1).ToString) + ": " + fila(2).ToString + "</p>", 1)

                    ElseIf fila(5).ToString = "Finalizado" Then
                        MsgBox("El paciente se ha desconectado")
                        Threading.Thread.Sleep(1000)
                        ReinicioDeBusqueda()
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
            AgregarMensajes("<p align = 'left'> Yo: " + RtbMensaje.Text + "</p>", 1)
            BtnEnviar.Enabled = False
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub AgregarMensajes(Mensaje As String, Emisor As Integer)
        WbbConversacion.DocumentText += Mensaje
        RtbMensaje.Clear()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs)
        Me.Close()

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

    Private Sub PctFinalizarChat_Click(sender As Object, e As EventArgs) Handles PctFinalizarChat.Click
        Select Case MsgBox("Seguro desea finalizar el chat?", MsgBoxStyle.YesNo, "caption")
            Case MsgBoxResult.Yes
                CambiosVisuales()
                FinalizarConversacion()

            Case MsgBoxResult.No

        End Select

    End Sub

    Private Sub CambiosVisuales()
        CerrarMenuConversacion()
        PctMenu.Enabled = True
        PctFinalizarChat.Visible = False
        DgvEnEspera.Enabled = True
    End Sub

    Private Sub FinalizarConversacion()
        Try
            ControladorChat.FinalizarChatMedico(IdDiagnostico, CiPaciente)
            ControladorChat.MarcarComoFinalizado(IdDiagnostico)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ReinicioDeBusqueda()

    End Sub

    Private Sub ReinicioDeBusqueda()
        MostrarDatosPaciente(False)
        TmrBuscarMensajesNuevos.Stop()
        IdDiagnostico = ""
        CiPaciente = ""
        BusquedaDeChats()
        CambiosEnForm()

    End Sub

    Private Sub BtnRecomendaciones_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Frm_Enviar_Recomendaciones.Show()

    End Sub

    Private Sub BtnConultas_Click(sender As Object, e As EventArgs)
        TmrBuscarChats.Stop()
        Me.Hide()
        FrmConsultas.Show()

    End Sub

    Private Sub RtbMensaje_TextChanged(sender As Object, e As EventArgs) Handles RtbMensaje.TextChanged
        If RtbMensaje.Text <> "" Then
            BtnEnviar.Enabled = True
        Else
            BtnEnviar.Enabled = False
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Dim i As Integer = PnlIniciarChat.Location.X
        While PnlIniciarChat.Location.X > 663
            PnlIniciarChat.Location = New Point(i, PnlIniciarChat.Location.Y)
            i -= 1
        End While

    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles PnlIniciarChat.MouseLeave

        Dim i As Integer = PnlIniciarChat.Location.X
        While PnlIniciarChat.Location.X < 773
            PnlIniciarChat.Location = New Point(i, PnlIniciarChat.Location.Y)
            i += 1
        End While

    End Sub

    Private Sub PctSalirLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles PctSalirLeft.MouseMove
        PctSalirLeft.Image = My.Resources.Salir2

    End Sub

    Private Sub PctSalirLeft_MouseLeave(sender As Object, e As EventArgs) Handles PctSalirLeft.MouseLeave
        PctSalirLeft.Image = My.Resources.Salir1

    End Sub

    Private Sub PctSalirLeft_Click(sender As Object, e As EventArgs) Handles PctSalirLeft.Click
        Me.Close()
        FrmLogin.Close()
    End Sub

    Private Sub PctMenu_Click(sender As Object, e As EventArgs) Handles PctMenu.Click
        EstadoMenu = Not EstadoMenu
        PctHistorial.Visible = True
        PctRecomendaciones.Visible = True
        If EstadoMenu Then
            AbrirMenu()
        Else
            CerrarMenu()
        End If

    End Sub

    Private Sub AbrirMenu()
        SeleccionarImagen()
        PnlMenu.BackColor = Color.FromArgb(53, 71, 94)
        While PnlMenu.Height < 410
            PnlMenu.Height += 1
        End While

    End Sub

    Private Sub SeleccionarImagen()
        If Numero = 1 Then
            PctRecomendaciones.Image = My.Resources.RecomendacionMen1
        Else
            PctRecomendaciones.Image = My.Resources.RecomendacionWomen1
        End If

    End Sub

    Private Sub CerrarMenu()
        PnlMenu.BackColor = Color.FromArgb(217, 223, 231)
        While PnlMenu.Height > 10
            PnlMenu.Height = 10
        End While

    End Sub

    Private Sub PctHistorial_MouseEnter(sender As Object, e As EventArgs) Handles PctHistorial.MouseEnter
        LblHistorial.Visible = True

    End Sub

    Private Sub PctHistorial_MouseLeave(sender As Object, e As EventArgs) Handles PctHistorial.MouseLeave
        LblHistorial.Visible = False

    End Sub

    Private Sub PctHistorial_Click(sender As Object, e As EventArgs) Handles PctHistorial.Click
        Me.Dispose()
        FrmConsultas.Show()

    End Sub

    Private Sub PctDatosPropios_Click(sender As Object, e As EventArgs) Handles PctRecomendaciones.Click
        Me.Dispose()
        Frm_Enviar_Recomendaciones.Show()
    End Sub

    Private Sub PctRecomendaciones_MouseEnter(sender As Object, e As EventArgs) Handles PctRecomendaciones.MouseEnter
        LblRecomendaciones.Visible = True

    End Sub

    Private Sub PctRecomendaciones_MouseLeave(sender As Object, e As EventArgs) Handles PctRecomendaciones.MouseLeave
        LblRecomendaciones.Visible = False

    End Sub

    Private Sub PctMenu_MouseEnter(sender As Object, e As EventArgs) Handles PctMenu.MouseEnter
        PctMenu.Image = My.Resources.MenuHamb2

    End Sub

    Private Sub PctMenu_MouseLeave(sender As Object, e As EventArgs) Handles PctMenu.MouseLeave
        PctMenu.Image = My.Resources.MenuHamb1

    End Sub

End Class