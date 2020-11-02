<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Consultas
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
        Me.DgvDiagnosticos = New System.Windows.Forms.DataGridView()
        Me.PnlInformacion = New System.Windows.Forms.Panel()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.RtbChat = New System.Windows.Forms.RichTextBox()
        Me.RtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.LblPrioridadEnfermedad = New System.Windows.Forms.Label()
        Me.DgvSintomas = New System.Windows.Forms.DataGridView()
        Me.LblNombreEnfermedad = New System.Windows.Forms.Label()
        Me.LblConversacion = New System.Windows.Forms.Label()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblMedico = New System.Windows.Forms.Label()
        Me.LblIndicaciones = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInformacion.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDiagnosticos
        '
        Me.DgvDiagnosticos.AllowUserToAddRows = False
        Me.DgvDiagnosticos.AllowUserToDeleteRows = False
        Me.DgvDiagnosticos.AllowUserToResizeColumns = False
        Me.DgvDiagnosticos.AllowUserToResizeRows = False
        Me.DgvDiagnosticos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDiagnosticos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDiagnosticos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgvDiagnosticos.Location = New System.Drawing.Point(13, 36)
        Me.DgvDiagnosticos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvDiagnosticos.MultiSelect = False
        Me.DgvDiagnosticos.Name = "DgvDiagnosticos"
        Me.DgvDiagnosticos.ReadOnly = True
        Me.DgvDiagnosticos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDiagnosticos.Size = New System.Drawing.Size(423, 919)
        Me.DgvDiagnosticos.TabIndex = 0
        '
        'PnlInformacion
        '
        Me.PnlInformacion.Controls.Add(Me.LblPrioridad)
        Me.PnlInformacion.Controls.Add(Me.LblNombre)
        Me.PnlInformacion.Controls.Add(Me.RtbChat)
        Me.PnlInformacion.Controls.Add(Me.RtbDescripcion)
        Me.PnlInformacion.Controls.Add(Me.LblPrioridadEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.DgvSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblNombreEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblConversacion)
        Me.PnlInformacion.Controls.Add(Me.LblEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblMedico)
        Me.PnlInformacion.Location = New System.Drawing.Point(444, 14)
        Me.PnlInformacion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.Size = New System.Drawing.Size(1250, 1109)
        Me.PnlInformacion.TabIndex = 1
        Me.PnlInformacion.Visible = False
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.Location = New System.Drawing.Point(758, 71)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(75, 20)
        Me.LblPrioridad.TabIndex = 11
        Me.LblPrioridad.Text = "Prioridad:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(502, 71)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 10
        Me.LblNombre.Text = "Nombre:"
        '
        'RtbChat
        '
        Me.RtbChat.Location = New System.Drawing.Point(74, 508)
        Me.RtbChat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RtbChat.Name = "RtbChat"
        Me.RtbChat.ReadOnly = True
        Me.RtbChat.Size = New System.Drawing.Size(1147, 595)
        Me.RtbChat.TabIndex = 9
        Me.RtbChat.Text = ""
        '
        'RtbDescripcion
        '
        Me.RtbDescripcion.Location = New System.Drawing.Point(410, 211)
        Me.RtbDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RtbDescripcion.Name = "RtbDescripcion"
        Me.RtbDescripcion.ReadOnly = True
        Me.RtbDescripcion.Size = New System.Drawing.Size(583, 164)
        Me.RtbDescripcion.TabIndex = 8
        Me.RtbDescripcion.Text = ""
        '
        'LblPrioridadEnfermedad
        '
        Me.LblPrioridadEnfermedad.AutoSize = True
        Me.LblPrioridadEnfermedad.Location = New System.Drawing.Point(758, 112)
        Me.LblPrioridadEnfermedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrioridadEnfermedad.Name = "LblPrioridadEnfermedad"
        Me.LblPrioridadEnfermedad.Size = New System.Drawing.Size(0, 20)
        Me.LblPrioridadEnfermedad.TabIndex = 7
        '
        'DgvSintomas
        '
        Me.DgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintomas.Location = New System.Drawing.Point(74, 71)
        Me.DgvSintomas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.ReadOnly = True
        Me.DgvSintomas.Size = New System.Drawing.Size(270, 317)
        Me.DgvSintomas.TabIndex = 6
        '
        'LblNombreEnfermedad
        '
        Me.LblNombreEnfermedad.AutoSize = True
        Me.LblNombreEnfermedad.Location = New System.Drawing.Point(573, 112)
        Me.LblNombreEnfermedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombreEnfermedad.Name = "LblNombreEnfermedad"
        Me.LblNombreEnfermedad.Size = New System.Drawing.Size(0, 20)
        Me.LblNombreEnfermedad.TabIndex = 5
        '
        'LblConversacion
        '
        Me.LblConversacion.AutoSize = True
        Me.LblConversacion.Location = New System.Drawing.Point(69, 462)
        Me.LblConversacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblConversacion.Name = "LblConversacion"
        Me.LblConversacion.Size = New System.Drawing.Size(105, 20)
        Me.LblConversacion.TabIndex = 4
        Me.LblConversacion.Text = "Conversacion"
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.Location = New System.Drawing.Point(406, 22)
        Me.LblEnfermedad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(203, 20)
        Me.LblEnfermedad.TabIndex = 2
        Me.LblEnfermedad.Text = "Enfermedad Diagnosticada"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(122, 22)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(169, 20)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Sintomas Consultados"
        '
        'LblMedico
        '
        Me.LblMedico.AutoSize = True
        Me.LblMedico.Location = New System.Drawing.Point(680, 462)
        Me.LblMedico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMedico.Name = "LblMedico"
        Me.LblMedico.Size = New System.Drawing.Size(117, 20)
        Me.LblMedico.TabIndex = 0
        Me.LblMedico.Text = "Medico a cargo"
        '
        'LblIndicaciones
        '
        Me.LblIndicaciones.AutoSize = True
        Me.LblIndicaciones.Location = New System.Drawing.Point(51, 9)
        Me.LblIndicaciones.Name = "LblIndicaciones"
        Me.LblIndicaciones.Size = New System.Drawing.Size(338, 20)
        Me.LblIndicaciones.TabIndex = 2
        Me.LblIndicaciones.Text = "Seleccione un diagnostico para ver los detalles"
        Me.LblIndicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(153, 995)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(92, 43)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Frm_Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1524, 1050)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.LblIndicaciones)
        Me.Controls.Add(Me.PnlInformacion)
        Me.Controls.Add(Me.DgvDiagnosticos)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Consultas"
        Me.Text = "Consultas"
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlInformacion.PerformLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvDiagnosticos As DataGridView
    Friend WithEvents PnlInformacion As Panel
    Friend WithEvents LblPrioridadEnfermedad As Label
    Friend WithEvents DgvSintomas As DataGridView
    Friend WithEvents LblNombreEnfermedad As Label
    Friend WithEvents LblConversacion As Label
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblMedico As Label
    Friend WithEvents RtbDescripcion As RichTextBox
    Friend WithEvents RtbChat As RichTextBox
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblIndicaciones As Label
    Friend WithEvents BtnSalir As Button
End Class
