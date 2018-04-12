Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Show()
        Me.Close()
    End Sub


    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a10 = TextBox1.Text
        Form12.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class