<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObtenerDiagnostico
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
        Me.TxtSintoma = New System.Windows.Forms.TextBox()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.SintomaPaciente = New System.Windows.Forms.ListView()
        Me.SintomaSistema = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        CType(Me.SintomaSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSintoma
        '
        Me.TxtSintoma.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtSintoma.Location = New System.Drawing.Point(289, 105)
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(169, 20)
        Me.TxtSintoma.TabIndex = 2
        Me.TxtSintoma.Text = "Ej: Fiebre"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(313, 77)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(125, 13)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.Location = New System.Drawing.Point(325, 53)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(103, 13)
        Me.LblSaludo.TabIndex = 0
        Me.LblSaludo.Text = "Buen día, username"
        '
        'SintomaPaciente
        '
        Me.SintomaPaciente.AllowDrop = True
        Me.SintomaPaciente.HideSelection = False
        Me.SintomaPaciente.Location = New System.Drawing.Point(462, 185)
        Me.SintomaPaciente.Name = "SintomaPaciente"
        Me.SintomaPaciente.Size = New System.Drawing.Size(193, 239)
        Me.SintomaPaciente.TabIndex = 4
        Me.SintomaPaciente.UseCompatibleStateImageBehavior = False
        '
        'SintomaSistema
        '
        Me.SintomaSistema.AllowDrop = True
        Me.SintomaSistema.AllowUserToDeleteRows = False
        Me.SintomaSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SintomaSistema.Location = New System.Drawing.Point(105, 185)
        Me.SintomaSistema.Name = "SintomaSistema"
        Me.SintomaSistema.ReadOnly = True
        Me.SintomaSistema.Size = New System.Drawing.Size(184, 301)
        Me.SintomaSistema.TabIndex = 5
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(462, 444)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(184, 42)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "Realizar Diagnostico"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 518)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.SintomaSistema)
        Me.Controls.Add(Me.SintomaPaciente)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Name = "ObtenerDiagnostico"
        Me.Text = "Bienvenido"
        CType(Me.SintomaSistema, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSintoma As TextBox
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblSaludo As Label
    Friend WithEvents SintomaPaciente As ListView
    Friend WithEvents SintomaSistema As DataGridView
    Friend WithEvents BtnBuscar As Button
End Class
