Public Class Form32
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form31.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a56 = TextBox1.Text
        a57 = TextBox2.Text
        a58 = TextBox3.Text
        Form33.Show()
        Me.Close()
    End Sub
End Class