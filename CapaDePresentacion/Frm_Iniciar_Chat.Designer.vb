<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Iniciar_Chat
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
        Me.LblId = New System.Windows.Forms.Label()
        Me.TxtIdDiagnostico = New System.Windows.Forms.TextBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtPrioridad = New System.Windows.Forms.TextBox()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.LblIniciarChat = New System.Windows.Forms.Label()
        Me.BtnIniciarChat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.ForeColor = System.Drawing.Color.White
        Me.LblId.Location = New System.Drawing.Point(310, 155)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(21, 13)
        Me.LblId.TabIndex = 21
        Me.LblId.Text = "ID:"
        '
        'TxtIdDiagnostico
        '
        Me.TxtIdDiagnostico.Enabled = False
        Me.TxtIdDiagnostico.Location = New System.Drawing.Point(290, 171)
        Me.TxtIdDiagnostico.Name = "TxtIdDiagnostico"
        Me.TxtIdDiagnostico.Size = New System.Drawing.Size(72, 20)
        Me.TxtIdDiagnostico.TabIndex = 20
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(620, 282)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(153, 45)
        Me.BtnVolver.TabIndex = 19
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.Enabled = False
        Me.TxtEnfermedad.Location = New System.Drawing.Point(54, 171)
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(196, 20)
        Me.TxtEnfermedad.TabIndex = 18
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(54, 344)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(279, 21)
        Me.TxtDescripcion.TabIndex = 17
        '
        'TxtPrioridad
        '
        Me.TxtPrioridad.Enabled = False
        Me.TxtPrioridad.ForeColor = System.Drawing.Color.White
        Me.TxtPrioridad.Location = New System.Drawing.Point(54, 259)
        Me.TxtPrioridad.Name = "TxtPrioridad"
        Me.TxtPrioridad.Size = New System.Drawing.Size(285, 20)
        Me.TxtPrioridad.TabIndex = 16
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.ForeColor = System.Drawing.Color.White
        Me.LblDescripcion.Location = New System.Drawing.Point(51, 314)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 15
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.ForeColor = System.Drawing.Color.White
        Me.LblPrioridad.Location = New System.Drawing.Point(51, 243)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(51, 13)
        Me.LblPrioridad.TabIndex = 14
        Me.LblPrioridad.Text = "Prioridad:"
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.ForeColor = System.Drawing.Color.White
        Me.LblEnfermedad.Location = New System.Drawing.Point(51, 155)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(230, 13)
        Me.LblEnfermedad.TabIndex = 13
        Me.LblEnfermedad.Text = "Lo mas probable es que usted pueda padecer: "
        '
        'LblIniciarChat
        '
        Me.LblIniciarChat.AutoSize = True
        Me.LblIniciarChat.ForeColor = System.Drawing.Color.White
        Me.LblIniciarChat.Location = New System.Drawing.Point(567, 171)
        Me.LblIniciarChat.Name = "LblIniciarChat"
        Me.LblIniciarChat.Size = New System.Drawing.Size(266, 13)
        Me.LblIniciarChat.TabIndex = 12
        Me.LblIniciarChat.Text = "Si desea conversar con un profesional, haga click aqui"
        '
        'BtnIniciarChat
        '
        Me.BtnIniciarChat.Location = New System.Drawing.Point(620, 222)
        Me.BtnIniciarChat.Name = "BtnIniciarChat"
        Me.BtnIniciarChat.Size = New System.Drawing.Size(154, 47)
        Me.BtnIniciarChat.TabIndex = 11
        Me.BtnIniciarChat.Text = "Iniciar Chat"
        Me.BtnIniciarChat.UseVisualStyleBackColor = True
        '
        'Frm_Iniciar_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(915, 559)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.TxtIdDiagnostico)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.TxtEnfermedad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblEnfermedad)
        Me.Controls.Add(Me.LblIniciarChat)
        Me.Controls.Add(Me.BtnIniciarChat)
        Me.Name = "Frm_Iniciar_Chat"
        Me.Text = "Frm_Iniciar_Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblId As Label
    Friend WithEvents TxtIdDiagnostico As TextBox
    Friend WithEvents BtnVolver As Button
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtPrioridad As TextBox
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents LblIniciarChat As Label
    Friend WithEvents BtnIniciarChat As Button
End Class
