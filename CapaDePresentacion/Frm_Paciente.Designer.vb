<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Paciente
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
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.Sintomas = New System.Windows.Forms.Label()
        Me.BtnDiagnostico = New System.Windows.Forms.Button()
        Me.LvSintomas = New System.Windows.Forms.ListView()
        Me.PanelChat = New System.Windows.Forms.Panel()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtPrioridad = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.LblIniciarChat = New System.Windows.Forms.Label()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.TxtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.PanelChat.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.LblSaludo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LblSaludo.ForeColor = System.Drawing.Color.White
        Me.LblSaludo.Location = New System.Drawing.Point(247, 112)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(240, 29)
        Me.LblSaludo.TabIndex = 2
        Me.LblSaludo.Text = "Buen día, username"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LblSintomas.ForeColor = System.Drawing.Color.White
        Me.LblSintomas.Location = New System.Drawing.Point(247, 157)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(294, 29)
        Me.LblSintomas.TabIndex = 4
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbSintomas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(340, 224)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(343, 21)
        Me.CmbSintomas.TabIndex = 15
        '
        'Sintomas
        '
        Me.Sintomas.AutoSize = True
        Me.Sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Sintomas.ForeColor = System.Drawing.Color.White
        Me.Sintomas.Location = New System.Drawing.Point(202, 327)
        Me.Sintomas.Name = "Sintomas"
        Me.Sintomas.Size = New System.Drawing.Size(0, 22)
        Me.Sintomas.TabIndex = 16
        '
        'BtnDiagnostico
        '
        Me.BtnDiagnostico.Location = New System.Drawing.Point(422, 423)
        Me.BtnDiagnostico.Name = "BtnDiagnostico"
        Me.BtnDiagnostico.Size = New System.Drawing.Size(177, 39)
        Me.BtnDiagnostico.TabIndex = 18
        Me.BtnDiagnostico.Text = "Realizar Diagnostico"
        Me.BtnDiagnostico.UseVisualStyleBackColor = True
        '
        'LvSintomas
        '
        Me.LvSintomas.HideSelection = False
        Me.LvSintomas.Location = New System.Drawing.Point(307, 268)
        Me.LvSintomas.Name = "LvSintomas"
        Me.LvSintomas.Size = New System.Drawing.Size(401, 125)
        Me.LvSintomas.TabIndex = 20
        Me.LvSintomas.UseCompatibleStateImageBehavior = False
        '
        'PanelChat
        '
        Me.PanelChat.Controls.Add(Me.LblId)
        Me.PanelChat.Controls.Add(Me.TxtIdDiagnostico)
        Me.PanelChat.Controls.Add(Me.BtnVolver)
        Me.PanelChat.Controls.Add(Me.TxtEnfermedad)
        Me.PanelChat.Controls.Add(Me.TxtDescripcion)
        Me.PanelChat.Controls.Add(Me.TxtPrioridad)
        Me.PanelChat.Controls.Add(Me.LblDescripcion)
        Me.PanelChat.Controls.Add(Me.LblPrioridad)
        Me.PanelChat.Controls.Add(Me.LblEnfermedad)
        Me.PanelChat.Controls.Add(Me.LblIniciarChat)
        Me.PanelChat.Controls.Add(Me.BtnIniciarChat)
        Me.PanelChat.Location = New System.Drawing.Point(98, 31)
        Me.PanelChat.Name = "PanelChat"
        Me.PanelChat.Size = New System.Drawing.Size(816, 459)
        Me.PanelChat.TabIndex = 21
        Me.PanelChat.Visible = False
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(591, 253)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(153, 45)
        Me.BtnVolver.TabIndex = 8
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.Enabled = False
        Me.TxtEnfermedad.Location = New System.Drawing.Point(29, 64)
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(196, 20)
        Me.TxtEnfermedad.TabIndex = 7
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(35, 237)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(279, 21)
        Me.TxtDescripcion.TabIndex = 6
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.Enabled = False
        Me.TxtPrioridad.ForeColor = System.Drawing.Color.White
        Me.TxtPrioridad.Location = New System.Drawing.Point(29, 142)
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.Size = New System.Drawing.Size(285, 20)
        Me.TxtPrioridad.TabIndex = 5
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.ForeColor = System.Drawing.Color.White
        Me.LblDescripcion.Location = New System.Drawing.Point(42, 210)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 4
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.ForeColor = System.Drawing.Color.White
        Me.LblPrioridad.Location = New System.Drawing.Point(42, 126)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(51, 13)
        Me.LblPrioridad.TabIndex = 3
        Me.LblPrioridad.Text = "Prioridad:"
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.ForeColor = System.Drawing.Color.White
        Me.LblEnfermedad.Location = New System.Drawing.Point(15, 48)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(230, 13)
        Me.LblEnfermedad.TabIndex = 2
        Me.LblEnfermedad.Text = "Lo mas probable es que usted pueda padecer: "
        '
        'LblIniciarChat
        '
        Me.LblIniciarChat.AutoSize = True
        Me.LblIniciarChat.ForeColor = System.Drawing.Color.White
        Me.LblIniciarChat.Location = New System.Drawing.Point(538, 142)
        Me.LblIniciarChat.Name = "LblIniciarChat"
        Me.LblIniciarChat.Size = New System.Drawing.Size(266, 13)
        Me.LblIniciarChat.TabIndex = 1
        Me.LblIniciarChat.Text = "Si desea conversar con un profesional, haga click aqui"
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.Location = New System.Drawing.Point(591, 193)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(154, 47)
        Me.BtnIniciarChat.TabIndex = 0
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = True
        '
        'TxtIdDiagnostico
        '
        Me.TxtIdDiagnostico.Enabled = False
        Me.TxtIdDiagnostico.Location = New System.Drawing.Point(242, 63)
        Me.TxtIdDiagnostico.Name = "TxtIdDiagnostico"
        Me.TxtIdDiagnostico.Size = New System.Drawing.Size(72, 20)
        Me.TxtIdDiagnostico.TabIndex = 9
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(262, 47)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(21, 13)
        Me.LblId.TabIndex = 10
        Me.LblId.Text = "ID:"
        '
        'Frm_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 528)
        Me.Controls.Add(Me.PanelChat)
        Me.Controls.Add(Me.LvSintomas)
        Me.Controls.Add(Me.BtnDiagnostico)
        Me.Controls.Add(Me.Sintomas)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Paciente"
        Me.Text = "Paciente"
        Me.PanelChat.ResumeLayout(False)
        Me.PanelChat.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaludo As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents Sintomas As Label
    Friend WithEvents BtnDiagnostico As Button
    Friend WithEvents LvSintomas As ListView
    Friend WithEvents PanelChat As Panel
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtPrioridad As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents LblIniciarChat As Label
    Friend WithEvents BtnIniciarChat As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents LblId As Label
    Friend WithEvents TxtIdDiagnostico As TextBox
End Class
