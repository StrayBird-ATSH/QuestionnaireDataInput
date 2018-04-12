Public Class Form22
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form21.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a29 = TextBox1.Text
        a30 = TextBox2.Text
        a31 = TextBox3.Text
        Form23.Show()
        Me.Close()
    End Sub
End Class