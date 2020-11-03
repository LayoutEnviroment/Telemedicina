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
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.BtnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnEliminarMedicacion = New System.Windows.Forms.Button()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Enabled = False
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(599, 214)
        Me.BtnAgregarMedicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(56, 19)
        Me.BtnAgregarMedicacion.TabIndex = 42
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Enabled = False
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(398, 214)
        Me.BtnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(56, 19)
        Me.BtnAgregarEnfermedad.TabIndex = 39
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Enabled = False
        Me.TxtMedicacion.Location = New System.Drawing.Point(493, 214)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(96, 20)
        Me.TxtMedicacion.TabIndex = 41
        Me.TxtMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Enabled = False
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(299, 214)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(86, 20)
        Me.TxtEnfermedadCronica.TabIndex = 38
        Me.TxtEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Enabled = False
        Me.LblMedicacion.Location = New System.Drawing.Point(509, 199)
        Me.LblMedicacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(62, 13)
        Me.LblMedicacion.TabIndex = 47
        Me.LblMedicacion.Text = "Medicación"
        Me.LblMedicacion.Visible = False
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Enabled = False
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(308, 196)
        Me.LblEnfermedadCronica.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(119, 13)
        Me.LblEnfermedadCronica.TabIndex = 46
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(523, 138)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(95, 26)
        Me.BtnVolver.TabIndex = 45
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(523, 96)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 26)
        Me.BtnCancelar.TabIndex = 44
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(523, 53)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(95, 26)
        Me.BtnAceptar.TabIndex = 43
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Enabled = False
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(5, 295)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(151, 20)
        Me.DtpFechaNacimiento.TabIndex = 37
        Me.DtpFechaNacimiento.Visible = False
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Enabled = False
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(23, 278)
        Me.LblFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaNacimiento.TabIndex = 40
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(122, 248)
        Me.ChbAdministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(91, 17)
        Me.ChbAdministrador.TabIndex = 36
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(122, 226)
        Me.ChbMedico.Margin = New System.Windows.Forms.Padding(2)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(61, 17)
        Me.ChbMedico.TabIndex = 35
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(122, 203)
        Me.ChbPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(68, 17)
        Me.ChbPaciente.TabIndex = 34
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'TxtMail
        '
        Me.TxtMail.Enabled = False
        Me.TxtMail.Location = New System.Drawing.Point(42, 144)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMail.MaxLength = 100
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(333, 20)
        Me.TxtMail.TabIndex = 32
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(43, -21)
        Me.TxtCI.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCI.MaxLength = 9
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(138, 20)
        Me.TxtCI.TabIndex = 26
        '
        'TxtApellido
        '
        Me.TxtApellido.CausesValidation = False
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Location = New System.Drawing.Point(237, 90)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(138, 20)
        Me.TxtApellido.TabIndex = 30
        '
        'TxtNombre
        '
        Me.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TxtNombre.CausesValidation = False
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(42, 90)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(138, 20)
        Me.TxtNombre.TabIndex = 27
        Me.TxtNombre.Tag = "^[a-zA-Z]+$"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Enabled = False
        Me.LblUsuario.Location = New System.Drawing.Point(23, 203)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(82, 13)
        Me.LblUsuario.TabIndex = 33
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Enabled = False
        Me.LblMail.Location = New System.Drawing.Point(39, 124)
        Me.LblMail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(26, 13)
        Me.LblMail.TabIndex = 31
        Me.LblMail.Text = "Mail"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(75, -47)
        Me.LblCI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(17, 13)
        Me.LblCI.TabIndex = 29
        Me.LblCI.Text = "CI"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Enabled = False
        Me.LblApellido.Location = New System.Drawing.Point(255, 64)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 28
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Enabled = False
        Me.LblNombre.Location = New System.Drawing.Point(62, 64)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 25
        Me.LblNombre.Text = "Nombre"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Cornsilk
        Me.LblCedula.Location = New System.Drawing.Point(53, 6)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(116, 13)
        Me.LblCedula.TabIndex = 49
        Me.LblCedula.Text = "Seleccione una cedula"
        '
        'CmbCi
        '
        Me.CmbCi.FormattingEnabled = True
        Me.CmbCi.Location = New System.Drawing.Point(56, 29)
        Me.CmbCi.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbCi.Name = "CmbCi"
        Me.CmbCi.Size = New System.Drawing.Size(132, 21)
        Me.CmbCi.TabIndex = 50
        '
        'RdbH
        '
        Me.RdbH.AutoSize = True
        Me.RdbH.Enabled = False
        Me.RdbH.Location = New System.Drawing.Point(185, 297)
        Me.RdbH.Margin = New System.Windows.Forms.Padding(2)
        Me.RdbH.Name = "RdbH"
        Me.RdbH.Size = New System.Drawing.Size(62, 17)
        Me.RdbH.TabIndex = 51
        Me.RdbH.TabStop = True
        Me.RdbH.Text = "Hombre"
        Me.RdbH.UseVisualStyleBackColor = True
        Me.RdbH.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Checked = True
        Me.RdbM.Enabled = False
        Me.RdbM.Location = New System.Drawing.Point(185, 317)
        Me.RdbM.Margin = New System.Windows.Forms.Padding(2)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(51, 17)
        Me.RdbM.TabIndex = 52
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "Mujer"
        Me.RdbM.UseVisualStyleBackColor = True
        Me.RdbM.Visible = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.Enabled = False
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(493, 238)
        Me.LstMedicaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(127, 96)
        Me.LstMedicaciones.TabIndex = 53
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        Me.LstMedicaciones.Visible = False
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.Enabled = False
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(299, 238)
        Me.LstEnfermedades.Margin = New System.Windows.Forms.Padding(2)
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(127, 96)
        Me.LstEnfermedades.TabIndex = 54
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedades.View = System.Windows.Forms.View.List
        Me.LstEnfermedades.Visible = False
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Enabled = False
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(345, 338)
        Me.BtnEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(56, 19)
        Me.BtnEliminarEnfermedad.TabIndex = 55
        Me.BtnEliminarEnfermedad.Text = "Eliminar"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnEliminarEnfermedad.Visible = False
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Enabled = False
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(533, 338)
        Me.BtnEliminarMedicacion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(56, 19)
        Me.BtnEliminarMedicacion.TabIndex = 56
        Me.BtnEliminarMedicacion.Text = "Eliminar"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        Me.BtnEliminarMedicacion.Visible = False
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(197, 278)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 57
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 390)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.BtnEliminarMedicacion)
        Me.Controls.Add(Me.BtnEliminarEnfermedad)
        Me.Controls.Add(Me.LstEnfermedades)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.RdbM)
        Me.Controls.Add(Me.RdbH)
        Me.Controls.Add(Me.CmbCi)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.BtnAgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
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
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmModificarUsuario"
        Me.Text = "FrmModificarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregarMedicacion As Button
    Friend WithEvents BtnAgregarEnfermedad As Button
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
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents BtnEliminarEnfermedad As Button
    Friend WithEvents BtnEliminarMedicacion As Button
    Friend WithEvents LblSexo As Label
End Class
