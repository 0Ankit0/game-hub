<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lvl2
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
        Me.PicWall4 = New System.Windows.Forms.PictureBox()
        Me.PicWall2 = New System.Windows.Forms.PictureBox()
        Me.PicWall1 = New System.Windows.Forms.PictureBox()
        Me.PicWall3 = New System.Windows.Forms.PictureBox()
        Me.PicWall5 = New System.Windows.Forms.PictureBox()
        Me.PicDoor = New System.Windows.Forms.PictureBox()
        Me.PicSpike1 = New System.Windows.Forms.PictureBox()
        Me.PicSpike2 = New System.Windows.Forms.PictureBox()
        Me.PicSpike3 = New System.Windows.Forms.PictureBox()
        Me.TimerRight = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPlatform = New System.Windows.Forms.Timer(Me.components)
        Me.PicChar = New System.Windows.Forms.PictureBox()
        CType(Me.PicWall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicWall4
        '
        Me.PicWall4.Image = Global.Dungeon_run.My.Resources.Resources.stone
        Me.PicWall4.Location = New System.Drawing.Point(630, 278)
        Me.PicWall4.Name = "PicWall4"
        Me.PicWall4.Size = New System.Drawing.Size(40, 37)
        Me.PicWall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWall4.TabIndex = 0
        Me.PicWall4.TabStop = False
        '
        'PicWall2
        '
        Me.PicWall2.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall2.Location = New System.Drawing.Point(220, 278)
        Me.PicWall2.Name = "PicWall2"
        Me.PicWall2.Size = New System.Drawing.Size(135, 61)
        Me.PicWall2.TabIndex = 1
        Me.PicWall2.TabStop = False
        '
        'PicWall1
        '
        Me.PicWall1.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall1.Location = New System.Drawing.Point(0, 278)
        Me.PicWall1.Name = "PicWall1"
        Me.PicWall1.Size = New System.Drawing.Size(145, 61)
        Me.PicWall1.TabIndex = 2
        Me.PicWall1.TabStop = False
        '
        'PicWall3
        '
        Me.PicWall3.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall3.Location = New System.Drawing.Point(438, 278)
        Me.PicWall3.Name = "PicWall3"
        Me.PicWall3.Size = New System.Drawing.Size(126, 61)
        Me.PicWall3.TabIndex = 3
        Me.PicWall3.TabStop = False
        '
        'PicWall5
        '
        Me.PicWall5.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall5.Location = New System.Drawing.Point(682, 89)
        Me.PicWall5.Name = "PicWall5"
        Me.PicWall5.Size = New System.Drawing.Size(118, 40)
        Me.PicWall5.TabIndex = 4
        Me.PicWall5.TabStop = False
        '
        'PicDoor
        '
        Me.PicDoor.Image = Global.Dungeon_run.My.Resources.Resources.door
        Me.PicDoor.Location = New System.Drawing.Point(735, 12)
        Me.PicDoor.Name = "PicDoor"
        Me.PicDoor.Size = New System.Drawing.Size(65, 76)
        Me.PicDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDoor.TabIndex = 5
        Me.PicDoor.TabStop = False
        '
        'PicSpike1
        '
        Me.PicSpike1.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike1.Location = New System.Drawing.Point(138, 310)
        Me.PicSpike1.Name = "PicSpike1"
        Me.PicSpike1.Size = New System.Drawing.Size(85, 29)
        Me.PicSpike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike1.TabIndex = 7
        Me.PicSpike1.TabStop = False
        '
        'PicSpike2
        '
        Me.PicSpike2.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike2.Location = New System.Drawing.Point(352, 310)
        Me.PicSpike2.Name = "PicSpike2"
        Me.PicSpike2.Size = New System.Drawing.Size(90, 29)
        Me.PicSpike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike2.TabIndex = 8
        Me.PicSpike2.TabStop = False
        '
        'PicSpike3
        '
        Me.PicSpike3.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike3.Location = New System.Drawing.Point(561, 313)
        Me.PicSpike3.Name = "PicSpike3"
        Me.PicSpike3.Size = New System.Drawing.Size(74, 26)
        Me.PicSpike3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike3.TabIndex = 9
        Me.PicSpike3.TabStop = False
        '
        'TimerRight
        '
        '
        'TimerLeft
        '
        '
        'TimerUp
        '
        '
        'TimerDown
        '
        '
        'TimerPlatform
        '
        Me.TimerPlatform.Enabled = True
        '
        'PicChar
        '
        Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_fr1
        Me.PicChar.Location = New System.Drawing.Point(0, 246)
        Me.PicChar.Name = "PicChar"
        Me.PicChar.Size = New System.Drawing.Size(34, 36)
        Me.PicChar.TabIndex = 10
        Me.PicChar.TabStop = False
        '
        'lvl2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicDoor)
        Me.Controls.Add(Me.PicWall5)
        Me.Controls.Add(Me.PicWall3)
        Me.Controls.Add(Me.PicWall1)
        Me.Controls.Add(Me.PicWall2)
        Me.Controls.Add(Me.PicWall4)
        Me.Controls.Add(Me.PicChar)
        Me.Controls.Add(Me.PicSpike1)
        Me.Controls.Add(Me.PicSpike2)
        Me.Controls.Add(Me.PicSpike3)
        Me.Name = "lvl2"
        Me.Text = "lvl2"
        CType(Me.PicWall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicWall4 As PictureBox
    Friend WithEvents PicWall2 As PictureBox
    Friend WithEvents PicWall1 As PictureBox
    Friend WithEvents PicWall3 As PictureBox
    Friend WithEvents PicWall5 As PictureBox
    Friend WithEvents PicDoor As PictureBox
    Friend WithEvents PicSpike1 As PictureBox
    Friend WithEvents PicSpike2 As PictureBox
    Friend WithEvents PicSpike3 As PictureBox
    Friend WithEvents TimerRight As Timer
    Friend WithEvents TimerLeft As Timer
    Friend WithEvents TimerUp As Timer
    Friend WithEvents TimerDown As Timer
    Friend WithEvents TimerPlatform As Timer
    Friend WithEvents PicChar As PictureBox
End Class
