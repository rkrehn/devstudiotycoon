Public Class fGameOver
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fSplash.Show()
        Me.Hide()
        My.Computer.Audio.Stop()
    End Sub
End Class