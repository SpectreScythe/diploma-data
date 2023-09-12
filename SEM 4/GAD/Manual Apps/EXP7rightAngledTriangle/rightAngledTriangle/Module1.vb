Module Module1

    Sub Main()
        Dim n As Integer
        n = InputBox("Enter number of rows")
        Dim ch As Char
        ch = InputBox("Enter your desired character")
        For i As Integer = 0 To n
            For j As Integer = 0 To i
                Console.Write(ch)
            Next
            Console.WriteLine("  ")
        Next
        Console.ReadLine()
    End Sub

End Module
