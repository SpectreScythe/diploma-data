Public Class GAD_MP_Info5_Login_Failed

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_UsernameTextBox.Text = ""
        GAD_MP_Form1_Home.GAD_MP_Form1_Home_Login_PasswordTextBox.Text = ""

        Me.Hide()
        GAD_MP_Form1_Home.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_SignUp_PhoneNumTextBox.Text = ""
        GAD_MP_Form2_SignUp.GAD_MP_Form2_SignUp_EmailTextBox.Text = ""

        Me.Hide()
        GAD_MP_Form2_SignUp.Show()

    End Sub

    Private Sub GAD_MP_Login_Failed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = Color.White

    End Sub
End Class