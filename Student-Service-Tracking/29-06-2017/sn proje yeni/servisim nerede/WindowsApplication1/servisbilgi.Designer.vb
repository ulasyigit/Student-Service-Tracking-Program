<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class servisbilgi
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bag = New System.Data.OleDb.OleDbConnection()
        Me.komut = New System.Data.OleDb.OleDbCommand()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.koltuk1 = New System.Windows.Forms.Button()
        Me.koltuk2 = New System.Windows.Forms.Button()
        Me.koltuk3 = New System.Windows.Forms.Button()
        Me.koltuk4 = New System.Windows.Forms.Button()
        Me.koltuk5 = New System.Windows.Forms.Button()
        Me.koltuk6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.koltuk9 = New System.Windows.Forms.Button()
        Me.koltuk8 = New System.Windows.Forms.Button()
        Me.koltuk7 = New System.Windows.Forms.Button()
        Me.koltuk12 = New System.Windows.Forms.Button()
        Me.koltuk11 = New System.Windows.Forms.Button()
        Me.koltuk10 = New System.Windows.Forms.Button()
        Me.koltuk15 = New System.Windows.Forms.Button()
        Me.koltuk14 = New System.Windows.Forms.Button()
        Me.koltuk13 = New System.Windows.Forms.Button()
        Me.koltuk16 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(479, 290)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(179, 82)
        Me.ListBox1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(453, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Öğrenci Listesi:"
        '
        'bag
        '
        Me.bag.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\user\Desktop\sn proje yen" & _
    "i\servisim nerede\vt\Servis_Takip.accdb"""
        '
        'komut
        '
        Me.komut.Connection = Me.bag
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(616, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Servise öğrenci ekle ↓↓"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(476, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bilgisi Gönderilecek öğrenci:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(667, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 42)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Veliye bilgi gönder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.Location = New System.Drawing.Point(31, 49)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 51)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Şöför"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'koltuk1
        '
        Me.koltuk1.BackColor = System.Drawing.Color.LightGray
        Me.koltuk1.Location = New System.Drawing.Point(242, 63)
        Me.koltuk1.Name = "koltuk1"
        Me.koltuk1.Size = New System.Drawing.Size(65, 37)
        Me.koltuk1.TabIndex = 24
        Me.koltuk1.Text = "Boş"
        Me.koltuk1.UseVisualStyleBackColor = False
        '
        'koltuk2
        '
        Me.koltuk2.BackColor = System.Drawing.Color.LightGray
        Me.koltuk2.Location = New System.Drawing.Point(30, 127)
        Me.koltuk2.Name = "koltuk2"
        Me.koltuk2.Size = New System.Drawing.Size(66, 37)
        Me.koltuk2.TabIndex = 25
        Me.koltuk2.Text = "Boş"
        Me.koltuk2.UseVisualStyleBackColor = False
        '
        'koltuk3
        '
        Me.koltuk3.BackColor = System.Drawing.Color.LightGray
        Me.koltuk3.Location = New System.Drawing.Point(102, 127)
        Me.koltuk3.Name = "koltuk3"
        Me.koltuk3.Size = New System.Drawing.Size(63, 37)
        Me.koltuk3.TabIndex = 26
        Me.koltuk3.Text = "Boş"
        Me.koltuk3.UseVisualStyleBackColor = False
        '
        'koltuk4
        '
        Me.koltuk4.BackColor = System.Drawing.Color.LightGray
        Me.koltuk4.Location = New System.Drawing.Point(29, 170)
        Me.koltuk4.Name = "koltuk4"
        Me.koltuk4.Size = New System.Drawing.Size(67, 37)
        Me.koltuk4.TabIndex = 27
        Me.koltuk4.Text = "Boş"
        Me.koltuk4.UseVisualStyleBackColor = False
        '
        'koltuk5
        '
        Me.koltuk5.BackColor = System.Drawing.Color.LightGray
        Me.koltuk5.Location = New System.Drawing.Point(102, 170)
        Me.koltuk5.Name = "koltuk5"
        Me.koltuk5.Size = New System.Drawing.Size(63, 37)
        Me.koltuk5.TabIndex = 28
        Me.koltuk5.Text = "Boş"
        Me.koltuk5.UseVisualStyleBackColor = False
        '
        'koltuk6
        '
        Me.koltuk6.BackColor = System.Drawing.Color.LightGray
        Me.koltuk6.Location = New System.Drawing.Point(240, 170)
        Me.koltuk6.Name = "koltuk6"
        Me.koltuk6.Size = New System.Drawing.Size(65, 37)
        Me.koltuk6.TabIndex = 29
        Me.koltuk6.Text = "Boş"
        Me.koltuk6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "<- Geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'koltuk9
        '
        Me.koltuk9.BackColor = System.Drawing.Color.LightGray
        Me.koltuk9.Location = New System.Drawing.Point(240, 213)
        Me.koltuk9.Name = "koltuk9"
        Me.koltuk9.Size = New System.Drawing.Size(65, 37)
        Me.koltuk9.TabIndex = 33
        Me.koltuk9.Text = "Boş"
        Me.koltuk9.UseVisualStyleBackColor = False
        '
        'koltuk8
        '
        Me.koltuk8.BackColor = System.Drawing.Color.LightGray
        Me.koltuk8.Location = New System.Drawing.Point(102, 213)
        Me.koltuk8.Name = "koltuk8"
        Me.koltuk8.Size = New System.Drawing.Size(63, 37)
        Me.koltuk8.TabIndex = 32
        Me.koltuk8.Text = "Boş"
        Me.koltuk8.UseVisualStyleBackColor = False
        '
        'koltuk7
        '
        Me.koltuk7.BackColor = System.Drawing.Color.LightGray
        Me.koltuk7.Location = New System.Drawing.Point(29, 213)
        Me.koltuk7.Name = "koltuk7"
        Me.koltuk7.Size = New System.Drawing.Size(67, 37)
        Me.koltuk7.TabIndex = 31
        Me.koltuk7.Text = "Boş"
        Me.koltuk7.UseVisualStyleBackColor = False
        '
        'koltuk12
        '
        Me.koltuk12.BackColor = System.Drawing.Color.LightGray
        Me.koltuk12.Location = New System.Drawing.Point(240, 256)
        Me.koltuk12.Name = "koltuk12"
        Me.koltuk12.Size = New System.Drawing.Size(65, 37)
        Me.koltuk12.TabIndex = 36
        Me.koltuk12.Text = "Boş"
        Me.koltuk12.UseVisualStyleBackColor = False
        '
        'koltuk11
        '
        Me.koltuk11.BackColor = System.Drawing.Color.LightGray
        Me.koltuk11.Location = New System.Drawing.Point(102, 256)
        Me.koltuk11.Name = "koltuk11"
        Me.koltuk11.Size = New System.Drawing.Size(63, 37)
        Me.koltuk11.TabIndex = 35
        Me.koltuk11.Text = "Boş"
        Me.koltuk11.UseVisualStyleBackColor = False
        '
        'koltuk10
        '
        Me.koltuk10.BackColor = System.Drawing.Color.LightGray
        Me.koltuk10.Location = New System.Drawing.Point(29, 256)
        Me.koltuk10.Name = "koltuk10"
        Me.koltuk10.Size = New System.Drawing.Size(67, 37)
        Me.koltuk10.TabIndex = 34
        Me.koltuk10.Text = "Boş"
        Me.koltuk10.UseVisualStyleBackColor = False
        '
        'koltuk15
        '
        Me.koltuk15.BackColor = System.Drawing.Color.LightGray
        Me.koltuk15.Location = New System.Drawing.Point(171, 308)
        Me.koltuk15.Name = "koltuk15"
        Me.koltuk15.Size = New System.Drawing.Size(65, 37)
        Me.koltuk15.TabIndex = 39
        Me.koltuk15.Text = "Boş"
        Me.koltuk15.UseVisualStyleBackColor = False
        '
        'koltuk14
        '
        Me.koltuk14.BackColor = System.Drawing.Color.LightGray
        Me.koltuk14.Location = New System.Drawing.Point(102, 308)
        Me.koltuk14.Name = "koltuk14"
        Me.koltuk14.Size = New System.Drawing.Size(63, 37)
        Me.koltuk14.TabIndex = 38
        Me.koltuk14.Text = "Boş"
        Me.koltuk14.UseVisualStyleBackColor = False
        '
        'koltuk13
        '
        Me.koltuk13.BackColor = System.Drawing.Color.LightGray
        Me.koltuk13.Location = New System.Drawing.Point(31, 308)
        Me.koltuk13.Name = "koltuk13"
        Me.koltuk13.Size = New System.Drawing.Size(65, 37)
        Me.koltuk13.TabIndex = 37
        Me.koltuk13.Text = "Boş"
        Me.koltuk13.UseVisualStyleBackColor = False
        '
        'koltuk16
        '
        Me.koltuk16.BackColor = System.Drawing.Color.LightGray
        Me.koltuk16.Location = New System.Drawing.Point(240, 308)
        Me.koltuk16.Name = "koltuk16"
        Me.koltuk16.Size = New System.Drawing.Size(65, 37)
        Me.koltuk16.TabIndex = 40
        Me.koltuk16.Text = "Boş"
        Me.koltuk16.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(479, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(407, 143)
        Me.DataGridView1.TabIndex = 41
        '
        'servisbilgi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 574)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.koltuk16)
        Me.Controls.Add(Me.koltuk15)
        Me.Controls.Add(Me.koltuk14)
        Me.Controls.Add(Me.koltuk13)
        Me.Controls.Add(Me.koltuk12)
        Me.Controls.Add(Me.koltuk11)
        Me.Controls.Add(Me.koltuk10)
        Me.Controls.Add(Me.koltuk9)
        Me.Controls.Add(Me.koltuk8)
        Me.Controls.Add(Me.koltuk7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.koltuk6)
        Me.Controls.Add(Me.koltuk5)
        Me.Controls.Add(Me.koltuk4)
        Me.Controls.Add(Me.koltuk3)
        Me.Controls.Add(Me.koltuk2)
        Me.Controls.Add(Me.koltuk1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "servisbilgi"
        Me.Text = "servis bilgi"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents bag As System.Data.OleDb.OleDbConnection
    Friend WithEvents komut As System.Data.OleDb.OleDbCommand
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents koltuk1 As System.Windows.Forms.Button
    Friend WithEvents koltuk2 As System.Windows.Forms.Button
    Friend WithEvents koltuk3 As System.Windows.Forms.Button
    Friend WithEvents koltuk4 As System.Windows.Forms.Button
    Friend WithEvents koltuk5 As System.Windows.Forms.Button
    Friend WithEvents koltuk6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents koltuk9 As System.Windows.Forms.Button
    Friend WithEvents koltuk8 As System.Windows.Forms.Button
    Friend WithEvents koltuk7 As System.Windows.Forms.Button
    Friend WithEvents koltuk12 As System.Windows.Forms.Button
    Friend WithEvents koltuk11 As System.Windows.Forms.Button
    Friend WithEvents koltuk10 As System.Windows.Forms.Button
    Friend WithEvents koltuk15 As System.Windows.Forms.Button
    Friend WithEvents koltuk14 As System.Windows.Forms.Button
    Friend WithEvents koltuk13 As System.Windows.Forms.Button
    Friend WithEvents koltuk16 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
