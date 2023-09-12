Public Class GAD_MP_SignUp_Loading

    Private Sub GAD_MP_SignUp_Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.White

        Me.Text = "FOOD HUB | Signing Up | Creating Account"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < ProgressBar1.Maximum Then

            ProgressBar1.Value += 5
            Timer1.Enabled = True

        ElseIf ProgressBar1.Value = 100 Then

            Me.Close()
            Timer1.Stop()
            GAD_MP_Form3_Welcome.Show()

        End If

    End Sub

End Class