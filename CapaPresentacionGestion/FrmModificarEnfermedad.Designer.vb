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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModificarEnfermedad))
        Me.CmbEnfermedades = New System.Windows.Forms.ComboBox()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.PctCancelar = New System.Windows.Forms.PictureBox()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PctAgregarSintoma = New System.Windows.Forms.PictureBox()
        Me.PctEliminarSintoma = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChbModificarSintomas = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBarra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAgregarSintoma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctEliminarSintoma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEnfermedades
        '
        Me.CmbEnfermedades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEnfermedades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEnfermedades.FormattingEnabled = True
        Me.CmbEnfermedades.Location = New System.Drawing.Point(34, 142)
        Me.CmbEnfermedades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbEnfermedades.Name = "CmbEnfermedades"
        Me.CmbEnfermedades.Size = New System.Drawing.Size(715, 32)
        Me.CmbEnfermedades.TabIndex = 0
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.BackColor = System.Drawing.Color.Transparent
        Me.LblEnfermedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEnfermedad.Location = New System.Drawing.Point(226, 112)
        Me.LblEnfermedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(360, 25)
        Me.LblEnfermedad.TabIndex = 1
        Me.LblEnfermedad.Text = "Seleccione la Enfermedades a modificar"
        '
        'PctCancelar
        '
        Me.PctCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctCancelar.Enabled = False
        Me.PctCancelar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Cancelar1
        Me.PctCancelar.Location = New System.Drawing.Point(612, 691)
        Me.PctCancelar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctCancelar.Name = "PctCancelar"
        Me.PctCancelar.Size = New System.Drawing.Size(140, 134)
        Me.PctCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctCancelar.TabIndex = 24
        Me.PctCancelar.TabStop = False
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(302, 691)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 23
        Me.PctAceptar.TabStop = False
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(694, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(80, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 22
        Me.PctSalir.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(176, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 47)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Modificar Enfermedad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.Label1)
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Controls.Add(Me.PictureBox1)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(774, 76)
        Me.PnlBarra.TabIndex = 28
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PictureBox1.Location = New System.Drawing.Point(833, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PctAgregarSintoma
        '
        Me.PctAgregarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctAgregarSintoma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAgregarSintoma.Enabled = False
        Me.PctAgregarSintoma.Image = Global.CapaPresentacionGestion.My.Resources.Resources.AddFondoClaro
        Me.PctAgregarSintoma.Location = New System.Drawing.Point(680, 298)
        Me.PctAgregarSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAgregarSintoma.Name = "PctAgregarSintoma"
        Me.PctAgregarSintoma.Size = New System.Drawing.Size(40, 37)
        Me.PctAgregarSintoma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAgregarSintoma.TabIndex = 40
        Me.PctAgregarSintoma.TabStop = False
        '
        'PctEliminarSintoma
        '
        Me.PctEliminarSintoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctEliminarSintoma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctEliminarSintoma.Enabled = False
        Me.PctEliminarSintoma.Image = Global.CapaPresentacionGestion.My.Resources.Resources.DelCircular
        Me.PctEliminarSintoma.Location = New System.Drawing.Point(680, 358)
        Me.PctEliminarSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctEliminarSintoma.Name = "PctEliminarSintoma"
        Me.PctEliminarSintoma.Size = New System.Drawing.Size(40, 35)
        Me.PctEliminarSintoma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctEliminarSintoma.TabIndex = 39
        Me.PctEliminarSintoma.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(478, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 25)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Sintomas"
        '
        'ChbModificarSintomas
        '
        Me.ChbModificarSintomas.AutoSize = True
        Me.ChbModificarSintomas.Enabled = False
        Me.ChbModificarSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChbModificarSintomas.Location = New System.Drawing.Point(388, 218)
        Me.ChbModificarSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChbModificarSintomas.Name = "ChbModificarSintomas"
        Me.ChbModificarSintomas.Size = New System.Drawing.Size(293, 24)
        Me.ChbModificarSintomas.TabIndex = 34
        Me.ChbModificarSintomas.Text = "Habilitar modificación de sintomas"
        Me.ChbModificarSintomas.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 572)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Prioridad"
        '
        'TxtNombre
        '
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(56, 261)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(238, 23)
        Me.TxtNombre.TabIndex = 29
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Descripcion"
        '
        'LstSintomas
        '
        Me.LstSintomas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstSintomas.Enabled = False
        Me.LstSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(388, 353)
        Me.LstSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(284, 285)
        Me.LstSintomas.TabIndex = 30
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        Me.LstSintomas.View = System.Windows.Forms.View.List
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Nombre"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescripcion.Location = New System.Drawing.Point(60, 353)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDescripcion.MaxLength = 500
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(238, 197)
        Me.TxtDescripcion.TabIndex = 31
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.Enabled = False
        Me.CmbPrioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(60, 601)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(240, 32)
        Me.CmbPrioridad.TabIndex = 32
        '
        'CmbSintomas
        '
        Me.CmbSintomas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSintomas.Enabled = False
        Me.CmbSintomas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(388, 298)
        Me.CmbSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(282, 32)
        Me.CmbSintomas.TabIndex = 33
        '
        'FrmModificarEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 954)
        Me.Controls.Add(Me.PctAgregarSintoma)
        Me.Controls.Add(Me.PctEliminarSintoma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChbModificarSintomas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LstSintomas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.PctCancelar)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.LblEnfermedad)
        Me.Controls.Add(Me.CmbEnfermedades)
        Me.Controls.Add(Me.PnlBarra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmModificarEnfermedad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Enfermedad"
        CType(Me.PctCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAgregarSintoma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctEliminarSintoma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedades As ComboBox
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents PctCancelar As PictureBox
    Friend WithEvents PctAceptar As PictureBox
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PctAgregarSintoma As PictureBox
    Friend WithEvents PctEliminarSintoma As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChbModificarSintomas As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents CmbSintomas As ComboBox
End Class
