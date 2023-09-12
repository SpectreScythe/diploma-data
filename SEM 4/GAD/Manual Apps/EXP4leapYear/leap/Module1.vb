Module Module1

    Sub Main()
        Dim year As Integer
        year = InputBox("Enter any year to check")

        If (year Mod 400 = 0) Then
            MsgBox(year & " is a leap year")
        ElseIf (year Mod 4 = 0) Then
            MsgBox(year & " is a leap year")
        Else
            MsgBox(year & " is not a leap year")


        End If
    End Sub

End Module
