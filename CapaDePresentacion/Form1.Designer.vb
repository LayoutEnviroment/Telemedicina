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
        Me.TxtSintoma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSintoma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSintoma.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TxtSintoma.Location = New System.Drawing.Point(292, 128)
        Me.TxtSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(281, 26)
        Me.TxtSintoma.TabIndex = 0
        Me.TxtSintoma.Text = "Ej: Fiebre"
        Me.TxtSintoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(328, 84)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(187, 20)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.Location = New System.Drawing.Point(346, 48)
        Me.LblSaludo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(151, 20)
        Me.LblSaludo.TabIndex = 0
        Me.LblSaludo.Text = "Buen día, username"
        '
        'SintomaPaciente
        '
        Me.SintomaPaciente.AllowDrop = True
        Me.SintomaPaciente.GridLines = True
        Me.SintomaPaciente.HideSelection = False
        Me.SintomaPaciente.Location = New System.Drawing.Point(472, 234)
        Me.SintomaPaciente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SintomaPaciente.Name = "SintomaPaciente"
        Me.SintomaPaciente.Size = New System.Drawing.Size(151, 285)
        Me.SintomaPaciente.TabIndex = 4
        Me.SintomaPaciente.UseCompatibleStateImageBehavior = False
        Me.SintomaPaciente.View = System.Windows.Forms.View.List
        '
        'SintomaSistema
        '
        Me.SintomaSistema.AllowDrop = True
        Me.SintomaSistema.AllowUserToDeleteRows = False
        Me.SintomaSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SintomaSistema.Location = New System.Drawing.Point(121, 222)
        Me.SintomaSistema.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SintomaSistema.Name = "SintomaSistema"
        Me.SintomaSistema.ReadOnly = True
        Me.SintomaSistema.Size = New System.Drawing.Size(179, 366)
        Me.SintomaSistema.TabIndex = 5
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(472, 538)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(169, 50)
        Me.BtnBuscar.TabIndex = 6
        Me.BtnBuscar.Text = "Realizar Diagnostico"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'ObtenerDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 670)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.SintomaSistema)
        Me.Controls.Add(Me.SintomaPaciente)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
