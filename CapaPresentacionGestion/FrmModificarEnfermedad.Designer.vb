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
        Me.CmbEnfermedades.Location = New System.Drawing.Point(120, 102)
        Me.CmbEnfermedades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbEnfermedades.Name = "CmbEnfermedades"
        Me.CmbEnfermedades.Size = New System.Drawing.Size(180, 28)
        Me.CmbEnfermedades.TabIndex = 0
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.Location = New System.Drawing.Point(156, 63)
        Me.LblEnfermedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(114, 20)
        Me.LblEnfermedad.TabIndex = 1
        Me.LblEnfermedad.Text = "Enfermedades"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(84, 171)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(236, 26)
        Me.TxtNombre.TabIndex = 2
        '
        'LstSintomas
        '
        Me.LstSintomas.Enabled = False
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(447, 152)
        Me.LstSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(220, 282)
        Me.LstSintomas.TabIndex = 3
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(320, 565)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(135, 49)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(84, 240)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(236, 127)
        Me.TxtDescripcion.TabIndex = 5
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(81, 405)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(240, 28)
        Me.CmbPrioridad.TabIndex = 6
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Enabled = False
        Me.BtnQuitar.Location = New System.Drawing.Point(699, 382)
        Me.BtnQuitar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(63, 55)
        Me.BtnQuitar.TabIndex = 7
        Me.BtnQuitar.Text = "X"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Enabled = False
        Me.BtnAgregar.Location = New System.Drawing.Point(699, 152)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(63, 55)
        Me.BtnAgregar.TabIndex = 8
        Me.BtnAgregar.Text = "<---"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(489, 565)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(135, 49)
        Me.BtnLimpiar.TabIndex = 9
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(666, 565)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(135, 49)
        Me.BtnVolver.TabIndex = 10
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'CmbSintomas
        '
        Me.CmbSintomas.Enabled = False
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(812, 166)
        Me.CmbSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(180, 28)
        Me.CmbSintomas.TabIndex = 11
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Enabled = False
        Me.LblSintomas.Location = New System.Drawing.Point(662, 114)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(76, 20)
        Me.LblSintomas.TabIndex = 12
        Me.LblSintomas.Text = "Sintomas"
        '
        'CbxModificarSintomas
        '
        Me.CbxModificarSintomas.AutoSize = True
        Me.CbxModificarSintomas.Location = New System.Drawing.Point(574, 46)
        Me.CbxModificarSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxModificarSintomas.Name = "CbxModificarSintomas"
        Me.CbxModificarSintomas.Size = New System.Drawing.Size(251, 24)
        Me.CbxModificarSintomas.TabIndex = 13
        Me.CbxModificarSintomas.Text = "Desea modificar los sintomas?"
        Me.CbxModificarSintomas.UseVisualStyleBackColor = True
        '
        'FrmModificarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 703)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
