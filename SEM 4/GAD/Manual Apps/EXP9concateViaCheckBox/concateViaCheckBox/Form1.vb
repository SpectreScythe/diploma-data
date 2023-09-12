Public Class Form1

    Dim str As String = ""

    Dim cancelBtn As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblYo.Text = "Yo"
        LblYo.Font = New Font("Comic Sans MS", 20.0)
        LblYo.ForeColor = Color.AliceBlue

        LblMr.Text = "Mr. White"
        LblMr.Font = New Font("Comic Sans MS", 20.0)
        LblMr.ForeColor = Color.AliceBlue

        YoCB.Text = "Add First"
        YoCB.Font = New Font("Comic Sans MS", 15.0)
        YoCB.ForeColor = Color.AliceBlue

        MrCB.Text = "Add Second"
        MrCB.Font = New Font("Comic Sans MS", 15.0)
        MrCB.ForeColor = Color.AliceBlue

        cancelBtn.Location = New Point(300, 300)
        cancelBtn.Font = New Font("Comic Sans MS", 10.0)
        cancelBtn.Size = New Size(100, 30)
        cancelBtn.Text = "Cancel"
        cancelBtn.BackColor = Color.AntiqueWhite

        Sbtn.Location = New Point(100, 300)
        Sbtn.Font = New Font("Comic Sans MS", 10.0)
        Sbtn.Size = New Size(100, 30)
        Sbtn.Text = "Submit"
        Sbtn.BackColor = Color.AntiqueWhite

        Me.Controls.Add(cancelBtn)

        AddHandler cancelBtn.Click, AddressOf btnCancel_Click

        Me.BackColor = Color.FromArgb(30, 30, 30)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private Sub Sbtn_Click(sender As Object, e As EventArgs) Handles Sbtn.Click
        If YoCB.Checked Then
            str &= "Yo,"
        End If

        If MrCB.Checked Then
            str &= "Mr. White"
        End If

        MsgBox(str)
        str = ""

    End Sub
End Class