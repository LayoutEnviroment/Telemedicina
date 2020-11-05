<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevoSintoma
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblDisponibilidad = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(84, 131)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(265, 35)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.Text = " "
        '
        'LblDisponibilidad
        '
        Me.LblDisponibilidad.AutoSize = True
        Me.LblDisponibilidad.BackColor = System.Drawing.Color.Transparent
        Me.LblDisponibilidad.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisponibilidad.Location = New System.Drawing.Point(139, 192)
        Me.LblDisponibilidad.Name = "LblDisponibilidad"
        Me.LblDisponibilidad.Size = New System.Drawing.Size(0, 16)
        Me.LblDisponibilidad.TabIndex = 2
        Me.LblDisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctAceptar
        '
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(174, 246)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(93, 87)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 6
        Me.PctAceptar.TabStop = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(381, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 9
        Me.PctSalir.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Libre Franklin", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(111, 11)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(207, 33)
        Me.LblDescripcion.TabIndex = 23
        Me.LblDescripcion.Text = "Nuevo Síntoma"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Escriba el nombre del nuevo síntoma"
        '
        'FrmNuevoSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CapaPresentacionGestion.My.Resources.Resources.MenuHistoria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(444, 345)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblDisponibilidad)
        Me.Controls.Add(Me.TxtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmNuevoSintoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblDisponibilidad As Label
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents Label1 As Label
End Class
