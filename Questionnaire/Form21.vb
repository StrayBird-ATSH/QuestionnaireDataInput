Public Class Form21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form20.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a26 = TextBox1.Text
        a27 = TextBox2.Text
        a28 = TextBox3.Text
        Form22.Show()
        Me.Close()
    End Sub
End Class