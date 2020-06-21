<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompone
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
        Me.CmbEnfermedad = New System.Windows.Forms.ComboBox()
        Me.LblSeleccionEnfermedad = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEnfermedad
        '
        Me.CmbEnfermedad.FormattingEnabled = True
        Me.CmbEnfermedad.Location = New System.Drawing.Point(44, 81)
        Me.CmbEnfermedad.Name = "CmbEnfermedad"
        Me.CmbEnfermedad.Size = New System.Drawing.Size(154, 24)
        Me.CmbEnfermedad.TabIndex = 0
        '
        'LblSeleccionEnfermedad
        '
        Me.LblSeleccionEnfermedad.AutoSize = True
        Me.LblSeleccionEnfermedad.Location = New System.Drawing.Point(41, 38)
        Me.LblSeleccionEnfermedad.Name = "LblSeleccionEnfermedad"
        Me.LblSeleccionEnfermedad.Size = New System.Drawing.Size(157, 17)
        Me.LblSeleccionEnfermedad.TabIndex = 1
        Me.LblSeleccionEnfermedad.Text = "Seleccione enfermedad"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(248, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(292, 336)
        Me.DataGridView1.TabIndex = 2
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(635, 135)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(122, 38)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(635, 199)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(122, 38)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(635, 379)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(122, 38)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormCompone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LblSeleccionEnfermedad)
        Me.Controls.Add(Me.CmbEnfermedad)
        Me.Name = "FormCompone"
        Me.Text = "FormCompone"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedad As ComboBox
    Friend WithEvents LblSeleccionEnfermedad As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnVolver As Button
End Class
