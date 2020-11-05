<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarSintoma
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
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtSintoma = New System.Windows.Forms.TextBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbSintomas
        '
        Me.CmbSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbSintomas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbSintomas.BackColor = System.Drawing.SystemColors.Control
        Me.CmbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSintomas.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(86, 115)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(265, 24)
        Me.CmbSintomas.TabIndex = 0
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(109, 96)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(214, 16)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Seleccione el síntoma a modificar"
        '
        'TxtSintoma
        '
        Me.TxtSintoma.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSintoma.Location = New System.Drawing.Point(86, 163)
        Me.TxtSintoma.MaxLength = 50
        Me.TxtSintoma.Multiline = True
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(265, 35)
        Me.TxtSintoma.TabIndex = 2
        Me.TxtSintoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(381, 4)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 10
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Libre Franklin", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(92, 14)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(244, 33)
        Me.LblDescripcion.TabIndex = 24
        Me.LblDescripcion.Text = "Modificar Síntoma"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(168, 246)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(93, 87)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 25
        Me.PctAceptar.TabStop = False
        '
        'FrmModificarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CapaPresentacionGestion.My.Resources.Resources.MenuHistoria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(444, 345)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbSintomas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtSintoma As TextBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents PctAceptar As PictureBox
End Class
