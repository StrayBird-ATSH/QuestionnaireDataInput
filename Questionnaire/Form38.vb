﻿Public Class Form38
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form37.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a71 = TextBox1.Text
        a72 = TextBox2.Text
        Form39.Show()
        Me.Close()
    End Sub
End Class