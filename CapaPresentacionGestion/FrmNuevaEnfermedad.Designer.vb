<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmNuevaEnfermedad
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
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.CmbPrioridad = New System.Windows.Forms.ComboBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.CmbSintomas = New System.Windows.Forms.ComboBox()
        Me.LstSintomasSeleccionados = New System.Windows.Forms.ListView()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.LblPrioridad = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.BtnCrear = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.LblDisponible = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(78, 39)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(137, 20)
        Me.TxtNombre.TabIndex = 0
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(78, 105)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(137, 18)
        Me.TxtDescripcion.TabIndex = 1
        '
        'CmbPrioridad
        '
        Me.CmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPrioridad.FormattingEnabled = True
        Me.CmbPrioridad.Items.AddRange(New Object() {"ALTA", "MEDIA", "BAJA"})
        Me.CmbPrioridad.Location = New System.Drawing.Point(78, 248)
        Me.CmbPrioridad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbPrioridad.Name = "CmbPrioridad"
        Me.CmbPrioridad.Size = New System.Drawing.Size(137, 21)
        Me.CmbPrioridad.TabIndex = 2
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(19, 17)
        Me.LblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 3
        Me.LblNombre.Text = "Nombre"
        '
        'CmbSintomas
        '
        Me.CmbSintomas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CmbSintomas.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbSintomas.FormattingEnabled = True
        Me.CmbSintomas.Location = New System.Drawing.Point(254, 38)
        Me.CmbSintomas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CmbSintomas.Name = "CmbSintomas"
        Me.CmbSintomas.Size = New System.Drawing.Size(130, 21)
        Me.CmbSintomas.TabIndex = 4
        '
        'LstSintomasSeleccionados
        '
        Me.LstSintomasSeleccionados.HideSelection = False
        Me.LstSintomasSeleccionados.Location = New System.Drawing.Point(254, 76)
        Me.LstSintomasSeleccionados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstSintomasSeleccionados.Name = "LstSintomasSeleccionados"
        Me.LstSintomasSeleccionados.Size = New System.Drawing.Size(130, 191)
        Me.LstSintomasSeleccionados.TabIndex = 5
        Me.LstSintomasSeleccionados.UseCompatibleStateImageBehavior = False
        Me.LstSintomasSeleccionados.View = System.Windows.Forms.View.List
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(15, 90)
        Me.LblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.LblDescripcion.TabIndex = 6
        Me.LblDescripcion.Text = "Descripcion"
        '
        'LblPrioridad
        '
        Me.LblPrioridad.AutoSize = True
        Me.LblPrioridad.Location = New System.Drawing.Point(15, 216)
        Me.LblPrioridad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPrioridad.Name = "LblPrioridad"
        Me.LblPrioridad.Size = New System.Drawing.Size(48, 13)
        Me.LblPrioridad.TabIndex = 7
        Me.LblPrioridad.Text = "Prioridad"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(291, 17)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(50, 13)
        Me.LblSintomas.TabIndex = 8
        Me.LblSintomas.Text = "Sintomas"
        '
        'BtnCrear
        '
        Me.BtnCrear.Enabled = False
        Me.BtnCrear.Location = New System.Drawing.Point(461, 29)
        Me.BtnCrear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnCrear.Name = "BtnCrear"
        Me.BtnCrear.Size = New System.Drawing.Size(87, 27)
        Me.BtnCrear.TabIndex = 9
        Me.BtnCrear.Text = "Crear"
        Me.BtnCrear.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(461, 90)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(87, 32)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(461, 154)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(87, 27)
        Me.BtnVolver.TabIndex = 11
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'LblDisponible
        '
        Me.LblDisponible.AutoSize = True
        Me.LblDisponible.Location = New System.Drawing.Point(103, 16)
        Me.LblDisponible.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblDisponible.Name = "LblDisponible"
        Me.LblDisponible.Size = New System.Drawing.Size(0, 13)
        Me.LblDisponible.TabIndex = 12
        '
        'FrmNuevaEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 318)
        Me.Controls.Add(Me.LblDisponible)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCrear)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.LblPrioridad)
        Me.Controls.Add(Me.LblDescripcion)
        Me.Controls.Add(Me.LstSintomasSeleccionados)
        Me.Controls.Add(Me.CmbSintomas)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.CmbPrioridad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtNombre)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmNuevaEnfermedad"
        Me.Text = "FrmNuevaEnfermedad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents CmbPrioridad As ComboBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents CmbSintomas As ComboBox
    Friend WithEvents LstSintomasSeleccionados As ListView
    Friend WithEvents LblDescripcion As Label
    Friend WithEvents LblPrioridad As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents BtnCrear As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents LblDisponible As Label
End Class
