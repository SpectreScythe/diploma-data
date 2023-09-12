Public Class BopTheMoleMenu

    Dim gameTitle As New Label()

    Private Sub BopTheMoleMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.Text = "Whack - The - Mole"
        Me.BackgroundImage = Image.FromFile("I:\Gold Roger\SEM 4\GAD\Manual Apps\EXP$WhackTheMole\grassyLandscape.jpg")

        gameTitle.Text = "Whack - The - Mole"
        gameTitle.Font = New Font("Showcard Gothic", 30.0)
        gameTitle.TextAlign = ContentAlignment.TopCenter
        gameTitle.Size = New Size(1386, 80)
        gameTitle.BackColor = Color.FromArgb(0, 162, 232)
        gameTitle.ForeColor = Color.GhostWhite
        gameTitle.Padding = New Padding(0, 20, 0, 0)

        startBtn.Text = "Start New Game"
        startBtn.Font = New Font("Showcard Gothic", 20.0)

        exitBtn.Text = "Exit"
        exitBtn.Font = New Font("Showcard Gothic", 20.0)

        Me.Controls.Add(gameTitle)

    End Sub

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        Me.Hide()

        BopTheMoleGame.Show()

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click

        Me.Close()

    End Sub
End Class