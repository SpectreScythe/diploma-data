Imports System.Data.OleDb

Public Class GAD_MP_Form1_Home

    Private images1 As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Public SessionUser As String

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Private images As New List(Of Image)


    Dim R As New Random()
    Private currentImageIndex1 As Integer = R.Next(1, 21)
    Private currentImageIndex2 As Integer = R.Next(1, 21)

    Sub GAD_MP_Form1_Home()

        Me.Text = "Food Hub | Home"

        GAD_MP_Form1_Title.Location = New Point((GAD_MP_Form1_Title.Parent.ClientSize.Width - GAD_MP_Form1_Title.Width) / 2, (GAD_MP_Form1_Title.Parent.ClientSize.Height - GAD_MP_Form1_Title.Height) / 2)

        GAD_MP_Form1_Home_Login_UsernameTextBox.Text = ""

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        GAD_MP_Form1_Home()

        Dim myValue As String = ""
        Dim prefix As String = "ORD"
        Dim r As New Random()
        Dim suffix As String = DateTime.Now.ToString("yyyyMMddHHmmss")
        Dim orderNum As String = prefix & "-" & suffix & "-" & r.Next(111111, 999999)

        myValue = orderNum

        GAD_MP_Form3_Welcome.TextBox1.Text = myValue

        images.Add(My.Resources.LoginSignImg1)
        images.Add(My.Resources.LoginSignImg2)
        images.Add(My.Resources.LoginSignImg3)
        images.Add(My.Resources.LoginSignImg4)
        images.Add(My.Resources.LoginSignImg5)
        images.Add(My.Resources.LoginSignImg6)

        PictureBox1.Image = images(currentImageIndex)
        PictureBox2.Image = images(currentImageIndex)

        GAD_MP_Form1_Home_T2.Interval = 1000
        GAD_MP_Form1_Home_T2.Start()
        GAD_MP_Form1_Home_T1.Interval = 1000
        GAD_MP_Form1_Home_T1.Start()

        Me.BackColor = Color.White

    End Sub

    Private Sub GAD_MP_Form1_Home_Login_Btn_Click(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Home_Login_Btn.Click

        If GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            GAD_MP_Form1_Home_EP.SetError(GAD_MP_Form1_Home_Login_UsernameTextBox, "Username field cannot be empty")

        ElseIf GAD_MP_Form1_Home_Login_PasswordTextBox.Text = "" Then

            GAD_MP_Form1_Home_EP.SetError(GAD_MP_Form1_Home_Login_PasswordTextBox, "Password field cannot be empty")

        Else

            Dim query = "SELECT username, password FROM FoodHubUsers"
            Dim adp = New OleDbDataAdapter(query, connection)
            Dim dt As New DataTable()
            connection.Open()
            adp.Fill(dt)
            connection.Close()

            Dim CanLogin As Boolean = False

            Dim dtuser, dtpass As String

            For i = 0 To dt.Rows.Count - 1

                dtuser = dt.Rows(i)("username").ToString()
                dtpass = dt.Rows(i)("password").ToString()

                If GAD_MP_Form1_Home_Login_UsernameTextBox.Text = dtuser And GAD_MP_Form1_Home_Login_PasswordTextBox.Text = dtpass Then

                    SessionUser = dtuser
                    CanLogin = True

                    Exit For

                End If

            Next

            If CanLogin Then
                GAD_MP_Info5_Login_Loading_Found.Show()

            Else

                GAD_MP_Login_Loading_Error.Show()

            End If

        End If

    End Sub

    Private Sub GAD_MP_Form1_Home_Login_SignUpLink_Click(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Home_Login_SignUpLink.Click

        GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_SignUp_PhoneNumTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_SignUp_EmailTextBox.Text = ""

        Me.Hide()
        GAD_MP_Form2_SignUp.Show()

    End Sub

    Private Sub GAD_MP_Form1_Home_T1_Tick(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Home_T1.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox1.Image = images(currentImageIndex)

    End Sub

    Private Sub GAD_MP_Form1_Home_T2_Tick(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Home_T2.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex1 += 1
        currentImageIndex2 += 1
        If currentImageIndex1 >= 21 Then
            currentImageIndex1 = 0

        ElseIf currentImageIndex2 >= 21 Then
            currentImageIndex2 = 0
        End If

        PictureBox3.Image = images1(currentImageIndex1)
        PictureBox4.Image = images1(currentImageIndex2)

    End Sub
End Class
