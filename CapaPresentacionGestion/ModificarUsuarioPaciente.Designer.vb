<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuarioPaciente
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
        Me.LblMail = New System.Windows.Forms.Label()
        Me.LblFechaNacimiento = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblEnfermedadCronica = New System.Windows.Forms.Label()
        Me.LblMedicacion = New System.Windows.Forms.Label()
        Me.BtnAgregarMedicacion = New System.Windows.Forms.Button()
        Me.BtnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.LstMedicacion = New System.Windows.Forms.ListBox()
        Me.LstEnfermedadCronica = New System.Windows.Forms.ListBox()
        Me.TxtMedicacion = New System.Windows.Forms.TextBox()
        Me.TxtEnfermedadCronica = New System.Windows.Forms.TextBox()
        Me.RdbF = New System.Windows.Forms.RadioButton()
        Me.RdbM = New System.Windows.Forms.RadioButton()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnEliminarMedicacion = New System.Windows.Forms.Button()
        Me.LblSeleccionarCI = New System.Windows.Forms.Label()
        Me.CmbSeleccionarCI = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(103, 73)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(58, 17)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(242, 73)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(58, 17)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(176, 139)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(33, 17)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(86, 216)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(141, 17)
        Me.LblFechaNacimiento.TabIndex = 4
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(86, 330)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(39, 17)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(407, 73)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(159, 17)
        Me.LblEnfermedadCronica.TabIndex = 6
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(449, 270)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(79, 17)
        Me.LblMedicacion.TabIndex = 7
        Me.LblMedicacion.Text = "Medicación"
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(523, 298)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarMedicacion.TabIndex = 40
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        Me.BtnAgregarMedicacion.Visible = False
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(523, 104)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregarEnfermedad.TabIndex = 39
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnAgregarEnfermedad.Visible = False
        '
        'LstMedicacion
        '
        Me.LstMedicacion.FormattingEnabled = True
        Me.LstMedicacion.ItemHeight = 16
        Me.LstMedicacion.Location = New System.Drawing.Point(391, 330)
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(126, 100)
        Me.LstMedicacion.TabIndex = 38
        Me.LstMedicacion.Visible = False
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.ItemHeight = 16
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(391, 133)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(126, 84)
        Me.LstEnfermedadCronica.TabIndex = 37
        Me.LstEnfermedadCronica.Visible = False
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(391, 298)
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(126, 22)
        Me.TxtMedicacion.TabIndex = 36
        Me.TxtMedicacion.Visible = False
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(391, 104)
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(114, 22)
        Me.TxtEnfermedadCronica.TabIndex = 35
        Me.TxtEnfermedadCronica.Visible = False
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.Location = New System.Drawing.Point(144, 357)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(37, 21)
        Me.RdbF.TabIndex = 34
        Me.RdbF.TabStop = True
        Me.RdbF.Text = "F"
        Me.RdbF.UseVisualStyleBackColor = True
        Me.RdbF.Visible = False
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Location = New System.Drawing.Point(144, 330)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(40, 21)
        Me.RdbM.TabIndex = 33
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "M"
        Me.RdbM.UseVisualStyleBackColor = True
        Me.RdbM.Visible = False
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(71, 246)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(200, 22)
        Me.DtpFechaNacimiento.TabIndex = 32
        Me.DtpFechaNacimiento.Visible = False
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(71, 162)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(253, 22)
        Me.TxtMail.TabIndex = 31
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(211, 105)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(113, 22)
        Me.TxtApellido.TabIndex = 29
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(71, 105)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(118, 22)
        Me.TxtNombre.TabIndex = 28
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(645, 178)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(127, 32)
        Me.BtnVolver.TabIndex = 43
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(645, 126)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 32)
        Me.BtnCancelar.TabIndex = 42
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(645, 73)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(127, 32)
        Me.BtnAceptar.TabIndex = 41
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(523, 139)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarEnfermedad.TabIndex = 44
        Me.BtnEliminarEnfermedad.Text = "Eliminar"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        Me.BtnEliminarEnfermedad.Visible = False
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(523, 330)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminarMedicacion.TabIndex = 45
        Me.BtnEliminarMedicacion.Text = "Eliminar"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        Me.BtnEliminarMedicacion.Visible = False
        '
        'LblSeleccionarCI
        '
        Me.LblSeleccionarCI.AutoSize = True
        Me.LblSeleccionarCI.Location = New System.Drawing.Point(68, 28)
        Me.LblSeleccionarCI.Name = "LblSeleccionarCI"
        Me.LblSeleccionarCI.Size = New System.Drawing.Size(181, 17)
        Me.LblSeleccionarCI.TabIndex = 46
        Me.LblSeleccionarCI.Text = "Seleccione la CI a modificar"
        '
        'CmbSeleccionarCI
        '
        Me.CmbSeleccionarCI.FormattingEnabled = True
        Me.CmbSeleccionarCI.Location = New System.Drawing.Point(267, 28)
        Me.CmbSeleccionarCI.Name = "CmbSeleccionarCI"
        Me.CmbSeleccionarCI.Size = New System.Drawing.Size(121, 24)
        Me.CmbSeleccionarCI.TabIndex = 47
        '
        'ModificarUsuarioPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CmbSeleccionarCI)
        Me.Controls.Add(Me.LblSeleccionarCI)
        Me.Controls.Add(Me.BtnEliminarMedicacion)
        Me.Controls.Add(Me.BtnEliminarEnfermedad)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.BtnAgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
        Me.Controls.Add(Me.LstMedicacion)
        Me.Controls.Add(Me.LstEnfermedadCronica)
        Me.Controls.Add(Me.TxtMedicacion)
        Me.Controls.Add(Me.TxtEnfermedadCronica)
        Me.Controls.Add(Me.RdbF)
        Me.Controls.Add(Me.RdbM)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblMedicacion)
        Me.Controls.Add(Me.LblEnfermedadCronica)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblFechaNacimiento)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Name = "ModificarUsuarioPaciente"
        Me.Text = "ModificarUsuarioPaciente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents LblFechaNacimiento As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblEnfermedadCronica As Label
    Friend WithEvents LblMedicacion As Label
    Friend WithEvents BtnAgregarMedicacion As Button
    Friend WithEvents BtnAgregarEnfermedad As Button
    Friend WithEvents LstMedicacion As ListBox
    Friend WithEvents LstEnfermedadCronica As ListBox
    Friend WithEvents TxtMedicacion As TextBox
    Friend WithEvents TxtEnfermedadCronica As TextBox
    Friend WithEvents RdbF As RadioButton
    Friend WithEvents RdbM As RadioButton
    Friend WithEvents DtpFechaNacimiento As DateTimePicker
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnEliminarEnfermedad As Button
    Friend WithEvents BtnEliminarMedicacion As Button
    Friend WithEvents LblSeleccionarCI As Label
    Friend WithEvents CmbSeleccionarCI As ComboBox
End Class
