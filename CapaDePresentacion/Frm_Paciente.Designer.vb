<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Paciente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.LblSaludo = New System.Windows.Forms.Label()
        Me.LblSintomas = New System.Windows.Forms.Label()
        Me.TxtSintoma = New System.Windows.Forms.TextBox()
        Me.DgvSintomaSistema = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Lst = New System.Windows.Forms.ListView()
        Me.DgvOpciones = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvSintomaSistema, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TxtSintoma.Location = New System.Drawing.Point(24, 120)
        Me.TxtSintoma.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtSintoma.MaxLength = 30
        Me.TxtSintoma.Name = "TxtSintoma"
        Me.TxtSintoma.Size = New System.Drawing.Size(281, 26)
        Me.TxtSintoma.TabIndex = 3
        Me.TxtSintoma.Text = "Tengo fiebre, tengo tos..."
        '
        'DgvSintomaSistema
        '
        Me.DgvSintomaSistema.AllowDrop = True
        Me.DgvSintomaSistema.AllowUserToAddRows = False
        Me.DgvSintomaSistema.AllowUserToDeleteRows = False
        Me.DgvSintomaSistema.AllowUserToResizeColumns = False
        Me.DgvSintomaSistema.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvSintomaSistema.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvSintomaSistema.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSintomaSistema.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSintomaSistema.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DgvSintomaSistema.BackgroundColor = System.Drawing.Color.White
        Me.DgvSintomaSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSintomaSistema.ColumnHeadersVisible = False
        Me.DgvSintomaSistema.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvSintomaSistema.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvSintomaSistema.Location = New System.Drawing.Point(24, 147)
        Me.DgvSintomaSistema.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DgvSintomaSistema.Name = "DgvSintomaSistema"
        Me.DgvSintomaSistema.ReadOnly = True
        Me.DgvSintomaSistema.RowHeadersVisible = False
        Me.DgvSintomaSistema.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvSintomaSistema.Size = New System.Drawing.Size(281, 366)
        Me.DgvSintomaSistema.TabIndex = 6
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.White
        Me.BtnBuscar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ForeColor = System.Drawing.Color.Black
        Me.BtnBuscar.Location = New System.Drawing.Point(578, 279)
        Me.BtnBuscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(206, 50)
        Me.BtnBuscar.TabIndex = 8
        Me.BtnBuscar.Text = "Realizar Diagnostico"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.White
        Me.BtnAgregar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregar.Location = New System.Drawing.Point(343, 147)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(102, 58)
        Me.BtnAgregar.TabIndex = 9
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Lst
        '
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.Lst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.Lst.HideSelection = False
        Me.Lst.Location = New System.Drawing.Point(488, 112)
        Me.Lst.Name = "Lst"
        Me.Lst.Size = New System.Drawing.Size(395, 141)
        Me.Lst.TabIndex = 11
        Me.Lst.UseCompatibleStateImageBehavior = False
        Me.Lst.View = System.Windows.Forms.View.SmallIcon
        '
        'DgvOpciones
        '
        Me.DgvOpciones.AllowUserToAddRows = False
        Me.DgvOpciones.AllowUserToDeleteRows = False
        Me.DgvOpciones.BackgroundColor = System.Drawing.Color.White
        Me.DgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOpciones.Location = New System.Drawing.Point(488, 358)
        Me.DgvOpciones.Name = "DgvOpciones"
        Me.DgvOpciones.ReadOnly = True
        Me.DgvOpciones.RowHeadersVisible = False
        Me.DgvOpciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvOpciones.RowTemplate.Height = 28
        Me.DgvOpciones.Size = New System.Drawing.Size(395, 155)
        Me.DgvOpciones.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(599, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 49)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Inicie un chat ahora!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_Paciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(936, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DgvOpciones)
        Me.Controls.Add(Me.Lst)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.DgvSintomaSistema)
        Me.Controls.Add(Me.LblSaludo)
        Me.Controls.Add(Me.LblSintomas)
        Me.Controls.Add(Me.TxtSintoma)
        Me.Name = "Frm_Paciente"
        Me.Text = "Paciente"
        CType(Me.DgvSintomaSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSaludo As Label
    Friend WithEvents LblSintomas As Label
    Friend WithEvents TxtSintoma As TextBox
    Friend WithEvents DgvSintomaSistema As DataGridView
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents Lst As ListView
    Friend WithEvents DgvOpciones As DataGridView
    Friend WithEvents Button1 As Button
End Class
