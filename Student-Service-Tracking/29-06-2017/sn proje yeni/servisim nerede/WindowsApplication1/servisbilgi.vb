Imports System.Data.OleDb
Imports System.Net.Mail

Public Class servisbilgi

    Private Sub servisbilgi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ListBox1.Items.Clear()
            bag.Open()

            DataGridView1.ColumnCount = 4
            DataGridView1.ColumnHeadersVisible = True
            DataGridView1.Columns(0).Name = "oadsoyad"
            DataGridView1.Columns(1).Name = "vtelno"
            DataGridView1.Columns(2).Name = "vmail"
            DataGridView1.Columns(3).Name = "durum"

            komut.CommandText = "select * from ogrenci"
            Dim oku As OleDbDataReader = komut.ExecuteReader
            Do While oku.Read
                'ListBox1.Items.Add(oku.Item("oadsoyad") & vbTab & oku.Item("vtelno") & vbTab & oku.Item("vmail") & vbTab & oku.Item("durum"))
                DataGridView1.Rows.Add(oku.Item("oadsoyad"), oku.Item("vtelno"), oku.Item("vmail"), oku.Item("durum"))
                'If oku.Item("durum") = "bindi" Then ListBox1.BackColor = Color.Green End If
            Loop
            oku.Close()

            koltuk1.Text = "Boş"
            koltuk1.BackColor = Color.LightGray
            koltuk2.Text = "Boş"
            koltuk2.BackColor = Color.LightGray
            koltuk3.Text = "Boş"
            koltuk3.BackColor = Color.LightGray
            koltuk4.Text = "Boş"
            koltuk4.BackColor = Color.LightGray
            koltuk5.Text = "Boş"
            koltuk5.BackColor = Color.LightGray
            koltuk6.Text = "Boş"
            koltuk6.BackColor = Color.LightGray
            koltuk7.Text = "Boş"
            koltuk7.BackColor = Color.LightGray
            koltuk8.Text = "Boş"
            koltuk8.BackColor = Color.LightGray
            koltuk9.Text = "Boş"
            koltuk9.BackColor = Color.LightGray
            koltuk10.Text = "Boş"
            koltuk10.BackColor = Color.LightGray
            koltuk11.Text = "Boş"
            koltuk11.BackColor = Color.LightGray
            koltuk12.Text = "Boş"
            koltuk12.BackColor = Color.LightGray
            koltuk13.Text = "Boş"
            koltuk13.BackColor = Color.LightGray
            koltuk14.Text = "Boş"
            koltuk14.BackColor = Color.LightGray
            koltuk15.Text = "Boş"
            koltuk15.BackColor = Color.LightGray
            koltuk16.Text = "Boş"
            koltuk16.BackColor = Color.LightGray
      

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            bag.Close()
        End Try

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        giris.Visible = True
        Me.Close()
    End Sub
    Dim koltuk1_ono, koltuk2_ono, koltuk3_ono, koltuk4_ono, koltuk5_ono, koltuk6_ono, koltuk7_ono, koltuk8_ono, koltuk9_ono, koltuk10_ono, koltuk11_ono, koltuk12_ono,
        koltuk13_ono, koltuk14_ono, koltuk15_ono, koltuk16_ono As Integer
    Dim koltuk1_binsaat, koltuk2_binsaat, koltuk3_binsaat, koltuk4_binsaat, koltuk5_binsaat, koltuk6_binsaat, koltuk7_binsaat, koltuk8_binsaat, koltuk9_binsaat, koltuk10_binsaat,
        koltuk11_binsaat, koltuk12_binsaat, koltuk13_binsaat, koltuk14_binsaat, koltuk15_binsaat, koltuk16_binsaat As New Date
    Dim binsaat, insaat As New Date
    Dim vmail, oadsoyad As String

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            bag.Open()
            komut.CommandText = "select * from ogrenci where durum='bindi'"
            Dim oku As OleDbDataReader = komut.ExecuteReader

            Do While oku.Read
                If koltuk1.BackColor = Color.LightGray Then
                    koltuk1.Text = oku.Item("oadsoyad")
                    koltuk1.BackColor = Color.MediumSeaGreen
                    koltuk1_ono = oku.Item("ono")
                    koltuk1_binsaat = TimeOfDay
                ElseIf koltuk2.BackColor = Color.LightGray Then
                    koltuk2.Text = oku.Item("oadsoyad")
                    koltuk2.BackColor = Color.MediumSeaGreen
                    koltuk2_ono = oku.Item("ono")
                    koltuk2_binsaat = TimeOfDay
                ElseIf koltuk3.BackColor = Color.LightGray Then
                    koltuk3.Text = oku.Item("oadsoyad")
                    koltuk3.BackColor = Color.MediumSeaGreen
                    koltuk3_ono = oku.Item("ono")
                    koltuk3_binsaat = TimeOfDay
                ElseIf koltuk4.BackColor = Color.LightGray Then
                    koltuk4.Text = oku.Item("oadsoyad")
                    koltuk4.BackColor = Color.MediumSeaGreen
                    koltuk4_ono = oku.Item("ono")
                    koltuk4_binsaat = TimeOfDay
                ElseIf koltuk5.BackColor = Color.LightGray Then
                    koltuk5.Text = oku.Item("oadsoyad")
                    koltuk5.BackColor = Color.MediumSeaGreen
                    koltuk5_ono = oku.Item("ono")
                    koltuk5_binsaat = TimeOfDay
                ElseIf koltuk6.BackColor = Color.LightGray Then
                    koltuk6.Text = oku.Item("oadsoyad")
                    koltuk6.BackColor = Color.MediumSeaGreen
                    koltuk6_ono = oku.Item("ono")
                    koltuk6_binsaat = TimeOfDay
                ElseIf koltuk7.BackColor = Color.LightGray Then
                    koltuk7.Text = oku.Item("oadsoyad")
                    koltuk7.BackColor = Color.MediumSeaGreen
                    koltuk7_ono = oku.Item("ono")
                    koltuk7_binsaat = TimeOfDay
                ElseIf koltuk8.BackColor = Color.LightGray Then
                    koltuk8.Text = oku.Item("oadsoyad")
                    koltuk8.BackColor = Color.MediumSeaGreen
                    koltuk8_ono = oku.Item("ono")
                    koltuk8_binsaat = TimeOfDay
                ElseIf koltuk9.BackColor = Color.LightGray Then
                    koltuk9.Text = oku.Item("oadsoyad")
                    koltuk9.BackColor = Color.MediumSeaGreen
                    koltuk9_ono = oku.Item("ono")
                    koltuk9_binsaat = TimeOfDay
                ElseIf koltuk10.BackColor = Color.LightGray Then
                    koltuk10.Text = oku.Item("oadsoyad")
                    koltuk10.BackColor = Color.MediumSeaGreen
                    koltuk10_ono = oku.Item("ono")
                    koltuk10_binsaat = TimeOfDay
                ElseIf koltuk11.BackColor = Color.LightGray Then
                    koltuk11.Text = oku.Item("oadsoyad")
                    koltuk11.BackColor = Color.MediumSeaGreen
                    koltuk11_ono = oku.Item("ono")
                    koltuk11_binsaat = TimeOfDay
                ElseIf koltuk12.BackColor = Color.LightGray Then
                    koltuk12.Text = oku.Item("oadsoyad")
                    koltuk12.BackColor = Color.MediumSeaGreen
                    koltuk12_ono = oku.Item("ono")
                    koltuk12_binsaat = TimeOfDay
                ElseIf koltuk13.BackColor = Color.LightGray Then
                    koltuk13.Text = oku.Item("oadsoyad")
                    koltuk13.BackColor = Color.MediumSeaGreen
                    koltuk13_ono = oku.Item("ono")
                    koltuk13_binsaat = TimeOfDay
                ElseIf koltuk14.BackColor = Color.LightGray Then
                    koltuk14.Text = oku.Item("oadsoyad")
                    koltuk14.BackColor = Color.MediumSeaGreen
                    koltuk14_ono = oku.Item("ono")
                    koltuk14_binsaat = TimeOfDay
                ElseIf koltuk15.BackColor = Color.LightGray Then
                    koltuk15.Text = oku.Item("oadsoyad")
                    koltuk15.BackColor = Color.MediumSeaGreen
                    koltuk15_ono = oku.Item("ono")
                    koltuk15_binsaat = TimeOfDay
                ElseIf koltuk16.BackColor = Color.LightGray Then
                    koltuk16.Text = oku.Item("oadsoyad")
                    koltuk16.BackColor = Color.MediumSeaGreen
                    koltuk16_ono = oku.Item("ono")
                    koltuk16_binsaat = TimeOfDay
                End If
            Loop
            oku.Close()
            bag.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    

    Private Function red() As Object
        Throw New NotImplementedException
    End Function

  
    Private Sub koltuk1_Click(sender As System.Object, e As System.EventArgs) Handles koltuk1.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk1_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk1_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad") 
            End If

            binsaat = koltuk1_binsaat
            insaat = TimeOfDay
            oku.Close()
            bag.Close()
            koltuk1.Text = "Boş"
            koltuk1.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk2_Click(sender As System.Object, e As System.EventArgs) Handles koltuk2.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk2_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk1_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If

            binsaat = koltuk2_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk2.Text = "Boş"
            koltuk2.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk3_Click(sender As System.Object, e As System.EventArgs) Handles koltuk3.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk3_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk3_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk3_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk3.Text = "Boş"
            koltuk3.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim mesaj As String
        Dim mail As New MailMessage
        mesaj = oadsoyad & " " & " isimli ögrencinizin servise biniş saati: " & binsaat & " , " & " servisden iniş saati: " & insaat
        mail.Subject = "Servisim Nerede Programı Öğrenci Bilgisi"
        mail.To.Add(vmail)
        mail.From = New MailAddress("yigit.ot@gmail.com")
        mail.Body = mesaj

        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential("E-POSTA ADRESİ", "E-POSTA ŞİFRESİ")
        smtp.Port = "587"
        smtp.Send(mail)

    End Sub

    Private Sub koltuk4_Click(sender As System.Object, e As System.EventArgs) Handles koltuk4.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk4_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk4_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk4_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk4.Text = "Boş"
            koltuk4.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk5_Click(sender As System.Object, e As System.EventArgs) Handles koltuk5.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk5_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk5_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk5_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk5.Text = "Boş"
            koltuk5.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk6_Click(sender As System.Object, e As System.EventArgs) Handles koltuk6.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk6_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk6_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk6_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk6.Text = "Boş"
            koltuk6.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk7_Click(sender As System.Object, e As System.EventArgs) Handles koltuk7.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk7_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk7_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk7_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk7.Text = "Boş"
            koltuk7.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk8_Click(sender As System.Object, e As System.EventArgs) Handles koltuk8.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk8_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk8_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk8_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk8.Text = "Boş"
            koltuk8.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk9_Click(sender As System.Object, e As System.EventArgs) Handles koltuk9.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk9_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk9_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk9_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk9.Text = "Boş"
            koltuk9.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk10_Click(sender As System.Object, e As System.EventArgs) Handles koltuk10.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk10_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk10_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk10_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk10.Text = "Boş"
            koltuk10.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk11_Click(sender As System.Object, e As System.EventArgs) Handles koltuk11.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk11_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk11_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk3_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk11.Text = "Boş"
            koltuk11.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk12_Click(sender As System.Object, e As System.EventArgs) Handles koltuk12.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk12_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk12_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk12_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk12.Text = "Boş"
            koltuk12.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk13_Click(sender As System.Object, e As System.EventArgs) Handles koltuk13.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk13_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk13_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk13_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk13.Text = "Boş"
            koltuk13.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk14_Click(sender As System.Object, e As System.EventArgs) Handles koltuk14.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk14_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk14_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk14_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk14.Text = "Boş"
            koltuk14.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk15_Click(sender As System.Object, e As System.EventArgs) Handles koltuk15.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk15_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk15_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk15_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk15.Text = "Boş"
            koltuk15.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub koltuk16_Click(sender As System.Object, e As System.EventArgs) Handles koltuk16.Click
        Try
            ListBox1.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where ono=" & koltuk16_ono & ""
            Dim oku As OleDbDataReader = komut.ExecuteReader

            If oku.Read Then
                ListBox1.Items.Add("Ogrenci Ad-soyad:" & oku.Item("oadsoyad"))
                ListBox1.Items.Add("Biniş saati:" & koltuk16_binsaat)
                ListBox1.Items.Add("İniş saati:" & TimeOfDay)
                ListBox1.Items.Add("Veli Ad-soyad:" & oku.Item("vadsoyad"))
                ListBox1.Items.Add("Veli E-posta:" & oku.Item("vmail"))
                ListBox1.Items.Add("Veli Telefon:" & oku.Item("vtelno"))
                vmail = oku.Item("vmail")
                oadsoyad = oku.Item("oadsoyad")
            End If
            binsaat = koltuk16_binsaat
            insaat = TimeOfDay

            oku.Close()
            bag.Close()
            koltuk16.Text = "Boş"
            koltuk16.BackColor = Color.LightGray
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class