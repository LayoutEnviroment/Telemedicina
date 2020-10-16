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
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.Sintomas = New System.Windows.Forms.Label()
        Me.BtnDiagnostico = New System.Windows.Forms.Button()
        Me.LvSintomas = New System.Windows.Forms.ListView()
        Me.BtnConsultaHistorial = New System.Windows.Forms.Button()
        Me.BtnDatosPriopios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.LblSaludo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LblSaludo.ForeColor = System.Drawing.Color.White
        Me.LblSaludo.Location = New System.Drawing.Point(370, 172)
        Me.LblSaludo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(352, 42)
        Me.LblSaludo.TabIndex = 2
        Me.LblSaludo.Text = "Buen día, username"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.LblSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LblSintomas.ForeColor = System.Drawing.Color.White
        Me.LblSintomas.Location = New System.Drawing.Point(370, 242)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(435, 42)
        Me.LblSintomas.TabIndex = 4
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbSintomas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(510, 345)
        Me.CmbSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(512, 28)
        Me.CmbSintomas.TabIndex = 15
        '
        'Sintomas
        '
        Me.Sintomas.AutoSize = True
        Me.Sintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.Sintomas.ForeColor = System.Drawing.Color.White
        Me.Sintomas.Location = New System.Drawing.Point(303, 503)
        Me.Sintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Sintomas.Name = "Sintomas"
        Me.Sintomas.Size = New System.Drawing.Size(0, 31)
        Me.Sintomas.TabIndex = 16
        '
        'BtnDiagnostico
        '
        Me.BtnDiagnostico.Location = New System.Drawing.Point(633, 651)
        Me.BtnDiagnostico.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDiagnostico.Name = "BtnDiagnostico"
        Me.BtnDiagnostico.Size = New System.Drawing.Size(266, 60)
        Me.BtnDiagnostico.TabIndex = 18
        Me.BtnDiagnostico.Text = "Realizar Diagnostico"
        Me.BtnDiagnostico.UseVisualStyleBackColor = True
        '
        'LvSintomas
        '
        Me.LvSintomas.HideSelection = False
        Me.LvSintomas.Location = New System.Drawing.Point(460, 412)
        Me.LvSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LvSintomas.Name = "LvSintomas"
        Me.LvSintomas.Size = New System.Drawing.Size(600, 190)
        Me.LvSintomas.TabIndex = 20
        Me.LvSintomas.UseCompatibleStateImageBehavior = False
        '
        'BtnConsultaHistorial
        '
        Me.BtnConsultaHistorial.AutoSize = True
        Me.BtnConsultaHistorial.Location = New System.Drawing.Point(51, 77)
        Me.BtnConsultaHistorial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnConsultaHistorial.Name = "BtnConsultaHistorial"
        Me.BtnConsultaHistorial.Size = New System.Drawing.Size(204, 35)
        Me.BtnConsultaHistorial.TabIndex = 21
        Me.BtnConsultaHistorial.Text = "Historial Diagnosticos"
        Me.BtnConsultaHistorial.UseVisualStyleBackColor = True
        '
        'BtnDatosPriopios
        '
        Me.BtnDatosPriopios.Location = New System.Drawing.Point(51, 165)
        Me.BtnDatosPriopios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDatosPriopios.Name = "BtnDatosPriopios"
        Me.BtnDatosPriopios.Size = New System.Drawing.Size(204, 35)
        Me.BtnDatosPriopios.TabIndex = 23
        Me.BtnDatosPriopios.Text = "Mis Datos"
        Me.BtnDatosPriopios.UseVisualStyleBackColor = True
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1515, 812)
        Me.Controls.Add(Me.BtnDatosPriopios)
        Me.Controls.Add(Me.BtnConsultaHistorial)
        Me.Controls.Add(Me.LvSintomas)
        Me.Controls.Add(Me.BtnDiagnostico)
        Me.Controls.Add(Me.Sintomas)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Name = "Frm_Menu"
        Me.Text = "Paciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaludo As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents Sintomas As Label
    Friend WithEvents BtnDiagnostico As Button
    Friend WithEvents LvSintomas As ListView
    Friend WithEvents BtnConsultaHistorial As Button
    Friend WithEvents BtnDatosPriopios As Button
End Class
