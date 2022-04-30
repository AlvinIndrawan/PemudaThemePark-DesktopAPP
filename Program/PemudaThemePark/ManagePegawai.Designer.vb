<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagePegawai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Pasword = New System.Windows.Forms.TextBox()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.noHP = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Jabatan = New System.Windows.Forms.ComboBox()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Updet = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(281, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Manage Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama"
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(306, 254)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(254, 29)
        Me.Nama.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(665, 178)
        Me.DataGridView1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(153, 458)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "No HP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(153, 496)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Gender"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(153, 534)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 24)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Jabatan"
        '
        'Username
        '
        Me.Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.Location = New System.Drawing.Point(306, 289)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(254, 29)
        Me.Username.TabIndex = 19
        '
        'Pasword
        '
        Me.Pasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pasword.Location = New System.Drawing.Point(306, 324)
        Me.Pasword.Name = "Pasword"
        Me.Pasword.Size = New System.Drawing.Size(254, 29)
        Me.Pasword.TabIndex = 20
        '
        'Alamat
        '
        Me.Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(306, 359)
        Me.Alamat.Multiline = True
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(254, 88)
        Me.Alamat.TabIndex = 21
        '
        'noHP
        '
        Me.noHP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noHP.Location = New System.Drawing.Point(306, 453)
        Me.noHP.Name = "noHP"
        Me.noHP.Size = New System.Drawing.Size(254, 29)
        Me.noHP.TabIndex = 22
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.Gender.Location = New System.Drawing.Point(305, 488)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(255, 32)
        Me.Gender.TabIndex = 23
        '
        'Jabatan
        '
        Me.Jabatan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jabatan.FormattingEnabled = True
        Me.Jabatan.Location = New System.Drawing.Point(305, 526)
        Me.Jabatan.Name = "Jabatan"
        Me.Jabatan.Size = New System.Drawing.Size(255, 32)
        Me.Jabatan.TabIndex = 24
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(178, 593)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(131, 42)
        Me.Insert.TabIndex = 25
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Updet
        '
        Me.Updet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updet.Location = New System.Drawing.Point(324, 593)
        Me.Updet.Name = "Updet"
        Me.Updet.Size = New System.Drawing.Size(131, 42)
        Me.Updet.TabIndex = 26
        Me.Updet.Text = "Update"
        Me.Updet.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(471, 593)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(131, 42)
        Me.Delete.TabIndex = 27
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 33)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ManagePegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(746, 661)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Updet)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Jabatan)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.noHP)
        Me.Controls.Add(Me.Alamat)
        Me.Controls.Add(Me.Pasword)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManagePegawai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManagePegawai"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Pasword As TextBox
    Friend WithEvents Alamat As TextBox
    Friend WithEvents noHP As TextBox
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Jabatan As ComboBox
    Friend WithEvents Insert As Button
    Friend WithEvents Updet As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Button1 As Button
End Class
