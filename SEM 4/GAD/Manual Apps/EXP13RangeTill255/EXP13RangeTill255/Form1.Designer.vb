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
        Me.Rangelbl = New System.Windows.Forms.Label()
        Me.RangeTxtB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Rangelbl
        '
        Me.Rangelbl.AutoSize = True
        Me.Rangelbl.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rangelbl.Location = New System.Drawing.Point(110, 128)
        Me.Rangelbl.Name = "Rangelbl"
        Me.Rangelbl.Size = New System.Drawing.Size(275, 28)
        Me.Rangelbl.TabIndex = 0
        Me.Rangelbl.Text = "Enter range from 0 to 255:"
        '
        'RangeTxtB
        '
        Me.RangeTxtB.Location = New System.Drawing.Point(391, 135)
        Me.RangeTxtB.Name = "RangeTxtB"
        Me.RangeTxtB.Size = New System.Drawing.Size(100, 20)
        Me.RangeTxtB.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Check"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(731, 57)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Regular Expression Go brbrbr..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RangeTxtB)
        Me.Controls.Add(Me.Rangelbl)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Rangelbl As System.Windows.Forms.Label
    Friend WithEvents RangeTxtB As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
