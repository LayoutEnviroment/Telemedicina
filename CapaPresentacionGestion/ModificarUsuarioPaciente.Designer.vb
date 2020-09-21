<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuarioPaciente
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblCI = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(113, 92)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(194, 92)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(113, 142)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(20, 17)
        Me.LblCI.TabIndex = 2
        Me.LblCI.Text = "CI"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(194, 142)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(113, 214)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(51, 17)
        Me.LblFechaNacimiento.TabIndex = 4
        Me.LblFechaNacimiento.Text = "Label5"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(113, 294)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(51, 17)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Label6"
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(409, 174)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(51, 17)
        Me.LblEnfermedadCronica.TabIndex = 6
        Me.LblEnfermedadCronica.Text = "Label7"
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(409, 353)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(51, 17)
        Me.LblMedicacion.TabIndex = 7
        Me.LblMedicacion.Text = "Label8"
        '
        'ModificarUsuarioPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblCI)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "ModificarUsuarioPaciente"
        Me.Text = "ModificarUsuarioPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblCI As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents LblMedicacion As Label
End Class
