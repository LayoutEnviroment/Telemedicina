<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuMedico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuMedico))
        Me.RTxtClhat = New System.Windows.Forms.RichTextBox()
        Me.RTxtMensaje = New System.Windows.Forms.RichTextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.BtnFinalizarChat = New System.Windows.Forms.Button()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TmrMedico = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RTxtClhat
        '
        Me.RTxtClhat.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtClhat.Location = New System.Drawing.Point(29, 133)
        Me.RTxtClhat.Name = "RTxtClhat"
        Me.RTxtClhat.Size = New System.Drawing.Size(349, 302)
        Me.RTxtClhat.TabIndex = 0
        Me.RTxtClhat.Text = ""
        '
        'RTxtMensaje
        '
        Me.RTxtMensaje.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtMensaje.Location = New System.Drawing.Point(29, 441)
        Me.RTxtMensaje.Name = "RTxtMensaje"
        Me.RTxtMensaje.Size = New System.Drawing.Size(316, 34)
        Me.RTxtMensaje.TabIndex = 3
        Me.RTxtMensaje.Text = ""
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(688, 223)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(22, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(198, 200)
        Me.WebBrowser1.TabIndex = 2
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(352, 441)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(128, 34)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'BtnFinalizarChat
        '
        Me.BtnFinalizarChat.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinalizarChat.Location = New System.Drawing.Point(688, 429)
        Me.BtnFinalizarChat.Name = "BtnFinalizarChat"
        Me.BtnFinalizarChat.Size = New System.Drawing.Size(198, 26)
        Me.BtnFinalizarChat.TabIndex = 6
        Me.BtnFinalizarChat.Text = "Finalizar Chat"
        Me.BtnFinalizarChat.UseVisualStyleBackColor = True
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciarChat.Location = New System.Drawing.Point(688, 193)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(198, 24)
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
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(443, 133)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(218, 261)
        Me.DataGridView1.TabIndex = 5
        '
        'TmrMedico
        '
        '
        'MenuMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(900, 531)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCerrarSesion)
        Me.Controls.Add(Me.BtnIniciarChat)
        Me.Controls.Add(Me.BtnFinalizarChat)
        Me.Controls.Add(Me.btnEnviar)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.RTxtMensaje)
        Me.Controls.Add(Me.RTxtClhat)
        Me.Font = New System.Drawing.Font("Libre Franklin Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MenuMedico"
        Me.Text = "Menu Medico"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RTxtClhat As RichTextBox
    Friend WithEvents RTxtMensaje As RichTextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btnEnviar As Button
    Friend WithEvents BtnFinalizarChat As Button
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TmrMedico As Timer
End Class
