Public Class GAD_MP_Info5_ItemAdded_Drinks

    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub GAD_MP_CART_DRINKS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        images.Add(My.Resources.drinksB)
        images.Add(My.Resources.drinksH2o)
        images.Add(My.Resources.drinksL)
        images.Add(My.Resources.drinksM)
        images.Add(My.Resources.drinksO)
        images.Add(My.Resources.drinksV)
        images.Add(My.Resources.drinksW)

        Timer1.Interval = 500
        Timer1.Enabled = True

        PictureBox2.Image = images(currentImageIndex)

        'Timer1.Interval = 1000
        'Timer1.Start()

        Label1.Text = "Item added" & vbCrLf & " to Cart"

        For Each ctrl As Control In Cart_Panel_Coolberg.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Grape.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Mango.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Mojito.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Orange.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Red.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_Water.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

        For Each ctrl As Control In Cart_Panel_WaterMelon.Controls

            If TypeOf ctrl Is Label Then

                ctrl.ForeColor = Color.Black
                ctrl.Font = New Font("Microsoft JhengHei", 12.0)

            End If

        Next

    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)
    End Sub
End Class