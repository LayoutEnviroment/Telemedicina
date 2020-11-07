<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConsultas))
        Me.DgvConsultas = New System.Windows.Forms.DataGridView()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMedicaciones = New System.Windows.Forms.Label()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblChat = New System.Windows.Forms.Label()
        Me.RtbChat = New System.Windows.Forms.RichTextBox()
        Me.PnlInformacion = New System.Windows.Forms.Panel()
        Me.LblIndicaciones = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        CType(Me.DgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInformacion.SuspendLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConsultas
        '
        Me.DgvConsultas.AllowUserToAddRows = False
        Me.DgvConsultas.AllowUserToDeleteRows = False
        Me.DgvConsultas.AllowUserToResizeColumns = False
        Me.DgvConsultas.AllowUserToResizeRows = False
        Me.DgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvConsultas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgvConsultas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgvConsultas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultas.Location = New System.Drawing.Point(16, 125)
        Me.DgvConsultas.MultiSelect = False
        Me.DgvConsultas.Name = "DgvConsultas"
        Me.DgvConsultas.ReadOnly = True
        Me.DgvConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultas.RowHeadersVisible = False
        Me.DgvConsultas.RowTemplate.Height = 28
        Me.DgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultas.Size = New System.Drawing.Size(357, 792)
        Me.DgvConsultas.TabIndex = 0
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Enabled = False
        Me.LblCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCedula.Location = New System.Drawing.Point(36, 23)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(73, 22)
        Me.LblCedula.TabIndex = 1
        Me.LblCedula.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'TxtCedula
        '
        Me.TxtCedula.Enabled = False
        Me.TxtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCedula.Location = New System.Drawing.Point(40, 63)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(169, 28)
        Me.TxtCedula.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(40, 172)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(169, 28)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Enabled = False
        Me.TxtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreo.Location = New System.Drawing.Point(40, 271)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(391, 28)
        Me.TxtCorreo.TabIndex = 8
        '
        'TxtEdad
        '
        Me.TxtEdad.Enabled = False
        Me.TxtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEdad.Location = New System.Drawing.Point(298, 63)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(133, 28)
        Me.TxtEdad.TabIndex = 9
        '
        'TxtSexo
        '
        Me.TxtSexo.Enabled = False
        Me.TxtSexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSexo.Location = New System.Drawing.Point(298, 172)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(133, 28)
        Me.TxtSexo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(512, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(223, 22)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.Enabled = False
        Me.LblMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMedicaciones.Location = New System.Drawing.Point(844, 37)
        Me.LblMedicaciones.Name = "LblMedicaciones"
        Me.LblMedicaciones.Size = New System.Drawing.Size(131, 22)
        Me.LblMedicaciones.TabIndex = 12
        Me.LblMedicaciones.Text = "Medicaciones"
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.Enabled = False
        Me.LstEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(516, 63)
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(242, 239)
        Me.LstEnfermedades.TabIndex = 13
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedades.View = System.Windows.Forms.View.List
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.Enabled = False
        Me.LstMedicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(800, 63)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(242, 239)
        Me.LstMedicaciones.TabIndex = 14
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 418)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Enfermedad Diagnosticada"
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.Enabled = False
        Me.TxtEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfermedad.Location = New System.Drawing.Point(40, 445)
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(274, 28)
        Me.TxtEnfermedad.TabIndex = 16
        '
        'LstSintomas
        '
        Me.LstSintomas.Enabled = False
        Me.LstSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(40, 537)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(274, 233)
        Me.LstSintomas.TabIndex = 18
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        Me.LstSintomas.View = System.Windows.Forms.View.List
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Enabled = False
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomas.Location = New System.Drawing.Point(126, 514)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(92, 22)
        Me.LblSintomas.TabIndex = 17
        Me.LblSintomas.Text = "Sintomas"
        '
        'LblChat
        '
        Me.LblChat.AutoSize = True
        Me.LblChat.Enabled = False
        Me.LblChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChat.Location = New System.Drawing.Point(634, 417)
        Me.LblChat.Name = "LblChat"
        Me.LblChat.Size = New System.Drawing.Size(132, 22)
        Me.LblChat.TabIndex = 19
        Me.LblChat.Text = "Conversacion"
        '
        'RtbChat
        '
        Me.RtbChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RtbChat.Location = New System.Drawing.Point(342, 445)
        Me.RtbChat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RtbChat.Name = "RtbChat"
        Me.RtbChat.ReadOnly = True
        Me.RtbChat.Size = New System.Drawing.Size(700, 326)
        Me.RtbChat.TabIndex = 21
        Me.RtbChat.Text = ""
        '
        'PnlInformacion
        '
        Me.PnlInformacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.PnlInformacion.Controls.Add(Me.RtbChat)
        Me.PnlInformacion.Controls.Add(Me.LblChat)
        Me.PnlInformacion.Controls.Add(Me.LstSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblSintomas)
        Me.PnlInformacion.Controls.Add(Me.TxtEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.Label6)
        Me.PnlInformacion.Controls.Add(Me.LstMedicaciones)
        Me.PnlInformacion.Controls.Add(Me.LstEnfermedades)
        Me.PnlInformacion.Controls.Add(Me.LblMedicaciones)
        Me.PnlInformacion.Controls.Add(Me.Label5)
        Me.PnlInformacion.Controls.Add(Me.TxtSexo)
        Me.PnlInformacion.Controls.Add(Me.TxtEdad)
        Me.PnlInformacion.Controls.Add(Me.TxtCorreo)
        Me.PnlInformacion.Controls.Add(Me.TxtNombre)
        Me.PnlInformacion.Controls.Add(Me.TxtCedula)
        Me.PnlInformacion.Controls.Add(Me.Label4)
        Me.PnlInformacion.Controls.Add(Me.Label3)
        Me.PnlInformacion.Controls.Add(Me.Label2)
        Me.PnlInformacion.Controls.Add(Me.Label1)
        Me.PnlInformacion.Controls.Add(Me.LblCedula)
        Me.PnlInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PnlInformacion.Location = New System.Drawing.Point(381, 125)
        Me.PnlInformacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.Size = New System.Drawing.Size(1066, 792)
        Me.PnlInformacion.TabIndex = 24
        Me.PnlInformacion.Visible = False
        '
        'LblIndicaciones
        '
        Me.LblIndicaciones.AutoSize = True
        Me.LblIndicaciones.BackColor = System.Drawing.Color.Transparent
        Me.LblIndicaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIndicaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblIndicaciones.Location = New System.Drawing.Point(730, 452)
        Me.LblIndicaciones.Name = "LblIndicaciones"
        Me.LblIndicaciones.Size = New System.Drawing.Size(0, 29)
        Me.LblIndicaciones.TabIndex = 25
        Me.LblIndicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = CType(resources.GetObject("PctSalir.Image"), System.Drawing.Image)
        Me.PctSalir.Location = New System.Drawing.Point(1347, 5)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(104, 98)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 26
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(534, 29)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(425, 47)
        Me.LblDescripcion.TabIndex = 27
        Me.LblDescripcion.Text = "Historial de Consultas"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.FrmMedico.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(1462, 932)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.LblIndicaciones)
        Me.Controls.Add(Me.DgvConsultas)
        Me.Controls.Add(Me.PnlInformacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmConsultas"
        CType(Me.DgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlInformacion.PerformLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConsultas As DataGridView
    Friend WithEvents LblCedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LblMedicaciones As Label
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblChat As Label
    Friend WithEvents RtbChat As RichTextBox
    Friend WithEvents PnlInformacion As Panel
    Friend WithEvents LblIndicaciones As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
End Class
