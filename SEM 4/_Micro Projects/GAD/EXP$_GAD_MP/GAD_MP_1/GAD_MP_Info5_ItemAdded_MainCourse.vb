Public Class GAD_MP_Info5_ItemAdded_MainCourse

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Me.Close()

    End Sub

    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub GAD_MP_ItemAdded_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.White

        images.Add(My.Resources.sushi)
        images.Add(My.Resources.spaghetti_200px)
        images.Add(My.Resources.poultry_leg_200px)
        images.Add(My.Resources.kawaii_steak_200px)
        images.Add(My.Resources.beef_200px)
        images.Add(My.Resources.prawn_200px)
        images.Add(My.Resources.Fish_Fillet_200px)

        PictureBox2.Image = images(currentImageIndex)

        Timer1.Interval = 1000
        Timer1.Start()

        Me.Text = "Food Hub | Item Added"

        Label1.Text = "Item added " & vbCrLf & "to Cart"

        GAD_MP_ItemAdded_BeefRibs.Visible = False
        GAD_MP_ItemAdded_BeefSteak.Visible = False
        GAD_MP_ItemAdded_ChickenTikkaMasala.Visible = False
        GAD_MP_ItemAdded_FishFillet.Visible = False
        GAD_MP_ItemAdded_GrilledChicken.Visible = False
        GAD_MP_ItemAdded_ShrimpScampi.Visible = False
        GAD_MP_ItemAdded_SpaghettiBolognese.Visible = False
        GAD_MP_ItemAdded_TunaSushi.Visible = False

        GAD_MP_ItemAdded_BeefRibs.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_BeefSteak.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_ChickenTikkaMasala.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_FishFillet.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_GrilledChicken.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_ShrimpScampi.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_SpaghettiBolognese.Font = New Font("Microsoft JhengHei", 10.0)
        GAD_MP_ItemAdded_TunaSushi.Font = New Font("Microsoft JhengHei", 10.0)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)
    End Sub
End Class