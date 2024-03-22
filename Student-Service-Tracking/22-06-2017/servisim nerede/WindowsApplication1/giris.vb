Public Class giris

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        obilgi.ShowDialog()
        Me.Visible = True
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Visible = False
        ogrenciekle.ShowDialog()
        Me.Visible = True
    End Sub
End Class
