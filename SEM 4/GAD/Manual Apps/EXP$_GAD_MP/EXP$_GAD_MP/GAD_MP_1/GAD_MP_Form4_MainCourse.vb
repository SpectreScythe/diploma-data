Public Class GAD_MP_Form4_MainCourse

    Dim str As String = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text
    Dim str1 As String = "Upgrade your meals to the next level"

    Dim str2 As String = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
    Dim str3 As String = "Perfect main courses for any appetite"

    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0
    Private currentImageIndex1 As Integer = 0

    Private Sub GAD_MP_Form4_MainCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        images.Add(My.Resources.sushi)
        images.Add(My.Resources.spaghetti_200px)
        images.Add(My.Resources.poultry_leg_200px)
        images.Add(My.Resources.kawaii_steak_200px)
        images.Add(My.Resources.beef_200px)
        images.Add(My.Resources.prawn_200px)
        images.Add(My.Resources.Fish_Fillet_200px)
        
        Me.BackColor = Color.White

        Me.Text = "Food Hub | Menu | Main Course"

        RectangleShape1.FillColor = Color.GhostWhite
        RectangleShape1.FillStyle = PowerPacks.FillStyle.Solid
        RectangleShape1.BorderColor = Color.GhostWhite
        RectangleShape1.Size = New Size(3, 80)

        For Each ctrl As Control In Panel5.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel6.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel7.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel8.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel9.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel10.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel11.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Panel12.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        If GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            Label8.Text = str3
            Label8.Location = New Point((Label8.Parent.ClientSize.Width - Label8.Width) / 2, (Label8.Parent.ClientSize.Height - Label8.Height) / 2)

        ElseIf GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            Label8.Text = str1
            Label8.Location = New Point((Label8.Parent.ClientSize.Width - Label8.Width) / 2, (Label8.Parent.ClientSize.Height - Label8.Height) / 2)

        End If

        CheckBox1.Visible = False
        CheckBox2.Visible = False
        CheckBox3.Visible = False
        CheckBox4.Visible = False
        CheckBox5.Visible = False
        CheckBox6.Visible = False
        CheckBox7.Visible = False
        CheckBox8.Visible = False

        Timer1.Enabled = True

    End Sub

    Private Sub DLabel_Click(sender As Object, e As EventArgs) Handles Label2.Click

        Me.Hide()
        GAD_MP_Form5_Drinks.Show()

    End Sub

    Private Sub ICLabel_Click(sender As Object, e As EventArgs) Handles Label3.Click

        Me.Hide()
        GAD_MP_Form6_Desserts.Show()

    End Sub

    Private Sub CLabel_Click(sender As Object, e As EventArgs) Handles Label4.Click

        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub AULabel_Click(sender As Object, e As EventArgs) Handles Label5.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        GAD_MP_Form5_Drinks.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        Me.Hide()
        GAD_MP_Form6_Desserts.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If GAD_MP_Form7_Cart.ListBox1.Items.Count = 0 Then

            GAD_MP_Form7_Cart.Panel2.Visible = True

        ElseIf GAD_MP_Form7_Cart.ListBox1.Items.Count <> 0 Then

            GAD_MP_Form7_Cart.Panel2.Visible = False

        End If
        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Close()
        GAD_MP_Form1_Home.Close()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        Me.Hide()
        GAD_MP_Form3_Welcome.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GAD_MP_Form7_Cart.Panel2.Visible = True
        For Each ctrl In GAD_MP_Form7_Cart.Controls

            If TypeOf ctrl Is ListBox Then

                ctrl.Items.Clear()

            End If

        Next

        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = ""
        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_PasswordTextBox.Text = ""
        Me.Hide()
        GAD_MP_Form1_Home.Show()

    End Sub

    Private Sub PictureBox22_Click_1(sender As Object, e As EventArgs) Handles info1.Click

        GAD_MP_Info1_MainCourse_BeefSteak.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles info2.Click

        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        GAD_MP_Info1_MainCourse_GrilledChicken.Show()

    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles info3.Click

        GAD_MP_Info1_MainCourse_SpaghettiBolognese.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles info4.Click

        GAD_MP_Info1_MainCourse_FishFillet.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles info5.Click

        GAD_MP_Info1_MainCourse_BeefRibs.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_Info1_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles info6.Click

        GAD_MP_Info1_MainCourse_ShrimpScampi.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles info7.Click

        GAD_MP_Info1_MainCourse_TunaSushi.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles info8.Click

        GAD_MP_Info1_MainCourse_ChickenTikkaMasala.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
        'GAD_MP_MainCourse_TunaSushi.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

        CheckBox2.Checked = True
        GAD_MP_Info1_MainCourse_GrilledChicken.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_GrilledChicken.Visible = True

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

        CheckBox3.Checked = True
        GAD_MP_Info1_MainCourse_SpaghettiBolognese.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_SpaghettiBolognese.Visible = True

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

        CheckBox4.Checked = True
        GAD_MP_Info1_MainCourse_FishFillet.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_FishFillet.Visible = True

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

        CheckBox8.Checked = True
        GAD_MP_Info1_MainCourse_ChickenTikkaMasala.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ChickenTikkaMasala.Visible = True

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

        CheckBox7.Checked = True
        GAD_MP_Info1_MainCourse_TunaSushi.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_TunaSushi.Visible = True

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

        CheckBox6.Checked = True
        GAD_MP_Info1_MainCourse_ShrimpScampi.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ShrimpScampi.Visible = True

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        CheckBox5.Checked = True
        GAD_MP_Info1_MainCourse_BeefRibs.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        CheckBox1.Checked = True
        GAD_MP_Info1_MainCourse_BeefSteak.Show()
        GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefSteak.Visible = True

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


    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex += 1
        currentImageIndex1 += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
            currentImageIndex1 = 0
        End If

        'PictureBox19.Image = images(currentImageIndex)
        'PictureBox20.Image = images(currentImageIndex1)
    End Sub

    Private Sub PictureBox20_Click_1(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub
End Class