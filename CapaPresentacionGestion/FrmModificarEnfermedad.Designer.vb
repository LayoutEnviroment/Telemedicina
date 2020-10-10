<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarEnfermedad
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
        Me.CmbEnfermedades = New System.Windows.Forms.ComboBox()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.CbxModificarSintomas = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CmbEnfermedades
        '
        Me.CmbEnfermedades.FormattingEnabled = True
        Me.CmbEnfermedades.Location = New System.Drawing.Point(80, 66)
        Me.CmbEnfermedades.Name = "CmbEnfermedades"
        Me.CmbEnfermedades.Size = New System.Drawing.Size(121, 21)
        Me.CmbEnfermedades.TabIndex = 0
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.Location = New System.Drawing.Point(104, 41)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(50, 13)
        Me.LblEnfermedad.TabIndex = 1
        Me.LblEnfermedad.Text = "Sintomas"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(56, 111)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(159, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'LstSintomas
        '
        Me.LstSintomas.Enabled = False
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(298, 99)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(148, 185)
        Me.LstSintomas.TabIndex = 3
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(213, 367)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(90, 32)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(56, 156)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(159, 84)
        Me.TxtDescripcion.TabIndex = 5
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(54, 263)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(161, 21)
        Me.CmbPrioridad.TabIndex = 6
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Enabled = False
        Me.BtnQuitar.Location = New System.Drawing.Point(466, 248)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(42, 36)
        Me.BtnQuitar.TabIndex = 7
        Me.BtnQuitar.Text = "X"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Location = New System.Drawing.Point(466, 99)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(42, 36)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "<---"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(326, 367)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(90, 32)
        Me.BtnLimpiar.TabIndex = 9
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(444, 367)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(90, 32)
        Me.BtnVolver.TabIndex = 10
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'CmbSintomas
        '
        Me.CmbSintomas.Enabled = False
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(541, 108)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(121, 21)
        Me.CmbSintomas.TabIndex = 11
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Enabled = False
        Me.LblSintomas.Location = New System.Drawing.Point(441, 74)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(50, 13)
        Me.LblSintomas.TabIndex = 12
        Me.LblSintomas.Text = "Sintomas"
        '
        'CbxModificarSintomas
        '
        Me.CbxModificarSintomas.AutoSize = True
        Me.CbxModificarSintomas.Location = New System.Drawing.Point(383, 30)
        Me.CbxModificarSintomas.Name = "CbxModificarSintomas"
        Me.CbxModificarSintomas.Size = New System.Drawing.Size(168, 17)
        Me.CbxModificarSintomas.TabIndex = 13
        Me.CbxModificarSintomas.Text = "Desea modificar los sintomas?"
        Me.CbxModificarSintomas.UseVisualStyleBackColor = True
        '
        'FrmModificarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 457)
        Me.Controls.Add(Me.CbxModificarSintomas)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnQuitar)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LstSintomas)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.LblEnfermedad)
        Me.Controls.Add(Me.CmbEnfermedades)
        Me.Name = "FrmModificarEnfermedad"
        Me.Text = "FrmModificarEnfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedades As ComboBox
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents BtnQuitar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LblSintomas As Label
    Friend WithEvents CbxModificarSintomas As CheckBox
End Class
