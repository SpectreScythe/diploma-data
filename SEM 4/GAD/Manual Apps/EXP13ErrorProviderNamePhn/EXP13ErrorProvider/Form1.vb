Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(30, 30, 30)

        Label1.ForeColor = Color.GhostWhite
        Label2.ForeColor = Color.GhostWhite

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating

        If TextBox1.Text = "" Then

            ErrorProvider1.SetError(TextBox1, "Empty")
            Button1.Enabled = False
            e.Cancel = True

        ElseIf IsNumeric(TextBox1.Text) Then

            ErrorProvider1.SetError(TextBox1, "No numerical value allowed")
            Button1.Enabled = False
            e.Cancel = True

        Else

            ErrorProvider1.SetError(TextBox2, "")
            Button1.Enabled = True

        End If

    End Sub


    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating


        If TextBox2.Text = "" Then

            ErrorProvider1.SetError(TextBox2, "Empty")
            Button1.Enabled = False
            e.Cancel = True

        ElseIf Not IsNumeric(TextBox2.Text) Then

            ErrorProvider1.SetError(TextBox2, "No alphabetical value allowed")
            Button1.Enabled = False
            e.Cancel = True

        ElseIf TextBox2.Text.Length <> 10 Then

            ErrorProvider1.SetError(TextBox2, "Phone number should contain 10 digits")
            Button1.Enabled = False
            e.Cancel = True

        Else

            ErrorProvider1.SetError(TextBox2, "")
            Button1.Enabled = True

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("Form Submitted")

    End Sub
End Class
