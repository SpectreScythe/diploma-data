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
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.loadingStatus = New System.Windows.Forms.Label()
        Me.loadingPercentage = New System.Windows.Forms.Label()
        Me.startStopBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'progressBar
        '
        Me.progressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.progressBar.Location = New System.Drawing.Point(238, 70)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(314, 23)
        Me.progressBar.TabIndex = 0
        '
        'loadingStatus
        '
        Me.loadingStatus.AutoSize = True
        Me.loadingStatus.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadingStatus.Location = New System.Drawing.Point(233, 28)
        Me.loadingStatus.Name = "loadingStatus"
        Me.loadingStatus.Size = New System.Drawing.Size(196, 28)
        Me.loadingStatus.TabIndex = 1
        Me.loadingStatus.Text = "Press Start to load"
        '
        'loadingPercentage
        '
        Me.loadingPercentage.AutoSize = True
        Me.loadingPercentage.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadingPercentage.Location = New System.Drawing.Point(234, 96)
        Me.loadingPercentage.Name = "loadingPercentage"
        Me.loadingPercentage.Size = New System.Drawing.Size(29, 19)
        Me.loadingPercentage.TabIndex = 2
        Me.loadingPercentage.Text = "0%"
        '
        'startStopBtn
        '
        Me.startStopBtn.Location = New System.Drawing.Point(327, 131)
        Me.startStopBtn.Name = "startStopBtn"
        Me.startStopBtn.Size = New System.Drawing.Size(100, 40)
        Me.startStopBtn.TabIndex = 3
        Me.startStopBtn.Text = "Start"
        Me.startStopBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.startStopBtn)
        Me.Controls.Add(Me.loadingPercentage)
        Me.Controls.Add(Me.loadingStatus)
        Me.Controls.Add(Me.progressBar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents progressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents loadingStatus As System.Windows.Forms.Label
    Friend WithEvents loadingPercentage As System.Windows.Forms.Label
    Friend WithEvents startStopBtn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
