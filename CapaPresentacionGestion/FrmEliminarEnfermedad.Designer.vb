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
        Me.TxtPrioridad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEnfermedades
        '
        Me.CmbEnfermedades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CmbEnfermedades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbEnfermedades.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEnfermedades.FormattingEnabled = True
        Me.CmbEnfermedades.Location = New System.Drawing.Point(41, 134)
        Me.CmbEnfermedades.Name = "CmbEnfermedades"
        Me.CmbEnfermedades.Size = New System.Drawing.Size(198, 27)
        Me.CmbEnfermedades.TabIndex = 0
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.Enabled = False
        Me.TxtPrioridad.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrioridad.Location = New System.Drawing.Point(41, 346)
        Me.TxtPrioridad.Multiline = True
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.Size = New System.Drawing.Size(198, 27)
        Me.TxtPrioridad.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Libre Franklin", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(127, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 33)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Eliminar Enfermedad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(451, 6)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 26
        Me.PctSalir.TabStop = False
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(215, 441)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(93, 87)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 25
        Me.PctAceptar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 114)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Sintomas"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.LblPrioridad.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.Location = New System.Drawing.Point(38, 327)
        Me.LblPrioridad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(64, 16)
        Me.LblPrioridad.TabIndex = 35
        Me.LblPrioridad.Text = "Prioridad"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(38, 187)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(81, 16)
        Me.LblDescripcion.TabIndex = 34
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LstSintomas
        '
        Me.LstSintomas.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(300, 134)
        Me.LstSintomas.Margin = New System.Windows.Forms.Padding(2)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(170, 239)
        Me.LstSintomas.TabIndex = 33
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        Me.LstSintomas.View = System.Windows.Forms.View.Tile
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 115)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nombre"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(41, 205)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.MaxLength = 500
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(198, 105)
        Me.TxtDescripcion.TabIndex = 29
        '
        'FrmEliminarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CapaPresentacionGestion.My.Resources.Resources.MenuHistoria
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(516, 540)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LstSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.TxtPrioridad)
        Me.Controls.Add(Me.CmbEnfermedades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarEnfermedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedades As ComboBox
    Friend WithEvents TxtPrioridad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescripcion As TextBox
End Class
