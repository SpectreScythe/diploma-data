Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(InputBox("Enter A Value : "))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Sorted Then
            Button3.Text = "Unsort"
            ListBox1.Sorted = False
        Else
            Button3.Text = "Sort"
            ListBox1.Sorted = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Remove(ListBox1.SelectedIndex)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Count : " & ListBox1.Items.Count)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromArgb(29, 29, 29)
        Me.Font = New Font("Comic Sans MS", 10.0)
        Me.Text = "EXP10ListBoxControls"
    End Sub
End Class
