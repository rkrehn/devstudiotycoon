Public Class fBank


    Private Sub Loan1_Click(sender As Object, e As EventArgs) Handles Loan1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)

        Dim x As Integer
        x = Loan1.SelectedIndex

        If x = -1 Then Exit Sub


        HScrollBar1.Minimum = 1
        HScrollBar1.Maximum = GetLoans(Loan1Data.Items(x), "Dollar")

        If HScrollBar1.Maximum > FMain.Cash.Text Then
            HScrollBar1.Value = Math.Round(Val(FMain.Cash.Text))
        Else
            HScrollBar1.Value = HScrollBar1.Maximum
        End If

        Label6.Text = HScrollBar1.Value
    End Sub

    Private Sub fBank_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub Loan2_Click(sender As Object, e As EventArgs) Handles Loan2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Loan2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Loan2.SelectedIndexChanged

    End Sub

    Private Sub Invest1_Click(sender As Object, e As EventArgs) Handles Invest1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub

    Private Sub Invest1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Invest1.SelectedIndexChanged

    End Sub

    Private Sub Invest2_Click(sender As Object, e As EventArgs) Handles Invest2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)
    End Sub


    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim x As Integer, ToDollar As Long
        x = Loan1.SelectedIndex
        If x = -1 Then Exit Sub

        'nuff money?
        If Val(HScrollBar1.Value) > Val(FMain.Cash.Text) Then
            Call MsgBox("Not enough funds!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ToDollar = Val(HScrollBar1.Value)

        'pay full?
        If HScrollBar1.Value = HScrollBar1.Maximum Then
            FMain.Cash.Text = Math.Round(Val(FMain.Cash.Text) - ToDollar)

            'remove current
            FMain.Loans.Items.RemoveAt(x)
            Loan1.Items.RemoveAt(x)
            Loan1Data.Items.RemoveAt(x)
            Exit Sub
        End If

        'pay pieces
        FMain.Cash.Text = Math.Round(Val(FMain.Cash.Text) - ToDollar)
        Loan1Data.Items(x) = GetLoans(Loan1Data.Items(x), "Dollar", Math.Round(Val(GetLoans(Loan1Data.Items(x), "Dollar")) - ToDollar))
        FMain.Loans.Items(x) = GetLoans(Loan1Data.Items(x), "Dollar", Math.Round(Val(GetLoans(Loan1Data.Items(x), "Dollar")) - ToDollar))

        Loan1.Items(x) = "You owe " & GetLoans(Loan1Data.Items(x), "Name") & " " & FormatCurrency(GetLoans(Loan1Data.Items(x), "Dollar"), 0) & "."
        Label6.Text = FormatCurrency(GetLoans(Loan1Data.Items(x), "Dollar"), 0)

        HScrollBar1.Maximum = GetLoans(Loan1Data.Items(x), "Dollar")
        HScrollBar1.Value = HScrollBar1.Maximum
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim x As Integer, NewDollar As Long
        If Loan2.SelectedIndex = -1 Then Exit Sub


        x = Loan2.SelectedIndex

        NewDollar = Math.Round(GetLoans(Loan2Data.Items(x), "Dollar") + ((GetLoans(Loan2Data.Items(x), "Dollar") * GetLoans(Loan2Data.Items(x), "Rate") / 100)), 0)
        'add to cash amount
        FMain.Cash.Text = Math.Round(Val(FMain.Cash.Text) + GetLoans(Loan2Data.Items(x), "Dollar"))
        Loan2Data.Items(x) = GetLoans(Loan2Data.Items(x), "Dollar", NewDollar)

        'add to loans
        Loan1Data.Items.Add(Loan2Data.Items(x))
        Loan1.Items.Add("You owe " & GetLoans(Loan2Data.Items(x), "Name") & " " & FormatCurrency(NewDollar, 0) & ".")
        FMain.Loans.Items.Add(Loan2Data.Items(x))

        'remove current
        Loan2.Items.RemoveAt(x)
        Loan2Data.Items.RemoveAt(x)

        Call SetLoans()
    End Sub

    Private Sub SlCbtn3_Click(sender As Object, e As EventArgs) Handles SlCbtn3.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim x As Integer
        x = Invest1.SelectedIndex

        If x = -1 Then Exit Sub

        'add to cash amount
        FMain.Cash.Text = Math.Round(Val(FMain.Cash.Text) + GetInvestments(Invest1Data.Items(x), "Dollar"))

        Call MsgBox("You have cashed out the amount of " & FormatCurrency(GetInvestments(Invest1Data.Items(x), "Dollar"), 0), MsgBoxStyle.Information)

        'remove current
        Invest1.Items.RemoveAt(x)
        Invest1Data.Items.RemoveAt(x)

        'update investments 
        FMain.Investments.Items.Clear()
        x = Invest1Data.Items.Count - 1
        If x = -1 Then Exit Sub

        Do
            FMain.Investments.Items.Add(Invest1Data.Items(x))
            x = x - 1
        Loop Until x = -1
    End Sub

    Private Sub SlCbtn4_Click(sender As Object, e As EventArgs) Handles SlCbtn4.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim x As Integer
        If Invest2.SelectedIndex = -1 Then Exit Sub

        x = Invest2.SelectedIndex

        'not enough cash?
        If Val(GetInvestments(Invest2Data.Items(x), "Dollar")) > Val(FMain.Cash.Text) Then
            Call MsgBox("Not enough money!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'subtract from cash amount
        FMain.Cash.Text = Math.Round(Val(FMain.Cash.Text) - GetInvestments(Invest2Data.Items(x), "Dollar"))

        'add to investments
        'Invest1Data.Items.Add(Invest2Data.Items(x))
        'Invest1.Items.Add("Investment in " & GetInvestments(Invest2Data.Items(x), "Name") & " is currently worth " & FormatCurrency(GetInvestments(Invest2Data.Items(x), "Dollar"), 0) & ".")
        FMain.Investments.Items.Add(Invest2Data.Items(x))

        'remove current
        Invest2.Items.RemoveAt(x)
        Invest2Data.Items.RemoveAt(x)

        Call SetInvestments()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub BaWGUITrackBar1_Scroll(sender As Object) Handles HScrollBar1.Scroll
        Label6.Text = FormatCurrency(HScrollBar1.Value, 0)
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub SlCbtn8_Click(sender As Object, e As EventArgs) Handles SlCbtn8.Click
        Dim y As Integer, z As Integer, temp As String, TheStock As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1

        'Check last item
        If z < 1 Then Exit Sub

        'Set the new item
        z = z - 1
        lbl_Selected.Text = z & " / " & StockData.Items.Count

        txt_AvailStocks.Text = GetStocks(StockData.Items(z), "Company") & " is willing to sell their company for " & FormatCurrency(GetStocks(StockData.Items(z), "Cash"), 0) & ". The average rating of their games is " & GetStocks(StockData.Items(z), "Rating") & " and they're willing to give " & GetStocks(StockData.Items(z), "Sales") & "% of sales."
    End Sub

    Private Sub SlCbtn7_Click(sender As Object, e As EventArgs) Handles SlCbtn7.Click
        Dim y As Integer, z As Integer, temp As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) + 1

        'Check last item
        If z > StockData.Items.Count Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & StockData.Items.Count

        z = z - 1
        txt_AvailStocks.Text = GetStocks(StockData.Items(z), "Company") & " is willing to sell their company for " & FormatCurrency(GetStocks(StockData.Items(z), "Cash"), 0) & ". The average rating of their games is " & GetStocks(StockData.Items(z), "Rating") & " and they're willing to give " & GetStocks(StockData.Items(z), "Sales") & "% of sales."
    End Sub

    Private Sub SlCbtn6_Click(sender As Object, e As EventArgs) Handles SlCbtn6.Click
        Dim z As Integer, TheCo As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1
        If z = -1 Then Exit Sub
        TheCo = GetStocks(StockData.Items(z), "Company")

        lst_ReleasedGames.Items.Clear()
        For Each itm In FMain.OldGames.Items
            If GetGame(itm, "Company") = TheCo Then
                lst_ReleasedGames.Items.Add(GetGame(itm, "Name") & " was released with a rating of " & GetGame(itm, "Rating"))
            End If
        Next

    End Sub

    Private Sub SlCbtn5_Click(sender As Object, e As EventArgs) Handles SlCbtn5.Click
        Dim z As Integer, y As Integer, TheCo As String, CashPrice As Long

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1
        TheCo = GetStocks(StockData.Items(z), "Company")

        CashPrice = GetStocks(StockData.Items(z), "Cash")

        If CashPrice > Val(FMain.Cash.Text) Then
            Call MsgBox("You cannot afford to purchase this company!", MsgBoxStyle.Critical)
            Exit Sub
        Else
            'find the company's data set
            y = FMain.Companies.FindString(TheCo)

            With FMain
                'Update publisher
                'MsgBox(FMain.Companies.Items(z))
                FMain.Companies.Items(z) = GetCompany(FMain.Companies.Items(z), "Publisher", FMain.YourCo.Text) 'FIX!
                FMain.OwnedStocks.Items.Add(StockData.Items(z))
                'MsgBox(FMain.Companies.Items(z))

                'update cash and remove stockdata
                .Cash.Text = Val(.Cash.Text) - CashPrice
                StockData.Items.RemoveAt(z)

                'update stock fields
                .Stocks.Items.Clear()
                For Each itm In StockData.Items
                    .Stocks.Items.Add(itm)
                Next
            End With

            Call MsgBox("Congrats! You have purchased a studio!" & vbNewLine & "All their future released games will bring you royalties. Remember to market them well!", vbInformation)
            Call SetStocks()
        End If
    End Sub
End Class