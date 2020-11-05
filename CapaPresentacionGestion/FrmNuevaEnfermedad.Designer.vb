<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaEnfermedad
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.LstSintomasSeleccionados = New System.Windows.Forms.ListView()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblDisponible = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctCancelar = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(48, 134)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(171, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(48, 206)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.MaxLength = 500
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(171, 105)
        Me.TxtDescripcion.TabIndex = 1
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(48, 345)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(171, 27)
        Me.CmbPrioridad.TabIndex = 2
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(45, 114)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(59, 16)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombre"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSintomas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSintomas.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(303, 132)
        Me.CmbSintomas.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(171, 27)
        Me.CmbSintomas.TabIndex = 4
        '
        'LstSintomasSeleccionados
        '
        Me.LstSintomasSeleccionados.Font = New System.Drawing.Font("Libre Franklin", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomasSeleccionados.HideSelection = False
        Me.LstSintomasSeleccionados.Location = New System.Drawing.Point(303, 177)
        Me.LstSintomasSeleccionados.Margin = New System.Windows.Forms.Padding(2)
        Me.LstSintomasSeleccionados.Name = "LstSintomasSeleccionados"
        Me.LstSintomasSeleccionados.Size = New System.Drawing.Size(171, 191)
        Me.LstSintomasSeleccionados.TabIndex = 5
        Me.LstSintomasSeleccionados.UseCompatibleStateImageBehavior = False
        Me.LstSintomasSeleccionados.View = System.Windows.Forms.View.Tile
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.Location = New System.Drawing.Point(41, 187)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(81, 16)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.BackColor = System.Drawing.Color.Transparent
        Me.LblPrioridad.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrioridad.Location = New System.Drawing.Point(45, 327)
        Me.LblPrioridad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(64, 16)
        Me.LblPrioridad.TabIndex = 7
        Me.LblPrioridad.Text = "Prioridad"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.BackColor = System.Drawing.Color.Transparent
        Me.LblSintomas.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSintomas.Location = New System.Drawing.Point(300, 114)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(66, 16)
        Me.LblSintomas.TabIndex = 8
        Me.LblSintomas.Text = "Sintomas"
        '
        'LblDisponible
        '
        Me.LblDisponible.AutoSize = True
        Me.LblDisponible.BackColor = System.Drawing.Color.Transparent
        Me.LblDisponible.Font = New System.Drawing.Font("Libre Franklin", 9.749999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDisponible.Location = New System.Drawing.Point(45, 425)
        Me.LblDisponible.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDisponible.Name = "LblDisponible"
        Me.LblDisponible.Size = New System.Drawing.Size(0, 16)
        Me.LblDisponible.TabIndex = 12
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(209, 425)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(93, 87)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 15
        Me.PctAceptar.TabStop = False
        '
        'PctCancelar
        '
        Me.PctCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctCancelar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Cancelar1
        Me.PctCancelar.Location = New System.Drawing.Point(381, 425)
        Me.PctCancelar.Name = "PctCancelar"
        Me.PctCancelar.Size = New System.Drawing.Size(93, 87)
        Me.PctCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctCancelar.TabIndex = 16
        Me.PctCancelar.TabStop = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(453, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(58, 55)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 17
        Me.PctSalir.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Libre Franklin", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(128, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 33)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nueva Enfermedad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmNuevaEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.CapaPresentacionGestion.My.Resources.Resources.MenuHistoria
        Me.ClientSize = New System.Drawing.Size(516, 540)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PctSalir)
        Me.Controls.Add(Me.PctCancelar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblDisponible)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LstSintomasSeleccionados)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmNuevaEnfermedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "-"
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LstSintomasSeleccionados As ListView
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblDisponible As Label
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctCancelar As PictureBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents Label1 As Label
End Class
