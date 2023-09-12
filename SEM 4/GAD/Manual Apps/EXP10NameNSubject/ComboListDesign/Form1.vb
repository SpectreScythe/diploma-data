Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count As Integer
        Label4.Text &= ComboBox1.SelectedItem.ToString()
        For Each element In ListBox1.SelectedItems
            Label3.Text &= element & vbCrLf & "              "
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(30, 30, 30)
        Me.Font = New Font("Comic Sans MS", 14.0)
        Me.Text = "EXP10ListBoxNComboBox"
        Label1.ForeColor = Color.AntiqueWhite
        Label2.ForeColor = Color.AntiqueWhite
        Label3.ForeColor = Color.AntiqueWhite
        Label4.ForeColor = Color.AntiqueWhite
    End Sub
End Class
