Public Class Form25
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form24.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a38 = TextBox1.Text
        a39 = TextBox2.Text
        a40 = TextBox3.Text
        Form26.Show()
        Me.Close()
    End Sub
End Class