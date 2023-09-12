Public Class Form1

    Dim CurrentSpeed As Integer
    Dim RoadArea(7) As PictureBox
    Dim CurrentScore As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.FromArgb(87, 87, 87)

        CurrentSpeed = 3

        RoadArea(0) = PictureBox1
        RoadArea(1) = PictureBox2
        RoadArea(2) = PictureBox3
        RoadArea(3) = PictureBox4
        RoadArea(4) = PictureBox5
        RoadArea(5) = PictureBox6
        RoadArea(6) = PictureBox7
        RoadArea(7) = PictureBox8

    End Sub

    Private Sub RoadNext_Tick(sender As Object, e As EventArgs) Handles RoadNext.Tick

        For RoadNextX As Integer = 0 To 7

            RoadArea(RoadNextX).Top = RoadArea(RoadNextX).Top + CurrentSpeed

            If RoadArea(RoadNextX).Top >= Me.Height Then

                RoadArea(RoadNextX).Top = -RoadArea(RoadNextX).Height

            End If

        Next

        If CurrentScore > 10 And CurrentScore < 30 Then

            CurrentSpeed = 20

        End If

        If CurrentScore > 30 And CurrentScore < 50 Then

            CurrentSpeed = 30

        End If

        If CurrentScore > 50 And CurrentScore < 100 Then

            CurrentSpeed = 40

        End If

        If CurrentScore > 100 Then

            CurrentSpeed = 50

        End If

        PlayerSpeed.Text = "Speed : " & CurrentSpeed

        If (PlayerCar.Bounds.IntersectsWith(LaneACar.Bounds)) Then

            BruhMoment()

        End If

        

        If (PlayerCar.Bounds.IntersectsWith(LaneBCar.Bounds)) Then

            BruhMoment()

        End If

        If (PlayerCar.Bounds.IntersectsWith(LaneCCar.Bounds)) Then

            BruhMoment()

        End If

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode

            Case Keys.Up, Keys.W

                PlayerCar.Top = PlayerCar.Top - 10

                CurrentSpeed += 1

            Case Keys.Left, Keys.A

                PlayerCar.Left = PlayerCar.Left - 10

            Case Keys.Right, Keys.D

                PlayerCar.Left = PlayerCar.Left + 10

            Case Keys.Down, Keys.S

                PlayerCar.Top = PlayerCar.Top + 10

                CurrentSpeed -= 1

        End Select

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        DriveRight.Stop()
        DriveLeft.Stop()

    End Sub

    Private Sub BruhMoment()

        RoadNext.Stop()
        PlayerMoverA.Stop()
        PlayerMoverB.Stop()
        PlayerMoverC.Stop()

        Panel1.Visible = True
        ScoreTimer.Stop()
        'PictureBox10.Visible = True
        ReplayBtn.Visible = True
        Button1.Visible = True
        Label1.Visible = True

    End Sub

    Private Sub PlayerMoverA_Tick(sender As Object, e As EventArgs) Handles PlayerMoverA.Tick

        LaneACar.Top += CurrentSpeed / 2

        If LaneACar.Top >= Me.Height Then

            LaneACar.Top = -(Math.Ceiling(Rnd() * 400) + LaneACar.Height)
            LaneACar.Top = (Math.Ceiling(Rnd() * 50) = 0)

        End If

    End Sub

    Private Sub PlayerMoverB_Tick(sender As Object, e As EventArgs) Handles PlayerMoverB.Tick

        LaneBCar.Top += CurrentSpeed / 2

        If LaneBCar.Top >= Me.Height Then

            LaneBCar.Top = -(Math.Ceiling(Rnd() * 400) + LaneBCar.Height)
            LaneBCar.Top = (Math.Ceiling(Rnd() * 50) = 0)

        End If

    End Sub

    Private Sub PlayerMoverC_Tick(sender As Object, e As EventArgs) Handles PlayerMoverC.Tick

        LaneCCar.Top += CurrentSpeed / 2

        If LaneCCar.Top >= Me.Height Then

            LaneCCar.Top = -(Math.Ceiling(Rnd() * 400) + LaneCCar.Height)
            LaneCCar.Top = (Math.Ceiling(Rnd() * 50) = 0)

        End If

    End Sub

    Private Sub ScoreTimer_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick

        CurrentScore += 1

        PlayerScore.Text = "Score : " & CurrentScore

    End Sub

End Class
