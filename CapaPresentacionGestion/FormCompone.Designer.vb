<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompone
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
        Me.CmbEnfermedad = New System.Windows.Forms.ComboBox()
        Me.LblSeleccionEnfermedad = New System.Windows.Forms.Label()
        Me.DgvSintoma = New System.Windows.Forms.DataGridView()
        Me.cbx = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LblTitulo = New System.Windows.Forms.Label()
        CType(Me.DgvSintoma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEnfermedad
        '
        Me.CmbEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEnfermedad.FormattingEnabled = True
        Me.CmbEnfermedad.Location = New System.Drawing.Point(42, 101)
        Me.CmbEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CmbEnfermedad.Name = "CmbEnfermedad"
        Me.CmbEnfermedad.Size = New System.Drawing.Size(173, 36)
        Me.CmbEnfermedad.TabIndex = 0
        '
        'LblSeleccionEnfermedad
        '
        Me.LblSeleccionEnfermedad.AutoSize = True
        Me.LblSeleccionEnfermedad.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeleccionEnfermedad.Location = New System.Drawing.Point(12, 48)
        Me.LblSeleccionEnfermedad.Name = "LblSeleccionEnfermedad"
        Me.LblSeleccionEnfermedad.Size = New System.Drawing.Size(241, 30)
        Me.LblSeleccionEnfermedad.TabIndex = 1
        Me.LblSeleccionEnfermedad.Text = "Seleccione enfermedad"
        '
        'DgvSintoma
        '
        Me.DgvSintoma.AllowUserToAddRows = False
        Me.DgvSintoma.AllowUserToDeleteRows = False
        Me.DgvSintoma.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintoma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintoma.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cbx})
        Me.DgvSintoma.Location = New System.Drawing.Point(279, 101)
        Me.DgvSintoma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgvSintoma.Name = "DgvSintoma"
        Me.DgvSintoma.RowTemplate.Height = 24
        Me.DgvSintoma.Size = New System.Drawing.Size(402, 420)
        Me.DgvSintoma.TabIndex = 2
        '
        'cbx
        '
        Me.cbx.HeaderText = "Sel."
        Me.cbx.Name = "cbx"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.White
        Me.BtnAceptar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(714, 101)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(137, 48)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(714, 181)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(137, 48)
        Me.BtnCancelar.TabIndex = 4
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.White
        Me.BtnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(714, 474)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(137, 48)
        Me.BtnVolver.TabIndex = 5
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(375, 48)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(210, 30)
        Me.LblTitulo.TabIndex = 6
        Me.LblTitulo.Text = "Seleccione Sintomas"
        '
        'FormCompone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblTitulo)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.DgvSintoma)
        Me.Controls.Add(Me.LblSeleccionEnfermedad)
        Me.Controls.Add(Me.CmbEnfermedad)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormCompone"
        Me.Text = "FormCompone"
        CType(Me.DgvSintoma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbEnfermedad As ComboBox
    Friend WithEvents LblSeleccionEnfermedad As Label
    Friend WithEvents DgvSintoma As DataGridView
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents cbx As DataGridViewCheckBoxColumn
    Friend WithEvents LblTitulo As Label
End Class
