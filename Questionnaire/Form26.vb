Public Class Form26
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form25.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a41 = TextBox1.Text
        a42 = TextBox2.Text
        a43 = TextBox3.Text
        Form27.Show()
        Me.Close()
    End Sub
End Class