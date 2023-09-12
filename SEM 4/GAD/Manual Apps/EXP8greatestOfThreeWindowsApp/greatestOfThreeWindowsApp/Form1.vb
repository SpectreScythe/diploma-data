Public Class Form1

    ' Global Declarations

    Dim LabelA As New Label()
    Dim LabelB As New Label()
    Dim LabelC As New Label()
    Dim textBoxA As New TextBox()
    Dim textBoxB As New TextBox()
    Dim textBoxC As New TextBox()
    Dim headerLabel As New Label()
    Dim cancelBtn As New Button()
    Dim checkGreatest As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Form Tools

        headerLabel.Text = "Greatest Of Three Number"
        headerLabel.Location = New Point(200, 50)
        headerLabel.Font = New Font("Comic Sans MS", 15.0)
        headerLabel.Size = New Size(300, 30)
        headerLabel.ForeColor = Color.AntiqueWhite

        LabelA.Text = "Enter value for A:"
        LabelA.Location = New Point(50, 120)
        LabelA.Font = New Font("Comic Sans MS", 10.0)
        LabelA.Size = New Size(150, 30)
        LabelA.ForeColor = Color.AntiqueWhite

        LabelB.Text = "Enter value for B:"
        LabelB.Location = New Point(50, 180)
        LabelB.Font = New Font("Comic Sans MS", 10.0)
        LabelB.Size = New Size(150, 30)
        LabelB.ForeColor = Color.AntiqueWhite

        LabelC.Text = "Enter value for C:"
        LabelC.Location = New Point(50, 240)
        LabelC.Font = New Font("Comic Sans MS", 10.0)
        LabelC.Size = New Size(150, 30)
        LabelC.ForeColor = Color.AntiqueWhite

        textBoxA.Location = New Point(200, 120)
        textBoxB.Location = New Point(200, 180)
        textBoxC.Location = New Point(200, 240)

        checkGreatest.Location = New Point(200, 300)
        checkGreatest.Font = New Font("Comic Sans MS", 10.0)
        checkGreatest.Size = New Size(100, 30)
        checkGreatest.Text = "Check"
        checkGreatest.BackColor = Color.AntiqueWhite

        cancelBtn.Location = New Point(400, 300)
        cancelBtn.Font = New Font("Comic Sans MS", 10.0)
        cancelBtn.Size = New Size(100, 30)
        cancelBtn.Text = "Cancel"
        cancelBtn.BackColor = Color.AntiqueWhite

        Me.Controls.Add(headerLabel)
        Me.Controls.Add(LabelA)
        Me.Controls.Add(LabelB)
        Me.Controls.Add(LabelC)
        Me.Controls.Add(textBoxA)
        Me.Controls.Add(textBoxB)
        Me.Controls.Add(textBoxC)
        Me.Controls.Add(checkGreatest)
        Me.Controls.Add(cancelBtn)

        AddHandler checkGreatest.Click, AddressOf resultClick
        AddHandler cancelBtn.Click, AddressOf btnCancelClick

        Me.BackColor = Color.FromArgb(30, 30, 30)

    End Sub

    Private Sub btnCancelClick(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub resultClick(ByVal sender As Object, ByVal e As EventArgs)

        ' Comparing variables

        Dim A As Integer = Integer.Parse(textBoxA.Text)
        Dim B As Integer = Integer.Parse(textBoxB.Text)
        Dim C As Integer = Integer.Parse(textBoxC.Text)

        If A > B Then
            If A > C Then
                MsgBox("A is Greatest!!")
            Else
                MsgBox("B is Greatest!!")
            End If
        ElseIf B > C Then
            MsgBox("B is Greatest!!")
        Else
            MsgBox("C is Greatest!!")
        End If

    End Sub
End Class
