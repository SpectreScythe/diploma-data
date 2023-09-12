Public Class GAD_MP_DESSERT_PANCAKES

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub GAD_MP_DESSERT_PANCAKES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = "A pancake is a flat " & vbCrLf & "cake, often thin and " & vbCrLf & "round, prepared from a " & vbCrLf & "starch-based batter that " & vbCrLf & "may contain eggs, milk and " & vbCrLf & "butter and cooked on a hot " & vbCrLf & "surface such as a griddle or" & vbCrLf & " frying pan, often frying " & vbCrLf & "with oil or butter. It " & vbCrLf & "is a type of batter bread."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim senderN As String = "Pancake"
        Dim senderP As String = "$15.00"
        Dim senderQ As Integer = 1
        Dim senderT As String = "Dessert"
        GAD_MP_Form7_Cart.ListBox1.Items.Add(senderN)
        GAD_MP_Form7_Cart.ListBox2.Items.Add(senderP)
        GAD_MP_Form7_Cart.ListBox3.Items.Add(senderQ)
        GAD_MP_Form7_Cart.ListBox4.Items.Add(senderT)
        GAD_MP_Form6_Desserts.CheckBox4.Checked = True
        Me.Hide()
        GAD_MP_ItemAdded.Show()
        GAD_MP_CART_DESSERT.Panel8.Visible = True
    End Sub
End Class