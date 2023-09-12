Public Class Form1

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gold Roger\Documents\FoodHub_DB.mdb")
    'Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mohammed Zaid\source\repos\WindowsApp1\Database1.accdb
    Dim com As New OleDb.OleDbCommand("Select * from FoodHubUsers", con)
    Dim da As New OleDb.OleDbDataAdapter(com)
    Dim ds As New DataSet
    Dim dt As New DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        da.Fill(dt)
        'da.Fill(ds)
        DataGridView1.DataSource = dt

    End Sub
End Class
