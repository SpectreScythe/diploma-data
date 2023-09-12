Imports System.Text.RegularExpressions
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(25, 25, 25)
        Me.ForeColor = Color.GhostWhite
        Button1.ForeColor = Color.FromArgb(25, 25, 25)
    End Sub

    Sub Main()
        Dim birthdayRegex As New Regex("^(0[1-9]|1[0-2])\/(0[1-9]|[12][0-9]|3[01])\/\d{4}$")
        Dim birthday As String = TextBox1.Text
        If birthdayRegex.IsMatch(birthday) Then
            MsgBox("Valid birthday")
        Else
            MsgBox("Invalid birthday - Birthday Format = (MM/DD/YYYY) OR Extreme Dates")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Main()
    End Sub
End Class
