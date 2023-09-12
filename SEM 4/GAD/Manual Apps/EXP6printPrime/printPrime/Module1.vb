Module Module1

    Sub Main()

        Dim i, j, count, n As Integer

        i = 1
        n = 0
        count = 0

        Console.WriteLine("Prime numbers between 1 to 100 ")

        While n < 100

            count = 0

            j = 1

            While j <= i

                If i Mod j = 0 Then

                    count = count + 1

                End If

                j = j + 1

            End While

            If count = 2 Then

                Console.Write(i & " ")

            End If

            i = i + 1
            n = n + 1

        End While

        Console.ReadLine()

    End Sub

End Module