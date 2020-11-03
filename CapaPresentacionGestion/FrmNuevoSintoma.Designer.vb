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
        Me.TxtNombre.Location = New System.Drawing.Point(73, 70)
        Me.TxtNombre.MaxLength = 50
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(160, 20)
        Me.TxtNombre.TabIndex = 0
        Me.TxtNombre.Text = " "
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(79, 42)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre"
        '
        'LblDisponibilidad
        '
        Me.LblDisponibilidad.AutoSize = True
        Me.LblDisponibilidad.Location = New System.Drawing.Point(290, 76)
        Me.LblDisponibilidad.Name = "LblDisponibilidad"
        Me.LblDisponibilidad.Size = New System.Drawing.Size(0, 13)
        Me.LblDisponibilidad.TabIndex = 2
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(73, 175)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(138, 38)
        Me.BtnAceptar.TabIndex = 3
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(431, 239)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(91, 34)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'BtnReactivar
        '
        Me.BtnReactivar.Enabled = False
        Me.BtnReactivar.Location = New System.Drawing.Point(246, 175)
        Me.BtnReactivar.Name = "BtnReactivar"
        Me.BtnReactivar.Size = New System.Drawing.Size(138, 38)
        Me.BtnReactivar.TabIndex = 5
        Me.BtnReactivar.Text = "Reactivar"
        Me.BtnReactivar.UseVisualStyleBackColor = True
        '
        'FrmNuevoSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 282)
        Me.Controls.Add(Me.BtnReactivar)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.LblDisponibilidad)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtNombre)
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
