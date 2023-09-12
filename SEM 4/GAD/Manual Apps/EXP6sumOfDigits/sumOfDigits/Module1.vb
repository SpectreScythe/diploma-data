Module Module1

    Sub Main()

        Dim number As Integer
        Dim r As Integer
        Dim sum As Integer

        number = InputBox("Enter your desired number")

        Do
            r = number Mod 10
            sum = sum + r
            number = number / 10
        Loop While(number <> 0)

        Console.WriteLine("The sum of the digits of the number is :" & sum)

        Console.ReadLine()


    End Sub

End Module
