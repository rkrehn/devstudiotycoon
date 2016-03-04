Public Class fPub_Marketing

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call MarketValue()
    End Sub
    Private Sub MarketValue()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Long, y As Long
        Dim MarketNum As Integer = Label10.Text
        Dim TheSales As Long = GetGame(FullGame.Text, "Sales")
        Dim TheRating As Integer = GetGame(FullGame.Text, "Rating")

        With FMain
            If Val(.Cash.Text) < Val(Label9.Text) Then
                Call MsgBox("You do not have enough money for this campaign!", vbCritical + vbOKOnly)
                Exit Sub
            Else
                Dim taco As Double = GetRandom(0, 150) + MarketNum
                TheSales = Math.Round(TheSales * (taco / My.Settings.MarketingFactor))
                FullGame.Text = GetGame(FullGame.Text, "Sales", TheSales)
            End If

GameAnnounce:
            Dim ConsoleHelp As Long, ConsoleSales As Long, ConsoleNewSales As Long, HelpCompany As String, ConsolePrice As Integer, CashValue As Long
            'announces the game!
            .NewsList.Items.Insert(0, .GameName.Text & " just released " & .GameName.Text & " with an overall rating of " & TheRating)
            .NewGames.Items.Add(FullGame.Text)

            'publishing cut
            If Val(.TheYear.Text) <= 1990 Then CashValue = (TheSales * 30)
            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then CashValue = (TheSales * 40)
            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then CashValue = (TheSales * 50)
            If Val(.TheYear.Text) > 2010 Then CashValue = (TheSales * 60)

            'Percentage of cut
            y = .OwnedStocks.FindString(GetGame(FullGame.Text, "Company"))
            If y <> -1 Then
                CashValue = CashValue * (GetStocks(.OwnedStocks.Items(y), "Sales") / 100)
            End If

            .Income.Text = Math.Round(Val(.Income.Text) + CashValue)

            'display tooltip
            .NewsList.Items.Insert(0, "Income sales for " & GameName.Text & " for week: " & TheSales & ". Earnings: $" & FormatNumber(.Income.Text, 0))

            .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))


            'increases sales for the system
            If TheRating >= 8 Then

                x = .NewConsoles.Items.Count - 1
                Do
                    x = x - 1
                Loop Until GetConsole(.NewConsoles.Items(x), "Console") = GetGame(FullGame.Text, "Console") Or x = 0

                y = GetRandom(20, 30)

                'get console data
                ConsoleSales = GetConsole(.NewConsoles.Items(x), "Sales")
                ConsoleNewSales = GetConsole(.NewConsoles.Items(x), "PreviousSales")
                HelpCompany = GetConsole(.NewConsoles.Items(x), "Company")
                ConsolePrice = GetConsole(.NewConsoles.Items(x), "Price")

                'increase sales
                ConsoleHelp = Math.Round(TheSales * (y / 100))
                .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", (ConsoleSales + ConsoleHelp))
                .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", (ConsoleNewSales + ConsoleHelp))

                'get that company money
                y = .Companies.FindString(HelpCompany)
                If y <> -1 Then .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", (ConsolePrice * ConsoleHelp))


                .NewsList.Items.Insert(0, "Sales of " & GameName.Text & " have increased sales of console " & GetConsole(.NewConsoles.Items(x), "Console") & " by " & FormatNumber(ConsoleHelp, 0))

                'Trends!!!
                y = GetRandom(1, My.Settings.TrendSetter)

                If TheRating >= 9 And y = 1 Then
                    x = GetRandom(1, 5)
                    If x = 1 Then
                        .Trend.Text = Label14.Text
                        .NewsList.Items.Insert(0, "Because of the recent success of " & GameName.Text & ", the new genre trend is " & Label14.Text)
                    End If
                End If

                If TheRating >= 9 And y <> 1 Then
                    .NewsList.Items.Insert(0, "Because of the recent success of " & GameName.Text & ", the new interest trend is " & Label19.Text)
                End If
            End If

            If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
            FMain.Timer1.Enabled = True
            Me.Hide()
        End With
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object) Handles TrackBar2.Scroll
        Call MarketValue()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object) Handles TrackBar1.Scroll
        Call MarketValue()
    End Sub

    Private Sub SlCbtn1_Click_1(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Dim MyRes As String = MsgBox("Are you sure you want to cancel this game? You may risk the studio closing.", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation)
        If MyRes = vbNo Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        FMain.Timer1.Enabled = True
        Me.Hide()
    End Sub
End Class