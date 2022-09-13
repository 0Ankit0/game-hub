<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lvl3
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
        Me.TimerRight = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSpike = New System.Windows.Forms.Timer(Me.components)
        Me.PicWall2 = New System.Windows.Forms.PictureBox()
        Me.PicWall1 = New System.Windows.Forms.PictureBox()
        Me.PicChar = New System.Windows.Forms.PictureBox()
        Me.PicSpike1 = New System.Windows.Forms.PictureBox()
        Me.PicSpike3 = New System.Windows.Forms.PictureBox()
        Me.PicSpike5 = New System.Windows.Forms.PictureBox()
        Me.PicDoor = New System.Windows.Forms.PictureBox()
        Me.PicSpike2 = New System.Windows.Forms.PictureBox()
        Me.PicSpike6 = New System.Windows.Forms.PictureBox()
        Me.Picwall3 = New System.Windows.Forms.PictureBox()
        Me.Picwall4 = New System.Windows.Forms.PictureBox()
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picwall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picwall4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TimerSpike
        '
        Me.TimerSpike.Enabled = True
        '
        'PicWall2
        '
        Me.PicWall2.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall2.Location = New System.Drawing.Point(578, 315)
        Me.PicWall2.Name = "PicWall2"
        Me.PicWall2.Size = New System.Drawing.Size(221, 29)
        Me.PicWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWall2.TabIndex = 14
        Me.PicWall2.TabStop = False
        '
        'PicWall1
        '
        Me.PicWall1.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall1.Location = New System.Drawing.Point(1, 315)
        Me.PicWall1.Name = "PicWall1"
        Me.PicWall1.Size = New System.Drawing.Size(139, 29)
        Me.PicWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWall1.TabIndex = 13
        Me.PicWall1.TabStop = False
        '
        'PicChar
        '
        Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_fr1
        Me.PicChar.Location = New System.Drawing.Point(1, 285)
        Me.PicChar.Name = "PicChar"
        Me.PicChar.Size = New System.Drawing.Size(34, 36)
        Me.PicChar.TabIndex = 18
        Me.PicChar.TabStop = False
        '
        'PicSpike1
        '
        Me.PicSpike1.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike1.Location = New System.Drawing.Point(146, 315)
        Me.PicSpike1.Name = "PicSpike1"
        Me.PicSpike1.Size = New System.Drawing.Size(66, 29)
        Me.PicSpike1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike1.TabIndex = 15
        Me.PicSpike1.TabStop = False
        '
        'PicSpike3
        '
        Me.PicSpike3.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike3.Location = New System.Drawing.Point(327, 315)
        Me.PicSpike3.Name = "PicSpike3"
        Me.PicSpike3.Size = New System.Drawing.Size(75, 29)
        Me.PicSpike3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike3.TabIndex = 16
        Me.PicSpike3.TabStop = False
        '
        'PicSpike5
        '
        Me.PicSpike5.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike5.Location = New System.Drawing.Point(515, 315)
        Me.PicSpike5.Name = "PicSpike5"
        Me.PicSpike5.Size = New System.Drawing.Size(57, 29)
        Me.PicSpike5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike5.TabIndex = 17
        Me.PicSpike5.TabStop = False
        '
        'PicDoor
        '
        Me.PicDoor.Image = Global.Dungeon_run.My.Resources.Resources.door
        Me.PicDoor.Location = New System.Drawing.Point(734, 245)
        Me.PicDoor.Name = "PicDoor"
        Me.PicDoor.Size = New System.Drawing.Size(65, 76)
        Me.PicDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDoor.TabIndex = 22
        Me.PicDoor.TabStop = False
        '
        'PicSpike2
        '
        Me.PicSpike2.Image = Global.Dungeon_run.My.Resources.Resources.spike_ball
        Me.PicSpike2.Location = New System.Drawing.Point(229, 263)
        Me.PicSpike2.Name = "PicSpike2"
        Me.PicSpike2.Size = New System.Drawing.Size(85, 58)
        Me.PicSpike2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike2.TabIndex = 20
        Me.PicSpike2.TabStop = False
        '
        'PicSpike6
        '
        Me.PicSpike6.Image = Global.Dungeon_run.My.Resources.Resources.spike_ball
        Me.PicSpike6.Location = New System.Drawing.Point(578, 263)
        Me.PicSpike6.Name = "PicSpike6"
        Me.PicSpike6.Size = New System.Drawing.Size(85, 58)
        Me.PicSpike6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike6.TabIndex = 21
        Me.PicSpike6.TabStop = False
        '
        'Picwall3
        '
        Me.Picwall3.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.Picwall3.Location = New System.Drawing.Point(408, 315)
        Me.Picwall3.Name = "Picwall3"
        Me.Picwall3.Size = New System.Drawing.Size(101, 29)
        Me.Picwall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picwall3.TabIndex = 23
        Me.Picwall3.TabStop = False
        '
        'Picwall4
        '
        Me.Picwall4.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.Picwall4.Location = New System.Drawing.Point(218, 315)
        Me.Picwall4.Name = "Picwall4"
        Me.Picwall4.Size = New System.Drawing.Size(103, 29)
        Me.Picwall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picwall4.TabIndex = 24
        Me.Picwall4.TabStop = False
        '
        'lvl3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Picwall4)
        Me.Controls.Add(Me.Picwall3)
        Me.Controls.Add(Me.PicWall2)
        Me.Controls.Add(Me.PicWall1)
        Me.Controls.Add(Me.PicChar)
        Me.Controls.Add(Me.PicSpike1)
        Me.Controls.Add(Me.PicSpike3)
        Me.Controls.Add(Me.PicSpike5)
        Me.Controls.Add(Me.PicDoor)
        Me.Controls.Add(Me.PicSpike2)
        Me.Controls.Add(Me.PicSpike6)
        Me.Name = "lvl3"
        Me.Text = "lvl3"
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picwall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picwall4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicWall2 As PictureBox
    Friend WithEvents PicWall1 As PictureBox
    Friend WithEvents PicChar As PictureBox
    Friend WithEvents PicSpike1 As PictureBox
    Friend WithEvents PicSpike3 As PictureBox
    Friend WithEvents PicSpike5 As PictureBox
    Friend WithEvents PicDoor As PictureBox
    Friend WithEvents TimerRight As Timer
    Friend WithEvents TimerLeft As Timer
    Friend WithEvents TimerUp As Timer
    Friend WithEvents TimerDown As Timer
    Friend WithEvents TimerSpike As Timer
    Friend WithEvents PicSpike6 As PictureBox
    Friend WithEvents PicSpike2 As PictureBox
    Friend WithEvents Picwall3 As PictureBox
    Friend WithEvents Picwall4 As PictureBox
End Class
