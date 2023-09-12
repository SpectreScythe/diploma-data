Module Module1

    Sub Main()

        Dim n As Integer
        n = InputBox("Enter number of rows")
        For i As Integer = 1 To n
            For j As Integer = 1 To n - i
                Console.Write(" ")
            Next
            For j As Integer = 1 To i
                Console.Write(" * ")
            Next
            Console.WriteLine(" ")
        Next

        Console.ReadLine()
    End Sub

End Module
