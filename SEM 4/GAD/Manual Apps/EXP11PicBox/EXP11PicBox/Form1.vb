
Public Class Form1

    Dim runImg As New PictureBox()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        runImg.Location = New Point(40, 0)
        runImg.Size = New Size(1450, 788)
        runImg.Image = Image.FromFile("I:\Gold Roger\SEM 4\GAD\Manual Apps\EXP11PicBox\HFW.jpg")

        Me.Controls.Add(runImg)

        Me.Text = "EXP11PicBox"

    End Sub
End Class
