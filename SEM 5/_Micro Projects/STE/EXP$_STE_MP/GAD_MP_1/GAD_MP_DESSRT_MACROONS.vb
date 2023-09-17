Public Class GAD_MP_DESSRT_MACROONS

    Private Sub GAD_MP_DESSRT_MACROONS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "macaron, sweet, small," & vbCrLf & "round French sandwich " & vbCrLf & "cookie made from meringue," & vbCrLf & " almond flour, sugar, and " & vbCrLf & "food colouring and adorned " & vbCrLf & "with a variety of fillings " & vbCrLf & "including buttercream, chocolate " & vbCrLf & "ganache, marzipan, jam, " & vbCrLf & "and fruit compote."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Macarons"
        Dim senderP As String = "$09.99"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel6.Visible = True
    End Sub
End Class