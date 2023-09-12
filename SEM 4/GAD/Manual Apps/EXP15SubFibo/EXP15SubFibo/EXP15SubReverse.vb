Public Class EXP15SubReverse
    Sub Rev()

        Dim number As Integer = Integer.Parse(TextBox1.Text)

        Dim reversedNumber As Integer = 0
        While number > 0
            reversedNumber = reversedNumber * 10 + number Mod 10
            number = number \ 10
        End While

        Label2.Text = reversedNumber

        Console.ReadLine()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Rev()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
    End Sub
End Class