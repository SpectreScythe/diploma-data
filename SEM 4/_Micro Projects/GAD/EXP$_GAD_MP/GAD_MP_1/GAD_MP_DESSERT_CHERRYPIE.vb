Public Class GAD_MP_DESSERT_CHERRYPIE

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "Cherry Pie is a fruit" & vbCrLf & " pie with a homemade pie " & vbCrLf & "crust, a lattice top, and " & vbCrLf & "filled with a sweet " & vbCrLf & "homemade pie filling for " & vbCrLf & "an irresistible dessert. " & vbCrLf & "It's a simple, but " & vbCrLf & "classic, pie."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Cherry Pie"
        Dim senderP As String = "$08.99"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form4_MainCourse.CheckBox1.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel7.Visible = True
    End Sub
End Class