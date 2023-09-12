
Module Module1
    Sub Main()
        Dim userNum, remainder, rev, i As Integer
        rev = 0
        userNum = InputBox("Enter your desired number")

        i = userNum

        Do

            remainder = userNum Mod 10

            rev = (rev * 10) + remainder

            userNum = userNum / 10

        Loop While userNum > 0

        Console.WriteLine("The reverse of the number " & i & " is " & rev)

        Console.ReadLine()

    End Sub
End Module
