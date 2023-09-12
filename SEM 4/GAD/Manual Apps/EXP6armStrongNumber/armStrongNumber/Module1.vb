Module Module1

    Sub Main()
        Dim n, r, m, sum, temp As Integer
        n = InputBox("Enter an integer")
        temp = n
        sum = 0


        Do
            r = n Mod 10
            sum = sum + (r * r * r)
            n = n \ 10

        Loop While (n > 0)

        If temp = sum Then
            Console.WriteLine(temp & " is armstrong")
        Else
            Console.WriteLine(temp & " not armstrong")
        End If

        Console.ReadLine()
    End Sub

End Module
