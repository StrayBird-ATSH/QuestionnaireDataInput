Public Class Form19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form18.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a20 = TextBox1.Text
        a21 = TextBox2.Text
        a22 = TextBox3.Text
        Form20.Show()
        Me.Close()
    End Sub
End Class