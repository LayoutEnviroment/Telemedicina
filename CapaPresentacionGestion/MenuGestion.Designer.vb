<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestion
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
        Me.BtnEnfermedad = New System.Windows.Forms.Button()
        Me.BtnSintoma = New System.Windows.Forms.Button()
        Me.BtnCompone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnEnfermedad
        '
        Me.BtnEnfermedad.BackColor = System.Drawing.Color.White
        Me.BtnEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnfermedad.Location = New System.Drawing.Point(61, 56)
        Me.BtnEnfermedad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEnfermedad.Name = "BtnEnfermedad"
        Me.BtnEnfermedad.Size = New System.Drawing.Size(250, 51)
        Me.BtnEnfermedad.TabIndex = 0
        Me.BtnEnfermedad.Text = "Gestionar Enfermedad"
        Me.BtnEnfermedad.UseVisualStyleBackColor = False
        '
        'BtnSintoma
        '
        Me.BtnSintoma.BackColor = System.Drawing.Color.White
        Me.BtnSintoma.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSintoma.Location = New System.Drawing.Point(61, 160)
        Me.BtnSintoma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnSintoma.Name = "BtnSintoma"
        Me.BtnSintoma.Size = New System.Drawing.Size(250, 51)
        Me.BtnSintoma.TabIndex = 1
        Me.BtnSintoma.Text = "Gestionar Síntoma"
        Me.BtnSintoma.UseVisualStyleBackColor = False
        '
        'BtnCompone
        '
        Me.BtnCompone.BackColor = System.Drawing.Color.White
        Me.BtnCompone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompone.Location = New System.Drawing.Point(61, 247)
        Me.BtnCompone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCompone.Name = "BtnCompone"
        Me.BtnCompone.Size = New System.Drawing.Size(250, 92)
        Me.BtnCompone.TabIndex = 2
        Me.BtnCompone.Text = "Gestionar Sintoma de Enfermedad"
        Me.BtnCompone.UseVisualStyleBackColor = False
        '
        'MenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(376, 385)
        Me.Controls.Add(Me.BtnCompone)
        Me.Controls.Add(Me.BtnSintoma)
        Me.Controls.Add(Me.BtnEnfermedad)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MenuGestion"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEnfermedad As Button
    Friend WithEvents BtnSintoma As Button
    Friend WithEvents BtnCompone As Button
End Class
