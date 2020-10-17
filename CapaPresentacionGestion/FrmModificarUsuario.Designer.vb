<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUsuario
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
        Me.BtnAgregarMedicacion = New System.Windows.Forms.Button()
        Me.BtnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.LstEnfermedadCronica = New System.Windows.Forms.ListBox()
        Me.TxtMedicacion = New System.Windows.Forms.TextBox()
        Me.TxtEnfermedadCronica = New System.Windows.Forms.TextBox()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtCI = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblCI = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.CmbCi = New System.Windows.Forms.ComboBox()
        Me.RdbH = New System.Windows.Forms.RadioButton()
        Me.RdbM = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(909, 389)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarMedicacion.TabIndex = 42
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(597, 329)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarEnfermedad.TabIndex = 39
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.ItemHeight = 20
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(449, 366)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(232, 144)
        Me.LstEnfermedadCronica.TabIndex = 48
        Me.LstEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(750, 390)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(142, 26)
        Me.TxtMedicacion.TabIndex = 41
        Me.TxtMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(449, 329)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(127, 26)
        Me.TxtEnfermedadCronica.TabIndex = 38
        Me.TxtEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(775, 366)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(89, 20)
        Me.LblMedicacion.TabIndex = 47
        Me.LblMedicacion.Text = "Medicación"
        Me.LblMedicacion.Visible = False
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(462, 302)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(180, 20)
        Me.LblEnfermedadCronica.TabIndex = 46
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(785, 213)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(142, 40)
        Me.BtnVolver.TabIndex = 45
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(785, 147)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(142, 40)
        Me.BtnCancelar.TabIndex = 44
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(785, 81)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 40)
        Me.BtnAceptar.TabIndex = 43
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(8, 454)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(224, 26)
        Me.DtpFechaNacimiento.TabIndex = 37
        Me.DtpFechaNacimiento.Visible = False
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(34, 427)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(159, 20)
        Me.LblFechaNacimiento.TabIndex = 40
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(183, 381)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(134, 24)
        Me.ChbAdministrador.TabIndex = 36
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(183, 347)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(86, 24)
        Me.ChbMedico.TabIndex = 35
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(183, 313)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(97, 24)
        Me.ChbPaciente.TabIndex = 34
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(63, 189)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(498, 26)
        Me.TxtMail.TabIndex = 32
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(64, -32)
        Me.TxtCI.MaxLength = 9
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(205, 26)
        Me.TxtCI.TabIndex = 26
        '
        'TxtApellido
        '
        Me.TxtApellido.CausesValidation = False
        Me.TxtApellido.Location = New System.Drawing.Point(356, 139)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(205, 26)
        Me.TxtApellido.TabIndex = 30
        '
        'TxtNombre
        '
        Me.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TxtNombre.CausesValidation = False
        Me.TxtNombre.Location = New System.Drawing.Point(63, 139)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 26)
        Me.TxtNombre.TabIndex = 27
        Me.TxtNombre.Tag = "^[a-zA-Z]+$"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(34, 313)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(120, 20)
        Me.LblUsuario.TabIndex = 33
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(59, 233)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 31
        Me.LblMail.Text = "Mail"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(112, -73)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(25, 20)
        Me.LblCI.TabIndex = 29
        Me.LblCI.Text = "CI"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(383, 98)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 28
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Location = New System.Drawing.Point(93, 98)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 25
        Me.LblNombre.Text = "Nombre"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Cornsilk
        Me.LblCedula.Location = New System.Drawing.Point(80, 9)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(169, 20)
        Me.LblCedula.TabIndex = 49
        Me.LblCedula.Text = "Seleccione una cedula"
        '
        'CmbCi
        '
        Me.CmbCi.FormattingEnabled = True
        Me.CmbCi.Location = New System.Drawing.Point(84, 45)
        Me.CmbCi.Name = "CmbCi"
        Me.CmbCi.Size = New System.Drawing.Size(196, 28)
        Me.CmbCi.TabIndex = 50
        '
        'RdbH
        '
        Me.RdbH.AutoSize = True
        Me.RdbH.Location = New System.Drawing.Point(277, 457)
        Me.RdbH.Name = "RdbH"
        Me.RdbH.Size = New System.Drawing.Size(91, 24)
        Me.RdbH.TabIndex = 51
        Me.RdbH.TabStop = True
        Me.RdbH.Text = "Hombre"
        Me.RdbH.UseVisualStyleBackColor = True
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Location = New System.Drawing.Point(277, 487)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(73, 24)
        Me.RdbM.TabIndex = 52
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "Mujer"
        Me.RdbM.UseVisualStyleBackColor = True
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 551)
        Me.Controls.Add(Me.RdbM)
        Me.Controls.Add(Me.RdbH)
        Me.Controls.Add(Me.CmbCi)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.BtnAgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
        Me.Controls.Add(Me.LstEnfermedadCronica)
        Me.Controls.Add(Me.TxtMedicacion)
        Me.Controls.Add(Me.TxtEnfermedadCronica)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DtpFechaNacimiento)
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
        Me.Name = "FrmModificarUsuario"
        Me.Text = "FrmModificarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregarMedicacion As Button
    Friend WithEvents BtnAgregarEnfermedad As Button
    Friend WithEvents LstEnfermedadCronica As ListBox
    Friend WithEvents TxtMedicacion As TextBox
    Friend WithEvents TxtEnfermedadCronica As TextBox
    Friend WithEvents LblMedicacion As Label
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtCI As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblCI As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCedula As Label
    Friend WithEvents CmbCi As ComboBox
    Friend WithEvents RdbH As RadioButton
    Friend WithEvents RdbM As RadioButton
End Class
