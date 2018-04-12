Public Class Form12
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a11 = TextBox1.Text
        Form13.Show()
        Me.Close()
    End Sub
End Class