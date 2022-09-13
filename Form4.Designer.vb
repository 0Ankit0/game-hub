<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEnemey = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShoot = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Plane = New System.Windows.Forms.PictureBox()
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        '
        'tmrLeft
        '
        '
        'tmrEnemey
        '
        '
        'tmrShoot
        '
        Me.tmrShoot.Interval = 1
        '
        'ScoreTimer
        '
        Me.ScoreTimer.Interval = 1000
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ScoreLabel.Location = New System.Drawing.Point(11, 9)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(55, 20)
        Me.ScoreLabel.TabIndex = 4
        Me.ScoreLabel.Text = "Score:"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(165, 283)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 66)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Restart"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Plane
        '
        Me.Plane.Image = Global.Dungeon_run.My.Resources.Resource1.player
        Me.Plane.Location = New System.Drawing.Point(197, 431)
        Me.Plane.Margin = New System.Windows.Forms.Padding(2)
        Me.Plane.Name = "Plane"
        Me.Plane.Size = New System.Drawing.Size(53, 46)
        Me.Plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Plane.TabIndex = 3
        Me.Plane.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(414, 502)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Plane)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.Plane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrEnemey As Timer
    Friend WithEvents tmrShoot As Timer
    Friend WithEvents ScoreTimer As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Plane As PictureBox
End Class
