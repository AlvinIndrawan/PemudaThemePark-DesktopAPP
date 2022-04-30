<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PegawaiNavigation
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
        Me.pesantiket = New System.Windows.Forms.Button()
        Me.JoinMemberr = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.ChangePassword = New System.Windows.Forms.Button()
        Me.Jadwal = New System.Windows.Forms.Button()
        Me.Nama = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pegawai Navigation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Welcome,"
        '
        'pesantiket
        '
        Me.pesantiket.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesantiket.Location = New System.Drawing.Point(108, 148)
        Me.pesantiket.Name = "pesantiket"
        Me.pesantiket.Size = New System.Drawing.Size(231, 49)
        Me.pesantiket.TabIndex = 6
        Me.pesantiket.Text = "Ticket Purchase"
        Me.pesantiket.UseVisualStyleBackColor = True
        '
        'JoinMemberr
        '
        Me.JoinMemberr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JoinMemberr.Location = New System.Drawing.Point(108, 203)
        Me.JoinMemberr.Name = "JoinMemberr"
        Me.JoinMemberr.Size = New System.Drawing.Size(231, 49)
        Me.JoinMemberr.TabIndex = 7
        Me.JoinMemberr.Text = "Join Member"
        Me.JoinMemberr.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.Location = New System.Drawing.Point(108, 368)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(231, 49)
        Me.Logout.TabIndex = 9
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.ChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePassword.Location = New System.Drawing.Point(108, 313)
        Me.ChangePassword.Name = "ChangePassword"
        Me.ChangePassword.Size = New System.Drawing.Size(231, 49)
        Me.ChangePassword.TabIndex = 10
        Me.ChangePassword.Text = "Change Password"
        Me.ChangePassword.UseVisualStyleBackColor = True
        '
        'Jadwal
        '
        Me.Jadwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jadwal.Location = New System.Drawing.Point(108, 258)
        Me.Jadwal.Name = "Jadwal"
        Me.Jadwal.Size = New System.Drawing.Size(231, 49)
        Me.Jadwal.TabIndex = 11
        Me.Jadwal.Text = "Lihat Jadwal"
        Me.Jadwal.UseVisualStyleBackColor = True
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(114, 84)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(60, 24)
        Me.Nama.TabIndex = 4
        Me.Nama.Text = "Nama"
        '
        'PegawaiNavigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(446, 463)
        Me.Controls.Add(Me.Jadwal)
        Me.Controls.Add(Me.ChangePassword)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.JoinMemberr)
        Me.Controls.Add(Me.pesantiket)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PegawaiNavigation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PegawaiNavigation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pesantiket As Button
    Friend WithEvents JoinMemberr As Button
    Friend WithEvents Logout As Button
    Friend WithEvents ChangePassword As Button
    Friend WithEvents Jadwal As Button
    Friend WithEvents Nama As Label
End Class
