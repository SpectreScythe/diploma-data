Public Class GAD_MP_DESSERT_SUNDAE

    Private Sub GAD_MP_DESSERT_SUNDAE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "A sundae is an ice cream " & vbCrLf & "dessert of American origin " & vbCrLf & "that typically consists of " & vbCrLf & "one or more scoops of " & vbCrLf & "ice cream topped with sauce " & vbCrLf & "or syrup and other " & vbCrLf & "toppings such as " & vbCrLf & "sprinkles, whipped cream, " & vbCrLf & "marshmallows, peanuts, " & vbCrLf & "maraschino cherries, or other " & vbCrLf & "fruits "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Icecream Sundae"
        Dim senderP As String = "$10.99"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel9.Visible = True
    End Sub
End Class