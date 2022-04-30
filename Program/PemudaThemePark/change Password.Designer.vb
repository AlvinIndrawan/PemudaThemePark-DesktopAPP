<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class change_Password
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
        Me.OldPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NewPasword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Save = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(225, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Old Password"
        '
        'OldPassword
        '
        Me.OldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPassword.Location = New System.Drawing.Point(254, 102)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.Size = New System.Drawing.Size(254, 29)
        Me.OldPassword.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(82, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "New Password"
        '
        'NewPasword
        '
        Me.NewPasword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasword.Location = New System.Drawing.Point(254, 146)
        Me.NewPasword.Name = "NewPasword"
        Me.NewPasword.Size = New System.Drawing.Size(254, 29)
        Me.NewPasword.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(82, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Password"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(254, 192)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.Size = New System.Drawing.Size(254, 29)
        Me.ConfirmPassword.TabIndex = 8
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.Location = New System.Drawing.Point(214, 263)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(131, 42)
        Me.Save.TabIndex = 9
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'change_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(594, 347)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NewPasword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OldPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "change_Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "change_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents OldPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NewPasword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ConfirmPassword As TextBox
    Friend WithEvents Save As Button
    Friend WithEvents Button1 As Button
End Class
