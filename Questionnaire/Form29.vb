Public Class Form29
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form28.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a48 = TextBox1.Text
        a49 = TextBox2.Text
        a50 = TextBox3.Text
        Form30.Show()
        Me.Close()
    End Sub
End Class