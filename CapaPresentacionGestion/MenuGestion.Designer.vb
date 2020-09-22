<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGestion
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
        Me.BtnEnfermedad = New System.Windows.Forms.Button()
        Me.BtnSintoma = New System.Windows.Forms.Button()
        Me.BtnCompone = New System.Windows.Forms.Button()
        Me.MenuGestor = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnfermedadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGestor.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEnfermedad
        '
        Me.BtnEnfermedad.BackColor = System.Drawing.Color.White
        Me.BtnEnfermedad.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnfermedad.Location = New System.Drawing.Point(12, 252)
        Me.BtnEnfermedad.Name = "BtnEnfermedad"
        Me.BtnEnfermedad.Size = New System.Drawing.Size(222, 41)
        Me.BtnEnfermedad.TabIndex = 0
        Me.BtnEnfermedad.Text = "Gestionar Enfermedad"
        Me.BtnEnfermedad.UseVisualStyleBackColor = False
        '
        'BtnSintoma
        '
        Me.BtnSintoma.BackColor = System.Drawing.Color.White
        Me.BtnSintoma.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSintoma.Location = New System.Drawing.Point(305, 252)
        Me.BtnSintoma.Name = "BtnSintoma"
        Me.BtnSintoma.Size = New System.Drawing.Size(222, 41)
        Me.BtnSintoma.TabIndex = 1
        Me.BtnSintoma.Text = "Gestionar Síntoma"
        Me.BtnSintoma.UseVisualStyleBackColor = False
        '
        'BtnCompone
        '
        Me.BtnCompone.BackColor = System.Drawing.Color.White
        Me.BtnCompone.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompone.Location = New System.Drawing.Point(595, 235)
        Me.BtnCompone.Name = "BtnCompone"
        Me.BtnCompone.Size = New System.Drawing.Size(222, 74)
        Me.BtnCompone.TabIndex = 2
        Me.BtnCompone.Text = "Gestionar Sintoma de Enfermedad"
        Me.BtnCompone.UseVisualStyleBackColor = False
        '
        'MenuGestor
        '
        Me.MenuGestor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuGestor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.SintomaToolStripMenuItem, Me.ImportarCSVToolStripMenuItem})
        Me.MenuGestor.Location = New System.Drawing.Point(0, 0)
        Me.MenuGestor.Name = "MenuGestor"
        Me.MenuGestor.Size = New System.Drawing.Size(852, 28)
        Me.MenuGestor.TabIndex = 3
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(71, 24)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.MedicoToolStripMenuItem, Me.AdministrativoToolStripMenuItem})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SintomaToolStripMenuItem
        '
        Me.SintomaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.SintomaToolStripMenuItem.Name = "SintomaToolStripMenuItem"
        Me.SintomaToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SintomaToolStripMenuItem.Text = "Sintoma"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(148, 26)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ImportarCSVToolStripMenuItem
        '
        Me.ImportarCSVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SintomaToolStripMenuItem1, Me.EnfermedadToolStripMenuItem})
        Me.ImportarCSVToolStripMenuItem.Name = "ImportarCSVToolStripMenuItem"
        Me.ImportarCSVToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ImportarCSVToolStripMenuItem.Text = "Importar CSV"
        '
        'SintomaToolStripMenuItem1
        '
        Me.SintomaToolStripMenuItem1.Name = "SintomaToolStripMenuItem1"
        Me.SintomaToolStripMenuItem1.Size = New System.Drawing.Size(165, 26)
        Me.SintomaToolStripMenuItem1.Text = "Sintoma"
        '
        'EnfermedadToolStripMenuItem
        '
        Me.EnfermedadToolStripMenuItem.Name = "EnfermedadToolStripMenuItem"
        Me.EnfermedadToolStripMenuItem.Size = New System.Drawing.Size(165, 26)
        Me.EnfermedadToolStripMenuItem.Text = "Enfermedad"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.MedicoToolStripMenuItem.Text = "Medico"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.AdministrativoToolStripMenuItem.Text = "Administrativo"
        '
        'MenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 402)
        Me.Controls.Add(Me.BtnCompone)
        Me.Controls.Add(Me.BtnSintoma)
        Me.Controls.Add(Me.BtnEnfermedad)
        Me.Controls.Add(Me.MenuGestor)
        Me.MainMenuStrip = Me.MenuGestor
        Me.Name = "MenuGestion"
        Me.Text = "Menu"
        Me.MenuGestor.ResumeLayout(False)
        Me.MenuGestor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnEnfermedad As Button
    Friend WithEvents BtnSintoma As Button
    Friend WithEvents BtnCompone As Button
    Friend WithEvents MenuGestor As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SintomaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImportarCSVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SintomaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnfermedadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrativoToolStripMenuItem As ToolStripMenuItem
End Class
