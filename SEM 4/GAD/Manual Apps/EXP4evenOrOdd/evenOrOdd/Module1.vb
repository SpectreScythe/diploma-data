Module Module1

    Sub Main()

        Dim userN As Integer

        userN = InputBox("Enter any number to check:")

        If userN Mod 2 = 0 Then
            Console.WriteLine("The entered number " & userN & " is an Even number")
        Else
            Console.WriteLine("The entered number " & userN & " is an Odd number")
        End If
        Console.ReadLine()

    End Sub

End Module
