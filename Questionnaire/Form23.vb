﻿Public Class Form23
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form22.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        a32 = TextBox1.Text
        a33 = TextBox2.Text
        a34 = TextBox3.Text
        Form24.Show()
        Me.Close()
    End Sub
End Class