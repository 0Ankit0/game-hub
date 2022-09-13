<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lvl1
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
        Me.PicWall1 = New System.Windows.Forms.PictureBox()
        Me.PicWall2 = New System.Windows.Forms.PictureBox()
        Me.PicSpike = New System.Windows.Forms.PictureBox()
        Me.PicChar = New System.Windows.Forms.PictureBox()
        Me.TimerRight = New System.Windows.Forms.Timer(Me.components)
        Me.TimerLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUp = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDown = New System.Windows.Forms.Timer(Me.components)
        Me.PicDoor = New System.Windows.Forms.PictureBox()
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicWall1
        '
        Me.PicWall1.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall1.Location = New System.Drawing.Point(1, 204)
        Me.PicWall1.Name = "PicWall1"
        Me.PicWall1.Size = New System.Drawing.Size(359, 36)
        Me.PicWall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWall1.TabIndex = 0
        Me.PicWall1.TabStop = False
        '
        'PicWall2
        '
        Me.PicWall2.Image = Global.Dungeon_run.My.Resources.Resources.tile
        Me.PicWall2.Location = New System.Drawing.Point(474, 204)
        Me.PicWall2.Name = "PicWall2"
        Me.PicWall2.Size = New System.Drawing.Size(328, 36)
        Me.PicWall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicWall2.TabIndex = 1
        Me.PicWall2.TabStop = False
        '
        'PicSpike
        '
        Me.PicSpike.Image = Global.Dungeon_run.My.Resources.Resources.spike
        Me.PicSpike.Location = New System.Drawing.Point(366, 204)
        Me.PicSpike.Name = "PicSpike"
        Me.PicSpike.Size = New System.Drawing.Size(102, 36)
        Me.PicSpike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSpike.TabIndex = 2
        Me.PicSpike.TabStop = False
        '
        'PicChar
        '
        Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_fr1
        Me.PicChar.Location = New System.Drawing.Point(29, 169)
        Me.PicChar.Name = "PicChar"
        Me.PicChar.Size = New System.Drawing.Size(34, 36)
        Me.PicChar.TabIndex = 3
        Me.PicChar.TabStop = False
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
        'PicDoor
        '
        Me.PicDoor.Image = Global.Dungeon_run.My.Resources.Resources.door
        Me.PicDoor.Location = New System.Drawing.Point(718, 129)
        Me.PicDoor.Name = "PicDoor"
        Me.PicDoor.Size = New System.Drawing.Size(64, 75)
        Me.PicDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicDoor.TabIndex = 4
        Me.PicDoor.TabStop = False
        '
        'lvl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PicDoor)
        Me.Controls.Add(Me.PicSpike)
        Me.Controls.Add(Me.PicWall2)
        Me.Controls.Add(Me.PicWall1)
        Me.Controls.Add(Me.PicChar)
        Me.Name = "lvl1"
        Me.Text = "lvl1"
        CType(Me.PicWall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicWall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicDoor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicWall1 As PictureBox
    Friend WithEvents PicWall2 As PictureBox
    Friend WithEvents PicSpike As PictureBox
    Friend WithEvents PicChar As PictureBox
    Friend WithEvents TimerRight As Timer
    Friend WithEvents TimerLeft As Timer
    Friend WithEvents TimerUp As Timer
    Friend WithEvents TimerDown As Timer
    Friend WithEvents PicDoor As PictureBox
End Class
