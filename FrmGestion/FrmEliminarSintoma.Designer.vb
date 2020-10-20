<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarSintoma
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
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.TxtSintoma = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmbSintomas
        '
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(124, 106)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(121, 21)
        Me.CmbSintomas.TabIndex = 0
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(158, 74)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(50, 13)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Sintomas"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Location = New System.Drawing.Point(145, 219)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'TxtSintoma
        '
        Me.TxtSintoma.Enabled = False
        Me.TxtSintoma.Location = New System.Drawing.Point(124, 160)
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(121, 20)
        Me.TxtSintoma.TabIndex = 3
        '
        'FrmEliminarSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 300)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Name = "FrmEliminarSintoma"
        Me.Text = "FrmEliminarSintoma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LblSintomas As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents TxtSintoma As TextBox
End Class
