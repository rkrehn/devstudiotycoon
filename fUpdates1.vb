Public Class fUpdates1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ThePath As String = Application.ExecutablePath
        ThePath = Mid(ThePath, 1, Len(ThePath) - 21)

        If My.Computer.FileSystem.FileExists(ThePath & "Setup.exe") Then My.Computer.FileSystem.DeleteFile(ThePath & "Setup.exe")
        My.Computer.Network.DownloadFile("http://www.dstycoon.com/Setup.exe", ThePath & "Setup.exe")
        Timer1.Enabled = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub fUpdates1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ThePath As String = Application.ExecutablePath
        ThePath = Mid(ThePath, 1, Len(ThePath) - 21)

        If My.Computer.FileSystem.FileExists(ThePath & "Setup.exe") Then
            Shell(ThePath & "Setup.exe")
            Label2.Visible = False
            Timer1.Enabled = False
            End
        End If

        If Label2.Visible = True Then
            Label2.Visible = False
            Exit Sub
        Else
            Label2.Visible = True
            Exit Sub
        End If
    End Sub
End Class