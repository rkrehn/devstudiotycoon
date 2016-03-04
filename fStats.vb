Public Class fStats

    Private Sub fStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class