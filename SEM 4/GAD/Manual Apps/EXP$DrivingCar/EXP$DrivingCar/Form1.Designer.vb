<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LaneACar = New System.Windows.Forms.PictureBox()
        Me.LaneCCar = New System.Windows.Forms.PictureBox()
        Me.PlayerCar = New System.Windows.Forms.PictureBox()
        Me.RoadNext = New System.Windows.Forms.Timer(Me.components)
        Me.DriveRight = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoverA = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoverB = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerMoverC = New System.Windows.Forms.Timer(Me.components)
        Me.DriveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LaneBCar = New System.Windows.Forms.PictureBox()
        Me.PlayerMoverB2 = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerScore = New System.Windows.Forms.Label()
        Me.PlayerSpeed = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.ReplayBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.LaneACar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaneCCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LaneBCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LaneACar
        '
        Me.LaneACar.Image = CType(resources.GetObject("LaneACar.Image"), System.Drawing.Image)
        Me.LaneACar.Location = New System.Drawing.Point(11, 209)
        Me.LaneACar.Name = "LaneACar"
        Me.LaneACar.Size = New System.Drawing.Size(40, 70)
        Me.LaneACar.TabIndex = 46
        Me.LaneACar.TabStop = False
        '
        'LaneCCar
        '
        Me.LaneCCar.Image = CType(resources.GetObject("LaneCCar.Image"), System.Drawing.Image)
        Me.LaneCCar.Location = New System.Drawing.Point(232, 269)
        Me.LaneCCar.Name = "LaneCCar"
        Me.LaneCCar.Size = New System.Drawing.Size(40, 70)
        Me.LaneCCar.TabIndex = 48
        Me.LaneCCar.TabStop = False
        '
        'PlayerCar
        '
        Me.PlayerCar.BackColor = System.Drawing.Color.Transparent
        Me.PlayerCar.Image = Global.EXP_DrivingCar.My.Resources.Resources.CarB2bg
        Me.PlayerCar.Location = New System.Drawing.Point(67, 225)
        Me.PlayerCar.Name = "PlayerCar"
        Me.PlayerCar.Size = New System.Drawing.Size(40, 70)
        Me.PlayerCar.TabIndex = 49
        Me.PlayerCar.TabStop = False
        '
        'RoadNext
        '
        Me.RoadNext.Enabled = True
        Me.RoadNext.Interval = 10
        '
        'DriveRight
        '
        Me.DriveRight.Enabled = True
        Me.DriveRight.Interval = 10
        '
        'PlayerMoverA
        '
        Me.PlayerMoverA.Enabled = True
        Me.PlayerMoverA.Interval = 10
        '
        'PlayerMoverB
        '
        Me.PlayerMoverB.Enabled = True
        Me.PlayerMoverB.Interval = 10
        '
        'PlayerMoverC
        '
        Me.PlayerMoverC.Enabled = True
        Me.PlayerMoverC.Interval = 10
        '
        'DriveLeft
        '
        Me.DriveLeft.Enabled = True
        Me.DriveLeft.Interval = 10
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(194, 212)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox3.TabIndex = 53
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(85, 212)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox4.TabIndex = 52
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(193, 342)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox5.TabIndex = 55
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(84, 342)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox6.TabIndex = 54
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(194, -33)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox7.TabIndex = 57
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(85, -33)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox8.TabIndex = 56
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Black
        Me.PictureBox9.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(300, 50)
        Me.PictureBox9.TabIndex = 59
        Me.PictureBox9.TabStop = False
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Enabled = True
        Me.ScoreTimer.Interval = 2000
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(194, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox2.TabIndex = 62
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(85, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'LaneBCar
        '
        Me.LaneBCar.Image = CType(resources.GetObject("LaneBCar.Image"), System.Drawing.Image)
        Me.LaneBCar.Location = New System.Drawing.Point(101, 55)
        Me.LaneBCar.Name = "LaneBCar"
        Me.LaneBCar.Size = New System.Drawing.Size(40, 70)
        Me.LaneBCar.TabIndex = 47
        Me.LaneBCar.TabStop = False
        '
        'PlayerMoverB2
        '
        Me.PlayerMoverB2.Enabled = True
        Me.PlayerMoverB2.Interval = 10
        '
        'PlayerScore
        '
        Me.PlayerScore.AutoSize = True
        Me.PlayerScore.BackColor = System.Drawing.Color.Black
        Me.PlayerScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerScore.ForeColor = System.Drawing.Color.White
        Me.PlayerScore.Location = New System.Drawing.Point(142, 9)
        Me.PlayerScore.Name = "PlayerScore"
        Me.PlayerScore.Size = New System.Drawing.Size(104, 29)
        Me.PlayerScore.TabIndex = 75
        Me.PlayerScore.Text = "SCORE:"
        '
        'PlayerSpeed
        '
        Me.PlayerSpeed.AutoSize = True
        Me.PlayerSpeed.BackColor = System.Drawing.Color.Black
        Me.PlayerSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerSpeed.ForeColor = System.Drawing.Color.White
        Me.PlayerSpeed.Location = New System.Drawing.Point(12, 9)
        Me.PlayerSpeed.Name = "PlayerSpeed"
        Me.PlayerSpeed.Size = New System.Drawing.Size(100, 29)
        Me.PlayerSpeed.TabIndex = 75
        Me.PlayerSpeed.Text = "SPEED:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.PictureBox12)
        Me.Panel1.Controls.Add(Me.ReplayBtn)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(289, 327)
        Me.Panel1.TabIndex = 79
        Me.Panel1.Visible = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(89, 30)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox12.TabIndex = 28
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Visible = False
        '
        'ReplayBtn
        '
        Me.ReplayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReplayBtn.Location = New System.Drawing.Point(46, 249)
        Me.ReplayBtn.Name = "ReplayBtn"
        Me.ReplayBtn.Size = New System.Drawing.Size(201, 47)
        Me.ReplayBtn.TabIndex = 24
        Me.ReplayBtn.TabStop = False
        Me.ReplayBtn.Text = "Play Again"
        Me.ReplayBtn.UseVisualStyleBackColor = True
        Me.ReplayBtn.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(42, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Sallu Bhai Confirmed"
        Me.Label1.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(46, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 54)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "GAME OVER"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PlayerSpeed)
        Me.Controls.Add(Me.PlayerScore)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PlayerCar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.LaneCCar)
        Me.Controls.Add(Me.LaneBCar)
        Me.Controls.Add(Me.LaneACar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LaneACar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaneCCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LaneBCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LaneACar As System.Windows.Forms.PictureBox
    Friend WithEvents LaneCCar As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerCar As System.Windows.Forms.PictureBox
    Friend WithEvents RoadNext As System.Windows.Forms.Timer
    Friend WithEvents DriveRight As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoverA As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoverB As System.Windows.Forms.Timer
    Friend WithEvents PlayerMoverC As System.Windows.Forms.Timer
    Friend WithEvents DriveLeft As System.Windows.Forms.Timer
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents ScoreTimer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LaneBCar As System.Windows.Forms.PictureBox
    Friend WithEvents PlayerMoverB2 As System.Windows.Forms.Timer
    Friend WithEvents PlayerScore As System.Windows.Forms.Label
    Friend WithEvents PlayerSpeed As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents ReplayBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
