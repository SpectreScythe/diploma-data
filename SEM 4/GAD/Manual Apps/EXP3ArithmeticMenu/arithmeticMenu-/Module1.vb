Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer
        Dim c As Char

        a = InputBox("Enter first Number")
        b = InputBox("Enter Second Number")

        c = InputBox("Enter operator")

        Select Case (c)

            Case "+"
                Console.WriteLine("Addition = " & a + b)

            Case "-"
                Console.WriteLine("Addition = " & a - b)

            Case "*"
                Console.WriteLine("Addition = " & a * b)

            Case "/"
                Console.WriteLine("Addition = " & a / b)
        End Select
        Console.ReadLine()

    End Sub

End Module
