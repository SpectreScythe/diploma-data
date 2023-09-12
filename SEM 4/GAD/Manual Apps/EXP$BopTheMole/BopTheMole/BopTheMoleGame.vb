Public Class BopTheMoleGame

    Dim gameTitle As New Label()
    Dim currScore As New Label
    'Dim moleSpawnPoint As New PictureBox()
    Dim playerScore As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Whack - The - Mole"
        Me.BackgroundImage = Image.FromFile("I:\Gold Roger\SEM 4\GAD\Manual Apps\EXP$BopTheMole\grassyLandscape.jpg")

        gameTitle.Text = "Whack - The - Mole"
        gameTitle.Font = New Font("Showcard Gothic", 30.0)
        gameTitle.TextAlign = ContentAlignment.TopCenter
        gameTitle.Size = New Size(1386, 80)
        gameTitle.BackColor = Color.FromArgb(0, 162, 232)
        gameTitle.ForeColor = Color.GhostWhite
        gameTitle.Padding = New Padding(0, 20, 0, 0)

        currScore.Font = New Font("Showcard Gothic", 20.0)
        currScore.Size = New Size(300, 30)
        currScore.BackColor = Color.FromArgb(0, 162, 232)
        currScore.ForeColor = Color.Black
        currScore.Location = New Point(1100, 80)

        moleSpawnPoint.Size = New Size(100, 100)
        moleSpawnPoint.Location = New Point(300, 200)
        moleSpawnPoint.Image = Image.FromFile("I:\Gold Roger\SEM 4\GAD\Manual Apps\EXP$WhackTheMole\mole.png")

        Me.Controls.Add(gameTitle)
        Me.Controls.Add(currScore)
        Me.Controls.Add(moleSpawnPoint)

    End Sub

    Private Sub MoleSpawnRate_Tick(sender As Object, e As EventArgs) Handles MoleSpawnRate.Tick

        Dim moleXCord As Integer
        moleXCord = Int(Rnd() * 1100) + 1
        Dim moleYCord As Integer
        moleYCord = Int(Rnd() * 600) + 1

        moleSpawnPoint.Location = New Point(moleXCord, moleYCord)

    End Sub

    Private Sub moleSpawnPoint_Click(sender As Object, e As EventArgs) Handles moleSpawnPoint.Click

        playerScore += 10
        currScore.Text = "Score : " & playerScore

    End Sub
End Class
