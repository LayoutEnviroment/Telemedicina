﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Me.LblMedico = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblEnfermedad = New System.Windows.Forms.Label()
        Me.BtnAtiende = New System.Windows.Forms.Label()
        Me.LblConversacion = New System.Windows.Forms.Label()
        Me.LblNombreEnfermedad = New System.Windows.Forms.Label()
        Me.DgvSintomas = New System.Windows.Forms.DataGridView()
        Me.LblPrioridadEnfermedad = New System.Windows.Forms.Label()
        Me.RtbDescripcion = New System.Windows.Forms.RichTextBox()
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlInformacion.SuspendLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDiagnosticos
        '
        Me.DgvDiagnosticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDiagnosticos.Location = New System.Drawing.Point(41, 12)
        Me.DgvDiagnosticos.Name = "DgvDiagnosticos"
        Me.DgvDiagnosticos.Size = New System.Drawing.Size(404, 721)
        Me.DgvDiagnosticos.TabIndex = 0
        '
        'PnlInformacion
        '
        Me.PnlInformacion.Controls.Add(Me.RtbDescripcion)
        Me.PnlInformacion.Controls.Add(Me.LblPrioridadEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.DgvSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblNombreEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblConversacion)
        Me.PnlInformacion.Controls.Add(Me.BtnAtiende)
        Me.PnlInformacion.Controls.Add(Me.LblEnfermedad)
        Me.PnlInformacion.Controls.Add(Me.LblSintomas)
        Me.PnlInformacion.Controls.Add(Me.LblMedico)
        Me.PnlInformacion.Location = New System.Drawing.Point(468, 12)
        Me.PnlInformacion.Name = "PnlInformacion"
        Me.PnlInformacion.Size = New System.Drawing.Size(721, 721)
        Me.PnlInformacion.TabIndex = 1
        Me.PnlInformacion.Visible = False
        '
        'LblMedico
        '
        Me.LblMedico.AutoSize = True
        Me.LblMedico.Location = New System.Drawing.Point(326, 264)
        Me.LblMedico.Name = "LblMedico"
        Me.LblMedico.Size = New System.Drawing.Size(81, 13)
        Me.LblMedico.TabIndex = 0
        Me.LblMedico.Text = "Medico a cargo"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(58, 239)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(111, 13)
        Me.LblSintomas.TabIndex = 1
        Me.LblSintomas.Text = "Sintomas Consultados"
        '
        'LblEnfermedad
        '
        Me.LblEnfermedad.AutoSize = True
        Me.LblEnfermedad.Location = New System.Drawing.Point(296, 24)
        Me.LblEnfermedad.Name = "LblEnfermedad"
        Me.LblEnfermedad.Size = New System.Drawing.Size(135, 13)
        Me.LblEnfermedad.TabIndex = 2
        Me.LblEnfermedad.Text = "Enfermedad Diagnosticada"
        '
        'BtnAtiende
        '
        Me.BtnAtiende.AutoSize = True
        Me.BtnAtiende.Location = New System.Drawing.Point(414, 239)
        Me.BtnAtiende.Name = "BtnAtiende"
        Me.BtnAtiende.Size = New System.Drawing.Size(251, 13)
        Me.BtnAtiende.TabIndex = 3
        Me.BtnAtiende.Text = "La informacion sobre su conversacion aparece aqui"
        '
        'LblConversacion
        '
        Me.LblConversacion.AutoSize = True
        Me.LblConversacion.Location = New System.Drawing.Point(335, 401)
        Me.LblConversacion.Name = "LblConversacion"
        Me.LblConversacion.Size = New System.Drawing.Size(72, 13)
        Me.LblConversacion.TabIndex = 4
        Me.LblConversacion.Text = "Conversacion"
        '
        'LblNombreEnfermedad
        '
        Me.LblNombreEnfermedad.AutoSize = True
        Me.LblNombreEnfermedad.Location = New System.Drawing.Point(115, 106)
        Me.LblNombreEnfermedad.Name = "LblNombreEnfermedad"
        Me.LblNombreEnfermedad.Size = New System.Drawing.Size(39, 13)
        Me.LblNombreEnfermedad.TabIndex = 5
        Me.LblNombreEnfermedad.Text = "Label1"
        '
        'DgvSintomas
        '
        Me.DgvSintomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintomas.Location = New System.Drawing.Point(27, 280)
        Me.DgvSintomas.Name = "DgvSintomas"
        Me.DgvSintomas.Size = New System.Drawing.Size(180, 321)
        Me.DgvSintomas.TabIndex = 6
        '
        'LblPrioridadEnfermedad
        '
        Me.LblPrioridadEnfermedad.AutoSize = True
        Me.LblPrioridadEnfermedad.Location = New System.Drawing.Point(348, 106)
        Me.LblPrioridadEnfermedad.Name = "LblPrioridadEnfermedad"
        Me.LblPrioridadEnfermedad.Size = New System.Drawing.Size(39, 13)
        Me.LblPrioridadEnfermedad.TabIndex = 7
        Me.LblPrioridadEnfermedad.Text = "Label1"
        '
        'RtbDescripcion
        '
        Me.RtbDescripcion.Location = New System.Drawing.Point(465, 72)
        Me.RtbDescripcion.Name = "RtbDescripcion"
        Me.RtbDescripcion.Size = New System.Drawing.Size(200, 96)
        Me.RtbDescripcion.TabIndex = 8
        Me.RtbDescripcion.Text = ""
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 745)
        Me.Controls.Add(Me.PnlInformacion)
        Me.Controls.Add(Me.DgvDiagnosticos)
        Me.Name = "Consultas"
        Me.Text = "Consultas"
        CType(Me.DgvDiagnosticos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlInformacion.ResumeLayout(False)
        Me.PnlInformacion.PerformLayout()
        CType(Me.DgvSintomas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvDiagnosticos As DataGridView
    Friend WithEvents PnlInformacion As Panel
    Friend WithEvents LblPrioridadEnfermedad As Label
    Friend WithEvents DgvSintomas As DataGridView
    Friend WithEvents LblNombreEnfermedad As Label
    Friend WithEvents LblConversacion As Label
    Friend WithEvents BtnAtiende As Label
    Friend WithEvents LblEnfermedad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblMedico As Label
    Friend WithEvents RtbDescripcion As RichTextBox
End Class
