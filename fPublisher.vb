Public Class fPublisher

    Private Sub fPublisher_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)

        Call QuitDev()
    End Sub

    Private Sub fPublisher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub ThePublisher_Click(sender As Object, e As EventArgs) Handles ThePublisher.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub ThePublisher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThePublisher.SelectedIndexChanged

    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1

        'Check last item
        If z < 1 Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & ThePublisherData.Items.Count
        z = z - 1

        'Build the textbox
        temp = ThePublisherData.Items(z)
        y = InStr(temp, "^") + 1
        TheQuest = Mid(temp, y)

        txt_ThePublisher.Text = TheQuest
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) + 1

        'Check last item
        If z > ThePublisherData.Items.Count Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & ThePublisherData.Items.Count
        z = z - 1

        'Build the textbox
        temp = ThePublisherData.Items(z)
        y = InStr(temp, "^") + 1
        TheQuest = Mid(temp, y)

        txt_ThePublisher.Text = TheQuest
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        'name, timeframe, reward, percent
        Dim y As Integer, z As Integer, temp As String
        Dim CoName As String, TimeFrame As Integer, CashAward As Long, ThePer As Integer

        'If ThePublisher.SelectedIndex = -1 Then Exit Sub
        'z = ThePublisher.SelectedIndex
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 1) - 1

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        y = InStr(ThePublisherData.Items(z), ",") - 1
        CoName = Mid(ThePublisherData.Items(z), 1, y)
        temp = Mid(ThePublisherData.Items(z), y + 2)

        y = InStr(temp, ",") - 1
        TimeFrame = Mid(temp, 1, y)
        temp = Mid(temp, y + 2)

        y = InStr(temp, ",") - 1
        CashAward = Mid(temp, 1, y)
        temp = Mid(temp, y + 2)

        y = InStr(temp, "^") - 1
        ThePer = Mid(temp, 1, y)

        'name, timeframe, reward, percent
        With FMain
            .ThePublisher.Text = CoName
            .OwedCut.Text = Val(ThePer)
            .AllWeeks.Text = Val(TimeFrame)
            .Cash.Text = Val(.Cash.Text) + Val(CashAward)
            .DownPayment.Text = Math.Round(CashAward * 1.2)
            .RadialBar1.Maximum = Val(TimeFrame)
            .RadialBar1.Value = 0
        End With

        With fProject
            .HScrollBar1.Maximum = Math.Round(FMain.AllWeeks.Text * 1.4)
            .HScrollBar1.Minimum = Math.Round(FMain.AllWeeks.Text * 0.6)
            .HScrollBar1.Value = FMain.AllWeeks.Text
            .HScrollBar1.Enabled = False
            .TextBox1.Text = Val(TimeFrame)
            .TextBox1.Enabled = False
            .Show()
        End With

        Me.Hide()
    End Sub

    Private Sub txt_ThePublisher_TextChanged(sender As Object, e As EventArgs) Handles txt_ThePublisher.TextChanged

    End Sub

    Private Sub ThePublisherData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ThePublisherData.SelectedIndexChanged

    End Sub

    Private Sub lbl_Selected_Click(sender As Object, e As EventArgs) Handles lbl_Selected.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub
End Class