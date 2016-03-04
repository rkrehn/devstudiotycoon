Public Class fPTO
    Private Sub fPTO_Leave(sender As Object, e As EventArgs) Handles Me.Leave
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)
    End Sub

    Private Sub fPTO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.sound_event, AudioPlayMode.Background)
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles Button4.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)

        FMain.EmployeeData.Items(ListBox1.Items(0)) = GetEmployee(FMain.EmployeeData.Items(ListBox1.Items(0)), "PTO", "Y")
        ListBox1.Items.RemoveAt(0)

        If ListBox1.Items.Count > 0 Then
            Label1.Text = GetEmployee(FMain.EmployeeData.Items(ListBox1.Items(0)), "Name") & " would like to request some time off."
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       If My.Settings.SettingsSound = True then  My.Computer.Audio.Play(My.Resources.closewindow, AudioPlayMode.Background)

        ListBox1.Items.RemoveAt(0)

        If ListBox1.Items.Count > 0 Then
            Label1.Text = GetEmployee(FMain.EmployeeData.Items(ListBox1.Items(0)), "Name") & " would like to request some time off."
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class