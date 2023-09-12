Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "EXP12TabControl"
        Me.BackColor = Color.GhostWhite

        TabPage1.BackColor = Color.GhostWhite
        TabPage2.BackColor = Color.FromArgb(29, 29, 29)
        TabPage1.BackColor = Color.FromArgb(29, 29, 29)
        Label3.ForeColor = Color.GhostWhite
        Label4.ForeColor = Color.GhostWhite
        Button1.ForeColor = Color.FromArgb(29, 29, 29)
        Button2.ForeColor = Color.FromArgb(29, 29, 29)

    End Sub

    Private Sub FactBtn_Click(sender As Object, e As EventArgs) Handles FactBtn.Click

        Dim n As Integer = FactInput.Text
        Dim resultFact As Integer = 1
        For i As Integer = 1 To n
            resultFact *= i
        Next

        ansFact.Text = resultFact

    End Sub

    Private Sub FiboBtn_Click(sender As Object, e As EventArgs) Handles FiboBtn.Click

        Dim n As Integer = fiboInput.Text
        Dim c As Integer

        For i As Integer = 0 To n
            c += i
        Next

        ansFibo.Text = c

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Button1.Image.Equals(My.Resources.LM1) Then

            Button1.Image = My.Resources.DM1
            TabPage1.BackColor = Color.FromArgb(29, 29, 29)
            Label1.ForeColor = Color.GhostWhite
            Label2.ForeColor = Color.GhostWhite
            Button1.ForeColor = Color.FromArgb(29, 29, 29)
            Button2.ForeColor = Color.FromArgb(29, 29, 29)

        Else

            Button1.Image = My.Resources.LM1
            TabPage1.BackColor = Color.GhostWhite
            Label1.ForeColor = Color.FromArgb(29, 29, 29)
            Label2.ForeColor = Color.FromArgb(29, 29, 29)
            Button1.ForeColor = Color.GhostWhite
            Button2.ForeColor = Color.GhostWhite

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If Button2.Image.Equals(My.Resources.LM1) Then

            Button2.Image = My.Resources.DM1
            TabPage2.BackColor = Color.FromArgb(29, 29, 29)
            Label3.ForeColor = Color.GhostWhite
            Label4.ForeColor = Color.GhostWhite
            Button1.ForeColor = Color.FromArgb(29, 29, 29)
            Button2.ForeColor = Color.FromArgb(29, 29, 29)

        Else

            Button2.Image = My.Resources.LM1
            TabPage2.BackColor = Color.GhostWhite
            Label3.ForeColor = Color.FromArgb(29, 29, 29)
            Label4.ForeColor = Color.FromArgb(29, 29, 29)
            Button1.ForeColor = Color.GhostWhite
            Button2.ForeColor = Color.GhostWhite

        End If

    End Sub
End Class
