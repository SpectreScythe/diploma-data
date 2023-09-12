Public Class GAD_MP_Info5_DealAdded

    Private images1 As New List(Of Image)
    Private currentImageIndex1 As Integer = 0

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        GAD_MP_Info4_DealA.Close()
        GAD_MP_Info4_DealB.Close()
        GAD_MP_Info4_DealC.Close()
        Me.Close()
    End Sub

    Private Sub GAD_MP_Info5_DealAdded_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True

        Me.Text = "FoodHub | Deal Added"

        images1.Add(My.Resources.sushi)
        images1.Add(My.Resources.spaghetti_200px)
        images1.Add(My.Resources.poultry_leg_200px)
        images1.Add(My.Resources.kawaii_steak_200px)
        images1.Add(My.Resources.beef_200px)
        images1.Add(My.Resources.prawn_200px)
        images1.Add(My.Resources.Fish_Fillet_200px)
        images1.Add(My.Resources.drinksB)
        images1.Add(My.Resources.drinksH2o)
        images1.Add(My.Resources.drinksL)
        images1.Add(My.Resources.drinksM)
        images1.Add(My.Resources.drinksO)
        images1.Add(My.Resources.drinksV)
        images1.Add(My.Resources.drinksW)
        images1.Add(My.Resources.DCC)
        images1.Add(My.Resources.DCCC)
        images1.Add(My.Resources.DCP)
        images1.Add(My.Resources.DFS)
        images1.Add(My.Resources.DIC)
        images1.Add(My.Resources.DICS)
        images1.Add(My.Resources.DMac)
        images1.Add(My.Resources.DPC)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex1 += 1
        If currentImageIndex1 >= images1.Count Then
            currentImageIndex1 = 0
        End If

        PictureBox2.Image = images1(currentImageIndex1)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class