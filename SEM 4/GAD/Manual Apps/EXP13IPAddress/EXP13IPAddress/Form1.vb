Imports System.Text.RegularExpressions

Public Class Form1

    Sub Main()
        Dim input As String = TextBox1.Text
        Dim pattern As String = "^((0|1?\d{1,2}|2([0-4]\d|5[0-5])).(0|1?\d{1,2}|2([0-4]\d|5[0-5])).(0|1?\d{1,2}|2([0-4]\d|5[0-5])).(0|1?\d{1,2}|2([0-4]\d|5[0-5])))$"
        Dim regex As New Regex(pattern)

        If regex.IsMatch(input) Then
            MsgBox("Valid input.")
        Else
            MsgBox("Invalid input.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.ForeColor = Color.GhostWhite
        Button1.ForeColor = Color.FromArgb(30, 30, 30)
    End Sub
End Class
