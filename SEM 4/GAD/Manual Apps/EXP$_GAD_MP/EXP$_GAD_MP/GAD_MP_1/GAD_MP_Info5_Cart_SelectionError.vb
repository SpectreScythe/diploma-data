Public Class GAD_MP_Info5_Cart_SelectionError

    Private Sub GAD_MP_Info5_Cart_SelectionError_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "FoodHub | Cart | Error"

        Label1.Text = "Error: No quantity found." & vbCrLf & "Please select an item's quantity."

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class