<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageGames
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Umur = New System.Windows.Forms.TextBox()
        Me.Kapasitas = New System.Windows.Forms.TextBox()
        Me.Durasi = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Updet = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Photo = New System.Windows.Forms.TextBox()
        Me.search = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Manage Games"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(649, 164)
        Me.DataGridView1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Game"
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(420, 237)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(254, 29)
        Me.Nama.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 24)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tanggal dibangun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(245, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Umur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(245, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 24)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Kapasitas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(245, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 24)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Durasi"
        '
        'Umur
        '
        Me.Umur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Umur.Location = New System.Drawing.Point(420, 302)
        Me.Umur.Name = "Umur"
        Me.Umur.Size = New System.Drawing.Size(254, 29)
        Me.Umur.TabIndex = 15
        '
        'Kapasitas
        '
        Me.Kapasitas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kapasitas.Location = New System.Drawing.Point(420, 337)
        Me.Kapasitas.Name = "Kapasitas"
        Me.Kapasitas.Size = New System.Drawing.Size(254, 29)
        Me.Kapasitas.TabIndex = 16
        '
        'Durasi
        '
        Me.Durasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Durasi.Location = New System.Drawing.Point(420, 372)
        Me.Durasi.Name = "Durasi"
        Me.Durasi.Size = New System.Drawing.Size(254, 29)
        Me.Durasi.TabIndex = 17
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(420, 272)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(254, 24)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(237, 471)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(131, 42)
        Me.Insert.TabIndex = 19
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Updet
        '
        Me.Updet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updet.Location = New System.Drawing.Point(395, 471)
        Me.Updet.Name = "Updet"
        Me.Updet.Size = New System.Drawing.Size(131, 42)
        Me.Updet.TabIndex = 20
        Me.Updet.Text = "Update"
        Me.Updet.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.Location = New System.Drawing.Point(552, 471)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(131, 42)
        Me.Delete.TabIndex = 21
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 33)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Location = New System.Drawing.Point(25, 250)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(245, 412)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 24)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Photo"
        '
        'Photo
        '
        Me.Photo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Photo.Location = New System.Drawing.Point(420, 407)
        Me.Photo.Name = "Photo"
        Me.Photo.Size = New System.Drawing.Size(254, 29)
        Me.Photo.TabIndex = 33
        '
        'search
        '
        Me.search.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Location = New System.Drawing.Point(680, 407)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(34, 29)
        Me.search.TabIndex = 34
        Me.search.Text = "..."
        Me.search.UseVisualStyleBackColor = True
        '
        'ManageGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(724, 536)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.Photo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Updet)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Durasi)
        Me.Controls.Add(Me.Kapasitas)
        Me.Controls.Add(Me.Umur)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ManageGames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageGames"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Nama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Umur As TextBox
    Friend WithEvents Kapasitas As TextBox
    Friend WithEvents Durasi As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Insert As Button
    Friend WithEvents Updet As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Photo As TextBox
    Friend WithEvents search As Button
End Class
