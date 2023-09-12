<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GAD_MP_Form2_SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GAD_MP_Form2_SignUp))
        Me.GAD_MP_Form1_Home_TitlePanel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GAD_MP_Form1_Title = New System.Windows.Forms.Label()
        Me.GAD_MP_Form1_Home_LoginPanel = New System.Windows.Forms.Panel()
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel = New System.Windows.Forms.Label()
        Me.GAD_MP_Form2_SignUp_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.GAD_MP_Form2_SignUp_EmailLabel = New System.Windows.Forms.Label()
        Me.GAD_MP_Form1_Home_SubmitBtn = New System.Windows.Forms.Button()
        Me.GAD_MP_Form2_Home_SignUp_LoginLink = New System.Windows.Forms.Label()
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel = New System.Windows.Forms.Label()
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel = New System.Windows.Forms.Label()
        Me.GAD_MP_Form2_SignUp_EP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GAD_MP_Form2_SignUp_T1 = New System.Windows.Forms.Timer(Me.components)
        Me.GAD_MP_Form2_SignUp_T2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GAD_MP_Form1_Home_TitlePanel.SuspendLayout()
        Me.GAD_MP_Form1_Home_LoginPanel.SuspendLayout()
        CType(Me.GAD_MP_Form2_SignUp_EP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GAD_MP_Form1_Home_TitlePanel
        '
        Me.GAD_MP_Form1_Home_TitlePanel.BackColor = System.Drawing.Color.Coral
        Me.GAD_MP_Form1_Home_TitlePanel.Controls.Add(Me.PictureBox4)
        Me.GAD_MP_Form1_Home_TitlePanel.Controls.Add(Me.Button2)
        Me.GAD_MP_Form1_Home_TitlePanel.Controls.Add(Me.PictureBox3)
        Me.GAD_MP_Form1_Home_TitlePanel.Controls.Add(Me.Button1)
        Me.GAD_MP_Form1_Home_TitlePanel.Controls.Add(Me.GAD_MP_Form1_Title)
        Me.GAD_MP_Form1_Home_TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.GAD_MP_Form1_Home_TitlePanel.Name = "GAD_MP_Form1_Home_TitlePanel"
        Me.GAD_MP_Form1_Home_TitlePanel.Size = New System.Drawing.Size(1280, 150)
        Me.GAD_MP_Form1_Home_TitlePanel.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Coral
        Me.Button2.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button2.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(117, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 50)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Coral
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft JhengHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GAD_MP_Form1_Title
        '
        Me.GAD_MP_Form1_Title.AutoSize = True
        Me.GAD_MP_Form1_Title.Font = New System.Drawing.Font("Microsoft JhengHei UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form1_Title.Location = New System.Drawing.Point(287, 36)
        Me.GAD_MP_Form1_Title.Name = "GAD_MP_Form1_Title"
        Me.GAD_MP_Form1_Title.Size = New System.Drawing.Size(511, 61)
        Me.GAD_MP_Form1_Title.TabIndex = 0
        Me.GAD_MP_Form1_Title.Text = "FOOD HUB - Sign Up"
        '
        'GAD_MP_Form1_Home_LoginPanel
        '
        Me.GAD_MP_Form1_Home_LoginPanel.BackColor = System.Drawing.Color.Coral
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_SignUp_PhoneNumTextBox)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_SignUp_PhoneNumLabel)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_SignUp_EmailTextBox)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_SignUp_EmailLabel)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form1_Home_SubmitBtn)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_Home_SignUp_LoginLink)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_Home_SignUp_PasswordLabel)
        Me.GAD_MP_Form1_Home_LoginPanel.Controls.Add(Me.GAD_MP_Form2_Home_SignUp_UsernameLabel)
        Me.GAD_MP_Form1_Home_LoginPanel.Location = New System.Drawing.Point(450, 171)
        Me.GAD_MP_Form1_Home_LoginPanel.Name = "GAD_MP_Form1_Home_LoginPanel"
        Me.GAD_MP_Form1_Home_LoginPanel.Size = New System.Drawing.Size(360, 500)
        Me.GAD_MP_Form1_Home_LoginPanel.TabIndex = 2
        '
        'GAD_MP_Form2_SignUp_PhoneNumTextBox
        '
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox.Location = New System.Drawing.Point(68, 341)
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox.Name = "GAD_MP_Form2_SignUp_PhoneNumTextBox"
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox.Size = New System.Drawing.Size(250, 29)
        Me.GAD_MP_Form2_SignUp_PhoneNumTextBox.TabIndex = 4
        '
        'GAD_MP_Form2_SignUp_PhoneNumLabel
        '
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.AutoSize = True
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.Location = New System.Drawing.Point(93, 299)
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.Name = "GAD_MP_Form2_SignUp_PhoneNumLabel"
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.Size = New System.Drawing.Size(225, 26)
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.TabIndex = 8
        Me.GAD_MP_Form2_SignUp_PhoneNumLabel.Text = "Enter Phone Number:"
        '
        'GAD_MP_Form2_SignUp_EmailTextBox
        '
        Me.GAD_MP_Form2_SignUp_EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_SignUp_EmailTextBox.Location = New System.Drawing.Point(68, 254)
        Me.GAD_MP_Form2_SignUp_EmailTextBox.Name = "GAD_MP_Form2_SignUp_EmailTextBox"
        Me.GAD_MP_Form2_SignUp_EmailTextBox.Size = New System.Drawing.Size(250, 29)
        Me.GAD_MP_Form2_SignUp_EmailTextBox.TabIndex = 3
        '
        'GAD_MP_Form2_SignUp_EmailLabel
        '
        Me.GAD_MP_Form2_SignUp_EmailLabel.AutoSize = True
        Me.GAD_MP_Form2_SignUp_EmailLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_SignUp_EmailLabel.Location = New System.Drawing.Point(93, 213)
        Me.GAD_MP_Form2_SignUp_EmailLabel.Name = "GAD_MP_Form2_SignUp_EmailLabel"
        Me.GAD_MP_Form2_SignUp_EmailLabel.Size = New System.Drawing.Size(157, 26)
        Me.GAD_MP_Form2_SignUp_EmailLabel.TabIndex = 6
        Me.GAD_MP_Form2_SignUp_EmailLabel.Text = "Enter Email-ID:"
        '
        'GAD_MP_Form1_Home_SubmitBtn
        '
        Me.GAD_MP_Form1_Home_SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GAD_MP_Form1_Home_SubmitBtn.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form1_Home_SubmitBtn.Location = New System.Drawing.Point(98, 399)
        Me.GAD_MP_Form1_Home_SubmitBtn.Name = "GAD_MP_Form1_Home_SubmitBtn"
        Me.GAD_MP_Form1_Home_SubmitBtn.Size = New System.Drawing.Size(171, 43)
        Me.GAD_MP_Form1_Home_SubmitBtn.TabIndex = 5
        Me.GAD_MP_Form1_Home_SubmitBtn.Text = "Submit"
        Me.GAD_MP_Form1_Home_SubmitBtn.UseVisualStyleBackColor = True
        '
        'GAD_MP_Form2_Home_SignUp_LoginLink
        '
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.AutoSize = True
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.ForeColor = System.Drawing.Color.MediumBlue
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Location = New System.Drawing.Point(3, 461)
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Name = "GAD_MP_Form2_Home_SignUp_LoginLink"
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Size = New System.Drawing.Size(347, 24)
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.TabIndex = 4
        Me.GAD_MP_Form2_Home_SignUp_LoginLink.Text = "Already have an account? Login Now!"
        '
        'GAD_MP_Form2_Home_SignUp_PasswordTextBox
        '
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Location = New System.Drawing.Point(68, 164)
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Name = "GAD_MP_Form2_Home_SignUp_PasswordTextBox"
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox.Size = New System.Drawing.Size(250, 29)
        Me.GAD_MP_Form2_Home_SignUp_PasswordTextBox.TabIndex = 2
        '
        'GAD_MP_Form2_Home_SignUp_UsernameTextBox
        '
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Location = New System.Drawing.Point(68, 73)
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Name = "GAD_MP_Form2_Home_SignUp_UsernameTextBox"
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox.Size = New System.Drawing.Size(250, 29)
        Me.GAD_MP_Form2_Home_SignUp_UsernameTextBox.TabIndex = 1
        '
        'GAD_MP_Form2_Home_SignUp_PasswordLabel
        '
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.AutoSize = True
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.Location = New System.Drawing.Point(93, 126)
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.Name = "GAD_MP_Form2_Home_SignUp_PasswordLabel"
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.Size = New System.Drawing.Size(183, 26)
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.TabIndex = 1
        Me.GAD_MP_Form2_Home_SignUp_PasswordLabel.Text = "Create Password:"
        '
        'GAD_MP_Form2_Home_SignUp_UsernameLabel
        '
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.AutoSize = True
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.Font = New System.Drawing.Font("Microsoft JhengHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.Location = New System.Drawing.Point(93, 34)
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.Name = "GAD_MP_Form2_Home_SignUp_UsernameLabel"
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.Size = New System.Drawing.Size(190, 26)
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.TabIndex = 0
        Me.GAD_MP_Form2_Home_SignUp_UsernameLabel.Text = "Create Username:"
        '
        'GAD_MP_Form2_SignUp_EP
        '
        Me.GAD_MP_Form2_SignUp_EP.ContainerControl = Me
        '
        'GAD_MP_Form2_SignUp_T1
        '
        '
        'GAD_MP_Form2_SignUp_T2
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GAD_MP_1.My.Resources.Resources.LoginSignImg1
        Me.PictureBox1.Location = New System.Drawing.Point(884, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(350, 350)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GAD_MP_1.My.Resources.Resources.LoginSignImg1
        Me.PictureBox2.Location = New System.Drawing.Point(55, 285)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(350, 347)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.GAD_MP_1.My.Resources.Resources.drinksL
        Me.PictureBox4.Location = New System.Drawing.Point(920, 23)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.GAD_MP_1.My.Resources.Resources.dessert_200px
        Me.PictureBox3.Location = New System.Drawing.Point(255, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'GAD_MP_Form2_SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GAD_MP_Form1_Home_LoginPanel)
        Me.Controls.Add(Me.GAD_MP_Form1_Home_TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "GAD_MP_Form2_SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GAD_MP_Form2_Login"
        Me.GAD_MP_Form1_Home_TitlePanel.ResumeLayout(False)
        Me.GAD_MP_Form1_Home_TitlePanel.PerformLayout()
        Me.GAD_MP_Form1_Home_LoginPanel.ResumeLayout(False)
        Me.GAD_MP_Form1_Home_LoginPanel.PerformLayout()
        CType(Me.GAD_MP_Form2_SignUp_EP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GAD_MP_Form1_Home_TitlePanel As System.Windows.Forms.Panel
    Friend WithEvents GAD_MP_Form1_Title As System.Windows.Forms.Label
    Friend WithEvents GAD_MP_Form1_Home_LoginPanel As System.Windows.Forms.Panel
    Friend WithEvents GAD_MP_Form1_Home_SubmitBtn As System.Windows.Forms.Button
    Friend WithEvents GAD_MP_Form2_Home_SignUp_LoginLink As System.Windows.Forms.Label
    Friend WithEvents GAD_MP_Form2_Home_SignUp_UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GAD_MP_Form2_Home_SignUp_PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents GAD_MP_Form2_Home_SignUp_UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GAD_MP_Form2_SignUp_EmailLabel As System.Windows.Forms.Label
    Friend WithEvents GAD_MP_Form2_SignUp_PhoneNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GAD_MP_Form2_SignUp_PhoneNumLabel As System.Windows.Forms.Label
    Friend WithEvents GAD_MP_Form2_SignUp_EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GAD_MP_Form2_SignUp_EP As System.Windows.Forms.ErrorProvider
    Friend WithEvents GAD_MP_Form2_Home_SignUp_PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GAD_MP_Form2_SignUp_T1 As System.Windows.Forms.Timer
    Friend WithEvents GAD_MP_Form2_SignUp_T2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
