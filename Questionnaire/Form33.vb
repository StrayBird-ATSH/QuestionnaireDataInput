Public Class Form33
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form32.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a59 = TextBox1.Text
        a60 = TextBox2.Text
        a61 = TextBox3.Text
        Form34.Show()
        Me.Close()
    End Sub
End Class