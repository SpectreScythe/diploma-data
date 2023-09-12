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
        Me.LightModeBtn = New System.Windows.Forms.RadioButton()
        Me.DarkModeBtn = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LightModeBtn
        '
        Me.LightModeBtn.AutoSize = True
        Me.LightModeBtn.Location = New System.Drawing.Point(156, 371)
        Me.LightModeBtn.Name = "LightModeBtn"
        Me.LightModeBtn.Size = New System.Drawing.Size(75, 17)
        Me.LightModeBtn.TabIndex = 0
        Me.LightModeBtn.TabStop = True
        Me.LightModeBtn.Text = "LightMode"
        Me.LightModeBtn.UseVisualStyleBackColor = True
        '
        'DarkModeBtn
        '
        Me.DarkModeBtn.AutoSize = True
        Me.DarkModeBtn.Location = New System.Drawing.Point(356, 371)
        Me.DarkModeBtn.Name = "DarkModeBtn"
        Me.DarkModeBtn.Size = New System.Drawing.Size(75, 17)
        Me.DarkModeBtn.TabIndex = 1
        Me.DarkModeBtn.TabStop = True
        Me.DarkModeBtn.Text = "DarkMode"
        Me.DarkModeBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Darkmode.My.Resources.Resources.lightmodepic1
        Me.PictureBox1.Location = New System.Drawing.Point(180, 103)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 221)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 451)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DarkModeBtn)
        Me.Controls.Add(Me.LightModeBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LightModeBtn As System.Windows.Forms.RadioButton
    Friend WithEvents DarkModeBtn As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
