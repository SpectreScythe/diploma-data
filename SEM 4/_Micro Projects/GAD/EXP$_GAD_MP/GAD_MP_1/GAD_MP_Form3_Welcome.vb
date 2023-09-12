Imports System.Data.OleDb

Public Class GAD_MP_Form3_Welcome

    Dim R As New Random()

    Private images1 As New List(Of Image)
    Private currentImageIndex1 As Integer = R.next(1, 21)
    Private currentImageIndex2 As Integer = R.Next(1, 21)
    Private currentImageIndex3 As Integer = R.Next(1, 21)
    Private currentImageIndex5 As Integer = R.Next(1, 21)
    Private currentImageIndex4 As Integer = R.Next(1, 21)

    Dim orderNumber As String = ""

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Dim str As String = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text
    Dim str1 As String = "What's on your mind today?"

    Dim str2 As String = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text
    Dim str3 As String = "What's your plan for today?"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Hide()
        GAD_MP_Form1_Home.Hide()

    End Sub

    Private Sub GAD_MP_Form3_Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        Timer1.Interval = 500

        'orderNumber = ""

        Me.BackColor = Color.White

        For Each ctrl As Control In TabPage1.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

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

        For Each ctrl As Control In TabPage2.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In TabPage3.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        GAD_MP_Form1_Home.Hide()

        Label12.Text = "Enjoy an almost effortless " & vbCrLf & " alfresco meal of marinated " & vbCrLf & " skirt steak cooked on " & vbCrLf & " a grill, plus " & vbCrLf & " blue-cheese-topped " & vbCrLf & " potatoes and corn-flecked " & vbCrLf & " spinach salad."
        Label12.Font = New Font("Microsoft JhengHei", 10.0)

        Label8.Text = " Our red wine is carefully" & vbCrLf & " crafted from the finest grapes," & vbCrLf & " harvested at the peak of " & vbCrLf & "ripeness, and expertly fermented " & vbCrLf & "and aged to perfection, " & vbCrLf & "resulting in a wine that " & vbCrLf & "is a symphony of flavors, " & vbCrLf & "aromas, and textures."
        Label8.Font = New Font("Microsoft JhengHei", 10.0)

        Label9.Text = "Made with love and care," & vbCrLf & " our cherry pie is a " & vbCrLf & "symphony of juicy" & vbCrLf & " cherries, nestled in a" & vbCrLf & " flaky, buttery crust, and " & vbCrLf & "baked to golden perfection."

        Label11.Text = "Japanese Tuna " & vbCrLf & "sushi is known for its " & vbCrLf & "rich and savory flavor," & vbCrLf & " and is often enjoyed" & vbCrLf & " with soy sauce, wasabi, " & vbCrLf & "and pickled ginger for " & vbCrLf & "added taste and freshness."
        Label11.Font = New Font("Microsoft JhengHei", 10.0)

        Label17.Text = "Take a sip and be " & vbCrLf & "instantly refreshed by" & vbCrLf & " the zesty notes of lime," & vbCrLf & " the aromatic aroma of " & vbCrLf & "fresh mint, and the" & vbCrLf & " smooth warmth of rum. "
        Label17.Font = New Font("Microsoft JhengHei", 10.0)

        Label18.Text = "Made with the creamiest, " & vbCrLf & "silkiest ice cream, our " & vbCrLf & "Ice Softie is a luxurious " & vbCrLf & "delight that will melt in your" & vbCrLf & " mouth and make your" & vbCrLf & " taste buds dance with joy. "
        Label18.Font = New Font("Microsoft JhengHei", 10.0)

        Label33.Text = "A hearty pasta dish " & vbCrLf & " made with ground meat " & vbCrLf & " (usually beef), tomatoes," & vbCrLf & " onions, garlic, and herbs," & vbCrLf & " served over spaghetti or" & vbCrLf & " other pasta noodles."
        Label33.Font = New Font("Microsoft JhengHei", 10.0)

        Label34.Text = "With its bright and cheerful " & vbCrLf & "color, our orange juice is a " & vbCrLf & "visual delight that promises " & vbCrLf & "to awaken your senses from " & vbCrLf & "the very first sip."

        Label34.Font = New Font("Microsoft JhengHei", 10.0)

        Label35.Text = "It's a canvas " & vbCrLf & " of deliciousness," & vbCrLf & " begging to be " & vbCrLf & "adorned with a drizzle " & vbCrLf & "of maple syrup, a " & vbCrLf & "dollop of whipped " & vbCrLf & "cream, or a scatter of " & vbCrLf & "fresh berries."
        Label35.Font = New Font("Microsoft JhengHei", 10.0)


        Me.Text = "Food Hub | Home | Welcome"

        RectangleShape1.FillColor = Color.GhostWhite
        RectangleShape1.FillStyle = PowerPacks.FillStyle.Solid
        RectangleShape1.BorderColor = Color.GhostWhite
        RectangleShape1.Size = New Size(3, 40)

        If GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            Label1.Text = str3
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        ElseIf GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            Label1.Text = str1
            Label1.Location = New Point((Label1.Parent.ClientSize.Width - Label1.Width) / 2, (Label1.Parent.ClientSize.Height - Label1.Height) / 2)

        End If

        Label9.Font = New Font("Microsoft JhengHei", 10.0)

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

    Private Sub AULabel_Click(sender As Object, e As EventArgs) Handles AULabel.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

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

        If GAD_MP_Form7_Cart.ListBox1.Items.Count = 0 Then

            Panel2.Visible = True

        ElseIf GAD_MP_Form7_Cart.ListBox1.Items.Count <> 0 Then

            Panel2.Visible = False

        End If

        Me.Hide()
        GAD_MP_Form7_Cart.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        Me.Hide()
        GAD_MP_Form8_Info.Show()

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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GAD_MP_Info4_DealA.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GAD_MP_Info4_DealB.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GAD_MP_Info4_DealC.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        currentImageIndex1 += 1
        currentImageIndex2 += 1
        currentImageIndex3 += 1
        currentImageIndex4 += 1
        currentImageIndex5 += 1
        If currentImageIndex1 >= 21 Then
            currentImageIndex1 = 0
        ElseIf currentImageIndex2 >= 21 Then
            currentImageIndex2 = 0
        ElseIf currentImageIndex3 >= 21 Then
            currentImageIndex3 = 0
        ElseIf currentImageIndex4 >= 21 Then
            currentImageIndex4 = 0
        ElseIf currentImageIndex5 >= 21 Then
            currentImageIndex5 = 0
        End If

        PictureBox17.Image = images1(currentImageIndex1)
        PictureBox19.Image = images1(currentImageIndex2)
        PictureBox20.Image = images1(currentImageIndex3)
        PictureBox21.Image = images1(currentImageIndex4)
        PictureBox9.Image = images1(currentImageIndex5)
    End Sub

    Private Sub info1_Click(sender As Object, e As EventArgs) Handles info1.Click
        If Panel2.Visible = True Then

            Panel2.Visible = False

        Else

            Panel2.Visible = True

        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If Panel3.Visible = True Then

            Panel3.Visible = False

        Else

            Panel3.Visible = True

        End If
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        If Panel4.Visible = True Then

            Panel4.Visible = False

        Else

            Panel4.Visible = True

        End If
    End Sub
End Class