<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarEnfermedad
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtPrioridad = New System.Windows.Forms.TextBox()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmbEnfermedades
        '
        Me.CmbEnfermedades.FormattingEnabled = True
        Me.CmbEnfermedades.Location = New System.Drawing.Point(59, 66)
        Me.CmbEnfermedades.Name = "CmbEnfermedades"
        Me.CmbEnfermedades.Size = New System.Drawing.Size(121, 21)
        Me.CmbEnfermedades.TabIndex = 0
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(89, 27)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(64, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Enfermedad"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(48, 134)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(145, 20)
        Me.TxtDescripcion.TabIndex = 2
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.Location = New System.Drawing.Point(48, 175)
        Me.TxtPrioridad.Multiline = True
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.Size = New System.Drawing.Size(145, 20)
        Me.TxtPrioridad.TabIndex = 3
        '
        'LstSintomas
        '
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(230, 66)
        Me.LstSintomas.MultiSelect = False
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(121, 178)
        Me.LstSintomas.TabIndex = 5
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        Me.LstSintomas.View = System.Windows.Forms.View.List
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(408, 90)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(89, 37)
        Me.BtnEliminar.TabIndex = 6
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(408, 141)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(89, 37)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(258, 27)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(50, 13)
        Me.LblSintomas.TabIndex = 8
        Me.LblSintomas.Text = "Sintomas"
        '
        'FrmEliminarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 257)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LstSintomas)
        Me.Controls.Add(Me.TxtPrioridad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbEnfermedades)
        Me.Name = "FrmEliminarEnfermedad"
        Me.Text = "FrmEliminarEnfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedades As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtPrioridad As TextBox
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents LblSintomas As Label
End Class
