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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.OvalShape1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.OvalShape3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.OvalShape1, Me.OvalShape2, Me.OvalShape3, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(708, 313)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'OvalShape1
        '
        Me.OvalShape1.Cursor = System.Windows.Forms.Cursors.Default
        Me.OvalShape1.FillColor = System.Drawing.Color.Teal
        Me.OvalShape1.FillGradientColor = System.Drawing.Color.LemonChiffon
        Me.OvalShape1.Location = New System.Drawing.Point(300, 60)
        Me.OvalShape1.Name = "OvalShape1"
        Me.OvalShape1.Size = New System.Drawing.Size(50, 50)
        '
        'OvalShape2
        '
        Me.OvalShape2.Location = New System.Drawing.Point(300, 130)
        Me.OvalShape2.Name = "OvalShape2"
        Me.OvalShape2.Size = New System.Drawing.Size(50, 50)
        '
        'OvalShape3
        '
        Me.OvalShape3.Location = New System.Drawing.Point(300, 200)
        Me.OvalShape3.Name = "OvalShape3"
        Me.OvalShape3.Size = New System.Drawing.Size(50, 50)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RectangleShape1.FillGradientColor = System.Drawing.Color.Orange
        Me.RectangleShape1.Location = New System.Drawing.Point(285, 46)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(80, 220)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "EXP12 Traffic Signal "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(708, 313)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents OvalShape3 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents OvalShape1 As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents OvalShape2 As Microsoft.VisualBasic.PowerPacks.OvalShape

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "EXP12TrafficSignal"
        Me.BackColor = Color.Gray

        RectangleShape1.FillStyle = PowerPacks.FillStyle.Solid
        RectangleShape1.FillColor = Color.Black

        OvalShape1.FillStyle = PowerPacks.FillStyle.Percent80
        OvalShape2.FillStyle = PowerPacks.FillStyle.Percent80
        OvalShape3.FillStyle = PowerPacks.FillStyle.Percent80

        OvalShape1.FillColor = Color.Red
        OvalShape2.FillColor = Color.Orange
        OvalShape3.FillColor = Color.Green

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static count As Integer = 0 ' create a static variable to keep track of time

        count += 1 ' increment the count variable by 1 each time the Timer ticks

        Select Case count ' check the value of the count variable
            Case 1 To 3 ' first 10 seconds, show green light
                OvalShape1.FillColor = Color.Red
                OvalShape2.FillColor = Color.Gray
                OvalShape3.FillColor = Color.Gray
            Case 4 To 7 ' next 5 seconds, show yellow light
                OvalShape1.FillColor = Color.Gray
                OvalShape2.FillColor = Color.Orange
                OvalShape3.FillColor = Color.Gray
            Case 8 To 10 ' next 10 seconds, show red light
                OvalShape1.FillColor = Color.Gray
                OvalShape2.FillColor = Color.Gray
                OvalShape3.FillColor = Color.Green
            Case Else ' after 25 seconds, reset the count variable and start again
                count = 0
        End Select

    End Sub
End Class

