Public Class fMarketing

    Public Sub MarketValue()
        Dim StrongCost As Long, SizeCost As Long, LenCost As Long

        Select Case ComboBox1.Text
            Case Is = "Magazine"
                StrongCost = GetRandom(3000, 6000)

                SizeCost = (StrongCost * TrackBar1.Value) + GetRandom(1000, 3000)

                LenCost = SizeCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value) * 10
            Case Is = "Radio"
                If TrackBar1.Value = 1 Then StrongCost = GetRandom(500, 1000)
                If TrackBar1.Value = 2 Then StrongCost = GetRandom(1000, 2500)
                If TrackBar1.Value = 3 Then StrongCost = GetRandom(2500, 4000)
                If TrackBar1.Value = 4 Then StrongCost = GetRandom(4000, 7000)
                If TrackBar1.Value = 5 Then StrongCost = GetRandom(7000, 9000)

                SizeCost = 0

                LenCost = StrongCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value) * 5
            Case Is = "Review Sites"
                If TrackBar1.Value = 1 Then StrongCost = GetRandom(50, 200)
                If TrackBar1.Value = 2 Then StrongCost = GetRandom(150, 300)
                If TrackBar1.Value = 3 Then StrongCost = GetRandom(250, 400)
                If TrackBar1.Value = 4 Then StrongCost = GetRandom(350, 500)
                If TrackBar1.Value = 5 Then StrongCost = GetRandom(450, 600)

                SizeCost = 0

                LenCost = StrongCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value)
            Case Is = "Social Media"
                If TrackBar1.Value = 1 Then StrongCost = GetRandom(50, 200)
                If TrackBar1.Value = 2 Then StrongCost = GetRandom(150, 300)
                If TrackBar1.Value = 3 Then StrongCost = GetRandom(250, 400)
                If TrackBar1.Value = 4 Then StrongCost = GetRandom(350, 500)
                If TrackBar1.Value = 5 Then StrongCost = GetRandom(450, 600)

                SizeCost = 0

                LenCost = StrongCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value)

            Case Is = "Television"
                StrongCost = GetRandom(6000, 9000)

                SizeCost = (StrongCost * TrackBar1.Value) + GetRandom(2000, 5000)

                LenCost = SizeCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value) * 15

            Case Is = "Trailer"
                If TrackBar1.Value = 1 Then StrongCost = GetRandom(700, 1250)
                If TrackBar1.Value = 2 Then StrongCost = GetRandom(1000, 2000)
                If TrackBar1.Value = 3 Then StrongCost = GetRandom(1500, 3000)
                If TrackBar1.Value = 4 Then StrongCost = GetRandom(2500, 4000)
                If TrackBar1.Value = 5 Then StrongCost = GetRandom(3500, 5000)

                SizeCost = 0

                LenCost = StrongCost * TrackBar2.Value

                Label10.Text = (TrackBar1.Value + TrackBar2.Value) * 3
        End Select

        Label9.Text = StrongCost + SizeCost + LenCost
    End Sub

    Private Sub fMarketing_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim MarketNum As Integer

        MarketNum = Label10.Text

        With FMain
            If Val(.Cash.Text) < Val(Label9.Text) Then
                Call MsgBox("You do not have enough money for this campaign!", vbCritical + vbOKOnly)
                Exit Sub
            Else
                'separates console from games
                x = .NewConsoles.FindString(.YourCo.Text)
                If x > -1 Or .Console.Checked = True Then
                    .Cash.Text = Math.Round(.Cash.Text - Label9.Text)
                    .CoMarketing.Text = Val(.CoMarketing.Text) + MarketNum
                    .Marketing.Text = Val(.Marketing.Text) + MarketNum
                Else
                    .Cash.Text = Math.Round(.Cash.Text - Label9.Text)
                    .Marketing.Text = Val(.Marketing.Text) + MarketNum
                End If
            End If
        End With

        Me.Hide()
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object) Handles TrackBar1.Scroll
        Call MarketValue()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object) Handles TrackBar2.Scroll
        Call MarketValue()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call MarketValue()
    End Sub

End Class