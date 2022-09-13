Public Class Levels
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub

    Private Sub Levels_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub BtnLvl1_Click(sender As Object, e As EventArgs) Handles BtnLvl1.Click
        lvl1.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLvl2_Click(sender As Object, e As EventArgs) Handles BtnLvl2.Click
        lvl2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLvl3_Click(sender As Object, e As EventArgs) Handles BtnLvl3.Click
        lvl3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLvl4_Click(sender As Object, e As EventArgs) Handles BtnLvl4.Click
        lvl4.Show()
        Me.Hide()
    End Sub
End Class