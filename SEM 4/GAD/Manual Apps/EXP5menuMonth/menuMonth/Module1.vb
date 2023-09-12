Module Module1

    Sub Main()
        Dim choice As Integer
        choice = InputBox("Enter your choice")

        Select Case (choice)

            Case 1
                Console.WriteLine("Jan")

            Case 2
                Console.WriteLine("Feb")

            Case 3
                Console.WriteLine("Mar")

            Case 4
                Console.WriteLine("Apr")

            Case 5
                Console.WriteLine("May")

            Case 6
                Console.WriteLine("Jun")

            Case 7
                Console.WriteLine("Jul")

            Case 8
                Console.WriteLine("Aug")

            Case 9
                Console.WriteLine("Sep")

            Case 10
                Console.WriteLine("Oct")

            Case 11
                Console.WriteLine("Nov")

            Case 12
                Console.WriteLine("Dec")

        End Select

        Console.ReadLine()

    End Sub

End Module
