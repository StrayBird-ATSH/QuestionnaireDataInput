Public Class Form24
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form23.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a35 = TextBox1.Text
        a36 = TextBox2.Text
        a37 = TextBox3.Text
        Form25.Show()
        Me.Close()
    End Sub
End Class