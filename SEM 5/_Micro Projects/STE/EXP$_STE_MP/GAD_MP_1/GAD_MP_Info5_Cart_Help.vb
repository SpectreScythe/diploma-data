Public Class GAD_MP_Info5_Cart_Help

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub GAD_MP_Cart_Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "FoodHub | Cart | Help"

        Label1.Text = "Select the desired item's quantity " & vbCrLf & "and click on the increase or " & vbCrLf & "decrease button to do the " & vbCrLf & "respective task."

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
End Class