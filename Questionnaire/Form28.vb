﻿Public Class Form28
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form27.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a45 = TextBox1.Text
        a46 = TextBox2.Text
        a47 = TextBox3.Text
        Form29.Show()
        Me.Close()
    End Sub
End Class