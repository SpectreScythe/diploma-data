Imports System.Data.OleDb

Public Class GAD_MP_Form8_Info

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Dim str As String = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text
    Dim str1 As String = "Your account, your world unlocked " & str

    Dim str2 As String = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
    Dim str3 As String = "Accounting is an art"

    Private Sub GAD_MP_Form8_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White

        Me.Text = "Food Hub | Menu | Account"

        RectangleShape1.FillColor = Color.GhostWhite
        RectangleShape1.FillStyle = PowerPacks.FillStyle.Solid
        RectangleShape1.BorderColor = Color.GhostWhite
        RectangleShape1.Size = New Size(3, 80)

        If GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            Label1.Text = str3
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        ElseIf GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            Label1.Text = str1
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        End If

        Dim cmd As String = "Select * from FoodHubUsers where UserName = '" & GAD_MP_Form1_Home.SessionUser & "'"

        connection.Open()
        Dim adp As New OleDbDataAdapter(cmd, connection)
        Dim dt As New DataTable()
        adp.Fill(dt)

        TextBox4.Text = dt.Rows(0)("UserName").ToString()
        TextBox1.Text = dt.Rows(0)("Password").ToString()
        TextBox3.Text = dt.Rows(0)("EmailID").ToString()
        TextBox2.Text = dt.Rows(0)("PhoneNumber").ToString()

        connection.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = ""
        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_PasswordTextBox.Text = ""
        Me.Hide()
        GAD_MP_Form1_Home.Show()

    End Sub

    Private Sub MCLabel_Click(sender As Object, e As EventArgs) Handles MCLabel.Click

        Me.Hide()
        GAD_MP_Form4_MainCourse.Show()

    End Sub

    Private Sub DLabel_Click(sender As Object, e As EventArgs) Handles DLabel.Click

        Me.Hide()
        GAD_MP_Form5_Drinks.Show()

    End Sub

    Private Sub ICLabel_Click(sender As Object, e As EventArgs) Handles ICLabel.Click

        Me.Hide()
        GAD_MP_Form6_Desserts.Show()

    End Sub

    Private Sub CLabel_Click(sender As Object, e As EventArgs) Handles CLabel.Click

        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub GAD_MP_Form1_Title_Click(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Title.Click

        Me.Hide()
        GAD_MP_Form3_Welcome.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Me.Hide()
        GAD_MP_Form4_MainCourse.Show()

    End Sub


    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        GAD_MP_Form5_Drinks.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        Me.Hide()
        GAD_MP_Form6_Desserts.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click


        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        GAD_MP_Form1_Home.Close()

    End Sub

    Private Sub AULabel_Click(sender As Object, e As EventArgs) Handles AULabel.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim qry As String = "DELETE FROM FoodHubUsers WHERE UserName = '" & GAD_MP_Form1_Home.SessionUser & "'"

        connection.Open()
        Dim cmd As New OleDbCommand(qry, connection)
        cmd.ExecuteNonQuery()
        MsgBox("Account Deleted")
        GAD_MP_Form1_Home.Show()
        Me.Close()
        connection.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim qry As String = "UPDATE FoodHubUsers SET [Password] = @Pass, [EmailID] = @Email, [PhoneNumber] = @Phone WHERE [UserName] = @User"
        connection.Open()
        Dim cmd As New OleDbCommand(qry, connection)
        cmd.Parameters.AddWithValue("@Pass", TextBox1.Text)
        cmd.Parameters.AddWithValue("@Email", TextBox3.Text)
        cmd.Parameters.AddWithValue("@Phone", TextBox2.Text)
        cmd.Parameters.AddWithValue("@User", GAD_MP_Form1_Home.SessionUser)


        cmd.ExecuteNonQuery()
        MsgBox("Account Updated")
        connection.Close()

    End Sub
End Class