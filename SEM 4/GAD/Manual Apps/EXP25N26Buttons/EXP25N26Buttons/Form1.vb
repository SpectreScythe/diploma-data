Imports System.Data.OleDb
Public Class Form1

    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim MaxRows, inc As Integer

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb")
    Dim com As New OleDb.OleDbCommand("Select * from FoodHubUsers", con)

    Dim dt As New DataTable
    Dim da As New OleDb.OleDbDataAdapter(com)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb")
        conn.Open()

        da.Fill(dt)
        'da.Fill(ds)
        DataGridView1.DataSource = dt


        cmd = New OleDbCommand("select * from Table1", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "Table1")

        reader = cmd.ExecuteReader()
        reader.Read()
        TextBox1.Text = reader.GetValue(0)
        TextBox2.Text = reader.GetValue(1)
        TextBox3.Text = reader.GetValue(3)
        TextBox4.Text = reader.GetValue(4)
        MaxRows = ds.Tables("Table1").Rows.Count
        inc = 0

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click    ' Move to Next record

        If inc <> MaxRows - 1 Then
            inc = inc + 1
            TextBox1.Text = ds.Tables("Table1").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("Table1").Rows(inc).Item(1)
            TextBox3.Text = ds.Tables("Table1").Rows(inc).Item(3)
            TextBox4.Text = ds.Tables("Table1").Rows(inc).Item(4)
        Else
            MessageBox.Show("No More Rows")
        End If

    End Sub
    ' Move to Previous Record
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If inc > -1 Then
            inc = inc - 1
            TextBox1.Text = ds.Tables("Table1").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("Table1").Rows(inc).Item(1)
            TextBox3.Text = ds.Tables("Table1").Rows(inc).Item(3)
            TextBox4.Text = ds.Tables("Table1").Rows(inc).Item(4)
        Else
            MessageBox.Show("First Record")

        End If

    End Sub
    ' Move to Last record
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If inc <> MaxRows - 1 Then
            inc = MaxRows - 1
            TextBox1.Text = ds.Tables("Table1").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("Table1").Rows(inc).Item(1)
            TextBox3.Text = ds.Tables("Table1").Rows(inc).Item(3)
            TextBox4.Text = ds.Tables("Table1").Rows(inc).Item(4)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' Move to First Record

        If inc <> 0 Then
            inc = 0
            TextBox1.Text = ds.Tables("Table1").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("Table1").Rows(inc).Item(1)
            TextBox3.Text = ds.Tables("Table1").Rows(inc).Item(3)
            TextBox4.Text = ds.Tables("Table1").Rows(inc).Item(4)
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub
End Class