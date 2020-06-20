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
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.EnfermedadesCargadas = New System.Windows.Forms.DataGridView()
        Me.LblInforSeleccion = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.EnfermedadesCargadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(46, 105)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(143, 37)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(46, 162)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(143, 37)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(46, 226)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(143, 37)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'EnfermedadesCargadas
        '
        Me.EnfermedadesCargadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EnfermedadesCargadas.Location = New System.Drawing.Point(236, 87)
        Me.EnfermedadesCargadas.Name = "EnfermedadesCargadas"
        Me.EnfermedadesCargadas.RowTemplate.Height = 24
        Me.EnfermedadesCargadas.Size = New System.Drawing.Size(355, 332)
        Me.EnfermedadesCargadas.TabIndex = 3
        '
        'LblInforSeleccion
        '
        Me.LblInforSeleccion.AutoSize = True
        Me.LblInforSeleccion.Location = New System.Drawing.Point(233, 34)
        Me.LblInforSeleccion.Name = "LblInforSeleccion"
        Me.LblInforSeleccion.Size = New System.Drawing.Size(349, 17)
        Me.LblInforSeleccion.TabIndex = 4
        Me.LblInforSeleccion.Text = "Seleccione una enfermedad para Modificar / Eliminar :"
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(46, 382)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(138, 37)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FormEnfermedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.LblInforSeleccion)
        Me.Controls.Add(Me.EnfermedadesCargadas)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Name = "FormEnfermedad"
        Me.Text = "FormEnfermedad"
        CType(Me.EnfermedadesCargadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents EnfermedadesCargadas As DataGridView
    Friend WithEvents LblInforSeleccion As Label
    Friend WithEvents btnVolver As Button
End Class
