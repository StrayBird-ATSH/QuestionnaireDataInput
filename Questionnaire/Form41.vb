﻿Public Class Form41
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form40.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a77 = TextBox1.Text
        a78 = TextBox2.Text
        Form42.Show()
        Me.Close()
    End Sub
End Class