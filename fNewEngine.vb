Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class fNewEngine
    Private Sub GameName_TextChanged(sender As Object, e As EventArgs)
        If InStr(GameName.Text, ",") <> 0 Then
            Call MsgBox("The comma character is not allowed!", MsgBoxStyle.Critical)
            Replace(GameName.Text, ",", "")
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GameName.Text = FMain.EngineNames.Items(GetRandom(0, FMain.EngineNames.Items.Count))
    End Sub

    Private Sub fNewEngine_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fNewEngine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim TheWe As Long

        Me.Hide()

        With fEngineProj
            FMain.EngName.Text = GameName.Text
            FMain.EngConsole.Text = ComboBox5.Text

            FMain.ThePublisher.Text = "Self"
            FMain.AllWeeks.Text = -1

            TheWe = Math.Round(FMain.Cash.Text / Expenses())
            If TheWe > 265 Then TheWe = 265

            If TheWe < 14 Then
                Call MsgBox("You should spend at least 12 weeks developing an engine. Based on your cash level and expenses you're unable to do so.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            .HScrollBar1.Maximum = TheWe
            .HScrollBar1.Minimum = 12
            .HScrollBar1.Value = Math.Round((.HScrollBar1.Maximum + .HScrollBar1.Minimum) / 2)
            .HScrollBar1.Enabled = True

           If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
            .Show()
        End With
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub
End Class