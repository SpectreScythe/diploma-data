Public Class Form1

    Function Fact(ByVal number As Integer) As Integer
        If number <= 1 Then
            Return 1
        Else
            Return number * Fact(number - 1)
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Factorial As Integer = Fact(Integer.Parse(TextBox1.Text))
        Label2.Text = Factorial
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
End Class
