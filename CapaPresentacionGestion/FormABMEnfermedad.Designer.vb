<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormABMEnfermedad
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtNombreEnfermedad = New System.Windows.Forms.TextBox()
        Me.txtIdEnfermedad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcionEnfermedad = New System.Windows.Forms.TextBox()
        Me.cmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(34, 127)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 17)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(34, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(25, 17)
        Me.lblId.TabIndex = 10
        Me.lblId.Text = "ID:"
        '
        'txtNombreEnfermedad
        '
        Me.txtNombreEnfermedad.Location = New System.Drawing.Point(128, 127)
        Me.txtNombreEnfermedad.Name = "txtNombreEnfermedad"
        Me.txtNombreEnfermedad.Size = New System.Drawing.Size(253, 22)
        Me.txtNombreEnfermedad.TabIndex = 9
        '
        'txtIdEnfermedad
        '
        Me.txtIdEnfermedad.Enabled = False
        Me.txtIdEnfermedad.Location = New System.Drawing.Point(127, 87)
        Me.txtIdEnfermedad.Name = "txtIdEnfermedad"
        Me.txtIdEnfermedad.Size = New System.Drawing.Size(254, 22)
        Me.txtIdEnfermedad.TabIndex = 8
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(222, 293)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(119, 40)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(69, 293)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(119, 40)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(34, 165)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 17)
        Me.lblDescripcion.TabIndex = 13
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'txtDescripcionEnfermedad
        '
        Me.txtDescripcionEnfermedad.Location = New System.Drawing.Point(128, 165)
        Me.txtDescripcionEnfermedad.Name = "txtDescripcionEnfermedad"
        Me.txtDescripcionEnfermedad.Size = New System.Drawing.Size(253, 22)
        Me.txtDescripcionEnfermedad.TabIndex = 12
        '
        'cmbPrioridad
        '
        Me.cmbPrioridad.FormattingEnabled = True
        Me.cmbPrioridad.Items.AddRange(New Object() {"LOW", "MEDIUM", "HIGH"})
        Me.cmbPrioridad.Location = New System.Drawing.Point(260, 215)
        Me.cmbPrioridad.Name = "cmbPrioridad"
        Me.cmbPrioridad.Size = New System.Drawing.Size(121, 24)
        Me.cmbPrioridad.TabIndex = 14
        '
        'FormABMEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 375)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbPrioridad)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcionEnfermedad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtNombreEnfermedad)
        Me.Controls.Add(Me.txtIdEnfermedad)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "FormABMEnfermedad"
        Me.Text = "FormABMEnfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblId As Label
    Friend WithEvents txtNombreEnfermedad As TextBox
    Friend WithEvents txtIdEnfermedad As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcionEnfermedad As TextBox
    Friend WithEvents cmbPrioridad As ComboBox
End Class
