Public Class Form31
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form30.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a54 = TextBox1.Text
        a55 = TextBox2.Text
        Form32.Show()
        Me.Close()
    End Sub
End Class