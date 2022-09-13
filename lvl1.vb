Public Class lvl1
    Dim time As Integer = 0
    Private Sub lvl1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Levels.Show()
    End Sub

    Private Sub lvl1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_rt1
                TimerRight.Start()
            Case Keys.Left
                Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_lf1
                TimerLeft.Start()
            Case Keys.Up
                TimerUp.Start()
        End Select
    End Sub

    Private Sub lvl1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_rt2
                TimerRight.Stop()
            Case Keys.Left
                Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_lf2
                TimerLeft.Stop()
            Case Keys.Up
                time = 0

        End Select
    End Sub

    Private Sub TimerRight_Tick(sender As Object, e As EventArgs) Handles TimerRight.Tick
        PicChar.Left += 10
        If PicChar.Bounds.IntersectsWith(PicSpike.Bounds) Then
            Me.Close()
        End If
        If PicChar.Bounds.IntersectsWith(PicDoor.Bounds) Then
            Me.Close()
        End If
    End Sub

    Private Sub TimerLeft_Tick(sender As Object, e As EventArgs) Handles TimerLeft.Tick
        PicChar.Left -= 10
        If PicChar.Bounds.IntersectsWith(PicSpike.Bounds) Then
            Me.Close()
        End If
    End Sub

    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        If time <= 10 Then
            PicChar.Top -= 10
            time += 1
        ElseIf PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Then
            TimerDown.Stop()
        Else
            TimerDown.Start()
            TimerUp.Stop()
        End If
    End Sub

    Private Sub TimerDown_Tick(sender As Object, e As EventArgs) Handles TimerDown.Tick
        PicChar.Top += 10
        If PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Then
            TimerDown.Stop()
        ElseIf PicChar.Bounds.IntersectsWith(PicSpike.Bounds) Then
            Me.Close()
        End If
    End Sub

    Private Sub lvl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub


End Class