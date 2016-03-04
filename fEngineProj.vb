Public Class fEngineProj

    Private Sub fEngineProj_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TotalPer As Integer

        TotalPer = TextBox1.Text

        'issue here
        TheInput.Text = Math.Round(Math.Round(TotalPer * (15 / 100)))
        'HScrollBar1.Maximum = Val(TotalPer)
        'HScrollBar1.Value = Val(TheInput.Text)
        ThePhysics.Text = Math.Round(TotalPer * (25 / 100))
        TrackBar3.Maximum = Val(TotalPer)
        TrackBar3.Value = Val(ThePhysics.Text)
        TheScripting.Text = Math.Round(TotalPer * (25 / 100))
        TrackBar4.Maximum = Val(TotalPer)
        TrackBar4.Value = Val(TheScripting.Text)
        TheNetworking.Text = Math.Round(TotalPer * (15 / 100))
        TrackBar5.Maximum = Val(TotalPer)
        TrackBar5.Value = Val(TheNetworking.Text)
        TheGUI.Text = Math.Round(TotalPer * (15 / 100))
        TrackBar6.Maximum = Val(TotalPer)
        TrackBar6.Value = Val(TheGUI.Text)
        GraphicsnSound.Text = Math.Round(TotalPer * (15 / 100))
        TrackBar7.Maximum = Val(TotalPer)
        TrackBar7.Value = Val(GraphicsnSound.Text)

        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

        Do Until DefinedWeeks.Text = TextBox1.Text
            TotalPer = GetRandom(1, 6) 'randomly select which one drops 
            Select Case TotalPer
                Case Is = 1
                    If DefinedWeeks.Text < TextBox1.Text Then
                        TheInput.Text = TheInput.Text + 1
                    Else
                        TheInput.Text = TheInput.Text - 1
                    End If
                    HScrollBar1.Value = TheInput.Text
                Case Is = 2
                    If DefinedWeeks.Text < TextBox1.Text Then
                        ThePhysics.Text = ThePhysics.Text + 1
                    Else
                        ThePhysics.Text = ThePhysics.Text - 1
                    End If
                    TrackBar3.Value = ThePhysics.Text
                Case Is = 3
                    If DefinedWeeks.Text < TextBox1.Text Then
                        TheScripting.Text = TheScripting.Text + 1
                    Else
                        TheScripting.Text = TheScripting.Text - 1
                    End If
                    TrackBar4.Value = TheScripting.Text
                Case Is = 4
                    If DefinedWeeks.Text < TextBox1.Text Then
                        TheNetworking.Text = TheNetworking.Text + 1
                    Else
                        TheNetworking.Text = TheNetworking.Text - 1
                    End If
                    TrackBar5.Value = TheNetworking.Text
                Case Is = 5
                    If DefinedWeeks.Text < TextBox1.Text Then
                        TheGUI.Text = TheGUI.Text + 1
                    Else
                        TheGUI.Text = TheGUI.Text - 1
                    End If
                    TrackBar6.Value = TheGUI.Text
                Case Is = 6
                    If DefinedWeeks.Text < TextBox1.Text Then
                        GraphicsnSound.Text = TheGUI.Text + 1
                    Else
                        GraphicsnSound.Text = TheGUI.Text - 1
                    End If
                    TrackBar7.Value = TheGUI.Text
            End Select

            DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)
        Loop

        Call MsgBox("Below is the recommended schedule. Adjust as you deem necessary.", vbInformation)
    End Sub

    Private Sub SlcScrollBar1_Scroll(sender As Object)
        TheInput.Text = HScrollBar1.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

    End Sub

    Private Sub BaWGUITrackBar1_Scroll(sender As Object) Handles HScrollBar1.Scroll
        TextBox1.Text = HScrollBar1.Value
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object) Handles TrackBar2.Scroll
        TheInput.Text = TrackBar2.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object) Handles TrackBar3.Scroll
        ThePhysics.Text = TrackBar3.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object) Handles TrackBar4.Scroll
        TheScripting.Text = TrackBar4.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

    End Sub

    Private Sub TrackBar5_Scroll(sender As Object) Handles TrackBar5.Scroll
        TheNetworking.Text = TrackBar5.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

    End Sub

    Private Sub BaWGUITrackBar5_Scroll(sender As Object) Handles TrackBar6.Scroll
        TheGUI.Text = TrackBar6.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

    End Sub
    Private Sub TrackBar7_Scroll(sender As Object) Handles TrackBar7.Scroll
        GraphicsnSound.Text = TrackBar7.Value
        DefinedWeeks.Text = Val(TheInput.Text) + Val(ThePhysics.Text) + Val(TheScripting.Text) + Val(TheNetworking.Text) + Val(TheGUI.Text) + Val(GraphicsnSound.Text)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        If TextBox1.Text <> DefinedWeeks.Text Then
            Call MsgBox("The defined weeks must equal the timeline.", vbCritical)
            Exit Sub
        End If

        With FMain
            .DevelopStages.Items.Clear()
            .DevelopStages.Items.Add(TheInput.Text)
            .DevelopStages.Items.Add(ThePhysics.Text)
            .DevelopStages.Items.Add(TheScripting.Text)
            .DevelopStages.Items.Add(TheNetworking.Text)
            .DevelopStages.Items.Add(TheGUI.Text)
            .DevelopStages.Items.Add(GraphicsnSound.Text)

            'reset 
            .uInput.Text = 0
            .uPhysics.Text = 0
            .uScripts.Text = 0
            .uNetwork.Text = 0
            .uGUI.Text = 0
            .uGraphics.Text = 0
            .uSound.Text = 0

            'set up everything 
            .Panel3.Visible = True
            .Engine.Checked = True
            .AllWeeks.Text = TextBox1.Text
            .Stage.Text = "Input"
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