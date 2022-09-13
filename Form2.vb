Public Class Form2
    Private Sub BtnLevel_Click(sender As Object, e As EventArgs) Handles BtnLevel.Click
        Levels.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub BtnCostumes_Click(sender As Object, e As EventArgs) Handles BtnCostumes.Click
        Costumes.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonUser_Click(sender As Object, e As EventArgs) Handles ButtonUser.Click
        Users.Show()
        Me.Hide()
    End Sub


End Class
