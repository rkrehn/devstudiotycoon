Public Class fHire

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        PositionTitle.Text = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "Position")
        Label6.Text = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "Salary")
        ProgressBar1.Value = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "Artist")
        ProgressBar2.Value = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "Tech")
        ProgressBar3.Value = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "StressMax")

    End Sub

    Private Sub fHire_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fHire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openmenu, AudioPlayMode.Background)

        Dim x As Integer, y As Integer, TempEE As String
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()

        FMain.Cash.Text = Val(FMain.Cash.Text - 1000)

        x = GetRandom(5, 25)
        TempEE = 4

        'if all is selected 
        If ComboBox2.Text = "All" Then
            Do
                y = GetRandom(1, 6)

                Select Case y
                    Case Is = 1
                        TempEE = EmployeeGen("Artist", Seat.Text)
                    Case Is = 2
                        TempEE = EmployeeGen("Designer", Seat.Text)
                    Case Is = 3
                        TempEE = EmployeeGen("Writer", Seat.Text)
                    Case Is = 4
                        TempEE = EmployeeGen("Programmer", Seat.Text)
                    Case Is = 5
                        TempEE = EmployeeGen("Audio", Seat.Text)
                    Case Is = 6
                        TempEE = EmployeeGen("Tester", Seat.Text)
                End Select

                ListBox1.Items.Add(GetEmployee(TempEE, "Name") & " (" & Mid(GetEmployee(TempEE, "Position"), 1, 1) & ")")
                ListBox2.Items.Add(TempEE)
                x = x - 1
            Loop Until x <= 1
            Exit Sub
        End If

        Do
            TempEE = EmployeeGen(ComboBox2.Text, Seat.Text)
            ListBox1.Items.Add(GetEmployee(TempEE, "Name") & " (" & Mid(GetEmployee(TempEE, "Position"), 1, 1) & ")")
            ListBox2.Items.Add(TempEE)
            x = x - 1
        Loop Until x <= 1

        If FMain.EmployeeData.Items.Count < 5 Then
            lbl_Cost.Text = 1000
        End If

        If FMain.EmployeeData.Items.Count > 4 Then
            lbl_Cost.Text = 5000
        End If

        If FMain.EmployeeData.Items.Count > 10 Then
            lbl_Cost.Text = 10000
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        Dim TheImage As String
        If ListBox1.Items.Count = 0 Then Exit Sub
        TheImage = GetEmployee(ListBox2.Items(ListBox1.SelectedIndex), "Image") ' & ".png"
        'Dim ImageSource As String = My.Resources.ResourceManager.GetObject(TheImage)

        Select Case Seat.Text
            Case Is = 2
                FMain.PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 3
                FMain.PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 4
                FMain.PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 5
                FMain.PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 6
                FMain.PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 7
                FMain.PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 8
                FMain.PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 9
                FMain.PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 10
                FMain.PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 11
                FMain.PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 12
                FMain.PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 13
                FMain.PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 14
                FMain.PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 15
                FMain.PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 16
                FMain.PictureBox16.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 17
                FMain.PictureBox17.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 18
                FMain.PictureBox18.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 19
                FMain.PictureBox19.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 20
                FMain.PictureBox20.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
            Case Is = 21
                FMain.PictureBox21.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
        End Select

        FMain.EmployeeData.Items.Add(ListBox2.Items(ListBox1.SelectedIndex))

        'If Form1.Develop.Checked = True Then Form1.ProgressBar2.Maximum = Form1.ProgressBar2.Maximum + 4000 'adds development time. Training etc.
        If FMain.Develop.Checked = False Then FMain.DevTeam.Text = FMain.EmployeeData.Items.Count

        FMain.Cash.Text = Val(FMain.Cash.Text) - Val(lbl_Cost.Text)

        Me.Hide()
    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub

    Private Sub DotNetBarTabcontrol1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DotNetBarTabcontrol1.SelectedIndexChanged

    End Sub

    Private Sub StaffList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StaffList.SelectedIndexChanged
        If StaffList.SelectedIndex = -1 Then Exit Sub

        Dim x As Integer = StaffList.SelectedIndex

        'Fill default values
        txt_Position.Text = GetEmployee(StaffData.Items(x), "Position")
        txt_Salary.Text = GetEmployee(StaffData.Items(x), "Salary")

        ArtBar.Value = GetEmployee(StaffData.Items(x), "Artist")
        TechBar.Value = GetEmployee(StaffData.Items(x), "Tech")
        SpeedBar.Value = GetEmployee(StaffData.Items(x), "Speed")
        StressBar.Value = GetEmployee(StaffData.Items(x), "StressMax")
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        If StaffList.SelectedIndex = -1 Or StaffList.SelectedIndex = 0 Then Exit Sub

        Dim x As Integer = StaffList.SelectedIndex

        Call Termination("Fired", StaffList.Items(x), GetEmployee(StaffData.Items(x), "Seat"))

        'update lists
        StaffList.Items.RemoveAt(x)
        StaffData.Items.RemoveAt(x)

        FMain.EmployeeData.Items.Clear()
        For Each itm In StaffData.Items
            FMain.EmployeeData.Items.Add(itm)
        Next

        Me.Hide()
    End Sub

    Private Sub SlCbtn3_Click(sender As Object, e As EventArgs) Handles SlCbtn3.Click
        If StaffList.SelectedIndex = -1 Or StaffList.SelectedIndex = 0 Then Exit Sub

        Dim x As Integer = StaffList.SelectedIndex
        Dim RecSalary = Salary(FMain.TheYear.Text, ArtBar.Value, TechBar.Value)

        Dim TheInput As MsgBoxResult = MsgBox("Would you like to give " & StaffList.Items(x) & " a 5% raise? Their recommend salary is $" & RecSalary & " per week.", MsgBoxStyle.Information + MsgBoxStyle.YesNo)

        If TheInput = MsgBoxResult.No Then Exit Sub

        If TheInput = MsgBoxResult.Yes Then
            'update the data
            Dim TempData As String = StaffData.Items(x)
            Dim TheSalary As Long = txt_Salary.Text
            TheSalary = TheSalary + Math.Round(TheSalary * (5 / 100))
            StaffData.Items.RemoveAt(x)

            're-add information
            StaffData.Items.Add(GetEmployee(TempData, "Salary", TheSalary))

            're-build employee list
            FMain.EmployeeData.Items.Clear()
            StaffList.Items.Clear()
            For Each itm In StaffData.Items
                FMain.EmployeeData.Items.Add(itm)
                StaffList.Items.Add(GetEmployee(itm, "Name"))
            Next

            StaffList.SelectedIndex = StaffList.Items.Count - 1
            txt_Salary.Text = TheSalary
        End If
    End Sub
End Class