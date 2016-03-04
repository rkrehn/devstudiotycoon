Public Class fReleaseConsole

    Private Sub BaWGUITrackBar1_Scroll(sender As Object) Handles BaWGUITrackBar1.Scroll
        Select BaWGUITrackBar1.Value
            Case Is = 1
                lbl_ReleaseDate.Text = "January"
            Case Is = 2
                lbl_ReleaseDate.Text = "February"
            Case Is = 3
                lbl_ReleaseDate.Text = "March"
            Case Is = 4
                lbl_ReleaseDate.Text = "April"
            Case Is = 5
                lbl_ReleaseDate.Text = "May"
            Case Is = 6
                lbl_ReleaseDate.Text = "June"
            Case Is = 7
                lbl_ReleaseDate.Text = "July"
            Case Is = 8
                lbl_ReleaseDate.Text = "August"
            Case Is = 9
                lbl_ReleaseDate.Text = "September"
            Case Is = 10
                lbl_ReleaseDate.Text = "October"
            Case Is = 11
                lbl_ReleaseDate.Text = "November"
            Case Is = 12
                lbl_ReleaseDate.Text = "December"
        End Select

    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        With FMain 'relieves freeze of game 
            'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
            Dim TheSales As Long

            'determine sales 
            If Val(.TheYear.Text) <= 1990 Then TheSales = GetRandom(1000, 5000)
            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 1995 Then TheSales = GetRandom(3000, 10000)
            If Val(.TheYear.Text) > 1995 And Val(.TheYear.Text) <= 2000 Then TheSales = GetRandom(10000, 4000000)
            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2005 Then TheSales = GetRandom(20000, 5000000)
            If Val(.TheYear.Text) > 2005 And Val(.TheYear.Text) <= 2010 Then TheSales = GetRandom(30000, 6000000)
            If Val(.TheYear.Text) > 2010 And Val(.TheYear.Text) <= 2020 Then TheSales = GetRandom(40000, 7000000)
            If Val(.TheYear.Text) > 2030 And Val(.TheYear.Text) <= 2040 Then TheSales = GetRandom(50000, 8000000)
            If Val(.TheYear.Text) > 2040 Then TheSales = GetRandom(500000, 10000000)

            'Marketing

            Dim taco As Double = .CoMarketing.Text
            TheSales = Math.Round(TheSales * (taco / My.Settings.MarketingFactor))

            .NewConsoles.Items.Add(.YourCo.Text & "," & lbl_ConsoleName.Text & "," & SlcProgrssBar1.Value & "," & lbl_ReleaseDate.Text & ",N" & "," & lbl_Cost.Text & "," & lbl_Price.Text & "," & TheSales & "," & TheSales)

            .DevelopStages.Items.Clear()
            .Stage.Text = "Idle"
            .Console.Checked = False
            .RadialBar1.Value = 0
            .RadialBar2.Value = 0
            .Panel2.Visible = False
            .Panel3.Visible = False
            .Panel4.Visible = False
            .Timer1.Enabled = True
        End With

        Me.Hide()
    End Sub


    Private Sub lbl_Price_Click(sender As Object, e As EventArgs) Handles lbl_Price.Click
        Dim ThePrice As Long = InputBox("Please enter the price you want to sell the console at.", "Console price", lbl_Price.Text)

        If IsNumeric(ThePrice) = False Then Exit Sub

        lbl_Price.Text = ThePrice
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        If lbl_Price.Text > 975 Then Exit Sub

        lbl_Price.Text = Val(lbl_Price.Text) + 25
    End Sub

    Private Sub SlCbtn3_Click(sender As Object, e As EventArgs) Handles SlCbtn3.Click
        If lbl_Price.Text <= 25 Then Exit Sub
        lbl_Price.Text = Val(lbl_Price.Text) - 25
    End Sub
End Class