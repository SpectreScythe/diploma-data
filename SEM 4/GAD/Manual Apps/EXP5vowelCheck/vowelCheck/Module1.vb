Module Module1

    Sub main()

        Dim userInputChar As Char

        userInputChar = InputBox("Enter any character")

        Select Case (userInputChar)
            Case "a"
                Console.WriteLine("The character " & userInputChar & " is an Vowel")
            Case "e"
                Console.WriteLine("The character " & userInputChar & " is an Vowel")
            Case "i"
                Console.WriteLine("The character " & userInputChar & " is an Vowel")
            Case "o"
                Console.WriteLine("The character " & userInputChar & " is an Vowel")
            Case "u"
                Console.WriteLine("The character " & userInputChar & " is an Vowel")
            Case Else
                Console.Write("The character " & userInputChar & " is either a number/special character/ or a consonant")

        End Select

        Console.ReadLine()
    End Sub


End Module
