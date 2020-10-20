<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSintomasCsv
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtRuta = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.OfdSeleccionarCsv = New System.Windows.Forms.OpenFileDialog()
        Me.CbxHeader = New System.Windows.Forms.CheckBox()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(76, 102)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(112, 35)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtRuta
        '
        Me.TxtRuta.Location = New System.Drawing.Point(218, 106)
        Me.TxtRuta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtRuta.Name = "TxtRuta"
        Me.TxtRuta.Size = New System.Drawing.Size(517, 26)
        Me.TxtRuta.TabIndex = 1
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Enabled = False
        Me.BtnAceptar.Location = New System.Drawing.Point(169, 326)
        Me.BtnAceptar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(192, 54)
        Me.BtnAceptar.TabIndex = 2
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'OfdSeleccionarCsv
        '
        Me.OfdSeleccionarCsv.FileName = "OpenFileDialog1"
        '
        'CbxHeader
        '
        Me.CbxHeader.AutoSize = True
        Me.CbxHeader.Location = New System.Drawing.Point(76, 170)
        Me.CbxHeader.Name = "CbxHeader"
        Me.CbxHeader.Size = New System.Drawing.Size(251, 24)
        Me.CbxHeader.TabIndex = 3
        Me.CbxHeader.Text = "Mi archivo CSV tiene cabezera"
        Me.CbxHeader.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(425, 326)
        Me.BtnVolver.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(192, 54)
        Me.BtnVolver.TabIndex = 4
        Me.BtnVolver.Text = "Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmSintomasCsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 421)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.CbxHeader)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.TxtRuta)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmSintomasCsv"
        Me.Text = "FrmSintomasCsv"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents TxtRuta As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents OfdSeleccionarCsv As OpenFileDialog
    Friend WithEvents CbxHeader As CheckBox
    Friend WithEvents BtnVolver As Button
End Class
