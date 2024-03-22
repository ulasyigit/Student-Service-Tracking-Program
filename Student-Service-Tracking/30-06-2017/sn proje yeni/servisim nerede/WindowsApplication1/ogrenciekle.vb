Imports System.Data.OleDb
Public Class ogrenciekle

    Private Sub ogrenciekle_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            bag.Open()
            ComboBox1.Items.Clear()

            komut.CommandText = "select okulad from okul"
            Dim oku As OleDbDataReader = komut.ExecuteReader
            Do While oku.Read
                ComboBox1.Items.Add(oku.Item("okulad"))
            Loop
            oku.Close()
            bag.Close()
            ComboBox1.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        bag.Open()
        komut.CommandText = "select * from ogrenci where ono = " & TextBox1.Text & ""
        Dim oku2 As OleDbDataReader = komut.ExecuteReader
        If oku2.Read = True Then
            MessageBox.Show("Bu ogrenci zaten var!")
            oku2.Close()
        Else
            oku2.Close()
            '           komut.CommandText = "insert into personel values(" & _
            'ComboBox1.Text & ", '" & TextBox1.Text & "', '" & _
            '           TextBox2.Text & "', " & TextBox3.Text & ")"
            komut.CommandText = "insert into ogrenci values(@ono, @oadsoyad, @vadsoyad, @vtelno, @vmail, @okulad,@durum)"
            komut.Parameters.AddWithValue("@ono", Convert.ToInt32(TextBox1.Text))
            komut.Parameters.AddWithValue("@oadsoyad", TextBox2.Text)
            komut.Parameters.AddWithValue("@vadsoyad", TextBox3.Text)
            komut.Parameters.AddWithValue("@vtelno", TextBox4.Text)
            komut.Parameters.AddWithValue("@vmail", TextBox5.Text)
            komut.Parameters.AddWithValue("@okulad", ComboBox1.Text)
            komut.Parameters.AddWithValue("@durum", "indi")
            komut.ExecuteNonQuery()
            MessageBox.Show("Yeni ogrenci eklendi")
        End If

        bag.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        giris.Visible = True
        Me.Close()
    End Sub
End Class