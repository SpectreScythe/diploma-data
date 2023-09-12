Module Module1

    Sub Main()
        Dim numArray As Integer() = {7, 3, 6, 2, 9}
        Dim num As Integer

        For Each num In numArray
            Console.WriteLine("The square of " & num & " is " & num * num)
        Next

        Console.ReadLine()
    End Sub

End Module