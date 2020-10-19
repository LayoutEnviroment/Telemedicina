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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Cornsilk
        Me.LblNombre.Location = New System.Drawing.Point(107, 66)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(300, 66)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblCI
        '
        Me.LblCI.AutoSize = True
        Me.LblCI.Location = New System.Drawing.Point(119, 7)
        Me.LblCI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCI.Name = "LblCI"
        Me.LblCI.Size = New System.Drawing.Size(17, 13)
        Me.LblCI.TabIndex = 2
        Me.LblCI.Text = "CI"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(107, 132)
        Me.LblMail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(26, 13)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.Location = New System.Drawing.Point(79, 204)
        Me.LblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(82, 13)
        Me.LblUsuario.TabIndex = 4
        Me.LblUsuario.Text = "Tipo de Usuario"
        '
        'TxtNombre
        '
        Me.TxtNombre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.TxtNombre.CausesValidation = False
        Me.TxtNombre.Location = New System.Drawing.Point(87, 93)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(138, 20)
        Me.TxtNombre.TabIndex = 1
        Me.TxtNombre.Tag = "^[a-zA-Z]+$"
        '
        'TxtApellido
        '
        Me.TxtApellido.CausesValidation = False
        Me.TxtApellido.Location = New System.Drawing.Point(282, 93)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(138, 20)
        Me.TxtApellido.TabIndex = 2
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(87, 147)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMail.MaxLength = 50
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(333, 20)
        Me.TxtMail.TabIndex = 3
        '
        'TxtCI
        '
        Me.TxtCI.AccessibleDescription = "Ingrese su cedula sin puntos ni guiones"
        Me.TxtCI.Location = New System.Drawing.Point(87, 34)
        Me.TxtCI.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtCI.MaxLength = 9
        Me.TxtCI.Name = "TxtCI"
        Me.TxtCI.Size = New System.Drawing.Size(138, 20)
        Me.TxtCI.TabIndex = 0
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(166, 204)
        Me.ChbPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(68, 17)
        Me.ChbPaciente.TabIndex = 4
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(166, 226)
        Me.ChbMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(61, 17)
        Me.ChbMedico.TabIndex = 5
        Me.ChbMedico.Text = "Medico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(166, 248)
        Me.ChbAdministrador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(91, 17)
        Me.ChbAdministrador.TabIndex = 6
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(67, 332)
        Me.LblFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LblFechaNacimiento.TabIndex = 12
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        Me.LblFechaNacimiento.Visible = False
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(46, 399)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 13
        Me.LblSexo.Text = "Sexo"
        Me.LblSexo.Visible = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(49, 350)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(151, 20)
        Me.DtpFechaNacimiento.TabIndex = 7
        Me.DtpFechaNacimiento.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Checked = True
        Me.RdbM.Location = New System.Drawing.Point(87, 397)
        Me.RdbM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(34, 17)
        Me.RdbM.TabIndex = 8
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "M"
        Me.RdbM.UseVisualStyleBackColor = True
        Me.RdbM.Visible = False
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.Location = New System.Drawing.Point(87, 419)
        Me.RdbF.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(31, 17)
        Me.RdbF.TabIndex = 9
        Me.RdbF.TabStop = True
        Me.RdbF.Text = "F"
        Me.RdbF.UseVisualStyleBackColor = True
        Me.RdbF.Visible = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(568, 55)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(95, 26)
        Me.BtnAceptar.TabIndex = 14
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(568, 98)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(95, 26)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(568, 141)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(95, 26)
        Me.BtnVolver.TabIndex = 16
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(282, 291)
        Me.LblEnfermedadCronica.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(119, 13)
        Me.LblEnfermedadCronica.TabIndex = 20
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        Me.LblEnfermedadCronica.Visible = False
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(491, 332)
        Me.LblMedicacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(62, 13)
        Me.LblMedicacion.TabIndex = 21
        Me.LblMedicacion.Text = "Medicación"
        Me.LblMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(273, 308)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(86, 20)
        Me.TxtEnfermedadCronica.TabIndex = 10
        Me.TxtEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(474, 348)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(96, 20)
        Me.TxtMedicacion.TabIndex = 12
        Me.TxtMedicacion.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(273, 332)
        Me.LstEnfermedadCronica.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(156, 95)
        Me.LstEnfermedadCronica.TabIndex = 24
        Me.LstEnfermedadCronica.Visible = False
        '
        'LstMedicacion
        '
        Me.LstMedicacion.FormattingEnabled = True
        Me.LstMedicacion.Location = New System.Drawing.Point(474, 374)
        Me.LstMedicacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(156, 69)
        Me.LstMedicacion.TabIndex = 25
        Me.LstMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(372, 308)
        Me.BtnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(56, 19)
        Me.BtnAgregarEnfermedad.TabIndex = 11
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(580, 347)
        Me.BtnAgregarMedicacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(56, 19)
        Me.BtnAgregarMedicacion.TabIndex = 13
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(303, 430)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(85, 20)
        Me.BtnEliminar.TabIndex = 26
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'FrmAltaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 469)
        Me.Controls.Add(Me.BtnEliminar)
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
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents BtnEliminar As Button
End Class
