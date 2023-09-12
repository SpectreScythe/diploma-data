Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked And CheckBox2.Checked Then
            Label1.Text = Concat(CheckBox1.Text, CheckBox2.Text)
        ElseIf CheckBox1.Checked Then
            Label1.Text = Concat(CheckBox1.Text)
        ElseIf CheckBox2.Checked Then
            Label1.Text = Concat(CheckBox2.Text)
        End If
    End Sub
    Public Function Concat(ByVal str As String) As String
        Return "Spectre" & " " & str
    End Function
    Public Function Concat(ByVal strA As String, ByVal strB As String) As String
        Return "Spectre" & " " & strA & " " & strB
    End Function
End Class
