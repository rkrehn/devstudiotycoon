Public Class FNewConsole

    Private Sub GameName_TextChanged(sender As Object, e As EventArgs) Handles ConsoleName.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As Long, CoName As String
        x = GetRandom(1, 10)

        If x >= 0 And x <= 3 Then
            CoName = FMain.Console1.Items(GetRandom(0, FMain.Console1.Items.Count))
        Else
            CoName = FMain.Console1.Items(GetRandom(0, FMain.Console1.Items.Count))
            CoName = CoName & " " & FMain.Console2.Items(GetRandom(0, FMain.Console2.Items.Count))
        End If

        ConsoleName.Text = CoName

    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        If Len(ConsoleName.Text) <= 3 Then
            MsgBox("You need a longer name for a console.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Len(ConsoleName.Text) >= 16 Then
            MsgBox("You need a shorter name for a console.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If DefinedWeeks.Text <> TextBox1.Text Then
            MsgBox("The defined timeline does not match the amount of weeks.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        With FMain
            .DevelopStages.Items.Clear()
            .DevelopStages.Items.Add(TheHardware.Text)
            .DevelopStages.Items.Add(TheSoftware.Text)
            .DevelopStages.Items.Add(TheProgramming.Text)
            .DevelopStages.Items.Add(TheVideoandAudio.Text)

            'set up everything 
            .Console.Text = ConsoleName.Text
            .Console.Checked = True
            .AllWeeks.Text = HScrollBar1.Value
            .Stage.Text = "Hardware Design"
            .CoMarketing.Text = 0

            .RadialBar1.Maximum = DefinedWeeks.Text
            .RadialBar1.Value = 0
            .RadialBar2.Maximum = .DevelopStages.Items(0)
            .RadialBar2.Value = 0

            .uCPU.Text = 0
            .uMemory.Text = 0
            .uSoftware.Text = 0
            .uProgramming.Text = 0
            .uStorage.Text = 0
            .uVideo.Text = 0
            .uAudio.Text = 0
        End With

        Me.Hide()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TheSplit As Long, Diff As Long

        TheSplit = Math.Round(TextBox1.Text / 4)

        TheHardware.Text = TheSplit
        TheSoftware.Text = TheSplit
        TheProgramming.Text = TheSplit
        TheVideoandAudio.Text = TheSplit
        TrackBar2.Value = TheSplit
        TrackBar3.Value = TheSplit
        TrackBar4.Value = TheSplit
        BaWGUITrackBar1.Value = TheSplit

        If TextBox1.Text < DefinedWeeks.Text Then
            Diff = Val(TextBox1.Text) - Val(DefinedWeeks.Text)
            TheHardware.Text = Val(TheHardware.Text) + Diff
        End If

        If TextBox1.Text > DefinedWeeks.Text Then
            Diff = Val(TextBox1.Text) - Val(DefinedWeeks.Text)
            TheHardware.Text = Val(TheHardware.Text) - Diff
        End If
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object) Handles TrackBar2.Scroll
        TheHardware.Text = TrackBar2.Value
        DefinedWeeks.Text = Val(TheHardware.Text) + Val(TheSoftware.Text) + Val(TheProgramming.Text) + Val(TheVideoandAudio.Text)
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object) Handles TrackBar3.Scroll
        TheProgramming.Text = TrackBar3.Value
        DefinedWeeks.Text = Val(TheHardware.Text) + Val(TheSoftware.Text) + Val(TheProgramming.Text) + Val(TheVideoandAudio.Text)
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object) Handles TrackBar4.Scroll
        TheSoftware.Text = TrackBar4.Value
        DefinedWeeks.Text = Val(TheHardware.Text) + Val(TheSoftware.Text) + Val(TheProgramming.Text) + Val(TheVideoandAudio.Text)
    End Sub

    Private Sub BaWGUITrackBar1_Scroll(sender As Object) Handles BaWGUITrackBar1.Scroll
        TheVideoandAudio.Text = BaWGUITrackBar1.Value
        DefinedWeeks.Text = Val(TheHardware.Text) + Val(TheSoftware.Text) + Val(TheProgramming.Text) + Val(TheVideoandAudio.Text)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class