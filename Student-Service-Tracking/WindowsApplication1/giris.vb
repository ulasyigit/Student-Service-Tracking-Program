Public Class giris

    Structure veli
        Public kad As String
        Public sifre As String
        <VBFixedString(20)> Public eposta As String
        <VBFixedString(15)> Public vad As String
        <VBFixedString(15)> Public vsoyad As String
        <VBFixedString(15)> Public oad As String
        <VBFixedString(15)> Public osoyad As String
        <VBFixedString(20)> Public okul As String

    End Structure


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim kayitUzn, kayitSay As Integer
        Dim uye As veli, kontrol As Boolean
        Try
            kayitUzn = Len(uye)
            FileOpen(1, "uyebilgi.dat", OpenMode.Random, , , kayitUzn)
            kayitSay = LOF(1) / kayitUzn   'kayit sayisinin Bayt cinsinden uzunlugu
            For i = 1 To kayitSay
                FileGet(1, uye, i)
                If uye.kad = TextBox1.Text And uye.sifre = TextBox2.Text Then kontrol = True 'girilen bilgiler doğruysa 
            Next

            If kontrol = True Then

                kayitSay = LOF(1) / kayitUzn
                For i = 1 To kayitSay
                    FileGet(1, uye, i)

                    globalsinif.vad = uye.vad
                    globalsinif.vsoyad = uye.vsoyad
                    globalsinif.oad = uye.oad
                    globalsinif.osoyad = uye.osoyad

                Next

                Me.Visible = False
                bilgi.ShowDialog()
                Me.Visible = True
            Else
                MessageBox.Show("Kullanıcı adı ve/veya şifre hatalı!")
            End If

            TextBox1.Clear()
            TextBox2.Clear()
            FileClose(1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim kayitUzn, kayitSay As Integer
        Dim uye As veli, kontrol As Boolean
        Try
            kayitUzn = Len(uye)
            FileOpen(1, "uyebilgi.dat", OpenMode.Random, , , kayitUzn)
            kayitSay = LOF(1) / kayitUzn   'kayit sayisinin Bayt cinsinden uzunlugu
            For i = 1 To kayitSay
                FileGet(1, uye, i)
                If uye.kad = TextBox1.Text And uye.sifre = TextBox2.Text Then kontrol = True
            Next
            If kontrol = True Then
                MessageBox.Show("Bu uyeden Zaten Var")

            Else                                    'uye yoksa ekleme
                uye.kad = TextBox1.Text
                uye.sifre = TextBox2.Text
                uye.eposta = TextBox3.Text
                uye.vad = TextBox4.Text
                uye.vsoyad = TextBox5.Text
                uye.oad = TextBox6.Text
                uye.osoyad = TextBox7.Text
                uye.okul = TextBox8.Text

                kayitSay += 1
                FilePut(1, uye, kayitSay)

                MessageBox.Show("kayıt eklendi")
            End If

            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            TextBox6.Clear()
            TextBox7.Clear()
            TextBox8.Clear()
            FileClose(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

End Class
