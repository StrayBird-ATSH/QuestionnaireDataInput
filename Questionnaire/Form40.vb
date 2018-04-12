Public Class Form40
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form39.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a75 = TextBox1.Text
        a76 = TextBox2.Text
        Form41.Show()
        Me.Close()
    End Sub
End Class