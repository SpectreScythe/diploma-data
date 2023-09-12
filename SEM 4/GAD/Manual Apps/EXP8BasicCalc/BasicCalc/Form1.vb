Public Class Form1

    Dim appTitle As New Button()

    Dim num1Label As New Button()
    Dim num2label As New Button()

    Dim num1TextBox As New TextBox()
    Dim num2TextBox As New TextBox()

    Dim userEnteredNum1 As New Integer
    Dim userEnteredNum2 As New Integer

    Dim addBtn As New Button()
    Dim subBtn As New Button()
    Dim mulBtn As New Button()
    Dim divBtn As New Button()

    Dim cancelBtn As New Button()
    Dim ansBtn As New Button()
    Dim clrbtn As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        appTitle.Location = New Point(100, 50)
        appTitle.Font = New Font("Comic Sans MS", 18.0)
        appTitle.Size = New Size(350, 50)
        appTitle.Text = "Arithmetic Menu"
        appTitle.BackColor = Color.Gray

        num1Label.Location = New Point(100, 150)
        num1Label.Font = New Font("Comic Sans MS", 12.0)
        num1Label.Size = New Size(150, 50)
        num1Label.Text = "Enter Number 1"
        num1Label.BackColor = Color.Gray

        num1TextBox.Text = "Enter value for A:"
        num1TextBox.Location = New Point(300, 160)
        num1TextBox.Font = New Font("Comic Sans MS", 10.0)
        num1TextBox.Size = New Size(150, 50)
        num1TextBox.ForeColor = Color.Black

        num2label.Location = New Point(100, 220)
        num2label.Font = New Font("Comic Sans MS", 12.0)
        num2label.Size = New Size(150, 50)
        num2label.Text = "Enter Number 2"
        num2label.BackColor = Color.Gray

        num2TextBox.Text = "Enter value for B:"
        num2TextBox.Location = New Point(300, 230)
        num2TextBox.Font = New Font("Comic Sans MS", 10.0)
        num2TextBox.Size = New Size(150, 500)
        num2TextBox.ForeColor = Color.Black

        addBtn.Location = New Point(100, 300)
        addBtn.Font = New Font("Comic Sans MS", 14.0)
        addBtn.Size = New Size(150, 50)
        addBtn.Text = "Add"
        addBtn.BackColor = Color.Gray

        subBtn.Location = New Point(300, 300)
        subBtn.Font = New Font("Comic Sans MS", 14.0)
        subBtn.Size = New Size(150, 50)
        subBtn.Text = "Subtract"
        subBtn.BackColor = Color.Gray

        mulBtn.Location = New Point(100, 380)
        mulBtn.Font = New Font("Comic Sans MS", 14.0)
        mulBtn.Size = New Size(150, 50)
        mulBtn.Text = "Multiply"
        mulBtn.BackColor = Color.Gray

        divBtn.Location = New Point(300, 380)
        divBtn.Font = New Font("Comic Sans MS", 14.0)
        divBtn.Size = New Size(150, 50)
        divBtn.Text = "Divide"
        divBtn.BackColor = Color.Gray

        clrbtn.Location = New Point(100, 470)
        clrbtn.Font = New Font("Comic Sans MS", 14.0)
        clrbtn.Size = New Size(350, 50)
        clrbtn.Text = "Clear"
        clrbtn.BackColor = Color.Gray

        cancelBtn.Location = New Point(100, 560)
        cancelBtn.Font = New Font("Comic Sans MS", 14.0)
        cancelBtn.Size = New Size(350, 50)
        cancelBtn.Text = "Cancel"
        cancelBtn.BackColor = Color.Gray

        Me.Controls.Add(appTitle)
        Me.Controls.Add(num1Label)
        Me.Controls.Add(num2label)
        Me.Controls.Add(num1TextBox)
        Me.Controls.Add(num2TextBox)
        Me.Controls.Add(addBtn)
        Me.Controls.Add(subBtn)
        Me.Controls.Add(mulBtn)
        Me.Controls.Add(divBtn)
        Me.Controls.Add(clrbtn)
        Me.Controls.Add(cancelBtn)

        AddHandler cancelBtn.Click, AddressOf btnCancel
        AddHandler clrbtn.Click, AddressOf btnClr
        AddHandler addBtn.Click, AddressOf Addbtnclick
        AddHandler subBtn.Click, AddressOf Subbtnclick
        AddHandler mulBtn.Click, AddressOf Mulbtnclick
        AddHandler divBtn.Click, AddressOf Divbtnclick

        Me.BackColor = Color.FromArgb(30, 30, 30)

    End Sub

    Private Sub btnCancel(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnClr(sender As Object, e As EventArgs)
        num1TextBox.Text = ""
        num2TextBox.Text = ""
    End Sub

    Private Sub Addbtnclick(sender As Object, e As EventArgs)
        userEnteredNum1 = num1TextBox.Text
        userEnteredNum2 = num2TextBox.Text
        MsgBox(userEnteredNum1 & " + " & userEnteredNum2 & " = " & userEnteredNum1 + userEnteredNum2)
    End Sub

    Private Sub Subbtnclick(sender As Object, e As EventArgs)
        userEnteredNum1 = num1TextBox.Text
        userEnteredNum2 = num2TextBox.Text
        MsgBox(userEnteredNum1 & " - " & userEnteredNum2 & " = " & userEnteredNum1 - userEnteredNum2)
    End Sub

    Private Sub Mulbtnclick(sender As Object, e As EventArgs)
        userEnteredNum1 = num1TextBox.Text
        userEnteredNum2 = num2TextBox.Text
        MsgBox(userEnteredNum1 & " * " & userEnteredNum2 & " = " & userEnteredNum1 * userEnteredNum2)
    End Sub

    Private Sub Divbtnclick(sender As Object, e As EventArgs)
        userEnteredNum1 = num1TextBox.Text
        userEnteredNum2 = num2TextBox.Text
        MsgBox(userEnteredNum1 & " / " & userEnteredNum2 & " = " & userEnteredNum1 / userEnteredNum2)
    End Sub

End Class
