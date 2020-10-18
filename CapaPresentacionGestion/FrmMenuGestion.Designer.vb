<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuGestion
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
        Me.MenuGestor = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarCSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SintomaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnfermedadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblBienvenida = New System.Windows.Forms.Label()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuGestor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuGestor
        '
        Me.MenuGestor.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuGestor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuGestor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem, Me.SintomaToolStripMenuItem, Me.ImportarCSVToolStripMenuItem, Me.EnfermedadToolStripMenuItem1})
        Me.MenuGestor.Location = New System.Drawing.Point(0, 0)
        Me.MenuGestor.Name = "MenuGestor"
        Me.MenuGestor.Padding = New System.Windows.Forms.Padding(6, 3, 0, 3)
        Me.MenuGestor.Size = New System.Drawing.Size(186, 503)
        Me.MenuGestor.TabIndex = 3
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.MedicoToolStripMenuItem, Me.AdministrativoToolStripMenuItem, Me.UsuarioToolStripMenuItem1})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.MedicoToolStripMenuItem.Text = "Medico"
        '
        'AdministrativoToolStripMenuItem
        '
        Me.AdministrativoToolStripMenuItem.Name = "AdministrativoToolStripMenuItem"
        Me.AdministrativoToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.AdministrativoToolStripMenuItem.Text = "Administrativo"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'SintomaToolStripMenuItem
        '
        Me.SintomaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem1, Me.ModificarToolStripMenuItem1, Me.EliminarToolStripMenuItem1})
        Me.SintomaToolStripMenuItem.Name = "SintomaToolStripMenuItem"
        Me.SintomaToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.SintomaToolStripMenuItem.Text = "Sintoma"
        '
        'NuevoToolStripMenuItem1
        '
        Me.NuevoToolStripMenuItem1.Name = "NuevoToolStripMenuItem1"
        Me.NuevoToolStripMenuItem1.Size = New System.Drawing.Size(171, 30)
        Me.NuevoToolStripMenuItem1.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem1
        '
        Me.ModificarToolStripMenuItem1.Name = "ModificarToolStripMenuItem1"
        Me.ModificarToolStripMenuItem1.Size = New System.Drawing.Size(171, 30)
        Me.ModificarToolStripMenuItem1.Text = "Modificar"
        '
        'EliminarToolStripMenuItem1
        '
        Me.EliminarToolStripMenuItem1.Name = "EliminarToolStripMenuItem1"
        Me.EliminarToolStripMenuItem1.Size = New System.Drawing.Size(171, 30)
        Me.EliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'ImportarCSVToolStripMenuItem
        '
        Me.ImportarCSVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SintomaToolStripMenuItem1})
        Me.ImportarCSVToolStripMenuItem.Name = "ImportarCSVToolStripMenuItem"
        Me.ImportarCSVToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.ImportarCSVToolStripMenuItem.Text = "Importar CSV"
        '
        'SintomaToolStripMenuItem1
        '
        Me.SintomaToolStripMenuItem1.Name = "SintomaToolStripMenuItem1"
        Me.SintomaToolStripMenuItem1.Size = New System.Drawing.Size(162, 30)
        Me.SintomaToolStripMenuItem1.Text = "Sintoma"
        '
        'EnfermedadToolStripMenuItem1
        '
        Me.EnfermedadToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem2, Me.ModificarToolStripMenuItem2, Me.EliminarToolStripMenuItem2})
        Me.EnfermedadToolStripMenuItem1.Name = "EnfermedadToolStripMenuItem1"
        Me.EnfermedadToolStripMenuItem1.Size = New System.Drawing.Size(173, 29)
        Me.EnfermedadToolStripMenuItem1.Text = "Enfermedad"
        '
        'NuevoToolStripMenuItem2
        '
        Me.NuevoToolStripMenuItem2.Name = "NuevoToolStripMenuItem2"
        Me.NuevoToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.NuevoToolStripMenuItem2.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem2
        '
        Me.ModificarToolStripMenuItem2.Name = "ModificarToolStripMenuItem2"
        Me.ModificarToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.ModificarToolStripMenuItem2.Text = "Modificar"
        '
        'EliminarToolStripMenuItem2
        '
        Me.EliminarToolStripMenuItem2.Name = "EliminarToolStripMenuItem2"
        Me.EliminarToolStripMenuItem2.Size = New System.Drawing.Size(171, 30)
        Me.EliminarToolStripMenuItem2.Text = "Eliminar"
        '
        'LblBienvenida
        '
        Me.LblBienvenida.AutoSize = True
        Me.LblBienvenida.Location = New System.Drawing.Point(388, 60)
        Me.LblBienvenida.Name = "LblBienvenida"
        Me.LblBienvenida.Size = New System.Drawing.Size(0, 20)
        Me.LblBienvenida.TabIndex = 4
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(252, 30)
        Me.UsuarioToolStripMenuItem1.Text = "usuario"
        '
        'FrmMenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 503)
        Me.Controls.Add(Me.LblBienvenida)
        Me.Controls.Add(Me.MenuGestor)
        Me.MainMenuStrip = Me.MenuGestor
        Me.Name = "FrmMenuGestion"
        Me.Text = "Menu"
        Me.MenuGestor.ResumeLayout(False)
        Me.MenuGestor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents PacienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrativoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblBienvenida As Label
    Friend WithEvents EnfermedadToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As ToolStripMenuItem
End Class
