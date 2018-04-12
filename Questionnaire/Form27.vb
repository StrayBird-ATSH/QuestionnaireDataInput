Public Class Form27
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form26.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a44 = TextBox1.Text
        Form28.Show()
        Me.Close()
    End Sub
End Class