Imports System.Data.OleDb

Public Class GAD_MP_Info4_DealC

    Private images1 As New List(Of Image)
    Private currentImageIndex1 As Integer = 0

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        GAD_MP_Info5_DealAdded.un.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        If NumericUpDown2.Value = 0 Then
            GAD_MP_Info5_Cart_QuantityError.Show()
        Else
            q1()
            q2()
            q3()

            'GAD_MP_Info5_DealAdded.Label5.Text = "Dissimilar MashUp"
            GAD_MP_Info5_DealAdded.un1.BringToFront()
            GAD_MP_Info5_DealAdded.un1.Visible = True
            GAD_MP_Info5_DealAdded.Show()
        End If

    End Sub

    Private Sub GAD_MP_Info4_DealB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "FoodHub | Deal | Disssimilar MashUp"

        Timer1.Enabled = True
        Timer1.Interval = 500

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

        For Each ctrl As Control In Panel2.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        Label2.Font = New Font("Microsoft JhengHie", 20.0)
        Label2.Font = New Font("Microsoft JhengHie", 15.0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex1 += 1
        If currentImageIndex1 >= images1.Count Then
            currentImageIndex1 = 0
        End If

        PictureBox2.Image = images1(currentImageIndex1)
    End Sub

    Sub q1()

        Dim str31 As String

        connection.Open()

        Dim query1 = "SELECT MAX(ID) FROM CartOrder"
        Dim cmd = New OleDbCommand(query1, connection)
        Dim maxID As Object = cmd.ExecuteScalar()
        If IsDBNull(maxID) Then
            maxID = 1
        Else
            maxID = CType(maxID, Integer) + 1
        End If

        If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            str31 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

        ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            str31 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

        End If

        Dim senderN1 As String = "Spaghetti Bolognese"
        Dim senderP1 As String = "$44.99"
        Dim senderQ1 As Integer = GAD_MP_Info1_MainCourse_BeefSteak.NumericUpDown1.Value
        Dim senderT1 As String = "Main Course"

        Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
        cmd1.Parameters.AddWithValue("@id", maxID)
        cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
        cmd1.Parameters.AddWithValue("@name", str31)
        cmd1.Parameters.AddWithValue("@product", senderN1)
        cmd1.Parameters.AddWithValue("@price", 49.99)
        cmd1.Parameters.AddWithValue("@qty", Me.NumericUpDown2.Value)
        cmd1.Parameters.AddWithValue("@type", senderT1)

        cmd1.ExecuteNonQuery()
        connection.Close()

        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN1)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP1)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(Me.NumericUpDown2.Value)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT1)

    End Sub


    Sub q2()

        Dim str32 As String

        connection.Open()

        Dim query1 = "SELECT MAX(ID) FROM CartOrder"
        Dim cmd = New OleDbCommand(query1, connection)
        Dim maxID As Object = cmd.ExecuteScalar()
        If IsDBNull(maxID) Then
            maxID = 1
        Else
            maxID = CType(maxID, Integer) + 1
        End If

        If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            str32 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

        ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            str32 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

        End If

        Dim senderN2 As String = "Fresh Orange Juice"
        Dim senderP2 As String = "$6.99"
        Dim senderQ2 As Integer = GAD_MP_Info1_MainCourse_BeefSteak.NumericUpDown1.Value
        Dim senderT2 As String = "Drinks"

        Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
        cmd1.Parameters.AddWithValue("@id", maxID)
        cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
        cmd1.Parameters.AddWithValue("@name", str32)
        cmd1.Parameters.AddWithValue("@product", senderN2)
        cmd1.Parameters.AddWithValue("@price", 1)
        cmd1.Parameters.AddWithValue("@qty", Me.NumericUpDown2.Value)
        cmd1.Parameters.AddWithValue("@type", senderT2)

        cmd1.ExecuteNonQuery()
        connection.Close()

        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN2)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP2)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(Me.NumericUpDown2.Value)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT2)

    End Sub


    Sub q3()

        Dim str33 As String

        connection.Open()

        Dim query1 = "SELECT MAX(ID) FROM CartOrder"
        Dim cmd = New OleDbCommand(query1, connection)
        Dim maxID As Object = cmd.ExecuteScalar()
        If IsDBNull(maxID) Then
            maxID = 1
        Else
            maxID = CType(maxID, Integer) + 1
        End If

        If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

            str33 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

        ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

            str33 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

        End If

        Dim senderN3 As String = "Pancakes"
        Dim senderP3 As String = "$15.00"
        Dim senderQ3 As Integer = GAD_MP_Info1_MainCourse_BeefSteak.NumericUpDown1.Value
        Dim senderT3 As String = "Dessert"

        Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
        Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
        cmd1.Parameters.AddWithValue("@id", maxID)
        cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
        cmd1.Parameters.AddWithValue("@name", str33)
        cmd1.Parameters.AddWithValue("@product", senderN3)
        cmd1.Parameters.AddWithValue("@price", 1)
        cmd1.Parameters.AddWithValue("@qty", Me.NumericUpDown2.Value)
        cmd1.Parameters.AddWithValue("@type", senderT3)

        cmd1.ExecuteNonQuery()
        connection.Close()

        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN3)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP3)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(Me.NumericUpDown2.Value)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT3)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class