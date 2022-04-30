<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketPurchase
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.QtyAdult = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PriceAdult = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.cektotal = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.status = New System.Windows.Forms.TextBox()
        Me.kategorimember = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cari = New System.Windows.Forms.Button()
        Me.NamaMember = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PriceChildren = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QtyChildren = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Hari = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(413, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ticket Purchase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Qty Adult"
        '
        'QtyAdult
        '
        Me.QtyAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyAdult.Location = New System.Drawing.Point(162, 90)
        Me.QtyAdult.Name = "QtyAdult"
        Me.QtyAdult.Size = New System.Drawing.Size(254, 29)
        Me.QtyAdult.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(430, 573)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 42)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(624, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nama Pegawai :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(625, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 24)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Tanggal             :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(625, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 24)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Hari                    :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(191, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 24)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Kategori Adult"
        '
        'PriceAdult
        '
        Me.PriceAdult.BackColor = System.Drawing.Color.White
        Me.PriceAdult.Enabled = False
        Me.PriceAdult.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceAdult.Location = New System.Drawing.Point(162, 55)
        Me.PriceAdult.Name = "PriceAdult"
        Me.PriceAdult.ReadOnly = True
        Me.PriceAdult.Size = New System.Drawing.Size(254, 29)
        Me.PriceAdult.TabIndex = 25
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(334, 486)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 24)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Total"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.White
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(391, 483)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(254, 29)
        Me.total.TabIndex = 30
        '
        'cektotal
        '
        Me.cektotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cektotal.Location = New System.Drawing.Point(651, 483)
        Me.cektotal.Name = "cektotal"
        Me.cektotal.Size = New System.Drawing.Size(43, 29)
        Me.cektotal.TabIndex = 33
        Me.cektotal.Text = "cek"
        Me.cektotal.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 26)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(777, 56)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(57, 24)
        Me.Nama.TabIndex = 35
        Me.Nama.Text = "nama"
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.Location = New System.Drawing.Point(777, 80)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(71, 24)
        Me.Tanggal.TabIndex = 36
        Me.Tanggal.Text = "tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox1.Controls.Add(Me.status)
        Me.GroupBox1.Controls.Add(Me.kategorimember)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.cari)
        Me.GroupBox1.Controls.Add(Me.NamaMember)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(509, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 287)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Member"
        '
        'status
        '
        Me.status.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.Location = New System.Drawing.Point(103, 236)
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Size = New System.Drawing.Size(248, 29)
        Me.status.TabIndex = 46
        '
        'kategorimember
        '
        Me.kategorimember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kategorimember.Location = New System.Drawing.Point(103, 201)
        Me.kategorimember.Name = "kategorimember"
        Me.kategorimember.ReadOnly = True
        Me.kategorimember.Size = New System.Drawing.Size(248, 29)
        Me.kategorimember.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 24)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 24)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Kategori"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(379, 114)
        Me.DataGridView1.TabIndex = 43
        '
        'cari
        '
        Me.cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cari.Location = New System.Drawing.Point(357, 32)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(44, 29)
        Me.cari.TabIndex = 42
        Me.cari.Text = "Cari"
        Me.cari.UseVisualStyleBackColor = True
        '
        'NamaMember
        '
        Me.NamaMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMember.Location = New System.Drawing.Point(103, 32)
        Me.NamaMember.Name = "NamaMember"
        Me.NamaMember.Size = New System.Drawing.Size(248, 29)
        Me.NamaMember.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 24)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Nama"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(82, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(86, 24)
        Me.CheckBox1.TabIndex = 40
        Me.CheckBox1.Text = "Member"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(82, 93)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(115, 24)
        Me.CheckBox2.TabIndex = 41
        Me.CheckBox2.Text = "NonMember"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkCyan
        Me.GroupBox2.Controls.Add(Me.PriceChildren)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.QtyChildren)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.PriceAdult)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.QtyAdult)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(35, 153)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 287)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NonMember"
        '
        'PriceChildren
        '
        Me.PriceChildren.BackColor = System.Drawing.Color.White
        Me.PriceChildren.Enabled = False
        Me.PriceChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceChildren.Location = New System.Drawing.Point(162, 191)
        Me.PriceChildren.Name = "PriceChildren"
        Me.PriceChildren.ReadOnly = True
        Me.PriceChildren.Size = New System.Drawing.Size(254, 29)
        Me.PriceChildren.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 24)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Price"
        '
        'QtyChildren
        '
        Me.QtyChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QtyChildren.Location = New System.Drawing.Point(162, 226)
        Me.QtyChildren.Name = "QtyChildren"
        Me.QtyChildren.Size = New System.Drawing.Size(254, 29)
        Me.QtyChildren.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(114, 24)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Qty Children"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(179, 158)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(155, 24)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Kategori Children"
        '
        'Hari
        '
        Me.Hari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hari.FormattingEnabled = True
        Me.Hari.Items.AddRange(New Object() {"Weekday", "Weekend"})
        Me.Hari.Location = New System.Drawing.Point(780, 107)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(143, 28)
        Me.Hari.TabIndex = 43
        '
        'TicketPurchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(965, 637)
        Me.Controls.Add(Me.Hari)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cektotal)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TicketPurchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TicketPurchase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QtyAdult As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PriceAdult As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents total As TextBox
    Friend WithEvents cektotal As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Nama As Label
    Friend WithEvents Tanggal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cari As Button
    Friend WithEvents NamaMember As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents status As TextBox
    Friend WithEvents kategorimember As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PriceChildren As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents QtyChildren As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Hari As ComboBox
End Class
