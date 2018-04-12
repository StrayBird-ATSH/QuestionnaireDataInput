Public Class Form34
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form33.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a62 = TextBox1.Text
        a63 = TextBox2.Text
        a64 = TextBox3.Text
        Form35.Show()
        Me.Close()
    End Sub
End Class