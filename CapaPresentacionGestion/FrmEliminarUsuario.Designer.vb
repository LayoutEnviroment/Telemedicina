<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarUsuario
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
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTipoUsuario = New System.Windows.Forms.Label()
        Me.CmbCI = New System.Windows.Forms.ComboBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.ChbPaciente = New System.Windows.Forms.CheckBox()
        Me.ChbMedico = New System.Windows.Forms.CheckBox()
        Me.ChbAdministrador = New System.Windows.Forms.CheckBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblIndicaciones2 = New System.Windows.Forms.Label()
        Me.LblIndicaciones = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Location = New System.Drawing.Point(286, 293)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 60)
        Me.BtnEliminar.TabIndex = 0
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(153, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 46)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "BAJA DE USUARIOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 173)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 293)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mail"
        '
        'LblTipoUsuario
        '
        Me.LblTipoUsuario.AutoSize = True
        Me.LblTipoUsuario.Location = New System.Drawing.Point(326, 134)
        Me.LblTipoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTipoUsuario.Name = "LblTipoUsuario"
        Me.LblTipoUsuario.Size = New System.Drawing.Size(80, 13)
        Me.LblTipoUsuario.TabIndex = 6
        Me.LblTipoUsuario.Text = "Tipo de usuario"
        Me.LblTipoUsuario.Visible = False
        '
        'CmbCI
        '
        Me.CmbCI.FormattingEnabled = True
        Me.CmbCI.Location = New System.Drawing.Point(108, 99)
        Me.CmbCI.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CmbCI.Name = "CmbCI"
        Me.CmbCI.Size = New System.Drawing.Size(108, 21)
        Me.CmbCI.TabIndex = 7
        '
        'TxtNombre
        '
        Me.TxtNombre.Enabled = False
        Me.TxtNombre.Location = New System.Drawing.Point(108, 173)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(108, 20)
        Me.TxtNombre.TabIndex = 8
        '
        'TxtApellido
        '
        Me.TxtApellido.Enabled = False
        Me.TxtApellido.Location = New System.Drawing.Point(108, 230)
        Me.TxtApellido.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(108, 20)
        Me.TxtApellido.TabIndex = 9
        '
        'TxtMail
        '
        Me.TxtMail.Enabled = False
        Me.TxtMail.Location = New System.Drawing.Point(108, 293)
        Me.TxtMail.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(108, 20)
        Me.TxtMail.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CI"
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(378, 293)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(90, 60)
        Me.BtnVolver.TabIndex = 12
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'ChbPaciente
        '
        Me.ChbPaciente.AutoSize = True
        Me.ChbPaciente.Enabled = False
        Me.ChbPaciente.Location = New System.Drawing.Point(458, 133)
        Me.ChbPaciente.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ChbPaciente.Name = "ChbPaciente"
        Me.ChbPaciente.Size = New System.Drawing.Size(68, 17)
        Me.ChbPaciente.TabIndex = 13
        Me.ChbPaciente.Text = "Paciente"
        Me.ChbPaciente.UseVisualStyleBackColor = True
        Me.ChbPaciente.Visible = False
        '
        'ChbMedico
        '
        Me.ChbMedico.AutoSize = True
        Me.ChbMedico.Enabled = False
        Me.ChbMedico.Location = New System.Drawing.Point(458, 162)
        Me.ChbMedico.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ChbMedico.Name = "ChbMedico"
        Me.ChbMedico.Size = New System.Drawing.Size(61, 17)
        Me.ChbMedico.TabIndex = 14
        Me.ChbMedico.Text = "Médico"
        Me.ChbMedico.UseVisualStyleBackColor = True
        Me.ChbMedico.Visible = False
        '
        'ChbAdministrador
        '
        Me.ChbAdministrador.AutoSize = True
        Me.ChbAdministrador.Enabled = False
        Me.ChbAdministrador.Location = New System.Drawing.Point(458, 190)
        Me.ChbAdministrador.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ChbAdministrador.Name = "ChbAdministrador"
        Me.ChbAdministrador.Size = New System.Drawing.Size(91, 17)
        Me.ChbAdministrador.TabIndex = 15
        Me.ChbAdministrador.Text = "Administrativo"
        Me.ChbAdministrador.UseVisualStyleBackColor = True
        Me.ChbAdministrador.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(474, 293)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(90, 60)
        Me.BtnCancelar.TabIndex = 16
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'LblIndicaciones2
        '
        Me.LblIndicaciones2.AutoSize = True
        Me.LblIndicaciones2.Location = New System.Drawing.Point(314, 99)
        Me.LblIndicaciones2.Name = "LblIndicaciones2"
        Me.LblIndicaciones2.Size = New System.Drawing.Size(235, 13)
        Me.LblIndicaciones2.TabIndex = 17
        Me.LblIndicaciones2.Text = "Deseleccione el rol que quiere quitarle al usuario"
        Me.LblIndicaciones2.Visible = False
        '
        'LblIndicaciones
        '
        Me.LblIndicaciones.AutoSize = True
        Me.LblIndicaciones.Location = New System.Drawing.Point(40, 72)
        Me.LblIndicaciones.Name = "LblIndicaciones"
        Me.LblIndicaciones.Size = New System.Drawing.Size(197, 13)
        Me.LblIndicaciones.TabIndex = 18
        Me.LblIndicaciones.Text = "Seleccione cédula de usuario a eliminar:"
        '
        'FrmEliminarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 365)
        Me.Controls.Add(Me.LblIndicaciones)
        Me.Controls.Add(Me.LblIndicaciones2)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.ChbAdministrador)
        Me.Controls.Add(Me.ChbMedico)
        Me.Controls.Add(Me.ChbPaciente)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.CmbCI)
        Me.Controls.Add(Me.LblTipoUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FrmEliminarUsuario"
        Me.Text = "Baja Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTipoUsuario As Label
    Friend WithEvents CmbCI As ComboBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnVolver As Button
    Friend WithEvents ChbPaciente As CheckBox
    Friend WithEvents ChbMedico As CheckBox
    Friend WithEvents ChbAdministrador As CheckBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblIndicaciones2 As Label
    Friend WithEvents LblIndicaciones As Label
End Class
