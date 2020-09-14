<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cambiar_Datos_Propios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblCorreo = New System.Windows.Forms.Label()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblFechaDeNacimiento = New System.Windows.Forms.Label()
        Me.LblEnfermedadesCronicas = New System.Windows.Forms.Label()
        Me.LblMedicaciones = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.LstEnfermedadesCronicas = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.DttFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtAgregarEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtAgregarMedicacion = New System.Windows.Forms.TextBox()
        Me.BtnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnEliminarMedicacion = New System.Windows.Forms.Button()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.RdbMujer = New System.Windows.Forms.RadioButton()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.AgregarMedicacion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(63, 38)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(40, 13)
        Me.LblCedula.TabIndex = 0
        Me.LblCedula.Text = "Cedula"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(63, 142)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(67, 227)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(69, 323)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(38, 13)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "Correo"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(414, 38)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(595, 38)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(110, 13)
        Me.LblFechaDeNacimiento.TabIndex = 6
        Me.LblFechaDeNacimiento.Text = "Fecha De Nacimiento"
        '
        'LblEnfermedadesCronicas
        '
        Me.LblEnfermedadesCronicas.AutoSize = True
        Me.LblEnfermedadesCronicas.Location = New System.Drawing.Point(351, 193)
        Me.LblEnfermedadesCronicas.Name = "LblEnfermedadesCronicas"
        Me.LblEnfermedadesCronicas.Size = New System.Drawing.Size(119, 13)
        Me.LblEnfermedadesCronicas.TabIndex = 7
        Me.LblEnfermedadesCronicas.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.Location = New System.Drawing.Point(632, 193)
        Me.LblMedicaciones.Name = "LblMedicaciones"
        Me.LblMedicaciones.Size = New System.Drawing.Size(73, 13)
        Me.LblMedicaciones.TabIndex = 8
        Me.LblMedicaciones.Text = "Medicaciones"
        '
        'TxtCedula
        '
        Me.TxtCedula.Enabled = False
        Me.TxtCedula.Location = New System.Drawing.Point(29, 68)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(123, 20)
        Me.TxtCedula.TabIndex = 9
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(29, 158)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(123, 20)
        Me.TxtNombre.TabIndex = 10
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(29, 243)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(123, 20)
        Me.TxtApellido.TabIndex = 11
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(29, 339)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(236, 20)
        Me.TxtCorreo.TabIndex = 12
        '
        'LstEnfermedadesCronicas
        '
        Me.LstEnfermedadesCronicas.FullRowSelect = True
        Me.LstEnfermedadesCronicas.HideSelection = False
        Me.LstEnfermedadesCronicas.Location = New System.Drawing.Point(332, 223)
        Me.LstEnfermedadesCronicas.MultiSelect = False
        Me.LstEnfermedadesCronicas.Name = "LstEnfermedadesCronicas"
        Me.LstEnfermedadesCronicas.Size = New System.Drawing.Size(158, 195)
        Me.LstEnfermedadesCronicas.TabIndex = 14
        Me.LstEnfermedadesCronicas.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedadesCronicas.View = System.Windows.Forms.View.List
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(591, 223)
        Me.LstMedicaciones.MultiSelect = False
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(158, 195)
        Me.LstMedicaciones.TabIndex = 15
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        '
        'DttFechaNacimiento
        '
        Me.DttFechaNacimiento.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DttFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DttFechaNacimiento.Location = New System.Drawing.Point(598, 65)
        Me.DttFechaNacimiento.Name = "DttFechaNacimiento"
        Me.DttFechaNacimiento.Size = New System.Drawing.Size(200, 20)
        Me.DttFechaNacimiento.TabIndex = 17
        '
        'TxtAgregarEnfermedad
        '
        Me.TxtAgregarEnfermedad.Location = New System.Drawing.Point(332, 444)
        Me.TxtAgregarEnfermedad.Name = "TxtAgregarEnfermedad"
        Me.TxtAgregarEnfermedad.Size = New System.Drawing.Size(158, 20)
        Me.TxtAgregarEnfermedad.TabIndex = 18
        '
        'TxtAgregarMedicacion
        '
        Me.TxtAgregarMedicacion.Location = New System.Drawing.Point(591, 444)
        Me.TxtAgregarMedicacion.Name = "TxtAgregarMedicacion"
        Me.TxtAgregarMedicacion.Size = New System.Drawing.Size(158, 20)
        Me.TxtAgregarMedicacion.TabIndex = 19
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Enabled = False
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(496, 221)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(31, 25)
        Me.BtnEliminarEnfermedad.TabIndex = 20
        Me.BtnEliminarEnfermedad.Text = "X"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Enabled = False
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(755, 221)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(31, 25)
        Me.BtnEliminarMedicacion.TabIndex = 21
        Me.BtnEliminarMedicacion.Text = "X"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.Location = New System.Drawing.Point(367, 65)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(62, 17)
        Me.RdbMasculino.TabIndex = 22
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Hombre"
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'RdbMujer
        '
        Me.RdbMujer.AutoSize = True
        Me.RdbMujer.Location = New System.Drawing.Point(446, 65)
        Me.RdbMujer.Name = "RdbMujer"
        Me.RdbMujer.Size = New System.Drawing.Size(51, 17)
        Me.RdbMujer.TabIndex = 23
        Me.RdbMujer.TabStop = True
        Me.RdbMujer.Text = "Mujer"
        Me.RdbMujer.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(66, 442)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 24
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Enabled = False
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(497, 442)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(41, 23)
        Me.BtnAgregarEnfermedad.TabIndex = 25
        Me.BtnAgregarEnfermedad.Text = "Add"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        '
        'AgregarMedicacion
        '
        Me.AgregarMedicacion.Enabled = False
        Me.AgregarMedicacion.Location = New System.Drawing.Point(755, 444)
        Me.AgregarMedicacion.Name = "AgregarMedicacion"
        Me.AgregarMedicacion.Size = New System.Drawing.Size(41, 23)
        Me.AgregarMedicacion.TabIndex = 26
        Me.AgregarMedicacion.Text = "Add"
        Me.AgregarMedicacion.UseVisualStyleBackColor = True
        '
        'Frm_Cambiar_Datos_Propios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 507)
        Me.Controls.Add(Me.AgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.RdbMujer)
        Me.Controls.Add(Me.RdbMasculino)
        Me.Controls.Add(Me.BtnEliminarMedicacion)
        Me.Controls.Add(Me.BtnEliminarEnfermedad)
        Me.Controls.Add(Me.TxtAgregarMedicacion)
        Me.Controls.Add(Me.TxtAgregarEnfermedad)
        Me.Controls.Add(Me.DttFechaNacimiento)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.LstEnfermedadesCronicas)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.LblMedicaciones)
        Me.Controls.Add(Me.LblEnfermedadesCronicas)
        Me.Controls.Add(Me.LblFechaDeNacimiento)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblCorreo)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCedula)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Cambiar_Datos_Propios"
        Me.Text = "Frm_Cambiar_Datos_Propios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCedula As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblApellido As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblFechaDeNacimiento As Label
    Friend WithEvents LblEnfermedadesCronicas As Label
    Friend WithEvents LblMedicaciones As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents LstEnfermedadesCronicas As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents DttFechaNacimiento As DateTimePicker
    Friend WithEvents TxtAgregarEnfermedad As TextBox
    Friend WithEvents TxtAgregarMedicacion As TextBox
    Friend WithEvents BtnEliminarEnfermedad As Button
    Friend WithEvents BtnEliminarMedicacion As Button
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents RdbMujer As RadioButton
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnAgregarEnfermedad As Button
    Friend WithEvents AgregarMedicacion As Button
End Class
