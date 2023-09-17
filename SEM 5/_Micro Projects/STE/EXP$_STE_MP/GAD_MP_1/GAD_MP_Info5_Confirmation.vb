Imports System.Data.OleDb

Public Class GAD_MP_Info5_Confirmation

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)

    Private Sub GAD_MP_Info5_Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label4.Text = "Once set, the quantity cannot " & vbCrLf & "be changed." & vbCrLf & vbCrLf & "Are you sure you want" & vbCrLf & "to continue?"

        Label1.Text = "Alert"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GAD_MP_Form7_Cart.Panel2.BringToFront()

        If GAD_MP_Info1_MainCourse_BeefRibs.CheckBox1.Checked = True Then

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Ribbs"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If

            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", str1)
            cmd1.Parameters.AddWithValue("@price", 49.99)
            cmd1.Parameters.AddWithValue("@qty", GAD_MP_Info1_MainCourse_BeefRibs.NumericUpDown1.Value)
            cmd1.Parameters.AddWithValue("@type", str2)

            cmd1.ExecuteNonQuery()

            connection.Close()

            Dim senderN As String = "Beef Ribs"
            Dim senderP As String = "$49.99"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_BeefRibs.NumericUpDown1.Value
            Dim senderT As String = "Main Course"
            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
            GAD_MP_Form4_MainCourse.CheckBox5.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefRibs.BringToFront()
            GAD_MP_Info1_MainCourse_BeefRibs.CheckBox1.Checked = False

        End If

        If GAD_MP_Info1_MainCourse_BeefSteak.CheckBox1.Checked = True Then

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If

            Dim senderN As String = "Beef Steak"
            Dim senderP As String = "$54.99"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_BeefSteak.NumericUpDown1.Value
            Dim senderT As String = "Main Course"

            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 54.99)
            cmd1.Parameters.AddWithValue("@qty", GAD_MP_Info1_MainCourse_BeefSteak.NumericUpDown1.Value)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefSteak.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_BeefSteak.BringToFront()
            GAD_MP_Info1_MainCourse_BeefSteak.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_ChickenTikkaMasala.CheckBox1.Checked = True Then

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Chicken Tikka Masala"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If

            Dim senderN As String = "Chicken Tikka Masala"
            Dim senderP As String = "$24.99"
            Dim senderQ As Integer = 1
            Dim senderT As String = "Main Course"


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", str1)
            cmd1.Parameters.AddWithValue("@price", 24.49)
            cmd1.Parameters.AddWithValue("@qty", GAD_MP_Info1_MainCourse_ChickenTikkaMasala.NumericUpDown1.Value)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox8.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ChickenTikkaMasala.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ChickenTikkaMasala.BringToFront()
            GAD_MP_Info1_MainCourse_ChickenTikkaMasala.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_FishFillet.CheckBox1.Checked = True Then

            Dim senderN As String = "Fish Fillet"
            Dim senderP As String = "$49.49"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_FishFillet.NumericUpDown1.Value
            Dim senderT As String = "Main Course"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 49.49)
            cmd1.Parameters.AddWithValue("@qty", GAD_MP_Info1_MainCourse_FishFillet.NumericUpDown1.Value)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox4.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_FishFillet.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_FishFillet.BringToFront()
            GAD_MP_Info1_MainCourse_FishFillet.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_GrilledChicken.CheckBox1.Checked = True Then

            Dim senderN As String = "Grilled Chicken"
            Dim senderP As String = "$39.99"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_GrilledChicken.NumericUpDown1.Value
            Dim senderT As String = "Main Course"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 39.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox2.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_GrilledChicken.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_GrilledChicken.BringToFront()
            GAD_MP_Info1_MainCourse_GrilledChicken.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_ShrimpScampi.CheckBox1.Checked = True Then

            Dim senderN As String = "Shrimp Scampi"
            Dim senderP As String = "$44.49"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_ShrimpScampi.NumericUpDown1.Value
            Dim senderT As String = "Main Course"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 44.49)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox6.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ShrimpScampi.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_ShrimpScampi.BringToFront()
            GAD_MP_Info1_MainCourse_ShrimpScampi.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_SpaghettiBolognese.CheckBox1.Checked = True Then

            Dim senderN As String = "Spaghetti Bologonese"
            Dim senderP As String = "$44.99"
            Dim senderQ As Integer = GAD_MP_Info1_MainCourse_SpaghettiBolognese.NumericUpDown1.Value
            Dim senderT As String = "Main Course"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 44.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox3.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_SpaghettiBolognese.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_SpaghettiBolognese.BringToFront()
            GAD_MP_Info1_MainCourse_SpaghettiBolognese.CheckBox1.Checked = False

        ElseIf GAD_MP_Info1_MainCourse_TunaSushi.CheckBox1.Checked = True Then

            Dim senderN As String = "Tuna Sushi"
            Dim senderP As String = "$39.99"
            Dim senderQ As Integer = 1
            Dim senderT As String = "Main Course"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 39.99)
            cmd1.Parameters.AddWithValue("@qty", 1)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox7.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_MainCourse.Show()
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_TunaSushi.Visible = True
            GAD_MP_Info5_ItemAdded_MainCourse.GAD_MP_ItemAdded_TunaSushi.BringToFront()
            GAD_MP_Info1_MainCourse_TunaSushi.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_CoolBerg.CheckBox1.Checked = True Then

            Dim senderN As String = "Chilled Coolberg"
            Dim senderP As String = "$3.49"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_CoolBerg.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 3.49)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()

            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Coolberg.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Coolberg.BringToFront()
            GAD_MP_Info2_Drinks_CoolBerg.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_GrapeWine.CheckBox1.Checked = True Then

            Dim senderN As String = "Grape Wine"
            Dim senderP As String = "$4.99"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_GrapeWine.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 4.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()

            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Grape.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Grape.BringToFront()
            GAD_MP_Info2_Drinks_GrapeWine.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_MangoJuice.CheckBox1.Checked = True Then


            Dim senderN As String = "Mango Juice"
            Dim senderP As String = "$9.99"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_MangoJuice.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 9.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Mango.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Mango.BringToFront()
            GAD_MP_Info2_Drinks_MangoJuice.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_Mojito.CheckBox1.Checked = True Then

            Dim senderN As String = "Lime Mojito"
            Dim senderP As String = "$5.99"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_Mojito.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 5.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Mojito.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Mojito.BringToFront()
            GAD_MP_Info2_Drinks_Mojito.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_OrangeJuice.CheckBox1.Checked = True Then

            Dim senderN As String = "Orange Juice"
            Dim senderP As String = "$6.99"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_OrangeJuice.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 6.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Orange.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Orange.BringToFront()
            GAD_MP_Info2_Drinks_OrangeJuice.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_RedWine.CheckBox1.Checked = True Then


            Dim senderN As String = "Divine Red Wine"
            Dim senderP As String = "$7.49"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_RedWine.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 7.49)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Red.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Red.BringToFront()
            GAD_MP_Info2_Drinks_RedWine.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_DRINKS_WATER.CheckBox1.Checked = True Then

            Dim senderN As String = "Mineral Water"
            Dim senderP As String = "$1"
            Dim senderQ As Integer = GAD_MP_Info2_DRINKS_WATER.NumericUpDown1.Value
            Dim senderT As String = "Drink"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 1)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)



            cmd1.ExecuteNonQuery()

            connection.Close()
            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)


            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Water.BringToFront()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_Water.Visible = True
            GAD_MP_Info2_DRINKS_WATER.CheckBox1.Checked = False

        ElseIf GAD_MP_Info2_Drinks_WaterMelon.CheckBox1.Checked = True Then


            Dim senderN As String = "Watermellon Slurp"
            Dim senderP As String = "$6.49"
            Dim senderQ As Integer = GAD_MP_Info2_Drinks_WaterMelon.NumericUpDown1.Value
            Dim senderT As String = "Drink"
            GAD_MP_Form7_Cart.Panel2.Visible = False
            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 6.49)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Drinks.Show()
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_WaterMelon.Visible = True
            GAD_MP_Info5_ItemAdded_Drinks.Cart_Panel_WaterMelon.BringToFront()
            GAD_MP_Info2_Drinks_WaterMelon.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_CheeseCake.CheckBox1.Checked = True Then


            Dim senderN As String = "Cheese Cake"
            Dim senderP As String = "$10.99"
            Dim senderQ As Integer = GAD_MP_Info3_CheeseCake.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 10.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.cheese.BringToFront()
            GAD_MP_Info3_CheeseCake.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_CherryPie.CheckBox1.Checked = True Then


            Dim senderN As String = "Cherry Pie"
            Dim senderP As String = "$8.99"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_CherryPie.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 8.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.Pie.BringToFront()
            GAD_MP_Info3_Desserts_CherryPie.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_Cupcake.CheckBox1.Checked = True Then


            Dim senderN As String = "Cupcake"
            Dim senderP As String = "$14.99"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_Cupcake.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 14.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.CupCake.BringToFront()
            GAD_MP_Info3_Desserts_Cupcake.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_FruitCake.CheckBox1.Checked = True Then


            Dim senderN As String = "Fruit Salad"
            Dim senderP As String = "$15.99"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_FruitCake.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 15.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.fruit.BringToFront()
            GAD_MP_Info3_Desserts_FruitCake.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_IceCream.CheckBox1.Checked = True Then


            Dim senderN As String = "Icecream Softie"
            Dim senderP As String = "$11.49"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_IceCream.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 11.49)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.softie.BringToFront()
            GAD_MP_Info3_Desserts_IceCream.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_Macrons.CheckBox1.Checked = True Then


            Dim senderN As String = "Macarons"
            Dim senderP As String = "$9.99"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_Macrons.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 9.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.Macrons.BringToFront()
            GAD_MP_Info3_Desserts_Macrons.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_PanCake.CheckBox1.Checked = True Then


            Dim senderN As String = "Pancake"
            Dim senderP As String = "$15.00"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_PanCake.NumericUpDown1.Value
            Dim senderT As String = "Dessert"

            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 15.0)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form6_Desserts.CheckBox4.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.PanCake.BringToFront()
            GAD_MP_Info3_Desserts_PanCake.CheckBox1.Checked = False

        ElseIf GAD_MP_Info3_Desserts_Sundae.CheckBox1.Checked = True Then


            Dim senderN As String = "Icecream Sundae"
            Dim senderP As String = "$19.99"
            Dim senderQ As Integer = GAD_MP_Info3_Desserts_Sundae.NumericUpDown1.Value
            Dim senderT As String = "Dessert"


            connection.Open()

            Dim query1 = "SELECT MAX(ID) FROM CartOrder"
            Dim cmd = New OleDbCommand(query1, connection)
            Dim maxID As Object = cmd.ExecuteScalar()
            If IsDBNull(maxID) Then
                maxID = 1
            Else
                maxID = CType(maxID, Integer) + 1
            End If

            Dim str1 As String = "Beef Steak"
            Dim str2 As String = "Main Course"
            Dim str3 As String

            If GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text

            ElseIf GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = "" Then

                str3 = GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text

            End If


            Dim query2 As String = "INSERT INTO CartOrder VALUES (@id, @orderNum, @name, @product, @price, @qty, @type)"
            Dim cmd1 As OleDbCommand = New OleDbCommand(query2, connection)
            cmd1.Parameters.AddWithValue("@id", maxID)
            cmd1.Parameters.AddWithValue("@orderNum", GAD_MP_Form3_Welcome.TextBox1.Text)
            cmd1.Parameters.AddWithValue("@name", str3)
            cmd1.Parameters.AddWithValue("@product", senderN)
            cmd1.Parameters.AddWithValue("@price", 19.99)
            cmd1.Parameters.AddWithValue("@qty", senderQ)
            cmd1.Parameters.AddWithValue("@type", senderT)

            cmd1.ExecuteNonQuery()

            connection.Close()

            GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
            GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
            GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
            GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)

            GAD_MP_Info6_Reciept.ListBox1.Items.Add(senderN)
            GAD_MP_Info6_Reciept.ListBox2.Items.Add(senderP)
            GAD_MP_Info6_Reciept.ListBox3.Items.Add(senderQ)

            GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
            Me.Hide()
            GAD_MP_Info5_ItemAdded_Desserts.Show()
            GAD_MP_Info5_ItemAdded_Desserts.IceSundea.BringToFront()
            GAD_MP_Info3_Desserts_Sundae.CheckBox1.Checked = False

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If GAD_MP_Info1_MainCourse_BeefRibs.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_BeefRibs.Show()
            GAD_MP_Info1_MainCourse_BeefRibs.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_BeefSteak.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_BeefSteak.Show()
            GAD_MP_Info1_MainCourse_BeefSteak.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_ChickenTikkaMasala.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_ChickenTikkaMasala.Show()
            GAD_MP_Info1_MainCourse_ChickenTikkaMasala.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_FishFillet.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_FishFillet.Show()
            GAD_MP_Info1_MainCourse_FishFillet.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_GrilledChicken.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_GrilledChicken.Show()
            GAD_MP_Info1_MainCourse_GrilledChicken.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_ShrimpScampi.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_ShrimpScampi.Show()
            GAD_MP_Info1_MainCourse_ShrimpScampi.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_SpaghettiBolognese.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_SpaghettiBolognese.Show()
            GAD_MP_Info1_MainCourse_SpaghettiBolognese.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info1_MainCourse_TunaSushi.CheckBox1.Checked = True Then

            GAD_MP_Info1_MainCourse_TunaSushi.Show()
            GAD_MP_Info1_MainCourse_TunaSushi.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_CoolBerg.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_CoolBerg.Show()
            GAD_MP_Info2_Drinks_CoolBerg.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_MangoJuice.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_MangoJuice.Show()
            GAD_MP_Info2_Drinks_MangoJuice.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_Mojito.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_Mojito.Show()
            GAD_MP_Info2_Drinks_Mojito.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_OrangeJuice.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_OrangeJuice.Show()
            GAD_MP_Info2_Drinks_OrangeJuice.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_GrapeWine.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_GrapeWine.Show()
            GAD_MP_Info2_Drinks_GrapeWine.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_RedWine.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_RedWine.Show()
            GAD_MP_Info2_Drinks_RedWine.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_DRINKS_WATER.CheckBox1.Checked = True Then

            GAD_MP_Info2_DRINKS_WATER.Show()
            GAD_MP_Info2_DRINKS_WATER.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info2_Drinks_WaterMelon.CheckBox1.Checked = True Then

            GAD_MP_Info2_Drinks_WaterMelon.Show()
            GAD_MP_Info2_Drinks_WaterMelon.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_Cupcake.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_Cupcake.Show()
            GAD_MP_Info3_Desserts_Cupcake.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_CherryPie.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_CherryPie.Show()
            GAD_MP_Info3_Desserts_CherryPie.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_Sundae.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_Sundae.Show()
            GAD_MP_Info3_Desserts_Sundae.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_PanCake.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_PanCake.Show()
            GAD_MP_Info3_Desserts_PanCake.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_FruitCake.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_FruitCake.Show()
            GAD_MP_Info3_Desserts_FruitCake.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_IceCream.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_IceCream.Show()
            GAD_MP_Info3_Desserts_IceCream.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_Desserts_Macrons.CheckBox1.Checked = True Then

            GAD_MP_Info3_Desserts_Macrons.Show()
            GAD_MP_Info3_Desserts_Macrons.CheckBox1.Checked = False
            Me.Hide()

        ElseIf GAD_MP_Info3_CheeseCake.CheckBox1.Checked = True Then

            GAD_MP_Info3_CheeseCake.Show()
            GAD_MP_Info3_CheeseCake.CheckBox1.Checked = False
            Me.Hide()

        End If
    End Sub
End Class