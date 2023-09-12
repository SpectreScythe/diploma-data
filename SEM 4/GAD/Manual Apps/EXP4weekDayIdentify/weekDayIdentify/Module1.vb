Module Module1

    Sub Main()

        Dim userInputDay As Integer

        userInputDay = InputBox("Enter a number for the week day from 1 - 7")

        If userInputDay = 1 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Monday")
        ElseIf userInputDay = 2 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Tuesday")
        ElseIf userInputDay = 3 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Wednesday")
        ElseIf userInputDay = 4 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Thurday")
        ElseIf userInputDay = 5 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Friday")
        ElseIf userInputDay = 6 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Saturday")
        ElseIf userInputDay = 7 Then
            Console.WriteLine("The entered number " & userInputDay & " belongs to Sunday")
        End If

        Console.ReadLine()

    End Sub

End Module
