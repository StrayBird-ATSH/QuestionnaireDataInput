﻿Public Class Form39
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form38.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a73 = TextBox1.Text
        a74 = TextBox2.Text
        Form40.Show()
        Me.Close()
    End Sub
End Class