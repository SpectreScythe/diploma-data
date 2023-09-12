Module Module1
    Sub Main(args As String())
        Dim student As New Student("Spectre", "Scythe", 210451, "spectre8643@gmail.com")
        student.Display()
        Console.ReadLine()
    End Sub
End Module
Public Class Person
    Protected firstName As String
    Protected lastName As String
    Public Sub New(firstName As String, lastName As String)
        Me.firstName = firstName
        Me.lastName = lastName
    End Sub
    Public Overridable Sub Display()
        Console.WriteLine("Name: {0} {1}", firstName, lastName)
    End Sub
End Class
Public Class Student
    Inherits Person
    Private rollNo As Integer
    Private email As String
    Public Sub New(firstName As String, lastName As String, rollno As Integer, email As String)
        MyBase.New(firstName, lastName)
        Me.rollNo = rollNo
        Me.email = email
    End Sub
    Public Shadows Sub Display()
        Console.WriteLine("Name: {0} {1}", firstName, lastName)
        Console.WriteLine("Roll No: {0}", rollNo)
        Console.WriteLine("Email: {0}", email)
    End Sub
End Class
