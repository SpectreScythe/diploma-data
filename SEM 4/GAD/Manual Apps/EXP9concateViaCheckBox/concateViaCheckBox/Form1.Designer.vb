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
        Me.LblYo = New System.Windows.Forms.Label()
        Me.LblMr = New System.Windows.Forms.Label()
        Me.YoCB = New System.Windows.Forms.CheckBox()
        Me.MrCB = New System.Windows.Forms.CheckBox()
        Me.Sbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblYo
        '
        Me.LblYo.AutoSize = True
        Me.LblYo.Location = New System.Drawing.Point(148, 80)
        Me.LblYo.Name = "LblYo"
        Me.LblYo.Size = New System.Drawing.Size(20, 13)
        Me.LblYo.TabIndex = 0
        Me.LblYo.Text = "Yo"
        '
        'LblMr
        '
        Me.LblMr.AutoSize = True
        Me.LblMr.Location = New System.Drawing.Point(242, 80)
        Me.LblMr.Name = "LblMr"
        Me.LblMr.Size = New System.Drawing.Size(53, 13)
        Me.LblMr.TabIndex = 1
        Me.LblMr.Text = "Mr. White"
        '
        'YoCB
        '
        Me.YoCB.AutoSize = True
        Me.YoCB.Location = New System.Drawing.Point(137, 198)
        Me.YoCB.Name = "YoCB"
        Me.YoCB.Size = New System.Drawing.Size(81, 17)
        Me.YoCB.TabIndex = 2
        Me.YoCB.Text = "CheckBox1"
        Me.YoCB.UseVisualStyleBackColor = True
        '
        'MrCB
        '
        Me.MrCB.AutoSize = True
        Me.MrCB.Location = New System.Drawing.Point(276, 198)
        Me.MrCB.Name = "MrCB"
        Me.MrCB.Size = New System.Drawing.Size(81, 17)
        Me.MrCB.TabIndex = 3
        Me.MrCB.Text = "CheckBox1"
        Me.MrCB.UseVisualStyleBackColor = True
        '
        'Sbtn
        '
        Me.Sbtn.Location = New System.Drawing.Point(198, 260)
        Me.Sbtn.Name = "Sbtn"
        Me.Sbtn.Size = New System.Drawing.Size(75, 23)
        Me.Sbtn.TabIndex = 4
        Me.Sbtn.Text = "Submit"
        Me.Sbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 402)
        Me.Controls.Add(Me.Sbtn)
        Me.Controls.Add(Me.MrCB)
        Me.Controls.Add(Me.YoCB)
        Me.Controls.Add(Me.LblMr)
        Me.Controls.Add(Me.LblYo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblYo As System.Windows.Forms.Label
    Friend WithEvents LblMr As System.Windows.Forms.Label
    Friend WithEvents YoCB As System.Windows.Forms.CheckBox
    Friend WithEvents MrCB As System.Windows.Forms.CheckBox
    Friend WithEvents Sbtn As System.Windows.Forms.Button

End Class
