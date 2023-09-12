Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "EXP11PanelUse"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            'Panel2.Visible = False
        Else
            Panel1.Visible = True
            'Panel2.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Panel2.Visible = True Then
            'Panel1.Visible = False
            Panel2.Visible = False
        Else
            'Panel1.Visible = False
            Panel2.Visible = True
        End If
    End Sub
End Class
