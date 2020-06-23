<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSintoma
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.DgvSintomasCargados = New System.Windows.Forms.DataGridView()
        Me.BtnVolver = New System.Windows.Forms.Button()
        CType(Me.DgvSintomasCargados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.White
        Me.BtnInsertar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Location = New System.Drawing.Point(42, 89)
        Me.BtnInsertar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(134, 45)
        Me.BtnInsertar.TabIndex = 0
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.White
        Me.BtnModificar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.Location = New System.Drawing.Point(42, 163)
        Me.BtnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(134, 45)
        Me.BtnModificar.TabIndex = 1
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.White
        Me.BtnEliminar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(42, 236)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(134, 45)
        Me.BtnEliminar.TabIndex = 2
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'DgvSintomasCargados
        '
        Me.DgvSintomasCargados.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomasCargados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintomasCargados.Location = New System.Drawing.Point(252, 89)
        Me.DgvSintomasCargados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DgvSintomasCargados.Name = "DgvSintomasCargados"
        Me.DgvSintomasCargados.RowTemplate.Height = 24
        Me.DgvSintomasCargados.Size = New System.Drawing.Size(270, 499)
        Me.DgvSintomasCargados.TabIndex = 3
        '
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.White
        Me.BtnVolver.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Location = New System.Drawing.Point(32, 542)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(134, 46)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FormSintoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(618, 639)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.DgvSintomasCargados)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormSintoma"
        Me.Text = "Gestor de Sintomas"
        CType(Me.DgvSintomasCargados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents DgvSintomasCargados As DataGridView
    Friend WithEvents BtnVolver As Button
End Class
