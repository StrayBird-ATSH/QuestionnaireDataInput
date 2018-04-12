Imports Microsoft.Office.Interop
Public Class Form42
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form41.Show()
        Me.Close()
    End Sub

    Private Sub Button2_GotFocus(sender As Object, e As EventArgs) Handles Button2.GotFocus
        Dim newxls As Excel.Application
        Dim newbook As Excel.Workbook
        Dim newsheet As Excel.Worksheet
        a79 = TextBox1.Text
        a80 = TextBox2.Text
        Form43.Show()
        newxls = New Excel.Application
        If Dir("D:\sheet.xlsx") = "" Then
            Dim lineNumber As String
            lineNumber = "1"
            newbook = newxls.Workbooks.Add
            newsheet = newbook.Worksheets(1)
            newsheet.Range("a1").Value = a1
            newsheet.Range("b1").Value = a2
            newsheet.Range("c1").Value = b2
            newsheet.Range("d1").Value = a3
            newsheet.Range("e1").Value = a4
            newsheet.Range("f1").Value = a5
            newsheet.Range("g1").Value = a6
            newsheet.Range("h1").Value = a7
            newsheet.Range("i1").Value = a8
            newsheet.Range("j1").Value = b8
            newsheet.Range("k1").Value = a9
            newsheet.Range("l1").Value = b9
            newsheet.Range("m1").Value = a10
            newsheet.Range("n1").Value = a11
            newsheet.Range("o1").Value = a12
            newsheet.Range("p1").Value = a13
            newsheet.Range("q1").Value = a14
            newsheet.Range("r1").Value = a15
            newsheet.Range("s1").Value = a16
            newsheet.Range("t1").Value = a17
            newsheet.Range("u1").Value = a18
            newsheet.Range("v1").Value = a19
            newsheet.Range("w1").Value = a20
            newsheet.Range("x1").Value = a21
            newsheet.Range("y1").Value = a22
            newsheet.Range("z1").Value = a23
            newsheet.Range("aa1").Value = a24
            newsheet.Range("ab1").Value = a25
            newsheet.Range("ac1").Value = a26
            newsheet.Range("ad1").Value = a27
            newsheet.Range("ae1").Value = a28
            newsheet.Range("af1").Value = a29
            newsheet.Range("ag1").Value = a30
            newsheet.Range("ah1").Value = a31
            newsheet.Range("ai1").Value = a32
            newsheet.Range("aj1").Value = a33
            newsheet.Range("ak1").Value = a34
            newsheet.Range("al1").Value = a35
            newsheet.Range("am1").Value = a36
            newsheet.Range("an1").Value = a37
            newsheet.Range("ao1").Value = a38
            newsheet.Range("ap1").Value = a38
            newsheet.Range("aq1").Value = a40
            newsheet.Range("ar1").Value = a41
            newsheet.Range("as1").Value = a42
            newsheet.Range("at1").Value = a43
            newsheet.Range("au1").Value = a44
            newsheet.Range("av1").Value = a45
            newsheet.Range("aw1").Value = a46
            newsheet.Range("ax1").Value = a47
            newsheet.Range("ay1").Value = a48
            newsheet.Range("az" + lineNumber).Value = a49
            newsheet.Range("ba" + lineNumber).Value = a50
            newsheet.Range("bb" + lineNumber).Value = a51
            newsheet.Range("bc" + lineNumber).Value = a52
            newsheet.Range("bd" + lineNumber).Value = a53
            newsheet.Range("be" + lineNumber).Value = a54
            newsheet.Range("bf" + lineNumber).Value = a55
            newsheet.Range("bg" + lineNumber).Value = a56
            newsheet.Range("bh" + lineNumber).Value = a57
            newsheet.Range("bi" + lineNumber).Value = a58
            newsheet.Range("bj" + lineNumber).Value = a59
            newsheet.Range("bk" + lineNumber).Value = a60
            newsheet.Range("bl" + lineNumber).Value = a61
            newsheet.Range("bm" + lineNumber).Value = a62
            newsheet.Range("bn" + lineNumber).Value = a63
            newsheet.Range("bo" + lineNumber).Value = a64
            newsheet.Range("bp" + lineNumber).Value = a65
            newsheet.Range("bq" + lineNumber).Value = a66
            newsheet.Range("br" + lineNumber).Value = a67
            newsheet.Range("bs" + lineNumber).Value = a68
            newsheet.Range("bt" + lineNumber).Value = a69
            newsheet.Range("bu" + lineNumber).Value = a70
            newsheet.Range("bv" + lineNumber).Value = a71
            newsheet.Range("bw" + lineNumber).Value = a72
            newsheet.Range("bx" + lineNumber).Value = a73
            newsheet.Range("by" + lineNumber).Value = a74
            newsheet.Range("bz" + lineNumber).Value = a75
            newsheet.Range("ca" + lineNumber).Value = a76
            newsheet.Range("cb" + lineNumber).Value = a77
            newsheet.Range("cc" + lineNumber).Value = a78
            newsheet.Range("cd" + lineNumber).Value = a79
            newsheet.Range("ce" + lineNumber).Value = a80
            newsheet.Range("cf" + lineNumber).Value = sisters
            newsheet.SaveAs("D:\sheet.xlsx")
            newxls.Quit()
            Form43.Show()
            Me.Close()
        Else
            newbook = newxls.Workbooks.Open("D:\sheet.xlsx")
            newsheet = newbook.Worksheets(1)
            Dim lineNumber1 As Int64
            lineNumber1 = 1
            Dim content As String
            content = newsheet.Range("a1").Value
            While (content <> "")
                lineNumber1 = lineNumber1 + 1
                content = newsheet.Range(Replace("a" + Str(lineNumber1), " ", "")).Value
            End While
            Dim linenumber As String
            linenumber = lineNumber1
            newsheet.Range("a" + linenumber).Value = a1
            newsheet.Range("b" + linenumber).Value = a2
            newsheet.Range("c" + linenumber).Value = b2
            newsheet.Range("d" + linenumber).Value = a3
            newsheet.Range("e" + linenumber).Value = a4
            newsheet.Range("f" + linenumber).Value = a5
            newsheet.Range("g" + linenumber).Value = a6
            newsheet.Range("h" + linenumber).Value = a7
            newsheet.Range("i" + linenumber).Value = a8
            newsheet.Range("j" + linenumber).Value = b8
            newsheet.Range("k" + linenumber).Value = a9
            newsheet.Range("l" + linenumber).Value = b9
            newsheet.Range("m" + linenumber).Value = a10
            newsheet.Range("n" + linenumber).Value = a11
            newsheet.Range("o" + linenumber).Value = a12
            newsheet.Range("p" + linenumber).Value = a13
            newsheet.Range("q" + linenumber).Value = a14
            newsheet.Range("r" + linenumber).Value = a15
            newsheet.Range("s" + linenumber).Value = a16
            newsheet.Range("t" + linenumber).Value = a17
            newsheet.Range("u" + linenumber).Value = a18
            newsheet.Range("v" + linenumber).Value = a19
            newsheet.Range("w" + linenumber).Value = a20
            newsheet.Range("x" + linenumber).Value = a21
            newsheet.Range("y" + linenumber).Value = a22
            newsheet.Range("z" + linenumber).Value = a23
            newsheet.Range("aa" + linenumber).Value = a24
            newsheet.Range("ab" + linenumber).Value = a25
            newsheet.Range("ac" + linenumber).Value = a26
            newsheet.Range("ad" + linenumber).Value = a27
            newsheet.Range("ae" + linenumber).Value = a28
            newsheet.Range("af" + linenumber).Value = a29
            newsheet.Range("ag" + linenumber).Value = a30
            newsheet.Range("ah" + linenumber).Value = a31
            newsheet.Range("ai" + linenumber).Value = a32
            newsheet.Range("aj" + linenumber).Value = a33
            newsheet.Range("ak" + linenumber).Value = a34
            newsheet.Range("al" + linenumber).Value = a35
            newsheet.Range("am" + linenumber).Value = a36
            newsheet.Range("an" + linenumber).Value = a37
            newsheet.Range("ao" + linenumber).Value = a38
            newsheet.Range("ap" + linenumber).Value = a38
            newsheet.Range("aq" + linenumber).Value = a40
            newsheet.Range("ar" + linenumber).Value = a41
            newsheet.Range("as" + linenumber).Value = a42
            newsheet.Range("at" + linenumber).Value = a43
            newsheet.Range("au" + linenumber).Value = a44
            newsheet.Range("av" + linenumber).Value = a45
            newsheet.Range("aw" + linenumber).Value = a46
            newsheet.Range("ax" + linenumber).Value = a47
            newsheet.Range("ay" + linenumber).Value = a48
            newsheet.Range("az" + linenumber).Value = a49
            newsheet.Range("ba" + linenumber).Value = a50
            newsheet.Range("bb" + linenumber).Value = a51
            newsheet.Range("bc" + linenumber).Value = a52
            newsheet.Range("bd" + linenumber).Value = a53
            newsheet.Range("be" + linenumber).Value = a54
            newsheet.Range("bf" + linenumber).Value = a55
            newsheet.Range("bg" + linenumber).Value = a56
            newsheet.Range("bh" + linenumber).Value = a57
            newsheet.Range("bi" + linenumber).Value = a58
            newsheet.Range("bj" + linenumber).Value = a59
            newsheet.Range("bk" + linenumber).Value = a60
            newsheet.Range("bl" + linenumber).Value = a61
            newsheet.Range("bm" + linenumber).Value = a62
            newsheet.Range("bn" + linenumber).Value = a63
            newsheet.Range("bo" + linenumber).Value = a64
            newsheet.Range("bp" + linenumber).Value = a65
            newsheet.Range("bq" + linenumber).Value = a66
            newsheet.Range("br" + linenumber).Value = a67
            newsheet.Range("bs" + linenumber).Value = a68
            newsheet.Range("bt" + linenumber).Value = a69
            newsheet.Range("bu" + linenumber).Value = a70
            newsheet.Range("bv" + linenumber).Value = a71
            newsheet.Range("bw" + linenumber).Value = a72
            newsheet.Range("bx" + linenumber).Value = a73
            newsheet.Range("by" + linenumber).Value = a74
            newsheet.Range("bz" + linenumber).Value = a75
            newsheet.Range("ca" + linenumber).Value = a76
            newsheet.Range("cb" + linenumber).Value = a77
            newsheet.Range("cc" + linenumber).Value = a78
            newsheet.Range("cd" + linenumber).Value = a79
            newsheet.Range("ce" + linenumber).Value = a80
            newsheet.Range("cf" + linenumber).Value = sisters
            newsheet.SaveAs("D:\sheet1.xlsx")
            newbook.Close()
            newxls.Quit()
            Kill("D:\sheet.xlsx")
            Form43.Show()
            Me.Close()
            Rename("D:\sheet1.xlsx", "D:\sheet.xlsx")
        End If
    End Sub
End Class