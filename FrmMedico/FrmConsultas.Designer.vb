﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultas
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
        Me.DgvConsultas = New System.Windows.Forms.DataGridView()
        Me.LblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.TxtSexo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMedicaciones = New System.Windows.Forms.Label()
        Me.LstEnfermedades = New System.Windows.Forms.ListView()
        Me.LstMedicaciones = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEnfermedad = New System.Windows.Forms.TextBox()
        Me.LstSintomas = New System.Windows.Forms.ListView()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.LblChat = New System.Windows.Forms.Label()
        Me.RtbChat = New System.Windows.Forms.RichTextBox()
        CType(Me.DgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvConsultas
        '
        Me.DgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvConsultas.Location = New System.Drawing.Point(11, 23)
        Me.DgvConsultas.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvConsultas.MultiSelect = False
        Me.DgvConsultas.Name = "DgvConsultas"
        Me.DgvConsultas.ReadOnly = True
        Me.DgvConsultas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvConsultas.RowTemplate.Height = 28
        Me.DgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvConsultas.Size = New System.Drawing.Size(207, 367)
        Me.DgvConsultas.TabIndex = 0
        '
        'LblCedula
        '
        Me.LblCedula.AutoSize = True
        Me.LblCedula.Location = New System.Drawing.Point(243, 23)
        Me.LblCedula.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCedula.Name = "LblCedula"
        Me.LblCedula.Size = New System.Drawing.Size(40, 13)
        Me.LblCedula.TabIndex = 1
        Me.LblCedula.Text = "Cedula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(414, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(518, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Edad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(610, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nombre"
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(221, 49)
        Me.TxtCedula.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(90, 20)
        Me.TxtCedula.TabIndex = 6
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(321, 49)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(90, 20)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Location = New System.Drawing.Point(417, 49)
        Me.TxtCorreo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(90, 20)
        Me.TxtCorreo.TabIndex = 8
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(509, 49)
        Me.TxtEdad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(90, 20)
        Me.TxtEdad.TabIndex = 9
        '
        'TxtSexo
        '
        Me.TxtSexo.Location = New System.Drawing.Point(602, 49)
        Me.TxtSexo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSexo.Name = "TxtSexo"
        Me.TxtSexo.Size = New System.Drawing.Size(90, 20)
        Me.TxtSexo.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 106)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Enfermedades Cronicas"
        '
        'LblMedicaciones
        '
        Me.LblMedicaciones.AutoSize = True
        Me.LblMedicaciones.Location = New System.Drawing.Point(381, 106)
        Me.LblMedicaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblMedicaciones.Name = "LblMedicaciones"
        Me.LblMedicaciones.Size = New System.Drawing.Size(73, 13)
        Me.LblMedicaciones.TabIndex = 12
        Me.LblMedicaciones.Text = "Medicaciones"
        '
        'LstEnfermedades
        '
        Me.LstEnfermedades.HideSelection = False
        Me.LstEnfermedades.Location = New System.Drawing.Point(224, 127)
        Me.LstEnfermedades.Margin = New System.Windows.Forms.Padding(2)
        Me.LstEnfermedades.Name = "LstEnfermedades"
        Me.LstEnfermedades.Size = New System.Drawing.Size(119, 118)
        Me.LstEnfermedades.TabIndex = 13
        Me.LstEnfermedades.UseCompatibleStateImageBehavior = False
        '
        'LstMedicaciones
        '
        Me.LstMedicaciones.HideSelection = False
        Me.LstMedicaciones.Location = New System.Drawing.Point(357, 127)
        Me.LstMedicaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.LstMedicaciones.Name = "LstMedicaciones"
        Me.LstMedicaciones.Size = New System.Drawing.Size(119, 118)
        Me.LstMedicaciones.TabIndex = 14
        Me.LstMedicaciones.UseCompatibleStateImageBehavior = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(546, 84)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Enfermedad Diagnosticada"
        '
        'TxtEnfermedad
        '
        Me.TxtEnfermedad.Location = New System.Drawing.Point(565, 99)
        Me.TxtEnfermedad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEnfermedad.Name = "TxtEnfermedad"
        Me.TxtEnfermedad.Size = New System.Drawing.Size(90, 20)
        Me.TxtEnfermedad.TabIndex = 16
        '
        'LstSintomas
        '
        Me.LstSintomas.HideSelection = False
        Me.LstSintomas.Location = New System.Drawing.Point(549, 146)
        Me.LstSintomas.Margin = New System.Windows.Forms.Padding(2)
        Me.LstSintomas.Name = "LstSintomas"
        Me.LstSintomas.Size = New System.Drawing.Size(119, 118)
        Me.LstSintomas.TabIndex = 18
        Me.LstSintomas.UseCompatibleStateImageBehavior = False
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(573, 125)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(50, 13)
        Me.LblSintomas.TabIndex = 17
        Me.LblSintomas.Text = "Sintomas"
        '
        'LblChat
        '
        Me.LblChat.AutoSize = True
        Me.LblChat.Location = New System.Drawing.Point(249, 274)
        Me.LblChat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblChat.Name = "LblChat"
        Me.LblChat.Size = New System.Drawing.Size(72, 13)
        Me.LblChat.TabIndex = 19
        Me.LblChat.Text = "Conversacion"
        '
        'RtbChat
        '
        Me.RtbChat.Location = New System.Drawing.Point(224, 293)
        Me.RtbChat.Name = "RtbChat"
        Me.RtbChat.Size = New System.Drawing.Size(444, 96)
        Me.RtbChat.TabIndex = 21
        Me.RtbChat.Text = ""
        '
        'FrmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 401)
        Me.Controls.Add(Me.RtbChat)
        Me.Controls.Add(Me.LblChat)
        Me.Controls.Add(Me.LstSintomas)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.TxtEnfermedad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LstMedicaciones)
        Me.Controls.Add(Me.LstEnfermedades)
        Me.Controls.Add(Me.LblMedicaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSexo)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCedula)
        Me.Controls.Add(Me.DgvConsultas)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmConsultas"
        Me.Text = "FrmConsultas"
        CType(Me.DgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvConsultas As DataGridView
    Friend WithEvents LblCedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCedula As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents TxtSexo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LblMedicaciones As Label
    Friend WithEvents LstEnfermedades As ListView
    Friend WithEvents LstMedicaciones As ListView
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEnfermedad As TextBox
    Friend WithEvents LstSintomas As ListView
    Friend WithEvents LblSintomas As Label
    Friend WithEvents LblChat As Label
    Friend WithEvents RtbChat As RichTextBox
End Class
