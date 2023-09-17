Public Class GAD_MP_Info5_ItemAdded_Desserts

    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

        PanCake.Visible = False
        fruit.Visible = False
        CupCake.Visible = False
        cheese.Visible = False
        Macrons.Visible = False
        IceSundea.Visible = False
        Pie.Visible = False
        softie.Visible = False

    End Sub

    Private Sub GAD_MP_ItemAdded_Desserts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        images.Add(My.Resources.DCC)
        images.Add(My.Resources.DCCC)
        images.Add(My.Resources.DCP)
        images.Add(My.Resources.DFS)
        images.Add(My.Resources.DIC)
        images.Add(My.Resources.DICS)
        images.Add(My.Resources.DMac)
        images.Add(My.Resources.DPC)

        PictureBox2.Image = images(currentImageIndex)

        Timer1.Interval = 500
        Timer1.Start()

        For Each ctrl As Control In IceSundea.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Pie.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In PanCake.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In softie.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In fruit.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In cheese.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Macrons.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In CupCake.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next


        Label1.Text = "Item added " & vbCrLf & "to cart"

        Me.Text = "Food Hub | Item Added"

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