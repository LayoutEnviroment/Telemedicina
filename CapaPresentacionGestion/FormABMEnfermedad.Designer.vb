<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABMEnfermedad
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
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtIdEnfermedad = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtDescripcionEnfermedad = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(38, 105)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(92, 30)
        Me.LblNombre.TabIndex = 11
        Me.LblNombre.Text = "Nombre"
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(38, 15)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(35, 30)
        Me.LblId.TabIndex = 10
        Me.LblId.Text = "ID"
        '
        'TxtNombreEnfermedad
        '
        Me.TxtNombreEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreEnfermedad.Location = New System.Drawing.Point(112, 139)
        Me.TxtNombreEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombreEnfermedad.Name = "TxtNombreEnfermedad"
        Me.TxtNombreEnfermedad.Size = New System.Drawing.Size(284, 34)
        Me.TxtNombreEnfermedad.TabIndex = 9
        '
        'TxtIdEnfermedad
        '
        Me.TxtIdEnfermedad.Enabled = False
        Me.TxtIdEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdEnfermedad.Location = New System.Drawing.Point(112, 52)
        Me.TxtIdEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIdEnfermedad.Name = "TxtIdEnfermedad"
        Me.TxtIdEnfermedad.Size = New System.Drawing.Size(285, 34)
        Me.TxtIdEnfermedad.TabIndex = 8
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(250, 360)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(134, 50)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.White
        Me.BtnAceptar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(70, 354)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(142, 62)
        Me.BtnAceptar.TabIndex = 6
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(38, 186)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(125, 30)
        Me.LblDescripcion.TabIndex = 13
        Me.LblDescripcion.Text = "Descripcion"
        '
        'TxtDescripcionEnfermedad
        '
        Me.TxtDescripcionEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcionEnfermedad.Location = New System.Drawing.Point(112, 220)
        Me.TxtDescripcionEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtDescripcionEnfermedad.Name = "TxtDescripcionEnfermedad"
        Me.TxtDescripcionEnfermedad.Size = New System.Drawing.Size(284, 34)
        Me.TxtDescripcionEnfermedad.TabIndex = 12
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"BAJA", "MEDIA", "ALTA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(261, 289)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(136, 36)
        Me.CmbPrioridad.TabIndex = 14
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.Location = New System.Drawing.Point(38, 277)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(102, 30)
        Me.LblPrioridad.TabIndex = 15
        Me.LblPrioridad.Text = "Prioridad"
        '
        'FormABMEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 469)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.TxtDescripcionEnfermedad)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtNombreEnfermedad)
        Me.Controls.Add(Me.TxtIdEnfermedad)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormABMEnfermedad"
        Me.Text = "Enfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblId As Label
    Friend WithEvents TxtNombreEnfermedad As TextBox
    Friend WithEvents TxtIdEnfermedad As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents TxtDescripcionEnfermedad As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents LblPrioridad As Label
End Class
