Module Module1
    Class Line
        Private l As Double
        Public Sub New()
            Console.WriteLine("Loading terrain...")
        End Sub
        Public Sub setlength(ByVal len As Double)
            l = len
        End Sub
        Public Function getLength() As Double
            Return l
        End Function
    End Class
    Sub Main()
        Console.WriteLine("Spectre Scythe")
        Dim L As Line = New Line()
        L.setlength(7.0)
        Console.WriteLine("Length Of line:{0}", L.getLength())
        Console.ReadKey()
    End Sub
End Module
