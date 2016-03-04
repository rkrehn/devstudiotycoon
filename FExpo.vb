Public Class fExpo

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BoothVisitors.Text = Math.Round(BoothVisitors.Text + GetRandom(1, 10))

    End Sub

    Private Sub BoothVisitors_Click(sender As Object, e As EventArgs) Handles BoothVisitors.Click

    End Sub

    Private Sub BoothVisitors_TextChanged(sender As Object, e As EventArgs) Handles BoothVisitors.TextChanged
        If Val(BoothVisitors.Text) >= Val(MaxVisitors.Text) Then Timer1.Enabled = False
    End Sub

    Private Sub fExpo_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fExpo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Integer
        My.Computer.Audio.Stop()
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        If Timer1.Enabled = True Then
            BoothVisitors.Text = MaxVisitors.Text
            Timer1.Enabled = False
        End If

        Call MsgBox("Your display was worth it. You pulled in " & FormatNumber(BoothVisitors.Text, 0) & " of " & FormatNumber(ConVisitors.Text, 0) & ". This brought up your hype by " & HypeBuild.Text & " points.", vbInformation)
        Me.Hide()

        With FMain

            If x > -1 Or .Console.Checked = True Then
                .CoMarketing.Text = Val(.CoMarketing.Text) + Val(HypeBuild.Text)
                .Marketing.Text = Val(.Marketing.Text) + Val(HypeBuild.Text)
            Else
                .Marketing.Text = Val(.Marketing.Text) + Val(HypeBuild.Text)
            End If
            .Timer1.Enabled = True
        End With
    End Sub
End Class