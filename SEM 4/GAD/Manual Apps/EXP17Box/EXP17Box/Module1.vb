Class Box
    Private length As Double
    Private breadth As Double
    Private height As Double

    Public Sub New(ByVal l As Double, ByVal b As Double, ByVal h As Double)
        length = l
        breadth = b
        height = h
    End Sub

    Public Function Volume() As Double
        Return length * breadth * height
    End Function
End Class

Module Module1
    Sub Main()
        Dim myBox As Box = New Box(5, 10, 15)

        Dim volume As Double = myBox.Volume()

        MsgBox("The volume of the box is: " & volume)

    End Sub
End Module
