Imports System.Data.OleDb

Public Class GAD_MP_Info2_Drinks_GrapeWine

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)
    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0
    Private Sub GAD_MP_ITEMADDED_DRINKS_ORANGEJUICE_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        images.Add(My.Resources.drinksB)
        images.Add(My.Resources.drinksH2o)
        images.Add(My.Resources.drinksL)
        images.Add(My.Resources.drinksM)
        images.Add(My.Resources.drinksO)
        images.Add(My.Resources.drinksV)
        images.Add(My.Resources.drinksW)

        Timer1.Interval = 500
        Timer1.Enabled = True
        Me.Text = "Food Hub | Drinks | GrapeWine"
        Label3.Text = "Pair your meal with " & vbCrLf & "the perfect wine from" & vbCrLf & " our carefully curated " & vbCrLf & "selection, showcasing " & vbCrLf & "varietals from renowned" & vbCrLf & " Grape Wine from around" & vbCrLf & " the world."
        Label1.Font = New Font("Microsoft JhengHei", 14.0)
        Label3.Font = New Font("Microsoft JhengHei", 9.0)
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NumericUpDown1.Value = 0 Then

            GAD_MP_Info5_Cart_QuantityError.Show()

        Else

            CheckBox1.Checked = True

            GAD_MP_Info5_Confirmation.Show()

            ' GAD_MP_Form7_Cart.Panel2.Visible = False

            Me.Hide()

        End If       'GAD_MP_Form7_Cart.Panel2.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)
    End Sub
End Class