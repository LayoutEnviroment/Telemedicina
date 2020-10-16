<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarAdministrativo
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
        Me.CmbCi = New System.Windows.Forms.ComboBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblCI = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbCi
        '
        Me.CmbCi.FormattingEnabled = True
        Me.CmbCi.Location = New System.Drawing.Point(121, 33)
        Me.CmbCi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbCi.Name = "CmbCi"
        Me.CmbCi.Size = New System.Drawing.Size(136, 28)
        Me.CmbCi.TabIndex = 45
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(590, 176)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(143, 40)
        Me.BtnVolver.TabIndex = 44
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(590, 111)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(143, 40)
        Me.BtnCancelar.TabIndex = 43
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(590, 45)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(143, 40)
        Me.BtnAceptar.TabIndex = 42
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(70, 391)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMail.MaxLength = 100
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(259, 26)
        Me.TxtMail.TabIndex = 41
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(219, 290)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(112, 26)
        Me.TxtApellido.TabIndex = 40
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(70, 290)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(112, 26)
        Me.TxtNombre.TabIndex = 39
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(187, 354)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 38
        Me.LblMail.Text = "Mail"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(75, 33)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(25, 20)
        Me.LblCI.TabIndex = 37
        Me.LblCI.Text = "CI"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(215, 246)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 36
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Location = New System.Drawing.Point(67, 246)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 35
        Me.LblNombre.Text = "Nombre"
        '
        'FrmModificarAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbCi)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblCI)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "FrmModificarAdministrativo"
        Me.Text = "Modificacion de Administrativos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbCi As ComboBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblMail As Label
    Friend WithEvents LblCI As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
End Class
