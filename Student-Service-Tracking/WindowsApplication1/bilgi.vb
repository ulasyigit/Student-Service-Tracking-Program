Public Class bilgi

    Private Sub bilgi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label2.Text = globalsinif.vad & " " & globalsinif.vsoyad
        Label4.Text = globalsinif.oad & " " & globalsinif.osoyad
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        giris.Visible = True
        Me.Close()

    End Sub
End Class