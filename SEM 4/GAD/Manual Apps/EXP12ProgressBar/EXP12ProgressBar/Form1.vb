Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "EXP12ProgressBar"
        Me.BackColor = Color.FromArgb(29, 29, 29)

        startStopBtn.Font = New Font("Comic Sans MS", 12.0)

        loadingPercentage.Font = New Font("Comic Sans MS", 8.0)
        loadingPercentage.ForeColor = Color.AntiqueWhite

        loadingStatus.Font = New Font("Comic Sans MS", 15.0)
        loadingStatus.ForeColor = Color.AntiqueWhite

    End Sub

    Private Sub startStopBtn_Click(sender As Object, e As EventArgs) Handles startStopBtn.Click

        If startStopBtn.Text = "Start" Then

            loadingStatus.Text = "Loading..."
            startStopBtn.Text = "Stop"
            Timer1.Start()

        ElseIf startStopBtn.Text = "Stop" Then

            loadingStatus.Text = "Press Start to continue"
            startStopBtn.Text = "Start"
            Timer1.Stop()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim i As Integer

        If progressBar.Value < progressBar.Maximum Then

            progressBar.Value += 1
            i = progressBar.Value
            loadingPercentage.Text = i & "%"

        Else

            Timer1.Stop()

        End If

    End Sub

End Class
