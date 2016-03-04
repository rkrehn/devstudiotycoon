Public Class fAwards

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' slowly add each item
        If Label1.Top < 300 And Button2.Enabled = False Then Button2.Enabled = True

        If Label1.Top < -300 Then Timer1.Enabled = False

        Label1.Top = Label1.Top - 1


        'end the function if no more 
        'If ListBox3.Items.Count = 0 Then
        '    Timer1.Enabled = False
        '    Button2.Enabled = True
        '    Exit Sub
        'End If

        'if it's genre specific then goto listbox1, otherwise goto 2
        'If IsGenre(ListBox3.Items(0)) = True Then
        '    ListBox1.Items.Add(ListBox3.Items(0))
        '    ListBox3.Items.RemoveAt(0)
        'Else
        '    ListBox2.Items.Add(ListBox3.Items(0))
        '    ListBox3.Items.RemoveAt(0)
        'End If


    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged

    End Sub
    Private Function IsGenre(TheString As String) As Boolean
        IsGenre = True

        If InStr(ListBox3.Items(0), "Design") <> 0 Then IsGenre = False
        If InStr(ListBox3.Items(0), "Art") <> 0 Then IsGenre = False
        If InStr(ListBox3.Items(0), "Gameplay") <> 0 Then IsGenre = False
        If InStr(ListBox3.Items(0), "Story") <> 0 Then IsGenre = False
        If InStr(ListBox3.Items(0), "Replay") <> 0 Then IsGenre = False
        If InStr(ListBox3.Items(0), "Music") <> 0 Then IsGenre = False

    End Function

    Private Sub fAwards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Me.SetStyle(ControlStyles.UserPaint, True)

        Me.Invalidate(False)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

        With FMain
            .Timer1.Enabled = True
        End With
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub SlcTheme1_Click(sender As Object, e As EventArgs) Handles SlcTheme1.Click

    End Sub
End Class