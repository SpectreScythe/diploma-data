Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Header Title

        topHeader.Location = New Point(300, 50)
        topHeader.Font = New Font("Comic Sans MS", 22.0)
        topHeader.ForeColor = Color.CadetBlue

        'Description

        DesCription.Font = New Font("Comic Sans MS", 10.0)
        DesCription.Size = New Size(350, 50)
        DesCription.Text = "Select the desired theme and see the change"
        DesCription.BackColor = Color.AntiqueWhite

        'Column Titles

        BgLBL.Font = New Font("Comic Sans MS", 18)
        BgLBL.ForeColor = Color.AntiqueWhite

        TLBL.Font = New Font("Comic Sans MS", 18)
        TLBL.ForeColor = Color.AntiqueWhite

        LBLFF.Font = New Font("Comic Sans MS", 18)
        LBLFF.ForeColor = Color.AntiqueWhite

        'Background Color

        BgRed.Font = New Font("Comic Sans MS", 15.0)
        BgRed.Size = New Size(350, 50)
        BgRed.Text = "Black"
        BgRed.ForeColor = Color.AntiqueWhite

        BgY.Font = New Font("Comic Sans MS", 15.0)
        BgY.Size = New Size(350, 50)
        BgY.Text = "Yellow"
        BgY.ForeColor = Color.AntiqueWhite

        BgW.Font = New Font("Comic Sans MS", 15.0)
        BgW.Size = New Size(350, 50)
        BgW.Text = "White"
        BgW.ForeColor = Color.AntiqueWhite

        'Font Color

        TSB.Font = New Font("Comic Sans MS", 15.0)
        TSB.Size = New Size(350, 50)
        TSB.Text = "CadetBlue"
        TSB.ForeColor = Color.AntiqueWhite

        TPur.Font = New Font("Comic Sans MS", 15.0)
        TPur.Size = New Size(350, 50)
        TPur.Text = "Purple"
        TPur.ForeColor = Color.AntiqueWhite

        TGreen.Font = New Font("Comic Sans MS", 15.0)
        TGreen.Size = New Size(350, 50)
        TGreen.Text = "Green"
        TGreen.ForeColor = Color.AntiqueWhite

        'Font Family

        RBTNR.Font = New Font("Comic Sans MS", 15.0)
        RBTNR.Size = New Size(350, 50)
        RBTNR.Text = "Times New Roman"
        RBTNR.ForeColor = Color.AntiqueWhite

        RBMono.Font = New Font("Comic Sans MS", 15.0)
        RBMono.Size = New Size(350, 50)
        RBMono.Text = "Ariel"
        RBMono.ForeColor = Color.AntiqueWhite

        RBF.Font = New Font("Comic Sans MS", 15.0)
        RBF.Size = New Size(350, 50)
        RBF.Text = "Fantasy"
        RBF.ForeColor = Color.AntiqueWhite

        Me.BackColor = Color.FromArgb(30, 30, 30)

    End Sub

    Private Sub RBTNR_CheckedChanged_1(sender As Object, e As EventArgs) Handles RBTNR.CheckedChanged
        If RBTNR.Checked Then
            topHeader.Font = New Font("Times New Roman", 22.0, FontStyle.Bold)
        End If
    End Sub

    Private Sub RBF_CheckedChanged_1(sender As Object, e As EventArgs) Handles RBF.CheckedChanged
        If RBF.Checked Then
            topHeader.Font = New Font("Fantasy", 22.0, FontStyle.Bold)
        End If
    End Sub

    Private Sub RBMono_CheckedChanged_1(sender As Object, e As EventArgs) Handles RBMono.CheckedChanged
        If RBMono.Checked Then
            topHeader.Font = New Font("Arial", 22.0, FontStyle.Bold)
        End If
    End Sub

    'Back Color

    Private Sub BgRed_CheckedChanged(sender As Object, e As EventArgs) Handles BgRed.CheckedChanged
        If BgRed.Checked Then
            topHeader.BackColor = Color.Black
        End If
    End Sub

    Private Sub BgW_CheckedChanged(sender As Object, e As EventArgs) Handles BgW.CheckedChanged
        If BgW.Checked Then
            topHeader.BackColor = Color.White
        End If
    End Sub

    Private Sub BgY_CheckedChanged(sender As Object, e As EventArgs) Handles BgY.CheckedChanged
        If BgY.Checked Then
            topHeader.BackColor = Color.Yellow
        End If
    End Sub

    'Font Color

    Private Sub TPur_CheckedChanged(sender As Object, e As EventArgs) Handles TPur.CheckedChanged
        If TPur.Checked Then
            topHeader.ForeColor = Color.Purple
        End If
    End Sub

    Private Sub TSB_CheckedChanged(sender As Object, e As EventArgs) Handles TSB.CheckedChanged
        If TSB.Checked Then
            topHeader.ForeColor = Color.CadetBlue
        End If
    End Sub

    Private Sub TGreen_CheckedChanged(sender As Object, e As EventArgs) Handles TGreen.CheckedChanged
        If TGreen.Checked Then
            topHeader.ForeColor = Color.Green
        End If
    End Sub
End Class
