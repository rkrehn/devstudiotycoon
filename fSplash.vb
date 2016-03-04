Imports System.IO
Imports System.Text
Imports System.Net

Public Class fSplash

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Text = "v" & Application.ProductVersion.ToString
        'My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.BackgroundLoop)

        'Launch tutorial?
        If IO.File.Exists(Application.StartupPath & "\Saves\Data.dat") = False Then SlcCheckbox1.Checked = True

        Dim thever As String

        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead("http://www.dstycoon.com/version.txt"))

        thever = reader.ReadLine

        'the same
        If Label10.Text <> thever Then NewUpdate.Visible = True

        client.Dispose()
        reader.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)

        Dim TmpCalc As Integer

        LTech.Text = GetRandom(30, 50)

        If Val(LTech.Text) > 40 Then
            LArt.Text = GetRandom(30, 40)
        Else
            LArt.Text = GetRandom(40, 50)
        End If

        TmpCalc = Val(LArt.Text) + Val(LTech.Text)

        If TmpCalc > 75 Then
            LSpeed.Text = GetRandom(10, 20)
        ElseIf TmpCalc > 60 And TmpCalc < 76 Then
            LSpeed.Text = GetRandom(20, 30)
        ElseIf TmpCalc < 61 Then
            LSpeed.Text = GetRandom(40, 50)
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("www.krehnsolutions.com")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBox1.Visible = True
        TextBox2.Text = "Krehn Solutions"
        TextBox1.Text = "Raymond"
        Button3.PerformClick()

        ComboBox1.Text = "1985"
        ComboBox2.Text = "Programmer"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim thever As String

        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead("http://www.dstycoon.com/version.txt"))

        Dim TheList = New ListBox
        Do While reader.Peek <> -1
            TheList.Items.Add(reader.ReadLine)
        Loop

        thever = TheList.Items(0)

        'the same
        If Label10.Text = thever Then
            Call MsgBox("You have the latest version!", MsgBoxStyle.Information)
            Exit Sub
        End If

        'continue if not the same
        With fUpdates1
            For Each itm In TheList.Items
                .ListBox1.Items.Add(itm)
            Next
            TheList.Items(0) = TheList.Items(0) & " updates:"
            .lbl_Version.Text = Label10.Text

            .Show()
        End With

        client.Dispose()
        reader.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call LoadGame()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.start, AudioPlayMode.Background)

        'EmployeeGen = TheName & "," & Salary(Form1.TheYear.Text, Artist, Tech) & "," & Pos & "," & Artist & "," & ArtistPot & "," & Tech & "," & TechPot & "," & TheSpeed & "," & SpeedMax & ",5,1," & StressMax & ",N," & TheSeat & "," & TheImage
        Dim TheName As String, Artist As Long, Tech As Long, Pos As String, ArtistPot As Long, TechPot As Long, TheSpeed As Long, SpeedMax As Long, StressMax As Long, TheSeat As Long, TheImage As String

        If Len(TextBox1.Text) < 3 Or Len(TextBox1.Text) > 30 Then
            Call MsgBox("Names must be at least 3 characters long and a max of 30", vbCritical + vbOKOnly)
            Exit Sub
        End If

        If Len(TextBox2.Text) < 3 Or Len(TextBox2.Text) > 30 Then
            Call MsgBox("Names must be at least 3 characters long and a max of 30", vbCritical + vbOKOnly)
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            Call MsgBox("Must select a valid position!", vbCritical + vbOKOnly)
            Exit Sub
        End If

        If LTech.Text = 0 Or LSpeed.Text = 0 Or LArt.Text = 0 Then
            Call MsgBox("It is recommended to generate your character by pressing the dice button.", vbCritical + vbOKOnly)
            Exit Sub
        End If


        TheName = TextBox1.Text
        Artist = LArt.Text
        Tech = LTech.Text
        Pos = ComboBox1.Text
        ArtistPot = 100
        TechPot = 100
        TheSpeed = LSpeed.Text
        SpeedMax = 100
        StressMax = 100
        TheSeat = 1
        TheImage = "boss"

        Call NewGame()

        'Simulate some months
        If Val(ComboBox2.Text) > 1980 Then
            Dim x As Integer = Val(ComboBox2.Text) - 1980
            x = x * 52

            SlcProgrssBar1.Maximum = x + 1
            SlcProgrssBar1.Value = 1
            SlcProgrssBar1.Visible = True
            SlcLabel1.Visible = True

            Do
                Call Weekly(True)
                Call Weekly_NewGames()
                If (x Mod 5) = 0 Then Call MonthEnd(True)

                SlcProgrssBar1.Value = SlcProgrssBar1.Value + 1
                x = x - 1
            Loop Until x = 0

            SlcProgrssBar1.Visible = False
            SlcLabel1.Visible = False
        End If

        Call DefineStocks()

        With FMain
            .YourCo.Text = TextBox2.Text
            .TheYear.Text = ComboBox2.Text
            .EmployeeData.Items.Add(TheName & "," & Salary(.TheYear.Text, Artist, Tech) & "," & Pos & "," & Artist & "," & ArtistPot & "," & Tech & "," & TechPot & "," & TheSpeed & "," & SpeedMax & ",5,1," & StressMax & ",N," & TheSeat & "," & TheImage)
            .Show()
        End With

        'launch tutorial?
        If SlcCheckbox1.Checked = True Then fTutorial.Show()

        Me.Hide()
        Button1.Enabled = True
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Button5.Visible = True
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://docs.google.com/forms/d/1tegKkBAxG3G4Rp7_PAPGSdf_LFCBC6D55TnbcW0FUhY/viewform?usp=send_form")
    End Sub
End Class