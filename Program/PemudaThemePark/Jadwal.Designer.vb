<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jadwal
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Insert = New System.Windows.Forms.Button()
        Me.Updet = New System.Windows.Forms.Button()
        Me.Delet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Shift = New System.Windows.Forms.ComboBox()
        Me.Nama = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Game = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 59)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(447, 436)
        Me.DataGridView1.TabIndex = 0
        '
        'Insert
        '
        Me.Insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insert.Location = New System.Drawing.Point(521, 251)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(93, 38)
        Me.Insert.TabIndex = 21
        Me.Insert.Text = "Insert"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'Updet
        '
        Me.Updet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updet.Location = New System.Drawing.Point(654, 251)
        Me.Updet.Name = "Updet"
        Me.Updet.Size = New System.Drawing.Size(93, 38)
        Me.Updet.TabIndex = 22
        Me.Updet.Text = "Update"
        Me.Updet.UseVisualStyleBackColor = True
        '
        'Delet
        '
        Me.Delet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delet.Location = New System.Drawing.Point(780, 251)
        Me.Delet.Name = "Delet"
        Me.Delet.Size = New System.Drawing.Size(93, 38)
        Me.Delet.TabIndex = 23
        Me.Delet.Text = "Delete"
        Me.Delet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 33)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(487, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(487, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Shift"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nama Pegawai"
        '
        'Shift
        '
        Me.Shift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shift.FormattingEnabled = True
        Me.Shift.Items.AddRange(New Object() {"Pagi", "Malam"})
        Me.Shift.Location = New System.Drawing.Point(639, 97)
        Me.Shift.Name = "Shift"
        Me.Shift.Size = New System.Drawing.Size(255, 32)
        Me.Shift.TabIndex = 24
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.FormattingEnabled = True
        Me.Nama.Location = New System.Drawing.Point(639, 141)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(255, 32)
        Me.Nama.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(487, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Nama Game"
        '
        'Game
        '
        Me.Game.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Game.FormattingEnabled = True
        Me.Game.Location = New System.Drawing.Point(639, 183)
        Me.Game.Name = "Game"
        Me.Game.Size = New System.Drawing.Size(255, 32)
        Me.Game.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(639, 66)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(255, 24)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Jadwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(920, 518)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Game)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Delet)
        Me.Controls.Add(Me.Updet)
        Me.Controls.Add(Me.Shift)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Insert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Jadwal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jadwal"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Insert As Button
    Friend WithEvents Updet As Button
    Friend WithEvents Delet As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Shift As ComboBox
    Friend WithEvents Nama As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Game As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
