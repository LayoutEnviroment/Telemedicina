<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSintomasCsv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.OfdSeleccionarCsv = New System.Windows.Forms.OpenFileDialog()
        Me.CbxHeader = New System.Windows.Forms.CheckBox()
        Me.PnlBarra = New System.Windows.Forms.Panel()
        Me.PctSalir = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.PctAceptar = New System.Windows.Forms.PictureBox()
        Me.PnlBarra.SuspendLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(44, 127)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtRuta
        '
        Me.TxtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRuta.Location = New System.Drawing.Point(206, 127)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(517, 35)
        Me.TxtRuta.TabIndex = 1
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(478, 172)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(192, 54)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'OfdSeleccionarCsv
        '
        Me.OfdSeleccionarCsv.FileName = "OpenFileDialog1"
        '
        'CbxHeader
        '
        Me.CbxHeader.AutoSize = True
        Me.CbxHeader.Location = New System.Drawing.Point(44, 188)
        Me.CbxHeader.Name = "CbxHeader"
        Me.CbxHeader.Size = New System.Drawing.Size(251, 24)
        Me.CbxHeader.TabIndex = 3
        Me.CbxHeader.Text = "Mi archivo CSV tiene cabezera"
        Me.CbxHeader.UseVisualStyleBackColor = True
        '
        'PnlBarra
        '
        Me.PnlBarra.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PnlBarra.Controls.Add(Me.PctSalir)
        Me.PnlBarra.Controls.Add(Me.PictureBox1)
        Me.PnlBarra.Controls.Add(Me.LblDescripcion)
        Me.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlBarra.Location = New System.Drawing.Point(0, 0)
        Me.PnlBarra.Name = "PnlBarra"
        Me.PnlBarra.Size = New System.Drawing.Size(800, 76)
        Me.PnlBarra.TabIndex = 29
        '
        'PctSalir
        '
        Me.PctSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PctSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctSalir.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PctSalir.Location = New System.Drawing.Point(719, 0)
        Me.PctSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctSalir.Name = "PctSalir"
        Me.PctSalir.Size = New System.Drawing.Size(81, 76)
        Me.PctSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctSalir.TabIndex = 24
        Me.PctSalir.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Salir1
        Me.PictureBox1.Location = New System.Drawing.Point(832, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.LblDescripcion.Location = New System.Drawing.Point(237, 9)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(324, 47)
        Me.LblDescripcion.TabIndex = 23
        Me.LblDescripcion.Text = "Ingreso por CSV"
        Me.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PctAceptar
        '
        Me.PctAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PctAceptar.Enabled = False
        Me.PctAceptar.Image = Global.CapaPresentacionGestion.My.Resources.Resources.Aceptar1
        Me.PctAceptar.Location = New System.Drawing.Point(343, 273)
        Me.PctAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PctAceptar.Name = "PctAceptar"
        Me.PctAceptar.Size = New System.Drawing.Size(140, 134)
        Me.PctAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PctAceptar.TabIndex = 30
        Me.PctAceptar.TabStop = False
        '
        'FrmSintomasCsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.PctAceptar)
        Me.Controls.Add(Me.PnlBarra)
        Me.Controls.Add(Me.CbxHeader)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSintomasCsv"
        Me.Text = "FrmSintomasCsv"
        Me.PnlBarra.ResumeLayout(False)
        Me.PnlBarra.PerformLayout()
        CType(Me.PctSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctAceptar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtRuta As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents OfdSeleccionarCsv As OpenFileDialog
    Friend WithEvents CbxHeader As CheckBox
    Friend WithEvents PnlBarra As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents PctSalir As PictureBox
    Friend WithEvents PctAceptar As PictureBox
End Class
