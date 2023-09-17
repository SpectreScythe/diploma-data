Public Class GAD_MP_Form6_Desserts

    Dim str As String = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text
    Dim str1 As String = "Wrap It Up With Some Sugar-coated-ness"

    Dim str2 As String = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
    Dim str3 As String = "See The USA In Your Box, " & str2

    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub GAD_MP_Form6_Desserts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        images.Add(My.Resources.DCC)
        images.Add(My.Resources.DCCC)
        images.Add(My.Resources.DCP)
        images.Add(My.Resources.DFS)
        images.Add(My.Resources.DIC)
        images.Add(My.Resources.DICS)
        images.Add(My.Resources.DMac)
        images.Add(My.Resources.DPC)

        For Each ctrl As Control In Panel12.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        Me.BackColor = Color.White

        Me.Text = "Food Hub | Menu | Desserts"

        RectangleShape1.FillColor = Color.GhostWhite
        RectangleShape1.FillStyle = PowerPacks.FillStyle.Solid
        RectangleShape1.BorderColor = Color.GhostWhite
        RectangleShape1.Size = New Size(3, 80)

        For Each ctrl As Control In Panel4.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        If GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            Label1.Text = str3
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        ElseIf GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            Label1.Text = str1
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        End If

    End Sub
    Private Sub MCLabel_Click(sender As Object, e As EventArgs) Handles MCLabel.Click

        Me.Hide()
        GAD_MP_Form4_MainCourse.Show()

    End Sub

    Private Sub DLabel_Click(sender As Object, e As EventArgs) Handles DLabel.Click

        Me.Hide()
        GAD_MP_Form5_Drinks.Show()

    End Sub

    Private Sub CLabel_Click(sender As Object, e As EventArgs) Handles CLabel.Click

        Me.Hide()
        GAD_MP_Form7_Cart.Show()

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

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If GAD_MP_Form7_Cart.ListBox1.Items.Count = 0 Then

            GAD_MP_Form7_Cart.Panel2.Visible = True

        ElseIf GAD_MP_Form7_Cart.ListBox1.Items.Count <> 0 Then

            GAD_MP_Form7_Cart.Panel2.Visible = False

        End If

        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        GAD_MP_Form1_HoMe.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

        GAD_MP_Info3_CheeseCake.Show()

    End Sub

    Private Sub info1_Click(sender As Object, e As EventArgs) Handles info1.Click

        GAD_MP_Info3_CheeseCake.Show()

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

        GAD_MP_Info3_Desserts_FruitCake.Show()

    End Sub

    Private Sub info5_Click(sender As Object, e As EventArgs) Handles info5.Click
        GAD_MP_Info3_Desserts_FruitCake.Show()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        GAD_MP_Info3_Desserts_Macrons.Show()
    End Sub

    Private Sub info2_Click(sender As Object, e As EventArgs) Handles info2.Click
        GAD_MP_Info3_Desserts_Macrons.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        GAD_MP_Info3_Desserts_IceCream.Show()
    End Sub

    Private Sub info6_Click(sender As Object, e As EventArgs) Handles info6.Click
        GAD_MP_Info3_Desserts_IceCream.Show()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        GAD_MP_Info3_Desserts_CherryPie.Show()
    End Sub

    Private Sub info3_Click(sender As Object, e As EventArgs) Handles info3.Click
        GAD_MP_Info3_Desserts_CherryPie.Show()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        GAD_MP_Info3_Desserts_Cupcake.Show()
    End Sub

    Private Sub info7_Click(sender As Object, e As EventArgs) Handles info7.Click
        GAD_MP_Info3_Desserts_Cupcake.Show()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        GAD_MP_Info3_Desserts_PanCake.Show()
    End Sub

    Private Sub info4_Click(sender As Object, e As EventArgs) Handles info4.Click
        GAD_MP_Info3_Desserts_PanCake.Show()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        GAD_MP_Info3_Desserts_Sundae.Show()
    End Sub

    Private Sub info8_Click(sender As Object, e As EventArgs) Handles info8.Click
        GAD_MP_Info3_Desserts_Sundae.Show()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Title.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles GAD_MP_Form1_Title.MouseLeave
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox20.Image = images(currentImageIndex)
        PictureBox2.Image = images(currentImageIndex)
    End Sub
End Class