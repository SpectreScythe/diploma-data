Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Form1
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public cmd2 As OleDbCommand
    Public adp As OleDbDataAdapter
    Public dt As New DataTable


    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\stud.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)
    Dim com As New OleDb.OleDbCommand("Select * from Table1", connection)
    Dim da As New OleDb.OleDbDataAdapter(com)
    Dim ds As New DataSet
    Dim dt1 As New DataTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Rollno")
        Else
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\stud.mdb;")
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "select * from Table1 where rno=" & TextBox1.Text & ""
            adp = New OleDbDataAdapter(cmd)
            adp.Fill(dt)
            If dt.Rows.Count() > 0 Then
                TextBox2.Text = dt.Rows(0)(1).ToString
                TextBox3.Text = dt.Rows(0)(2).ToString
                TextBox4.Text = dt.Rows(0)(3).ToString
            End If
        End If
        con.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\stud.mdb;")
        con.Open()
        cmd = con.CreateCommand
        cmd.CommandText = "insert into Table1(name,gender,rollno,phnnum)values(' " + TextBox1.Text + "',' " + TextBox2.Text + "',' " + TextBox3.Text + "',' " + TextBox4.Text + "')"
        cmd.ExecuteNonQuery()
        MsgBox("Inserted")
        con.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Deleted")
        Else
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\stud.mdb;Initial Catalog=gad_pracs;IntegratedSecurity=True")
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "delete from Table1 where rno=" & TextBox1.Text & ""
            cmd.ExecuteNonQuery()
            MsgBox("Deleted")
            con.Close()
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter rollno")
        Else
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\stud.mdb;")
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandText = "update Table1 set name= '" & TextBox2.Text & "',gender='" & TextBox3.Text & " ',rollno='" & TextBox4.Text & " 'where phnnum= '" & TextBox1.Text & "'"
            cmd.ExecuteNonQuery()
            MsgBox("Updated")
            con.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()
        da.Fill(dt1)
        'da.Fill(ds)
        DataGridView1.DataSource = dt1
        connection.Close()

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class