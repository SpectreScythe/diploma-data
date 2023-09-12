Public Class GAD_MP_Info6_Reciept

    Dim R As New Random()
    Private currentImageIndex1 As Integer = R.Next(1, 21)
    Private currentImageIndex2 As Integer = R.Next(1, 21)
    Private images1 As New List(Of Image)

    Private Sub CartLBL3_Click(sender As Object, e As EventArgs) Handles CartLBL3.Click

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub
    Private Sub CartLBL1_Click(sender As Object, e As EventArgs) Handles CartLBL1.Click

    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
    Private Sub GAD_MP_RECEIPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label8.Location = New Point((Label8.Parent.ClientSize.Width - Label8.Width) / 2, (Label8.Parent.ClientSize.Height - Label8.Height) / 2)

        Me.Text = "FoodHub | Reciept"

        Timer1.Enabled = True
        Timer1.Interval = 500

        Label4.Text = "Order Number : " & GAD_MP_Form3_Welcome.TextBox1.Text

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

        Dim str As String = ""

        If GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            str = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

        ElseIf GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            str = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

        End If

        Label3.Text = "Customer's Name : " & str

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GAD_MP_Info6_Scan.Show()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GAD_MP_Form7_Cart.Show()
        Me.Hide()
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
End Class