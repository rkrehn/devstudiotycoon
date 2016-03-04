Public Class fSequel

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) - 1

        'Check last item
        If z < 1 Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & lst_Games.Items.Count
        z = z - 1

        'Build the textbox
        txt_Game.Text = GetGame(lst_Games.Items(z), "Name") & " is a(n) " & GetGame(lst_Games.Items(z), "Genre") & " game that had a rating of " & GetGame(lst_Games.Items(z), "Rating") & "."
    End Sub

    Private Sub SlCbtn2_Click(sender As Object, e As EventArgs) Handles SlCbtn2.Click
        Dim y As Integer, z As Integer, temp As String, TheQuest As String

        ' Gather variables
        z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 2) + 1

        'Check last item
        If z > lst_Games.Items.Count Then Exit Sub

        'Set the new item
        lbl_Selected.Text = z & " / " & lst_Games.Items.Count
        z = z - 1

        'Build the textbox
        txt_Game.Text = GetGame(lst_Games.Items(z), "Name") & " is a(n) " & GetGame(lst_Games.Items(z), "Genre") & " game that had a rating of " & GetGame(lst_Games.Items(z), "Rating") & "."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.menuselect, AudioPlayMode.Background)
        Dim z = Mid(lbl_Selected.Text, 1, InStr(lbl_Selected.Text, "/") - 1) - 1

        Dim Genre As String = GetGame(lst_Games.Items(z), "Genre")
        With fNewGame
            Call LoadForm2(Genre)

            .GameName.Text = GetGame(lst_Games.Items(z), "Name")
            .Show()
        End With

        Me.Hide()
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Me.Hide()
    End Sub
End Class