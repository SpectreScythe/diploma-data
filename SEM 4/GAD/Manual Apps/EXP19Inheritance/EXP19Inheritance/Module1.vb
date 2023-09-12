Public Class Faculty
    Public Property Name As String
    Public Property ID As Integer
    Public Property Department As String

    Public Sub New(name As String, id As Integer, department As String)
        Me.Name = name
        Me.ID = id
        Me.Department = department
    End Sub

    Public Sub DisplayDetails()
        Console.WriteLine("Name: " & Me.Name)
        Console.WriteLine("ID: " & Me.ID)
        Console.WriteLine("Department: " & Me.Department)
    End Sub
End Class

Public Class Student
    Inherits Faculty

    Public Property Batch As String
    Public Property Semester As Integer

    Public Sub New(name As String, id As Integer, department As String, batch As String, semester As Integer)
        MyBase.New(name, id, department)
        Me.Batch = batch
        Me.Semester = semester
    End Sub

    Public Sub DisplayDetails()
        MyBase.DisplayDetails()
        Console.WriteLine("Batch: " & Me.Batch)
        Console.WriteLine("Semester: " & Me.Semester)
    End Sub
End Class

Module Module1

    Sub Main()
        Dim faculty As New Faculty("John Cena", 1001, "Computer Science")
        faculty.DisplayDetails()

        Dim student As New Student("Rey Mysterio", 2001, "Computer Science", "2022", 4)
        student.DisplayDetails()
        Console.ReadLine()
    End Sub

End Module
