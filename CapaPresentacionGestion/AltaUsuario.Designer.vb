<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaUsuario
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
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtCI = New System.Windows.Forms.TextBox()
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.RdbM = New System.Windows.Forms.RadioButton()
        Me.RdbF = New System.Windows.Forms.RadioButton()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.TxtEnfermedadCronica = New System.Windows.Forms.TextBox()
        Me.TxtMedicacion = New System.Windows.Forms.TextBox()
        Me.LstEnfermedadCronica = New System.Windows.Forms.ListBox()
        Me.LstMedicacion = New System.Windows.Forms.ListBox()
        Me.BtnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnAgregarMedicacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Location = New System.Drawing.Point(135, 84)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(243, 84)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(396, 84)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(20, 17)
        Me.LblCI.TabIndex = 2
        Me.LblCI.Text = "CI"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(112, 152)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(222, 182)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(109, 17)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(86, 117)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 22)
        Me.TxtNombre.TabIndex = 5
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(218, 117)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(100, 22)
        Me.TxtApellido.TabIndex = 6
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(87, 172)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(100, 22)
        Me.TxtMail.TabIndex = 8
        '
        'TxtCI
        '
        Me.TxtCI.Location = New System.Drawing.Point(353, 117)
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(100, 22)
        Me.TxtCI.TabIndex = 7
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Location = New System.Drawing.Point(337, 182)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(85, 21)
        Me.ChbPaciente.TabIndex = 9
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Location = New System.Drawing.Point(337, 209)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(75, 21)
        Me.ChbMedico.TabIndex = 10
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Location = New System.Drawing.Point(337, 236)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(118, 21)
        Me.ChbAdministrador.TabIndex = 11
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(83, 240)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(141, 17)
        Me.LblFechaNacimiento.TabIndex = 12
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(84, 321)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(39, 17)
        Me.LblSexo.TabIndex = 13
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(86, 267)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(200, 22)
        Me.DtpFechaNacimiento.TabIndex = 14
        Me.DtpFechaNacimiento.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Location = New System.Drawing.Point(139, 319)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(40, 21)
        Me.RdbM.TabIndex = 15
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "M"
        Me.RdbM.UseVisualStyleBackColor = True
        Me.RdbM.Visible = False
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.Location = New System.Drawing.Point(139, 346)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(37, 21)
        Me.RdbF.TabIndex = 16
        Me.RdbF.TabStop = True
        Me.RdbF.Text = "F"
        Me.RdbF.UseVisualStyleBackColor = True
        Me.RdbF.Visible = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(661, 84)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(127, 32)
        Me.BtnAceptar.TabIndex = 17
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(661, 137)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 32)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(661, 189)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(127, 32)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(257, 312)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(159, 17)
        Me.LblEnfermedadCronica.TabIndex = 20
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(524, 312)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(79, 17)
        Me.LblMedicacion.TabIndex = 21
        Me.LblMedicacion.Text = "Medicación"
        Me.LblMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(246, 335)
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(114, 22)
        Me.TxtEnfermedadCronica.TabIndex = 22
        Me.TxtEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(501, 332)
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(126, 22)
        Me.TxtMedicacion.TabIndex = 23
        Me.TxtMedicacion.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.ItemHeight = 16
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(246, 364)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(207, 84)
        Me.LstEnfermedadCronica.TabIndex = 24
        Me.LstEnfermedadCronica.Visible = False
        '
        'LstMedicacion
        '
        Me.LstMedicacion.FormattingEnabled = True
        Me.LstMedicacion.ItemHeight = 16
        Me.LstMedicacion.Location = New System.Drawing.Point(501, 364)
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(207, 84)
        Me.LstMedicacion.TabIndex = 25
        Me.LstMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(378, 335)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarEnfermedad.TabIndex = 26
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(633, 331)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarMedicacion.TabIndex = 27
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'AltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
        Me.Controls.Add(Me.LstMedicacion)
        Me.Controls.Add(Me.LstEnfermedadCronica)
        Me.Controls.Add(Me.TxtMedicacion)
        Me.Controls.Add(Me.TxtEnfermedadCronica)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.RdbF)
        Me.Controls.Add(Me.RdbM)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.ChbAdministrador)
        Me.Controls.Add(Me.ChbMedico)
        Me.Controls.Add(Me.ChbPaciente)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtCI)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblUsuario)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblCI)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "AltaUsuario"
        Me.Text = "AltaUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblCI As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblUsuario As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtCI As TextBox
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents RdbM As RadioButton
    Friend WithEvents RdbF As RadioButton
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents LblMedicacion As Label
    Friend WithEvents TxtEnfermedadCronica As TextBox
    Friend WithEvents TxtMedicacion As TextBox
    Friend WithEvents LstEnfermedadCronica As ListBox
    Friend WithEvents LstMedicacion As ListBox
    Friend WithEvents BtnAgregarEnfermedad As Button
    Friend WithEvents BtnAgregarMedicacion As Button
End Class
