<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarPaciente
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
        Me.LblNombre.Location = New System.Drawing.Point(116, 91)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(272, 91)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 1
        Me.LblApellido.Text = "Apellido"
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.Location = New System.Drawing.Point(198, 174)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(37, 20)
        Me.LblMail.TabIndex = 3
        Me.LblMail.Text = "Mail"
        '
        'LblFechaNacimiento
        '
        Me.LblFechaNacimiento.AutoSize = True
        Me.LblFechaNacimiento.Location = New System.Drawing.Point(97, 270)
        Me.LblFechaNacimiento.Name = "LblFechaNacimiento"
        Me.LblFechaNacimiento.Size = New System.Drawing.Size(159, 20)
        Me.LblFechaNacimiento.TabIndex = 4
        Me.LblFechaNacimiento.Text = "Fecha de Nacimiento"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(97, 412)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(45, 20)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblEnfermedadCronica
        '
        Me.LblEnfermedadCronica.AutoSize = True
        Me.LblEnfermedadCronica.Location = New System.Drawing.Point(458, 91)
        Me.LblEnfermedadCronica.Name = "LblEnfermedadCronica"
        Me.LblEnfermedadCronica.Size = New System.Drawing.Size(180, 20)
        Me.LblEnfermedadCronica.TabIndex = 6
        Me.LblEnfermedadCronica.Text = "Enfermedades Crónicas"
        '
        'LblMedicacion
        '
        Me.LblMedicacion.AutoSize = True
        Me.LblMedicacion.Location = New System.Drawing.Point(505, 338)
        Me.LblMedicacion.Name = "LblMedicacion"
        Me.LblMedicacion.Size = New System.Drawing.Size(89, 20)
        Me.LblMedicacion.TabIndex = 7
        Me.LblMedicacion.Text = "Medicación"
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(588, 372)
        Me.BtnAgregarMedicacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarMedicacion.TabIndex = 40
        Me.BtnAgregarMedicacion.Text = "Agregar"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(588, 130)
        Me.BtnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(84, 29)
        Me.BtnAgregarEnfermedad.TabIndex = 39
        Me.BtnAgregarEnfermedad.Text = "Agregar"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        '
        'LstMedicacion
        '
        Me.LstMedicacion.FormattingEnabled = True
        Me.LstMedicacion.ItemHeight = 20
        Me.LstMedicacion.Location = New System.Drawing.Point(440, 412)
        Me.LstMedicacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstMedicacion.Name = "LstMedicacion"
        Me.LstMedicacion.Size = New System.Drawing.Size(141, 124)
        Me.LstMedicacion.TabIndex = 38
        '
        'LstEnfermedadCronica
        '
        Me.LstEnfermedadCronica.FormattingEnabled = True
        Me.LstEnfermedadCronica.ItemHeight = 20
        Me.LstEnfermedadCronica.Location = New System.Drawing.Point(440, 166)
        Me.LstEnfermedadCronica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstEnfermedadCronica.Name = "LstEnfermedadCronica"
        Me.LstEnfermedadCronica.Size = New System.Drawing.Size(141, 104)
        Me.LstEnfermedadCronica.TabIndex = 37
        '
        'TxtMedicacion
        '
        Me.TxtMedicacion.Location = New System.Drawing.Point(440, 372)
        Me.TxtMedicacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMedicacion.MaxLength = 40
        Me.TxtMedicacion.Name = "TxtMedicacion"
        Me.TxtMedicacion.Size = New System.Drawing.Size(141, 26)
        Me.TxtMedicacion.TabIndex = 36
        '
        'TxtEnfermedadCronica
        '
        Me.TxtEnfermedadCronica.Location = New System.Drawing.Point(440, 130)
        Me.TxtEnfermedadCronica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtEnfermedadCronica.MaxLength = 40
        Me.TxtEnfermedadCronica.Name = "TxtEnfermedadCronica"
        Me.TxtEnfermedadCronica.Size = New System.Drawing.Size(128, 26)
        Me.TxtEnfermedadCronica.TabIndex = 35
        '
        'RdbF
        '
        Me.RdbF.AutoSize = True
        Me.RdbF.Location = New System.Drawing.Point(162, 446)
        Me.RdbF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdbF.Name = "RdbF"
        Me.RdbF.Size = New System.Drawing.Size(44, 24)
        Me.RdbF.TabIndex = 34
        Me.RdbF.Text = "F"
        Me.RdbF.UseVisualStyleBackColor = True
        '
        'RdbM
        '
        Me.RdbM.AutoSize = True
        Me.RdbM.Checked = True
        Me.RdbM.Location = New System.Drawing.Point(162, 412)
        Me.RdbM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RdbM.Name = "RdbM"
        Me.RdbM.Size = New System.Drawing.Size(47, 24)
        Me.RdbM.TabIndex = 33
        Me.RdbM.TabStop = True
        Me.RdbM.Text = "M"
        Me.RdbM.UseVisualStyleBackColor = True
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(80, 308)
        Me.DtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(224, 26)
        Me.DtpFechaNacimiento.TabIndex = 32
        '
        'TxtMail
        '
        Me.TxtMail.Location = New System.Drawing.Point(80, 202)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtMail.MaxLength = 100
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(284, 26)
        Me.TxtMail.TabIndex = 31
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(237, 131)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtApellido.MaxLength = 25
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(127, 26)
        Me.TxtApellido.TabIndex = 29
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(80, 131)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombre.MaxLength = 25
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(132, 26)
        Me.TxtNombre.TabIndex = 28
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(726, 222)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(143, 40)
        Me.BtnVolver.TabIndex = 43
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(726, 158)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(143, 40)
        Me.BtnCancelar.TabIndex = 42
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(726, 91)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(143, 40)
        Me.BtnAceptar.TabIndex = 41
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(588, 174)
        Me.BtnEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(84, 29)
        Me.BtnEliminarEnfermedad.TabIndex = 44
        Me.BtnEliminarEnfermedad.Text = "Eliminar"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(588, 412)
        Me.BtnEliminarMedicacion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(84, 29)
        Me.BtnEliminarMedicacion.TabIndex = 45
        Me.BtnEliminarMedicacion.Text = "Eliminar"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        '
        'LblSeleccionarCI
        '
        Me.LblSeleccionarCI.AutoSize = True
        Me.LblSeleccionarCI.Location = New System.Drawing.Point(76, 35)
        Me.LblSeleccionarCI.Name = "LblSeleccionarCI"
        Me.LblSeleccionarCI.Size = New System.Drawing.Size(204, 20)
        Me.LblSeleccionarCI.TabIndex = 46
        Me.LblSeleccionarCI.Text = "Seleccione la CI a modificar"
        '
        'CmbSeleccionarCI
        '
        Me.CmbSeleccionarCI.FormattingEnabled = True
        Me.CmbSeleccionarCI.Location = New System.Drawing.Point(300, 35)
        Me.CmbSeleccionarCI.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbSeleccionarCI.Name = "CmbSeleccionarCI"
        Me.CmbSeleccionarCI.Size = New System.Drawing.Size(136, 28)
        Me.CmbSeleccionarCI.TabIndex = 47
        '
        'FrmModificarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmModificarPaciente"
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
