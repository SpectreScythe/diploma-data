Public Class GAD_MP_DESSERT_ICECREAMSOFTIE

    Private Sub GAD_MP_DESSERT_ICECREAMSOFTIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Ice cream is a frozen " & vbCrLf & "dessert, typically made " & vbCrLf & "from milk or cream and " & vbCrLf & "flavoured with a sweetener, " & vbCrLf & "either sugar or an " & vbCrLf & "alternative, and a spice, such " & vbCrLf & "as cocoa or vanilla, or " & vbCrLf & "with fruit such as " & vbCrLf & "strawberries or peaches."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Icecream Softie"
        Dim senderP As String = "$11.49"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel11.Visible = True
    End Sub
End Class