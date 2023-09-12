Public Class GAD_MP_Info5_Cart_QuantityError

    Private Sub GAD_MP_Info5_Cart_Error_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Error: Invalid Quantity" & vbCrLf & "Please set a valid value."
        Label1.Location = New Point(182, 120)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class