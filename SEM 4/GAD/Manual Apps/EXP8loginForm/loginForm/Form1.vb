Public Class Form1

    Dim appTitle As New Label()

    Dim userNameLabel As New Label()
    Dim userNameTextBox As New TextBox()

    Dim userPasswordLabel As New Label()
    Dim userPasswordTextBox As New TextBox()

    Dim cancelBtn As New Button()
    Dim submitBtn As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        appTitle.Text = "Login Form"
        appTitle.Location = New Point(140, 50)
        appTitle.Font = New Font("Comic Sans MS", 15.0)
        appTitle.Size = New Size(300, 30)
        appTitle.ForeColor = Color.AntiqueWhite


        userNameLabel.Text = "Enter Username here"
        userNameLabel.Location = New Point(50, 120)
        userNameLabel.Font = New Font("Comic Sans MS", 10.0)
        userNameLabel.Size = New Size(150, 30)
        userNameLabel.ForeColor = Color.AntiqueWhite

        userNameTextBox.Text = "Type here..."
        userNameTextBox.Location = New Point(250, 120)
        userNameTextBox.Font = New Font("Comic Sans MS", 10.0)
        userNameTextBox.Size = New Size(150, 30)
        userNameTextBox.ForeColor = Color.Black

        userPasswordLabel.Text = "Enter Password here"
        userPasswordLabel.Location = New Point(50, 180)
        userPasswordLabel.Font = New Font("Comic Sans MS", 10.0)
        userPasswordLabel.Size = New Size(150, 30)
        userPasswordLabel.ForeColor = Color.AntiqueWhite

        userPasswordTextBox.Text = "Type here..."
        userPasswordTextBox.Location = New Point(250, 180)
        userPasswordTextBox.Font = New Font("Comic Sans MS", 10.0)
        userPasswordTextBox.Size = New Size(150, 30)
        userPasswordTextBox.ForeColor = Color.Black

        submitBtn.Location = New Point(100, 300)
        submitBtn.Font = New Font("Comic Sans MS", 10.0)
        submitBtn.Size = New Size(100, 30)
        submitBtn.Text = "Check"
        submitBtn.BackColor = Color.AntiqueWhite

        cancelBtn.Location = New Point(300, 300)
        cancelBtn.Font = New Font("Comic Sans MS", 10.0)
        cancelBtn.Size = New Size(100, 30)
        cancelBtn.Text = "Cancel"
        cancelBtn.BackColor = Color.AntiqueWhite

        Me.Controls.Add(appTitle)
        Me.Controls.Add(userNameLabel)
        Me.Controls.Add(userNameTextBox)
        Me.Controls.Add(userPasswordLabel)
        Me.Controls.Add(userPasswordTextBox)
        Me.Controls.Add(submitBtn)
        Me.Controls.Add(cancelBtn)

        AddHandler submitBtn.Click, AddressOf checkB4Sumbit
        AddHandler cancelBtn.Click, AddressOf btnCancel_Click
        Me.BackColor = Color.FromArgb(30, 30, 30)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub checkB4Sumbit(sender As Object, e As EventArgs)

        Dim password As String = "12345678"
        Dim UserName As String = "Yo, Mr. White"

        If userNameTextBox.Text = "Yo, Mr. White" Then
            If userPasswordTextBox.Text = "12345678" Then
                MsgBox("Login Sucessfull!!")
            Else
                MsgBox("Invalid Password!!")
            End If
        Else
            MsgBox("Invalid Username!!")
        End If
    End Sub

End Class
