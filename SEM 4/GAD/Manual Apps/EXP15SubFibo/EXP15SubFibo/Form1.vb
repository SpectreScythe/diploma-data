Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fibo()
    End Sub
    Sub fibo()

        Dim n As Integer = Integer.Parse(TextBox1.Text)
        Dim num1 As Integer = 0
        Dim num2 As Integer = 1
        Dim num3 As Integer = 0

        ListBox1.Items.Add(num1)
        ListBox1.Items.Add(num2)
        For i As Integer = 3 To n
            num3 = num1 + num2
            ListBox1.Items.Add(num3)
            num1 = num2
            num2 = num3
        Next

    End Sub
End Class
