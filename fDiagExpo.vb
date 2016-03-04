Public Class fDiagExpo
    Private Sub fDiagExpo_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)

    End Sub

    Private Sub fDiagExpo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim TheDesign As Long, TheArt As Long, TheGameplay As Long, TheReplay As Long, TheStory As Long, TheAudio As Long
        Dim TheRating As Integer, RatingPoints As Long, BoothPoints As Integer
        Dim TechLevel As Long, Usability As Long

        'Determines % of people will come based on game rating + 70% of booth size
        RatingPoints = Math.Round(My.Settings.DevPoints / 10)

        With FMain
            'Can afford?
            If Val(.Cash.Text) < Val(Cost.Text) Then
                Call MsgBox("You cannot afford this!", vbCritical)
                Exit Sub
            End If

            'Get rating
            If .Develop.Checked = True Then 'for games
                TheDesign = Math.Round(Val(.uDesign.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheArt = Math.Round(Val(.uArt.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheGameplay = Math.Round(Val(.uGameplay.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheReplay = Math.Round(Val(.uReplay.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheStory = Math.Round(Val(.uStory.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheAudio = Math.Round(Val(.uMusic.Text) / (RatingPoints * Val(.DevTeam.Text)))

                TheRating = GetRating(TheDesign * 100, TheArt * 100, TheGameplay * 100, TheReplay * 100, TheStory * 100, TheAudio * 100, 0, .GameGenre.Text)
            ElseIf .Engine.Checked = True Then 'for engine 
                TechLevel = Math.Round(Val(.uInput.Text) + Val(.uGraphics.Text) + Val(.uSound.Text) + Val(.uNetwork.Text) + Val(.uPhysics.Text)) / 5
                Usability = Math.Round(Val(.uGUI.Text) + Val(.uScripts.Text)) / 2

                TechLevel = Math.Round((TechLevel / (My.Settings.EngineDev * .DevTeam.Text)) * 100)
                Usability = Math.Round((Usability / (My.Settings.EngineDev * .DevTeam.Text)) * 100)

                TheRating = Math.Round((Usability + TechLevel) / 2)
                TheRating = Math.Round(TheRating / 100)

            ElseIf .Console.Checked = True Then 'for console 

                TechLevel = (Val(FMain.uCPU.Text) + Val(FMain.uMemory.Text) + Val(FMain.uSoftware.Text) + Val(FMain.uProgramming.Text) + Val(FMain.uStorage.Text) + Val(FMain.uVideo.Text) + Val(FMain.uAudio.Text)) / 7
                TechLevel = Math.Round((TechLevel / (My.Settings.ConsoleDev * FMain.DevTeam.Text)) * 100)

                TheRating = Math.Round(TechLevel / 100)
            Else
                TheRating = 1
            End If

            'TheRating = Math.Round(TheRating + (TrackBar1.Value * 0.7), 2)
            'If theRating > 20 Then theRating = 20

            Select Case TrackBar1.Value
                Case Is = 1
                    BoothPoints = 1
                Case Is = 2
                    BoothPoints = 2.5
                Case Is = 3
                    BoothPoints = 4.7
                Case Is = 4
                    BoothPoints = 6.3
                Case Is = 5
                    BoothPoints = 8.5
            End Select

            'cost deduction
            .Cash.Text = Math.Round(.Cash.Text - Cost.Text)

        End With

        With fExpo
            'expected visitors
            .ConVisitors.Text = ConVisitors.Text

            Dim ToBeVisits As Long = Math.Round(ConVisitors.Text * ((TheRating + BoothPoints) / 20))
            .MaxVisitors.Text = ToBeVisits  'max visitors based on % determined

            .HypeBuild.Text = 0

            ' how much hype is generated
            If Val(.MaxVisitors.Text) < 1000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 20)
            If Val(.MaxVisitors.Text) > 1000 And Val(.MaxVisitors.Text) <= 10000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 30)
            If Val(.MaxVisitors.Text) > 10000 And Val(.MaxVisitors.Text) <= 20000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 60)
            If Val(.MaxVisitors.Text) > 20000 And Val(.MaxVisitors.Text) <= 30000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 100)
            If Val(.MaxVisitors.Text) > 30000 And Val(.MaxVisitors.Text) <= 40000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 150)
            If Val(.MaxVisitors.Text) > 40000 Then .HypeBuild.Text = Math.Round((.MaxVisitors.Text / ConVisitors.Text) * 200)

            .BoothVisitors.Text = 0
            .Timer1.Enabled = True
            .Text = ConName.Text

            If Trackbar1.Value = 1 Then .PictureBox1.Image = My.Resources.ResourceManager.GetObject("Booth1")
            If Trackbar1.Value = 2 Then .PictureBox1.Image = My.Resources.ResourceManager.GetObject("Booth2")
            If Trackbar1.Value = 3 Then .PictureBox1.Image = My.Resources.ResourceManager.GetObject("Booth3")
            If Trackbar1.Value = 4 Then .PictureBox1.Image = My.Resources.ResourceManager.GetObject("Booth4")
            If Trackbar1.Value = 5 Then .PictureBox1.Image = My.Resources.ResourceManager.GetObject("Booth5")

            My.Computer.Audio.Stop()
           If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.expo, AudioPlayMode.BackgroundLoop)

            .SlcTheme1.Text = ConName.Text
            .Show()
        End With

        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)

        Me.Hide()
        FMain.Timer1.Enabled = True
    End Sub

    Private Sub BaWGUITrackBar1_Scroll(sender As Object) Handles TrackBar1.Scroll
        If TrackBar1.Value = 1 Then Cost.Text = Math.Round(ConVisitors.Text * 1.4)
        If TrackBar1.Value = 2 Then Cost.Text = Math.Round(ConVisitors.Text * 2.3)
        If TrackBar1.Value = 3 Then Cost.Text = Math.Round(ConVisitors.Text * 3.5)
        If TrackBar1.Value = 4 Then Cost.Text = Math.Round(ConVisitors.Text * 4.7)
        If TrackBar1.Value = 5 Then Cost.Text = Math.Round(ConVisitors.Text * 6.6)
    End Sub
End Class