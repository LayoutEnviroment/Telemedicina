<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentanaPrincipal2
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.TxtSintoma = New System.Windows.Forms.TextBox()
        Me.SintomaSistema = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Lst = New System.Windows.Forms.ListView()
        Me.DgvOpciones = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.SintomaSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblSaludo
        '
        Me.LblSaludo.AutoSize = True
        Me.LblSaludo.Location = New System.Drawing.Point(20, 39)
        Me.LblSaludo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSaludo.Name = "LblSaludo"
        Me.LblSaludo.Size = New System.Drawing.Size(151, 20)
        Me.LblSaludo.TabIndex = 2
        Me.LblSaludo.Text = "Buen día, username"
        '
        'LblSintomas
        '
        Me.LblSintomas.AutoSize = True
        Me.LblSintomas.Location = New System.Drawing.Point(20, 74)
        Me.LblSintomas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblSintomas.Name = "LblSintomas"
        Me.LblSintomas.Size = New System.Drawing.Size(187, 20)
        Me.LblSintomas.TabIndex = 4
        Me.LblSintomas.Text = "Cuentenos, ¿que siente?"
        '
        'TxtSintoma
        '
        Me.TxtSintoma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtSintoma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtSintoma.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TxtSintoma.Location = New System.Drawing.Point(24, 132)
        Me.TxtSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(281, 26)
        Me.TxtSintoma.TabIndex = 3
        Me.TxtSintoma.Text = "Ej: Fiebre"
        Me.TxtSintoma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SintomaSistema
        '
        Me.SintomaSistema.AllowDrop = True
        Me.SintomaSistema.AllowUserToDeleteRows = False
        Me.SintomaSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SintomaSistema.Location = New System.Drawing.Point(24, 200)
        Me.SintomaSistema.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SintomaSistema.Name = "SintomaSistema"
        Me.SintomaSistema.ReadOnly = True
        Me.SintomaSistema.Size = New System.Drawing.Size(179, 366)
        Me.SintomaSistema.TabIndex = 6
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(341, 504)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(169, 50)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Realizar Diagnostico"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(228, 332)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(85, 42)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Lst
        '
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.Lst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.Lst.HideSelection = False
        Me.Lst.Location = New System.Drawing.Point(341, 200)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(169, 270)
        Me.Lst.TabIndex = 11
        Me.Lst.UseCompatibleStateImageBehavior = False
        Me.Lst.View = System.Windows.Forms.View.List
        '
        'DgvOpciones
        '
        Me.DgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOpciones.Location = New System.Drawing.Point(585, 190)
        Me.DgvOpciones.Name = "DgvOpciones"
        Me.DgvOpciones.RowTemplate.Height = 28
        Me.DgvOpciones.Size = New System.Drawing.Size(310, 364)
        Me.DgvOpciones.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(407, 55)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(283, 28)
        Me.ComboBox1.TabIndex = 13
        '
        'VentanaPrincipal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 589)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DgvOpciones)
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.SintomaSistema)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Name = "VentanaPrincipal2"
        Me.Text = "VentanaPrincipal2"
        CType(Me.SintomaSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaludo As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents TxtSintoma As TextBox
    Friend WithEvents SintomaSistema As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Lst As ListView
    Friend WithEvents DgvOpciones As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
End Class
