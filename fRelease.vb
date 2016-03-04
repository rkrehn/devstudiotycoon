Public Class fRelease


    Private Sub fRelease_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fRelease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TheSales As Long, OrigSold As Long, CutSold As Long
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        'Form1.NewGames.Items.Add(FullGame.Text)

        With FMain
            .Label19.Enabled = True
            .Label20.Enabled = True
            If Val(.OwedCut.Text) = 0 Then .OwedCut.Text = 100 'sometimes cut is 0, but should be 100

            Dim TheData As String = FullGame.Text
            TheSales = GetGame(TheData, "Sales")
            TheSales = Challenges(TheSales) 'Game AI for difficulty
            TheData = GetGame(TheData, "Sales", TheSales)

            If Val(.TheYear.Text) <= 1990 Then OrigSold = Math.Round(TheSales * 30)
            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then OrigSold = Math.Round(TheSales * 40)
            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then OrigSold = Math.Round(TheSales * 50)
            If Val(.TheYear.Text) > 2010 Then OrigSold = Math.Round(TheSales * 60)

            'If Val(Form1.TheYear.Text) <= 1990 Then Form1.Cash.Text = Form1.Cash.Text + Math.Round(TheSales * (30 * (Form1.OwedCut.Text / 100)))
            'If Val(Form1.TheYear.Text) > 1990 And Val(Form1.TheYear.Text) <= 2000 Then Form1.Cash.Text = Form1.Cash.Text + Math.Round(TheSales * (40 * (Form1.OwedCut.Text / 100)))
            'If Val(Form1.TheYear.Text) > 2000 And Val(Form1.TheYear.Text) <= 2010 Then Form1.Cash.Text = Form1.Cash.Text + Math.Round(TheSales * (50 * (Form1.OwedCut.Text / 100)))
            'If Val(Form1.TheYear.Text) > 2010 Then Form1.Cash.Text = Form1.Cash.Text + Math.Round(TheSales * (60 * (Form1.OwedCut.Text / 100)))

            If .ThePublisher.Text <> "Self" Then 'if published by someone else, then display their cut
                CutSold = Math.Round(OrigSold * (.OwedCut.Text / 100))
                Call MsgBox("Congrats on your release! You sold " & FormatNumber(TheSales, 0) & " copies!" & vbNewLine & "Total earnings were " & FormatCurrency(OrigSold, 0) & vbNewLine & "After royalties, you earned " & FormatCurrency(CutSold, 0))
                .Cash.Text = Val(.Cash.Text) + CutSold
            Else
                'if self-published then keep everything!
                Call MsgBox("Congrats on your release! You sold " & FormatNumber(TheSales, 0) & " copies!" & vbNewLine & "Total earnings were " & FormatCurrency(OrigSold, 0))
                .Cash.Text = Val(.Cash.Text) + OrigSold
            End If

            '/temp removal to see if gengame works better 
            'Call GenGame(Form1.YourCo.Text, "Player")
            If My.Settings.AlertBankruptcy = True Then .NewsList.Items.Insert(0, .YourCo.Text & " just released " & GameName.Text & " with an overall rating of " & GetGame(TheData, "Rating"))
            .NewGames.Items.Add(TheData)

            'reputation
            .Reputation.Text = Val(.Reputation.Text) + Val(RepPoints.Text)

            'settings
            .Timer1.Enabled = True
            .Stage.Text = "Idle"

            Me.Hide()

        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
        Dim Que As String

        With FMain
            Que = MsgBox("Are you sure you want to cancel the project? It will cost a penalty of " & FormatCurrency(.DownPayment.Text, 0), vbYesNo)
            If Que = vbNo Then Exit Sub

            .Cash.Text = Val(.Cash.Text) - Val(.DownPayment.Text)
            .Reputation.Text = Math.Round(.Reputation.Text - GetRandom(50, 150))
            Call QuitDev()
        End With

        Me.Hide()
    End Sub

    Private Sub GameName_Click(sender As Object, e As EventArgs) Handles GameName.Click
        Dim ChgGame As String = InputBox("What would like to change the name to?", "Change name", GameName.Text)

        FullGame.Text = GetGame(FullGame.Text, "Name", ChgGame)
    End Sub
End Class