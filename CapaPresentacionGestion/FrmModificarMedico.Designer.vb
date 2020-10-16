<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarMedico
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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtMailMedico = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMedico = New System.Windows.Forms.TextBox()
        Me.TxtNombreMedico = New System.Windows.Forms.TextBox()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblCI = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CmbCIMedico = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(567, 231)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(143, 40)
        Me.BtnVolver.TabIndex = 33
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(567, 166)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(143, 40)
        Me.BtnCancelar.TabIndex = 32
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(567, 100)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(143, 40)
        Me.BtnAceptar.TabIndex = 31
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtMailMedico
        '
        Me.TxtMailMedico.Location = New System.Drawing.Point(47, 446)
        Me.TxtMailMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMailMedico.MaxLength = 100
        Me.TxtMailMedico.Name = "TxtMailMedico"
        Me.TxtMailMedico.Size = New System.Drawing.Size(259, 26)
        Me.TxtMailMedico.TabIndex = 28
        '
        'TxtApellidoMedico
        '
        Me.TxtApellidoMedico.Location = New System.Drawing.Point(196, 345)
        Me.TxtApellidoMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellidoMedico.MaxLength = 25
        Me.TxtApellidoMedico.Name = "TxtApellidoMedico"
        Me.TxtApellidoMedico.Size = New System.Drawing.Size(112, 26)
        Me.TxtApellidoMedico.TabIndex = 26
        '
        'TxtNombreMedico
        '
        Me.TxtNombreMedico.Location = New System.Drawing.Point(47, 345)
        Me.TxtNombreMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombreMedico.MaxLength = 25
        Me.TxtNombreMedico.Name = "TxtNombreMedico"
        Me.TxtNombreMedico.Size = New System.Drawing.Size(112, 26)
        Me.TxtNombreMedico.TabIndex = 25
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(164, 409)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 23
        Me.LblMail.Text = "Mail"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(52, 88)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(25, 20)
        Me.LblCI.TabIndex = 22
        Me.LblCI.Text = "CI"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(192, 301)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 21
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Location = New System.Drawing.Point(44, 301)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 20
        Me.LblNombre.Text = "Nombre"
        '
        'CmbCIMedico
        '
        Me.CmbCIMedico.FormattingEnabled = True
        Me.CmbCIMedico.Location = New System.Drawing.Point(98, 88)
        Me.CmbCIMedico.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbCIMedico.Name = "CmbCIMedico"
        Me.CmbCIMedico.Size = New System.Drawing.Size(136, 28)
        Me.CmbCIMedico.TabIndex = 34
        '
        'FrmModificarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 562)
        Me.Controls.Add(Me.CmbCIMedico)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtMailMedico)
        Me.Controls.Add(Me.TxtApellidoMedico)
        Me.Controls.Add(Me.TxtNombreMedico)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblCI)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmModificarMedico"
        Me.Text = "ModificarUsuarioMedico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtMailMedico As TextBox
    Friend WithEvents TxtApellidoMedico As TextBox
    Friend WithEvents TxtNombreMedico As TextBox
    Friend WithEvents LblMail As Label
    Friend WithEvents LblCI As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbCIMedico As ComboBox
End Class
