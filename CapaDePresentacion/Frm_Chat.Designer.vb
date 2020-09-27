<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Chat
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.TmrMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.BbtnSalir = New System.Windows.Forms.Button()
        Me.WbbConversacion = New System.Windows.Forms.WebBrowser()
        Me.TxtMensaje = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(754, 435)
        Me.BtnEnviar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(97, 40)
        Me.BtnEnviar.TabIndex = 2
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'TmrMensajesNuevos
        '
        Me.TmrMensajesNuevos.Enabled = True
        Me.TmrMensajesNuevos.Interval = 1000
        '
        'BbtnSalir
        '
        Me.BbtnSalir.Location = New System.Drawing.Point(20, 20)
        Me.BbtnSalir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BbtnSalir.Name = "BbtnSalir"
        Me.BbtnSalir.Size = New System.Drawing.Size(112, 35)
        Me.BbtnSalir.TabIndex = 3
        Me.BbtnSalir.Text = "Salir"
        Me.BbtnSalir.UseVisualStyleBackColor = True
        '
        'WbbConversacion
        '
        Me.WbbConversacion.Location = New System.Drawing.Point(215, 20)
        Me.WbbConversacion.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WbbConversacion.Name = "WbbConversacion"
        Me.WbbConversacion.Size = New System.Drawing.Size(636, 400)
        Me.WbbConversacion.TabIndex = 4
        '
        'TxtMensaje
        '
        Me.TxtMensaje.Location = New System.Drawing.Point(215, 442)
        Me.TxtMensaje.Name = "TxtMensaje"
        Me.TxtMensaje.Size = New System.Drawing.Size(503, 26)
        Me.TxtMensaje.TabIndex = 5
        '
        'Frm_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(989, 559)
        Me.Controls.Add(Me.TxtMensaje)
        Me.Controls.Add(Me.WbbConversacion)
        Me.Controls.Add(Me.BbtnSalir)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Chat"
        Me.Text = "Chat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TmrMensajesNuevos As Timer
    Friend WithEvents BbtnSalir As Button
    Friend WithEvents WbbConversacion As WebBrowser
    Friend WithEvents TxtMensaje As TextBox
End Class
