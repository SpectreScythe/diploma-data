Module GreatestOfThree

    Sub Main()

        Dim A As Integer
        Dim B As Integer
        Dim C As Integer

        A = InputBox("Enter Value For A:")
        B = InputBox("Enter Value For B:")
        C = InputBox("Enter Value For C:")

        If A > B Then

            If A > C Then

                MsgBox("A = " & A & " is the Greatest")

            Else

                MsgBox("C = " & C & " is the Greatest")

            End If

        ElseIf B > C Then

            MsgBox("B = " & B & " is the Greatest")

        Else

            MsgBox("C = " & C & " is the Greatest")

        End If

    End Sub

End Module
