Public Class fProject





    Private Sub fProject_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub TrackBar7_Scroll(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar7_Scroll(sender As Object) Handles TrackBar7.Scroll
        Testing.Text = TrackBar7.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub

    Private Sub TrackBar6_Scroll(sender As Object) Handles TrackBar6.Scroll
        ArtProduction.Text = TrackBar6.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub


    Private Sub TrackBar5_Scroll(sender As Object) Handles TrackBar5.Scroll
        LevelCreation.Text = TrackBar5.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub
    Private Sub TrackBar4_Scroll(sender As Object) Handles TrackBar4.Scroll
        Programming.Text = TrackBar4.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub

    Private Sub TrackBar3_Scroll(sender As Object) Handles TrackBar3.Scroll
        Design.Text = TrackBar3.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object) Handles TrackBar2.Scroll
        Production.Text = TrackBar2.Value
        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TotalPer As Integer

        Testing.Text = 5
        TrackBar7.Value = 5

        TotalPer = TextBox1.Text

        Production.Text = Math.Round(TextBox1.Text * (10 / 100))
        TrackBar2.Maximum = TextBox1.Text
        TrackBar2.Value = Production.Text
        Design.Text = Math.Round(TextBox1.Text * (15 / 100))
        TrackBar3.Maximum = TextBox1.Text
        TrackBar3.Value = Design.Text
        Programming.Text = Math.Round(TextBox1.Text * (25 / 100))
        TrackBar4.Maximum = TextBox1.Text
        TrackBar4.Value = Programming.Text
        LevelCreation.Text = Math.Round(TextBox1.Text * (25 / 100))
        TrackBar5.Maximum = TextBox1.Text
        TrackBar5.Value = LevelCreation.Text
        ArtProduction.Text = Math.Round(TextBox1.Text * (15 / 100))
        TrackBar6.Maximum = TextBox1.Text
        TrackBar6.Value = ArtProduction.Text

        DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)

        Do Until DefinedWeeks.Text = TextBox1.Text
            TotalPer = GetRandom(1, 5) 'randomly select which one drops 
            Select Case TotalPer
                Case Is = 1
                    If DefinedWeeks.Text < TextBox1.Text Then
                        Production.Text = Production.Text + 1
                    Else
                        Production.Text = Production.Text - 1
                    End If
                    TrackBar2.Value = Production.Text
                Case Is = 2
                    If DefinedWeeks.Text < TextBox1.Text Then
                        Design.Text = Design.Text + 1
                    Else
                        Design.Text = Design.Text - 1
                    End If
                    TrackBar3.Value = Design.Text
                Case Is = 3
                    If DefinedWeeks.Text < TextBox1.Text Then
                        Programming.Text = Programming.Text + 1
                    Else
                        Programming.Text = Programming.Text - 1
                    End If
                    TrackBar4.Value = Programming.Text
                Case Is = 4
                    If DefinedWeeks.Text < TextBox1.Text Then
                        LevelCreation.Text = LevelCreation.Text + 1
                    Else
                        LevelCreation.Text = LevelCreation.Text - 1
                    End If
                    TrackBar5.Value = LevelCreation.Text
                Case Is = 5
                    If DefinedWeeks.Text < TextBox1.Text Then
                        ArtProduction.Text = ArtProduction.Text + 1
                    Else
                        ArtProduction.Text = ArtProduction.Text - 1
                    End If
                    TrackBar6.Value = ArtProduction.Text
            End Select

            DefinedWeeks.Text = Val(Production.Text) + Val(Design.Text) + Val(Programming.Text) + Val(LevelCreation.Text) + Val(ArtProduction.Text) + Val(Testing.Text)
        Loop

        Call MsgBox("Below is the recommended schedule. Adjust as you deem necessary.", vbInformation)
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        If TextBox1.Text <> DefinedWeeks.Text Then
            Call MsgBox("The defined weeks must equal the timelin.", vbCritical)
            Exit Sub
        End If

        With FMain
            .DevelopStages.Items.Clear()
            .DevelopStages.Items.Add(Production.Text)
            .DevelopStages.Items.Add(Design.Text)
            .DevelopStages.Items.Add(Programming.Text)
            .DevelopStages.Items.Add(LevelCreation.Text)
            .DevelopStages.Items.Add(ArtProduction.Text)
            .DevelopStages.Items.Add(Testing.Text)

            'set up everything 
            .AllWeeks.Text = TextBox1.Text
            .Stage.Text = "Production"
            '.RadialBar2.Maximum = (3000 * ProgressMax)
            .RadialBar1.Maximum = DefinedWeeks.Text
            .RadialBar1.Value = 0
            .RadialBar2.Maximum = .DevelopStages.Items(0)
            .RadialBar2.Value = 0
            .Timer1.Enabled = True
        End With

        Me.Hide()
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class