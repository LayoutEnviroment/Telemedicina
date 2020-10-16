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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDisponibilidad = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.BtnReactivar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(110, 108)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(238, 26)
        Me.TxtNombre.TabIndex = 0
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(118, 65)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(65, 20)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblDisponibilidad
        '
        Me.LblDisponibilidad.AutoSize = True
        Me.LblDisponibilidad.Location = New System.Drawing.Point(435, 117)
        Me.LblDisponibilidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDisponibilidad.Name = "LblDisponibilidad"
        Me.LblDisponibilidad.Size = New System.Drawing.Size(0, 20)
        Me.LblDisponibilidad.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(110, 269)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(207, 58)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(646, 367)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(137, 53)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnReactivar
        '
        Me.BtnReactivar.Enabled = False
        Me.BtnReactivar.Location = New System.Drawing.Point(369, 269)
        Me.BtnReactivar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnReactivar.Name = "BtnReactivar"
        Me.BtnReactivar.Size = New System.Drawing.Size(207, 58)
        Me.BtnReactivar.TabIndex = 5
        Me.BtnReactivar.Text = "Reactivar"
        Me.BtnReactivar.UseVisualStyleBackColor = True
        '
        'FrmNuevoSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 434)
        Me.Controls.Add(Me.BtnReactivar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblDisponibilidad)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtNombre)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmNuevoSintoma"
        Me.Text = "FrmNuevoSintoma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblDisponibilidad As Label
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents BtnReactivar As Button
End Class
