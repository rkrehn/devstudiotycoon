Public Class fRandom

    Private Sub fRandom_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fRandom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.sound_event, AudioPlayMode.Background)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim x As Integer, y As Integer

        x = GetRandom(0, 100)
        y = Impact.Text

        If Cost.Text <> 0 Then
            If Val(FMain.Cash.Text) < Val(Cost.Text) Then
                Call MsgBox("You cannot afford this!", vbCritical + vbOKOnly)
                Me.Hide()
                Exit Sub
            Else
                FMain.Cash.Text = Math.Round(FMain.Cash.Text - Cost.Text)
                Call MsgBox("Purchase was a success!", vbInformation + vbOKOnly)
                Me.Hide()
                Exit Sub
            End If
        End If

        If Cost.Text = 0 Then
            If x < Val(SuccessRate.Text) Then
                Select Case Affected.Text
                    Case Is = "Gameplay"
                        FMain.uGameplay.Text = Val(FMain.uGameplay.Text) + Val(Approve.Text)
                    Case Is = "Story"
                        FMain.uStory.Text = Val(FMain.uStory.Text) + Val(Approve.Text)
                    Case Is = "Design"
                        FMain.uDesign.Text = Val(FMain.uDesign.Text) + Val(Approve.Text)
                    Case Is = "Art"
                        FMain.uArt.Text = Val(FMain.uArt.Text) + Val(Approve.Text)
                    Case Is = "Music"
                        FMain.uMusic.Text = Val(FMain.uMusic.Text) + Val(Approve.Text)
                    Case Is = "Physics"
                        FMain.uPhysics.Text = Val(FMain.uPhysics.Text) + Val(Approve.Text)
                    Case Is = "Input"
                        FMain.uInput.Text = Val(FMain.uInput.Text) + Val(Approve.Text)
                    Case Is = "Networking"
                        FMain.uNetwork.Text = Val(FMain.uNetwork.Text) + Val(Approve.Text)
                    Case Is = "Scripting"
                        FMain.uScripts.Text = Val(FMain.uScripts.Text) + Val(Approve.Text)
                    Case Is = "GUI"
                        FMain.uGUI.Text = Val(FMain.uGUI.Text) + Val(Approve.Text)
                    Case Is = "Graphics and Sound"
                        FMain.uGraphics.Text = Val(FMain.uGraphics.Text) + Val(Approve.Text)
                        FMain.uSound.Text = Val(FMain.uSound.Text) + Val(Approve.Text)
                End Select

                'adjust development time
                FMain.RadialBar2.Maximum = FMain.RadialBar2.Maximum + y
                If FMain.DevelopStages.Items.Count > 1 Then FMain.DevelopStages.Items(1) = Val(FMain.DevelopStages.Items(1)) - y

                If Impact.Text = 0 Then
                    Call MsgBox("It was a success! You have gained " & Approve.Text & " points towards " & Affected.Text & ".", vbInformation + vbOKOnly)
                Else
                    Call MsgBox("It was a success! You have gained " & Approve.Text & " points towards " & Affected.Text & "." & vbNewLine & "You lost " & Impact.Text & " weeks of development time.", vbInformation + vbOKOnly)
                End If

                Me.Hide()
            Else
                Select Case Affected.Text
                    Case Is = "Gameplay"
                        FMain.uGameplay.Text = Val(FMain.uGameplay.Text) - Val(Reject.Text)
                    Case Is = "Story"
                        FMain.uStory.Text = Val(FMain.uStory.Text) - Val(Reject.Text)
                    Case Is = "Design"
                        FMain.uDesign.Text = Val(FMain.uDesign.Text) - Val(Reject.Text)
                    Case Is = "Art"
                        FMain.uArt.Text = Val(FMain.uArt.Text) - Val(Reject.Text)
                    Case Is = "Music"
                        FMain.uMusic.Text = Val(FMain.uMusic.Text) - Val(Reject.Text)
                    Case Is = "Replay"
                        FMain.uReplay.Text = Val(FMain.uReplay.Text) - Val(Reject.Text)
                    Case Is = "Physics"
                        FMain.uPhysics.Text = Val(FMain.uPhysics.Text) - Val(Reject.Text)
                    Case Is = "Input"
                        FMain.uInput.Text = Val(FMain.uInput.Text) - Val(Reject.Text)
                    Case Is = "Networking"
                        FMain.uNetwork.Text = Val(FMain.uNetwork.Text) - Val(Reject.Text)
                    Case Is = "Scripting"
                        FMain.uScripts.Text = Val(FMain.uScripts.Text) - Val(Reject.Text)
                    Case Is = "GUI"
                        FMain.uGUI.Text = Val(FMain.uGUI.Text) - Val(Reject.Text)
                    Case Is = "Graphics and Sound"
                        FMain.uGraphics.Text = Val(FMain.uGraphics.Text) - Val(Reject.Text)
                        FMain.uSound.Text = Val(FMain.uSound.Text) - Val(Reject.Text)
                End Select

                FMain.RadialBar2.Maximum = FMain.RadialBar2.Maximum + 1
                If FMain.DevelopStages.Items.Count > 1 Then
                    FMain.DevelopStages.Items(1) = Val(FMain.DevelopStages.Items(1)) - y
                    If FMain.DevelopStages.Items(1) < 1 Then FMain.DevelopStages.Items(1) = 1
                End If

                If Impact.Text = 0 Then
                    Call MsgBox("It was a failure. You have lost " & Approve.Text & " points towards " & Affected.Text & ".", vbCritical + vbOKOnly)
                Else
                    Call MsgBox("It was a failure. You have lost " & Approve.Text & " points towards " & Affected.Text & "." & vbNewLine & "You lost " & Impact.Text & " weeks of development time.", vbCritical + vbOKOnly)
                End If

                Me.Hide()
            End If
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
        Me.Hide()
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class