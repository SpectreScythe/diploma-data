Module Module1

    Sub Main()
        Dim n, t, r As Integer

        r = 0

        n = InputBox("Enter your desired number")

        t = n

        While (t <> 0)
            r = r * 10
            r = r + t Mod 10
            t = t / 10
        End While
        If n = r Then
            Console.WriteLine("The entered number " & n & " is a palindrome")

        Else
            Console.WriteLine("The entered number " & n & " is not a palindrome")

        End If

        Console.ReadLine()

    End Sub

End Module
