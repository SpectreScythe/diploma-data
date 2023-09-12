Imports System.Data.OleDb

Public Class Form1
    Public con As OleDbConnection
    Public cmd As OleDbCommand
    Public adp As OleDbDataAdapter
    Public ds As New DataSet

    Dim con1 = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb;")
    Dim com As New OleDb.OleDbCommand("Select * from FoodHubUsers", con1)
    Dim da As New OleDb.OleDbDataAdapter(com)
    Dim ds1 As New DataSet
    Dim dt As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb;")
        con.Open()
        cmd = con.CreateCommand
        cmd.CommandText = "select * from FoodHubUsers"
        adp = New OleDbDataAdapter(cmd)
        adp.Fill(ds, "FoodHubUsers")
        ComboBox1.DataSource = ds.Tables("FoodHubUsers")
        ComboBox2.DataSource = ds.Tables("FoodHubUsers")
        ComboBox3.DataSource = ds.Tables("FoodHubUsers")
        ComboBox4.DataSource = ds.Tables("FoodHubUsers")
        ComboBox1.DisplayMember = "UserName"
        ComboBox2.DisplayMember = "EmailID"
        ComboBox3.DisplayMember = "PhoneNumber"
        ComboBox4.DisplayMember = "Password"

        con1.Open()
        da.Fill(dt)
        'da.Fill(ds)
        DataGridView1.DataSource = dt
        con1.Close()

    End Sub
End Class