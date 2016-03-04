Public Class FDirection

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        Dim ArtSkills As Long, TechSkills As Long, GameSkills As Long, BugSkills As Long
        If StaffList.SelectedIndex = -1 Then Exit Sub

        If StaffList.SelectedIndex = 0 And StaffList.Items.Count > 4 Then
            Call MsgBox("You cannot select yourself as you have enough work to do managing the team.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'Set data
        ArtSkills = ArtBar.Value
        TechSkills = TechBar.Value
        GameSkills = Math.Round((ArtSkills + TechSkills) / 2)

        'Set visibility
        SlcLabel1.Visible = True
        SlcProgrssBar1.Visible = True
        SlcLabel2.Visible = True
        SlcProgrssBar2.Visible = True

        'Development
        With FMain
            If .Develop.Checked = True Or .Engine.Checked = True Or .Console.Checked = True Then
                'get bonus
                BugSkills = Math.Round(TechSkills)
                ArtSkills = Math.Round(ArtSkills * Val(.DevTeam.Text)) * My.Settings.DirectionGift
                GameSkills = Math.Round(GameSkills * Val(.DevTeam.Text)) * My.Settings.DirectionGift
                TechSkills = Math.Round(TechSkills * Val(.DevTeam.Text)) * My.Settings.DirectionGift

                'Position specialty
                Select Case txt_Position.Text
                    Case Is = "Artist"
                        ArtSkills = Math.Round(ArtSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                    Case Is = "Designer"
                        GameSkills = Math.Round(GameSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                    Case Is = "Writer"
                        ArtSkills = Math.Round(ArtSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                    Case Is = "Programmer"
                        TechSkills = Math.Round(TechSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                    Case Is = "Audio"
                        ArtSkills = Math.Round(ArtSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                    Case Is = "Tester"
                        BugSkills = Math.Round(TechSkills * (GetRandom(My.Settings.DirectMin, My.Settings.DirectMax) / 100))
                End Select

                'Based on stage
                Select Case .Stage.Text
                    Case Is = "Design"
                        SlcLabel1.Text = "Design"
                        Max1.Text = Math.Round(GameSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Designer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uDesign.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False
                    Case Is = "Programming"
                        SlcLabel1.Text = "Replay"
                        Max1.Text = Math.Round(GameSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uReplay.Text)

                        SlcLabel2.Text = "Gameplay"
                        Max2.Text = Math.Round(GameSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Programmer" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uGameplay.Text)
                    Case Is = "Level creation"
                        SlcLabel1.Text = "Gameplay"
                        Max1.Text = Math.Round(GameSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uGameplay.Text)

                        SlcLabel2.Text = "Design"
                        Max2.Text = Math.Round(ArtSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Designer" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uDesign.Text)
                    Case Is = "Art Production"
                        SlcLabel1.Text = "Art"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Artist" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uArt.Text)

                        SlcLabel2.Text = "Music"
                        Max2.Text = Math.Round(ArtSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Audio" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uMusic.Text)
                    Case Is = "Testing"
                        SlcLabel1.Text = "Bugs"
                        Max1.Text = Val(.uBugs.Text) - Math.Round(BugSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Tester" Then Max1.Text = Val(.uBugs.Text) - Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        If Val(Max1.Text) < 1 Then Max1.Text = 1

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False

                        'engine
                    Case Is = "Input"
                        SlcLabel1.Text = "Input"
                        Max1.Text = Math.Round(TechSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uInput.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False
                    Case Is = "Physics"
                        SlcLabel1.Text = "Physics"
                        Max1.Text = Math.Round(TechSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uPhysics.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False
                    Case Is = "Scripting"
                        SlcLabel1.Text = "Scripting"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Writer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uScripts.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False

                    Case Is = "Networking"
                        SlcLabel1.Text = "Networking"
                        Max1.Text = Math.Round(TechSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uNetwork.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False
                    Case Is = "GUI"
                        SlcLabel1.Text = "GUI"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Designer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uGUI.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False

                    Case Is = "Graphics and Sound"
                        SlcLabel1.Text = "Graphics and Sound"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Artist" Or txt_Position.Text = "Audio" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uGraphics.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False

                        'console
                    Case Is = "Hardware Design"
                        SlcLabel1.Text = "CPU"
                        Max1.Text = Math.Round(TechSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uCPU.Text)

                        SlcLabel2.Text = "Memory"
                        Max2.Text = Math.Round(TechSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Programmer" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uMemory.Text)
                    Case Is = "Software Design"
                        SlcLabel1.Text = "Software"
                        Max1.Text = Math.Round(GameSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Designer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uSoftware.Text)

                        SlcLabel2.Text = "Storage"
                        Max2.Text = Math.Round(GameSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Designer" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uStorage.Text)
                    Case Is = "Programming"
                        SlcLabel1.Text = "Programming"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Programmer" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uScripts.Text)

                        SlcLabel2.Visible = False
                        SlcProgrssBar2.Visible = False

                    Case Is = "Video and Audio"
                        SlcLabel1.Text = "Video"
                        Max1.Text = Math.Round(ArtSkills * (GetRandom(10, 25)) / 100)
                        If txt_Position.Text = "Artist" Then Max1.Text = Math.Round(Val(Max1.Text) * My.Settings.DirectionBonus)
                        Max1.Text = Val(Max1.Text) + Val(.uVideo.Text)

                        SlcLabel2.Text = "Audio"
                        Max2.Text = Math.Round(ArtSkills * (GetRandom(5, 15)) / 100)
                        If txt_Position.Text = "Audio" Then Max2.Text = Math.Round(Val(Max2.Text) * My.Settings.DirectionBonus)
                        Max2.Text = Val(Max2.Text) + Val(.uAudio.Text)
                End Select
            End If


            'Setup the progress bars
            If SlcLabel1.Text = "Design" Then
                If Val(Max1.Text) > Val(.DesignBar.Maximum) Then Max1.Text = Val(.DesignBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.DesignBar.Maximum)
                SlcProgrssBar1.Value = Val(.DesignBar.Value)
                .uDesign.Text = Max1.Text
            End If
            If SlcLabel2.Text = "Design" Then
                If Val(Max2.Text) > Val(.DesignBar.Maximum) Then Max2.Text = Val(.DesignBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.DesignBar.Maximum)
                SlcProgrssBar2.Value = Val(.DesignBar.Value)
                .uDesign.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Art" Then
                If Val(Max1.Text) > Val(.ArtBar.Maximum) Then Max1.Text = Val(.ArtBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.ArtBar.Maximum)
                SlcProgrssBar1.Value = Val(.ArtBar.Value)
                .uArt.Text = Max1.Text
            End If
            If SlcLabel2.Text = "Art" Then
                If Val(Max2.Text) > Val(.ArtBar.Maximum) Then Max2.Text = Val(.ArtBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.ArtBar.Maximum)
                SlcProgrssBar2.Value = Val(.ArtBar.Value)
                .uArt.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Gameplay" Then
                If Val(Max1.Text) > Val(.GameplayBar.Maximum) Then Max1.Text = Val(.GameplayBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.GameplayBar.Maximum)
                SlcProgrssBar1.Value = Val(.GameplayBar.Value)
                .uGameplay.Text = Max1.Text
            End If
            If SlcLabel2.Text = "Gameplay" Then
                If Val(Max2.Text) > Val(.GameplayBar.Maximum) Then Max2.Text = Val(.GameplayBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.GameplayBar.Maximum)
                SlcProgrssBar2.Value = Val(.GameplayBar.Value)
                .uGameplay.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Replay" Then
                If Val(Max1.Text) > Val(.ReplayBar.Maximum) Then Max1.Text = Val(.ReplayBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.ReplayBar.Maximum)
                SlcProgrssBar1.Value = Val(.ReplayBar.Value)
                .uReplay.Text = Max1.Text
            End If
            If SlcLabel2.Text = "Replay" Then
                If Val(Max2.Text) > Val(.ReplayBar.Maximum) Then Max2.Text = Val(.ReplayBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.ReplayBar.Maximum)
                SlcProgrssBar2.Value = Val(.ReplayBar.Value)
                .uReplay.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Music" Then
                If Val(Max1.Text) > Val(.MusicBar.Maximum) Then Max1.Text = Val(.MusicBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.MusicBar.Maximum)
                SlcProgrssBar1.Value = Val(.MusicBar.Value)
                .uMusic.Text = Max1.Text
            End If
            If SlcLabel2.Text = "Music" Then
                If Val(Max2.Text) > Val(.MusicBar.Maximum) Then Max2.Text = Val(.MusicBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.MusicBar.Maximum)
                SlcProgrssBar2.Value = Val(.MusicBar.Value)
                .uMusic.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Bugs" Then
                If Val(Max1.Text) < 0 Then Max1.Text = 0
                SlcProgrssBar1.Value = Val(.BugBar.Value)
                .uBugs.Text = Max1.Text
            End If

            'engine
            If SlcLabel1.Text = "Input" Then
                If Val(Max1.Text) > Val(.InputBar.Maximum) Then Max1.Text = Val(.InputBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.InputBar.Maximum)
                SlcProgrssBar1.Value = Val(.InputBar.Value)
                .uInput.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Physics" Then
                If Val(Max1.Text) > Val(.PhysicsBar.Maximum) Then Max2.Text = Val(.PhysicsBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.PhysicsBar.Maximum)
                SlcProgrssBar1.Value = Val(.PhysicsBar.Value)
                .uPhysics.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Scripting" Then
                If Val(Max1.Text) > Val(.ScriptBar.Maximum) Then Max1.Text = Val(.ScriptBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.ScriptBar.Maximum)
                SlcProgrssBar1.Value = Val(.ScriptBar.Value)
                .uScripts.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Networking" Then
                If Val(Max1.Text) > Val(.NetworkBar.Maximum) Then Max2.Text = Val(.NetworkBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.NetworkBar.Maximum)
                SlcProgrssBar1.Value = Val(.NetworkBar.Value)
                .uNetwork.Text = Max1.Text
            End If

            If SlcLabel1.Text = "GUI" Then
                If Val(Max1.Text) > Val(.guiBar.Maximum) Then Max1.Text = Val(.guiBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.guiBar.Maximum)
                SlcProgrssBar1.Value = Val(.guiBar.Value)
                .uGUI.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Graphics and Sound" Then
                If Val(Max1.Text) > Val(.SoundBar.Maximum) Then Max2.Text = Val(.SoundBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.SoundBar.Maximum)
                SlcProgrssBar1.Value = Val(.SoundBar.Value)
                .uSound.Text = Max1.Text
            End If

            'console
            If SlcLabel1.Text = "CPU" Then
                If Val(Max1.Text) > Val(.CPUBar.Maximum) Then Max1.Text = Val(.CPUBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.CPUBar.Maximum)
                SlcProgrssBar1.Value = Val(.CPUBar.Value)
                .uCPU.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Memory" Then
                If Val(Max2.Text) > Val(.MemoryBar.Maximum) Then Max2.Text = Val(.MemoryBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.MemoryBar.Maximum)
                SlcProgrssBar2.Value = Val(.MemoryBar.Value)
                .uCPU.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Software" Then
                If Val(Max1.Text) > Val(.SoftwareBar.Maximum) Then Max1.Text = Val(.SoftwareBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.SoftwareBar.Maximum)
                SlcProgrssBar1.Value = Val(.SoftwareBar.Value)
                .uSoftware.Text = Max1.Text
            End If

            If SlcLabel2.Text = "Storage" Then
                If Val(Max2.Text) > Val(.StorageBar.Maximum) Then Max2.Text = Val(.StorageBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.StorageBar.Maximum)
                SlcProgrssBar2.Value = Val(.StorageBar.Value)
                .uStorage.Text = Max2.Text
            End If

            If SlcLabel1.Text = "Programming" Then
                If Val(Max1.Text) > Val(.ProgrammingBar.Maximum) Then Max1.Text = Val(.ProgrammingBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.ProgrammingBar.Maximum)
                SlcProgrssBar1.Value = Val(.ProgrammingBar.Value)
                .uProgramming.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Video" Then
                If Val(Max1.Text) > Val(.VideoBar.Maximum) Then Max1.Text = Val(.VideoBar.Maximum)
                SlcProgrssBar1.Maximum = Val(.VideoBar.Maximum)
                SlcProgrssBar1.Value = Val(.VideoBar.Value)
                .uVideo.Text = Max1.Text
            End If

            If SlcLabel1.Text = "Audio" Then
                If Val(Max2.Text) > Val(.AudioBar.Maximum) Then Max2.Text = Val(.AudioBar.Maximum)
                SlcProgrssBar2.Maximum = Val(.AudioBar.Maximum)
                SlcProgrssBar2.Value = Val(.AudioBar.Value)
                .uAudio.Text = Max2.Text
            End If
        End With

        SlcGroupBox1.Visible = True
        Timer1.Enabled = True
    End Sub

    Private Sub StaffList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StaffList.SelectedIndexChanged
        Dim x As Integer = StaffList.SelectedIndex

        If x = -1 Then Exit Sub

        txt_Position.Text = GetEmployee(StaffData.Items(x), "Position")
        ArtBar.Value = GetEmployee(StaffData.Items(x), "Artist")
        TechBar.Value = GetEmployee(StaffData.Items(x), "Tech")
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        FMain.Timer1.Enabled = True

        Timer1.Enabled = False
        SlcGroupBox1.Visible = False
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SlcLabel1.Text <> "Bugs" Then
            If SlcProgrssBar1.Value < Val(Max1.Text) Then SlcProgrssBar1.Value = SlcProgrssBar1.Value + 100
            If SlcProgrssBar2.Value < Val(Max2.Text) Then SlcProgrssBar2.Value = SlcProgrssBar2.Value + 100

            If SlcProgrssBar1.Value >= Val(Max1.Text) And SlcProgrssBar2.Value >= Val(Max2.Text) Then Timer1.Enabled = False
        Else
            Dim tmpBar As Long = SlcProgrssBar1.Value
            tmpBar = SlcProgrssBar1.Value - 100

            If tmpBar < 1 Then tmpBar = 1
            If SlcProgrssBar1.Value > 1 Then SlcProgrssBar1.Value = tmpBar

            If SlcProgrssBar1.Value <= 0 Then Timer1.Enabled = False
        End If
    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub
End Class