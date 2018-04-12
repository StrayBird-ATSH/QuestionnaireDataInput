Public Class Form30
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form29.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a51 = TextBox1.Text
        a52 = TextBox2.Text
        a53 = TextBox3.Text
        Form31.Show()
        Me.Close()
    End Sub
End Class