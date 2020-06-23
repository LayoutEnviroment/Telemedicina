<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.BtnIngreso = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LklRegistro = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'BtnIngreso
        '
        Me.BtnIngreso.BackColor = System.Drawing.Color.White
        Me.BtnIngreso.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngreso.ForeColor = System.Drawing.Color.Black
        Me.BtnIngreso.Location = New System.Drawing.Point(118, 325)
        Me.BtnIngreso.Name = "BtnIngreso"
        Me.BtnIngreso.Size = New System.Drawing.Size(168, 53)
        Me.BtnIngreso.TabIndex = 0
        Me.BtnIngreso.Text = "Ingresar"
        Me.BtnIngreso.UseVisualStyleBackColor = False
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(89, 118)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(230, 34)
        Me.TxtUsername.TabIndex = 1
        Me.TxtUsername.Text = "gestor"
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(89, 235)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(230, 34)
        Me.TxtPassword.TabIndex = 2
        Me.TxtPassword.Text = "gestor"
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPassword.Location = New System.Drawing.Point(153, 203)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(111, 28)
        Me.LblPassword.TabIndex = 3
        Me.LblPassword.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(171, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 28)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'LklRegistro
        '
        Me.LklRegistro.AutoSize = True
        Me.LklRegistro.Font = New System.Drawing.Font("Segoe UI Emoji", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LklRegistro.Location = New System.Drawing.Point(140, 404)
        Me.LklRegistro.Name = "LklRegistro"
        Me.LklRegistro.Size = New System.Drawing.Size(120, 21)
        Me.LklRegistro.TabIndex = 5
        Me.LklRegistro.TabStop = True
        Me.LklRegistro.Text = "Registrese aquí "
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(424, 487)
        Me.Controls.Add(Me.LklRegistro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.BtnIngreso)
        Me.Name = "Login"
        Me.Text = "Ingreso de Gestores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnIngreso As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LklRegistro As LinkLabel
End Class
