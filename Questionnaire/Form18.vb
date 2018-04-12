Public Class Form18
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form17.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a17 = TextBox1.Text
        a18 = TextBox2.Text
        a19 = TextBox3.Text
        Form19.Show()
        Me.Close()
    End Sub
End Class