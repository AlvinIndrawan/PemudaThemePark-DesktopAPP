<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageGaji
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tipe = New System.Windows.Forms.TextBox()
        Me.Rate = New System.Windows.Forms.TextBox()
        Me.Deskripsi = New System.Windows.Forms.TextBox()
        Me.insert = New System.Windows.Forms.Button()
        Me.updet = New System.Windows.Forms.Button()
        Me.delet = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Jenis Gaji"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(622, 200)
        Me.DataGridView1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tipe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 356)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 24)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Deskripsi"
        '
        'Tipe
        '
        Me.Tipe.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipe.Location = New System.Drawing.Point(231, 282)
        Me.Tipe.Name = "Tipe"
        Me.Tipe.Size = New System.Drawing.Size(360, 29)
        Me.Tipe.TabIndex = 15
        '
        'Rate
        '
        Me.Rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rate.Location = New System.Drawing.Point(231, 317)
        Me.Rate.Name = "Rate"
        Me.Rate.Size = New System.Drawing.Size(360, 29)
        Me.Rate.TabIndex = 16
        '
        'Deskripsi
        '
        Me.Deskripsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deskripsi.Location = New System.Drawing.Point(231, 351)
        Me.Deskripsi.Multiline = True
        Me.Deskripsi.Name = "Deskripsi"
        Me.Deskripsi.Size = New System.Drawing.Size(360, 117)
        Me.Deskripsi.TabIndex = 17
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(175, 500)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(108, 34)
        Me.insert.TabIndex = 18
        Me.insert.Text = "insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'updet
        '
        Me.updet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updet.Location = New System.Drawing.Point(321, 500)
        Me.updet.Name = "updet"
        Me.updet.Size = New System.Drawing.Size(108, 34)
        Me.updet.TabIndex = 19
        Me.updet.Text = "update"
        Me.updet.UseVisualStyleBackColor = True
        '
        'delet
        '
        Me.delet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delet.Location = New System.Drawing.Point(463, 500)
        Me.delet.Name = "delet"
        Me.delet.Size = New System.Drawing.Size(108, 34)
        Me.delet.TabIndex = 20
        Me.delet.Text = "Delete"
        Me.delet.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(59, 33)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Gaji
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(720, 559)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.delet)
        Me.Controls.Add(Me.updet)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.Deskripsi)
        Me.Controls.Add(Me.Rate)
        Me.Controls.Add(Me.Tipe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gaji"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gaji"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tipe As TextBox
    Friend WithEvents Rate As TextBox
    Friend WithEvents Deskripsi As TextBox
    Friend WithEvents insert As Button
    Friend WithEvents updet As Button
    Friend WithEvents delet As Button
    Friend WithEvents Button1 As Button
End Class
