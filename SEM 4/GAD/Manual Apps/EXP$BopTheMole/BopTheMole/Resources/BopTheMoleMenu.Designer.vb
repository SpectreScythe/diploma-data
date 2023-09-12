<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BopTheMoleMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BopTheMoleMenu))
        Me.startBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(393, 267)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(75, 23)
        Me.startBtn.TabIndex = 0
        Me.startBtn.Text = "START"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(393, 335)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'BopTheMoleMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 741)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.startBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BopTheMoleMenu"
        Me.Text = "BopTheMoleMenu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents startBtn As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
End Class
