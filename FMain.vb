Imports dsTycoon.Class1

Public Class FMain

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'set up seating if they're away
        If Val(Hrs.Text) < 7 Or Val(Hrs.Text - Overtime.Text) > 17 Then Call SetSeating(True) Else Call SetSeating()

        'developing the games
        If Develop.Checked = True Then
            'Dim DevThread As New System.Threading.Thread(Sub() Development())
            'DevThread.Start()
            Call Development()
            If Panel2.Visible = False Then Panel2.Visible = True
            If Panel3.Visible = True Then Panel3.Visible = False
            If Panel4.Visible = True Then Panel4.Visible = False
            Label19.Enabled = False
        End If

        'work on contract
        If Contract.Checked = True Then
            'Dim conThread As New System.Threading.Thread(Sub() Contracting())
            'conThread.Start()
            Call Contracting()
        End If

        If Engine.Checked = True Then
            'Dim engThread As New System.Threading.Thread(Sub() EngineBuild())
            'engThread.Start()
            Call EngineBuild()

            If Panel2.Visible = True Then Panel2.Visible = False
            If Panel3.Visible = False Then Panel3.Visible = True
            If Panel4.Visible = True Then Panel4.Visible = False
            Label19.Enabled = False
        End If

        If Console.Checked = True Then
            'Dim soleThread As New System.Threading.Thread(Sub() ConsoleBuild())
            'soleThread.Start()
            Call ConsoleBuild()

            If Panel2.Visible = True Then Panel2.Visible = False
            If Panel3.Visible = True Then Panel3.Visible = False
            If Panel4.Visible = False Then Panel4.Visible = True
            Label19.Enabled = False
        End If

        If Engine.Checked = False And Contract.Checked = False And Develop.Checked = False And Console.Checked = False Then 'only time it's allowed
            Label19.Enabled = True
        End If

        Call RunEmployees() 'run employee stress, whether they're at work, etc.

        If Hrs.Text = 2 Then 'consoles 
            Call Weekly_Consoles()
        End If

        If Hrs.Text = 6 Then 'new game generation so midnight isn't bogged down
            Call Weekly_NewGames()
        End If

        If Hrs.Text = 24 Then
            Hrs.Text = 0
            GoTo WeekTest
        Else
            Hrs.Text = Hrs.Text + 1
        End If
        Exit Sub

WeekTest:
        TheWeek.Text = Int(TheWeek.Text) + 1
        Call Weekly()

        If TheMonth.Text = "January" And TheWeek.Text = 6 Then
            Call MonthEnd()
            TheMonth.Text = "February"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "February" And TheWeek.Text = 4 Then
            Call MonthEnd()
            TheMonth.Text = "March"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "March" And TheWeek.Text = 6 Then
            Call MonthEnd()
            TheMonth.Text = "April"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "April" And TheWeek.Text = 5 Then
            Call MonthEnd()
            TheMonth.Text = "May"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "May" And TheWeek.Text = 6 Then
            Call MonthEnd()
            TheMonth.Text = "June"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "June" And TheWeek.Text = 5 Then
            Call MonthEnd()
            TheMonth.Text = "July"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "July" And TheWeek.Text = 6 Then
            Call MonthEnd()
            TheMonth.Text = "August"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "August" And TheWeek.Text = 5 Then
            Call MonthEnd()
            TheMonth.Text = "September"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "September" And TheWeek.Text = 5 Then
            Call MonthEnd()
            TheMonth.Text = "October"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "October" And TheWeek.Text = 6 Then
            Call MonthEnd()
            TheMonth.Text = "November"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "November" And TheWeek.Text = 5 Then
            Call MonthEnd()
            TheMonth.Text = "December"
            TheWeek.Text = 1
            Exit Sub
        End If
        If TheMonth.Text = "December" And TheWeek.Text = 6 Then
            Call MonthEnd()
            Call YearEnd()
            TheMonth.Text = "January"
            TheWeek.Text = 1
            TheYear.Text = Int(TheYear.Text + 1)
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub NewsTimer_Tick(sender As Object, e As EventArgs) Handles NewsTimer.Tick

    End Sub

    Private Sub AdventureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdventureToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Adventure")
        fNewGame.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        HelpText.Visible = False
        Timer2.Enabled = False
    End Sub


    Private Sub HireToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Call Staffing()
    End Sub

    Private Sub NewConsoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NewConsoles.SelectedIndexChanged

    End Sub

    Private Sub ActionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActionToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Action")

        fNewGame.Show()
    End Sub

    Private Sub RoleplayingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoleplayingToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("RPG")
        fNewGame.Show()
    End Sub

    Private Sub SimulationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimulationToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Simulation")

        fNewGame.Show()
    End Sub

    Private Sub StrategyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StrategyToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Call LoadForm2("Strategy")
        fNewGame.Show()
    End Sub

    Private Sub CasualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CasualToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Casual")
        fNewGame.Show()
    End Sub

    Private Sub PartyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartyToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Party")
        fNewGame.Show()
    End Sub

    Private Sub PuzzleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PuzzleToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Puzzle")
        fNewGame.Show()
    End Sub

    Private Sub SportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SportsToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call LoadForm2("Sports")
        fNewGame.Show()
    End Sub

    Private Sub NewGameToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem1.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim Que As String

        Que = MsgBox("Would you like to quit the game in progress and start a new game?", vbYesNo)

        If Que = vbYes Then
            Timer1.Enabled = False
            fSplash.Show()
            Me.Hide()
        End If

        'Call NewGame()
        ' Button5.Enabled = True
        'Button6.Enabled = True

        'ListBox6.Items.Add(EmployeeGen("Programmer", 0)) '//temp - have a character generator
    End Sub

    Private Sub Companies_DoubleClick(sender As Object, e As EventArgs) Handles Companies.DoubleClick
        Call MsgBox(Companies.Items(Companies.SelectedIndex))
    End Sub

    Private Sub G2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles G2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        'TextBox1.Text = GenGame("TempCo", "Chance")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub fMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub LoadGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadGameToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Label19.Enabled = True
        Label20.Enabled = True

        Call LoadGame()
    End Sub

    Private Sub Cash_Click(sender As Object, e As EventArgs) Handles Cash.Click

    End Sub

    Private Sub Cash_MouseHover(sender As Object, e As EventArgs) Handles Cash.MouseHover
        HelpText.Text = "Income: " & FormatCurrency(Val(Income.Text), 0) & vbNewLine & "Expenses: " & FormatCurrency(Expenses, 0)
        HelpText.Top = Cash.Top + 15
        HelpText.Left = Cash.Left + 15
        HelpText.Visible = True
        Timer2.Enabled = True

    End Sub

    Private Sub Cash_MouseLeave(sender As Object, e As EventArgs) Handles Cash.MouseLeave
        HelpText.Visible = False
    End Sub

    Private Sub EnforceOvertimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnforceOvertimeToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim TheOT As String
        If EnforceOvertimeToolStripMenuItem.Checked = True Then
            EnforceOvertimeToolStripMenuItem.Checked = False
            Overtime.Text = 0
            Exit Sub
        End If

        If EnforceOvertimeToolStripMenuItem.Checked = False Then
            TheOT = InputBox("How many hours would you like to enforce per day?", , 0, MousePosition.X, MousePosition.Y)
            If IsNumeric(TheOT) = False Then
                Call MsgBox("Please select a valid number", vbCritical)
                Exit Sub
            Else
                Overtime.Text = TheOT
                EnforceOvertimeToolStripMenuItem.Checked = True
            End If
        End If
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

    End Sub

    Private Sub RequestPublisherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestPublisherToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        If Stage.Text = "Production" Then
            Stage.Text = "Design"
            '.RadialBar2.Maximum = (4000 * ProgressMax)
            DevelopStages.Items.RemoveAt(0)
            RadialBar2.Maximum = DevelopStages.Items(0)
            RadialBar2.Value = 1
            Exit Sub
        End If

        If Stage.Text = "Design" Then
            Stage.Text = "Programming"
            '.RadialBar2.Maximum = (7000 * ProgressMax)
            DevelopStages.Items.RemoveAt(0)
            RadialBar2.Maximum = DevelopStages.Items(0)
            RadialBar2.Value = 1
            Exit Sub
        End If

        If Stage.Text = "Programming" Then
            Stage.Text = "Level creation"
            '.RadialBar2.Maximum = (7000 * ProgressMax)
            DevelopStages.Items.RemoveAt(0)
            RadialBar2.Maximum = DevelopStages.Items(0)
            RadialBar2.Value = 1
            Exit Sub
        End If

        If Stage.Text = "Level creation" Then
            Stage.Text = "Art Production"
            '.RadialBar2.Maximum = (6000 * ProgressMax)
            DevelopStages.Items.RemoveAt(0)
            RadialBar2.Maximum = DevelopStages.Items(0)
            RadialBar2.Value = 1
            Exit Sub
        End If

        If Stage.Text = "Art Production" Then
            Stage.Text = "Testing"
            '.RadialBar2.Maximum = (3000 * ProgressMax)
            DevelopStages.Items.RemoveAt(0)
            RadialBar2.Maximum = DevelopStages.Items(0)
            RadialBar2.Value = 1
            Exit Sub
        End If

        If Stage.Text = "Testing" Then
            Stage.Text = "Release"
            Exit Sub
        End If
    End Sub

    Private Sub ArtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArtToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Design"
        ArtToolStripMenuItem.Checked = True
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub ArtToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ArtToolStripMenuItem1.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Art"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = True
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub GameplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GameplayToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Gameplay"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = True
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub StoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoryToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Story"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = True
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub ReplayabilityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplayabilityToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Replay"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = True
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub NoneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NoneToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "None"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = False
        NoneToolStripMenuItem.Checked = True
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        GameFocus.Text = "Audio"
        ArtToolStripMenuItem.Checked = False
        ArtToolStripMenuItem1.Checked = False
        GameplayToolStripMenuItem.Checked = False
        StoryToolStripMenuItem.Checked = False
        ReplayabilityToolStripMenuItem.Checked = False
        AudioToolStripMenuItem.Checked = True
        NoneToolStripMenuItem.Checked = False
    End Sub

    Private Sub ReleaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        If Develop.Checked = True Then
            Stage.Text = "Release"
            Call ReleaseGame()
        End If

        If Engine.Checked = True Then
            Call ReleaseEngine()
        End If
    End Sub


    Private Sub FireToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub MarketingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarketingToolStripMenuItem.Click
        Call MarketingForm()
    End Sub

    Private Sub Cash_QueryContinueDrag(sender As Object, e As QueryContinueDragEventArgs) Handles Cash.QueryContinueDrag

    End Sub

    Private Sub Cash_TextChanged(sender As Object, e As EventArgs) Handles Cash.TextChanged
        Try
            If Val(Cash.Text) > Val(CashMax.Text) Then CashMax.Text = Cash.Text

            If Val(Cash.Text) < 0 Then
                Call EndGame("Cash")
                Exit Sub
            End If

            Cash2.Text = FormatCurrency(Val(Cash.Text), 0)

            If Me.Visible = False Then Exit Sub

            If Val(Cash.Text) < (Expenses() * 2) Then
                Cash2.ForeColor = Color.Red
                Exit Sub
            Else
                Cash2.ForeColor = Color.Black
                Exit Sub
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub SeeContractsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeeContractsToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call GenContracts()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        ContextMenuStrip4.Show(MousePosition)
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        ContextMenuStrip1.Show(MousePosition)
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        ContextMenuStrip2.Show(MousePosition)
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        Try
            With fStats
                If fStats.Visible = True Then
                    Exit Sub
                Else
                    .ListView1.Clear()
                    .ListView1.View = View.Details
                    .ListView1.GridLines = True
                    .ListView1.FullRowSelect = True

                    .ListView2.Clear()
                    .ListView2.View = View.Details
                    .ListView2.GridLines = True
                    .ListView2.FullRowSelect = True

                    'Add column header
                    .ListView1.Columns.Add("Game", 250)
                    .ListView1.Columns.Add("Sales", 125)

                    .ListView2.Columns.Add("Console", 250)
                    .ListView2.Columns.Add("Sales", 125)

                    'Add items in the listview
                    Dim arr(2) As String, x As Integer
                    Dim itm As ListViewItem

                    'Add first item
                    x = NewGames.Items.Count - 1
                    If x = -1 Then Exit Sub

                    Do
                        arr(0) = GetGame(NewGames.Items.Item(x), "Name")
                        arr(1) = FormatNumber(GetGame(NewGames.Items.Item(x), "Sales"), 0)
                        itm = New ListViewItem(arr)
                        .ListView1.Items.Add(itm)

                        x = x - 1
                    Loop Until x = -1

                    x = NewConsoles.Items.Count - 1
                    If x = -1 Then Exit Sub


                    Do
                        arr(0) = GetConsole(NewConsoles.Items.Item(x), "Console")
                        arr(1) = FormatNumber(GetConsole(NewConsoles.Items.Item(x), "Sales"), 0)

                        'only if release console
                        If GetConsole(NewConsoles.Items.Item(x), "Release") > 1 Then
                            itm = New ListViewItem(arr)
                            .ListView2.Items.Add(itm)
                        End If

                        x = x - 1
                    Loop Until x = -1

                    .ListView1.ListViewItemSorter = New ListViewItemComparer(1)
                    .ListView2.ListViewItemSorter = New ListViewItemComparer(1)

                    'sort lists
                    .ListView1.Columns.Item(1).ListView.Sorting = SortOrder.Ascending
                    .ListView2.Columns.Item(1).ListView.Sorting = SortOrder.Ascending

                    .ListView1.Sort()
                    .ListView2.Sort()

                    .Show()
                End If
            End With
            If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub

    Private Sub Label19_MouseHover(sender As Object, e As EventArgs) Handles Label19.MouseHover
        Label19.Image = dsTycoon.My.Resources.Resources.arrow_hov
    End Sub

    Private Sub Label19_MouseLeave(sender As Object, e As EventArgs) Handles Label19.MouseLeave
        Label19.Image = dsTycoon.My.Resources.Resources.arrow_dis
    End Sub

    Private Sub Label20_MouseHover(sender As Object, e As EventArgs) Handles Label20.MouseHover
        Label20.Image = dsTycoon.My.Resources.Resources.settings_hov
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave
        Label20.Image = dsTycoon.My.Resources.Resources.settings_dis
    End Sub

    Private Sub Label21_MouseHover(sender As Object, e As EventArgs) Handles Label21.MouseHover
        Label21.Image = dsTycoon.My.Resources.Resources.manage_hov
    End Sub

    Private Sub Label21_MouseLeave(sender As Object, e As EventArgs) Handles Label21.MouseLeave
        Label21.Image = dsTycoon.My.Resources.Resources.manage_dis
    End Sub

    Private Sub Label22_MouseHover(sender As Object, e As EventArgs) Handles Label22.MouseHover
        Label22.Image = dsTycoon.My.Resources.Resources.stats_hov
    End Sub

    Private Sub Label22_MouseLeave(sender As Object, e As EventArgs) Handles Label22.MouseLeave
        Label22.Image = dsTycoon.My.Resources.Resources.stats_dis
    End Sub

    Private Sub Label23_MouseHover(sender As Object, e As EventArgs) Handles Label23.MouseHover
        Label23.Image = dsTycoon.My.Resources.Resources.home_hov
    End Sub

    Private Sub Label23_MouseLeave(sender As Object, e As EventArgs) Handles Label23.MouseLeave
        Label23.Image = dsTycoon.My.Resources.Resources.home_dis
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub ProgressBar3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewEngineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEngineToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim x As Integer, temp As String

        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        With fNewEngine
            'get consoles first
            .ComboBox5.Items.Clear()
            x = NewConsoles.Items.Count - 1

            temp = NewConsoles.Items(x)

            Do
                .ComboBox5.Items.Add(GetConsole(NewConsoles.Items(x), "Console"))
                x = x - 1
            Loop Until x = -1

            Call DrawChartsEng()

        End With

    End Sub

    Private Sub RequestLoanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestLoanToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Call SetLoans()
        Call SetInvestments()
        Call SetStocks()
        fBank.Show()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        With fOptions
            .SlcOnOffBox1.Checked = My.Settings.SettingsSound
            .SlcOnOffBox2.Checked = My.Settings.SettingsMusic
            .SlcOnOffBox3.Checked = My.Settings.AlertNewGame
            .SlcOnOffBox4.Checked = My.Settings.AlertBankruptcy
            .SlcOnOffBox5.Checked = My.Settings.AlertRetiredEngines
            .SlcOnOffBox6.Checked = My.Settings.AlertRetiredGames
            .SlcOnOffBox7.Checked = My.Settings.AlertRetiredGames
            .SlcOnOffBox9.Checked = My.Settings.SettingsCorruptMode

            .Show()
        End With

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = False

        Button1.BackColor = Color.White
        Button2.BackColor = Color.LightSteelBlue
        Button3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Interval = My.Settings.Timer

        Timer1.Enabled = True
        Button1.BackColor = Color.LightSteelBlue
        Button2.BackColor = Color.White
        Button3.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Interval = My.Settings.TimerFast

        Timer1.Enabled = True
        Button1.BackColor = Color.LightSteelBlue
        Button2.BackColor = Color.LightSteelBlue
        Button3.BackColor = Color.White
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Label19.Enabled = True
        Label20.Enabled = True

        Call SaveGame()
    End Sub

    Private Sub TheWeek_Click(sender As Object, e As EventArgs) Handles TheWeek.Click

    End Sub

    Private Sub DevelopStages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DevelopStages.SelectedIndexChanged

    End Sub


    Private Sub fMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 775
        Me.Height = 580

        If Application.ExecutablePath.Contains("Debug") Then
            SlcTheme1.Sizable = True
        End If

        ' Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub RadialBar2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadialBar2_MouseHover(sender As Object, e As EventArgs)
        If DevelopStages.Items.Count = 0 And Contract.CheckState = CheckState.Unchecked Then Exit Sub

        HelpText.Text = "Weeks remaining: " & (RadialBar2.Maximum - RadialBar2.Value)
        HelpText.Top = RadialBar2.Top + 25
        HelpText.Left = RadialBar2.Left + 25
        HelpText.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub RadialBar2_MouseLeave(sender As Object, e As EventArgs)
        HelpText.Visible = False
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgressBar1_MouseHover(sender As Object, e As EventArgs)
        If DevelopStages.Items.Count = 0 And Contract.CheckState = CheckState.Unchecked Then Exit Sub

        HelpText.Text = "Weeks remaining: " & AllWeeks.Text
        HelpText.Top = RadialBar1.Top + 25
        HelpText.Left = RadialBar1.Left + 25
        HelpText.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub ProgressBar1_MouseLeave(sender As Object, e As EventArgs)
        HelpText.Visible = False
    End Sub


    Private Sub StaffingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StaffingToolStripMenuItem.Click
        Call Staffing()
    End Sub

    Private Sub RetireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetireToolStripMenuItem.Click
        Call EndGame("Retire")
    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub

    Private Sub NewPlatformToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewPlatformToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        Call NewConsole()

    End Sub

    Private Sub Cash2_Click(sender As Object, e As EventArgs) Handles Cash2.Click
        If Application.ExecutablePath.Contains("Debug") Then
            Dim TheCash As Long = InputBox("How much cash you want?", "My Cousin Vinnie", "10000000")
            Cash.Text = TheCash
        End If
    End Sub

    Private Sub Cash2_MouseHover(sender As Object, e As EventArgs) Handles Cash2.MouseHover
        HelpText.Text = "Income: " & FormatCurrency(Val(Income.Text), 0) & vbNewLine & "Expenses: " & FormatCurrency(Expenses, 0)
        HelpText.Top = Cash.Top + 15
        HelpText.Left = Cash.Left + 15
        HelpText.Visible = True
        Timer2.Enabled = True
    End Sub

    Private Sub Cash2_MouseLeave(sender As Object, e As EventArgs) Handles Cash2.MouseLeave
        HelpText.Visible = False
    End Sub

    Private Sub SequelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SequelToolStripMenuItem.Click
        If Contract.Checked = True Or Develop.Checked = True Or Engine.Checked = True Or Console.Checked = True Then Exit Sub

        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        With fSequel
            .lst_Games.Items.Clear()

            'grab data
            For Each itm In OldGames.Items
                If GetGame(itm, "Company") = YourCo.Text Then .lst_Games.Items.Add(itm)
            Next

            For Each itm In NewGames.Items
                If GetGame(itm, "Company") = YourCo.Text Then .lst_Games.Items.Add(itm)
            Next

            ' no games?
            If .lst_Games.Items.Count = 0 Then
                Call MsgBox("No games made!", vbInformation)
                Exit Sub
            End If

            .lbl_Selected.Text = "1 / " & .lst_Games.Items.Count
            .txt_Game.Text = GetGame(.lst_Games.Items(0), "Name") & " is a(n) " & GetGame(.lst_Games.Items(0), "Genre") & " game that had a rating of " & GetGame(.lst_Games.Items(0), "Rating") & "."

            .Show()
        End With
    End Sub
End Class

