Imports System.Data.OleDb

Public Class obilgi

    Private Sub obilgi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try

            bag.Open()
            ListBox1.Items.Clear()
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()

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

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            ListBox1.Items.Clear()
            ComboBox2.Items.Clear()
            bag.Open()
            komut.CommandText = "select * from ogrenci where okulad = '" & ComboBox1.Text & "'"
            Dim oku As OleDbDataReader = komut.ExecuteReader

            Do While oku.Read
                ListBox1.Items.Add(oku.Item("oadsoyad") & vbTab & oku.Item("vtelno") & vbTab & oku.Item("vmail") & vbTab & oku.Item("okulad"))
            Loop

            oku.Close()


            komut.CommandText = "select vmail from ogrenci where okulad = '" & ComboBox1.Text & "' group by vmail"
            oku = komut.ExecuteReader
            Do While oku.Read
                ComboBox2.Items.Add(oku.Item("vmail"))
            Loop
            oku.Close()

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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class