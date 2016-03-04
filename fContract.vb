Public Class fContract
    Private Sub fContract_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fContract_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub TheContract_Click(sender As Object, e As EventArgs)
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub TheContract_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SlCbtn3_Click(sender As Object, e As EventArgs) Handles SlCbtn3.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        'name, cost, timeframe, arttime, techtime
        Dim TheName As String, TheCost As String, TimeFrame As String, ArtTime As Long, TechTime As Long, TheQuest As String
        Dim temp As String, y As Integer, z As Integer

        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 1) - 1

        If z > (TheContractData.Items.Count - 1) Then z = TheContractData.Items.Count - 1

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        y = InStr(TheContractData.Items(z), ",") - 1
        TheName = Mid(TheContractData.Items(z), 1, y)
        temp = Mid(TheContractData.Items(z), y + 2)

        y = InStr(temp, ",") - 1
        TheCost = Mid(temp, 1, y)
        temp = Mid(temp, y + 2)

        y = InStr(temp, ",") - 1
        TimeFrame = Mid(temp, 1, y)
        temp = Mid(temp, y + 2)

        y = InStr(temp, ",") - 1
        ArtTime = Mid(temp, 1, y)
        temp = Mid(temp, y + 2)

        y = InStr(temp, "^") - 1
        TechTime = Mid(temp, 1, y)
        TheQuest = Mid(temp, y + 2)

        'name, cost, timeframe, arttime, techtime
        With FMain
            .AllWeeks.Text = Val(TimeFrame)
            .ConCash.Text = Val(TheCost)
            .cArt.Text = Val(ArtTime)
            .cTech.Text = Val(TechTime)

            .RadialBar2.Value = 0
            .RadialBar2.Maximum = Math.Round(Val(TechTime) + Val(ArtTime))
            .RadialBar1.Value = 0
            .RadialBar1.Maximum = TimeFrame

            .Contract.Checked = True

            .Label19.Enabled = True
            .Label20.Enabled = True
            .Stage.Text = "Contracting"
            .uArt.Text = 0
            .uDesign.Text = 0
            .uGameplay.Text = 0
            .uReplay.Text = 0
            .uStory.Text = 0
            .uMusic.Text = 0
            .uBugs.Text = 0

            .Label9.Enabled = False
        End With

        Me.Hide()
    End Sub

    Private Sub TheContractData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TheContractData.SelectedIndexChanged

    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1

        'Check last item
        If z < 1 Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & TheContractData.Items.Count

        'Build the textbox
        z = z - 1
        temp = TheContractData.Items(z)
        y = InStr(temp, "^") + 1
        TheQuest = Mid(temp, y)

        txt_TheJob.Text = TheQuest
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) + 1

        'Check last item
        If z > TheContractData.Items.Count Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & TheContractData.Items.Count

        'Build the textbox
        z = z - 1
        temp = TheContractData.Items(z)
        y = InStr(temp, "^") + 1
        TheQuest = Mid(temp, y)

        txt_TheJob.Text = TheQuest
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class