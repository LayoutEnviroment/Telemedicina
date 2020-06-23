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
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.LblRegistro = New System.Windows.Forms.LinkLabel()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblContra = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblBienvenida
        '
        Me.LblBienvenida.AutoSize = True
        Me.LblBienvenida.Location = New System.Drawing.Point(155, 36)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(91, 20)
        Me.LblBienvenida.TabIndex = 0
        Me.LblBienvenida.Text = "Bienvenido!"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Location = New System.Drawing.Point(159, 397)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(242, 38)
        Me.BtnIngresar.TabIndex = 1
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'LblRegistro
        '
        Me.LblRegistro.AutoSize = True
        Me.LblRegistro.Location = New System.Drawing.Point(159, 454)
        Me.LblRegistro.Name = "LblRegistro"
        Me.LblRegistro.Size = New System.Drawing.Size(231, 20)
        Me.LblRegistro.TabIndex = 2
        Me.LblRegistro.TabStop = True
        Me.LblRegistro.Text = "Haga click aqui para registrarse"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(74, 125)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(43, 20)
        Me.LblUsuario.TabIndex = 3
        Me.LblUsuario.Text = "User"
        '
        'LblContra
        '
        Me.LblContra.AutoSize = True
        Me.LblContra.Location = New System.Drawing.Point(74, 247)
        Me.LblContra.Name = "LblContra"
        Me.LblContra.Size = New System.Drawing.Size(78, 20)
        Me.LblContra.TabIndex = 4
        Me.LblContra.Text = "Password"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(80, 169)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(309, 26)
        Me.TxtUsuario.TabIndex = 5
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(80, 297)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(309, 26)
        Me.TxtPassword.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Login.My.Resources.Resources.Username
        Me.PictureBox1.Location = New System.Drawing.Point(35, 114)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 570)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.LblContra)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblRegistro)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.LblBienvenida)
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBienvenida As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents LblRegistro As LinkLabel
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblContra As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
