Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class GAD_MP_Form2_SignUp

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Private images1 As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Dim R As New Random()
    Private currentImageIndex1 As Integer = R.Next(1, 21)
    Private currentImageIndex2 As Integer = R.Next(1, 21)

    Dim ci As New Random()
    Dim randomID As Integer = ci.Next(111111, 999999)

    Private images As New List(Of Image)

    Sub GAD_MP_Form2_SignUp()

        Me.Text = "Food Hub | Home | Sign Up"

        GAD_MP_Form1_Title.Location = New Point((GAD_MP_Form1_Title.Parent.ClientSize.Width - GAD_MP_Form1_Title.Width) / 2, (GAD_MP_Form1_Title.Parent.ClientSize.Height - GAD_MP_Form1_Title.Height) / 2)

        GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = ""

        GAD_MP_Form1_Home.SessionUser = GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

    End Sub

    Private Sub GAD_MP_Form2_SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dim customErrorIcon As Image = Image.FromFile(My.Resources.warning)

        Me.BackColor = Color.White

        'currentImageIndex1 = 0

        GAD_MP_Form2_SignUp()

        Timer1.Enabled = True

        images1.Add(My.Resources.sushi)
        images1.Add(My.Resources.spaghetti_200px)
        images1.Add(My.Resources.poultry_leg_200px)
        images1.Add(My.Resources.kawaii_steak_200px)
        images1.Add(My.Resources.beef_200px)
        images1.Add(My.Resources.prawn_200px)
        images1.Add(My.Resources.Fish_Fillet_200px)
        images1.Add(My.Resources.drinksB)
        images1.Add(My.Resources.drinksH2o)
        images1.Add(My.Resources.drinksL)
        images1.Add(My.Resources.drinksM)
        images1.Add(My.Resources.drinksO)
        images1.Add(My.Resources.drinksV)
        images1.Add(My.Resources.drinksW)
        images1.Add(My.Resources.DCC)
        images1.Add(My.Resources.DCCC)
        images1.Add(My.Resources.DCP)
        images1.Add(My.Resources.DFS)
        images1.Add(My.Resources.DIC)
        images1.Add(My.Resources.DICS)
        images1.Add(My.Resources.DMac)
        images1.Add(My.Resources.DPC)

        'PictureBox3.Image = images1(currentImageIndex1)
        'PictureBox4.Image = images1(currentImageIndex1)

        images.Add(My.Resources.LoginSignImg1)
        images.Add(My.Resources.LoginSignImg2)
        images.Add(My.Resources.LoginSignImg3)
        images.Add(My.Resources.LoginSignImg4)
        images.Add(My.Resources.LoginSignImg5)
        images.Add(My.Resources.LoginSignImg6)

        PictureBox1.Image = images(currentImageIndex)
        PictureBox2.Image = images(currentImageIndex)

        GAD_MP_Form2_SignUp_T2.Interval = 1000
        GAD_MP_Form2_SignUp_T2.Start()
        GAD_MP_Form2_SignUp_T1.Interval = 1000
        GAD_MP_Form2_SignUp_T1.Start()

    End Sub

    Private Sub GAD_MP_Form1_Home_SubmitBtn_Click(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Home_SubmitBtn.Click

        If GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_Home_SignUp_UsernameTextBox, "Username field cannot be empty")

        ElseIf GAD_MP_Form2_Home_SignUp_PasswordTextBox.Text = "" Then

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_Home_SignUp_PasswordTextBox, "Password field cannot be empty")

        ElseIf GAD_MP_Form2_SignUp_EmailTextBox.Text = "" Then

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_EmailTextBox, "Email-ID field cannot be empty")

        ElseIf GAD_MP_Form2_SignUp_PhoneNumTextBox.Text = "" Then

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_PhoneNumTextBox, "Phone Number field cannot be empty")

        Else

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM FoodHubUsers"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim query2 As String = "INSERT INTO FoodHubUsers VALUES (@id, @cid, @name, @email, @password, @phonenumber)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@cid", ci.Next(11111, 99999))
            cmd1.Parameters.AddWithValue("@name", GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text)
            cmd1.Parameters.AddWithValue("@email", GAD_MP_Form2_SignUp_EmailTextBox.Text)
            cmd1.Parameters.AddWithValue("@password", GAD_MP_Form2_Home_SignUp_PasswordTextBox.Text)
            cmd1.Parameters.AddWithValue("@phonenumber", GAD_MP_Form2_SignUp_PhoneNumTextBox.Text)

            cmd1.ExecuteNonQuery()

            connection.Close()
            GAD_MP_Form1_Home.SessionUser = GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
            GAD_MP_SignUp_Loading.Show()

        End If

    End Sub

    Private Sub GAD_MP_Form2_Home_SignUp_LoginLink_Click(sender As Object, e As EventArgs) Handles GAD_MP_Form2_Home_SignUp_LoginLink.Click

        Me.Hide()
        GAD_MP_Form1_Home.Show()

    End Sub

    Private Sub GAD_MP_Form2_Home_T1_Tick(sender As Object, e As EventArgs) Handles GAD_MP_Form2_SignUp_T1.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox1.Image = images(currentImageIndex)

    End Sub

    Private Sub GAD_MP_Form2_Home_T2_Tick(sender As Object, e As EventArgs) Handles GAD_MP_Form2_SignUp_T2.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        GAD_MP_Form1_Home.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()
        GAD_MP_Form1_Home.Show()

    End Sub

    Private Sub GAD_MP_Form2_SignUp_EmailTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GAD_MP_Form2_SignUp_EmailTextBox.Validating

        Dim input As String = GAD_MP_Form2_SignUp_EmailTextBox.Text
        Dim emailPattern As String = ("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
        Dim regex As New Regex(emailPattern)
        If regex.IsMatch(input) Then
            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_EmailTextBox, "Valid Email Format")
        Else
            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_EmailTextBox, "Invalid Email Format")
        End If

    End Sub

    Private Sub GAD_MP_Form2_SignUp_PhoneNumTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GAD_MP_Form2_SignUp_PhoneNumTextBox.Validating

        If IsNumeric(GAD_MP_Form2_SignUp_PhoneNumTextBox.Text) = False Then

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_PhoneNumTextBox, "Phone Number cannot have alphabetical values")

        Else

            GAD_MP_Form2_SignUp_EP.SetError(GAD_MP_Form2_SignUp_PhoneNumTextBox, "")

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex1 += 1
        currentImageIndex2 += 1
        If currentImageIndex1 >= images1.Count Then
            currentImageIndex1 = 0

        ElseIf currentImageIndex2 >= images1.Count Then
            currentImageIndex2 = 0
        End If

        PictureBox3.Image = images1(currentImageIndex1)
        PictureBox4.Image = images1(currentImageIndex2)
    End Sub
End Class