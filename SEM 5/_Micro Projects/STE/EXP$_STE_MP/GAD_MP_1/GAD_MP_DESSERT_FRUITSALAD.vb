Public Class GAD_MP_DESSERT_FRUITSALAD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GAD_MP_DESSERT_FRUITSALAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Fruit salad is a dish " & vbCrLf & "consisting of various kinds " & vbCrLf & "of fruit, sometimes served " & vbCrLf & "in a liquid, either their " & vbCrLf & "juices or a syrup. In " & vbCrLf & "different forms, fruit salad " & vbCrLf & "can be served as an " & vbCrLf & "appetizer or a side salad."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Fruit Salad"
        Dim senderP As String = "$15.99"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel12.Visible = True
    End Sub
End Class