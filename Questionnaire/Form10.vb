Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a9 = TextBox1.Text
        b9 = TextBox2.Text
        Form11.Show()
        Me.Close()
    End Sub
End Class