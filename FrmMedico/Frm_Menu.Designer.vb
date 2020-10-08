<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Menu))
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnFinalizarChat = New System.Windows.Forms.Button()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.BtnRecomendaciones = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DgvEnEspera = New System.Windows.Forms.DataGridView()
        Me.TmrBuscarMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.LblNombrePaciente = New System.Windows.Forms.Label()
        Me.LblSexoPaciente = New System.Windows.Forms.Label()
        Me.LblEdadPaciente = New System.Windows.Forms.Label()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.TmrBuscarChats = New System.Windows.Forms.Timer(Me.components)
        Me.WbbConversacion = New System.Windows.Forms.WebBrowser()
        Me.BtnConultas = New System.Windows.Forms.Button()
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbMensaje.Location = New System.Drawing.Point(346, 462)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(341, 47)
        Me.RtbMensaje.TabIndex = 3
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(706, 462)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(88, 47)
        Me.BtnEnviar.TabIndex = 4
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnFinalizarChat
        '
        Me.BtnFinalizarChat.Enabled = False
        Me.BtnFinalizarChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarChat.Location = New System.Drawing.Point(812, 538)
        Me.BtnFinalizarChat.Name = "BtnFinalizarChat"
        Me.BtnFinalizarChat.Size = New System.Drawing.Size(241, 26)
        Me.BtnFinalizarChat.TabIndex = 6
        Me.BtnFinalizarChat.Text = "Finalizar Chat"
        Me.BtnFinalizarChat.UseVisualStyleBackColor = True
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarChat.Location = New System.Drawing.Point(812, 151)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(241, 24)
        Me.BtnIniciarChat.TabIndex = 1
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = True
        '
        'BtnRecomendaciones
        '
        Me.BtnRecomendaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRecomendaciones.Location = New System.Drawing.Point(909, 26)
        Me.BtnRecomendaciones.Name = "BtnRecomendaciones"
        Me.BtnRecomendaciones.Size = New System.Drawing.Size(128, 29)
        Me.BtnRecomendaciones.TabIndex = 7
        Me.BtnRecomendaciones.Text = "Recomendaciones"
        Me.BtnRecomendaciones.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(909, 96)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(128, 29)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DgvEnEspera
        '
        Me.DgvEnEspera.AllowUserToAddRows = False
        Me.DgvEnEspera.AllowUserToDeleteRows = False
        Me.DgvEnEspera.AllowUserToOrderColumns = True
        Me.DgvEnEspera.AllowUserToResizeColumns = False
        Me.DgvEnEspera.AllowUserToResizeRows = False
        Me.DgvEnEspera.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvEnEspera.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DgvEnEspera.Location = New System.Drawing.Point(812, 195)
        Me.DgvEnEspera.MultiSelect = False
        Me.DgvEnEspera.Name = "DgvEnEspera"
        Me.DgvEnEspera.ReadOnly = True
        Me.DgvEnEspera.RowHeadersVisible = False
        Me.DgvEnEspera.RowTemplate.Height = 24
        Me.DgvEnEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEnEspera.Size = New System.Drawing.Size(241, 324)
        Me.DgvEnEspera.TabIndex = 9
        '
        'TmrBuscarMensajesNuevos
        '
        Me.TmrBuscarMensajesNuevos.Enabled = True
        '
        'LblNombrePaciente
        '
        Me.LblNombrePaciente.AutoSize = True
        Me.LblNombrePaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblNombrePaciente.Location = New System.Drawing.Point(41, 169)
        Me.LblNombrePaciente.Name = "LblNombrePaciente"
        Me.LblNombrePaciente.Size = New System.Drawing.Size(45, 13)
        Me.LblNombrePaciente.TabIndex = 10
        Me.LblNombrePaciente.Text = "Label1"
        Me.LblNombrePaciente.Visible = False
        '
        'LblSexoPaciente
        '
        Me.LblSexoPaciente.AutoSize = True
        Me.LblSexoPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblSexoPaciente.Location = New System.Drawing.Point(41, 206)
        Me.LblSexoPaciente.Name = "LblSexoPaciente"
        Me.LblSexoPaciente.Size = New System.Drawing.Size(45, 13)
        Me.LblSexoPaciente.TabIndex = 11
        Me.LblSexoPaciente.Text = "Label1"
        Me.LblSexoPaciente.Visible = False
        '
        'LblEdadPaciente
        '
        Me.LblEdadPaciente.AutoSize = True
        Me.LblEdadPaciente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblEdadPaciente.Location = New System.Drawing.Point(41, 243)
        Me.LblEdadPaciente.Name = "LblEdadPaciente"
        Me.LblEdadPaciente.Size = New System.Drawing.Size(45, 13)
        Me.LblEdadPaciente.TabIndex = 12
        Me.LblEdadPaciente.Text = "Label1"
        Me.LblEdadPaciente.Visible = False
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(44, 291)
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(131, 228)
        Me.LstEnfermedades.TabIndex = 13
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedades.Visible = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(198, 291)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(131, 228)
        Me.LstMedicaciones.TabIndex = 14
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.Visible = False
        '
        'TmrBuscarChats
        '
        Me.TmrBuscarChats.Interval = 10000
        '
        'WbbConversacion
        '
        Me.WbbConversacion.Location = New System.Drawing.Point(346, 195)
        Me.WbbConversacion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbbConversacion.Name = "WbbConversacion"
        Me.WbbConversacion.Size = New System.Drawing.Size(448, 250)
        Me.WbbConversacion.TabIndex = 15
        '
        'BtnConultas
        '
        Me.BtnConultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConultas.Location = New System.Drawing.Point(909, 61)
        Me.BtnConultas.Name = "BtnConultas"
        Me.BtnConultas.Size = New System.Drawing.Size(128, 29)
        Me.BtnConultas.TabIndex = 16
        Me.BtnConultas.Text = "Consultas"
        Me.BtnConultas.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1065, 590)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnConultas)
        Me.Controls.Add(Me.WbbConversacion)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.LstEnfermedades)
        Me.Controls.Add(Me.LblEdadPaciente)
        Me.Controls.Add(Me.LblSexoPaciente)
        Me.Controls.Add(Me.LblNombrePaciente)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.DgvEnEspera)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnRecomendaciones)
        Me.Controls.Add(Me.BtnIniciarChat)
        Me.Controls.Add(Me.BtnFinalizarChat)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Menu"
        Me.Text = "Menu Medico"
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnFinalizarChat As Button
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents BtnRecomendaciones As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DgvEnEspera As DataGridView
    Friend WithEvents TmrBuscarMensajesNuevos As Timer
    Friend WithEvents LblNombrePaciente As Label
    Friend WithEvents LblSexoPaciente As Label
    Friend WithEvents LblEdadPaciente As Label
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents TmrBuscarChats As Timer
    Friend WithEvents WbbConversacion As WebBrowser
    Friend WithEvents BtnConultas As Button
End Class
