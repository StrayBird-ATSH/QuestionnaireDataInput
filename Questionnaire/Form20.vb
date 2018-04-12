Public Class Form20
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form19.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a23 = TextBox1.Text
        a24 = TextBox2.Text
        a25 = TextBox3.Text
        Form21.Show()
        Me.Close()
    End Sub
End Class