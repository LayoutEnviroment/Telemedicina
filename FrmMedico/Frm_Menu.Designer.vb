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
        Me.RtbConversacion = New System.Windows.Forms.RichTextBox()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.BtnFinalizarChat = New System.Windows.Forms.Button()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DgvEnEspera = New System.Windows.Forms.DataGridView()
        Me.TmrBuscarMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.BtnBuscarSolicitudes = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RtbConversacion
        '
        Me.RtbConversacion.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbConversacion.Location = New System.Drawing.Point(29, 133)
        Me.RtbConversacion.Name = "RtbConversacion"
        Me.RtbConversacion.Size = New System.Drawing.Size(349, 302)
        Me.RtbConversacion.TabIndex = 0
        Me.RtbConversacion.Text = ""
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbMensaje.Location = New System.Drawing.Point(29, 441)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(244, 47)
        Me.RtbMensaje.TabIndex = 3
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnviar.Location = New System.Drawing.Point(290, 441)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(88, 47)
        Me.BtnEnviar.TabIndex = 4
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'BtnFinalizarChat
        '
        Me.BtnFinalizarChat.Enabled = False
        Me.BtnFinalizarChat.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarChat.Location = New System.Drawing.Point(645, 413)
        Me.BtnFinalizarChat.Name = "BtnFinalizarChat"
        Me.BtnFinalizarChat.Size = New System.Drawing.Size(241, 26)
        Me.BtnFinalizarChat.TabIndex = 6
        Me.BtnFinalizarChat.Text = "Finalizar Chat"
        Me.BtnFinalizarChat.UseVisualStyleBackColor = True
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarChat.Location = New System.Drawing.Point(645, 177)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(241, 24)
        Me.BtnIniciarChat.TabIndex = 1
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = True
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(742, 26)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(128, 29)
        Me.BtnCerrarSesion.TabIndex = 7
        Me.BtnCerrarSesion.Text = "Cerrar Sesion"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(742, 71)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(128, 29)
        Me.BtnSalir.TabIndex = 8
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(398, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(218, 355)
        Me.DataGridView1.TabIndex = 5
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
        Me.DgvEnEspera.Location = New System.Drawing.Point(645, 207)
        Me.DgvEnEspera.MultiSelect = False
        Me.DgvEnEspera.Name = "DgvEnEspera"
        Me.DgvEnEspera.ReadOnly = True
        Me.DgvEnEspera.RowHeadersVisible = False
        Me.DgvEnEspera.RowTemplate.Height = 24
        Me.DgvEnEspera.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEnEspera.Size = New System.Drawing.Size(241, 200)
        Me.DgvEnEspera.TabIndex = 9
        '
        'TmrBuscarMensajesNuevos
        '
        Me.TmrBuscarMensajesNuevos.Enabled = True
        '
        'BtnBuscarSolicitudes
        '
        Me.BtnBuscarSolicitudes.Location = New System.Drawing.Point(645, 148)
        Me.BtnBuscarSolicitudes.Name = "BtnBuscarSolicitudes"
        Me.BtnBuscarSolicitudes.Size = New System.Drawing.Size(241, 23)
        Me.BtnBuscarSolicitudes.TabIndex = 10
        Me.BtnBuscarSolicitudes.Text = "Refrescar"
        Me.BtnBuscarSolicitudes.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnBuscarSolicitudes)
        Me.Controls.Add(Me.DgvEnEspera)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCerrarSesion)
        Me.Controls.Add(Me.BtnIniciarChat)
        Me.Controls.Add(Me.BtnFinalizarChat)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.RtbConversacion)
        Me.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Menu"
        Me.Text = "Menu Medico"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvEnEspera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RtbConversacion As RichTextBox
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents BtnFinalizarChat As Button
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgvEnEspera As DataGridView
    Friend WithEvents TmrBuscarMensajesNuevos As Timer
    Friend WithEvents BtnBuscarSolicitudes As Button
End Class
