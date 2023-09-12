<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BopTheMoleGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BopTheMoleGame))
        Me.MoleSpawnRate = New System.Windows.Forms.Timer(Me.components)
        Me.moleSpawnPoint = New System.Windows.Forms.PictureBox()
        CType(Me.moleSpawnPoint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MoleSpawnRate
        '
        Me.MoleSpawnRate.Enabled = True
        Me.MoleSpawnRate.Interval = 500
        '
        'moleSpawnPoint
        '
        Me.moleSpawnPoint.Image = Global.BopTheMole.My.Resources.Resources.mole
        Me.moleSpawnPoint.Location = New System.Drawing.Point(281, 170)
        Me.moleSpawnPoint.Name = "moleSpawnPoint"
        Me.moleSpawnPoint.Size = New System.Drawing.Size(100, 100)
        Me.moleSpawnPoint.TabIndex = 0
        Me.moleSpawnPoint.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 679)
        Me.Controls.Add(Me.moleSpawnPoint)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.moleSpawnPoint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MoleSpawnRate As System.Windows.Forms.Timer
    Friend WithEvents moleSpawnPoint As System.Windows.Forms.PictureBox

End Class
