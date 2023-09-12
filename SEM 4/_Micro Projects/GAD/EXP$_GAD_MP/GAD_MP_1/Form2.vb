Public Class Form2

    Dim r As New Random

    Private images As New List(Of Image)

    Private currentImageIndex1 As Integer = r.Next(1, 19)

    Private currentImageIndex2 As Integer = r.Next(1, 19)

    Private currentImageIndex3 As Integer = r.Next(1, 19)

    Private currentImageIndex4 As Integer = r.Next(1, 19)

    Private currentImageIndex5 As Integer = r.Next(1, 19)

    Private currentImageIndex6 As Integer = r.Next(1, 19)

    Private currentImageIndex7 As Integer = r.Next(1, 19)

    Private currentImageIndex8 As Integer = r.Next(1, 19)

    Private currentImageIndex9 As Integer = r.Next(1, 19)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1

        Else
            Timer1.Stop()
            GAD_MP_Form1_Home.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        'Timer1.Stop()
        Me.Text = "Food Hub"

        images.Add(My.Resources._1)
        images.Add(My.Resources._2)
        images.Add(My.Resources._3)
        images.Add(My.Resources._4)
        images.Add(My.Resources._5)
        images.Add(My.Resources._6)
        images.Add(My.Resources._7)
        images.Add(My.Resources._8)
        images.Add(My.Resources._9)
        images.Add(My.Resources._10)
        images.Add(My.Resources._11)
        images.Add(My.Resources._12)
        images.Add(My.Resources._13)
        images.Add(My.Resources._14)
        images.Add(My.Resources._15)
        images.Add(My.Resources._16)
        images.Add(My.Resources._17)
        images.Add(My.Resources._18)
        images.Add(My.Resources._19)
        images.Add(My.Resources._20)

        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        currentImageIndex1 += 1
        If currentImageIndex1 >= images.Count Then
            currentImageIndex1 = 0
        End If

        PictureBox1.Image = images(currentImageIndex1)

        currentImageIndex2 += 1
        If currentImageIndex2 >= images.Count Then
            currentImageIndex2 = 0
        End If

        PictureBox2.Image = images(currentImageIndex2)

        currentImageIndex3 += 1
        If currentImageIndex3 >= images.Count Then
            currentImageIndex3 = 0
        End If

        PictureBox3.Image = images(currentImageIndex3)

        currentImageIndex4 += 1
        If currentImageIndex4 >= images.Count Then
            currentImageIndex4 = 0
        End If

        PictureBox4.Image = images(currentImageIndex4)

        currentImageIndex5 += 1
        If currentImageIndex5 >= images.Count Then
            currentImageIndex5 = 0
        End If

        PictureBox5.Image = images(currentImageIndex5)

        currentImageIndex6 += 1
        If currentImageIndex6 >= images.Count Then
            currentImageIndex6 = 0
        End If

        PictureBox6.Image = images(currentImageIndex6)

        currentImageIndex7 += 1
        If currentImageIndex7 >= images.Count Then
            currentImageIndex7 = 0
        End If

        PictureBox7.Image = images(currentImageIndex7)

        currentImageIndex8 += 1
        If currentImageIndex8 >= images.Count Then
            currentImageIndex8 = 0
        End If

        PictureBox8.Image = images(currentImageIndex8)

        currentImageIndex9 += 1
        If currentImageIndex9 >= images.Count Then
            currentImageIndex9 = 0
        End If

        PictureBox9.Image = images(currentImageIndex9)

    End Sub
End Class