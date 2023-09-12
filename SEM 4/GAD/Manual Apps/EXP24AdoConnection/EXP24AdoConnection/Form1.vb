Imports System.Data.OleDb

Public Class Form1

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            connection.Open()
            MsgBox("Connected successfully!!")
        Catch ex As Exception
            MsgBox("Failed")

        End Try

    End Sub
End Class