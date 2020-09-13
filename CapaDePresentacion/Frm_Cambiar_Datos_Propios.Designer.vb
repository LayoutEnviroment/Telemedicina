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
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.LstEnfermedadesCronicas = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
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
        Me.LblSexo.Location = New System.Drawing.Point(218, 38)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 5
        Me.LblSexo.Text = "Sexo"
        '
        'LblFechaDeNacimiento
        '
        Me.LblFechaDeNacimiento.AutoSize = True
        Me.LblFechaDeNacimiento.Location = New System.Drawing.Point(179, 142)
        Me.LblFechaDeNacimiento.Name = "LblFechaDeNacimiento"
        Me.LblFechaDeNacimiento.Size = New System.Drawing.Size(110, 13)
        Me.LblFechaDeNacimiento.TabIndex = 6
        Me.LblFechaDeNacimiento.Text = "Fecha De Nacimiento"
        '
        'LblEnfermedadesCronicas
        '
        Me.LblEnfermedadesCronicas.AutoSize = True
        Me.LblEnfermedadesCronicas.Location = New System.Drawing.Point(402, 38)
        Me.LblEnfermedadesCronicas.Name = "LblEnfermedadesCronicas"
        Me.LblEnfermedadesCronicas.Size = New System.Drawing.Size(119, 13)
        Me.LblEnfermedadesCronicas.TabIndex = 7
        Me.LblEnfermedadesCronicas.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.Location = New System.Drawing.Point(637, 38)
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
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(182, 68)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(100, 20)
        Me.TxtSexo.TabIndex = 13
        '
        'LstEnfermedadesCronicas
        '
        Me.LstEnfermedadesCronicas.HideSelection = False
        Me.LstEnfermedadesCronicas.Location = New System.Drawing.Point(379, 68)
        Me.LstEnfermedadesCronicas.Name = "LstEnfermedadesCronicas"
        Me.LstEnfermedadesCronicas.Size = New System.Drawing.Size(158, 195)
        Me.LstEnfermedadesCronicas.TabIndex = 14
        Me.LstEnfermedadesCronicas.UseCompatibleStateImageBehavior = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(596, 68)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(158, 195)
        Me.LstMedicaciones.TabIndex = 15
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar1.Location = New System.Drawing.Point(434, 323)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowTodayCircle = False
        Me.MonthCalendar1.TabIndex = 16
        '
        'Frm_Cambiar_Datos_Propios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 507)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.LstEnfermedadesCronicas)
        Me.Controls.Add(Me.TxtSexo)
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
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents LstEnfermedadesCronicas As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
