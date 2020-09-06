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
        Me.RtbConversacion = New System.Windows.Forms.RichTextBox()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.TmrMensajesNuevos = New System.Windows.Forms.Timer(Me.components)
        Me.BbtnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RtbConversacion
        '
        Me.RtbConversacion.Location = New System.Drawing.Point(193, 48)
        Me.RtbConversacion.Name = "RtbConversacion"
        Me.RtbConversacion.ReadOnly = True
        Me.RtbConversacion.Size = New System.Drawing.Size(424, 214)
        Me.RtbConversacion.TabIndex = 0
        Me.RtbConversacion.Text = ""
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Location = New System.Drawing.Point(193, 286)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(360, 60)
        Me.RtbMensaje.TabIndex = 1
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Enabled = False
        Me.BtnEnviar.Location = New System.Drawing.Point(560, 286)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(57, 60)
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
        Me.BbtnSalir.Location = New System.Drawing.Point(13, 13)
        Me.BbtnSalir.Name = "BbtnSalir"
        Me.BbtnSalir.Size = New System.Drawing.Size(75, 23)
        Me.BbtnSalir.TabIndex = 3
        Me.BbtnSalir.Text = "Salir"
        Me.BbtnSalir.UseVisualStyleBackColor = True
        '
        'Frm_Chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(802, 482)
        Me.Controls.Add(Me.BbtnSalir)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.RtbConversacion)
        Me.Name = "Frm_Chat"
        Me.Text = "Chat"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RtbConversacion As RichTextBox
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents TmrMensajesNuevos As Timer
    Friend WithEvents BbtnSalir As Button
End Class
