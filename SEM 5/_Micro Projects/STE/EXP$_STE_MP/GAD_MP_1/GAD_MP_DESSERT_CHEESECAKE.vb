Public Class GAD_MP_DESSERT_CHEESECAKE

    Private Sub GAD_MP_DESSERT_CHEESECAKE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "cheesecake, a dessert " & vbCrLf & "consisting of a thick," & vbCrLf & " creamy filling of cheese," & vbCrLf & " eggs, and sugar over" & vbCrLf & " a thinner crust and " & vbCrLf & "topped with sweet or " & vbCrLf & "sometimes salty items."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Cheese Cake"
        Dim senderP As String = "$10.39"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel5.Visible = True
    End Sub
End Class