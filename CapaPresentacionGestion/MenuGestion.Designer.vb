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
        Me.btnEnfermedad = New System.Windows.Forms.Button()
        Me.btnSintoma = New System.Windows.Forms.Button()
        Me.btnCompone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEnfermedad
        '
        Me.btnEnfermedad.Location = New System.Drawing.Point(49, 116)
        Me.btnEnfermedad.Name = "btnEnfermedad"
        Me.btnEnfermedad.Size = New System.Drawing.Size(222, 41)
        Me.btnEnfermedad.TabIndex = 0
        Me.btnEnfermedad.Text = "Gestionar Enfermedad"
        Me.btnEnfermedad.UseVisualStyleBackColor = True
        '
        'btnSintoma
        '
        Me.btnSintoma.Location = New System.Drawing.Point(49, 173)
        Me.btnSintoma.Name = "btnSintoma"
        Me.btnSintoma.Size = New System.Drawing.Size(222, 41)
        Me.btnSintoma.TabIndex = 1
        Me.btnSintoma.Text = "Gestionar Síntoma"
        Me.btnSintoma.UseVisualStyleBackColor = True
        '
        'btnCompone
        '
        Me.btnCompone.Location = New System.Drawing.Point(49, 232)
        Me.btnCompone.Name = "btnCompone"
        Me.btnCompone.Size = New System.Drawing.Size(222, 52)
        Me.btnCompone.TabIndex = 2
        Me.btnCompone.Text = "Gestionar Sintoma de Enfermedad"
        Me.btnCompone.UseVisualStyleBackColor = True
        '
        'MenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 397)
        Me.Controls.Add(Me.btnCompone)
        Me.Controls.Add(Me.btnSintoma)
        Me.Controls.Add(Me.btnEnfermedad)
        Me.Name = "MenuGestion"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEnfermedad As Button
    Friend WithEvents btnSintoma As Button
    Friend WithEvents btnCompone As Button
End Class
