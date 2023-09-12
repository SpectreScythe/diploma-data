Imports System.Text.RegularExpressions

Public Class Form1

    Sub checking()
        Dim input As String = TextBox1.Text
        Dim emailPattern As String = ("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Dim regex As New Regex(emailPattern)

        If regex.IsMatch(input) Then
            MsgBox("Valid email address")
        Else
            MsgBox("Invalid email address")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(25, 25, 25)
        Me.ForeColor = Color.GhostWhite
        Button1.ForeColor = Color.FromArgb(25, 25, 25)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        checking()
    End Sub

End Class
