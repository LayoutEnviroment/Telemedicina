<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABMSintoma
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
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtIdSintoma = New System.Windows.Forms.TextBox()
        Me.TxtNombreSintoma = New System.Windows.Forms.TextBox()
        Me.LblId = New System.Windows.Forms.Label()
        Me.LlblNombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.White
        Me.BtnAceptar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(81, 253)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(151, 64)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.White
        Me.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancelar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(251, 260)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(134, 50)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'TxtIdSintoma
        '
        Me.TxtIdSintoma.Enabled = False
        Me.TxtIdSintoma.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdSintoma.Location = New System.Drawing.Point(100, 72)
        Me.TxtIdSintoma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtIdSintoma.Name = "TxtIdSintoma"
        Me.TxtIdSintoma.Size = New System.Drawing.Size(285, 34)
        Me.TxtIdSintoma.TabIndex = 2
        '
        'TxtNombreSintoma
        '
        Me.TxtNombreSintoma.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreSintoma.Location = New System.Drawing.Point(100, 163)
        Me.TxtNombreSintoma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtNombreSintoma.Name = "TxtNombreSintoma"
        Me.TxtNombreSintoma.Size = New System.Drawing.Size(284, 34)
        Me.TxtNombreSintoma.TabIndex = 3
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblId.Location = New System.Drawing.Point(37, 37)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(34, 30)
        Me.LblId.TabIndex = 4
        Me.LblId.Text = "ID"
        '
        'LlblNombre
        '
        Me.LlblNombre.AutoSize = True
        Me.LlblNombre.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LlblNombre.Location = New System.Drawing.Point(37, 129)
        Me.LlblNombre.Name = "LlblNombre"
        Me.LlblNombre.Size = New System.Drawing.Size(94, 30)
        Me.LlblNombre.TabIndex = 5
        Me.LlblNombre.Text = "Nombre"
        '
        'FormABMSintoma
        '
        Me.AcceptButton = Me.BtnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CancelButton = Me.BtnCancelar
        Me.ClientSize = New System.Drawing.Size(472, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.LlblNombre)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtNombreSintoma)
        Me.Controls.Add(Me.TxtIdSintoma)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormABMSintoma"
        Me.Text = "Sintomas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TxtIdSintoma As TextBox
    Friend WithEvents TxtNombreSintoma As TextBox
    Friend WithEvents LblId As Label
    Friend WithEvents LlblNombre As Label
End Class
