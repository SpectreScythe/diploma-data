Imports System.Data.OleDb

Public Class GAD_MP_Info3_CheeseCake

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)
    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub GAD_MP_DESSERT_CHEESECAKE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images.Add(My.Resources.DCC)
        images.Add(My.Resources.DCCC)
        images.Add(My.Resources.DCP)
        images.Add(My.Resources.DFS)
        images.Add(My.Resources.DIC)
        images.Add(My.Resources.DICS)
        images.Add(My.Resources.DMac)
        images.Add(My.Resources.DPC)

        Timer1.Interval = 500
        Timer1.Enabled = True
        Me.Text = "Food Hub | Desserts | CheeseCake"

        Label1.Font = New Font("Microsoft JhengHei", 14.0)

        Label3.Font = New Font("Microsoft JhengHei", 9.0)

        Label3.Text = "Our cheesecakes are made " & vbCrLf & "with the finest " & vbCrLf & "ingredients and crafted to " & vbCrLf & "perfection, delivering a " & vbCrLf & "creamy, rich, and velvety " & vbCrLf & "texture that will" & vbCrLf & " melt in your mouth and " & vbCrLf & "leave you craving for more. "

    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GAD_MP_Info5_ItemAdded_Desserts.PanCake.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.fruit.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.CupCake.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.cheese.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.Macrons.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.IceSundea.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.Pie.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.softie.Visible = False
        Me.Close()

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GAD_MP_Info5_ItemAdded_Desserts.PanCake.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.fruit.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.CupCake.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.cheese.Visible = True
        GAD_MP_Info5_ItemAdded_Desserts.Macrons.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.IceSundea.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.Pie.Visible = False
        GAD_MP_Info5_ItemAdded_Desserts.softie.Visible = False
        If NumericUpDown1.Value = 0 Then

            GAD_MP_Info5_Cart_QuantityError.Show()

        Else

            CheckBox1.Checked = True

            GAD_MP_Info5_Confirmation.Show()

            'GAD_MP_Form7_Cart.Panel2.Visible = False

            Me.Hide()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)
    End Sub
End Class