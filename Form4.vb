Public Class Form4
    Dim BulletArray(6) As PictureBox
    Dim BulletNumber As Integer = 0
    Dim BulletOnSccreen(5) As Boolean
    Dim maxEnemy As Integer = 5
    Dim enemyArray(maxEnemy) As PictureBox
    Dim enemyOnScreen(maxEnemy) As Boolean
    Dim score As Integer = 0
    Dim enemySpeed As Single = 5

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer = 0
        Dim count As Integer = 1

        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Space
                For i = 0 To 5
                    If BulletOnSccreen(i) = True Then
                        count = count + 1

                    End If
                Next
                If count <= 5 Then
                    BulletOnSccreen(BulletNumber) = True
                    BulletArray(BulletNumber).Visible = True
                    BulletArray(BulletNumber).Top = Plane.Top + Plane.Height / 2 - BulletArray(BulletNumber).Height / 2
                    BulletArray(BulletNumber).Left = Plane.Left + Plane.Width / 2 - BulletArray(BulletNumber).Width / 2
                    BulletNumber += 1
                    If BulletNumber = 5 Then
                        BulletNumber = 0

                    End If
                End If

        End Select



    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()



        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        If (Plane.Location.X < 533) And (Plane.Left < Me.Width - 70) Then
            Plane.Left += 12
        End If

    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        If (Plane.Location.X > -4) Then
            Plane.Left -= 12
        End If


    End Sub

    Private Sub tmrShoot_Tick(sender As Object, e As EventArgs) Handles tmrShoot.Tick
        Dim i As Integer
        Dim j As Integer
        For i = 0 To 5
            If BulletOnSccreen(i) = True Then
                BulletArray(i).Top -= 6
            End If

            If BulletArray(i).Top <= -10 Then
                BulletOnSccreen(i) = False

            End If
            For j = 0 To maxEnemy
                If Collision(BulletArray(i), enemyArray(j)) Then
                    'Moves Enemies back to top at random location 
                    enemyArray(j).Top = 0
                    enemyArray(j).Left = Int(Rnd() * Me.Width)

                End If
            Next
        Next
    End Sub

    Private Sub createBullet(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim Bullet As New PictureBox
            Me.Controls.Add(Bullet)
            Bullet.Width = 5
            Bullet.Height = 20
            Bullet.BorderStyle = BorderStyle.FixedSingle
            Bullet.BackColor = Color.Red
            Bullet.Top = Plane.Top + Plane.Height / 2 - Plane.Height / 2
            Bullet.Left = Plane.Left + Plane.Width / 2 - Plane.Width / 2
            Bullet.BringToFront()
            tmrShoot.Start()
            BulletArray(i) = Bullet
            BulletArray(i).Visible = False
            BulletOnSccreen(i) = False

        Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createBullet(5)
        createEnemies(maxEnemy)
        tmrEnemey.Start()
        Randomize()
        ScoreTimer.Start()

    End Sub
    Private Sub createEnemies(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim Enemy As New PictureBox
            Enemy.Width = 20
            Enemy.Height = 35
            Enemy.BorderStyle = BorderStyle.FixedSingle
            ' Enemy.BackColor = Color.Blue
            Enemy.Image = Global.Dungeon_run.My.Resources.Resource1.villian
            Enemy.SizeMode = PictureBoxSizeMode.StretchImage
            Enemy.BackColor = System.Drawing.Color.Transparent
            ' Me.BackgroundImage = My.Resources.Enemy
            'Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.Controls.Add(Enemy)

            Enemy.Top = 50
            Enemy.Left = i * 85
            Enemy.BringToFront()
            tmrShoot.Start()
            enemyArray(i) = Enemy
            enemyArray(i).Visible = True
            enemyOnScreen(i) = True

        Next

    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False

        If Object1.Top + Object1.Height >= Object2.Top And
        Object2.Top + Object2.Height >= Object1.Top And
        Object1.Left + Object1.Width >= Object2.Left And
        Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            Collided = True
        End If
        Return Collided
    End Function
    'it shows how enemy moves
    Private Sub tmrEnemey_Tick(sender As Object, e As EventArgs) Handles tmrEnemey.Tick
        Dim i As Integer = 0
        Dim Random As Double

        For i = 0 To maxEnemy
            enemyArray(i).Top += enemySpeed
            'if enemy touches ground game ends
            If enemyArray(i).Top > Me.Height Then
                tmrRight.Stop()
                tmrLeft.Stop()
                tmrShoot.Stop()
                tmrEnemey.Stop()
                ScoreTimer.Stop()
                Button1.Visible = True
                'MsgBox("Game Over")
            End If
            Random = Rnd()

            If Random > 0.66 Then
                enemyArray(i).Left += 5
            ElseIf Random < 0.33 Then
                enemyArray(i).Left -= 5
            End If
            'Enemy cannot move off boundary
            If enemyArray(i).Left < 5 Then
                enemyArray(i).Left += 10
            End If
            If enemyArray(i).Left > (Me.Width - 40) Then
                enemyArray(i).Left -= 10
            End If
        Next
    End Sub

    Private Sub ScoreTimer_Tick(sender As Object, e As EventArgs) Handles ScoreTimer.Tick
        score += 1
        ScoreLabel.Text = "Score: " & score
        If score Mod 10 = 0 Then
            enemySpeed += 0.7

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
