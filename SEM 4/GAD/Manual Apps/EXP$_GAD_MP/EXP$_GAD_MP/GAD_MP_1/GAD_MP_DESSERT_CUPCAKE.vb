Public Class GAD_MP_DESSERT_CUPCAKE

    Private Sub GAD_MP_DESSERT_CUPCAKE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = " Cupcakes are small, tasty" & vbCrLf & " snack cakes that are favored " & vbCrLf & "for their portability and " & vbCrLf & "portion-control. They are " & vbCrLf & "batter cakes baked in a " & vbCrLf & "cup-shaped foil or " & vbCrLf & "temperature resistant paper." & vbCrLf & " A cupcake can be prepared " & vbCrLf & "from a variety of " & vbCrLf & "formulations and can be " & vbCrLf & "decorated with cream and " & vbCrLf & "icings."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Cupcake"
        Dim senderP As String = "$14.99"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel10.Visible = True
    End Sub
End Class