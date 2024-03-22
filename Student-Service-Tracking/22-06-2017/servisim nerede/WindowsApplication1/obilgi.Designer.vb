<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class obilgi
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bag = New System.Data.OleDb.OleDbConnection()
        Me.komut = New System.Data.OleDb.OleDbCommand()
        Me.OgrenciBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Servis_TakipDataSet = New WindowsApplication1.Servis_TakipDataSet()
        Me.OkulBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OkulTableAdapter = New WindowsApplication1.Servis_TakipDataSetTableAdapters.okulTableAdapter()
        Me.OgrenciTableAdapter = New WindowsApplication1.Servis_TakipDataSetTableAdapters.ogrenciTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Servis_TakipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OkulBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 497)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "<- geri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(24, 97)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(369, 147)
        Me.ListBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Okul Listesi:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Öğrenci Listesi:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(24, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 21)
        Me.ComboBox1.TabIndex = 12
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
        'OgrenciBindingSource
        '
        Me.OgrenciBindingSource.DataMember = "ogrenci"
        Me.OgrenciBindingSource.DataSource = Me.Servis_TakipDataSet
        '
        'Servis_TakipDataSet
        '
        Me.Servis_TakipDataSet.DataSetName = "Servis_TakipDataSet"
        Me.Servis_TakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OkulBindingSource
        '
        Me.OkulBindingSource.DataMember = "okul"
        Me.OkulBindingSource.DataSource = Me.Servis_TakipDataSet
        '
        'OkulTableAdapter
        '
        Me.OkulTableAdapter.ClearBeforeFill = True
        '
        'OgrenciTableAdapter
        '
        Me.OgrenciTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(171, 250)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Öğrenci ekle ↓↓"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(26, 330)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(262, 95)
        Me.ListBox2.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bilgisi Gönderilecek öğrenciler:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(294, 331)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Biniş saati: ?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "İniş saati: ?"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(297, 402)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 42)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Veliye bilgi gönder"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 375)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Veli e-posta listesi:"
        '
        'obilgi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 543)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "obilgi"
        Me.Text = "öğrenci bilgi"
        CType(Me.OgrenciBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Servis_TakipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OkulBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents bag As System.Data.OleDb.OleDbConnection
    Friend WithEvents komut As System.Data.OleDb.OleDbCommand
    Friend WithEvents Servis_TakipDataSet As WindowsApplication1.Servis_TakipDataSet
    Friend WithEvents OkulBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OkulTableAdapter As WindowsApplication1.Servis_TakipDataSetTableAdapters.okulTableAdapter
    Friend WithEvents OgrenciBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OgrenciTableAdapter As WindowsApplication1.Servis_TakipDataSetTableAdapters.ogrenciTableAdapter
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
