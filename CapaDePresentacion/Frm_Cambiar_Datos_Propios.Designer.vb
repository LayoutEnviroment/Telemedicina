<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Cambiar_Datos_Propios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TxtAgregarEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtAgregarMedicacion = New System.Windows.Forms.TextBox()
        Me.BtnEliminarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnEliminarMedicacion = New System.Windows.Forms.Button()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.RdbMujer = New System.Windows.Forms.RadioButton()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnAgregarEnfermedad = New System.Windows.Forms.Button()
        Me.BtnAgregarMedicacion = New System.Windows.Forms.Button()
        Me.DttFecha = New System.Windows.Forms.DateTimePicker()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(94, 58)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(59, 20)
        Me.LblCedula.TabIndex = 0
        Me.LblCedula.Text = "Cedula"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(94, 218)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(100, 349)
        Me.LblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(65, 20)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido"
        '
        'LblCorreo
        '
        Me.LblCorreo.AutoSize = True
        Me.LblCorreo.Location = New System.Drawing.Point(104, 497)
        Me.LblCorreo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblCorreo.Name = "LblCorreo"
        Me.LblCorreo.Size = New System.Drawing.Size(57, 20)
        Me.LblCorreo.TabIndex = 3
        Me.LblCorreo.Text = "Correo"
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(621, 58)
        Me.LblSexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(45, 20)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(892, 58)
        Me.LblFechaDeNacimiento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(162, 20)
        Me.LblFechaDeNacimiento.TabIndex = 6
        Me.LblFechaDeNacimiento.Text = "Fecha De Nacimiento"
        '
        'LblEnfermedadesCronicas
        '
        Me.LblEnfermedadesCronicas.AutoSize = True
        Me.LblEnfermedadesCronicas.Location = New System.Drawing.Point(526, 297)
        Me.LblEnfermedadesCronicas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedadesCronicas.Name = "LblEnfermedadesCronicas"
        Me.LblEnfermedadesCronicas.Size = New System.Drawing.Size(180, 20)
        Me.LblEnfermedadesCronicas.TabIndex = 7
        Me.LblEnfermedadesCronicas.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.Location = New System.Drawing.Point(948, 297)
        Me.LblMedicaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMedicaciones.Name = "LblMedicaciones"
        Me.LblMedicaciones.Size = New System.Drawing.Size(106, 20)
        Me.LblMedicaciones.TabIndex = 8
        Me.LblMedicaciones.Text = "Medicaciones"
        '
        'TxtCedula
        '
        Me.TxtCedula.Enabled = False
        Me.TxtCedula.Location = New System.Drawing.Point(44, 105)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(182, 26)
        Me.TxtCedula.TabIndex = 9
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(44, 243)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(182, 26)
        Me.TxtNombre.TabIndex = 10
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(44, 374)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(182, 26)
        Me.TxtApellido.TabIndex = 11
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(44, 522)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(352, 26)
        Me.TxtCorreo.TabIndex = 12
        '
        'LstEnfermedadesCronicas
        '
        Me.LstEnfermedadesCronicas.FullRowSelect = True
        Me.LstEnfermedadesCronicas.HideSelection = False
        Me.LstEnfermedadesCronicas.Location = New System.Drawing.Point(498, 343)
        Me.LstEnfermedadesCronicas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstEnfermedadesCronicas.MultiSelect = False
        Me.LstEnfermedadesCronicas.Name = "LstEnfermedadesCronicas"
        Me.LstEnfermedadesCronicas.Size = New System.Drawing.Size(235, 298)
        Me.LstEnfermedadesCronicas.TabIndex = 14
        Me.LstEnfermedadesCronicas.UseCompatibleStateImageBehavior = False
        Me.LstEnfermedadesCronicas.View = System.Windows.Forms.View.List
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(886, 343)
        Me.LstMedicaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstMedicaciones.MultiSelect = False
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(235, 298)
        Me.LstMedicaciones.TabIndex = 15
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        Me.LstMedicaciones.View = System.Windows.Forms.View.List
        '
        'TxtAgregarEnfermedad
        '
        Me.TxtAgregarEnfermedad.Location = New System.Drawing.Point(498, 683)
        Me.TxtAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAgregarEnfermedad.Name = "TxtAgregarEnfermedad"
        Me.TxtAgregarEnfermedad.Size = New System.Drawing.Size(235, 26)
        Me.TxtAgregarEnfermedad.TabIndex = 18
        '
        'TxtAgregarMedicacion
        '
        Me.TxtAgregarMedicacion.Location = New System.Drawing.Point(886, 683)
        Me.TxtAgregarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtAgregarMedicacion.Name = "TxtAgregarMedicacion"
        Me.TxtAgregarMedicacion.Size = New System.Drawing.Size(235, 26)
        Me.TxtAgregarMedicacion.TabIndex = 19
        '
        'BtnEliminarEnfermedad
        '
        Me.BtnEliminarEnfermedad.Enabled = False
        Me.BtnEliminarEnfermedad.Location = New System.Drawing.Point(744, 340)
        Me.BtnEliminarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEliminarEnfermedad.Name = "BtnEliminarEnfermedad"
        Me.BtnEliminarEnfermedad.Size = New System.Drawing.Size(46, 38)
        Me.BtnEliminarEnfermedad.TabIndex = 20
        Me.BtnEliminarEnfermedad.Text = "X"
        Me.BtnEliminarEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnEliminarMedicacion
        '
        Me.BtnEliminarMedicacion.Enabled = False
        Me.BtnEliminarMedicacion.Location = New System.Drawing.Point(1132, 340)
        Me.BtnEliminarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEliminarMedicacion.Name = "BtnEliminarMedicacion"
        Me.BtnEliminarMedicacion.Size = New System.Drawing.Size(46, 38)
        Me.BtnEliminarMedicacion.TabIndex = 21
        Me.BtnEliminarMedicacion.Text = "X"
        Me.BtnEliminarMedicacion.UseVisualStyleBackColor = True
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.Location = New System.Drawing.Point(550, 100)
        Me.RdbMasculino.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(91, 24)
        Me.RdbMasculino.TabIndex = 22
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Hombre"
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'RdbMujer
        '
        Me.RdbMujer.AutoSize = True
        Me.RdbMujer.Location = New System.Drawing.Point(669, 100)
        Me.RdbMujer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RdbMujer.Name = "RdbMujer"
        Me.RdbMujer.Size = New System.Drawing.Size(73, 24)
        Me.RdbMujer.TabIndex = 23
        Me.RdbMujer.TabStop = True
        Me.RdbMujer.Text = "Mujer"
        Me.RdbMujer.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(99, 680)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(112, 35)
        Me.BtnAceptar.TabIndex = 24
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnAgregarEnfermedad
        '
        Me.BtnAgregarEnfermedad.Enabled = False
        Me.BtnAgregarEnfermedad.Location = New System.Drawing.Point(746, 680)
        Me.BtnAgregarEnfermedad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAgregarEnfermedad.Name = "BtnAgregarEnfermedad"
        Me.BtnAgregarEnfermedad.Size = New System.Drawing.Size(62, 35)
        Me.BtnAgregarEnfermedad.TabIndex = 25
        Me.BtnAgregarEnfermedad.Text = "Add"
        Me.BtnAgregarEnfermedad.UseVisualStyleBackColor = True
        '
        'BtnAgregarMedicacion
        '
        Me.BtnAgregarMedicacion.Enabled = False
        Me.BtnAgregarMedicacion.Location = New System.Drawing.Point(1132, 683)
        Me.BtnAgregarMedicacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAgregarMedicacion.Name = "BtnAgregarMedicacion"
        Me.BtnAgregarMedicacion.Size = New System.Drawing.Size(62, 35)
        Me.BtnAgregarMedicacion.TabIndex = 26
        Me.BtnAgregarMedicacion.Text = "Add"
        Me.BtnAgregarMedicacion.UseVisualStyleBackColor = True
        '
        'DttFecha
        '
        Me.DttFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DttFecha.Location = New System.Drawing.Point(910, 100)
        Me.DttFecha.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DttFecha.Name = "DttFecha"
        Me.DttFecha.Size = New System.Drawing.Size(145, 26)
        Me.DttFecha.TabIndex = 27
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(332, 683)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(107, 28)
        Me.BtnCancelar.TabIndex = 28
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(332, 26)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(84, 37)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Frm_Cambiar_Datos_Propios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1371, 780)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.DttFecha)
        Me.Controls.Add(Me.BtnAgregarMedicacion)
        Me.Controls.Add(Me.BtnAgregarEnfermedad)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.RdbMujer)
        Me.Controls.Add(Me.RdbMasculino)
        Me.Controls.Add(Me.BtnEliminarMedicacion)
        Me.Controls.Add(Me.BtnEliminarEnfermedad)
        Me.Controls.Add(Me.TxtAgregarMedicacion)
        Me.Controls.Add(Me.TxtAgregarEnfermedad)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents TxtAgregarEnfermedad As TextBox
    Friend WithEvents TxtAgregarMedicacion As TextBox
    Friend WithEvents BtnEliminarEnfermedad As Button
    Friend WithEvents BtnEliminarMedicacion As Button
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents RdbMujer As RadioButton
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnAgregarEnfermedad As Button
    Friend WithEvents BtnAgregarMedicacion As Button
    Friend WithEvents DttFecha As DateTimePicker
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnSalir As Button
End Class
