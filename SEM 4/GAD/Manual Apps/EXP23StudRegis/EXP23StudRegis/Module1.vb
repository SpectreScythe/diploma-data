Imports System
Module Module1
    Sub Main(args As String())
        Try
            Console.WriteLine("Please Enter Student Details:")
            Console.Write("Name: ")
            Dim SName As String = Console.ReadLine()
            Console.Write("RollNo: ")
            Dim rollNo As String = Console.ReadLine()
            Console.Write("Phone No: ")
            Dim phoneNo As String = Console.ReadLine()
            Console.Write("Email ID: ")
            Dim emailID As String = Console.ReadLine()
            If SName = "" Or rollNo = "" Or phoneNo = "" Or emailID = "" Then
                Throw New RequiredFieldException("Please fill in all required fields.")
            ElseIf Not IsNumeric(phoneNo) Or Not IsNumeric(rollNo) Then
                Throw New NumericFieldException("RollNo & PhoneNo must be Numeric")
            End If
            Console.WriteLine("Student record saved successfully.")
        Catch ex As Exception
            Console.WriteLine("Error : " & ex.Message)
        Finally
            Console.ReadLine()
        End Try
    End Sub
End Module
Public Class RequiredFieldException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
Public Class NumericFieldException
    Inherits Exception
    Public Sub New(ByVal message As String)
        MyBase.New(message)
    End Sub
End Class
