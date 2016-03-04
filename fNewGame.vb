Imports System.Drawing
Imports System.Drawing.Drawing2D
Public Class fNewGame

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = True
        GroupBox2.Visible = False
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox3_SelectedValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox4_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = False
        GroupBox2.Visible = True
    End Sub

    Private Sub ComboBox4_SelectedValueChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub fNewGame_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        If InStr(GameName.Text, ",") <> 0 Then
            Call MsgBox("The comma character is not allowed!", MsgBoxStyle.Critical)
            Replace(GameName.Text, ",", "")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GameName.Text = Module1.GameName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        With FMain
            '.NewsList.Width = 486
            .Label19.Enabled = True
            .Label20.Enabled = True
            .Develop.Checked = True

            .Stage.Text = "Pre-production"
            .RadialBar1.Value = 0
            .RadialBar1.Maximum = Math.Round((9999 * .EmployeeData.Items.Count) * 0.5)
            .RadialBar2.Value = 0
            .RadialBar2.Maximum = Math.Round((My.Settings.PreProduction * .EmployeeData.Items.Count) * 0.5)
            .uArt.Text = 0
            .uDesign.Text = 0
            .uGameplay.Text = 0
            .uReplay.Text = 0
            .uStory.Text = 0
            .uMusic.Text = 0
            .uBugs.Text = 0

            .GameName.Text = Me.GameName.Text
            .GameGenre.Text = txt_Genre.Text
            .SubGenre.Text = cmbo_Subgenre.Text
            .GameInterest.Text = cmbo_Interest.Text
            .GameEngine.Text = cmbo_Engine.Text
            .GameConsole.Text = cmbo_Platform.Text
            .EngTech.Text = ProgressBar1.Value
            .EngUse.Text = ProgressBar2.Value

            .GameSize.Text = Me.GameSize.Value
            .Cash.Text = Val(FMain.Cash.Text) - Val(Label10.Text)

            .DevTeam.Text = .EmployeeData.Items.Count
        End With

        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SlcGroupBox1.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = True
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub

    Private Sub ComboBox3_GotFocus(sender As Object, e As EventArgs) Handles cmbo_Platform.GotFocus
        GroupBox2.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub ComboBox4_GotFocus(sender As Object, e As EventArgs) Handles cmbo_Engine.GotFocus
        GroupBox2.Visible = True
        GroupBox1.Visible = False
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbo_Engine.SelectedIndexChanged
        GroupBox2.Visible = True
        GroupBox1.Visible = False

        Dim x As Integer

        If cmbo_Engine.Text = "Home built" Then
            ProgressBar1.Value = 1
            ProgressBar2.Value = 1
            Exit Sub
        End If

        x = cmbo_Engine.SelectedIndex

        Label11.Text = GetEngine(ListBox1.Items.Item(x), "Name")
        ProgressBar1.Value = Int(GetEngine(ListBox1.Items.Item(x), "Tech"))
        ProgressBar2.Value = Int(GetEngine(ListBox1.Items.Item(x), "Usability"))
        Label10.Text = "$" & Int(GetEngine(ListBox1.Items.Item(x), "Price"))
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles cmbo_Platform.SelectedIndexChanged
        Dim x As Integer, TheConsole As String

        'get consoles first
        cmbo_Engine.Items.Clear()
        cmbo_Engine.Items.Add("Home built")
        cmbo_Engine.Text = "Home built"

        ListBox1.Items.Clear()
        ListBox1.Items.Add("Home built")
        Label11.Text = "Home built"
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        Label10.Text = 0

        If cmbo_Platform.Text = "" Then Exit Sub Else TheConsole = cmbo_Platform.Text

        x = FMain.NewEngines.Items.Count - 1
        If x = -1 Then Exit Sub

        Do
            If GetEngine(FMain.NewEngines.Items(x), "Console") = TheConsole Then
                cmbo_Engine.Items.Add(GetEngine(FMain.NewEngines.Items(x), "Name"))
                ListBox1.Items.Add(FMain.NewEngines.Items(x))
            End If
            x = x - 1
        Loop Until x = -1
    End Sub
End Class