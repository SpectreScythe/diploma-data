Module Module1
    Class Circle
        Dim r, a As Integer
        Sub New(ByVal r As Integer)
            a = 3.14 * r * r
            Console.WriteLine("Area of a circle : " & a)
        End Sub
    End Class
    Sub Main()
        Console.WriteLine("Spectre Scythe")
        Dim obj As New Circle(7)
        Console.ReadLine()
    End Sub
End Module
