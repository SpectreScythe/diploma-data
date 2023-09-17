Public Class GAD_MP_Form7_Cart

    Dim cartArray As New List(Of String)()

    Dim CartString As String

    Dim str As String = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text
    Dim str1 As String = "All The Food That’s Fit to cart"

    Dim str2 As String = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
    Dim str3 As String = "Serving up some culture, straight to your cart"

    Private Sub GAD_MP_Form7_Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If ListBox1.Items.Count = 0 Then

            Panel2.Visible = True

        Else

            Panel2.Visible = False

        End If

        For Each ctrl In Me.Controls

            If TypeOf ctrl Is ListBox Then

                ctrl.BackColor = Color.GhostWhite

            End If

        Next

        Dim BeefSteakCart As String = GAD_MP_Form4_MainCourse.Label9.Text
        Dim GrilledChickenCart As String = GAD_MP_Form4_MainCourse.Label11.Text
        Dim SpaghettiBologoneseCart As String = GAD_MP_Form4_MainCourse.Label13.Text
        Dim FishFilletCart As String = GAD_MP_Form4_MainCourse.Label15.Text
        Dim BeefRibsCart As String = GAD_MP_Form4_MainCourse.Label18.Text
        Dim ShrimpScampiCart As String = GAD_MP_Form4_MainCourse.Label20.Text
        Dim TunaSushiCart As String = GAD_MP_Form4_MainCourse.Label22.Text
        Dim ChickenTikkaMasalaCart As String = GAD_MP_Form4_MainCourse.Label24.Text

        cartArray.Add(BeefSteakCart)
        cartArray.Add(GrilledChickenCart)
        cartArray.Add(SpaghettiBologoneseCart)
        cartArray.Add(FishFilletCart)
        cartArray.Add(BeefRibsCart)
        cartArray.Add(ShrimpScampiCart)
        cartArray.Add(TunaSushiCart)
        cartArray.Add(ChickenTikkaMasalaCart)

        Me.BackColor = Color.White

        Me.Text = "Food Hub | Menu | Cart"

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

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Visible = True
        For Each ctrl In Me.Controls

            If TypeOf ctrl Is ListBox Then

                ctrl.Items.Clear()

            End If

        Next
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

    Private Sub AULabel_Click(sender As Object, e As EventArgs) Handles AULabel.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        GAD_MP_Form1_HoMe.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        GAD_MP_Info5_Cart_Help.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox6.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub AULabel_MouseEnter(sender As Object, e As EventArgs) Handles AULabel.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub AULabel_MouseLeave(sender As Object, e As EventArgs) Handles AULabel.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CLabel_MouseEnter(sender As Object, e As EventArgs) Handles CLabel.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub CLabel_MouseLeave(sender As Object, e As EventArgs) Handles CLabel.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MCLabel_MouseEnter(sender As Object, e As EventArgs) Handles MCLabel.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub MCLabel_MouseLeave(sender As Object, e As EventArgs) Handles MCLabel.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DLabel_MouseEnter(sender As Object, e As EventArgs) Handles DLabel.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub DLabel_MouseLeave(sender As Object, e As EventArgs) Handles DLabel.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ICLabel_MouseEnter(sender As Object, e As EventArgs) Handles ICLabel.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub ICLabel_MouseLeave(sender As Object, e As EventArgs) Handles ICLabel.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Title.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Title.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If ListBox1.Items.Count = 0 Then
            GAD_MP_Info5_Cart_SelectionError.Show()
        Else
            Dim total As Double
            Dim price As String
            Dim i As Integer

            Dim slice As String
            For i = 0 To ListBox2.Items.Count - 1
                price = ListBox2.Items.Item(i)

                slice = price.Trim("$")
                Dim q As Integer = ListBox3.Items.Item(i)
                Dim s As Double = Double.Parse(slice)
                'Dim amt As  = Convert.ToInt32(s)
                Dim quantity As Integer = s * q
                total = total + quantity
            Next

            GAD_MP_Info6_Reciept.Label2.Text = total & ".00"
            GAD_MP_Info6_Reciept.Show()
        End If

        Me.Hide()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub CartLBL2_Click(sender As Object, e As EventArgs) Handles CartLBL2.Click

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub CartLBL1_Click(sender As Object, e As EventArgs) Handles CartLBL1.Click

    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub

    Private Sub CartLBL3_Click(sender As Object, e As EventArgs) Handles CartLBL3.Click

    End Sub
End Class