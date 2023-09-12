Public Class GAD_MP_Login_Loading_Error

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < ProgressBar1.Maximum Then

            ProgressBar1.Value += 5
            Timer1.Enabled = True

        ElseIf ProgressBar1.Value = 100 Then

            Me.Close()
            Timer1.Stop()
            GAD_MP_Info5_Login_Failed.Show()

        End If

    End Sub

    Private Sub GAD_MP_Login_Loading_Error_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.White

        Me.Text = "Food Hub | Login | Loading"

    End Sub
End Class