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
        Me.SuspendLayout()
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Enabled = False
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(799, 263)
        Me.BtnAgregarMedicacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarMedicacion.TabIndex = 42
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Enabled = False
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(531, 263)
        Me.BtnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarEnfermedad.TabIndex = 39
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Enabled = False
        Me.TxtMedicacion.Location = New System.Drawing.Point(657, 263)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(127, 22)
        Me.TxtMedicacion.TabIndex = 41
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Enabled = False
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(399, 263)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(113, 22)
        Me.TxtEnfermedadCronica.TabIndex = 38
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Enabled = False
        Me.LblMedicacion.Location = New System.Drawing.Point(679, 245)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(79, 17)
        Me.LblMedicacion.TabIndex = 47
        Me.LblMedicacion.Text = "Medicación"
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Enabled = False
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(411, 241)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(159, 17)
        Me.LblEnfermedadCronica.TabIndex = 46
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(697, 170)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(127, 32)
        Me.BtnVolver.TabIndex = 45
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(697, 118)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 32)
        Me.BtnCancelar.TabIndex = 44
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(697, 65)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(127, 32)
        Me.BtnAceptar.TabIndex = 43
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Enabled = False
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(7, 363)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(200, 22)
        Me.DtpFechaNacimiento.TabIndex = 37
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Enabled = False
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(31, 342)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(141, 17)
        Me.LblFechaNacimiento.TabIndex = 40
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(163, 305)
        Me.ChbAdministrador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(118, 21)
        Me.ChbAdministrador.TabIndex = 36
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(163, 278)
        Me.ChbMedico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(75, 21)
        Me.ChbMedico.TabIndex = 35
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(163, 250)
        Me.ChbPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(85, 21)
        Me.ChbPaciente.TabIndex = 34
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'TxtMail
        '
        Me.TxtMail.Enabled = False
        Me.TxtMail.Location = New System.Drawing.Point(56, 151)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(443, 22)
        Me.TxtMail.TabIndex = 32
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(57, -26)
        Me.TxtCI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtCI.MaxLength = 9
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(183, 22)
        Me.TxtCI.TabIndex = 26
        '
        'TxtApellido
        '
        Me.TxtApellido.CausesValidation = False
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Location = New System.Drawing.Point(316, 111)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(183, 22)
        Me.TxtApellido.TabIndex = 30
        '
        'TxtNombre
        '
        Me.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TxtNombre.CausesValidation = False
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(56, 111)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(183, 22)
        Me.TxtNombre.TabIndex = 27
        Me.TxtNombre.Tag = "^[a-zA-Z]+$"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Enabled = False
        Me.LblUsuario.Location = New System.Drawing.Point(31, 250)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(109, 17)
        Me.LblUsuario.TabIndex = 33
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Enabled = False
        Me.LblMail.Location = New System.Drawing.Point(52, 186)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 31
        Me.LblMail.Text = "Mail"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(100, -58)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(20, 17)
        Me.LblCI.TabIndex = 29
        Me.LblCI.Text = "CI"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Enabled = False
        Me.LblApellido.Location = New System.Drawing.Point(340, 79)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 28
        Me.LblApellido.Text = "Apellido"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Enabled = False
        Me.LblNombre.Location = New System.Drawing.Point(83, 79)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblNombre.TabIndex = 25
        Me.LblNombre.Text = "Nombre"
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.BackColor = System.Drawing.Color.Cornsilk
        Me.LblCedula.Location = New System.Drawing.Point(71, 7)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(151, 17)
        Me.LblCedula.TabIndex = 49
        Me.LblCedula.Text = "Seleccione una cedula"
        '
        'CmbCi
        '
        Me.CmbCi.FormattingEnabled = True
        Me.CmbCi.Location = New System.Drawing.Point(75, 36)
        Me.CmbCi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CmbCi.Name = "CmbCi"
        Me.CmbCi.Size = New System.Drawing.Size(175, 24)
        Me.CmbCi.TabIndex = 50
        '
        'RdbH
        '
        Me.RdbH.AutoSize = True
        Me.RdbH.Enabled = False
        Me.RdbH.Location = New System.Drawing.Point(247, 366)
        Me.RdbH.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdbH.Name = "RdbH"
        Me.RdbH.Size = New System.Drawing.Size(79, 21)
        Me.RdbH.TabIndex = 51
        Me.RdbH.TabStop = True
        Me.RdbH.Text = "Hombre"
        Me.RdbH.UseVisualStyleBackColor = True
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Enabled = False
        Me.RdbM.Location = New System.Drawing.Point(247, 390)
        Me.RdbM.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(64, 21)
        Me.RdbM.TabIndex = 52
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "Mujer"
        Me.RdbM.UseVisualStyleBackColor = True
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.Enabled = False
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(657, 293)
        Me.LstMedicaciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(168, 117)
        Me.LstMedicaciones.TabIndex = 53
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.Enabled = False
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(399, 293)
        Me.LstEnfermedades.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(168, 117)
        Me.LstEnfermedades.TabIndex = 54
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Enabled = False
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(521, 414)
        Me.BtnEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarEnfermedad.TabIndex = 55
        Me.BtnEliminarEnfermedad.Text = "Eliminar"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Enabled = False
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(799, 414)
        Me.BtnEliminarMedicacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarMedicacion.TabIndex = 56
        Me.BtnEliminarMedicacion.Text = "Eliminar"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 441)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
End Class
