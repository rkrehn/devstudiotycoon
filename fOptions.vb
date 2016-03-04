Public Class fOptions

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        My.Settings.SettingsSound = SlcOnOffBox1.Checked
        My.Settings.SettingsMusic = SlcOnOffBox2.Checked

        My.Settings.AlertNewGame = SlcOnOffBox3.Checked
        My.Settings.AlertBankruptcy = SlcOnOffBox4.Checked
        My.Settings.AlertRetiredEngines = SlcOnOffBox5.Checked
        My.Settings.AlertRetiredGames = SlcOnOffBox6.Checked
        My.Settings.AlertRetiredGames = SlcOnOffBox7.Checked

        My.Settings.SettingsCorruptMode = SlcOnOffBox9.Checked

        My.Settings.Save()

        Call MsgBox("Settings saved!")
        Me.Hide()
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        My.Settings.Reload()
        My.Settings.Save()
    End Sub
End Class