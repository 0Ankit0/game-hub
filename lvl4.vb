Public Class lvl4
    Dim time As Integer = 0
    Dim jumping As Boolean = False
    Dim timing As Integer = 1
    Private Sub lvl4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Levels.Show()
    End Sub

    Private Sub lvl4_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                If PicChar.Bounds.IntersectsWith(PicWall8.Bounds) Then
                    PicChar.Left -= 3
                Else
                    Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_rt1
                    TimerRight.Start()
                End If

            Case Keys.Left
                If PicChar.Bounds.IntersectsWith(PicWall8.Bounds) Then
                    PicChar.Left += 3
                Else
                    Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_lf1
                    TimerLeft.Start()
                End If
            Case Keys.Up
                jumping = True
                TimerUp.Start()
        End Select
    End Sub

    Private Sub lvl4_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                If PicChar.Bounds.IntersectsWith(PicWall8.Bounds) Then
                    PicChar.Left -= 3
                Else
                    Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_rt2
                    TimerRight.Stop()
                End If

            Case Keys.Left
                If PicChar.Bounds.IntersectsWith(PicWall8.Bounds) Then
                    PicChar.Left += 3
                Else
                    Me.PicChar.Image = Global.Dungeon_run.My.Resources.Resources.avt1_lf2
                    TimerLeft.Stop()
                End If


        End Select
    End Sub



    Private Sub TimerRight_Tick(sender As Object, e As EventArgs) Handles TimerRight.Tick
        PicChar.Left += 10

        If PicChar.Bounds.IntersectsWith(PicDoor.Bounds) Then
            Me.Close()
        End If
        If PicChar.Bounds.IntersectsWith(PicSpike1.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike11.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike12.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike2.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike3.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike4.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike7.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike8.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike5.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike6.Bounds) Or
            PicChar.Top >= Me.Height Then
            Me.Close()
        End If
        If PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall11.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall5.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall6.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall7.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall3.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall4.Bounds) Then
            TimerDown.Stop()
        ElseIf jumping = False Then
            TimerDown.Start()
        End If
    End Sub

    Private Sub TimerLeft_Tick(sender As Object, e As EventArgs) Handles TimerLeft.Tick
        PicChar.Left -= 10
        If PicChar.Bounds.IntersectsWith(PicSpike1.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike11.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike12.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike2.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike3.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike4.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike5.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike6.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike7.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike8.Bounds) Or
            PicChar.Top >= Me.Height Then
            Me.Close()
        End If

        If PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall11.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall5.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall6.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall7.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall3.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall4.Bounds) Then
            TimerDown.Stop()
        ElseIf jumping = False Then
            TimerDown.Start()
        End If
    End Sub

    Private Sub TimerUp_Tick(sender As Object, e As EventArgs) Handles TimerUp.Tick
        If time <= 5 Then
            PicChar.Top -= 10
            time += 1
        ElseIf PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Then
            TimerDown.Stop()
            jumping = False
        Else
            TimerDown.Start()
            TimerUp.Stop()
            time = 0
            jumping = False
        End If
    End Sub

    Private Sub TimerDown_Tick(sender As Object, e As EventArgs) Handles TimerDown.Tick
        PicChar.Top += 10
        If PicChar.Bounds.IntersectsWith(PicWall1.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall11.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall2.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall5.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall6.Bounds) Or
          PicChar.Bounds.IntersectsWith(PicWall7.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall3.Bounds) Or
          PicChar.Bounds.IntersectsWith(Picwall4.Bounds) Then
            TimerDown.Stop()
        ElseIf PicChar.Bounds.IntersectsWith(PicSpike1.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike11.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike12.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike2.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike3.Bounds) Or
            PicChar.Bounds.IntersectsWith(Picspike4.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike5.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike6.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike7.Bounds) Or
            PicChar.Bounds.IntersectsWith(PicSpike8.Bounds) Or
            PicChar.Top >= Me.Height Then
            Me.Close()
        End If
    End Sub


    Private Sub lvl4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub


    Private Sub TimerDrop_Tick(sender As Object, e As EventArgs) Handles TimerDrop.Tick
        If PicChar.Left >= PicSpike10.Left - PicChar.Width Then
            PicSpike10.Top += 5
            If PicSpike10.Bounds.IntersectsWith(PicWall11.Bounds) Then
                PicSpike10.Visible = False
                PicSpike10.Dispose()
            ElseIf PicSpike10.Bounds.IntersectsWith(PicChar.Bounds) Then
                Me.Close()
            End If

        End If
        If PicChar.Left >= PicSpike9.Left - PicChar.Width Then
            PicSpike9.Top += 5
            If PicSpike9.Bounds.IntersectsWith(PicWall11.Bounds) Then
                PicSpike9.Visible = False
                PicSpike9.Dispose()
            ElseIf PicSpike10.Bounds.IntersectsWith(PicChar.Bounds) Then
                Me.Close()
            End If

        End If
        If PicBullet.Bounds.IntersectsWith(PicChar.Bounds) Then

        End If
    End Sub

    Private Sub TimerBullet_Tick(sender As Object, e As EventArgs) Handles TimerBullet.Tick
        PicBullet.Left -= 2
        If PicChar.Bounds.IntersectsWith(PicBullet.Bounds) Then
            Me.Close()
        End If
    End Sub

    Private Sub TimerSpike_Tick(sender As Object, e As EventArgs) Handles TimerSpike.Tick
        If timing <= 15 Then
            PicSpike2.Top -= 5
            PicSpike6.Top -= 5
            timing += 1
        ElseIf timing > 30 And timing <= 45 Then
            PicSpike2.Top += 5
            PicSpike6.Top += 5
            timing += 1
        ElseIf timing > 15 And timing <= 30 Then
            timing += 1
        Else
            timing = 1
        End If

        If PicChar.Bounds.IntersectsWith(PicSpike1.Bounds) Or
           PicChar.Bounds.IntersectsWith(PicSpike2.Bounds) Or
           PicChar.Bounds.IntersectsWith(PicSpike3.Bounds) Or
           PicChar.Bounds.IntersectsWith(PicSpike5.Bounds) Or
           PicChar.Bounds.IntersectsWith(PicSpike6.Bounds) Then

            Me.Close()
        End If

    End Sub
End Class