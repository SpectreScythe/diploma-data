Public Class Form1

    Private Sub DarkModeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DarkModeBtn.CheckedChanged
        If DarkModeBtn.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Gold Roger\Desktop\College\SEM 4\GUI\Manual Apps\Darkmode\darkmodepic.png")
        End If
    End Sub

    Private Sub LightModeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles LightModeBtn.CheckedChanged
        If LightModeBtn.Checked Then
            PictureBox1.Image = Image.FromFile("C:\Users\Gold Roger\Desktop\College\SEM 4\GUI\Manual Apps\Darkmode\lightmodepic.png")
        End If
    End Sub

End Class
