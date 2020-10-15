<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.LblNombre.Location = New System.Drawing.Point(160, 102)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(450, 102)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(178, 11)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(25, 20)
        Me.LblCI.TabIndex = 2
        Me.LblCI.Text = "CI"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(160, 203)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(118, 314)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(120, 20)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'TxtNombre
        '
        Me.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TxtNombre.CausesValidation = False
        Me.TxtNombre.Location = New System.Drawing.Point(130, 143)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(205, 26)
        Me.TxtNombre.TabIndex = 5
        Me.TxtNombre.Tag = "^[a-zA-Z]+$"
        '
        'TxtApellido
        '
        Me.TxtApellido.CausesValidation = False
        Me.TxtApellido.Location = New System.Drawing.Point(423, 143)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(205, 26)
        Me.TxtApellido.TabIndex = 6
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(130, 226)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(498, 26)
        Me.TxtMail.TabIndex = 8
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(130, 52)
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(205, 26)
        Me.TxtCI.TabIndex = 7
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(249, 314)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(97, 24)
        Me.ChbPaciente.TabIndex = 9
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(249, 348)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(86, 24)
        Me.ChbMedico.TabIndex = 10
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(249, 382)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(134, 24)
        Me.ChbAdministrador.TabIndex = 11
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(100, 511)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(159, 20)
        Me.LblFechaNacimiento.TabIndex = 12
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(69, 614)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(45, 20)
        Me.LblSexo.TabIndex = 13
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(74, 538)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(224, 26)
        Me.DtpFechaNacimiento.TabIndex = 14
        Me.DtpFechaNacimiento.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Checked = True
        Me.RdbM.Location = New System.Drawing.Point(130, 611)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(47, 24)
        Me.RdbM.TabIndex = 15
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "M"
        Me.RdbM.UseVisualStyleBackColor = True
        Me.RdbM.Visible = False
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.Location = New System.Drawing.Point(130, 645)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(44, 24)
        Me.RdbF.TabIndex = 16
        Me.RdbF.TabStop = True
        Me.RdbF.Text = "F"
        Me.RdbF.UseVisualStyleBackColor = True
        Me.RdbF.Visible = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(852, 85)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 40)
        Me.BtnAceptar.TabIndex = 17
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(852, 151)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(142, 40)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(852, 217)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(142, 40)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(436, 511)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(180, 20)
        Me.LblEnfermedadCronica.TabIndex = 20
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(736, 511)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(89, 20)
        Me.LblMedicacion.TabIndex = 21
        Me.LblMedicacion.Text = "Medicación"
        Me.LblMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(423, 538)
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(127, 26)
        Me.TxtEnfermedadCronica.TabIndex = 22
        Me.TxtEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(711, 535)
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(142, 26)
        Me.TxtMedicacion.TabIndex = 23
        Me.TxtMedicacion.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.ItemHeight = 20
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(423, 575)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(232, 104)
        Me.LstEnfermedadCronica.TabIndex = 24
        Me.LstEnfermedadCronica.Visible = False
        '
        'LstMedicacion
        '
        Me.LstMedicacion.FormattingEnabled = True
        Me.LstMedicacion.ItemHeight = 20
        Me.LstMedicacion.Location = New System.Drawing.Point(711, 575)
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(232, 104)
        Me.LstMedicacion.TabIndex = 25
        Me.LstMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(573, 538)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarEnfermedad.TabIndex = 26
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(870, 534)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarMedicacion.TabIndex = 27
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'FrmAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 722)
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
        Me.Name = "FrmAltaUsuario"
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
