Public Class Form1

    Function GetMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        If num1 > num2 Then
            Return num1
        Else
            Return num2
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim G As Integer = GetMax(Integer.Parse(TextBox1.Text), Integer.Parse(TextBox2.Text))
        Label2.Text = "Greater Number --> " & G
    End Sub
End Class
