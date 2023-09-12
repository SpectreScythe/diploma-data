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
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ansFact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FactInput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FactBtn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ansFibo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fiboInput = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FiboBtn = New System.Windows.Forms.Button()
        Me.Tab1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TabPage1)
        Me.Tab1.Controls.Add(Me.TabPage2)
        Me.Tab1.Location = New System.Drawing.Point(10, 10)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Drawing.Point(10, 3)
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(310, 297)
        Me.Tab1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.ansFact)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.FactInput)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.FactBtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(302, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FactorialProg"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EXP12TabPrograms.My.Resources.Resources.DM12
        Me.Button1.Location = New System.Drawing.Point(10, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ansFact
        '
        Me.ansFact.Location = New System.Drawing.Point(70, 187)
        Me.ansFact.Name = "ansFact"
        Me.ansFact.Size = New System.Drawing.Size(150, 20)
        Me.ansFact.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Factorial:"
        '
        'FactInput
        '
        Me.FactInput.Location = New System.Drawing.Point(70, 95)
        Me.FactInput.Name = "FactInput"
        Me.FactInput.Size = New System.Drawing.Size(158, 20)
        Me.FactInput.TabIndex = 2
        Me.FactInput.Text = "Enter number here..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter range to calculate factoral:"
        '
        'FactBtn
        '
        Me.FactBtn.Location = New System.Drawing.Point(70, 230)
        Me.FactBtn.Name = "FactBtn"
        Me.FactBtn.Size = New System.Drawing.Size(150, 30)
        Me.FactBtn.TabIndex = 0
        Me.FactBtn.Text = "Generate Program"
        Me.FactBtn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.ansFibo)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.fiboInput)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.FiboBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(302, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "FibonacciProg"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.EXP12TabPrograms.My.Resources.Resources.LM22
        Me.Button2.Location = New System.Drawing.Point(10, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(40, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ansFibo
        '
        Me.ansFibo.Location = New System.Drawing.Point(70, 181)
        Me.ansFibo.Name = "ansFibo"
        Me.ansFibo.Size = New System.Drawing.Size(150, 20)
        Me.ansFibo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fibonacci Series:"
        '
        'fiboInput
        '
        Me.fiboInput.Location = New System.Drawing.Point(70, 91)
        Me.fiboInput.Name = "fiboInput"
        Me.fiboInput.Size = New System.Drawing.Size(158, 20)
        Me.fiboInput.TabIndex = 3
        Me.fiboInput.Text = "Enter number here..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter range to calculate fibonacci series:"
        '
        'FiboBtn
        '
        Me.FiboBtn.Location = New System.Drawing.Point(70, 230)
        Me.FiboBtn.Name = "FiboBtn"
        Me.FiboBtn.Size = New System.Drawing.Size(150, 30)
        Me.FiboBtn.TabIndex = 1
        Me.FiboBtn.Text = "Generate Program"
        Me.FiboBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 321)
        Me.Controls.Add(Me.Tab1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Tab1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents FactBtn As System.Windows.Forms.Button
    Friend WithEvents FiboBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FactInput As System.Windows.Forms.TextBox
    Friend WithEvents ansFact As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fiboInput As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ansFibo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
