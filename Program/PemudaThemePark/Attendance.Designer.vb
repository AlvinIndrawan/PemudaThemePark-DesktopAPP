<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.save = New System.Windows.Forms.Button()
        Me.shift = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ontime = New System.Windows.Forms.CheckBox()
        Me.late = New System.Windows.Forms.CheckBox()
        Me.absent = New System.Windows.Forms.CheckBox()
        Me.overtime = New System.Windows.Forms.CheckBox()
        Me.updet = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(670, 219)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 336)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nama Pegawai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(356, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Kehadiran"
        '
        'nama
        '
        Me.nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.FormattingEnabled = True
        Me.nama.Location = New System.Drawing.Point(275, 333)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(254, 32)
        Me.nama.TabIndex = 25
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(441, 21)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 24)
        Me.DateTimePicker1.TabIndex = 26
        '
        'save
        '
        Me.save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save.Location = New System.Drawing.Point(377, 470)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(131, 42)
        Me.save.TabIndex = 29
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'shift
        '
        Me.shift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shift.FormattingEnabled = True
        Me.shift.Items.AddRange(New Object() {"Pagi", "Malam"})
        Me.shift.Location = New System.Drawing.Point(275, 295)
        Me.shift.Name = "shift"
        Me.shift.Size = New System.Drawing.Size(254, 32)
        Me.shift.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(121, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 24)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Shift"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 33)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ontime
        '
        Me.ontime.AutoSize = True
        Me.ontime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ontime.Location = New System.Drawing.Point(275, 376)
        Me.ontime.Name = "ontime"
        Me.ontime.Size = New System.Drawing.Size(88, 24)
        Me.ontime.TabIndex = 34
        Me.ontime.Text = "On-Time"
        Me.ontime.UseVisualStyleBackColor = True
        '
        'late
        '
        Me.late.AutoSize = True
        Me.late.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.late.Location = New System.Drawing.Point(275, 406)
        Me.late.Name = "late"
        Me.late.Size = New System.Drawing.Size(60, 24)
        Me.late.TabIndex = 35
        Me.late.Text = "Late"
        Me.late.UseVisualStyleBackColor = True
        '
        'absent
        '
        Me.absent.AutoSize = True
        Me.absent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absent.Location = New System.Drawing.Point(401, 376)
        Me.absent.Name = "absent"
        Me.absent.Size = New System.Drawing.Size(79, 24)
        Me.absent.TabIndex = 36
        Me.absent.Text = "Absent"
        Me.absent.UseVisualStyleBackColor = True
        '
        'overtime
        '
        Me.overtime.AutoSize = True
        Me.overtime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overtime.Location = New System.Drawing.Point(401, 406)
        Me.overtime.Name = "overtime"
        Me.overtime.Size = New System.Drawing.Size(91, 24)
        Me.overtime.TabIndex = 37
        Me.overtime.Text = "Overtime"
        Me.overtime.UseVisualStyleBackColor = True
        '
        'updet
        '
        Me.updet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updet.Location = New System.Drawing.Point(218, 470)
        Me.updet.Name = "updet"
        Me.updet.Size = New System.Drawing.Size(131, 42)
        Me.updet.TabIndex = 38
        Me.updet.Text = "Update"
        Me.updet.UseVisualStyleBackColor = True
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(699, 542)
        Me.Controls.Add(Me.updet)
        Me.Controls.Add(Me.overtime)
        Me.Controls.Add(Me.absent)
        Me.Controls.Add(Me.late)
        Me.Controls.Add(Me.ontime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.shift)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nama As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents save As Button
    Friend WithEvents shift As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ontime As CheckBox
    Friend WithEvents late As CheckBox
    Friend WithEvents absent As CheckBox
    Friend WithEvents overtime As CheckBox
    Friend WithEvents updet As Button
End Class
