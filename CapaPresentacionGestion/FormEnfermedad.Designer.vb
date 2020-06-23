<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEnfermedad
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
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DgvEnfermedadesCargadas = New System.Windows.Forms.DataGridView()
        Me.LblInforSeleccion = New System.Windows.Forms.Label()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvEnfermedadesCargadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.White
        Me.BtnInsertar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(36, 109)
        Me.BtnInsertar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(161, 46)
        Me.BtnInsertar.TabIndex = 0
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(36, 194)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(161, 46)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(36, 278)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(161, 46)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DgvEnfermedadesCargadas
        '
        Me.DgvEnfermedadesCargadas.BackgroundColor = System.Drawing.Color.White
        Me.DgvEnfermedadesCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEnfermedadesCargadas.Location = New System.Drawing.Point(266, 109)
        Me.DgvEnfermedadesCargadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgvEnfermedadesCargadas.Name = "DgvEnfermedadesCargadas"
        Me.DgvEnfermedadesCargadas.RowTemplate.Height = 24
        Me.DgvEnfermedadesCargadas.Size = New System.Drawing.Size(399, 415)
        Me.DgvEnfermedadesCargadas.TabIndex = 3
        '
        'LblInforSeleccion
        '
        Me.LblInforSeleccion.AutoSize = True
        Me.LblInforSeleccion.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInforSeleccion.Location = New System.Drawing.Point(230, 39)
        Me.LblInforSeleccion.Name = "LblInforSeleccion"
        Me.LblInforSeleccion.Size = New System.Drawing.Size(485, 28)
        Me.LblInforSeleccion.TabIndex = 4
        Me.LblInforSeleccion.Text = "Seleccione una enfermedad para Modificar / Eliminar :"
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.White
        Me.BtnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(36, 478)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(161, 46)
        Me.BtnVolver.TabIndex = 5
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FormEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.LblInforSeleccion)
        Me.Controls.Add(Me.DgvEnfermedadesCargadas)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormEnfermedad"
        Me.Text = "FormEnfermedad"
        CType(Me.DgvEnfermedadesCargadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DgvEnfermedadesCargadas As DataGridView
    Friend WithEvents LblInforSeleccion As Label
    Friend WithEvents BtnVolver As Button
End Class
