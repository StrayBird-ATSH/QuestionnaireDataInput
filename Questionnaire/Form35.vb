Public Class Form35
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form34.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a65 = TextBox1.Text
        a66 = TextBox2.Text
        a67 = TextBox3.Text
        Form36.Show()
        Me.Close()
    End Sub
End Class