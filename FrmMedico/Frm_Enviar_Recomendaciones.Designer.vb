<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Enviar_Recomendaciones
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
        Me.LblAsunto = New System.Windows.Forms.Label()
        Me.CmbAcciones = New System.Windows.Forms.ComboBox()
        Me.CmbSobre = New System.Windows.Forms.ComboBox()
        Me.LblAccion = New System.Windows.Forms.Label()
        Me.LblObjetivo = New System.Windows.Forms.Label()
        Me.LblTexto = New System.Windows.Forms.Label()
        Me.RtbMensaje = New System.Windows.Forms.RichTextBox()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.CmbItem = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LblAsunto
        '
        Me.LblAsunto.AutoSize = True
        Me.LblAsunto.Location = New System.Drawing.Point(84, 25)
        Me.LblAsunto.Name = "LblAsunto"
        Me.LblAsunto.Size = New System.Drawing.Size(40, 13)
        Me.LblAsunto.TabIndex = 0
        Me.LblAsunto.Text = "Asunto"
        '
        'CmbAcciones
        '
        Me.CmbAcciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbAcciones.FormattingEnabled = True
        Me.CmbAcciones.Items.AddRange(New Object() {"Agregar", "Eliminar", "Modificar"})
        Me.CmbAcciones.Location = New System.Drawing.Point(159, 73)
        Me.CmbAcciones.Name = "CmbAcciones"
        Me.CmbAcciones.Size = New System.Drawing.Size(121, 21)
        Me.CmbAcciones.TabIndex = 1
        '
        'CmbSobre
        '
        Me.CmbSobre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSobre.Enabled = False
        Me.CmbSobre.FormattingEnabled = True
        Me.CmbSobre.Items.AddRange(New Object() {"Sintoma", "Enfermedad"})
        Me.CmbSobre.Location = New System.Drawing.Point(406, 73)
        Me.CmbSobre.Name = "CmbSobre"
        Me.CmbSobre.Size = New System.Drawing.Size(121, 21)
        Me.CmbSobre.TabIndex = 2
        '
        'LblAccion
        '
        Me.LblAccion.AutoSize = True
        Me.LblAccion.Location = New System.Drawing.Point(203, 54)
        Me.LblAccion.Name = "LblAccion"
        Me.LblAccion.Size = New System.Drawing.Size(40, 13)
        Me.LblAccion.TabIndex = 3
        Me.LblAccion.Text = "Acción"
        '
        'LblObjetivo
        '
        Me.LblObjetivo.AutoSize = True
        Me.LblObjetivo.Location = New System.Drawing.Point(444, 57)
        Me.LblObjetivo.Name = "LblObjetivo"
        Me.LblObjetivo.Size = New System.Drawing.Size(35, 13)
        Me.LblObjetivo.TabIndex = 4
        Me.LblObjetivo.Text = "Sobre"
        '
        'LblTexto
        '
        Me.LblTexto.AutoSize = True
        Me.LblTexto.Location = New System.Drawing.Point(317, 76)
        Me.LblTexto.Name = "LblTexto"
        Me.LblTexto.Size = New System.Drawing.Size(39, 13)
        Me.LblTexto.TabIndex = 5
        Me.LblTexto.Text = "El / La"
        '
        'RtbMensaje
        '
        Me.RtbMensaje.Location = New System.Drawing.Point(87, 137)
        Me.RtbMensaje.Name = "RtbMensaje"
        Me.RtbMensaje.Size = New System.Drawing.Size(631, 96)
        Me.RtbMensaje.TabIndex = 6
        Me.RtbMensaje.Text = ""
        '
        'BtnEnviar
        '
        Me.BtnEnviar.Location = New System.Drawing.Point(643, 281)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEnviar.TabIndex = 7
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'CmbItem
        '
        Me.CmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbItem.Enabled = False
        Me.CmbItem.FormattingEnabled = True
        Me.CmbItem.Location = New System.Drawing.Point(571, 73)
        Me.CmbItem.Name = "CmbItem"
        Me.CmbItem.Size = New System.Drawing.Size(121, 21)
        Me.CmbItem.TabIndex = 8
        Me.CmbItem.Visible = False
        '
        'Frm_Enviar_Recomendaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 351)
        Me.Controls.Add(Me.CmbItem)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.RtbMensaje)
        Me.Controls.Add(Me.LblTexto)
        Me.Controls.Add(Me.LblObjetivo)
        Me.Controls.Add(Me.LblAccion)
        Me.Controls.Add(Me.CmbSobre)
        Me.Controls.Add(Me.CmbAcciones)
        Me.Controls.Add(Me.LblAsunto)
        Me.Name = "Frm_Enviar_Recomendaciones"
        Me.Text = "Frm_Enviar_Recomendaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAsunto As Label
    Friend WithEvents CmbAcciones As ComboBox
    Friend WithEvents CmbSobre As ComboBox
    Friend WithEvents LblAccion As Label
    Friend WithEvents LblObjetivo As Label
    Friend WithEvents LblTexto As Label
    Friend WithEvents RtbMensaje As RichTextBox
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents CmbItem As ComboBox
End Class
