Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Drawing
Imports System.Drawing.Drawing2D

Module Module1
    ' Error handling
    Public Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        Call WriteLog(Now & " - " & sender.ToString() & " // " & e.ToString)
    End Sub

    Dim FullGame As String
    Public MsgExists As Boolean
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "6LQ28I7CD5TTTTC"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "6LQ28I7CD5TTTTC"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function
    Public Function GenerateName(IsMale As Boolean) As String
        Dim x As Integer, Fname As String

        Try
            With FMain
                .MFirstNames.Refresh()
                .FFirstNames.Refresh()
                .LastNames.Refresh()
                x = GetRandom(1, 300)
                If IsMale = True Then
                    Fname = Mid(.MFirstNames.Items(x), 1, 1)
                    Fname = Fname & LCase(Mid(.MFirstNames.Items(x), 2))
                Else
                    Fname = Mid(.FFirstNames.Items(x), 1, 1)
                    Fname = Fname & LCase(Mid(.FFirstNames.Items(x), 2))
                End If

                x = GetRandom(1, 500)

                Fname = Fname & " " & Mid(.LastNames.Items(x), 1, 1)
                Fname = Fname & LCase(Mid(.LastNames.Items(x), 2))
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            GenerateName = Fname
        End Try
    End Function
    Public Function GetRandom(ByVal Min As Long, ByVal Max As Long) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()

        If Min > Max Then Max = Min

        Return Generator.Next(Min, Max)
    End Function
    Public Function EmployeeGen(Pos As String, TheSeat As Integer) As String
        Dim TheName As String, Artist As Integer, ArtistPot As Integer, Tech As Integer, TechPot As Integer, TheSpeed As Integer, SpeedMax As Integer, StressMax As Integer, TheImage As String
        Dim x As Integer, isMale As Boolean

        Try
            'Name,Position,Pay,Artistry,ArtPotential,Tech,TechPotential,Speed,SpeedPotential,Happiness,Stress,StressMax,PTO,TheSeat,TheImage

            TheImage = Nothing

            x = GetRandom(1, 6)

            If x = 1 Then
                TheName = GenerateName(False)
                isMale = False
            Else
                TheName = GenerateName(True)
                isMale = True
            End If

            'generate male/female pics
            x = GetRandom(1, 7)
            If isMale = True Then
                If TheSeat < 7 Then TheImage = "m" & x & "down"
                If TheSeat > 6 And TheSeat < 12 Then TheImage = "m" & x & "up"
                If TheSeat > 11 And TheSeat < 17 Then TheImage = "m" & x & "down"
                If TheSeat > 16 And TheSeat < 22 Then TheImage = "m" & x & "down"
            Else
                If TheSeat < 7 Then TheImage = "f" & x & "down"
                If TheSeat > 6 And TheSeat < 12 Then TheImage = "f" & x & "up"
                If TheSeat > 11 And TheSeat < 17 Then TheImage = "f" & x & "down"
                If TheSeat > 16 And TheSeat < 22 Then TheImage = "f" & x & "down"
            End If

            Select Case Pos
                Case Is = "Artist"
                    x = GetRandom(10, 100)
                    If x < 60 Then ArtistPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then ArtistPot = GetRandom(81, 90)
                    If x >= 80 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then TechPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then TechPot = GetRandom(75, 90)
                    If x >= 95 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

                Case Is = "Designer"

                    x = GetRandom(10, 100)
                    If x < 60 Then ArtistPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then ArtistPot = GetRandom(81, 90)
                    If x >= 80 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then TechPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then TechPot = GetRandom(75, 90)
                    If x >= 95 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

                Case Is = "Writer"

                    x = GetRandom(10, 100)
                    If x < 60 Then ArtistPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then ArtistPot = GetRandom(81, 90)
                    If x >= 80 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then TechPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then TechPot = GetRandom(75, 90)
                    If x >= 95 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

                Case Is = "Programmer"

                    x = GetRandom(10, 100)
                    If x < 60 Then TechPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then TechPot = GetRandom(81, 90)
                    If x >= 80 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then ArtistPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then ArtistPot = GetRandom(75, 90)
                    If x >= 95 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

                Case Is = "Audio"

                    x = GetRandom(10, 100)
                    If x < 60 Then ArtistPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then ArtistPot = GetRandom(81, 90)
                    If x >= 80 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then TechPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then TechPot = GetRandom(75, 90)
                    If x >= 95 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

                Case Is = "Tester"

                    x = GetRandom(10, 100)
                    If x < 60 Then TechPot = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then TechPot = GetRandom(81, 90)
                    If x >= 80 Then TechPot = GetRandom(91, 100)

                    Tech = GetRandom(10, TechPot)

                    x = GetRandom(10, 100)
                    If x < 80 Then ArtistPot = GetRandom(60, 75)
                    If x >= 80 And x < 95 Then ArtistPot = GetRandom(75, 90)
                    If x >= 95 Then ArtistPot = GetRandom(91, 100)

                    Artist = GetRandom(10, ArtistPot)

                    x = GetRandom(10, 100)
                    If x < 60 Then SpeedMax = GetRandom(60, 80)
                    If x >= 60 And x < 80 Then SpeedMax = GetRandom(81, 90)
                    If x >= 80 Then SpeedMax = GetRandom(91, 100)

                    TheSpeed = GetRandom(10, SpeedMax)

            End Select

            x = GetRandom(10, 100)
            If x < 60 Then StressMax = GetRandom(40, 70)
            If x >= 60 And x < 80 Then StressMax = GetRandom(60, 80)
            If x >= 80 Then StressMax = GetRandom(70, 100)

            'Name,Position,Pay,Artistry,ArtPotential,Tech,TechPotential,Speed,SpeedPotential,Happiness,Stress,StressMax,PTO,TheSeat,TheImage
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            EmployeeGen = TheName & "," & Salary(FMain.TheYear.Text, Artist, Tech) & "," & Pos & "," & Artist & "," & ArtistPot & "," & Tech & "," & TechPot & "," & TheSpeed & "," & SpeedMax & ",5,1," & StressMax & ",N," & TheSeat & "," & TheImage
        End Try
    End Function
    Public Function GetEmployee(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        Dim TheName As String, TheSalary As String, Pos As String, Artist As Integer, ArtistPot As Integer, Tech As Integer
        Dim TechPot As Integer, TheSpeed As Integer, SpeedMax As Integer, Happiness As Integer, Stressed As Integer, StressMax As Integer, TheSeat As String, TheImage As String, PTO As String
        Dim temp As String, x As Integer

        'Name,Position,Pay,Artistry,ArtPotential,Tech,TechPotential,Speed,SpeedPotential,Happiness,Stress,StressMax,PTO,TheSeat,TheImage,

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheName = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            TheSalary = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Pos = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Artist = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            ArtistPot = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Tech = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TechPot = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheSpeed = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            SpeedMax = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Happiness = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Stressed = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            StressMax = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            PTO = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheSeat = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            TheImage = temp
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Name"
                GetEmployee = TheName
                Return GetEmployee

            Case Is = "Position"
                GetEmployee = Pos
                Return GetEmployee

            Case Is = "Artist"
                If ChangeTo <> "" Then
                    Artist = Int(ChangeTo)
                Else
                    GetEmployee = Artist
                    Return GetEmployee
                End If

            Case Is = "ArtistMax"
                GetEmployee = ArtistPot
                Return GetEmployee

            Case Is = "Tech"
                If ChangeTo <> "" Then
                    Tech = Int(ChangeTo)
                Else
                    GetEmployee = Tech
                    Return GetEmployee
                End If

            Case Is = "TechMax"
                GetEmployee = TechPot
                Return GetEmployee

            Case Is = "Speed"
                If ChangeTo <> "" Then
                    TheSpeed = Int(ChangeTo)
                Else
                    GetEmployee = TheSpeed
                    Return GetEmployee
                End If

            Case Is = "SpeedMax"
                GetEmployee = SpeedMax
                Return GetEmployee

            Case Is = "Happiness"
                If ChangeTo <> "" Then
                    Happiness = Int(ChangeTo)
                Else
                    GetEmployee = Happiness
                    Return GetEmployee
                End If

            Case Is = "Stress"
                If ChangeTo <> "" Then
                    Stressed = Int(ChangeTo)
                Else
                    GetEmployee = Stressed
                    Return GetEmployee
                End If

            Case Is = "StressMax"
                GetEmployee = StressMax
                Return GetEmployee

            Case Is = "Salary"
                If ChangeTo <> "" Then
                    'TheSalary = Salary(FMain.TheYear.Text, Artist, Tech) 'changeto doesn't function, so any number is valid
                    TheSalary = ChangeTo
                Else
                    GetEmployee = TheSalary
                    Return GetEmployee
                End If

            Case Is = "PTO"
                If ChangeTo <> "" Then
                    PTO = ChangeTo  'changeto doesn't function, so any number is valid
                Else
                    GetEmployee = PTO
                    Return GetEmployee
                End If

            Case Is = "Seat"
                If ChangeTo <> "" Then
                    TheSeat = ChangeTo  'changeto doesn't function, so any number is valid
                Else
                    GetEmployee = TheSeat
                    Return GetEmployee
                End If

            Case Is = "Image"
                If ChangeTo <> "" Then
                    TheImage = ChangeTo  'changeto doesn't function, so any number is valid
                Else
                    GetEmployee = TheImage
                    Return GetEmployee
                End If
        End Select

        'Name,Position,Pay,Artistry,ArtPotential,Tech,TechPotential,Speed,SpeedPotential,Happiness,Stress,StressMax,PTO,TheSeat,TheImage
        'return full employee data if a change is needed
        GetEmployee = TheName & "," & TheSalary & "," & Pos & "," & Artist & "," & ArtistPot & "," & Tech & "," & TechPot & "," & TheSpeed & "," & SpeedMax & "," & Happiness & "," & Stressed & "," & StressMax & "," & PTO & "," & TheSeat & "," & TheImage
        Return GetEmployee
    End Function
    Public Sub SetSeating(Optional ByRef OffHours = False)
        Dim PTO As String, TheSeat As Integer, TheImage As String
        Dim x As Integer

        Try
            With FMain

                If OffHours = True Then
                    .PictureBox1.Image = Nothing
                    .PictureBox2.Image = Nothing
                    .PictureBox3.Image = Nothing
                    .PictureBox4.Image = Nothing
                    .PictureBox5.Image = Nothing
                    .PictureBox6.Image = Nothing
                    .PictureBox7.Image = Nothing
                    .PictureBox8.Image = Nothing
                    .PictureBox9.Image = Nothing
                    .PictureBox10.Image = Nothing
                    .PictureBox11.Image = Nothing
                    .PictureBox12.Image = Nothing
                    .PictureBox13.Image = Nothing
                    .PictureBox14.Image = Nothing
                    .PictureBox15.Image = Nothing
                    .PictureBox16.Image = Nothing
                    .PictureBox17.Image = Nothing
                    .PictureBox18.Image = Nothing
                    .PictureBox19.Image = Nothing
                    .PictureBox20.Image = Nothing
                    .PictureBox21.Image = Nothing
                    Exit Sub
                End If

                .EmployeeData.Refresh()
                x = .EmployeeData.Items.Count - 1

                If x = -1 Then Exit Sub

                Do
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    TheSeat = GetEmployee(.EmployeeData.Items(x), "Seat")
                    TheImage = GetEmployee(.EmployeeData.Items(x), "Image")

                    'Dim ImageSource As String = My.Resources.ResourceManager.GetObject(TheImage)


                    Select Case TheSeat
                        Case Is = 1
                            If PTO = "N" Then
                                .PictureBox1.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox1.Image = Nothing
                            End If

                        Case Is = 2
                            If PTO = "N" Then
                                .PictureBox2.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox2.Image = Nothing
                            End If
                        Case Is = 3
                            If PTO = "N" Then
                                .PictureBox3.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox3.Image = Nothing
                            End If
                        Case Is = 4
                            If PTO = "N" Then
                                .PictureBox4.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox4.Image = Nothing
                            End If
                        Case Is = 5
                            If PTO = "N" Then
                                .PictureBox5.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox5.Image = Nothing
                            End If
                        Case Is = 6
                            If PTO = "N" Then
                                .PictureBox6.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox6.Image = Nothing
                            End If
                        Case Is = 7
                            If PTO = "N" Then
                                .PictureBox7.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox7.Image = Nothing
                            End If
                        Case Is = 8
                            If PTO = "N" Then
                                .PictureBox8.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox8.Image = Nothing
                            End If
                        Case Is = 9
                            If PTO = "N" Then
                                .PictureBox9.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox9.Image = Nothing
                            End If
                        Case Is = 10
                            If PTO = "N" Then
                                .PictureBox10.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox10.Image = Nothing
                            End If
                        Case Is = 11
                            If PTO = "N" Then
                                .PictureBox11.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox11.Image = Nothing
                            End If
                        Case Is = 12
                            If PTO = "N" Then
                                .PictureBox12.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox12.Image = Nothing
                            End If
                        Case Is = 13
                            If PTO = "N" Then
                                .PictureBox13.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox13.Image = Nothing
                            End If
                        Case Is = 14
                            If PTO = "N" Then
                                .PictureBox14.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox14.Image = Nothing
                            End If
                        Case Is = 15
                            If PTO = "N" Then
                                .PictureBox15.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox15.Image = Nothing
                            End If
                        Case Is = 16
                            If PTO = "N" Then
                                .PictureBox16.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox16.Image = Nothing
                            End If
                        Case Is = 17
                            If PTO = "N" Then
                                .PictureBox17.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox17.Image = Nothing
                            End If
                        Case Is = 18
                            If PTO = "N" Then
                                .PictureBox18.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox18.Image = Nothing
                            End If
                        Case Is = 19
                            If PTO = "N" Then
                                .PictureBox19.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox19.Image = Nothing
                            End If
                        Case Is = 20
                            If PTO = "N" Then
                                .PictureBox20.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox20.Image = Nothing
                            End If
                        Case Is = 21
                            If PTO = "N" Then
                                .PictureBox21.Image = CType(My.Resources.ResourceManager.GetObject(TheImage), Image) 'My.Resources.ResourceManager.GetObject(TheImage & ".png")
                            Else
                                .PictureBox21.Image = Nothing
                            End If
                    End Select

                    Application.DoEvents()
                    x = x - 1
                Loop Until x = -1
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Function GetConsole(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
        Dim TheCompany As String, ConsoleName As String, TechLevel As Integer, TheRelease As String, ReleaseDate As Integer, Retired As String
        Dim TheCost As Integer, ThePrice As Integer, TheSales As Long, PrevSales As Long, temp As String, x As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            If TheCompany = "Company" Then
                GetConsole = TheData
                Exit Function
            End If


            x = InStr(temp, ",") - 1
            ConsoleName = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TechLevel = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheRelease = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Retired = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheCost = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            ThePrice = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheSales = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            PrevSales = Int(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try


        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If IsNumeric(TheRelease) = True Then ReleaseDate = Int(TheRelease)

        Select Case WhatData
            Case Is = "Company"
                GetConsole = TheCompany
                Return GetConsole

            Case Is = "Console"
                GetConsole = ConsoleName
                Return GetConsole

            Case Is = "Position"
                GetConsole = ConsoleName
                Return GetConsole

            Case Is = "Tech"
                If ChangeTo <> "" Then
                    TechLevel = Int(ChangeTo)
                Else
                    GetConsole = TechLevel
                    Return GetConsole
                End If

            Case Is = "Release"
                If ChangeTo <> "" Then
                    ReleaseDate = Int(ChangeTo)
                Else
                    If IsNumeric(TheRelease) = True Then
                        GetConsole = ReleaseDate
                    Else
                        GetConsole = TheRelease
                    End If
                    Return GetConsole
                End If

            Case Is = "Retire"
                If ChangeTo <> "" Then
                    Retired = Int(ChangeTo)
                Else
                    GetConsole = Retired
                    Return GetConsole
                End If

            Case Is = "Cost"
                If ChangeTo <> "" Then
                    TheCost = Int(ChangeTo)
                Else
                    GetConsole = TheCost
                    Return GetConsole
                End If

            Case Is = "Price"
                If ChangeTo <> "" Then
                    ThePrice = Int(ChangeTo)
                Else
                    GetConsole = ThePrice
                    Return GetConsole
                End If

            Case Is = "Sales"
                If ChangeTo <> "" Then
                    TheSales = Int(ChangeTo)
                Else
                    GetConsole = TheSales
                    Return GetConsole
                End If
            Case Is = "PreviousSales"
                If ChangeTo <> "" Then
                    PrevSales = Int(ChangeTo)
                Else
                    GetConsole = PrevSales
                    Return GetConsole
                End If
        End Select


        'return full console data if a change is needed
        'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
        GetConsole = TheCompany & "," & ConsoleName & "," & TechLevel & "," & ReleaseDate & "," & Retired & "," & TheCost & "," & ThePrice & "," & TheSales & "," & PrevSales
        Return GetConsole
    End Function
    Public Function GetCompany(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'Company Name,Sales,TimeBetween,Expenses,Cash,Income,Strategy,Publisher
        Dim TheCompany As String, TheSales As Long, TimeBetween As Integer, Expenses As Long, Cash As Long, Strategy As String, TheIncome As Long, ThePublisher As String
        Dim x As Integer, temp As String
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            TheSales = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TimeBetween = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Expenses = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Cash = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheIncome = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Strategy = Left(temp, x)
            temp = Mid(temp, x + 2)

            ThePublisher = temp
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Company"
                If ChangeTo <> "" Then
                    GetCompany = ChangeTo
                Else
                    GetCompany = TheCompany
                    Return GetCompany
                End If

            Case Is = "Sales"
                If ChangeTo <> "" Then
                    TheSales = Val(ChangeTo)
                Else
                    GetCompany = TheSales
                    Return GetCompany
                End If

            Case Is = "Time"
                If ChangeTo <> "" Then
                    TimeBetween = Int(ChangeTo)
                Else
                    GetCompany = TimeBetween
                    Return GetCompany
                End If

            Case Is = "Expenses"
                If ChangeTo <> "" Then
                    Expenses = Val(ChangeTo)
                Else
                    GetCompany = Expenses
                    Return GetCompany
                End If

            Case Is = "Cash"
                If ChangeTo <> "" Then
                    If ChangeTo.Contains(".") Then ChangeTo = UInteger.MaxValue
                    Cash = Val(ChangeTo)
                Else
                    GetCompany = Cash
                    Return GetCompany
                End If

            Case Is = "Income"
                If ChangeTo <> "" Then
                    If ChangeTo.Contains(".") Then ChangeTo = UInteger.MaxValue
                    TheIncome = Val(ChangeTo)
                Else
                    GetCompany = TheIncome
                    Return GetCompany
                End If

            Case Is = "Strategy"
                If ChangeTo <> "" Then
                    Strategy = ChangeTo
                Else
                    GetCompany = Strategy
                    Return GetCompany
                End If

            Case Is = "Publisher"
                If ChangeTo <> "" Then
                    ThePublisher = ChangeTo
                Else
                    GetCompany = ThePublisher
                    Return GetCompany
                End If
        End Select

        'return full company data if a change is needed
        'Company Name,Sales,TimeBetween,Expenses,Cash,Income,Strategy,Publisher
        GetCompany = TheCompany & "," & TheSales & "," & TimeBetween & "," & Expenses & "," & Cash & "," & TheIncome & "," & Strategy & "," & ThePublisher
        Return GetCompany
    End Function
    Public Function GetGame(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'Company Name,Game Name,Genre,Design,Art,Gameplay,Story,Replay,Audio,Bugs,Rating,Console,ReleaseDate,Sales,PreviousSales
        Dim TheCompany As String, TheGame As String, TheGenre As String, TheDesign As Long, TheArt As Long, TheStory As Long, TheGameplay As Long, TheReplay As Long, TheRating As Integer, TheAudio As Long, TheBugs As Integer
        Dim TheConsole As String, ReleaseDate As Integer, TheSales As Long, PrevSales As Long
        Dim x As Integer, temp As String
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            TheGame = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheGenre = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheDesign = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheArt = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheStory = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheGameplay = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheReplay = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheAudio = Val(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheBugs = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheRating = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheConsole = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            ReleaseDate = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheSales = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            PrevSales = Val(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Company"
                If ChangeTo <> "" Then
                    TheCompany = ChangeTo
                Else
                    GetGame = TheCompany
                    Return GetGame
                End If

            Case Is = "Name"
                If ChangeTo <> "" Then
                    TheGame = ChangeTo
                Else
                    GetGame = TheGame
                    Return GetGame
                End If

            Case Is = "Genre"
                GetGame = TheGenre
                Return GetGame

            Case Is = "Design"
                GetGame = TheDesign
                Return GetGame
            Case Is = "Art"
                GetGame = TheArt
                Return GetGame

            Case Is = "Gameplay"
                GetGame = TheGameplay
                Return GetGame

            Case Is = "Story"
                GetGame = TheStory
                Return GetGame

            Case Is = "Replay"
                GetGame = TheReplay
                Return GetGame

            Case Is = "Audio"
                GetGame = TheAudio
                Return GetGame

            Case Is = "Bugs"
                GetGame = TheBugs
                Return GetGame

            Case Is = "Rating"
                GetGame = TheRating
                Return GetGame

            Case Is = "Console"
                GetGame = TheConsole
                Return GetGame

            Case Is = "Release"
                If ChangeTo <> "" Then
                    ReleaseDate = ChangeTo
                Else
                    GetGame = ReleaseDate
                    Return GetGame
                End If

            Case Is = "Sales"
                If ChangeTo <> "" Then
                    TheSales = ChangeTo
                Else
                    GetGame = TheSales
                    Return GetGame
                End If
            Case Is = "PreviousSales"
                If ChangeTo <> "" Then
                    PrevSales = ChangeTo
                Else
                    GetGame = PrevSales
                    Return GetGame
                End If

        End Select

        'return full game data if a change is needed
        'Company Name,Game Name,Genre,Design,Art,Gameplay,Story,Replay,Audio,Bugs,Rating,Console,ReleaseDate,Sales,PreviousSales
        GetGame = TheCompany & "," & TheGame & "," & TheGenre & "," & TheDesign & "," & TheArt & "," & TheGameplay & "," & TheStory & "," & TheReplay & "," & TheAudio & "," & TheBugs & "," & TheRating & "," & TheConsole & "," & ReleaseDate & "," & TheSales & "," & PrevSales
        Return GetGame
    End Function
    Public Function GetEngine(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
        Dim TheName As String, TheConsole As String, TheCompany As String, TechLevel As Integer, Usability As Integer, ThePrice As Integer, ReleaseDate As Integer
        Dim temp As String, x As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheName = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            TheConsole = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheCompany = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TechLevel = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Usability = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            ThePrice = Int(Left(temp, x))
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            ReleaseDate = Int(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Name"
                GetEngine = TheName
                Return GetEngine

            Case Is = "Console"
                GetEngine = TheConsole
                Return GetEngine

            Case Is = "Company"
                GetEngine = TheCompany
                Return GetEngine

            Case Is = "Tech"
                If ChangeTo <> "" Then
                    TechLevel = Int(ChangeTo)
                Else
                    GetEngine = TechLevel
                    Return GetEngine
                End If

            Case Is = "Usability"
                If ChangeTo <> "" Then
                    Usability = Int(ChangeTo)
                Else
                    GetEngine = Usability
                    Return GetEngine
                End If

            Case Is = "Price"
                If ChangeTo <> "" Then
                    ThePrice = Int(ChangeTo)
                Else
                    GetEngine = ThePrice
                    Return GetEngine
                End If

            Case Is = "Release"
                If ChangeTo <> "" Then
                    ReleaseDate = Int(ChangeTo)
                Else
                    GetEngine = ReleaseDate
                    Return GetEngine
                End If
        End Select

        'return full engine data if a change is needed
        'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
        GetEngine = TheName & "," & TheConsole & "," & TheCompany & "," & TechLevel & "," & Usability & "," & ThePrice & "," & ReleaseDate
        Return GetEngine
    End Function
    Public Function Salary(TheYear As Long, Art As Long, Tech As Long) As Long
        Try
            Salary = 100

            If TheYear < 1990 Then
                Salary = (Art + Tech) * 5
                Exit Function
            End If

            If TheYear >= 1990 And TheYear < 1995 Then
                Salary = (Art + Tech) * 6
                Exit Function
            End If

            If TheYear >= 1995 And TheYear < 2000 Then
                Salary = (Art + Tech) * 8
                Exit Function
            End If

            If TheYear >= 2000 And TheYear < 2005 Then
                Salary = (Art + Tech) * 10
                Exit Function
            End If

            If TheYear >= 2005 And TheYear < 2010 Then
                Salary = (Art + Tech) * 12
                Exit Function
            End If

            If TheYear >= 2010 And TheYear < 2015 Then
                Salary = (Art + Tech) * 14
                Exit Function
            End If

            If TheYear >= 2015 And TheYear < 2020 Then
                Salary = (Art + Tech) * 16
                Exit Function
            End If

            If TheYear >= 2020 And TheYear < 2025 Then
                Salary = (Art + Tech) * 18
                Exit Function
            End If

            If TheYear >= 2025 And TheYear < 2030 Then
                Salary = (Art + Tech) * 20
                Exit Function
            End If

            If TheYear >= 2030 And TheYear < 2035 Then
                Salary = (Art + Tech) * 22
                Exit Function
            End If

            If TheYear >= 2035 And TheYear < 2040 Then
                Salary = (Art + Tech) * 24
                Exit Function
            End If

            If TheYear >= 2040 And TheYear < 2045 Then
                Salary = (Art + Tech) * 26
                Exit Function
            End If

            If TheYear >= 2045 Then
                Salary = (Art + Tech) * 28
                Exit Function
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Function
    Public Function GetAvgSalary() As Long
        Dim TheYear As Integer, Art As Long, Tech As Long


        Try
            TheYear = FMain.TheYear.Text

            GetAvgSalary = 700
            Art = GetRandom(25, 75)
            Tech = GetRandom(25, 75)

            If TheYear < 1990 Then
                GetAvgSalary = (Art + Tech) * 5
                Return GetAvgSalary
            End If

            If TheYear >= 1990 And TheYear < 1995 Then
                GetAvgSalary = (Art + Tech) * 6
                Return GetAvgSalary
            End If

            If TheYear >= 1995 And TheYear < 2000 Then
                GetAvgSalary = (Art + Tech) * 8
                Return GetAvgSalary
            End If

            If TheYear >= 2000 And TheYear < 2005 Then
                GetAvgSalary = (Art + Tech) * 10
                Return GetAvgSalary
            End If

            If TheYear >= 2005 And TheYear < 2010 Then
                GetAvgSalary = (Art + Tech) * 12
                Return GetAvgSalary
            End If

            If TheYear >= 2010 And TheYear < 2015 Then
                GetAvgSalary = (Art + Tech) * 14
                Return GetAvgSalary
            End If

            If TheYear >= 2015 And TheYear < 2020 Then
                GetAvgSalary = (Art + Tech) * 16
                Return GetAvgSalary
            End If

            If TheYear >= 2020 And TheYear < 2025 Then
                GetAvgSalary = (Art + Tech) * 18
                Return GetAvgSalary
            End If

            If TheYear >= 2025 And TheYear < 2030 Then
                GetAvgSalary = (Art + Tech) * 20
                Return GetAvgSalary
            End If

            If TheYear >= 2030 And TheYear < 2035 Then
                GetAvgSalary = (Art + Tech) * 22
                Return GetAvgSalary
            End If

            If TheYear >= 2035 And TheYear < 2040 Then
                GetAvgSalary = (Art + Tech) * 24
                Return GetAvgSalary
            End If

            If TheYear >= 2040 And TheYear < 2045 Then
                GetAvgSalary = (Art + Tech) * 26
                Return GetAvgSalary
            End If

            If TheYear >= 2045 Then
                GetAvgSalary = (Art + Tech) * 28
                Return GetAvgSalary
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Function
    Public Function GenCo() As String
        'Company Name,Sales,TimeBetween,Expenses,Cash,Income,Strategy,Publisher
        Dim CoName As String, Strategy As String, ThePublisher As String
        Dim x As Integer, TimeBetween As Long

        Try

            FMain.CoName.Refresh()
            FMain.CoName2.Refresh()
            FMain.Companies.Refresh()
GenCo_Start:
            ThePublisher = 0

            'determine name
            x = GetRandom(1, 5)
            If x = 1 Then
                CoName = FMain.CoName.Items(GetRandom(0, FMain.CoName.Items.Count - 1))
            Else
                CoName = FMain.CoName.Items(GetRandom(0, FMain.CoName.Items.Count - 1))
                CoName = CoName & " " & FMain.CoName2.Items(GetRandom(0, FMain.CoName2.Items.Count - 1))
            End If

            x = GetRandom(1, 8)
            Strategy = "Average"

            'set strategy
            Select Case x
                Case Is = 1
                    Strategy = "Rapid"
                Case Is = 2
                    Strategy = "Sequel"
                Case Is = 3
                    Strategy = "Quality"
                Case Is = 4
                    Strategy = "Reboot"
                Case Is = 5
                    Strategy = "Chance"
                Case Is = 6
                    Strategy = "Engine"
                Case Is = 7
                    Strategy = "America"
                Case Is = 8
                    Strategy = "Average"
            End Select

            x = FMain.Companies.Items.Count - 1
            If x = -1 Then GoTo GenCo_Cont

            'determine if name already exists
            'Do
            'If InStr(FMain.Companies.Items(x), Left(CoName, 4)) <> 0 Then GoTo GenCo_Start
            'x = x - 1
            'Loop Until x = -1
            x = FMain.Companies.FindString(CoName)
            If x <> -1 Then GoTo GenCo_Start

            'define publisher
            Dim newlist As ListBox = New ListBox
            For Each itm In FMain.Companies.Items
                If GetCompany(itm, "Cash") > 1000000 Then
                    newlist.Items.Add(GetCompany(itm, "Company"))
                End If
            Next

            If newlist.Items.Count <> 0 Then
                x = GetRandom(0, newlist.Items.Count - 1)
                ThePublisher = newlist.Items(x)
            End If

            TimeBetween = GetRandom(40, 80)
            If Strategy = "Quality" Then TimeBetween = GetRandom(60, 120)
            If Strategy = "Rapid" Then TimeBetween = GetRandom(30, 60)

GenCo_Cont:
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            'Company Name,Sales,TimeBetween,Expenses,Cash,Income,Strategy,Publisher
            GenCo = CoName & ",0," & TimeBetween & "," & GetRandom(GetAvgSalary, GetAvgSalary() * 5) & "," & GetRandom(10000, 25000) & ",0," & Strategy & "," & ThePublisher
        End Try
    End Function
    Public Function GenConsole(Optional ByRef CoName As String = "TempCo", Optional ByRef PreSales As Boolean = False) As String
        'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
        Dim ConsoleName As String, TechLevel As Integer, TheCost As Integer, ThePrice As Integer, TheSales As Long
        Dim x As Integer, temp As String

        Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                      Console Name generator
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            x = GetRandom(1, 10)

            If x >= 0 And x <= 3 Then
                ConsoleName = FMain.Console1.Items(GetRandom(0, FMain.Console1.Items.Count))
            Else
                ConsoleName = FMain.Console1.Items(GetRandom(0, FMain.Console1.Items.Count))
                ConsoleName = ConsoleName & " " & FMain.Console2.Items(GetRandom(0, FMain.Console2.Items.Count))
            End If

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                       Technical determination
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TechLevel = GetRandom(65, 100)

            'determine cost of console based on year
            If FMain.TheYear.Text < 1990 Then
                TheCost = TechLevel * 2
            End If

            If FMain.TheYear.Text >= 1990 And FMain.TheYear.Text <= 2000 Then
                TheCost = TechLevel * 3
            End If

            If FMain.TheYear.Text >= 2000 And FMain.TheYear.Text <= 2010 Then
                TheCost = TechLevel * 4
            End If

            If FMain.TheYear.Text >= 2010 And FMain.TheYear.Text <= 2020 Then
                TheCost = TechLevel * 5
            End If

            If FMain.TheYear.Text >= 2010 And FMain.TheYear.Text <= 2030 Then
                TheCost = TechLevel * 6
            End If

            If FMain.TheYear.Text >= 2010 And FMain.TheYear.Text <= 2040 Then
                TheCost = TechLevel * 7
            End If

            If FMain.TheYear.Text >= 2040 Then
                TheCost = TechLevel * 8
            End If

            'gather the price
            x = GetRandom(3, 10)

            If x = 10 Then
                ThePrice = TheCost * 2
            Else
                temp = "1." & x
                temp = TheCost * Val(temp)
                temp = Math.Round(Int(temp) / 25) * 25
                ThePrice = Val(temp)
            End If

            'determine sales 
            With FMain
                If Val(FMain.TheYear.Text) <= 1990 Then TheSales = GetRandom(1000, 5000)
                If Val(FMain.TheYear.Text) > 1990 And Val(FMain.TheYear.Text) <= 1995 Then TheSales = GetRandom(3000, 10000)
                If Val(FMain.TheYear.Text) > 1995 And Val(FMain.TheYear.Text) <= 2000 Then TheSales = GetRandom(10000, 4000000)
                If Val(FMain.TheYear.Text) > 2000 And Val(FMain.TheYear.Text) <= 2005 Then TheSales = GetRandom(20000, 5000000)
                If Val(FMain.TheYear.Text) > 2005 And Val(FMain.TheYear.Text) <= 2010 Then TheSales = GetRandom(30000, 6000000)
                If Val(FMain.TheYear.Text) > 2010 And Val(FMain.TheYear.Text) <= 2020 Then TheSales = GetRandom(40000, 7000000)
                If Val(FMain.TheYear.Text) > 2030 And Val(FMain.TheYear.Text) <= 2040 Then TheSales = GetRandom(50000, 8000000)
                If Val(FMain.TheYear.Text) > 2040 Then TheSales = GetRandom(500000, 10000000)
            End With

            If PreSales = True Then
                If TheSales < 100000 Then TheSales = TheSales * GetRandom(50, 200)
                If TheSales >= 100000 And TheSales < 1000000 Then TheSales = TheSales + GetRandom(10, 50)
            End If

            If TheSales >= UInteger.MaxValue Then TheSales = (UInteger.MaxValue / 2)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
            GenConsole = CoName & "," & ConsoleName & "," & TechLevel & "," & "-" & GetRandom(12, 24) & "," & "N" & "," & TheCost & "," & ThePrice & "," & TheSales & ",0"
        End Try

    End Function
    Public Function GenEngine(Company As String) As String
        'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
        Dim TheName As String, ConsoleName As String, TechLevel As Integer, Usability As Integer
        Dim ThePrice As Integer
        Dim x As Integer, temp As String

        Try
            '/temp build script based on console popularity
            x = FMain.NewConsoles.Items.Count - 1
            x = GetRandom(0, x)
            ConsoleName = GetConsole(FMain.NewConsoles.Items(x), "Console")

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                      Console Name generator
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            TheName = FMain.EngineNames.Items(GetRandom(0, FMain.EngineNames.Items.Count))

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                       Technical determination
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            TechLevel = GetRandom(50, 90)
            If TechLevel = 90 Then TechLevel = GetRandom(90, 100) 'makes 90+ engines more rare 

            Usability = GetRandom(50, 90)
            If Usability = 90 Then Usability = GetRandom(90, 100) 'makes 90+ engines more rare 

            'determine price based on usability and techlevel
            x = GetRandom(2, 10)

            If x = 10 Then
                ThePrice = (TechLevel + Usability) * 10
            Else
                temp = "1." & x
                temp = Int(TechLevel + Usability) * Val(temp)
                temp = Math.Round(Int(temp) / 5) * 5
                ThePrice = Val(temp) * 10
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
            GenEngine = TheName & "," & ConsoleName & "," & Company & "," & TechLevel & "," & Usability & "," & ThePrice & ",1"
        End Try

    End Function
    Public Function GenGame(CoName As String, CoType As String, Optional ByRef Sequel As String = "0") As String
        Dim TheGame As String, TheGenre As String, TheDesign As Long, TheArt As Long, TheGameplay As Long, TheAudio, TheBugs As Long
        Dim TheStory As Long, TheReplay As Long, TheRating As Long, TheConsole As String, TheSales As Long
        Dim gMin As Integer, gMax As Integer
        Dim x As Integer, y As Integer, TheCo2 As String, TheCash As Long, ConsoleX As Integer

        Try
            'Company Name,Game Name,Genre,Design,Art,Gameplay,Story,Replay,Audio,Bugs,Rating,Console,ReleaseDate,Sales,PreviousSales

            'Clean
            TheConsole = Nothing
            TheGenre = Nothing

            With FMain
                If Sequel = "0" Then
                    TheGame = GameName()
                Else
                    TheGame = Sequel
                End If

                'If CoType = "Engine" Or CoType = "American" Then CoType = "Average"

                Select Case CoType
                    Case Is = "Rapid"
                        x = GetRandom(100, 700)
                        gMin = x - 200
                        gMax = x + 200
                        If gMin < 1 Then gMin = 1

                        TheDesign = GetRandom(gMin, gMax)

                        TheArt = GetRandom(gMin, gMax)

                        TheGameplay = GetRandom(gMin, gMax)

                        TheStory = GetRandom(gMin, gMax)

                        TheReplay = GetRandom(gMin, gMax)

                        TheAudio = GetRandom(gMin, gMax)

                        TheBugs = GetRandom(10, 25)

                    Case Is = "Sequel"
                        x = GetRandom(100, 900)
                        gMin = x - 200
                        gMax = x + 200
                        If gMin < 1 Then gMin = 1
                        If gMax > 999 Then gMax = 999


                        TheDesign = GetRandom(gMin, gMax)
                        TheArt = GetRandom(gMin, gMax)
                        TheGameplay = GetRandom(gMin, gMax)
                        TheStory = GetRandom(gMin, gMax)
                        TheReplay = GetRandom(gMin, gMax)
                        TheAudio = GetRandom(gMin, gMax)
                        TheBugs = GetRandom(5, 20)

                    Case Is = "Quality"
                        x = GetRandom(1, 10)
                        If x <= 5 Then TheDesign = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheDesign = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheDesign = GetRandom(901, 950)
                        If x = 10 Then TheDesign = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 5 Then TheArt = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheArt = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheArt = GetRandom(901, 950)
                        If x = 10 Then TheArt = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 5 Then TheGameplay = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheGameplay = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheGameplay = GetRandom(901, 950)
                        If x = 10 Then TheGameplay = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 5 Then TheStory = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheStory = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheStory = GetRandom(901, 950)
                        If x = 10 Then TheStory = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 5 Then TheReplay = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheReplay = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheReplay = GetRandom(901, 950)
                        If x = 10 Then TheReplay = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 5 Then TheAudio = GetRandom(600, 850)
                        If x = 6 Or x = 7 Then TheAudio = GetRandom(851, 900)
                        If x = 8 Or x = 9 Then TheAudio = GetRandom(901, 950)
                        If x = 10 Then TheAudio = GetRandom(951, 999)

                        TheBugs = GetRandom(0, 10)

                    Case Is = "Reboot"
                        x = GetRandom(1, 10)
                        If x <= 7 Then TheDesign = GetRandom(500, 700)
                        If x = 8 Then TheDesign = GetRandom(701, 800)
                        If x = 9 Then TheDesign = GetRandom(801, 950)
                        If x = 10 Then TheDesign = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheArt = GetRandom(500, 700)
                        If x = 8 Then TheArt = GetRandom(701, 800)
                        If x = 9 Then TheArt = GetRandom(801, 950)
                        If x = 10 Then TheArt = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheGameplay = GetRandom(500, 700)
                        If x = 8 Then TheGameplay = GetRandom(701, 800)
                        If x = 9 Then TheGameplay = GetRandom(801, 950)
                        If x = 10 Then TheGameplay = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheStory = GetRandom(500, 700)
                        If x = 8 Then TheStory = GetRandom(701, 800)
                        If x = 9 Then TheStory = GetRandom(801, 950)
                        If x = 10 Then TheStory = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheReplay = GetRandom(500, 700)
                        If x = 8 Then TheReplay = GetRandom(701, 800)
                        If x = 9 Then TheReplay = GetRandom(801, 950)
                        If x = 10 Then TheReplay = GetRandom(951, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheAudio = GetRandom(500, 700)
                        If x = 8 Then TheAudio = GetRandom(701, 800)
                        If x = 9 Then TheAudio = GetRandom(801, 950)
                        If x = 10 Then TheAudio = GetRandom(951, 999)

                        TheBugs = GetRandom(0, 15)

                    Case Is = "Engine"
                        x = GetRandom(1, 10)
                        If x <= 7 Then TheDesign = GetRandom(500, 700)
                        If x = 8 Then TheDesign = GetRandom(701, 800)
                        If x = 9 Then TheDesign = GetRandom(801, 900)
                        If x = 10 Then TheDesign = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheArt = GetRandom(500, 700)
                        If x = 8 Then TheArt = GetRandom(701, 800)
                        If x = 9 Then TheArt = GetRandom(801, 900)
                        If x = 10 Then TheArt = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheGameplay = GetRandom(500, 700)
                        If x = 8 Then TheGameplay = GetRandom(701, 800)
                        If x = 9 Then TheGameplay = GetRandom(801, 900)
                        If x = 10 Then TheGameplay = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheStory = GetRandom(500, 700)
                        If x = 8 Then TheStory = GetRandom(701, 800)
                        If x = 9 Then TheStory = GetRandom(801, 900)
                        If x = 10 Then TheStory = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheReplay = GetRandom(500, 700)
                        If x = 8 Then TheReplay = GetRandom(701, 800)
                        If x = 9 Then TheReplay = GetRandom(801, 900)
                        If x = 10 Then TheReplay = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheAudio = GetRandom(500, 700)
                        If x = 8 Then TheAudio = GetRandom(701, 800)
                        If x = 9 Then TheAudio = GetRandom(801, 900)
                        If x = 10 Then TheAudio = GetRandom(901, 999)

                        TheBugs = GetRandom(0, 15)

                    Case Is = "America"
                        x = GetRandom(1, 10)
                        If x <= 7 Then TheDesign = GetRandom(500, 700)
                        If x = 8 Then TheDesign = GetRandom(701, 800)
                        If x = 9 Then TheDesign = GetRandom(801, 900)
                        If x = 10 Then TheDesign = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheArt = GetRandom(500, 700)
                        If x = 8 Then TheArt = GetRandom(701, 800)
                        If x = 9 Then TheArt = GetRandom(801, 900)
                        If x = 10 Then TheArt = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheGameplay = GetRandom(500, 700)
                        If x = 8 Then TheGameplay = GetRandom(701, 800)
                        If x = 9 Then TheGameplay = GetRandom(801, 900)
                        If x = 10 Then TheGameplay = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheStory = GetRandom(500, 700)
                        If x = 8 Then TheStory = GetRandom(701, 800)
                        If x = 9 Then TheStory = GetRandom(801, 900)
                        If x = 10 Then TheStory = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheReplay = GetRandom(500, 700)
                        If x = 8 Then TheReplay = GetRandom(701, 800)
                        If x = 9 Then TheReplay = GetRandom(801, 900)
                        If x = 10 Then TheReplay = GetRandom(901, 999)

                        x = GetRandom(1, 10)
                        If x <= 7 Then TheAudio = GetRandom(500, 700)
                        If x = 8 Then TheAudio = GetRandom(701, 800)
                        If x = 9 Then TheAudio = GetRandom(801, 900)
                        If x = 10 Then TheAudio = GetRandom(901, 999)

                        TheBugs = GetRandom(0, 15)

                    Case Is = "Chance"
                        x = GetRandom(1, 10)
                        If x < 5 Then TheDesign = GetRandom(100, 400)
                        If x >= 5 Then TheDesign = GetRandom(701, 999)

                        If x < 5 Then TheArt = GetRandom(100, 400)
                        If x >= 5 Then TheArt = GetRandom(701, 999)

                        If x < 5 Then TheGameplay = GetRandom(100, 400)
                        If x >= 5 Then TheGameplay = GetRandom(701, 999)

                        If x < 5 Then TheStory = GetRandom(100, 400)
                        If x >= 5 Then TheStory = GetRandom(701, 999)

                        If x < 5 Then TheReplay = GetRandom(100, 400)
                        If x >= 5 Then TheReplay = GetRandom(701, 999)

                        If x < 5 Then TheAudio = GetRandom(100, 400)
                        If x >= 5 Then TheAudio = GetRandom(701, 999)

                        If x < 5 Then TheBugs = GetRandom(10, 25)
                        If x >= 5 Then TheBugs = GetRandom(0, 10)

                    Case Is = "Average"
                        TheDesign = GetRandom(100, 999)
                        TheArt = GetRandom(100, 999)
                        TheGameplay = GetRandom(100, 999)
                        TheStory = GetRandom(100, 999)
                        TheReplay = GetRandom(100, 999)
                        TheAudio = GetRandom(100, 999)
                        TheBugs = GetRandom(0, 15)

                    Case Is = "Player"
                        GenGame = fRelease.FullGame.Text()
                        GoTo GameAnnounce
                End Select

                'set genre of the game

                'Action, RPG, Simulation, Strategy, Casual, Party, Puzzle, Sports
                If InStr(LCase(TheGame), "sim") <> 0 Then TheGenre = "Simulation" : GoTo Pass_Genre
                If InStr(LCase(TheGame), "tycoon") <> 0 Then TheGenre = "Simulation" : GoTo Pass_Genre

                If InStr(LCase(TheGame), "pinball") <> 0 Then TheGenre = "Casual" : GoTo Pass_Genre

                If InStr(LCase(TheGame), "ball") <> 0 Then TheGenre = "Sports" : GoTo Pass_Genre
                If InStr(TheGame, "boxing") <> 0 Then TheGenre = "Sports" : GoTo Pass_Genre
                If InStr(TheGame, "polo") <> 0 Then TheGenre = "Sports" : GoTo Pass_Genre
                If InStr(TheGame, "hockey") <> 0 Then TheGenre = "Sports" : GoTo Pass_Genre

                If InStr(TheGame, "dance") <> 0 Then TheGenre = "Party" : GoTo Pass_Genre
                If InStr(TheGame, "dancing") <> 0 Then TheGenre = "Party" : GoTo Pass_Genre

                x = GetRandom(1, 12)
                If x < 3 Then TheGenre = "Action"
                If x = 4 Or x = 5 Then TheGenre = "Adventure"
                If x = 6 Then TheGenre = "Simulation"
                If x = 7 Then TheGenre = "RPG"
                If x = 8 Then TheGenre = "Strategy"
                If x = 9 Then TheGenre = "Casual"
                If x = 10 Then TheGenre = "Party"
                If x >= 11 Then TheGenre = "Puzzle"

Pass_Genre:
                'get the rating
                TheRating = GetRating(TheDesign, TheArt, TheGameplay, TheReplay, TheStory, TheAudio, TheBugs, TheGenre)

                'the console
                If .NewConsoles.Items.Count - 1 > -1 Then
                    x = GetRandom(0, .NewConsoles.Items.Count - 1)
                    ConsoleX = x
                    TheConsole = GetConsole(.NewConsoles.Items(x), "Console")
                End If

                'engines?
                If .NewEngines.Items.Count - 1 > -1 And GetRandom(1, 3) = 1 Then
                    x = GetRandom(0, .NewEngines.Items.Count - 1)
                    'TheConsole = GetConsole(Form1.NewConsoles.Items(x), "Console")

                    'create a temporary list of engines for each console 
                    .lstSeq.Items.Clear()
                    x = .NewEngines.Items.Count - 1
                    Do
                        If GetEngine(.NewEngines.Items(x), "Console") = TheConsole Then .lstSeq.Items.Add(.NewEngines.Items(x))

                        x = x - 1
                    Loop Until x = -1

                    'transfer cash 
                    x = .lstSeq.Items.Count - 1
                    If x > -1 Then
                        x = GetRandom(0, x)

                        TheCo2 = GetEngine(.lstSeq.Items(x), "Company")
                        TheCash = GetEngine(.lstSeq.Items(x), "Price")

                        If .YourCo.Text = TheCo2 Then
                            .Cash.Text = Val(.Cash.Text + TheCash)
                            .NewsList.Items.Insert(0, "Another company just purchased a license for your engine. You earned " & FormatCurrency(TheCash, 0))
                            .Reputation.Text = Math.Round(.Reputation.Text + GetRandom(25, 50))
                        Else
                            'company selling the engine
                            y = .Companies.Items.Count - 1
                            'Do
                            'y = y - 1
                            'Loop Until GetCompany(Form1.Companies.Items(y), "Company") = TheCo2
                            y = .Companies.FindString(TheCo2)

                            If y <> -1 Then .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", Val(GetCompany(.Companies.Items(y), "Cash") + TheCash))

                            'company creating the game 
                            'y = Form1.Companies.Items.Count - 1
                            'Do
                            'y = y - 1
                            'Loop Until GetCompany(Form1.Companies.Items(y), "Company") = CoName
                            y = .Companies.FindString(CoName)

                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", Val(GetCompany(.Companies.Items(y), "Cash") - TheCash))
                        End If

                    End If
                End If

                'Ratings
                If TheRating = 10 Then TheSales = GetRandom(10000000, 30000000)
                If TheRating = 9 Then TheSales = GetRandom(700000, 6000000)
                If TheRating = 8 Then TheSales = GetRandom(500000, 5000000)
                If TheRating = 7 Then TheSales = GetRandom(120000, 1000000)
                If TheRating = 6 Then TheSales = GetRandom(70000, 500000)
                If TheRating = 5 Then TheSales = GetRandom(30000, 300000)
                If TheRating < 5 Then TheSales = GetRandom(1000, 80000)

                'If the genre is a trend, then boost sales a little
                If .Trend.Text = TheGenre Then
                    x = GetRandom(1, 5)
                    Select Case x
                        Case Is = 1
                            TheSales = Math.Round(TheSales * 1.3)
                        Case Is = 2
                            TheSales = Math.Round(TheSales * 1.2)
                        Case Is = 3
                            TheSales = Math.Round(TheSales * 1.2)
                        Case Is = 4
                            TheSales = Math.Round(TheSales * 1.1)
                        Case Is = 5
                            TheSales = Math.Round(TheSales * 1.1)
                    End Select
                End If

                'prevents duplicates
                For Each game In .NewGames.Items
                    If InStr(game, TheGame) <> 0 Then Exit Function
                Next

                'Company Name,Game Name,Genre,Design,Art,Gameplay,Story,Replay,Audio,Bugs,Rating,Console,ReleaseDate,Sales,PreviousSales
                FullGame = CoName & "," & TheGame & "," & TheGenre & "," & TheDesign & "," & TheArt & "," & TheGameplay & "," & TheStory & "," & TheReplay & "," & TheAudio & "," & TheBugs & "," & TheRating & "," & TheConsole & ",1," & TheSales & ",1"

GameAnnounce:
                'is player the publisher? //TEMP
                y = .Companies.FindString(CoName)
                If y > -1 Then
                    y = .OwnedStocks.FindString(CoName)
                    If y > -1 Then
                        Call ReleasePubGame(FullGame)
                        GenGame = Nothing
                        Exit Function
                    End If

                End If

                'announces the game!
                If My.Settings.AlertNewGame = True Then .NewsList.Items.Insert(0, CoName & " just released " & TheGame & " with an overall rating of " & TheRating)
                .NewGames.Items.Add(FullGame)

                'increases sales for the system
                If TheRating >= 8 Then
                    Dim ConsoleHelp As Long, ConsoleSales As Long, ConsoleNewSales As Long, HelpCompany As String, ConsolePrice As Integer
                    x = ConsoleX
                    y = GetRandom(20, 30)

                    'get console data
                    ConsoleSales = GetConsole(.NewConsoles.Items(x), "Sales")
                    ConsoleNewSales = GetConsole(.NewConsoles.Items(x), "PreviousSales")
                    HelpCompany = GetConsole(.NewConsoles.Items(x), "Company")
                    ConsolePrice = GetConsole(.NewConsoles.Items(x), "Price")

                    'increase sales
                    ConsoleHelp = Math.Round(TheSales * (y / 100))
                    .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", (ConsoleSales + ConsoleHelp))
                    .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", (ConsoleNewSales + ConsoleHelp))

                    'get that company money
                    y = .Companies.FindString(HelpCompany)
                    If y = -1 Then Exit Function
                    .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", (ConsolePrice * ConsoleHelp))

                    .NewsList.Items.Insert(0, "Sales of " & TheGame & " have increased sales of console " & GetConsole(.NewConsoles.Items(x), "Console") & " by " & FormatNumber(ConsoleHelp, 0))

                    'Trends!!!
                    y = GetRandom(1, My.Settings.TrendSetter)

                    If TheRating >= 9 And y = 1 Then
                        x = GetRandom(1, 5)
                        If x = 1 Then
                            .Trend.Text = TheGenre
                            .NewsList.Items.Insert(0, "Because of the recent success of " & TheGame & ", the new genre trend is " & TheGenre)
                        End If
                    End If

                    If TheRating >= 9 And y <> 1 Then
                        x = GetRandom(1, 14)
                        Dim TheInterest() As String = {"Drama", "Fairy Tale", "Fantasy", "Fiction", "Folklore", "History", "Horror", "Humor", "Legend", "Mystery", "Mythology", "Realistic Fiction", "Science Finction", "Tall Tale"}
                        .Trend.Text = TheInterest(x)
                        .NewsList.Items.Insert(0, "Because of the recent success of " & TheGame & ", the new interest trend is " & TheGenre)
                    End If
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Function
    Public Function GameName() As String
        Dim PartA As String, PartB As String, PartC As String, x As Integer, y As Long, z As Integer
        Dim TempA As String, TempB As String, TempC As String

        Try
            z = GetRandom(1, 3)

            y = GetRandom(1, FMain.G1.Items.Count - 1)
            TempA = FMain.G1.Items(y)
            x = InStr(TempA, "^")
            If x <> 0 Then
                PartA = Mid(TempA, 1, (x - 1))
            Else
                PartA = TempA
            End If

            y = GetRandom(1, FMain.G2.Items.Count - 1)
            TempB = FMain.G2.Items(y)
            x = InStr(TempB, "^")
            If x <> 0 Then
                PartB = Mid(TempB, 1, (x - 1))
            Else
                PartB = TempB
            End If

            If z <> 3 Then GameName = PartA & " " & PartB : Exit Function

Game3:
            y = GetRandom(1, FMain.G3.Items.Count - 1)
            TempC = FMain.G3.Items(y)

            x = InStr(TempA, "^")

            If x <> 0 Then
                If Mid(TempA, (x + 1), 3) = Mid(TempC, 1, 3) Then GoTo Game3
            End If

            x = InStr(TempC, "^")
            PartC = Mid(TempC, 1, (x - 1))

        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            GameName = PartA & " " & PartB & " " & PartC
        End Try
    End Function
    Public Sub DataLists()
        Try
            With FMain
                'companies

                Dim lines() As String = IO.File.ReadAllLines(Application.StartupPath & "\Data\CompanyNames1.lst")
                .CoName.Items.Clear()
                .CoName.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\CompanyNames2.lst")
                .CoName2.Items.Clear()
                .CoName2.Items.AddRange(lines)

                'consoles
                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\ConsoleNames1.lst")
                .Console1.Items.Clear()
                .Console1.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\ConsoleNames2.lst")
                .Console2.Items.Clear()
                .Console2.Items.AddRange(lines)

                'engines
                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\Engines.lst")
                .EngineNames.Items.Clear()
                .EngineNames.Items.AddRange(lines)

                'names
                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\Males.lst")
                .MFirstNames.Items.Clear()
                .MFirstNames.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\Females.lst")
                .FFirstNames.Items.Clear()
                .FFirstNames.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\LastNames.lst")
                .LastNames.Items.Clear()
                .LastNames.Items.AddRange(lines)

                'games
                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\GameNames1.lst")
                .G1.Items.Clear()
                .G1.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\GameNames2.lst")
                .G2.Items.Clear()
                .G2.Items.AddRange(lines)

                lines = IO.File.ReadAllLines(Application.StartupPath & "\Data\GameNames3.lst")
                .G3.Items.Clear()
                .G3.Items.AddRange(lines)
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub NewGame(Optional ByVal ResumeGame As Boolean = False)
        Dim x As Integer, y As Integer, TheCash As Long, SaveCash As Long, SaveCo As String, SaveY As Integer
        'Load data
        Call DataLists()

        Try
            With FMain

                .Stage.Text = "Idle"
                .Label19.Enabled = True
                .Label20.Enabled = True

                .EmployeeData.Items.Clear() 'employees
                .ListBox2.Items.Clear()

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                             Build Companies
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                ' Build companies based on year range, some etablished, some not
                .Companies.Items.Clear()
                .NewEngines.Items.Clear()

                If ResumeGame = False Then 'ignore this if resuming game 
                    x = GetRandom(7, 20)
                    .Companies.Items.Clear()

                    Do
                        .Companies.Items.Add(GenCo)
                        x = x - 1
                    Loop Until x = -1

                    x = .Companies.Items.Count - 1
                    Do
                        .Companies.Items(x) = GetCompany(.Companies.Items(x), "Cash", GetRandom(10000, 50000000))

                        x = x - 1
                    Loop Until x = -1
                End If

                'sidebar lists
                .NewConsoles.Items.Clear()
                .OldConsoles.ClearSelected()

                .NewEngines.Items.Clear()
                .OldEngines.Items.Clear()

                .NewsList.Items.Clear()

                .NewConsoles.Items.Clear()
                .OldConsoles.Items.Clear()

                .NewGames.Items.Clear()
                .OldGames.Items.Clear()

                'others
                .Reputation.Text = 0
                .Trend.Text = "None"

                'main settings
                .Timer1.Interval = My.Settings.Timer
                .Button1.BackColor = Color.LightSteelBlue
                .Button2.BackColor = Color.White
                .Button3.BackColor = Color.LightSteelBlue
                .TheYear.Text = 1980
                .TheMonth.Text = "January"
                .TheWeek.Text = 1
                .Hrs.Text = 8

                If Val(.TheYear.Text) > 1979 Then
                    .Cash.Text = 10000
                    .Cash2.Text = 10000
                    .CashMax.Text = 10000
                End If

                If Val(.TheYear.Text) > 1989 Then
                    .Cash.Text = 20000
                    .Cash2.Text = 20000
                    .CashMax.Text = 20000
                End If

                If Val(.TheYear.Text) > 1999 Then
                    .Cash.Text = 45000
                    .Cash2.Text = 45000
                    .CashMax.Text = 45000
                End If

                If Val(.TheYear.Text) > 2009 Then
                    .Cash.Text = 60000
                    .Cash2.Text = 60000
                    .CashMax.Text = 60000
                End If

                .Income.Text = 0
                '.NewsList.Width = 603
                .RadialBar1.Value = 0
                .RadialBar2.Value = 0
                .Panel2.Visible = False
                .Panel3.Visible = False
                .Panel4.Visible = False

                'focus
                .GameFocus.Text = "None"
                .ArtToolStripMenuItem.Checked = False
                .ArtToolStripMenuItem1.Checked = False
                .GameplayToolStripMenuItem.Checked = False
                .StoryToolStripMenuItem.Checked = False
                .ReplayabilityToolStripMenuItem.Checked = False
                .NoneToolStripMenuItem.Checked = True

                'management panels
                .Overtime.Text = 0
                .DevTeam.Text = 1
                .RandomCounter.Text = 0

                .Develop.Checked = False
                .Contract.Checked = False
                .Engine.Checked = False
                .Console.Checked = False
                .GameSize.Text = 1

                'Game settings
                .EngTech.Text = 0
                .EngUse.Text = 0
                .GameName.Text = ""
                .GameGenre.Text = ""
                .SubGenre.Text = ""
                .GameInterest.Text = ""
                .GameEngine.Text = ""
                .GameConsole.Text = ""

                'publisher
                .ThePublisher.Text = "Self"
                .SetPublisher.Text = ""
                .SetPublisher.Checked = False
                .OwedCut.Text = 0
                .AllWeeks.Text = -1
                .Marketing.Text = 0

                'console
                .CoMarketing.Text = 0

                'expos
                .ExpoList.Items.Clear()

                'banking
                .Loans.Items.Clear()
                .Investments.Items.Clear()
                .Stocks.Items.Clear()
                .OwnedStocks.Items.Clear()

                'empties all the seats
                Call SetSeating(True)

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                                                                    Consoles
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If ResumeGame = True Then Exit Sub 'No longer necessary to generate information

First_Console:
                .NewConsoles.Items.Clear()
                'prepare first console

                y = .Companies.Items.Count - 1
                SaveCash = 0
                TheCash = 0
                Do
                    TheCash = Val(GetCompany(.Companies.Items(y), "Cash"))

                    If TheCash > SaveCash Then
                        SaveCash = TheCash
                        SaveY = y
                    End If

                    y = y - 1
                Loop Until y = -1

                'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
                If Val(.TheYear.Text) > 1980 Then
                    .NewConsoles.Items.Add("MacroSun,PC,100,1,1,1,1,1,1")
                Else 'accuracy for PC based off http://techland.time.com/2013/05/07/a-brief-history-of-windows-sales-figures-1985-present/
                    Dim TheSales As Long
                    If Val(FMain.TheYear.Text) > 1990 And Val(FMain.TheYear.Text) <= 1995 Then TheSales = GetRandom(3000, 10000)
                    If Val(FMain.TheYear.Text) > 1995 And Val(FMain.TheYear.Text) <= 2000 Then TheSales = GetRandom(10000, 4000000)
                    If Val(FMain.TheYear.Text) > 2000 And Val(FMain.TheYear.Text) <= 2005 Then TheSales = GetRandom(20000, 5000000)
                    If Val(FMain.TheYear.Text) > 2005 And Val(FMain.TheYear.Text) <= 2010 Then TheSales = GetRandom(30000, 6000000)
                    If Val(FMain.TheYear.Text) > 2010 And Val(FMain.TheYear.Text) <= 2020 Then TheSales = GetRandom(40000, 7000000)
                    If Val(FMain.TheYear.Text) > 2030 And Val(FMain.TheYear.Text) <= 2040 Then TheSales = GetRandom(50000, 8000000)
                    If Val(FMain.TheYear.Text) > 2040 Then TheSales = GetRandom(500000, 10000000)

                    If TheSales < 100000 Then TheSales = TheSales * GetRandom(50, 200)
                    If TheSales >= 100000 And TheSales < 1000000 Then TheSales = TheSales + GetRandom(10, 50)

                    .NewConsoles.Items.Add("MacroSun,PC,100,1,1,1,1," & TheSales & ",1")
                End If

                TheCash = SaveCash
                y = SaveY

                'get the cash
                SaveCash = GetRandom(1000000, 3000000)

                'deplete cash
                FMain.Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", Val(TheCash - SaveCash)) 'goodbye money

                If Val(.TheYear.Text) > 1980 Then 'determine year for accuracy
                    FMain.NewConsoles.Items.Add(GenConsole(GetCompany(.Companies.Items(y), "Company"), True)) 'hello console
                Else
                    FMain.NewConsoles.Items.Add(GenConsole(GetCompany(.Companies.Items(y), "Company"))) 'hello console
                End If

                Application.DoEvents()
                FMain.NewsList.Items.Insert(0, GetCompany(.Companies.Items(y), "Company") & " has released a new console: " & GetConsole(.NewConsoles.Items(.NewConsoles.Items.Count - 1), "Console"))

                If Val(.TheYear.Text) < 1981 Then Exit Sub 'no more new console

                'build new consoles!

                y = .Companies.Items.Count - 1
                Do
                    TheCash = Val(GetCompany(.Companies.Items(y), "Cash"))
                    SaveCo = GetCompany(.Companies.Items(y), "Company")

                    If .NewConsoles.FindString(SaveCo) <> ListBox.NoMatches Then GoTo Nexty 'prevent duplicates

                    If TheCash > 25000000 Then
                        SaveCash = GetRandom(3000000, 10000000)
                        .NewConsoles.Items.Add(GenConsole(SaveCo, True)) 'hello console
                        Application.DoEvents()
                        .NewConsoles.Items(.NewConsoles.Items.Count - 1) = GetConsole(.NewConsoles.Items(.NewConsoles.Items.Count - 1), "Release", GetRandom(1, 3))
                        FMain.NewsList.Items.Insert(0, SaveCo & " has released a new console: " & GetConsole(.NewConsoles.Items(.NewConsoles.Items.Count - 1), "Console"))

                        'engines
                        x = GetRandom(0, 2)
                        If x = 0 Then GoTo Nexty

                        Do
                            .NewEngines.Items.Add(GenEngine(GetCompany(.Companies.Items(GetRandom(0, .Companies.Items.Count - 1)), "Company")))
                            x = x - 1
                        Loop Until x = -1
                    End If

Nexty:
                    y = y - 1
                Loop Until y = -1 Or .NewConsoles.Items.Count < GetRandom(3, 5)

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                                               Games!
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim CoType As String

                y = .Companies.Items.Count - 1
                Do
                    SaveCo = GetCompany(.Companies.Items(y), "Company")
                    CoType = GetCompany(.Companies.Items(y), "Strategy")

                    x = GetRandom(1, 4)
                    If x = 1 Then Call GenGame(SaveCo, CoType)

                    'Engines!
                    x = GetRandom(1, 10)
                    If x = 1 Then Call GenEngine(SaveCo)

                    y = y - 1
                Loop Until y = -1

                .Timer1.Enabled = True
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub YearEnd()
        Call GenAwards()
    End Sub
    Public Sub MonthEnd(Optional Sim As Boolean = False)
        Dim x As Integer, y As Long, z As Long
        'Dim StockCash As Long, StockMarket As Double

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                           Expos!
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            With FMain
                x = .ExpoList.Items.Count - 1

                Call GenExpo(.TheMonth.Text)

                If .ExpoList.Items.Count = 0 Then GoTo MoveExpenses
                x = .ExpoList.Items.Count - 1
                Do
                    If InStr(.ExpoList.Items(x), .TheMonth.Text) <> 0 Then
                        'Simulate expo event if there are none
                        If Sim = True Then
                            .ExpoList.Items(x) = SimExpo(.ExpoList.Items(x))
                        Else
                            .ExpoList.Items(x) = GetExpo(.ExpoList.Items(x))
                        End If

                        GoTo MoveExpenses
                    End If

                    x = x - 1
                Loop Until x = -1
            End With


            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                           Expenses
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
MoveExpenses:
            If Sim = False Then FMain.Cash.Text = Val(FMain.Cash.Text - Expenses())

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                           AI Expenses / income
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim isQuarter As Boolean, MinExp As Long, MaxExp As Long, PrevIncome As Long, PrevExpenses As Long
            Dim TheExpense As Long, CashOnHand As Long

            isQuarter = False

            'this section readjusts expenses based on previous month sales 
            With FMain
                If .TheMonth.Text = "March" Then isQuarter = True
                If .TheMonth.Text = "June" Then isQuarter = True
                If .TheMonth.Text = "September" Then isQuarter = True
                If .TheMonth.Text = "December" Then isQuarter = True

                If isQuarter = True Then
                    x = .Companies.Items.Count - 1

                    Do
                        PrevIncome = GetCompany(.Companies.Items(x), "Income")

                        PrevIncome = Math.Round(PrevIncome / 4, 0)

                        'some companies will have a very successful game, but no need to hire more than 30 people
                        If PrevIncome > (GetAvgSalary() * 30) Then
                            MinExp = (GetAvgSalary() * 25)
                            MaxExp = (GetAvgSalary() * 40)
                        Else
                            MinExp = PrevIncome * My.Settings.MinIncome_AI
                            MaxExp = PrevIncome * My.Settings.MaxIncome_AI
                        End If


                        'unless it equals zero, then use previous expenses 
                        If PrevIncome = 0 And GetCompany(.Companies.Items(x), "Cash") < 100000 Then
                            PrevExpenses = GetCompany(.Companies.Items(x), "Expenses")
                            MinExp = Math.Round(PrevExpenses * My.Settings.MinIncome_AI)
                            MaxExp = Math.Round(PrevExpenses * My.Settings.MaxIncome_AI)
                        End If

                        If PrevIncome = 0 And GetCompany(.Companies.Items(x), "Cash") > 100000 Then 'richer companies are fine
                            MinExp = PrevIncome * My.Settings.MinIncome_AI
                            MaxExp = PrevIncome * My.Settings.MaxIncome_AI
                        End If

                        'if it's a smaller company 
                        If MinExp < 500 Or MinExp < GetAvgSalary() Then
                            If Val(FMain.TheYear.Text) <= 1990 Then MinExp = My.Settings.Exp1980
                            If Val(FMain.TheYear.Text) > 1990 And Val(FMain.TheYear.Text) <= 2000 Then MinExp = My.Settings.Exp1990
                            If Val(FMain.TheYear.Text) > 2000 And Val(FMain.TheYear.Text) <= 2010 Then MinExp = My.Settings.Exp2000
                            If Val(FMain.TheYear.Text) > 2010 And Val(FMain.TheYear.Text) <= 2020 Then MinExp = My.Settings.Exp2010
                            If Val(FMain.TheYear.Text) > 2020 And Val(FMain.TheYear.Text) <= 2030 Then MinExp = My.Settings.Exp2020
                            If Val(FMain.TheYear.Text) > 2030 And Val(FMain.TheYear.Text) <= 2040 Then MinExp = My.Settings.Exp2030
                            If Val(FMain.TheYear.Text) > 2040 Then MinExp = My.Settings.Exp2040

                            MinExp = MinExp + GetAvgSalary()
                            MaxExp = MinExp + (GetAvgSalary() * 5)

                        End If

                        .Companies.Items(x) = GetCompany(.Companies.Items(x), "Expenses", GetRandom(MinExp, MaxExp)) 'set new expenses 
                        .Companies.Items(x) = GetCompany(.Companies.Items(x), "Income", "0") 'reset income for quarter
                        x = x - 1
                    Loop Until x = -1

                End If

                'subtract expenses from income 
                x = .Companies.Items.Count - 1
                Do
                    CashOnHand = GetCompany(.Companies.Items(x), "Cash")
                    TheExpense = GetCompany(.Companies.Items(x), "Expenses")

                    CashOnHand = CashOnHand - TheExpense
                    .Companies.Items(x) = GetCompany(.Companies.Items(x), "Cash", CashOnHand)

                    'bankruptcy 
                    CashOnHand = GetCompany(.Companies.Items(x), "Cash")
                    Dim CurCo As String = GetCompany(.Companies.Items(x), "Company")
                    If CashOnHand < -5000 And .NewGames.FindString(CurCo) = -1 Then '0 cash and no game is out 
                        If My.Settings.AlertBankruptcy = True Then .NewsList.Items.Insert(0, CurCo & " has declared bankruptcy.")

                        'Who controls assets?
                        Dim ThePub As String = GetCompany(.Companies.Items(x), "Publisher")
                        If ThePub <> CurCo Then 'Not same as publisher
                            Dim TheList As ListBox = New ListBox

                            'remove old games under previous publisher
                            z = .OldGames.Items.Count - 1
                            If z >= 0 Then
                                Do
                                    If GetGame(.OldGames.Items(z), "Company") = CurCo Then
                                        TheList.Items.Add(GetGame(.OldGames.Items(z), "Company", ThePub))
                                        .OldGames.Items.RemoveAt(z)
                                    End If

                                    z = z - 1
                                Loop Until z = -1

                                'Add with correct data
                                For Each itm In TheList.Items
                                    .OldGames.Items.Add(itm)
                                Next
                            End If

                            .NewsList.Items.Insert(0, ThePub & " has taken over the assets of " & CurCo & ".")
                        End If

                        .Companies.Items.RemoveAt(x)
                    End If

                    'Set as own entity if they have enough funds
                    y = GetRandom(500000, 10000000)
                    z = GetRandom(1, My.Settings.SelfPublishFreq)
                    If CashOnHand > y And GetCompany(.Companies.Items(x), "Publisher") <> "0" And x = 1 Then
                        'notify player if they leave you
                        If GetCompany(.Companies.Items(x), "Publisher") = .YourCo.Text Then
                            .NewsList.Items.Insert(0, GetCompany(.Companies.Items(x), "Company") & " has left your publishing house.")
                        End If

                        'update publisher information
                        Dim theco As String = GetCompany(.Companies.Items(x), "Company")
                        .Companies.Items(x) = GetCompany(.Companies.Items(x), "Publisher", "0")
                    End If

                    x = x - 1
                Loop Until x = -1
            End With

MonthEnd2:

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                           Engine degration
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim TechLvl As Long, UseLvl As Long

            With FMain
                x = .NewEngines.Items.Count - 1
                If x = -1 Then GoTo ConsoleDegrade

                Do
                    'what to subtract
                    y = GetRandom(5, 10)
                    TechLvl = GetEngine(.NewEngines.Items(x), "Tech")
                    UseLvl = GetEngine(.NewEngines.Items(x), "Usability")

                    'actual subtraction
                    TechLvl = TechLvl - y
                    UseLvl = UseLvl - y

                    'can't have a negative... they're still useful somewhat
                    If TechLvl < 10 Then TechLvl = 10
                    If UseLvl < 10 Then UseLvl = 10

                    'set it
                    Call GetEngine(.NewEngines.Items(x), "Tech", TechLvl)
                    Call GetEngine(.NewEngines.Items(x), "Usability", UseLvl)

                    'retire it!
                    If TechLvl = 10 And UseLvl = 10 Then
                        .OldEngines.Items.Add(.NewEngines.Items(x))
                        If My.Settings.AlertRetiredEngines = True Then .NewsList.Items.Insert(0, "The " & GetEngine(.NewEngines.Items(x), "Name") & " engine for the " & GetEngine(.NewEngines.Items(x), "Console") & " was just retired.")
                        .NewEngines.Items.RemoveAt(x)
                    End If

                    x = x - 1
                Loop Until x = -1

            End With

            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                           Console degration
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
ConsoleDegrade:
            Dim TheCost As Long
            With FMain
                x = GetRandom(1, 4)
                If x = 1 Then
                    x = .NewConsoles.Items.Count - 1
                    If x = -1 Then GoTo Banking

                    Do
                        'what to subtract
                        y = GetRandom(5, 10)
                        TechLvl = GetConsole(.NewConsoles.Items(x), "Tech")

                        'calculate cost based on year
                        If .TheYear.Text < 1990 Then
                            TheCost = TechLvl * 2
                        End If

                        If .TheYear.Text >= 1990 And FMain.TheYear.Text <= 2000 Then
                            TheCost = TechLvl * 3
                        End If

                        If .TheYear.Text >= 2000 And FMain.TheYear.Text <= 2010 Then
                            TheCost = TechLvl * 4
                        End If

                        If .TheYear.Text >= 2010 And FMain.TheYear.Text <= 2020 Then
                            TheCost = TechLvl * 5
                        End If

                        If .TheYear.Text >= 2010 And FMain.TheYear.Text <= 2030 Then
                            TheCost = TechLvl * 6
                        End If

                        If .TheYear.Text >= 2010 And FMain.TheYear.Text <= 2040 Then
                            TheCost = TechLvl * 7
                        End If

                        If .TheYear.Text >= 2040 Then
                            TheCost = TechLvl * 8
                        End If

                        'can't have a negative... they're still useful somewhat
                        If TechLvl < 10 Then TechLvl = 10
                        TheCost = Math.Round(TheCost)

                        'set it
                        Call GetConsole(.NewConsoles.Items(x), "Tech", TechLvl)
                        Call GetConsole(.NewConsoles.Items(x), "Cost", TheCost)

                        x = x - 1
                    Loop Until x = -1
                End If
            End With

            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                       Banking
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Banking:
            Dim TheInt As Double, TheDollar As Long, tmpDollar As Long
            With FMain
                x = .Loans.Items.Count - 1

                If x = -1 Then GoTo Investments

                Do
                    'get the data
                    TheInt = GetLoans(.Loans.Items(x), "Rate")
                    TheDollar = GetLoans(.Loans.Items(x), "Dollar")


                    TheDollar = Math.Round(TheDollar + (TheDollar * ((TheInt / 100) / 12))) 'define interest
                    tmpDollar = Math.Round(TheDollar / 36) '3 years pay off

                    If tmpDollar < 1 Then tmpDollar = 0

                    'subtract from cash amount
                    .Cash.Text = Math.Round(Val(.Cash.Text) - tmpDollar)

                    'revalue 
                    TheDollar = Math.Round(TheDollar - tmpDollar)

                    'if 0 can we remove?
                    If tmpDollar = 0 Then
                        .Loans.Items.RemoveAt(x)
                    End If

                    'set new dollar amount
                    If tmpDollar > 0 Then
                        .Loans.Items(x) = GetLoans(.Loans.Items(x), "Dollar", TheDollar)
                    End If

                    x = x - 1
                Loop Until x < 0

Investments:
                x = .Investments.Items.Count - 1

                If x = -1 Then GoTo End_Investments

                Do
                    'get the data
                    TheInt = GetInvestments(.Investments.Items(x), "Rate")
                    TheDollar = GetInvestments(.Investments.Items(x), "Dollar")


                    TheDollar = Math.Round(TheDollar + (TheDollar * ((TheInt / 100) / 12))) 'define interest

                    .Investments.Items(x) = GetInvestments(.Investments.Items(x), "Dollar", TheDollar)

                    x = x - 1
                Loop Until x < 0

End_Investments:

                'x = .Companies.Items.Count - 1
                'If x = -1 Then Exit Sub

                ''Build new stock profiles
                'Do
                '    'does the company have more than 10 mil?
                '    If GetCompany(.Companies.Items(x), "Cash") > 1000000 Then
                '        'do they already have stocks?
                '        y = .Stocks.FindString(GetCompany(.Companies.Items(x), "Name"))
                '        If y = -1 Then
                '            'CoName,StockAmount,StockCost,StockMarket,Owned
                '            .Stocks.Items.Add(GetCompany(.Companies.Items(x), "Company") & "," & Math.Round(GetCompany(.Companies.Items(x), "Cash") * 1.2) & ",0," & Math.Round(GetCompany(.Companies.Items(x), "Cash") / 1000000) & ",0")
                '        End If
                '    End If

                '    x = x - 1
                'Loop Until x = -1

Start_Stocks:
                If isQuarter = True Then
                    Call DefineStocks()
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Function Expenses(Optional ByRef forAI As Boolean = False) As Long
        Dim x As Integer
        Try
            Expenses = 1

            With FMain

                'salaries
                x = .EmployeeData.Items.Count - 1

                If x = -1 Then Return Expenses

                Do
                    Expenses = Expenses + Val(GetEmployee(.EmployeeData.Items(x), "Salary"))
                    x = x - 1
                Loop Until x = -1

                'product of salaries and weeks in a month
                Select Case .TheMonth.Text
                    Case Is = "January"
                        Expenses = Expenses * 5
                    Case Is = "February"
                        Expenses = Expenses * 3
                    Case Is = "March"
                        Expenses = Expenses * 5
                    Case Is = "April"
                        Expenses = Expenses * 4
                    Case Is = "May"
                        Expenses = Expenses * 5
                    Case Is = "June"
                        Expenses = Expenses * 4
                    Case Is = "July"
                        Expenses = Expenses * 5
                    Case Is = "August"
                        Expenses = Expenses * 4
                    Case Is = "September"
                        Expenses = Expenses * 4
                    Case Is = "October"
                        Expenses = Expenses * 5
                    Case Is = "November"
                        Expenses = Expenses * 4
                    Case Is = "December"
                        Expenses = Expenses * 5
                End Select

                'expenses for loans
                x = .Loans.Items.Count - 1
                If x = -1 Then Exit Function '//temp until AI expenses are filled

                Dim TheInt As Double, TheDollar As String
                Do
                    'get the data
                    TheInt = GetLoans(.Loans.Items(x), "Rate")
                    TheDollar = GetLoans(.Loans.Items(x), "Dollar")

                    TheDollar = Math.Round(TheDollar / 36) '3 years pay off
                    Expenses = Expenses + TheDollar

                    x = x - 1
                Loop Until x < 0

                'rent
                If Val(.TheYear.Text) <= 1990 Then Expenses = Expenses + My.Settings.Exp1980
                If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then Expenses = Expenses + My.Settings.Exp1990
                If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then Expenses = Expenses + My.Settings.Exp2000
                If Val(.TheYear.Text) > 2010 And Val(.TheYear.Text) <= 2020 Then Expenses = Expenses + My.Settings.Exp2010
                If Val(.TheYear.Text) > 2020 And Val(.TheYear.Text) <= 2030 Then Expenses = Expenses + My.Settings.Exp2020
                If Val(.TheYear.Text) > 2030 And Val(.TheYear.Text) <= 2040 Then Expenses = Expenses + My.Settings.Exp2030
                If Val(.TheYear.Text) > 2040 Then Expenses = Expenses + My.Settings.Exp2040

                If forAI = True Then 'do expenses for AI

                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Function
    Public Sub LoadForm2(Genre As String)
        Dim x As Integer, temp As String

        Try
            With fNewGame
                'genres
                .txt_Genre.Text = Genre
                .cmbo_Subgenre.Items.Clear()

                Select Case Genre
                    Case Is = "Adventure"
                        .txt_Genre.Text = "Adventure"
                        .cmbo_Subgenre.Items.Clear()
                        .cmbo_Subgenre.Items.Add("3D")
                        .cmbo_Subgenre.Items.Add("Text")
                        .cmbo_Subgenre.Items.Add("Graphic")
                        .cmbo_Subgenre.Items.Add("Visual Novel")
                    Case Is = "Action"
                        .cmbo_Subgenre.Items.Add("Beat'Em Up")
                        .cmbo_Subgenre.Items.Add("Fighting")
                        .cmbo_Subgenre.Items.Add("Maze")
                        .cmbo_Subgenre.Items.Add("Platform")
                        .cmbo_Subgenre.Items.Add("Rhythm")
                        .cmbo_Subgenre.Items.Add("Shooter")
                    Case Is = "RPG"
                        .cmbo_Subgenre.Items.Add("Action")
                        .cmbo_Subgenre.Items.Add("Japanese")
                        .cmbo_Subgenre.Items.Add("Rogue")
                        .cmbo_Subgenre.Items.Add("Tactical")
                        .cmbo_Subgenre.Items.Add("Turn-Based")
                        .cmbo_Subgenre.Items.Add("Western")
                    Case Is = "Simulation"
                        .cmbo_Subgenre.Items.Add("Business")
                        .cmbo_Subgenre.Items.Add("Dating")
                        .cmbo_Subgenre.Items.Add("City-Building")
                        .cmbo_Subgenre.Items.Add("Flight")
                        .cmbo_Subgenre.Items.Add("Government")
                        .cmbo_Subgenre.Items.Add("Life")
                        .cmbo_Subgenre.Items.Add("Sports")
                        .cmbo_Subgenre.Items.Add("Transportation")
                        .cmbo_Subgenre.Items.Add("War")
                    Case Is = "Strategy"
                        .cmbo_Subgenre.Items.Add("4X")
                        .cmbo_Subgenre.Items.Add("Artillery")
                        .cmbo_Subgenre.Items.Add("Real-Time")
                        .cmbo_Subgenre.Items.Add("Turn-Based")
                        .cmbo_Subgenre.Items.Add("War")
                    Case Is = "Casual"
                        .cmbo_Subgenre.Items.Add("Arcade")
                        .cmbo_Subgenre.Items.Add("Adventure")
                        .cmbo_Subgenre.Items.Add("Board Game")
                        .cmbo_Subgenre.Items.Add("Card")
                        .cmbo_Subgenre.Items.Add("Hidden Object")
                        .cmbo_Subgenre.Items.Add("Puzzle")
                        .cmbo_Subgenre.Items.Add("Strategy")
                        .cmbo_Subgenre.Items.Add("Trivia")
                        .cmbo_Subgenre.Items.Add("Word")
                    Case Is = "Party"
                        .cmbo_Subgenre.Items.Add("Team-Based")
                    Case Is = "Puzzle"
                        .cmbo_Subgenre.Items.Add("Action")
                        .cmbo_Subgenre.Items.Add("Hidden Object")
                        .cmbo_Subgenre.Items.Add("Physics")
                        .cmbo_Subgenre.Items.Add("Tile-matching")
                        .cmbo_Subgenre.Items.Add("Traditional")
                    Case Is = "Sports"
                        .cmbo_Subgenre.Items.Add("American Football")
                        .cmbo_Subgenre.Items.Add("Baseball")
                        .cmbo_Subgenre.Items.Add("Cricket")
                        .cmbo_Subgenre.Items.Add("Football")
                        .cmbo_Subgenre.Items.Add("Hockey")
                        .cmbo_Subgenre.Items.Add("Lacrosse")
                        .cmbo_Subgenre.Items.Add("Olympics")
                        .cmbo_Subgenre.Items.Add("Racing")
                        .cmbo_Subgenre.Items.Add("Rugby")
                        .cmbo_Subgenre.Items.Add("Wrestling")

                End Select

                'get consoles first
                .cmbo_Platform.Items.Clear()
                x = FMain.NewConsoles.Items.Count - 1

                temp = FMain.NewConsoles.Items(x)

                Do
                    .cmbo_Platform.Items.Add(GetConsole(FMain.NewConsoles.Items(x), "Console"))
                    x = x - 1
                Loop Until x = -1

                .Label11.Text = "Home built"
                .ProgressBar1.Value = 1
                .ProgressBar2.Value = 1
                .Label10.Text = 0

                .SlcGroupBox1.Visible = True
                .GroupBox1.Visible = True
                .GroupBox2.Visible = False
                .GroupBox3.Visible = False
            End With

            fNewGame.cmbo_Engine.Items.Clear()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            Call DrawCharts()
        End Try
    End Sub
    Public Sub Weekly(Optional Sim As Boolean = False)
        Dim x As Integer, y As Integer, TheCash As Long

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Development
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            With FMain
                If .RandomCounter.Text > 0 Then .RandomCounter.Text = Math.Round(.RandomCounter.Text - 1) 'lower random counter to prevent overload

                If .AllWeeks.Text = 0 And .Develop.Checked = True Then
                    .AllWeeks.Text = -1
                    .Develop.Checked = False
                    ReleaseGame()

                    'not prototype stage? Then just add a week
                    'Exit Sub
                End If

                If .AllWeeks.Text < 0 And .Contract.Checked = True Then 'for contracts
                    '.AllWeeks.Text = -1
                    '.Contract.Checked = False
                    'Call EndContract(False)

                    'penalty
                    .Reputation.Text = Val(.Reputation.Text) + (Val(.AllWeeks.Text) * My.Settings.ContractPenalty)
                End If

                If .AllWeeks.Text = 0 And .Engine.Checked = True Then 'for engine
                    .AllWeeks.Text = -1
                    .Contract.Checked = False
                    Call ReleaseEngine()

                End If

                If .AllWeeks.Text = 0 And .Console.Checked = True Then 'for console
                    .AllWeeks.Text = -1
                    .Console.Checked = False
                    Call ReleaseConsole()

                End If

                'development
                If .Develop.Checked = True Then
                    If .Stage.Text <> "Prototype" And .Stage.Text <> "Pre-production" And .RadialBar2.Value <> .RadialBar2.Maximum Then .RadialBar2.Value = .RadialBar2.Value + 1
                End If

                'engine
                If .Engine.Checked = True Then
                    If .RadialBar2.Value < .RadialBar2.Maximum Then .RadialBar2.Value = .RadialBar2.Value + 1
                End If

                'console
                If .Console.Checked = True Then
                    If .RadialBar2.Value < .RadialBar2.Maximum Then .RadialBar2.Value = .RadialBar2.Value + 1
                End If

                'weeks only advance if something is worked on
                If .Develop.Checked = True Or .Engine.Checked = True Or .Console.Checked = True Then
                    If .AllWeeks.Text > 0 Then 'move forward 
                        .AllWeeks.Text = Val(.AllWeeks.Text) - 1
                        If .RadialBar1.Value < .RadialBar1.Maximum Then .RadialBar1.Value = .RadialBar1.Value + 1
                    End If
                End If

                'contracts separated due to specialty
                If .Contract.Checked = True Then
                    .AllWeeks.Text = Val(.AllWeeks.Text) - 1
                    If .RadialBar1.Value < .RadialBar1.Maximum Then .RadialBar1.Value = .RadialBar1.Value + 1
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Marketing
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            With FMain
                'marketing long and the game will lose interest 
                Dim themarket As Long = .Marketing.Text
                If themarket > 5 Then
                    .Marketing.Text = Math.Round(.Marketing.Text - GetRandom(2, 5))
                End If


                'minimum threshold 
                If .ThePublisher.Text <> "Self" And Val(.Marketing.Text) < My.Settings.PublisherAdvantage Then .Marketing.Text = My.Settings.PublisherAdvantage

                If .ThePublisher.Text = "Self" And Val(.Marketing.Text) < 25 Then .Marketing.Text = 25
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       New Games
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Call Weekly_NewGames() moved to new sub for 6am

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       New companies
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Try
            x = GetRandom(1, 100)
            If x > 75 Then
                FMain.Companies.Items.Add(GenCo)
                Application.DoEvents()
                x = FMain.Companies.Items.Count - 1
                If My.Settings.AlertCompanyFounded = True Then FMain.NewsList.Items.Insert(0, GetCompany(FMain.Companies.Items(x), "Company") & " was founded.")
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       New Consoles
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim SaveCo As String, SaveCash As Long

        Try
            With FMain
                If .TheYear.Text < 1995 Then
                    If .NewConsoles.Items.Count = 5 Then GoTo Game_Sales
                    If .NewConsoles.Items.Count = 1 Then y = GetRandom(90, 150)
                    If .NewConsoles.Items.Count = 2 Then y = GetRandom(60, 150)
                    If .NewConsoles.Items.Count = 3 Then y = GetRandom(20, 150)
                    If .NewConsoles.Items.Count = 4 Then y = GetRandom(1, 150)
                Else
                    If .NewConsoles.Items.Count = 6 Then GoTo Game_Sales
                    If .NewConsoles.Items.Count = 1 Then y = GetRandom(90, 150)
                    If .NewConsoles.Items.Count = 2 Then y = GetRandom(70, 150)
                    If .NewConsoles.Items.Count = 3 Then y = GetRandom(50, 150)
                    If .NewConsoles.Items.Count = 4 Then y = GetRandom(10, 150)
                End If

                If .NewConsoles.Items.Count = 4 And .Console.Checked = True Then GoTo Game_Sales 'prevents additional console because of player

                If y < 145 Then GoTo Game_Sales

                x = .Companies.Items.Count - 1
                If x = -1 Then GoTo Game_Sales
                y = .Companies.Items.Count - 1

                Do
                    TheCash = Val(GetCompany(.Companies.Items(y), "Cash"))
                    SaveCo = GetCompany(.Companies.Items(y), "Company")

                    If .NewConsoles.FindString(SaveCo) <> ListBox.NoMatches Then GoTo Nexty 'prevent duplicates

                    If TheCash > 25000000 Then
                        SaveCash = GetRandom(3000000, 10000000)
                        GoTo Sell_Console
                    End If

                    If TheCash > 10000000 And GetRandom(1, 3) = 1 Then 'less likely
                        SaveCash = GetRandom(3000000, 10000000)
                        GoTo Sell_Console
                    End If
Nexty:
                    y = y - 1
                Loop Until y = -1

                If y = -1 Then GoTo Game_Sales
Sell_Console:
                .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", Val(TheCash - SaveCash)) 'goodbye money
                .NewConsoles.Items.Add(GenConsole(SaveCo)) 'hello console
                Application.DoEvents()
                .NewsList.Items.Insert(0, SaveCo & " has released a new console: " & GetConsole(.NewConsoles.Items(.NewConsoles.Items.Count - 1), "Console"))

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Game sales
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Game_Sales:
        'Call Weekly_GameSales() 'this has been moved to 6am to prevent too much code running at once

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Console  Sales
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Call Weekly_Consoles() 'moved to 2am to prevent too much code running at once 

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Expenses
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'moved to monthly

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Challenges!
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            With FMain
                If Sim = True Then Exit Sub 'Avoid if they're simulating

                Dim TotalCash As Long = Val(.Cash.Text)
                Dim Weeks As Long = Math.Round(FMain.Cash.Text / Expenses())

                For Each itm In FMain.Investments.Items
                    TotalCash = TotalCash + GetInvestments(itm, "Dollar")
                Next

                If Weeks >= 52 And Weeks < 78 Then
                    y = GetRandom(1, My.Settings.ChallengeFreq1)
                End If
                If Weeks >= 78 And Weeks < 104 Then
                    y = GetRandom(1, My.Settings.ChallengeFreq2)
                End If
                If Weeks >= 104 Then
                    y = GetRandom(1, My.Settings.ChallengeFreq3)
                End If

                If y = 1 Then Call Challenge()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub Weekly_NewGames()
        Dim x As Integer, y As Integer, Freq As Integer, CoName As String, CoStrat As String, TheGame As String

        Try
            With FMain

                If .NewConsoles.Items.Count = 0 Then Exit Sub
                x = .Companies.Items.Count - 1

                Do
                    CoName = GetCompany(.Companies.Items(x), "Company")
                    CoStrat = GetCompany(.Companies.Items(x), "Strategy")
                    Freq = GetCompany(.Companies.Items(x), "Time")
                    y = 0

                    Select Case CoStrat
                        Case Is = "Rapid"
                            If Freq >= 40 Then y = 2
                            If Freq >= 35 Then y = 4
                            If Freq >= 30 Then y = 8

                        Case Is = "Sequel"
                            If Freq >= 52 Then y = 3
                            If Freq >= 45 Then y = 5
                            If Freq >= 38 Then y = 9

                        Case Is = "Quality"
                            If Freq >= 70 Then y = 5
                            If Freq >= 60 Then y = 15
                            If Freq >= 50 Then y = 25

                        Case Is = "Reboot"
                            If Freq >= 60 Then y = 3
                            If Freq >= 50 Then y = 5
                            If Freq >= 40 Then y = 8

                        Case Is = "Chance"
                            If Freq >= 65 Then y = 3
                            If Freq >= 55 Then y = 7
                            If Freq >= 45 Then y = 9

                        Case Is = "Engine"
                            If Freq >= 65 Then y = 3
                            If Freq >= 55 Then y = 7
                            If Freq >= 45 Then y = 9

                        Case Is = "America"
                            If Freq >= 60 Then y = 3
                            If Freq >= 50 Then y = 5
                            If Freq >= 40 Then y = 8

                        Case Is = "Average"
                            If Freq >= 60 Then y = 3
                            If Freq >= 50 Then y = 5
                            If Freq >= 40 Then y = 8
                    End Select

                    If y = 0 Then GoTo Skip_Loop

                    If CoStrat = "Engine" And GetRandom(1, y) = 1 Then 'engines only
                        y = .NewEngines.Items.Count - 1
                        If y = -1 Or GetRandom(1, .NewEngines.Items.Count) = 1 Then
                            .NewEngines.Items.Insert(0, GenEngine(CoName))
                            Application.DoEvents()
                            .NewsList.Items.Insert(0, CoName & " released the engine " & GetEngine(.NewEngines.Items(0), "Name") & " for the " & GetEngine(.NewEngines.Items(0), "Console") & " console.")
                            Freq = 0
                            GoTo Skip_Loop
                        End If
                    End If


                    y = GetRandom(1, y) 'should we do a sequel? even though it skips, it won't always do a sequel. The skip prevents two games being built
                    If y = 2 Then
                        Call DoSequel(CoName, CoStrat)
                        GoTo Skip_Loop
                    End If

                    If y = 1 Then
                        If CoStrat = "Engine" Then 'turns engine and sequel to average 
                            TheGame = GenGame(CoName, "Average")
                        ElseIf CoStrat = "Sequel" Then
                            TheGame = GenGame(CoName, "Average")
                        Else
                            TheGame = GenGame(CoName, CoStrat)
                        End If

                        'Below has moved to newgame code
                        'TheRating = GetGame(TheGame, "Rating")
                        'Form1.NewsList.Items.Insert(0, CoName & " just released " & GetGame(TheGame, "Name") & " with an overall rating of " & TheRating)
                        'Form1.NewGames.Items.Add(TheGame)

                        Freq = 0
                    End If

Skip_Loop:
                    Freq = Freq + 1
                    .Companies.Items.Item(x) = GetCompany(.Companies.Items(x), "Time", Freq)
                    x = x - 1
                Loop Until x = -1

                .Companies.Update()

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub Weekly_GameSales()
        Dim CoName As String, TheWeek As Integer, TheRating As Integer, TheGame As String, TheSales As Long, NewSales As Long, CurCash As Long, PrevSales As Long, CurIncome As Long, ThePublisher As String
        Dim x As Integer, y As Integer, z As Integer, ThePercent As Integer, PubSales As Long
        Dim CashValue As Long

        Try
            With FMain
                x = .NewGames.Items.Count - 1
                .Income.Text = ""
                If x = -1 Then Exit Sub

                'updates sales
                Do
                    CoName = GetGame(.NewGames.Items(x), "Company")
                    TheWeek = Val(GetGame(.NewGames.Items(x), "Release"))
                    TheRating = Val(GetGame(.NewGames.Items(x), "Rating"))
                    TheGame = GetGame(.NewGames.Items(x), "Name")
                    PrevSales = GetGame(.NewGames.Items(x), "PreviousSales")
                    z = .Companies.FindString(CoName)
                    If z = -1 Then ThePublisher = "0" Else ThePublisher = GetCompany(.Companies.Items(.Companies.FindString(CoName)), "Publisher")

                    ' If TheWeek = 1 Then 'moved over to game generation since creating new games has been moved to 6am
                    ' If TheRating = 10 Then TheSales = GetRandom(100000, 5000000)
                    ' If TheRating = 9 Then TheSales = GetRandom(50000, 300000)
                    ' If TheRating = 8 Then TheSales = GetRandom(50000, 150000)
                    ' If TheRating = 7 Then TheSales = GetRandom(30000, 75000)
                    ' If TheRating = 6 Then TheSales = GetRandom(20000, 50000)
                    ' If TheRating = 5 Then TheSales = GetRandom(5000, 20000)
                    ' If TheRating < 5 Then TheSales = GetRandom(1000, 5000)
                    ' Form1.NewGames.Items(x) = GetGame(Form1.NewGames.Items(x), "Sales", TheSales)
                    ' GoTo Skip_GameSales
                    ' End If

                    ' Remove GOTY
                    If .TheMonth.Text = "March" And TheGame.Contains("GOTY") Then
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Release", .TheYear.Text)
                        .OldGames.Items.Add(.NewGames.Items(x))
                        .NewGames.Items.RemoveAt(x)

                        GoTo Skip_GameSales2
                    End If

                    If TheWeek = 1 Then GoTo Skip_GameSales 'prevents games retiring on day 1

                    TheSales = Val(GetGame(.NewGames.Items(x), "Sales"))
                    PrevSales = Val(GetGame(.NewGames.Items(x), "PreviousSales"))

                    If TheWeek = 2 Then 'most games dropped between 60-90% after the first week
                        ThePercent = GetRandom(10, 40)
                        NewSales = Math.Round(TheSales * (ThePercent / 100))

                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Sales", (TheSales + NewSales))
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "PreviousSales", NewSales)

                        If CoName = .YourCo.Text Then
                            NewSales = Challenges(NewSales) 'Game AI for difficulty

                            If Val(.TheYear.Text) <= 1990 Then CashValue = (NewSales * 30)
                            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then CashValue = (NewSales * 40)
                            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then CashValue = (NewSales * 50)
                            If Val(.TheYear.Text) > 2010 Then CashValue = (NewSales * 60)

                            'Percentage of cut
                            If Val(.OwedCut.Text) <> 0 Then
                                CashValue = CashValue * (.OwedCut.Text / 100)
                            End If

                            .Income.Text = Math.Round(CashValue)

                            'display tooltip
                            .HelpText.Location = .Cash.Location
                            .HelpText.Text = "Sales for week " & TheWeek & ": " & NewSales & vbNewLine & "Earnings: $" & FormatNumber(.Income.Text, 0)
                            .HelpText.Visible = True
                            .Timer2.Enabled = True

                            .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))
                        End If

                        'Publishing
                        If ThePublisher = .YourCo.Text Then
                            NewSales = Challenges(NewSales) 'Game AI for difficulty

                            If Val(.TheYear.Text) <= 1990 Then CashValue = (NewSales * 30)
                            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then CashValue = (NewSales * 40)
                            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then CashValue = (NewSales * 50)
                            If Val(.TheYear.Text) > 2010 Then CashValue = (NewSales * 60)

                            'Percentage of cut
                            y = .OwnedStocks.FindString(CoName)
                            If y <> -1 Then
                                CashValue = CashValue * (GetStocks(.OwnedStocks.Items(y), "Sales") / 100)
                            End If

                            .Income.Text = Math.Round(Val(.Income.Text) + CashValue)

                            'display tooltip
                            .NewsList.Items.Insert(0, "Income sales for " & TheGame & " for week " & TheWeek & ": " & NewSales & ". Earnings: $" & FormatNumber(.Income.Text, 0))

                            .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))
                        End If

                        GoTo Skip_GameSales
                    End If

                    If TheWeek > 2 Then 'And TheWeek < 13 Then 'then the games slowly dropped sales over time
                        ThePercent = GetRandom(70, 90)
                        NewSales = (Math.Round(PrevSales * (ThePercent / 100)))
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Sales", (TheSales + NewSales))
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "PreviousSales", NewSales)

                        If CoName = .YourCo.Text Then
                            NewSales = Challenges(NewSales) 'Game AI for difficulty

                            If Val(.TheYear.Text) <= 1990 Then CashValue = (NewSales * 30)
                            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then CashValue = (NewSales * 40)
                            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then CashValue = (NewSales * 50)
                            If Val(.TheYear.Text) > 2010 Then CashValue = (NewSales * 60)

                            'Percentage of cut
                            If Val(.OwedCut.Text) <> 0 Then
                                CashValue = CashValue * (.OwedCut.Text / 100)
                            End If
                            .Income.Text = Math.Round(CashValue)

                            'display tooltip
                            .HelpText.Location = .Cash.Location
                            .HelpText.Text = "Sales for week " & TheWeek & ": " & NewSales & vbNewLine & "Earnings: $" & FormatNumber(.Income.Text, 0)
                            .HelpText.Visible = True
                            .Timer2.Enabled = True

                            .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))
                        End If

                        'Publishing
                        If ThePublisher = .YourCo.Text Then
                            If Val(.TheYear.Text) <= 1990 Then CashValue = (NewSales * 30)
                            If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then CashValue = (NewSales * 40)
                            If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then CashValue = (NewSales * 50)
                            If Val(.TheYear.Text) > 2010 Then CashValue = (NewSales * 60)

                            'Percentage of cut
                            y = .OwnedStocks.FindString(CoName)
                            If y <> -1 Then
                                CashValue = CashValue * (GetStocks(.OwnedStocks.Items(y), "Sales") / 100)
                            End If

                            .Income.Text = Math.Round(Val(.Income.Text) + CashValue)

                            'display tooltip
                            .NewsList.Items.Insert(0, "Income sales for " & TheGame & " for week " & TheWeek & ": " & NewSales & ". Earnings: $" & FormatNumber(.Income.Text, 0))

                            .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))
                        End If

                        'GoTo Skip_GameSales
                    End If

                    If NewSales < 100 Or TheWeek >= 23 Then
                        CoName = GetGame(.NewGames.Items(x), "Company")
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Release", .TheYear.Text)
                        .OldGames.Items.Add(.NewGames.Items(x))
                        .NewGames.Items.RemoveAt(x)

                        'add to company list
                        'y = Form1.Companies.Items.Count - 1

                        'Do
                        '    If InStr(Form1.Companies.Items(y), CoName) <> 0 Then
                        ' GoTo Update_Sales
                        'End If

                        'y = y - 1
                        'Loop Until y = -1

                        y = .Companies.FindString(CoName)
                        'If y = -1 Or CoName = Form1.YourCo.Text Then GoTo Skip_GameSales

                        If CoName = .YourCo.Text Then 'retire the player's game
                            .NewsList.Items.Insert(0, CoName & " just retired " & TheGame & " with " & FormatNumber(TheSales, 0) & " total sales.")
                            .ThePublisher.Text = ""
                            .OwedCut.Text = 0

                            'display tooltip
                            .HelpText.Location = .Cash.Location
                            .HelpText.Text = TheGame & " was retired." & vbNewLine & "Total sales: " & FormatNumber(TheSales, 0)
                            .HelpText.Visible = True
                            .Timer2.Enabled = True

                            GoTo Skip_GameSales2
                        End If

                        If y = -1 Then GoTo Skip_GameSales

Update_Sales:           'announce the retired game and add to company sales

                        NewSales = TheSales
                        If My.Settings.AlertRetiredGames = True Then .NewsList.Items.Insert(0, CoName & " just retired " & TheGame & " with " & FormatNumber(TheSales, 0) & " total sales.")

                        TheSales = GetCompany(.Companies.Items(y), "Sales")

                        .Companies.Items(y) = GetCompany(.Companies.Items(y), "Sales", (NewSales + TheSales))

                        'update cash
                        CurCash = GetCompany(.Companies.Items(y), "Cash")
                        CurIncome = GetCompany(.Companies.Items(y), "Income")

                        'Publishing assistance
                        PubSales = 0
                        z = -1
                        If ThePublisher <> CoName And ThePublisher <> "0" Then
                            'settle the real amount of income for the company
                            PubSales = Math.Round(NewSales * (GetRandom(30, 50) / 100))
                            NewSales = NewSales - PubSales

                            'bring in revenue
                            z = .Companies.FindString(ThePublisher)
                            If z <> -1 Then
                                If Val(.TheYear.Text) <= 1990 Then
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Cash", CurCash + (PubSales * 30))
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Income", CurIncome + (PubSales * 30))
                                End If

                                If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Cash", CurCash + (PubSales * 40))
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Income", CurIncome + (PubSales * 40))
                                End If

                                If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Cash", CurCash + (PubSales * 50))
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Income", CurIncome + (PubSales * 50))
                                End If

                                If Val(.TheYear.Text) > 2010 Then
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Cash", CurCash + (PubSales * 60))
                                    .Companies.Items(z) = GetCompany(.Companies.Items(y), "Income", CurIncome + (PubSales * 60))
                                End If
                            End If
                        End If

                        'Development studios get money
                        If Val(.TheYear.Text) <= 1990 Then
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash + (NewSales * 30))
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome + (NewSales * 30))
                        End If

                        If Val(.TheYear.Text) > 1990 And Val(.TheYear.Text) <= 2000 Then
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash + (NewSales * 40))
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome + (NewSales * 40))
                        End If

                        If Val(.TheYear.Text) > 2000 And Val(.TheYear.Text) <= 2010 Then
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash + (NewSales * 50))
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome + (NewSales * 50))
                        End If

                        If Val(.TheYear.Text) > 2010 Then
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash + (NewSales * 60))
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome + (NewSales * 60))
                        End If


                        TheWeek = TheWeek + 1
                        GoTo Skip_GameSales2
                    Else
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Sales", TheSales + NewSales)
                    End If

Skip_GameSales:
                    If .NewGames.Items.Count > 1 Then
                        TheWeek = TheWeek + 1
                        .NewGames.Items(x) = GetGame(.NewGames.Items(x), "Release", TheWeek)
                    End If

Skip_GameSales2:
                    x = x - 1
                Loop Until x = -1

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub DrawChartsEng()
        Try
            Dim b As New LinearGradientBrush(New Point(0, 0), New Point(300, 300), Color.Navy, Color.Black)
            Dim y As New Dictionary(Of String, Pie.PieData)
            Dim NumConsoles As Integer, NumSales As Long, x As Integer, TheCount As Integer, TheTotal As Integer
            'For i As Integer = 0 To 10
            ' Randomize()
            ' Dim rndI = CInt(Int((32000 * Rnd()) + 1))
            'y.Add("Test" & i, New Pie.PieData(rndI, GetRndBrush(300, 300)))
            'Next

            'clear everything 
            fNewEngine.Label26.Visible = False
            fNewEngine.Label25.Visible = False
            fNewEngine.Label24.Visible = False
            fNewEngine.Label11.Visible = False
            fNewEngine.Label10.Visible = False

            fNewEngine.Label27.Visible = False
            fNewEngine.Label9.Visible = False
            fNewEngine.Label8.Visible = False
            fNewEngine.Label7.Visible = False
            fNewEngine.Label6.Visible = False

            With FMain
                x = .NewConsoles.Items.Count - 1

                NumConsoles = 0
                NumSales = 0
                TheCount = 0

                'get total number of sales for each console 
                Do
                    If GetConsole(.NewConsoles.Items(x), "Sales") <> 0 Then
                        NumConsoles = NumConsoles + 1
                        NumSales = NumSales + GetConsole(.NewConsoles.Items(x), "Sales")
                    End If
                    x = x - 1
                Loop Until x = -1
            End With

            With fNewEngine
                'now let's create the chart
                x = FMain.NewConsoles.Items.Count - 1

                Do
                    If GetConsole(FMain.NewConsoles.Items(x), "Sales") <> 0 Then
                        TheCount = TheCount + 1

                        If TheCount = 1 Then
                            .Label26.Text = GetConsole(FMain.NewConsoles.Items(x), "Console")
                            .Label26.Visible = True
                            .Label27.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkRed))
                        End If

                        If TheCount = 2 Then
                            .Label25.Text = GetConsole(FMain.NewConsoles.Items(x), "Console")
                            .Label25.Visible = True
                            .Label9.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkGreen))
                        End If

                        If TheCount = 3 Then
                            .Label24.Text = GetConsole(FMain.NewConsoles.Items(x), "Console")
                            .Label24.Visible = True
                            .Label8.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkOrange))
                        End If

                        If TheCount = 4 Then
                            .Label11.Text = GetConsole(FMain.NewConsoles.Items(x), "Console")
                            .Label11.Visible = True
                            .Label7.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkBlue))
                        End If

                        If TheCount = 5 Then
                            .Label10.Text = GetConsole(FMain.NewConsoles.Items(x), "Console")
                            .Label10.Visible = True
                            .Label6.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkOrchid))
                        End If

                    End If
                    x = x - 1
                Loop Until x = -1

                'y.Add("demo1", New Pie.PieData(12, Brushes.DarkRed))
                'y.Add("demo2", New Pie.PieData(5, Brushes.DarkGreen))
                'y.Add("demo3", New Pie.PieData(9, Brushes.DarkOrange))
                'y.Add("demo4", New Pie.PieData(3, Brushes.DarkBlue))
                'y.Add("demo5", New Pie.PieData(2, Brushes.DarkOrchid))
                'y.Add("demo6", New Pie.PieData(19, Brushes.DarkTurquoise))

                If .PictureBox2.Height > .PictureBox2.Width Then
                    .PictureBox2.Image = New Pie(.PictureBox2.Width, .PictureBox2.Width, y).Image
                Else
                    .PictureBox2.Image = New Pie(.PictureBox2.Height, .PictureBox2.Height, y).Image
                End If

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub DrawCharts()
        Try

            Dim b As New LinearGradientBrush(New Point(0, 0), New Point(300, 300), Color.Navy, Color.Black)
            Dim y As New Dictionary(Of String, Pie.PieData)
            Dim NumConsoles As Long, NumSales As Long, x As Long, TheCount As Long, TheTotal As Long, NotReleased As String
            'For i As Integer = 0 To 10
            ' Randomize()
            ' Dim rndI = CInt(Int((32000 * Rnd()) + 1))
            'y.Add("Test" & i, New Pie.PieData(rndI, GetRndBrush(300, 300)))
            'Next

            'clear everything 
            x = FMain.NewConsoles.Items.Count - 1

            NumConsoles = 0
            NumSales = 0
            TheCount = 0

            With fNewGame
                .Label12.Visible = False
                .Label13.Visible = False
                .Label18.Visible = False
                .Label14.Visible = False
                .Label19.Visible = False
                .Label15.Visible = False
                .Label20.Visible = False
                .Label16.Visible = False
                .Label21.Visible = False
                .Label17.Visible = False
                .lbl_ExpectedSales.Visible = False

                'get total number of sales for each console 
                Do
                    If GetConsole(FMain.NewConsoles.Items(x), "Sales") <> 0 Then
                        NumConsoles = NumConsoles + 1
                        NumSales = NumSales + GetConsole(FMain.NewConsoles.Items(x), "Sales")
                    End If
                    x = x - 1
                Loop Until x = -1

                'now let's create the chart
                x = FMain.NewConsoles.Items.Count - 1

                Do
                    If IsNumeric(GetConsole(FMain.NewConsoles.Items(x), "Release")) = False Or GetConsole(FMain.NewConsoles.Items(x), "Release") < 1 Then
                        NotReleased = "***"
                    Else
                        NotReleased = ""
                    End If

                    If GetConsole(FMain.NewConsoles.Items(x), "Sales") <> 0 Then
                        TheCount = TheCount + 1

                        If TheCount = 1 Then
                            .Label13.Text = GetConsole(FMain.NewConsoles.Items(x), "Console") & NotReleased
                            .Label12.Visible = True
                            .Label13.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkRed))
                        End If

                        If TheCount = 2 Then
                            .Label14.Text = GetConsole(FMain.NewConsoles.Items(x), "Console") & NotReleased
                            .Label18.Visible = True
                            .Label14.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkGreen))
                        End If

                        If TheCount = 3 Then
                            .Label15.Text = GetConsole(FMain.NewConsoles.Items(x), "Console") & NotReleased
                            .Label19.Visible = True
                            .Label15.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkOrange))
                        End If

                        If TheCount = 4 Then
                            .Label16.Text = GetConsole(FMain.NewConsoles.Items(x), "Console") & NotReleased
                            .Label20.Visible = True
                            .Label16.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkBlue))
                        End If

                        If TheCount = 5 Then
                            .Label17.Text = GetConsole(FMain.NewConsoles.Items(x), "Console") & NotReleased
                            .Label21.Visible = True
                            .Label17.Visible = True
                            TheTotal = GetConsole(FMain.NewConsoles.Items(x), "Sales") * 100
                            y.Add(TheCount, New Pie.PieData(TheTotal, Brushes.DarkOrchid))
                        End If

                    End If
                    x = x - 1
                Loop Until x = -1

                If InStr(.Label13.Text, "***") <> 0 Or InStr(.Label14.Text, "***") <> 0 Or InStr(.Label15.Text, "***") <> 0 Or InStr(.Label16.Text, "***") <> 0 Or InStr(.Label17.Text, "***") <> 0 Then
                    .lbl_ExpectedSales.Visible = True
                End If

                'y.Add("demo1", New Pie.PieData(12, Brushes.DarkRed))
                'y.Add("demo2", New Pie.PieData(5, Brushes.DarkGreen))
                'y.Add("demo3", New Pie.PieData(9, Brushes.DarkOrange))
                'y.Add("demo4", New Pie.PieData(3, Brushes.DarkBlue))
                'y.Add("demo5", New Pie.PieData(2, Brushes.DarkOrchid))
                'y.Add("demo6", New Pie.PieData(19, Brushes.DarkTurquoise))

                If .Height > .PictureBox1.Width Then
                    .PictureBox1.Image = New Pie(.PictureBox1.Width, .PictureBox1.Width, y).Image
                Else
                    .PictureBox1.Image = New Pie(.PictureBox1.Height, .PictureBox1.Height, y).Image
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub DoSequel(CoName As String, CoStrat As String)
        Try
            Dim y As Integer, x As Integer

            'setup 
            FMain.lstSeq.Items.Clear()
            y = FMain.OldGames.Items.Count - 1
            If y = -1 Then Exit Sub
            x = -1

            Do 'determine if previous game exists and prevents GOTY from duplicating
                If GetGame(FMain.OldGames.Items(y), "Company") = CoName And Int(GetGame(FMain.OldGames.Items(y), "Rating")) >= 7 And InStr(GetGame(FMain.OldGames.Items(y), "Name"), "GOTY") = 0 Then
                    FMain.lstSeq.Items.Add(FMain.OldGames.Items(y))
                    x = x + 1
                End If

                y = y - 1
            Loop Until y = -1

            If CoStrat = "Sequel" Then
                'sequel companies are 33% of the time going to make a sequel
                If x > -1 And GetRandom(1, 3) = 1 Then
                    Call ProduceSequel(GetGame(FMain.lstSeq.Items(x), "Company"), GetGame(FMain.lstSeq.Items(x), "Name"), CoStrat)
                End If
                Exit Sub
            Else
                'depending on the game's previous rating, a company is more likely going to make a sequel
                If x = -1 Then Exit Sub 'quit while you're ahead

                x = GetRandom(0, x)
                Select Case Int(GetGame(FMain.lstSeq.Items(x), "Rating"))
                    Case Is = 7
                        If GetRandom(1, 12) = 1 Then ProduceSequel(GetGame(FMain.lstSeq.Items(x), "Company"), GetGame(FMain.lstSeq.Items(x), "Name"), CoStrat)
                    Case Is = 8
                        If GetRandom(1, 7) = 1 Then ProduceSequel(GetGame(FMain.lstSeq.Items(x), "Company"), GetGame(FMain.lstSeq.Items(x), "Name"), CoStrat)
                    Case Is = 9
                        If GetRandom(1, 5) = 1 Then ProduceSequel(GetGame(FMain.lstSeq.Items(x), "Company"), GetGame(FMain.lstSeq.Items(x), "Name"), CoStrat)
                    Case Is = 10
                        If GetRandom(1, 3) = 1 Then ProduceSequel(GetGame(FMain.lstSeq.Items(x), "Company"), GetGame(FMain.lstSeq.Items(x), "Name"), CoStrat)
                End Select

            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub ProduceSequel(CoName As String, TheGame As String, CoStrat As String)
        Dim x As Integer, y As Integer, TheRating As Integer, Seq As Integer, SeqText As String

        Try
            'chose game to sequelize
            y = GetRandom(0, FMain.lstSeq.Items.Count - 1)

            'figure out which number it is 
            SeqText = GetGame(FMain.lstSeq.Items(y), "Name")
            If IsNumeric(Right(SeqText, 2)) = True Then
                Seq = Right(SeqText, 2)
                Seq = Seq + 1
                SeqText = Left(SeqText, Len(SeqText) - 2) & " " & Seq
            Else
                SeqText = SeqText & " 2"
            End If

            'add the sequel number
            TheGame = GenGame(CoName, CoStrat, SeqText)

            'prevents duplicates
            For Each game In FMain.NewGames.Items
                If InStr(game, TheGame) <> 0 Then Exit Sub
            Next

            If FullGame <> Nothing Then
                TheRating = GetGame(FullGame, "Rating")
                If My.Settings.AlertNewGame = True Then FMain.NewsList.Items.Insert(0, CoName & " just released " & GetGame(FullGame, "Name") & " with an overall rating of " & TheRating)
                FMain.NewGames.Items.Add(FullGame)
                Application.DoEvents()

                FMain.Companies.Items.Item(x) = GetCompany(FMain.Companies.Items(x), "Time", 1)
            End If
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub Weekly_Consoles()
        Dim CoName As String, TheWeek As String, TheConsole As String, TheSales As Long, NewSales As Long, PrevSales As Long, CurCash As Long, ThePrice As Long, CurIncome As Long, TheCost As Long, TheDiff As Long
        Dim x As Integer, y As Integer, ThePercent As Integer

        Try
            x = FMain.NewConsoles.Items.Count - 1
            If x = -1 Then Exit Sub

            With FMain
                'updates sales
                Do
                    CoName = GetConsole(.NewConsoles.Items(x), "Company")
                    TheWeek = GetConsole(.NewConsoles.Items(x), "Release")
                    If IsNumeric(TheWeek) = True Then TheWeek = Int(TheWeek)

                    TheConsole = GetConsole(.NewConsoles.Items(x), "Console")
                    ThePrice = GetConsole(.NewConsoles.Items(x), "Price")
                    TheCost = GetConsole(.NewConsoles.Items(x), "Cost")
                    TheDiff = ThePrice - TheCost

                    TheSales = Val(GetConsole(.NewConsoles.Items(x), "Sales"))
                    PrevSales = Val(GetConsole(.NewConsoles.Items(x), "PreviousSales"))

                    If TheConsole = "PC" Then 'own special animal
                        Dim AllSales As Long

                        'Get total sales of all consoles
                        For Each itm In .NewConsoles.Items
                            If InStr(itm, "MacroSun") <> 0 Then AllSales = AllSales + GetConsole(itm, "Sales")
                        Next

                        'Calculate average
                        AllSales = AllSales / .NewConsoles.Items.Count

                        'Determine percent of average to decline/increase usage
                        ThePercent = GetRandom(80, 120)
                        AllSales = Math.Round(PrevSales * (ThePercent / 100))

                        'Update data
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", AllSales)
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", AllSales)

                        TheWeek = TheWeek + 1
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Release", TheWeek)

                        GoTo Skip_ConsoleSales2 'to prevent retiring
                    End If

                    'These will determine if the console is released or not yet
                    If TheWeek = .TheMonth.Text Then 'For player
                        TheWeek = 1
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Release", TheWeek)
                        NewSales = GetConsole(.NewConsoles.Items(x), "Sales")
                        GoTo Skip_ConsoleSales
                    End If

                    If TheWeek < 1 Then 'For AI
                        TheWeek = Val(TheWeek) + 1
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Release", TheWeek)
                        NewSales = GetConsole(.NewConsoles.Items(x), "Sales")
                        GoTo Skip_ConsoleSales2
                    End If


                    'First week? Then show me the money. Otherwise, move along
                    If TheWeek = 1 Then GoTo Skip_ConsoleSales 'because of command sequence we can skip this section

                    If TheWeek = 2 Then 'first major drop off, but not significant since it's a console
                        ThePercent = GetRandom(30, 50)
                        NewSales = (Math.Round(TheSales * (ThePercent / 100)))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", (TheSales + NewSales))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", NewSales)
                        GoTo Skip_ConsoleSales
                    End If

                    If TheWeek > 2 And TheWeek < 105 Then 'sales slowly dwindle for a year
                        ThePercent = GetRandom(90, 99)
                        NewSales = (Math.Round(PrevSales * (ThePercent / 100)))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", (TheSales + NewSales))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", NewSales)
                        'GoTo Skip_ConsoleSales
                    End If

                    If TheWeek > 104 Then 'after a year the sales go kaboom :(
                        ThePercent = GetRandom(30, 60) / 100
                        NewSales = (Math.Round(PrevSales * (ThePercent / 100)))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", (TheSales + NewSales))
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "PreviousSales", NewSales)
                        'GoTo Skip_ConsoleSales
                    End If

                    'ThePercent = GetRandom(1, 3) / 100
                    'NewSales = (Math.Round(TheSales * (ThePercent / 100)))

                    If NewSales < 100 Or TheWeek >= 208 Then 'launch failure or greater than 4 years
                        CoName = GetConsole(.NewConsoles.Items(x), "Company")
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Release", .TheYear.Text)
                        .OldConsoles.Items.Add(.NewConsoles.Items(x))
                        .NewConsoles.Items.RemoveAt(x)

                        'announce the retired console and add to company sales
                        NewSales = TheSales
                        .NewsList.Items.Insert(0, CoName & " just retired " & TheConsole & " with " & FormatNumber(TheSales, 0) & " total sales.")

                        'retire engines
                        y = .NewEngines.Items.Count - 1
                        If y = -1 Then
                            TheWeek = TheWeek + 1
                            GoTo Skip_ConsoleSales2
                        End If
                        Do
                            If GetEngine(.NewEngines.Items(y), "Console") = TheConsole Then
                                .OldEngines.Items.Add(.NewEngines.Items(y))
                                .NewEngines.Items.RemoveAt(y)
                            End If
                            y = y - 1
                        Loop Until y = -1

                        TheWeek = TheWeek + 1
                        GoTo Skip_ConsoleSales2
                    Else
                        y = .Companies.FindString(CoName)
                        .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Sales", TheSales + NewSales)
                    End If

Skip_ConsoleSales:

                    If CoName = .YourCo.Text Then
                        .Income.Text = Val(.Income.Text) + (TheDiff * NewSales)

                        'display tooltip
                        .HelpText.Location = .Cash.Location
                        .HelpText.Text = "Console sales for week " & TheWeek & ": " & NewSales & vbNewLine & "Earnings: $" & FormatNumber(.Income.Text, 0)
                        .HelpText.Visible = True
                        .Timer2.Enabled = True

                        .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.Income.Text))
                    Else
                        y = .Companies.FindString(CoName)

                        If y <> -1 Then 'if the company does not exist
                            CurCash = GetCompany(.Companies.Items(y), "Cash")
                            CurIncome = GetCompany(.Companies.Items(y), "Income")
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash + Val(NewSales * TheDiff))
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome + Val(NewSales * TheDiff))


                            TheWeek = TheWeek + 1
                            .NewConsoles.Items(x) = GetConsole(.NewConsoles.Items(x), "Release", TheWeek)
                        Else
                            Call GenCo() 'Create a new company anyways
                            y = .Companies.Items.Count - 1

                            Try
                                CurCash = CurCash + Val(NewSales * TheDiff)
                                CurIncome = CurIncome + Val(NewSales * TheDiff)
                            Catch ex As Exception
                                CurCash = UInteger.MaxValue
                                CurIncome = UInteger.MaxValue
                            End Try

                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Name", CoName)
                            CurCash = GetCompany(.Companies.Items(y), "Cash")
                            CurIncome = GetCompany(.Companies.Items(y), "Income")
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Cash", CurCash)
                            .Companies.Items(y) = GetCompany(.Companies.Items(y), "Income", CurIncome)
                            '.NewConsoles.Items.RemoveAt(x)
                        End If

                    End If

Skip_ConsoleSales2:
                    x = x - 1
                Loop Until x = -1
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub Contracting()
        Try
            Dim ArtSkills As Long, TechSkills As Long, SpeedSkills As Long, TempProg As Long, Speciality As String
            Dim x As Integer, PTO As String

            With FMain
                If Val(.Hrs.Text) < 7 Then Exit Sub
                If Val(.Hrs.Text - .Overtime.Text) > 17 Then Exit Sub

                x = .EmployeeData.Items.Count - 1

                ArtSkills = 0
                TechSkills = 0

                If .EmployeeData.Items.Count = 0 Then Exit Sub
                TempProg = .RadialBar2.Value

                Do
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    If PTO = "Y" Then GoTo Next_Dev 'why work when off?

                    'the skills
                    SpeedSkills = GetEmployee(.EmployeeData.Items(x), "Speed")
                    SpeedSkills = SpeedSkills + (Val(.EngUse.Text) * My.Settings.EnginePts)
                    ArtSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Artist") * (SpeedSkills / 100))
                    TechSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Tech") * (SpeedSkills / 100))

                    ArtSkills = ArtSkills + Math.Round(Val(.EngTech.Text) * My.Settings.EnginePts)
                    TechSkills = TechSkills + Math.Round(Val(.EngTech.Text) * My.Settings.EnginePts)

                    Speciality = GetEmployee(.EmployeeData.Items(x), "Position")

                    Select Case Speciality
                        Case Is = "Artist"
                            ArtSkills = ArtSkills + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Designer" 'multi-skilled
                            ArtSkills = ArtSkills + Math.Round((ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax)) / 2)
                            TechSkills = TechSkills + Math.Round((TechSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax)) / 2)
                        Case Is = "Writer"
                            ArtSkills = ArtSkills + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Programmer"
                            ArtSkills = ArtSkills + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Audio"
                            TechSkills = TechSkills + Math.Round(TechSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Tester"
                            TechSkills = TechSkills + Math.Round(TechSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                    End Select

                    TempProg = Math.Round(TempProg + ArtSkills + TechSkills)

Next_Dev:
                    x = x - 1
                Loop Until x = -1

                If TempProg > .RadialBar2.Maximum Then TempProg = .RadialBar2.Maximum

                .RadialBar2.Value = TempProg

                'contract is met 
                If TempProg = .RadialBar2.Maximum Then
                    If Val(.AllWeeks.Text) > 0 Then
                        Call EndContract(True)
                        .AllWeeks.Text = -1
                        Exit Sub
                    Else
                        Call EndContract(False, Val(.AllWeeks.Text))
                        .AllWeeks.Text = -1
                        Exit Sub
                    End If
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub EndContract(Success As Boolean, Optional ByVal OffWeeks As Integer = 0)
        Try
            With FMain
                .Label9.Enabled = True
                .Contract.Checked = False
                .Label19.Enabled = True
                .Label20.Enabled = True
                .Stage.Text = "Idle"
                .DevelopStages.Items.Clear()

                .RadialBar1.Value = 0
                .RadialBar2.Value = 0

                If Success = True Then
                    Call MsgBox("You have honored the contract within the required timeframe. You will be paid " & FormatCurrency(.ConCash.Text, 0), vbOKOnly)
                    .Cash.Text = Math.Round(Val(.Cash.Text) + Val(.ConCash.Text))
                    .Reputation.Text = Math.Round(.Reputation.Text + GetRandom(25, 50))
                Else
                    Dim FailCon As Long = Val(.AllWeeks.Text)
                    Dim ConTotal As Long = Val(.ConCash.Text)
                    Dim MaxLoss As Long = Math.Round(ConTotal * 0.25)
                    Do
                        ConTotal = ConTotal - Math.Round(Val(.ConCash.Text) * 0.1)
                        FailCon = FailCon + 1
                    Loop Until FailCon = 0

                    If ConTotal < MaxLoss Then ConTotal = MaxLoss 'just so they don't get bankrupt

                    .ConCash.Text = Val(.ConCash.Text) + ConTotal
                    Call MsgBox("You have failed to meet the contract deadline. However, you will be paid " & FormatCurrency(.ConCash.Text, 0), vbOKOnly)

                    .Cash.Text = Val(.Cash.Text) + Val(.ConCash.Text)
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub Development()
        Try
            Dim ArtSkills As Long, TechSkills As Long, SpeedSkills As Long, TempProg As Long, Publish As String, GameSkills As Long, Speciality As String
            Dim x As Integer, y As Integer, PTO As String

            With FMain
                If Val(.Hrs.Text) < 7 Then Exit Sub
                If Val(.Hrs.Text - .Overtime.Text) > 17 Then Exit Sub

                x = .EmployeeData.Items.Count - 1

                ArtSkills = 0
                TechSkills = 0

                If .EmployeeData.Items.Count = 0 Then Exit Sub


                Do
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    If PTO = "Y" Then GoTo Next_Dev 'why work when off?

                    'the skills
                    SpeedSkills = GetEmployee(.EmployeeData.Items(x), "Speed")
                    SpeedSkills = SpeedSkills + (Val(.EngUse.Text) * My.Settings.EnginePts)
                    ArtSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Artist") * (SpeedSkills / 100))
                    TechSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Tech") * (SpeedSkills / 100))
                    GameSkills = Math.Round((TechSkills + ArtSkills) / 2) * (SpeedSkills / 100)

                    'ArtSkills = Math.Round(ArtSkills / .ListBox6.Items.Count)
                    ArtSkills = ArtSkills + Math.Round(Val(.EngTech.Text) * My.Settings.EnginePts)
                    'TechSkills = Math.Round(TechSkills / .ListBox6.Items.Count)
                    TechSkills = TechSkills + Math.Round(Val(.EngTech.Text) * My.Settings.EnginePts)
                    'GameSkills = Math.Round(GameSkills / .ListBox6.Items.Count)
                    GameSkills = GameSkills + Math.Round(Val(.EngTech.Text) * My.Settings.EnginePts)

                    Speciality = GetEmployee(.EmployeeData.Items(x), "Position")

                    'for researching
                    y = GetRandom(1, My.Settings.ResearchPer)
                    If y = 1 Then
                        ArtSkills = 0
                        TechSkills = 0
                        GameSkills = 0
                    End If

                    TempProg = .RadialBar2.Value
                    y = GetRandom(1, 9)

                    'distribute skills  - top item should be the set "focus" by player 
                    Select Case .GameFocus.Text
                        Case Is = "Art"
                            If y <= 3 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 4 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 6 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 8 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            End If
                        Case Is = "Story"
                            If y = 4 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y <= 3 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 6 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 8 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            End If
                        Case Is = "Design"
                            If y = 4 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y <= 3 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 6 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 8 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            End If
                        Case Is = "Gameplay"
                            If y = 4 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 6 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y <= 3 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 8 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            End If
                        Case Is = "Replay"
                            If y = 4 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 6 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y <= 3 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 8 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            End If
                        Case Is = "Audio"
                            If y = 4 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 5 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 6 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 7 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y <= 3 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 8 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            End If
                        Case Is = "None"
                            y = GetRandom(1, 7)
                            If y = 1 Then
                                .uArt.Text = Val(.uArt.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 2 Then
                                .uStory.Text = Val(.uStory.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills
                            ElseIf y = 3 Then
                                .uDesign.Text = Val(.uDesign.Text) + TechSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 4 Then
                                .uGameplay.Text = Val(.uGameplay.Text) + GameSkills
                                TempProg = TempProg + TechSkills
                            ElseIf y = 5 Then
                                .uReplay.Text = Val(.uReplay.Text) + GameSkills
                                TempProg = TempProg + GameSkills
                            ElseIf y = 6 Then
                                .uMusic.Text = Val(.uMusic.Text) + ArtSkills
                                TempProg = TempProg + ArtSkills

                            End If
                    End Select

                    'And then there are bugs + development help 
                    Select Case .Stage.Text
                        Case Is = "Pre-production"
                            .uStory.Text = Val(.uStory.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Prototype"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(0, 2)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(5, 20)
                            .uStory.Text = Val(.uStory.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Production"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(0, 7)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(4, 15)
                            .uReplay.Text = Val(.uReplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uGameplay.Text = Val(.uGameplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Design"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(0, 8)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(3, 13)
                            .uDesign.Text = Val(.uDesign.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Programming"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(0, 10)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(1, 9)
                            .uReplay.Text = Val(.uReplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uGameplay.Text = Val(.uGameplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Level creation"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(2, 10)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(1, 5)
                            .uReplay.Text = Val(.uReplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uGameplay.Text = Val(.uGameplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uDesign.Text = Val(.uDesign.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Art Production"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(1, 15)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(1, 4)
                            .uArt.Text = Val(.uArt.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uMusic.Text = Val(.uMusic.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                            .uStory.Text = Val(.uStory.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.StageMin, My.Settings.StageMax))
                        Case Is = "Testing"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(5, 25)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(0, 3)
                        Case Is = "Release"
                            .uBugs.Text = Val(.uBugs.Text) - GetRandom(5, 20)
                            .uBugs.Text = Val(.uBugs.Text) + GetRandom(0, 1)
                    End Select

                    If Val(.uBugs.Text) < 0 Then .uBugs.Text = 0

                    'position specialties affect outcome too
                    Select Case Speciality
                        Case Is = "Artist"
                            .uArt.Text = Val(.uArt.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Designer"
                            .uDesign.Text = Val(.uDesign.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Writer"
                            .uStory.Text = Val(.uStory.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Programmer"
                            .uReplay.Text = Val(.uReplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                            .uGameplay.Text = Val(.uGameplay.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Audio"
                            .uMusic.Text = Val(.uMusic.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Tester"
                            .uBugs.Text = Val(.uBugs.Text) - Math.Round(TechSkills / GetRandom(1, 10))
                            If Val(.uBugs.Text) < 0 Then .uBugs.Text = 0
                    End Select

                    If .Stage.Text = "Prototype" Or .Stage.Text = "Pre-production" Then 'if prototype stages use traditional based off development point
                        If TempProg > .RadialBar2.Maximum Then TempProg = .RadialBar2.Maximum
                        .RadialBar2.Value = TempProg
                    End If

Next_Dev:
                    x = x - 1
                Loop Until x = -1

                Dim ProgressMax As Long, TotalDev As Long

                ProgressMax = 1

                If .GameSize.Text = 2 Then ProgressMax = 2
                If .GameSize.Text = 3 Then ProgressMax = 5
                If .GameSize.Text = 4 Then ProgressMax = 8
                If .GameSize.Text = 5 Then ProgressMax = 12

                'create the progress bars
                TotalDev = Math.Round(Val(.uDesign.Text) + Val(.uArt.Text) + Val(.uGameplay.Text) + Val(.uStory.Text) + Val(.uReplay.Text) + Val(.uMusic.Text))

                If TotalDev > 0 Then
                    'set maximum
                    .DesignBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .ArtBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .GameplayBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .StoryBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .ReplayBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .MusicBar.Maximum = Math.Round(My.Settings.DevPoints * .DevTeam.Text)
                    .BugBar.Maximum = (My.Settings.DevPoints * .DevTeam.Text)

                    'prevent overflow
                    If Val(.uDesign.Text) > Val(.DesignBar.Maximum) Then .uDesign.Text = Val(.DesignBar.Maximum)
                    If Val(.uArt.Text) > Val(.ArtBar.Maximum) Then .uArt.Text = Val(.ArtBar.Maximum)
                    If Val(.uGameplay.Text) > Val(.GameplayBar.Maximum) Then .uGameplay.Text = Val(.GameplayBar.Maximum)
                    If Val(.uStory.Text) > Val(.StoryBar.Maximum) Then .uStory.Text = Val(.StoryBar.Maximum)
                    If Val(.uReplay.Text) > Val(.ReplayBar.Maximum) Then .uReplay.Text = Val(.ReplayBar.Maximum)
                    If Val(.uMusic.Text) > Val(.MusicBar.Maximum) Then .uMusic.Text = Val(.MusicBar.Maximum)
                    If Val(.uBugs.Text) > Val(.BugBar.Maximum) Then .uBugs.Text = Val(.BugBar.Maximum)

                    .DesignBar.Minimum = 1
                    .ArtBar.Minimum = 1
                    .GameplayBar.Minimum = 1
                    .StoryBar.Minimum = 1
                    .ReplayBar.Minimum = 1
                    .DesignBar.Minimum = 1
                    .MusicBar.Minimum = 1
                    .BugBar.Minimum = 1

                    'set values based on data
                    If Val(.uDesign.Text) < 1 Then .DesignBar.Value = 1 Else .DesignBar.Value = Math.Round(Val(.uDesign.Text))
                    If Val(.uArt.Text) < 1 Then .ArtBar.Value = 1 Else .ArtBar.Value = Math.Round(Val(.uArt.Text))
                    If Val(.uGameplay.Text) < 1 Then .GameplayBar.Value = 1 Else .GameplayBar.Value = Math.Round(Val(.uGameplay.Text))
                    If Val(.uStory.Text) < 1 Then .StoryBar.Value = 1 Else .StoryBar.Value = Math.Round(Val(.uStory.Text))
                    If Val(.uReplay.Text) < 1 Then .ReplayBar.Value = 1 Else .ReplayBar.Value = Math.Round(Val(.uReplay.Text))
                    If Val(.uMusic.Text) < 1 Then .MusicBar.Value = 1 Else .MusicBar.Value = Math.Round(Val(.uMusic.Text))
                    If Val(.uBugs.Text) < 1 Then .BugBar.Value = 1 Else .BugBar.Value = Val(.uBugs.Text)

                End If

                'random events!
                If .Stage.Text <> "Pre-production" And .Stage.Text <> "Prototype" And .Stage.Text <> "Testing" And .RandomCounter.Text = 0 Then
                    x = GetRandom(0, My.Settings.RandomEvents)
                    If x = 1 And fRandom.Visible = False Then Call RandomEvents()
                End If

                If .RadialBar2.Value <> .RadialBar2.Maximum Then Exit Sub ' quit while you're ahead

                If .Stage.Text = "Pre-production" Then
                    .Stage.Text = "Prototype"
                    .RadialBar2.Maximum = (My.Settings.PreProduction * ProgressMax)
                    .RadialBar2.Value = 0
                    Exit Sub
                End If

                If .Stage.Text = "Prototype" Then
                    .Timer1.Enabled = False

                    Call SetPublishing()

                    Exit Sub
                End If

                If .Stage.Text = "Production" Then
                    .Stage.Text = "Design"
                    '.RadialBar2.Maximum = (4000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Design" Then
                    .Stage.Text = "Programming"
                    '.RadialBar2.Maximum = (7000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Programming" Then
                    .Stage.Text = "Level creation"
                    '.RadialBar2.Maximum = (7000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Level creation" Then
                    .Stage.Text = "Art Production"
                    '.RadialBar2.Maximum = (6000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Art Production" Then
                    .Stage.Text = "Testing"
                    '.RadialBar2.Maximum = (3000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Testing" Then
                    .Stage.Text = "Release"
                    Exit Sub
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub SetPublishing()
        Dim Publish As MsgBoxResult
        Dim TheWe As Long = Math.Round(FMain.Cash.Text / Expenses())

        Try
            With FMain
                .Timer1.Enabled = False

                If .SetPublisher.Checked = True Then 'publisher is determined
                    Dim TotCash As Long

                    If .TheYear.Text < 1990 Then TotCash = 75000 * Val(.GameSize.Text)
                    If .TheYear.Text >= 1990 And .TheYear.Text < 2000 Then TotCash = 100000 * Val(.GameSize.Text)
                    If .TheYear.Text >= 2000 And .TheYear.Text < 2010 Then TotCash = 125000 * Val(.GameSize.Text)
                    If .TheYear.Text >= 2010 Then TotCash = 150000 * Val(.GameSize.Text)
                    Dim CashAward As Long = Val(GetRandom(50000, TotCash)) * Val(.GameSize.Text)

                    Publish = MsgBox("Would you like to publish with " & .SetPublisher.Text & " with a downpayment of " & FormatCurrency(CashAward, 0) & "?", vbYesNo + vbInformation)

                    If Publish = MsgBoxResult.Yes Then 'then let's build project plan
Pre_Publish:
                        Dim timeframe As Long = GetRandom(50, 70)
                        'determine minimum and maximum time 
                        'name, timeframe, reward, percent
                        .ThePublisher.Text = .SetPublisher.Text
                        .OwedCut.Text = GetRandom(25, 40)
                        .AllWeeks.Text = timeframe
                        .Cash.Text = Val(.Cash.Text) + Val(CashAward)
                        .DownPayment.Text = Math.Round(CashAward * 1.2)
                        .RadialBar1.Maximum = Val(.AllWeeks.Text)
                        .RadialBar1.Value = 0
                        .Marketing.Text = My.Settings.PublisherAdvantage

                        With fProject
                            .HScrollBar1.Maximum = Math.Round(timeframe * 1.4)
                            .HScrollBar1.Minimum = Math.Round(timeframe * 0.6)
                            .HScrollBar1.Value = timeframe
                            .HScrollBar1.Enabled = False
                            .TextBox1.Text = timeframe
                            .TextBox1.Enabled = False
                            .Show()
                        End With

                        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                        fProject.Show()

                    Else 'if they select no

                        If TheWe < 25 Then 'They can't afford it - go back to go
                            Call MsgBox("You need at least 25 weeks of development to self-publish." & vbNewLine & "According to your current expenses, you only have " & TheWe & " weeks of funds.", vbInformation)
                            GoTo Pre_Publish
                        End If

                        'Otherwise, let's self-publish
                        .SetPublisher.Text = ""
                        .SetPublisher.Checked = False
                        Call MsgBox("You have cut ties with your publisher.", MsgBoxStyle.Information)
                        GoTo Self_Publish
                    End If
                End If

                'Publisher is not determined
                If .SetPublisher.Checked = False Then
                    Publish = MsgBox("Would you like to pitch your idea to publishers?", vbYesNo + vbInformation)
                    .Marketing.Text = 5

                    If Publish = MsgBoxResult.No Then 'okay, let's self-publish

                        If TheWe < 25 Then 'unless you can't afford it
                            Call MsgBox("You need at least 25 weeks of development to self-publish." & vbNewLine & "According to your current expenses, you only have " & TheWe & " weeks of funds.", vbInformation)
                            Call SetPublishers()
                            Exit Sub
                        End If

Self_Publish:
                        .ThePublisher.Text = "Self"
                        .AllWeeks.Text = -1
                        .OwedCut.Text = 100
                        .Marketing.Text = 5

                        'determine minimum and maximum time 
                        If TheWe > 265 Then TheWe = 265
                        Dim TheWu As Long = TheWe * 0.5
                        If TheWu >= 52 Then TheWu = 52

                        fProject.HScrollBar1.Maximum = TheWe
                        fProject.HScrollBar1.Minimum = TheWu
                        fProject.HScrollBar1.Value = Math.Round((fProject.HScrollBar1.Maximum + fProject.HScrollBar1.Minimum) / 2)
                        fProject.TextBox1.Text = fProject.HScrollBar1.Value
                        fProject.HScrollBar1.Enabled = True

                        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                        fProject.Show()
                    Else 'otherwise, let's find a publisher
                        .Marketing.Text = My.Settings.PublisherAdvantage
                        Call SetPublishers()
                    End If
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub SetDirection()
        Try
            FMain.Timer1.Enabled = False

            With FDirection
                .Label1.Text = "Who will lead the " & FMain.Stage.Text & " stage of the project?"

                .StaffList.Items.Clear()
                .StaffData.Items.Clear()

                For Each itm In FMain.EmployeeData.Items
                    .StaffData.Items.Add(itm)
                    .StaffList.Items.Add(GetEmployee(itm, "Name"))
                Next

                'Fill default values
                .txt_Position.Text = GetEmployee(.StaffData.Items(0), "Position")
                .ArtBar.Value = GetEmployee(.StaffData.Items(0), "Artist")
                .TechBar.Value = GetEmployee(.StaffData.Items(0), "Tech")

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub EngineBuild()
        Dim ArtSkills As Long, TechSkills As Long, SpeedSkills As Long, TempProg As Long, GameSkills As Long, Speciality As String
        Dim x As Integer, y As Integer, PTO As String, z As Integer

        Try
            With FMain
                If Val(.Hrs.Text) < 7 Then Exit Sub
                If Val(.Hrs.Text - .Overtime.Text) > 17 Then Exit Sub

                x = .EmployeeData.Items.Count - 1

                ArtSkills = 0
                TechSkills = 0

                If .EmployeeData.Items.Count = 0 Then Exit Sub


                Do
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    If PTO = "Y" Then GoTo Next_Dev 'why work when off?

                    'the skills
                    SpeedSkills = GetEmployee(.EmployeeData.Items(x), "Speed")
                    SpeedSkills = SpeedSkills + My.Settings.EnginePts
                    ArtSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Artist") * (SpeedSkills / 100))
                    TechSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Tech") * (SpeedSkills / 100))
                    GameSkills = Math.Round((TechSkills + ArtSkills) / 2) * (SpeedSkills / 100)

                    'ArtSkills = Math.Round(ArtSkills / .ListBox6.Items.Count)
                    ArtSkills = ArtSkills + My.Settings.EnginePts
                    'TechSkills = Math.Round(TechSkills / .ListBox6.Items.Count)
                    TechSkills = TechSkills + My.Settings.EnginePts

                    Speciality = GetEmployee(.EmployeeData.Items(x), "Position")

                    'for researching
                    y = GetRandom(1, My.Settings.ResearchPer)
                    If y = 1 Then
                        ArtSkills = 0
                        TechSkills = 0
                        GameSkills = 0
                    End If

                    TempProg = .RadialBar2.Value

                    'stage focus
                    Select Case .Stage.Text
                        Case Is = "Input"
                            .uInput.Text = Math.Round(Val(.uInput.Text) + TechSkills)
                        Case Is = "Physics"
                            .uPhysics.Text = Math.Round(Val(.uPhysics.Text) + ArtSkills)
                        Case Is = "Scripting"
                            .uScripts.Text = Math.Round(Val(.uScripts.Text) + ArtSkills)
                        Case Is = "Networking"
                            .uNetwork.Text = Math.Round(Val(.uNetwork.Text) + ArtSkills)
                        Case Is = "GUI"
                            .uGUI.Text = Math.Round(Val(.uGUI.Text) + TechSkills)
                        Case Is = "Graphics and Sound"
                            .uGraphics.Text = Math.Round(Val(.uGraphics.Text) + ArtSkills)
                            .uSound.Text = Math.Round(Val(.uSound.Text) + TechSkills)
                        Case Is = 7

                    End Select

                    z = GetRandom(1, 7)
                    'random additions for each stage
                    Select Case z
                        Case Is = 1
                            .uInput.Text = Math.Round(Val(.uInput.Text) + TechSkills)
                        Case Is = 2
                            .uGraphics.Text = Math.Round(Val(.uGraphics.Text) + ArtSkills)
                        Case Is = 3
                            .uSound.Text = Math.Round(Val(.uSound.Text) + ArtSkills)
                        Case Is = 4
                            .uNetwork.Text = Math.Round(Val(.uNetwork.Text) + ArtSkills)
                        Case Is = 5
                            .uPhysics.Text = Math.Round(Val(.uPhysics.Text) + TechSkills)
                        Case Is = 6
                            .uGUI.Text = Math.Round(Val(.uGUI.Text) + ArtSkills)
                        Case Is = 7
                            .uScripts.Text = Math.Round(Val(.uScripts.Text) + TechSkills)
                    End Select

                    'position specialties affect outcome too
                    Select Case Speciality
                        Case Is = "Artist"
                            .uGraphics.Text = Val(.uGraphics.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Designer"
                            .uGUI.Text = Val(.uGUI.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Writer"
                            .uInput.Text = Val(.uInput.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Programmer"
                            .uNetwork.Text = Val(.uNetwork.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                            .uPhysics.Text = Val(.uPhysics.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Audio"
                            .uSound.Text = Val(.uSound.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Tester"
                            .uScripts.Text = Val(.uScripts.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                    End Select

Next_Dev:
                    x = x - 1
                Loop Until x = -1

                'random events!
                If .Stage.Text <> "Graphics and Sound" And .RandomCounter.Text = 0 Then
                    x = GetRandom(0, My.Settings.RandomEvents)
                    If x = 1 And fRandom.Visible = False Then Call RandomEvents()
                End If

                Dim ProgressMax As Long, TotalDev As Long

                ProgressMax = 1

                'create the progress bars
                TotalDev = Math.Round(Val(.uInput.Text) + Val(.uGraphics.Text) + Val(.uSound.Text) + Val(.uNetwork.Text) + Val(.uPhysics.Text) + Val(.uGUI.Text) + Val(.uScripts.Text))

                If TotalDev > 0 Then
                    .InputBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .GraphicsBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .SoundBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .NetworkBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .PhysicsBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .guiBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)
                    .ScriptBar.Maximum = Math.Round(My.Settings.EngineDev * .DevTeam.Text)

                    If Val(.uInput.Text) > Val(.InputBar.Maximum) Then .uInput.Text = Val(.InputBar.Maximum)
                    If Val(.uGraphics.Text) > Val(.GraphicsBar.Maximum) Then .uGraphics.Text = Val(.InputBar.Maximum)
                    If Val(.uSound.Text) > Val(.SoundBar.Maximum) Then .uSound.Text = Val(.SoundBar.Maximum)
                    If Val(.uNetwork.Text) > Val(.NetworkBar.Maximum) Then .uNetwork.Text = Val(.NetworkBar.Maximum)
                    If Val(.uPhysics.Text) > Val(.PhysicsBar.Maximum) Then .uPhysics.Text = Val(.PhysicsBar.Maximum)
                    If Val(.uGUI.Text) > Val(.guiBar.Maximum) Then .uGUI.Text = Val(.guiBar.Maximum)
                    If Val(.uScripts.Text) > Val(.ScriptBar.Maximum) Then .uScripts.Text = Val(.ScriptBar.Maximum)

                    .InputBar.Minimum = 1
                    .GraphicsBar.Minimum = 1
                    .SoundBar.Minimum = 1
                    .NetworkBar.Minimum = 1
                    .PhysicsBar.Minimum = 1
                    .guiBar.Minimum = 1
                    .ScriptBar.Minimum = 1

                    If Val(.uInput.Text) < 1 Then .InputBar.Value = 1 Else .InputBar.Value = Math.Round(Val(.uInput.Text))
                    If Val(.uGraphics.Text) < 1 Then .GraphicsBar.Value = 1 Else .GraphicsBar.Value = Math.Round(Val(.uGraphics.Text))
                    If Val(.uSound.Text) < 1 Then .SoundBar.Value = 1 Else .SoundBar.Value = Math.Round(Val(.uSound.Text))
                    If Val(.uNetwork.Text) < 1 Then .NetworkBar.Value = 1 Else .NetworkBar.Value = Math.Round(Val(.uNetwork.Text))
                    If Val(.uPhysics.Text) < 1 Then .PhysicsBar.Value = 1 Else .PhysicsBar.Value = Math.Round(Val(.uPhysics.Text))
                    If Val(.uGUI.Text) < 1 Then .guiBar.Value = 1 Else .guiBar.Value = Math.Round(Val(.uGUI.Text))
                    If Val(.uScripts.Text) < 1 Then .ScriptBar.Value = 1 Else .ScriptBar.Value = Math.Round(Val(.uScripts.Text))

                End If

                If .RadialBar2.Value <> .RadialBar2.Maximum Then Exit Sub ' quit while you're ahead

                If .Stage.Text = "Input" Then
                    .Stage.Text = "Physics"
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Physics" Then
                    .Stage.Text = "Scripting"
                    '.RadialBar2.Maximum = (4000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Scripting" Then
                    .Stage.Text = "Networking"
                    '.RadialBar2.Maximum = (7000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Networking" Then
                    .Stage.Text = "GUI"
                    '.RadialBar2.Maximum = (7000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "GUI" Then
                    .Stage.Text = "Graphics and Sound"
                    '.RadialBar2.Maximum = (6000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Graphics and Sound" Then
                    Call ReleaseEngine()
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub ConsoleBuild()
        Try
            Dim ArtSkills As Long, TechSkills As Long, SpeedSkills As Long, TempProg As Long, GameSkills As Long, Speciality As String
            Dim x As Integer, y As Integer, PTO As String, z As Integer

            With FMain
                If Val(.Hrs.Text) < 7 Then Exit Sub
                If Val(.Hrs.Text - .Overtime.Text) > 17 Then Exit Sub

                x = .EmployeeData.Items.Count - 1

                ArtSkills = 0
                TechSkills = 0

                If .EmployeeData.Items.Count = 0 Then Exit Sub

                Do
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    If PTO = "Y" Then GoTo Next_Dev 'why work when off?

                    'the skills
                    SpeedSkills = GetEmployee(.EmployeeData.Items(x), "Speed")
                    SpeedSkills = SpeedSkills + My.Settings.EnginePts
                    ArtSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Artist") * (SpeedSkills / 100))
                    TechSkills = Math.Round(GetEmployee(.EmployeeData.Items(x), "Tech") * (SpeedSkills / 100))
                    GameSkills = Math.Round((TechSkills + ArtSkills) / 2) * (SpeedSkills / 100)

                    'ArtSkills = Math.Round(ArtSkills / .ListBox6.Items.Count)
                    ArtSkills = ArtSkills + My.Settings.ConsolePts
                    'TechSkills = Math.Round(TechSkills / .ListBox6.Items.Count)
                    TechSkills = TechSkills + My.Settings.ConsolePts

                    Speciality = GetEmployee(.EmployeeData.Items(x), "Position")

                    'for researching
                    y = GetRandom(1, My.Settings.ResearchPer)
                    If y = 1 Then
                        ArtSkills = 0
                        TechSkills = 0
                        GameSkills = 0
                    End If

                    TempProg = .RadialBar2.Value

                    'stage focus
                    Select Case .Stage.Text
                        Case Is = "Hardware Design"
                            .uCPU.Text = Math.Round(Val(.uCPU.Text) + TechSkills)
                            .uMemory.Text = Math.Round(Val(.uMemory.Text) + TechSkills)
                            .uStorage.Text = Math.Round(Val(.uStorage.Text) + TechSkills)
                        Case Is = "Software Design"
                            .uSoftware.Text = Math.Round(Val(.uSoftware.Text) + ArtSkills)
                        Case Is = "Programming"
                            .uProgramming.Text = Math.Round(Val(.uProgramming.Text) + GameSkills)
                        Case Is = "Video and Audio"
                            .uVideo.Text = Math.Round(Val(.uMemory.Text) + GameSkills)
                            .uAudio.Text = Math.Round(Val(.uAudio.Text) + GameSkills)
                        Case Is = 7

                    End Select

                    z = GetRandom(1, 8)
                    'random additions for each stage
                    Select Case z
                        Case Is = 1
                            .uCPU.Text = Math.Round(Val(.uCPU.Text) + TechSkills)
                        Case Is = 2
                            .uMemory.Text = Math.Round(Val(.uMemory.Text) + TechSkills)
                        Case Is = 3
                            .uSoftware.Text = Math.Round(Val(.uSoftware.Text) + ArtSkills)
                        Case Is = 4
                            .uProgramming.Text = Math.Round(Val(.uProgramming.Text) + GameSkills)
                        Case Is = 5
                            .uStorage.Text = Math.Round(Val(.uStorage.Text) + TechSkills)
                        Case Is = 6
                            .uVideo.Text = Math.Round(Val(.uVideo.Text) + GameSkills)
                        Case Is = 7
                            .uAudio.Text = Math.Round(Val(.uAudio.Text) + GameSkills)
                    End Select

                    'position specialties affect outcome too
                    Select Case Speciality
                        Case Is = "Artist"
                            .uVideo.Text = Val(.uMemory.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Designer"
                            .uSoftware.Text = Val(.uStorage.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Writer"
                            .uProgramming.Text = Val(.uCPU.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Programmer"
                            .uProgramming.Text = Val(.uProgramming.Text) + Math.Round(TechSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Audio"
                            .uAudio.Text = Val(.uAudio.Text) + Math.Round(ArtSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                        Case Is = "Tester"
                            .uCPU.Text = Val(.uMemory.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                            .uMemory.Text = Val(.uMemory.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                            .uStorage.Text = Val(.uMemory.Text) + Math.Round(GameSkills / GetRandom(My.Settings.SpecMin, My.Settings.SpecMax))
                    End Select

Next_Dev:
                    x = x - 1
                Loop Until x = -1

                'random events!
                If .Stage.Text <> "Video and Audio" And .RandomCounter.Text = 0 Then
                    x = GetRandom(0, My.Settings.RandomEvents)
                    If x = 1 And fRandom.Visible = False Then Call RandomEvents()
                End If

                Dim ProgressMax As Long, TotalDev As Long

                ProgressMax = 1

                'create the progress bars
                TotalDev = Math.Round(Val(.uCPU.Text) + Val(.uMemory.Text) + Val(.uAudio.Text) + Val(.uProgramming.Text) + Val(.uMemory.Text) + Val(.uStorage.Text) + Val(.uSoftware.Text))

                If TotalDev > 0 Then
                    .CPUBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .MemoryBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .SoftwareBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .ProgrammingBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .StorageBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .VideoBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)
                    .AudioBar.Maximum = Math.Round(My.Settings.ConsoleDev * .DevTeam.Text)

                    If Val(.uCPU.Text) > Val(.CPUBar.Maximum) Then .uCPU.Text = Val(.CPUBar.Maximum)
                    If Val(.uMemory.Text) > Val(.MemoryBar.Maximum) Then .uMemory.Text = Val(.MemoryBar.Maximum)
                    If Val(.uSoftware.Text) > Val(.SoftwareBar.Maximum) Then .uSoftware.Text = Val(.SoftwareBar.Maximum)
                    If Val(.uProgramming.Text) > Val(.ProgrammingBar.Maximum) Then .uProgramming.Text = Val(.ProgrammingBar.Maximum)
                    If Val(.uStorage.Text) > Val(.StorageBar.Maximum) Then .uStorage.Text = Val(.StorageBar.Maximum)
                    If Val(.uVideo.Text) > Val(.VideoBar.Maximum) Then .uVideo.Text = Val(.VideoBar.Maximum)
                    If Val(.uAudio.Text) > Val(.AudioBar.Maximum) Then .uAudio.Text = Val(.AudioBar.Maximum)

                    .CPUBar.Minimum = 1
                    .MemoryBar.Minimum = 1
                    .SoftwareBar.Minimum = 1
                    .ProgrammingBar.Minimum = 1
                    .StorageBar.Minimum = 1
                    .VideoBar.Minimum = 1
                    .AudioBar.Minimum = 1

                    If Val(.uCPU.Text) < 1 Then .CPUBar.Value = 1 Else .CPUBar.Value = Math.Round(Val(.uCPU.Text))
                    If Val(.uMemory.Text) < 1 Then .MemoryBar.Value = 1 Else .MemoryBar.Value = Math.Round(Val(.uMemory.Text))
                    If Val(.uSoftware.Text) < 1 Then .SoftwareBar.Value = 1 Else .SoftwareBar.Value = Math.Round(Val(.uSoftware.Text))
                    If Val(.uProgramming.Text) < 1 Then .ProgrammingBar.Value = 1 Else .ProgrammingBar.Value = Math.Round(Val(.uProgramming.Text))
                    If Val(.uStorage.Text) < 1 Then .StorageBar.Value = 1 Else .StorageBar.Value = Math.Round(Val(.uStorage.Text))
                    If Val(.uVideo.Text) < 1 Then .VideoBar.Value = 1 Else .VideoBar.Value = Math.Round(Val(.uVideo.Text))
                    If Val(.uAudio.Text) < 1 Then .AudioBar.Value = 1 Else .AudioBar.Value = Math.Round(Val(.uAudio.Text))

                End If

                If .RadialBar2.Value <> .RadialBar2.Maximum Then Exit Sub ' quit while you're ahead

                If .Stage.Text = "Hardware Design" Then
                    .Stage.Text = "Software Design"
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Software Design" Then
                    .Stage.Text = "Programming"
                    '.RadialBar2.Maximum = (4000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Programming" Then
                    .Stage.Text = "Video and Audio"
                    '.RadialBar2.Maximum = (7000 * ProgressMax)
                    .DevelopStages.Items.RemoveAt(0)
                    .RadialBar2.Maximum = .DevelopStages.Items(0)
                    .RadialBar2.Value = 0
                    Call SetDirection()
                    Exit Sub
                End If

                If .Stage.Text = "Video and Audio" Then
                    Call ReleaseConsole()
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub ReleaseGame() 'in progress
        Try
            Dim TheDesign As Long, TheArt As Long, TheGameplay As Long, TheReplay As Long, TheStory As Long, TheAudio As Long, TheBugs As Long
            Dim TheRating As Long, x As Integer, TheSales As Long, RatingPoints As Long
            Dim TheDiff As Long = 0

            RatingPoints = Math.Round(My.Settings.DevPoints / 10)

            With FMain
                TheDesign = Math.Round(Val(.uDesign.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheArt = Math.Round(Val(.uArt.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheGameplay = Math.Round(Val(.uGameplay.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheReplay = Math.Round(Val(.uReplay.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheStory = Math.Round(Val(.uStory.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheAudio = Math.Round(Val(.uMusic.Text) / (RatingPoints * Val(.DevTeam.Text)))
                TheBugs = .uBugs.Text

                .Develop.Checked = False
                .DevelopStages.Items.Clear()
                .AllWeeks.Text = -1
                .Stage.Text = "Release"
                .RadialBar2.Maximum = 500
                .RadialBar2.Value = 0

                Dim dig As Integer = .GameSize.Text

                If .GameSize.Text = 2 And Val(.DevTeam.Text) > 6 Then
                    TheDiff = Val(.DevTeam.Text) - 6
                    TheDesign = TheDesign - GetRandom(1, 3)
                    TheArt = TheDesign - GetRandom(1, 3)
                    TheGameplay = TheDesign - GetRandom(1, 3)
                    TheReplay = TheDesign - GetRandom(1, 3)
                    TheStory = TheDesign - GetRandom(1, 3)
                    TheAudio = TheDesign - GetRandom(1, 3)
                End If

                If .GameSize.Text = 3 And Val(.DevTeam.Text) > 10 Then
                    TheDiff = Val(.DevTeam.Text) - 10
                    TheDesign = TheDesign - GetRandom(1, 3)
                    TheArt = TheDesign - GetRandom(1, 3)
                    TheGameplay = TheDesign - GetRandom(1, 3)
                    TheReplay = TheDesign - GetRandom(1, 3)
                    TheStory = TheDesign - GetRandom(1, 3)
                    TheAudio = TheDesign - GetRandom(1, 3)
                End If

                If .GameSize.Text = 4 And Val(.DevTeam.Text) > 15 Then
                    TheDiff = Val(.DevTeam.Text) - 15
                    TheDesign = TheDesign - GetRandom(1, 3)
                    TheArt = TheDesign - GetRandom(1, 3)
                    TheGameplay = TheDesign - GetRandom(1, 3)
                    TheReplay = TheDesign - GetRandom(1, 3)
                    TheStory = TheDesign - GetRandom(1, 3)
                    TheAudio = TheDesign - GetRandom(1, 3)
                End If

            End With

            With fRelease
                If TheDesign < 1 Then TheDesign = 1
                If TheArt < 1 Then TheArt = 1
                If TheGameplay < 1 Then TheGameplay = 1
                If TheReplay < 1 Then TheReplay = 1
                If TheStory < 1 Then TheStory = 1
                If TheAudio < 1 Then TheAudio = 1
                If TheBugs < 0 Then TheBugs = 0
                If TheRating < 0 Then TheRating = 1

                .GameName.Text = FMain.GameName.Text
                .Label8.Text = FMain.ThePublisher.Text
                .Label2.Text = FMain.GameGenre.Text
                .Label4.Text = FMain.SubGenre.Text
                .Label6.Text = FMain.GameInterest.Text
                .Label10.Text = FMain.GameConsole.Text
                .LinkLabel1.Text = ""
                .LinkLabel2.Text = ""
                .LinkLabel3.Text = ""

                Select Case .Label2.Text
                    Case Is = "Action"
                        TheRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 3) + TheReplay + (TheStory * 2) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        Else
                            If TheStory < 5 Then .LinkLabel3.Text = "They note the story was rather dull."
                            If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the story was rather weak."
                            If TheStory = 7 Then .LinkLabel3.Text = "They note the story really helped the game."
                            If TheStory = 8 Then .LinkLabel3.Text = "They note the story made the game standout."
                            If TheStory > 8 Then .LinkLabel3.Text = "They note the story was incredible!"
                        End If

                    Case Is = "Adventure"
                        TheRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 2) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        ElseIf x = 2 Then
                            If TheStory < 5 Then .LinkLabel3.Text = "They note the story was rather dull."
                            If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the story was rather weak."
                            If TheStory = 7 Then .LinkLabel3.Text = "They note the story really helped the game."
                            If TheStory = 8 Then .LinkLabel3.Text = "They note the story made the game standout."
                            If TheStory > 8 Then .LinkLabel3.Text = "They note the story was incredible!"
                        ElseIf x = 3 Then
                            If TheArt < 5 Then .LinkLabel3.Text = "They note the artwork really hurt."
                            If TheArt = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the artwork was average."
                            If TheArt = 7 Then .LinkLabel3.Text = "They note the artwork really helped the game."
                            If TheArt = 8 Then .LinkLabel3.Text = "They note the artwork made the game standout."
                            If TheArt > 8 Then .LinkLabel3.Text = "They note the artwork was incredible!"
                        End If

                    Case Is = "RPG"
                        TheRating = Math.Round((TheDesign + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 3) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheStory < 5 Then .LinkLabel2.Text = "They note the story was rather dull."
                        If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the story was rather weak."
                        If TheStory = 7 Then .LinkLabel2.Text = "They note the story really helped the game."
                        If TheStory = 8 Then .LinkLabel2.Text = "They note the story made the game standout."
                        If TheStory > 8 Then .LinkLabel2.Text = "They note the story was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheArt < 5 Then .LinkLabel3.Text = "They note the art was weak."
                            If TheArt = 5 Or TheArt = 6 Then .LinkLabel3.Text = "They note the art was acceptable."
                            If TheArt = 7 Then .LinkLabel3.Text = "They note the art kept you in the world."
                            If TheArt = 8 Then .LinkLabel3.Text = "They note the art made the game standout."
                            If TheArt > 8 Then .LinkLabel3.Text = "They note the art was incredible!"
                        Else
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        End If

                    Case Is = "Simulation"
                        TheRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once or twice."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If

                    Case Is = "Strategy"
                        TheRating = Math.Round((TheDesign + TheArt + (TheGameplay * 2) + (TheReplay * 3) + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheReplay < 5 Then .LinkLabel2.Text = "They note the game was good enough to play once."
                        If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel2.Text = "They note the game was only fun for a while."
                        If TheReplay = 7 Then .LinkLabel2.Text = "They note they could sink some time in the game."
                        If TheReplay = 8 Then .LinkLabel2.Text = "They note the game kept them playing quite often."
                        If TheReplay > 8 Then .LinkLabel2.Text = "They note the game was extremely addictive!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheAudio < 5 Then .LinkLabel3.Text = "They note the audio was cheap."
                            If TheAudio = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the audio was okay."
                            If TheAudio = 7 Then .LinkLabel3.Text = "They note the audio made the game feel alive."
                            If TheAudio = 8 Then .LinkLabel3.Text = "They note the audio made the game powerful."
                            If TheAudio > 8 Then .LinkLabel3.Text = "They note the audio was incredible!"
                        End If

                    Case Is = "Casual"
                        TheRating = Math.Round(((TheDesign * 3) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheDesign < 5 Then .LinkLabel2.Text = "They note the level design was confusing."
                        If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel2.Text = "They note the level design could use some help."
                        If TheDesign = 7 Then .LinkLabel2.Text = "They note the level design helped keep the game enticing."
                        If TheDesign = 8 Then .LinkLabel2.Text = "They note the level design made the game standout above others."
                        If TheDesign > 8 Then .LinkLabel2.Text = "They note the level design was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If

                    Case Is = "Party"
                        TheRating = Math.Round((TheDesign + TheArt + (TheGameplay * 3) + (TheReplay * 3) + TheStory + TheAudio) / 10)
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        Else
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game enticing."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game standout above others."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        End If

                    Case Is = "Puzzle"
                        TheRating = Math.Round(((TheDesign * 3) + TheArt + (TheGameplay * 2) + TheReplay + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheDesign < 5 Then .LinkLabel2.Text = "They note the level design was confusing."
                        If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel2.Text = "They note the level design could use some help."
                        If TheDesign = 7 Then .LinkLabel2.Text = "They note the level design helped keep the game enticing."
                        If TheDesign = 8 Then .LinkLabel2.Text = "They note the level design made the game standout above others."
                        If TheDesign > 8 Then .LinkLabel2.Text = "They note the level design was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheAudio < 5 Then .LinkLabel3.Text = "They note the audio was cheap."
                            If TheAudio = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the audio was okay."
                            If TheAudio = 7 Then .LinkLabel3.Text = "They note the audio made the game feel alive."
                            If TheAudio = 8 Then .LinkLabel3.Text = "They note the audio made the game more fun."
                            If TheAudio > 8 Then .LinkLabel3.Text = "They note the audio was incredible!"
                        End If

                    Case Is = "Sports"
                        TheRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 3) + (TheReplay * 2) + TheStory + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the game design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the game design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the game design helped keep the game enticing."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the game design made the game standout above others."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the game design was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If
                End Select

                .LinkLabel1.Text = "The magazine average gives you an overall rating of " & TheRating & "."

                If TheBugs > 25 Then
                    TheRating = TheRating - (TheBugs * 10)
                    If TheRating < 0 Then TheRating = 1
                    .LinkLabel3.Text = "The amount of bugs really hurt the outcome."
                End If

                If TheDiff > 0 Then .LinkLabel3.Text = "A studio this size should've produced a better quality product."

                'sales based off rating
                If TheRating = 10 Then TheSales = GetRandom(10000000, 30000000)
                If TheRating = 9 Then TheSales = GetRandom(700000, 6000000)
                If TheRating = 8 Then TheSales = GetRandom(500000, 5000000)
                If TheRating = 7 Then TheSales = GetRandom(120000, 1000000)
                If TheRating = 6 Then TheSales = GetRandom(70000, 500000)
                If TheRating = 5 Then TheSales = GetRandom(30000, 300000)
                If TheRating < 5 Then TheSales = GetRandom(1000, 80000)

                'If the genre is a trend, then boost sales a little
                If FMain.Trend.Text = .Label2.Text Or FMain.Trend.Text = .Label4.Text Then
                    x = GetRandom(1, 5)
                    Select Case x
                        Case Is = 1
                            TheSales = Math.Round(TheSales * 1.3)
                        Case Is = 2
                            TheSales = Math.Round(TheSales * 1.2)
                        Case Is = 3
                            TheSales = Math.Round(TheSales * 1.2)
                        Case Is = 4
                            TheSales = Math.Round(TheSales * 1.1)
                        Case Is = 5
                            TheSales = Math.Round(TheSales * 1.1)
                    End Select
                End If

                'enter marketing here.
                If Val(FMain.Marketing.Text) < My.Settings.MarketingThreshold Then FMain.Marketing.Text = Val(FMain.Marketing.Text) + My.Settings.MarketingThreshold 'less than 10? well sell something...
                If FMain.ThePublisher.Text <> "Self" And Val(FMain.Marketing.Text) < My.Settings.PublisherAdvantage Then FMain.Marketing.Text = My.Settings.PublisherAdvantage

                Dim taco As Double = FMain.Marketing.Text
                TheSales = Math.Round(TheSales * (taco / My.Settings.MarketingFactor))

                'GetGame = TheCompany & "," & TheGame & "," & TheGenre & "," & TheDesign & "," & TheArt & "," & TheGameplay & "," & TheStory & "," & TheReplay & "," & TheAudio & "," & TheBugs & "," & TheRating & "," & TheConsole & "," & ReleaseDate & "," & TheSales & "," & PrevSales
                'Company Name,Game Name,Genre,Design,Art,Gameplay,Story,Replay,Audio,Bugs,Rating,Console,ReleaseDate,Sales,PreviousSales
                .FullGame.Text = FMain.YourCo.Text & "," & .GameName.Text & "," & .Label2.Text & "," & TheDesign & "," & TheArt & "," & TheGameplay & "," & TheStory & "," & TheReplay & "," & TheAudio & "," & TheBugs & "," & TheRating & "," & .Label10.Text & ",1," & TheSales & "," & TheSales

                'Form1.NewsList.Items.Insert(0, Form1.YourCo.Text & " just released " & .GameName.Text & " with an overall rating of " & TheRating)
                'Form1.NewGames.Items.Add(.FullGame.Text)

                'reputation
                .RepPoints.Text = 0
                If TheRating = 10 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(100, 150))
                If TheRating = 9 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(75, 100))
                If TheRating = 8 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(50, 75))
                If TheRating = 7 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(25, 50))
                If TheRating = 6 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(10, 25))
                If TheRating = 5 Then .RepPoints.Text = Math.Round(.RepPoints.Text + GetRandom(1, 10))
                If TheRating = 4 Then .RepPoints.Text = Math.Round(.RepPoints.Text - GetRandom(1, 10))
                If TheRating = 3 Then .RepPoints.Text = Math.Round(.RepPoints.Text - GetRandom(10, 50))
                If TheRating = 2 Then .RepPoints.Text = Math.Round(.RepPoints.Text - GetRandom(50, 150))
                If TheRating = 1 Then .RepPoints.Text = Math.Round(.RepPoints.Text - GetRandom(150, 300))

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With

            With FMain
                .Timer1.Enabled = False

                'trendsetter!
                x = GetRandom(1, My.Settings.TrendSetter)
                If TheRating >= 9 And x = 1 Then
                    x = GetRandom(1, 3)
                    If x = 1 Then
                        .NewsList.Items.Insert(0, "Due to the popularity of your game, you have set a new genre trend: " & .GameGenre.Text)
                        .Trend.Text = fRelease.Label2.Text
                    Else
                        .Trend.Text = .SubGenre.Text
                        .NewsList.Items.Insert(0, "Due to the popularity of your game, you have set a new subgenre trend: " & .SubGenre.Text)
                    End If
                End If

                'contracted publisher
                x = -1
                Select Case TheRating
                    Case Is = 7
                        x = GetRandom(1, (My.Settings.FullPublisher * 2))
                    Case Is = 8
                        x = GetRandom(1, (My.Settings.FullPublisher * 1.5))
                    Case Is = 9
                        x = GetRandom(1, (My.Settings.FullPublisher * 1.25))
                    Case Is = 10
                        x = GetRandom(1, My.Settings.FullPublisher)
                End Select

                If x = 1 Then
                    Dim temp As MsgBoxResult = MsgBox(.ThePublisher.Text & " would like to be your permanent publisher that will take 25-40% of the cut and provide a typically larger downpayment. Interested?", MsgBoxStyle.YesNo)

                    If temp = MsgBoxResult.Yes Then
                        .SetPublisher.Checked = True
                        .SetPublisher.Text = .ThePublisher.Text
                    End If
                End If
            End With
        Catch ex As Exception
            WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub ReleasePubGame(TheData As String)
        Dim TheDesign As Long, TheArt As Long, TheGameplay As Long, TheReplay As Long, TheStory As Long, TheAudio As Long, TheBugs As Long, TheCO As String
        Dim TheRating As Long, x As Integer
        Dim TheDiff As Long = 0

        Try
            FMain.Timer1.Enabled = False

            With fPub_Marketing
                .FullGame.Text = TheData
                TheCO = GetGame(TheData, "Company")
                .Label15.Text = TheCO
                .GameName.Text = GetGame(TheData, "Name")
                .Label11.Text = GetGame(TheData, "Console")
                .Label14.Text = GetGame(TheData, "Genre")

                'interest
                x = GetRandom(1, 14)
                Dim TheInterest() As String = {"Drama", "Fairy Tale", "Fantasy", "Fiction", "Folklore", "History", "Horror", "Humor", "Legend", "Mystery", "Mythology", "Realistic Fiction", "Science Fiction", "Tall Tale"}
                .Label19.Text = TheInterest(x)

                .DotNetBarTabcontrol1.SelectTab(0)

                TheDesign = Math.Round(GetGame(TheData, "Design") / 100)
                TheArt = Math.Round(GetGame(TheData, "Art") / 100)
                TheGameplay = Math.Round(GetGame(TheData, "Gameplay") / 100)
                TheReplay = Math.Round(GetGame(TheData, "Replay") / 100)
                TheStory = Math.Round(GetGame(TheData, "Story") / 100)
                TheAudio = Math.Round(GetGame(TheData, "Audio") / 100)
                TheBugs = Math.Round(GetGame(TheData, "Bugs") / 100)

                If TheRating < 0 Then TheRating = 1

                Select Case .Label14.Text
                    Case Is = "Action"
                        TheRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 3) + TheReplay + (TheStory * 2) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        Else
                            If TheStory < 5 Then .LinkLabel3.Text = "They note the story was rather dull."
                            If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the story was rather weak."
                            If TheStory = 7 Then .LinkLabel3.Text = "They note the story really helped the game."
                            If TheStory = 8 Then .LinkLabel3.Text = "They note the story made the game standout."
                            If TheStory > 8 Then .LinkLabel3.Text = "They note the story was incredible!"
                        End If

                    Case Is = "Adventure"
                        TheRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 2) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        ElseIf x = 2 Then
                            If TheStory < 5 Then .LinkLabel3.Text = "They note the story was rather dull."
                            If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the story was rather weak."
                            If TheStory = 7 Then .LinkLabel3.Text = "They note the story really helped the game."
                            If TheStory = 8 Then .LinkLabel3.Text = "They note the story made the game standout."
                            If TheStory > 8 Then .LinkLabel3.Text = "They note the story was incredible!"
                        ElseIf x = 3 Then
                            If TheArt < 5 Then .LinkLabel3.Text = "They note the artwork really hurt."
                            If TheArt = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the artwork was average."
                            If TheArt = 7 Then .LinkLabel3.Text = "They note the artwork really helped the game."
                            If TheArt = 8 Then .LinkLabel3.Text = "They note the artwork made the game standout."
                            If TheArt > 8 Then .LinkLabel3.Text = "They note the artwork was incredible!"
                        End If

                    Case Is = "RPG"
                        TheRating = Math.Round((TheDesign + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 3) + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheStory < 5 Then .LinkLabel2.Text = "They note the story was rather dull."
                        If TheStory = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the story was rather weak."
                        If TheStory = 7 Then .LinkLabel2.Text = "They note the story really helped the game."
                        If TheStory = 8 Then .LinkLabel2.Text = "They note the story made the game standout."
                        If TheStory > 8 Then .LinkLabel2.Text = "They note the story was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheArt < 5 Then .LinkLabel3.Text = "They note the art was weak."
                            If TheArt = 5 Or TheArt = 6 Then .LinkLabel3.Text = "They note the art was acceptable."
                            If TheArt = 7 Then .LinkLabel3.Text = "They note the art kept you in the world."
                            If TheArt = 8 Then .LinkLabel3.Text = "They note the art made the game standout."
                            If TheArt > 8 Then .LinkLabel3.Text = "They note the art was incredible!"
                        Else
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        End If

                    Case Is = "Simulation"
                        TheRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game challenging."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game a lot of fun."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once or twice."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If

                    Case Is = "Strategy"
                        TheRating = Math.Round((TheDesign + TheArt + (TheGameplay * 2) + (TheReplay * 3) + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheReplay < 5 Then .LinkLabel2.Text = "They note the game was good enough to play once."
                        If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel2.Text = "They note the game was only fun for a while."
                        If TheReplay = 7 Then .LinkLabel2.Text = "They note they could sink some time in the game."
                        If TheReplay = 8 Then .LinkLabel2.Text = "They note the game kept them playing quite often."
                        If TheReplay > 8 Then .LinkLabel2.Text = "They note the game was extremely addictive!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheAudio < 5 Then .LinkLabel3.Text = "They note the audio was cheap."
                            If TheAudio = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the audio was okay."
                            If TheAudio = 7 Then .LinkLabel3.Text = "They note the audio made the game feel alive."
                            If TheAudio = 8 Then .LinkLabel3.Text = "They note the audio made the game powerful."
                            If TheAudio > 8 Then .LinkLabel3.Text = "They note the audio was incredible!"
                        End If

                    Case Is = "Casual"
                        TheRating = Math.Round(((TheDesign * 3) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheDesign < 5 Then .LinkLabel2.Text = "They note the level design was confusing."
                        If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel2.Text = "They note the level design could use some help."
                        If TheDesign = 7 Then .LinkLabel2.Text = "They note the level design helped keep the game enticing."
                        If TheDesign = 8 Then .LinkLabel2.Text = "They note the level design made the game standout above others."
                        If TheDesign > 8 Then .LinkLabel2.Text = "They note the level design was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If

                    Case Is = "Party"
                        TheRating = Math.Round((TheDesign + TheArt + (TheGameplay * 3) + (TheReplay * 3) + TheStory + TheAudio) / 10)
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        Else
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the level design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the level design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the level design helped keep the game enticing."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the level design made the game standout above others."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the level design was incredible!"
                        End If

                    Case Is = "Puzzle"
                        TheRating = Math.Round(((TheDesign * 3) + TheArt + (TheGameplay * 2) + TheReplay + TheStory + (TheAudio * 2)) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheDesign < 5 Then .LinkLabel2.Text = "They note the level design was confusing."
                        If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel2.Text = "They note the level design could use some help."
                        If TheDesign = 7 Then .LinkLabel2.Text = "They note the level design helped keep the game enticing."
                        If TheDesign = 8 Then .LinkLabel2.Text = "They note the level design made the game standout above others."
                        If TheDesign > 8 Then .LinkLabel2.Text = "They note the level design was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheGameplay < 5 Then .LinkLabel3.Text = "They note the gameplay was boring."
                            If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the gameplay was okay."
                            If TheGameplay = 7 Then .LinkLabel3.Text = "They note the gameplay really helped the game."
                            If TheGameplay = 8 Then .LinkLabel3.Text = "They note the gameplay made the game standout."
                            If TheGameplay > 8 Then .LinkLabel3.Text = "They note the gameplay was incredible!"
                        Else
                            If TheAudio < 5 Then .LinkLabel3.Text = "They note the audio was cheap."
                            If TheAudio = 5 Or TheGameplay = 6 Then .LinkLabel3.Text = "They note the audio was okay."
                            If TheAudio = 7 Then .LinkLabel3.Text = "They note the audio made the game feel alive."
                            If TheAudio = 8 Then .LinkLabel3.Text = "They note the audio made the game more fun."
                            If TheAudio > 8 Then .LinkLabel3.Text = "They note the audio was incredible!"
                        End If

                    Case Is = "Sports"
                        TheRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 3) + (TheReplay * 2) + TheStory + TheAudio) / 10)
                        If TheRating < 1 Then TheRating = 1
                        If TheGameplay < 5 Then .LinkLabel2.Text = "They note the gameplay was boring."
                        If TheGameplay = 5 Or TheGameplay = 6 Then .LinkLabel2.Text = "They note the gameplay was okay."
                        If TheGameplay = 7 Then .LinkLabel2.Text = "They note the gameplay really helped the game."
                        If TheGameplay = 8 Then .LinkLabel2.Text = "They note the gameplay made the game standout."
                        If TheGameplay > 8 Then .LinkLabel2.Text = "They note the gameplay was incredible!"

                        x = GetRandom(1, 3)
                        If x = 1 Then
                            If TheDesign < 5 Then .LinkLabel3.Text = "They note the game design was confusing."
                            If TheDesign = 5 Or TheDesign = 6 Then .LinkLabel3.Text = "They note the game design could use some help."
                            If TheDesign = 7 Then .LinkLabel3.Text = "They note the game design helped keep the game enticing."
                            If TheDesign = 8 Then .LinkLabel3.Text = "They note the game design made the game standout above others."
                            If TheDesign > 8 Then .LinkLabel3.Text = "They note the game design was incredible!"
                        Else
                            If TheReplay < 5 Then .LinkLabel3.Text = "They note the game was good enough to play once."
                            If TheReplay = 5 Or TheReplay = 6 Then .LinkLabel3.Text = "They note the game was only fun for a while."
                            If TheReplay = 7 Then .LinkLabel3.Text = "They note they could sink some time in the game."
                            If TheReplay = 8 Then .LinkLabel3.Text = "They note the game kept them playing quite often."
                            If TheReplay > 8 Then .LinkLabel3.Text = "They note the game was extremely addictive!"
                        End If
                End Select

                .LinkLabel1.Text = "The magazine average gives an overall rating of " & TheRating & "."

                If TheBugs > 25 Then
                    TheRating = TheRating - (TheBugs * 10)
                    If TheRating < 0 Then TheRating = 1
                    .LinkLabel3.Text = "The amount of bugs really hurt the outcome."
                End If

                'fill combo
                .ComboBox1.Items.Clear()

                If Val(FMain.TheYear.Text) < 2000 Then
                    .ComboBox1.Items.Add("Magazine")
                    .ComboBox1.Items.Add("Radio")
                    .ComboBox1.Items.Add("Television")
                Else
                    .ComboBox1.Items.Add("Magazine")
                    .ComboBox1.Items.Add("Radio")
                    .ComboBox1.Items.Add("Review Sites")
                    .ComboBox1.Items.Add("Social Media")
                    .ComboBox1.Items.Add("Television")
                    .ComboBox1.Items.Add("Trailer")
                End If

                .Label9.Text = 0
                .Label10.Text = 0


                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub ReleaseEngine()
        'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
        Dim TheName As String, ConsoleName As String, TechLevel As Long, Usability As Long
        Dim ThePrice As Integer
        Dim x As Integer, temp As String

        Try
            With fNewEngine
                ConsoleName = FMain.EngConsole.Text
                TheName = FMain.EngName.Text
            End With

            With FMain
                .Timer1.Enabled = False
                TechLevel = Math.Round(Val(.uInput.Text) + Val(.uGraphics.Text) + Val(.uSound.Text) + Val(.uNetwork.Text) + Val(.uPhysics.Text)) / 5
                Usability = Math.Round(Val(.uGUI.Text) + Val(.uScripts.Text)) / 2

                TechLevel = Math.Round((TechLevel / (My.Settings.EngineDev * .DevTeam.Text)) * 100)
                Usability = Math.Round((Usability / (My.Settings.EngineDev * .DevTeam.Text)) * 100)

                If TechLevel < 25 Or Usability < 25 Then 'give a little boost
                    TechLevel = TechLevel + GetRandom(1, 10)
                    Usability = Usability + GetRandom(1, 10)
                End If

                'determine price based on usability and techlevel
                x = GetRandom(2, 10)

                If x = 10 Then
                    ThePrice = (TechLevel + Usability) * 1
                Else
                    temp = "1." & x
                    temp = Int(TechLevel + Usability) * Val(temp)
                    temp = Math.Round(Int(temp) / 5) * 5
                    ThePrice = Val(temp) * 10
                End If

                .Panel3.Visible = False
            End With

            Dim QryMsg As String = MsgBox("Your released engine, " & TheName & ", was released with the following ratings:" & vbNewLine & "Technical level: " & TechLevel & vbNewLine & "Usability level: " & Usability & vbNewLine & "It has been determined that your engine will sell for " & FormatCurrency(ThePrice, 0), MsgBoxStyle.Information)

            With FMain
                If QryMsg = vbOK Then 'relieves freeze of game 
                    'Name,Console,Company,Tech#,Useability,Price,ReleaseDate
                    FMain.NewEngines.Items.Add(TheName & "," & ConsoleName & "," & FMain.YourCo.Text & "," & TechLevel & "," & Usability & "," & ThePrice & ",1")

                    .DevelopStages.Items.Clear()
                    .Stage.Text = "Idle"
                    .Engine.Checked = False
                    .RadialBar1.Value = 0
                    .RadialBar2.Value = 0
                    .Panel2.Visible = False
                    .Panel3.Visible = False
                    .Panel4.Visible = False
                    .Timer1.Enabled = True
                End If
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub NewConsole()
        Dim TheWe As Long

        Try
            TheWe = Math.Round(FMain.Cash.Text / Expenses())
            If TheWe < 208 Then
                Call MsgBox("You should spend at least 4 years developing an engine. Based on your cash level and expenses you're unable to do so.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            With FNewConsole
                .ConsoleName.Text = ""
                .HScrollBar1.Value = 260
                .TextBox1.Text = 260

                .TrackBar2.Value = 65
                .TrackBar3.Value = 65
                .TrackBar4.Value = 65
                .BaWGUITrackBar1.Value = 65
                .DefinedWeeks.Text = 260

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub ReleaseConsole()
        'Company, ConsoleName, TechLevel, ReleaseDate, Retired, Cost, Price, Sales, PreviousSales
        Dim TechLevel As Long, TheCost As Long, ThePrice As Long, tmp As Double, TheMonth As Integer

        Try
            FMain.Timer1.Enabled = False

            With fReleaseConsole
                'initial data
                .lbl_ConsoleName.Text = FMain.ConsoleName.Text

                'set the month
                Select Case FMain.TheMonth.Text
                    Case Is = "January"
                        TheMonth = 1
                    Case Is = "February"
                        TheMonth = 2
                    Case Is = "March"
                        TheMonth = 3
                    Case Is = "April"
                        TheMonth = 4
                    Case Is = "May"
                        TheMonth = 5
                    Case Is = "June"
                        TheMonth = 6
                    Case Is = "July"
                        TheMonth = 7
                    Case Is = "August"
                        TheMonth = 8
                    Case Is = "September"
                        TheMonth = 9
                    Case Is = "October"
                        TheMonth = 10
                    Case Is = "November"
                        TheMonth = 11
                    Case Is = "December"
                        TheMonth = 12
                End Select

                TheMonth = TheMonth + GetRandom(3, 5)
                If TheMonth > 12 Then TheMonth = TheMonth - 12
                .BaWGUITrackBar1.Value = TheMonth

                Select Case TheMonth
                    Case Is = 1
                        .lbl_ReleaseDate.Text = "January"
                    Case Is = 2
                        .lbl_ReleaseDate.Text = "February"
                    Case Is = 3
                        .lbl_ReleaseDate.Text = "March"
                    Case Is = 4
                        .lbl_ReleaseDate.Text = "April"
                    Case Is = 5
                        .lbl_ReleaseDate.Text = "May"
                    Case Is = 6
                        .lbl_ReleaseDate.Text = "June"
                    Case Is = 7
                        .lbl_ReleaseDate.Text = "July"
                    Case Is = 8
                        .lbl_ReleaseDate.Text = "August"
                    Case Is = 9
                        .lbl_ReleaseDate.Text = "September"
                    Case Is = 10
                        .lbl_ReleaseDate.Text = "October"
                    Case Is = 11
                        .lbl_ReleaseDate.Text = "November"
                    Case Is = 12
                        .lbl_ReleaseDate.Text = "December"
                End Select

                'tech level
                TechLevel = (Val(FMain.uCPU.Text) + Val(FMain.uMemory.Text) + Val(FMain.uSoftware.Text) + Val(FMain.uProgramming.Text) + Val(FMain.uStorage.Text) + Val(FMain.uVideo.Text) + Val(FMain.uAudio.Text)) / 7
                TechLevel = Math.Round((TechLevel / (My.Settings.ConsoleDev * FMain.DevTeam.Text)) * 100)

                If TechLevel < 25 Then 'give a little boost
                    TechLevel = TechLevel + GetRandom(1, 10)
                End If

                .SlcProgrssBar1.Value = TechLevel

                'determine cost based on techlevel
                tmp = "1." & GetRandom(1, 9)
                TheCost = Math.Round(TechLevel * tmp)
                .lbl_Cost.Text = TheCost

                'determine price based on cost
                tmp = GetRandom(1, 3) & "." & GetRandom(2, 9)
                ThePrice = Math.Round(TheCost * tmp)
                If ThePrice > 1000 Then ThePrice = 1000
                ThePrice = ThePrice / 25
                ThePrice = Math.Round((ThePrice + 1) * 25)

                .lbl_Price.Text = ThePrice

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try


    End Sub
    Public Sub RunEmployees() 'in progress
        ''Name,Position,Pay,Artistry,ArtPotential,Tech,TechPotential,Speed,SpeedPotential,Happiness,Stress,StressMax,TheSeat,TheImage
        Dim ThePay As Long, TheArt As Integer, ArtPot As Integer, Tech As Integer, TechPot As Integer, TheSpeed As Integer, SpeedMax As Integer, Happy As Integer, Stress As Integer, StressMax As Integer, PTO As String
        Dim TheName As String, TheSeat As Integer
        Dim x As Integer, TotalStre As Integer

        Try
            With FMain
                If Val(.Hrs.Text) = 12 Then fPTO.ListBox1.Items.Clear() 'clear PTO requests ahead of time

                x = .EmployeeData.Items.Count - 1


                Do
                    If x = -1 Then Exit Sub

                    'definitions
                    TheName = GetEmployee(.EmployeeData.Items(x), "Name")
                    ThePay = GetEmployee(.EmployeeData.Items(x), "Salary")
                    TheArt = GetEmployee(.EmployeeData.Items(x), "Artist")
                    ArtPot = GetEmployee(.EmployeeData.Items(x), "ArtistMax")
                    Tech = GetEmployee(.EmployeeData.Items(x), "Tech")
                    TechPot = GetEmployee(.EmployeeData.Items(x), "TechMax")
                    TheSpeed = GetEmployee(.EmployeeData.Items(x), "Speed")
                    SpeedMax = GetEmployee(.EmployeeData.Items(x), "SpeedMax")
                    Happy = GetEmployee(.EmployeeData.Items(x), "Happiness")
                    Stress = GetEmployee(.EmployeeData.Items(x), "Stress")
                    StressMax = GetEmployee(.EmployeeData.Items(x), "StressMax")
                    PTO = GetEmployee(.EmployeeData.Items(x), "PTO")
                    TheSeat = GetEmployee(.EmployeeData.Items(x), "Seat")

                    'help them heal if they're off - then move out
                    If Stress < 1 Then Stress = 1
                    If PTO = "Y" Then 'PTO kicks ass
                        Stress = Stress - GetRandom(My.Settings.MinStressOT, My.Settings.MinStressOT)
                        If Stress < 1 Then Stress = 1
                        .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress)

                        If Stress < Math.Round(StressMax * My.Settings.StressReturn) And Val(.Hrs.Text) = 7 Then 'return from PTO 
                            .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "PTO", "N")
                        Else
                            GoTo MoveOn_EXP
                        End If
                    End If
                    If Val(.Hrs.Text) < 7 Then
                        If Stress > 0 Then .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress - 1)
                        GoTo MoveOn_EXP
                    End If
                    If Val(.Hrs.Text - .Overtime.Text) > 17 Then
                        If Stress > 0 Then .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress - 1)
                        GoTo MoveOn_EXP
                    End If
                    If .Develop.Checked = False Then
                        If Stress > 0 Then .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress - 1)
                        GoTo MoveOn_EXP
                    End If

                    'adjust player's salary
                    If x = 0 Then
                        .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Salary", GetAvgSalary())
                        ThePay = GetEmployee(.EmployeeData.Items(x), "Salary")
                    End If

                    'stressing them out
                    TotalStre = TheArt + Tech + TheSpeed
                    If TotalStre >= 150 Then 'skillset is average
                        Stress = Stress + GetRandom(My.Settings.MinStressNorm, My.Settings.MaxStressNorm)
                        If ThePay < GetAvgSalary() Then .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress) 'lower than average pay hurts
                    End If

                    Stress = Stress + GetRandom(My.Settings.RegMinStress, My.Settings.RegMaxStress)

                    If Val(.Hrs.Text) > 17 Then 'overtime is a bitch
                        Stress = Stress + GetRandom(My.Settings.MinStressOT, My.Settings.MaxStressOT)
                        .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", Stress)
                    End If


                    'gain experience, only monthly
                    If Val(.Hrs.Text) = 8 And Val(.TheWeek.Text) = 1 Then
                        If TheArt < ArtPot Then
                            TheArt = TheArt + GetRandom(My.Settings.MinEXPGain, My.Settings.MaxEXPGain)
                            If TheArt > ArtPot Then TheArt = ArtPot
                            .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Artist", TheArt)
                        End If

                        If Tech < TechPot Then
                            Tech = TechPot + GetRandom(My.Settings.MinEXPGain, My.Settings.MaxEXPGain)
                            If Tech > TechPot Then Tech = TechPot
                            .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Tech", Tech)
                        End If

                        If TheSpeed < SpeedMax Then
                            TheSpeed = SpeedMax + GetRandom(My.Settings.MinEXPGain, My.Settings.MaxEXPGain)
                            If TheSpeed > TechPot Then TheSpeed = SpeedMax
                            .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Speed", TheSpeed)
                        End If
                    End If

                    'PTO request 
                    If Stress > Math.Round(StressMax * My.Settings.PTORequest) And PTO = "N" And Val(.Hrs.Text) = 12 Then
                        If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.sound_event, AudioPlayMode.Background)
                        fPTO.Show()
                        fPTO.ListBox1.Items.Insert(0, Str(x)) 'adds employee x to listbox for pto requests
                        fPTO.Label1.Text = GetEmployee(.EmployeeData.Items(x), "Name") & " would like to request some time off."
                    End If

                    'move off PTO
                    'If PTO = "Y" And Stress < Math.Round(StressMax * My.Settings.StressReturn) Then .ListBox6.Items(x) = GetEmployee(.ListBox6.Items(x), "PTO", "N")

                    'quit if over-stressed
                    If Stress > StressMax And Val(.Hrs.Text) = 20 Then
                        Happy = Happy - 1
                        If Happy < 1 Then
                            Call Termination("Quit", TheName, TheSeat)
                            .EmployeeData.Items.RemoveAt(x)
                        End If
                    End If

                    'quit if really underpaid
                    If ThePay < (GetAvgSalary() * My.Settings.EmployeePayThreshold) And Stress > Math.Round(StressMax * My.Settings.PTORequest) And Val(.Hrs.Text) = 20 Then
                        Happy = Happy - 1
                        If Happy < 1 Then
                            Call Termination("Quit", TheName, TheSeat)
                            .EmployeeData.Items.RemoveAt(x)
                        End If
                    End If

MoveOn_EXP:
                    x = x - 1
                Loop Until x = 0

                .EmployeeData.Update()
                .EmployeeSalaries.Update()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub Termination(TheReason As String, TheName As String, TheSeat As Integer)
        Try
            Select Case TheReason
                Case Is = "Quit"
                    FMain.NewsList.Items.Insert(0, TheName & " has quit the company!")
                Case Is = "Fired"
                    FMain.NewsList.Items.Insert(0, TheName & " was fired.")
                Case Is = "Died"
                    FMain.NewsList.Items.Insert(0, TheName & " has died.")
            End Select

            Select Case TheSeat
                Case Is = 0
                    Call EndGame("Suicide")
                Case Is = 2
                    FMain.PictureBox2.Image = Nothing
                Case Is = 3
                    FMain.PictureBox3.Image = Nothing
                Case Is = 4
                    FMain.PictureBox4.Image = Nothing
                Case Is = 5
                    FMain.PictureBox5.Image = Nothing
                Case Is = 6
                    FMain.PictureBox6.Image = Nothing
                Case Is = 7
                    FMain.PictureBox7.Image = Nothing
                Case Is = 8
                    FMain.PictureBox8.Image = Nothing
                Case Is = 9
                    FMain.PictureBox9.Image = Nothing
                Case Is = 10
                    FMain.PictureBox10.Image = Nothing
                Case Is = 11
                    FMain.PictureBox11.Image = Nothing
                Case Is = 12
                    FMain.PictureBox12.Image = Nothing
                Case Is = 13
                    FMain.PictureBox13.Image = Nothing
                Case Is = 14
                    FMain.PictureBox14.Image = Nothing
                Case Is = 15
                    FMain.PictureBox15.Image = Nothing
                Case Is = 16
                    FMain.PictureBox16.Image = Nothing
                Case Is = 17
                    FMain.PictureBox17.Image = Nothing
                Case Is = 18
                    FMain.PictureBox18.Image = Nothing
                Case Is = 19
                    FMain.PictureBox19.Image = Nothing
                Case Is = 20
                    FMain.PictureBox20.Image = Nothing
                Case Is = 21
                    FMain.PictureBox21.Image = Nothing
            End Select
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Function GetRating(TheDesign As Long, TheArt As Long, TheGameplay As Long, TheReplay As Long, TheStory As Long, TheAudio As Long, TheBugs As Long, Genre As String) As Integer
        'Action, RPG, Simulation, Strategy, Casual, Party, Puzzle, Sports

        '!!!!!!!!!!!!!!!!!! Update the ReleaseGame function if this is updated!!!!!!!!!!!!!!!!!!!!!!!
        Select Case Genre
            Case Is = "Action"
                GetRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 3) + TheReplay + (TheStory * 2) + TheAudio) / 10)
            Case Is = "Adventure"
                GetRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 2) + TheAudio) / 10)
            Case Is = "RPG"
                GetRating = Math.Round((TheDesign + (TheArt * 2) + (TheGameplay * 2) + TheReplay + (TheStory * 3) + TheAudio) / 10)
            Case Is = "Simulation"
                GetRating = Math.Round(((TheDesign * 2) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + (TheAudio * 2)) / 10)
            Case Is = "Strategy"
                GetRating = Math.Round((TheDesign + TheArt + (TheGameplay * 2) + (TheReplay * 3) + TheStory + (TheAudio * 2)) / 10)
            Case Is = "Casual"
                GetRating = Math.Round(((TheDesign * 3) + TheArt + (TheGameplay * 2) + (TheReplay * 2) + TheStory + TheAudio) / 10)
            Case Is = "Party"
                GetRating = Math.Round((TheDesign + TheArt + (TheGameplay * 3) + (TheReplay * 3) + TheStory + TheAudio) / 10)
            Case Is = "Puzzle"
                GetRating = Math.Round(((TheDesign * 3) + TheArt + TheGameplay + TheReplay + (TheStory * 3) + TheAudio) / 10)
            Case Is = "Sports"
                GetRating = Math.Round(((TheDesign * 2) + (TheArt * 2) + (TheGameplay * 3) + (TheReplay * 2) + TheStory + TheAudio) / 10)
        End Select


        'bugs affect the rating
        If TheBugs > 9 Then GetRating = GetRating - (TheBugs * 10)
        GetRating = Math.Round(GetRating / 100)

        If GetRating <= 0 Then GetRating = 1

        Return GetRating
    End Function
    Public Function Challenges(Optional ByVal TotalSales As Long = 0) As Long
        Dim x As Integer, y As Long

        With FMain
            Dim TotalCash As Long = .Cash.Text
            Dim Weeks As Long = Math.Round(TotalCash / Expenses())

            For Each itm In FMain.Investments.Items
                TotalCash = TotalCash + GetInvestments(itm, "Dollar")
            Next

            If Weeks >= 52 And Weeks < 78 Then
                y = GetRandom(1, My.Settings.ChallengeFreq1)
            End If
            If Weeks >= 78 And Weeks < 104 Then
                y = GetRandom(1, My.Settings.ChallengeFreq2)
            End If
            If Weeks >= 104 Then
                y = GetRandom(1, My.Settings.ChallengeFreq3)
            End If

            If y <> 1 Then
                Challenges = TotalSales
                Exit Function
            End If

            Challenges = TotalSales - Math.Round(TotalSales * (GetRandom(25, 50) / 100))

            x = GetRandom(1, 5)
            'depending on how much money the company has, they're susceptible to sabotage, piracy, boycotts

            Select Case x
                Case Is = 1
                    .NewsList.Items.Insert(0, "Due to sales sabotage by a competitor, your sales have reduced from " & FormatNumber(TotalSales, 0) & " to " & FormatNumber(Challenges, 0))
                Case Is = 2
                    .NewsList.Items.Insert(0, "Piracy skyrocketed and reduced your sales from " & FormatNumber(TotalSales, 0) & " to " & FormatNumber(Challenges, 0))
                Case Is = 3
                    .NewsList.Items.Insert(0, "A group of people found your game offensive and boycotting brought sales down from " & FormatNumber(TotalSales, 0) & " to " & FormatNumber(Challenges, 0))
                Case Is = 4
                    .NewsList.Items.Insert(0, "Poor advertising has backfired. You lost " & FormatNumber(TotalSales, 0) & " sales.")
                Case Is = 5
                    .NewsList.Items.Insert(0, "Poor advertising has backfired. You lost " & FormatNumber(TotalSales, 0) & " sales.")
            End Select
        End With

    End Function
    Public Sub Challenge()
        Try
            Dim x As Integer, y As Integer, TheChe As Integer, Dollars As Long

            TheChe = GetRandom(1, 191)

            With FMain

                'team quits
                If TheChe > 0 And TheChe <= 10 And .EmployeeData.Items.Count > 2 Then
                    x = GetRandom(1, .EmployeeData.Items.Count - 1)
                    If .EmployeeData.Items.Count > x And .EmployeeData.Items.Count >= 2 Then x = .EmployeeData.Items.Count - 1

                    If x = 1 Then
                        Call MsgBox("An employee has left due to disagreements with management.", MsgBoxStyle.Exclamation)
                    Else
                        Call MsgBox("A group of employees have left due to internal issues.", MsgBoxStyle.Information)
                    End If

                    Do
                        y = .EmployeeData.Items.Count - 1
                        y = GetRandom(1, y)
                        .NewsList.Items.Insert(0, "Due to internal issues " & GetEmployee(.EmployeeData.Items(y), "Name") & " has left the studio.")
                        .EmployeeData.Items.RemoveAt(y)
                        x = x - 1
                    Loop Until x = 1

                End If

                'feature creep!
                If TheChe > 10 And TheChe <= 20 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("The infamous feature creep has caused your development to get delayed.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'technology change
                If TheChe > 20 And TheChe <= 30 Then
                    If .Develop.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A quick change in technology for the " & .GameConsole.Text & " console has delayed your development.", MsgBoxStyle.Information)
                    ElseIf .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A quick change in technology for the " & .EngConsole.Text & " console has delayed your development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'licensing issues
                If TheChe > 30 And TheChe <= 40 Then
                    If .Develop.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A legal change in licensing for " & .GameConsole.Text & " has caused a delay for development.", MsgBoxStyle.Information)
                    ElseIf .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A legal change in licensing for " & .EngConsole.Text & " has caused a delay for development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'creativity block
                If TheChe > 40 And TheChe <= 47 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A team creativity block has caused a delay in development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'miscommunicated priorities
                If TheChe > 47 And TheChe <= 54 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("Miscommunicated priorities caused an delay in development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'Lack of specifications
                If TheChe > 54 And TheChe <= 60 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("Lack of specifications on your latest project has caused a delay in development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'feature creep!
                If TheChe > 60 And TheChe <= 75 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(3, 6))
                        Call MsgBox("You were hacked and latest development changes were stolen.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'Equipment upgrades
                If TheChe > 75 And TheChe <= 85 Then
                    Dollars = Math.Round(.Cash.Text * (GetRandom(5, 15) / 100))
                    Call MsgBox("You have decided to invest " & FormatCurrency(Dollars, 0) & " in equipment for the office.", MsgBoxStyle.Information)
                    .Cash.Text = Val(.Cash.Text) - Dollars
                End If

                'server crash
                If TheChe > 85 And TheChe <= 95 Then
                    If .Develop.CheckState = CheckState.Checked Or .Engine.CheckState = CheckState.Checked Then
                        .DevelopStages.Items(0) = Math.Round(Val(.DevelopStages.Items(0)) + GetRandom(1, 2))
                        Call MsgBox("A server crash and lost data has caused a delay in development.", MsgBoxStyle.Information)
                    Else
                        Exit Sub
                    End If
                End If

                'strong documentation
                If TheChe > 95 And TheChe <= 105 Then
                    x = GetRandom(1, 2)
                    Dollars = GetRandom(100, 500) * Val(.DevTeam.Text)
                    If .Develop.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uGameplay.Text = Val(.uGameplay.Text) + Dollars
                            Call MsgBox("Strong documentation has improved your game by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uDesign.Text = Val(.uDesign.Text) + Dollars
                            Call MsgBox("Strong documentation has improved your design by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    ElseIf .Engine.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uPhysics.Text = Val(.uPhysics.Text) + Dollars
                            Call MsgBox("Strong documentation has improved your physics by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uScripts.Text = Val(.uScripts.Text) + Dollars
                            Call MsgBox("Strong documentation has improved your scripts by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    Else
                        Exit Sub
                    End If
                End If

                'moddable coding
                If TheChe > 105 And TheChe <= 115 Then
                    x = GetRandom(1, 3)
                    Dollars = GetRandom(100, 500) * Val(.DevTeam.Text)
                    If .Develop.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uGameplay.Text = Val(.uGameplay.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your game by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uDesign.Text = Val(.uDesign.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your design by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 3 Then
                            .uArt.Text = Val(.uArt.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your art by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    ElseIf .Engine.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uGUI.Text = Val(.uGUI.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your GUI by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uScripts.Text = Val(.uScripts.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your scripts by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 3 Then
                            .uGraphics.Text = Val(.uGraphics.Text) + Dollars
                            Call MsgBox("Moddable coding has improved your graphics by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    Else
                        Exit Sub
                    End If
                End If

                'commented code
                If TheChe > 115 And TheChe <= 125 Then
                    x = GetRandom(1, 2)
                    Dollars = GetRandom(100, 500) * Val(.DevTeam.Text)
                    If .Develop.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uGameplay.Text = Val(.uGameplay.Text) + Dollars
                            Call MsgBox("Well commented code has improved your game by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uDesign.Text = Val(.uDesign.Text) + Dollars
                            Call MsgBox("Well commented code has improved your design by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    ElseIf .Engine.CheckState = CheckState.Checked Then
                        If x = 1 Then
                            .uPhysics.Text = Val(.uPhysics.Text) + Dollars
                            Call MsgBox("Well commented code has improved your physics by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                        If x = 2 Then
                            .uScripts.Text = Val(.uScripts.Text) + Dollars
                            Call MsgBox("Well commented code has improved your scripts by " & Dollars & " points.", MsgBoxStyle.Information)
                        End If
                    Else
                        Exit Sub
                    End If
                End If

                'Lawsuit
                If TheChe > 125 And TheChe <= 132 Then
                    Dollars = Math.Round(.Cash.Text * (GetRandom(25, 75) / 100))
                    Call MsgBox("A lawsuit has caused you to lose " & FormatCurrency(Dollars, 0) & ".", MsgBoxStyle.Information)
                    .Cash.Text = Val(.Cash.Text) - Dollars
                End If

                'Licenses
                If TheChe > 132 And TheChe <= 140 Then
                    Dollars = Math.Round(.Cash.Text * (GetRandom(5, 20) / 100))
                    Call MsgBox("Renegotiated licensing has caused you to invest " & FormatCurrency(Dollars, 0) & ".", MsgBoxStyle.Information)
                    .Cash.Text = Val(.Cash.Text) - Dollars
                End If

                'Embezzlement
                If TheChe > 140 And TheChe <= 145 And .EmployeeData.Items.Count > 1 Then
                    Dollars = Math.Round(.Cash.Text * (GetRandom(10, 40) / 100))

                    y = .EmployeeData.Items.Count - 1
                    y = GetRandom(1, y)
                    Call MsgBox("Embezzlement has caused you to lose " & FormatCurrency(Dollars, 0) & ". " & GetEmployee(.EmployeeData.Items(y), "Name") & " was fired.", MsgBoxStyle.Information)
                    .EmployeeData.Items.RemoveAt(y)

                    .Cash.Text = Val(.Cash.Text) - Dollars
                End If

                'weather
                If TheChe > 145 And TheChe <= 150 Then
                    Dollars = Math.Round(.Cash.Text * (GetRandom(5, 25) / 100))
                    Call MsgBox("Severe weather has caused " & FormatCurrency(Dollars, 0) & " in damages.", MsgBoxStyle.Information)
                    .Cash.Text = Val(.Cash.Text) - Dollars
                End If

                'Long-term disability
                If TheChe > 150 And TheChe <= 157 Then
                    x = GetRandom(1, .EmployeeData.Items.Count)

                    Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " has gone on FMLA.", MsgBoxStyle.Information)
                    .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "PTO", "Y")
                    .EmployeeData.Items(x) = GetEmployee(.EmployeeData.Items(x), "Stress", GetRandom(500, 1000))
                    .NewsList.Items.Insert(0, GetEmployee(.EmployeeData.Items(x), "Name") & " has gone on FMLA.")
                End If

                'Better jobs
                If TheChe > 157 And TheChe <= 173 Then
                    x = GetRandom(1, .EmployeeData.Items.Count)

                    Dim TheirSalary As Long = GetEmployee(.EmployeeData.Items(x), "Salary")
                    If TheirSalary < GetAvgSalary() Then

                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " left the company for a better paying job.", MsgBoxStyle.Information)
                        Call Termination("Quit", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                End If

                'Random expenses
                If TheChe > 173 And TheChe <= 183 Then
                    x = GetRandom(1, 7)
                    Dollars = .EmployeeData.Items.Count * GetRandom(1000, 5000)
                    .Cash.Text = Val(.Cash.Text) - Dollars

                    Select Case x
                        Case Is = 1
                            .NewsList.Items.Insert(0, "A holiday party costed was " & FormatCurrency(Dollars, 0) & ".")
                        Case Is = 2
                            .NewsList.Items.Insert(0, "You rewarded your employees with a bonus of " & FormatCurrency(Dollars, 0) & ".")
                        Case Is = 3
                            .NewsList.Items.Insert(0, "You invested " & FormatCurrency(Dollars, 0) & " towards a startup project.")
                        Case Is = 4
                            .NewsList.Items.Insert(0, "Greed got the best of you when you were tricked into buying secrets for " & FormatCurrency(Dollars, 0) & ".")
                        Case Is = 5
                            .NewsList.Items.Insert(0, "Someone gambled with some of your company money and lost " & FormatCurrency(Dollars, 0) & ".")
                        Case Is = 6
                            .NewsList.Items.Insert(0, "Travel expenses for an event costed " & FormatCurrency(Dollars, 0) & ".")
                        Case Is = 7
                            .NewsList.Items.Insert(0, "You sent the team to training for " & FormatCurrency(Dollars, 0) & ".")
                    End Select

                End If


                'Death
                If TheChe > 183 And TheChe <= 190 Then
                    If .EmployeeData.Items.Count = 1 Then Exit Sub
                    x = GetRandom(1, .EmployeeData.Items.Count)

                    y = GetRandom(1, 50)
                    If y >= 1 And y <= 20 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " died of a heart attack.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                    If y > 20 And y <= 30 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " died of cancer.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                    If y > 30 And y <= 35 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " died in car accident.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                    If y > 35 And y <= 40 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " died of pneumonia.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                    If y > 40 And y <= 45 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " died of diabetes.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If

                    If y > 45 And y <= 50 Then
                        Call MsgBox(GetEmployee(.EmployeeData.Items(x), "Name") & " committed suicide.", MsgBoxStyle.Information)
                        Call Termination("Died", GetEmployee(.EmployeeData.Items(x), "Name"), GetEmployee(.EmployeeData.Items(x), "Seat"))
                        .EmployeeData.Items.RemoveAt(x)
                    End If
                End If

                'Acquisition
                If TheChe > 190 Then
                    Call EndGame("Acquisition")
                End If

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub RandomEvents()
        Dim x As Integer
        Dim temp As String, temp2 As String

        Try
            With fRandom
                'set defaults
                .Cost.Text = 0
                .Button1.Enabled = True
                .Affected.Text = "Gameplay"
                .Impact.Text = 0
                .RichTextBox1.Text = ""

                'what is the success rate? and how does it help the outcome. The lower chance items have huge impact, and higher chance have low impact
                .SuccessRate.Text = GetRandom(1, 100)

                If .SuccessRate.Text < 25 Then
                    .Approve.Text = GetRandom(800, 1000)
                    .Reject.Text = GetRandom(800, 1000)
                End If

                If .SuccessRate.Text >= 25 And .SuccessRate.Text < 50 Then
                    .Approve.Text = GetRandom(500, 700)
                    .Reject.Text = GetRandom(500, 700)
                End If

                If .SuccessRate.Text >= 50 And .SuccessRate.Text < 75 Then
                    .Approve.Text = GetRandom(300, 500)
                    .Reject.Text = GetRandom(300, 500)
                End If

                If .SuccessRate.Text >= 75 Then
                    .Approve.Text = GetRandom(100, 300)
                    .Reject.Text = GetRandom(100, 300)
                End If

                'what will be affected?
                x = GetRandom(0, 10)

                If FMain.Develop.Checked = True Then
                    If x <= 3 Then .Affected.Text = "Gameplay"
                    If x = 4 Or x = 5 Then .Affected.Text = "Design"
                    If x = 6 Then .Affected.Text = "Art"
                    If x = 7 Or x = 8 Then .Affected.Text = "Replay"
                    If x = 9 Then .Affected.Text = "Story"
                    If x = 10 Then .Affected.Text = "Music"
                ElseIf FMain.Engine.Checked = True Then
                    If x <= 3 Then .Affected.Text = "Physics"
                    If x = 4 Or x = 5 Then .Affected.Text = "Input"
                    If x = 6 Then .Affected.Text = "Networking"
                    If x = 7 Or x = 8 Then .Affected.Text = "Scripting"
                    If x = 9 Then .Affected.Text = "GUI"
                    If x = 10 Then .Affected.Text = "Graphics and Sound"
                ElseIf FMain.Console.Checked = True Then
                    If x = 1 Or x = 2 Then .Affected.Text = "CPU"
                    If x = 3 Or x = 4 Then .Affected.Text = "Memory"
                    If x = 5 Or x = 6 Then .Affected.Text = "Software"
                    If x = 7 Or x = 8 Then .Affected.Text = "Programming"
                    If x = 9 Or x = 10 Then .Affected.Text = "Storage"
                End If

                'The scenario
                If FMain.NewGames.Items.Count = 0 Then Exit Sub
                x = GetRandom(1, 100)
                If x < 10 Then
                    temp2 = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")

                    If FMain.Console.Checked = True Then
                        temp = GetConsole(FMain.NewConsoles.Items(GetRandom(0, FMain.NewConsoles.Items.Count - 1)), "Console")
                    Else
                        temp = GetGame(FMain.NewGames.Items(GetRandom(0, FMain.NewGames.Items.Count - 1)), "Name")
                    End If

                    .RichTextBox1.Text = "A new technology was discovered in " & temp & " and " & temp2 & " believes we should try to implement it."
                    .Impact.Text = GetRandom(2, 4)
                End If

                If x >= 10 And x < 30 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    If FMain.Develop.Checked = True Then
                        .RichTextBox1.Text = temp & " came up with a new feature they believe would benefit the game."
                    ElseIf FMain.Engine.Checked = True Then
                        .RichTextBox1.Text = temp & " came up with a new feature they believe would benefit the engine."
                    ElseIf FMain.Console.Checked = True Then
                        .RichTextBox1.Text = temp & " came up with a new feature they believe would benefit the console."
                    End If
                    .Impact.Text = GetRandom(1, 3)
                End If

                If x >= 30 And x < 35 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " has discovered that there is a licensing issue. Should they resolve it?"
                End If

                If x >= 35 And x < 40 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " is in a creative block and would like to try a new technique. Shall we go for it?"
                End If

                If x >= 40 And x < 45 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " mentioned that there are too many meetings going on and requests that we post-pone a few so they can focus on development."
                End If

                If x >= 45 And x < 50 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " is constantly getting interrupted and would like to work in isolation for a while."
                End If

                If x >= 50 And x < 55 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "Multi-tasking has prevented " & temp & " from being productive and would like to narrow their focus on a specific feature."
                End If

                If x >= 55 And x < 60 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " would like to hold others accountable for completing their tasks as they feel like development is slowing down."
                End If

                If x >= 60 And x < 65 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "Poor miscommunication has left " & temp & " out of the loop, negatively affecting development and would like to try a new technique."
                End If

                If x >= 65 And x < 70 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "Miscommunicated priorities have caused " & temp & " some frustration and would like to have a meeting to reprioritize."
                End If

                If x >= 70 And x < 75 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " read about some new algorithms and would like to implement them."
                    .Impact.Text = GetRandom(1, 2)
                End If


                If x >= 75 And x < 80 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "After some data analysis, " & temp & " found some interesting market data that they want to apply."
                End If

                If x >= 80 And x < 85 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " went to a development forum and wants to apply some of their knowledge."
                End If

                If x >= 85 And x < 90 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "Some security vulnerabilities were discovered by " & temp & " and they want to fix them."
                    .Impact.Text = 1
                    .Cost.Text = GetRandom(FMain.EmployeeData.Items.Count * 50, FMain.EmployeeData.Items.Count * 200)
                End If

                If x >= 90 And x < 95 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = "A lack of specifications has caused " & temp & " to be concerned about development and would like to revisit them."
                    .Impact.Text = GetRandom(1, 2)
                End If

                If x >= 95 And x < 98 Then
                    .Cost.Text = GetRandom(FMain.EmployeeData.Items.Count * 200, FMain.EmployeeData.Items.Count * 600)
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .RichTextBox1.Text = temp & " mentioned we should upgrade computers for the new game."
                    .Impact.Text = GetRandom(1, 2)
                End If

                If x >= 98 Then
                    temp = GetEmployee(FMain.EmployeeData.Items(GetRandom(0, FMain.EmployeeData.Items.Count - 1)), "Name")
                    .Cost.Text = GetRandom(FMain.EmployeeData.Items.Count * 400, FMain.EmployeeData.Items.Count * 1200)
                    .RichTextBox1.Text = temp & " thinks new furniture will help increase productivity."
                End If

                'success rate only counts if money is not involved
                If .Cost.Text = 0 Then
                    .RichTextBox1.Text = .RichTextBox1.Text & " The estimated success rate is " & .SuccessRate.Text & "%"
                Else
                    .RichTextBox1.Text = .RichTextBox1.Text & " The estimated cost is " & FormatCurrency(.Cost.Text, 0) & "."
                End If

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            FMain.RandomCounter.Text = GetRandom(2, 10) 'prevents random spam
        End Try

    End Sub
    Public Sub EndGame(TheReason As String)
        Dim GoodGames As Integer, GoodEngines As Integer, Investments As Long, Consoles As Integer, Stocks As Long, Loans As Long, BadGames As Integer, Reputation As Integer

        Try
            'corrupt mode - files will get deleted when the game is over
            If My.Settings.SettingsCorruptMode = True Then
                If IO.File.Exists(Application.StartupPath & "\Saves\Companies.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\Companies.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\NewConsoles.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\NewConsoles.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\OldConsoles.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\OldConsoles.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\NewEngines.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\NewEngines.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\Employees.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\Employees.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\ExpoList.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\ExpoList.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\NewGames.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\NewGames.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\OldGames.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\OldGames.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\DevelopStages.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\DevelopStages.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\lstSeq.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\lstSeq.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\Loans.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\Loans.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\Investments.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\Investments.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\Stocks.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\Stocks.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\OwnedStocks.dat") Then IO.File.Delete(Application.StartupPath & "\Saves\OwnedStocks.dat")
                If IO.File.Exists(Application.StartupPath & "\Saves\Data.dat") = True Then IO.File.Delete(Application.StartupPath & "\Saves\Data.dat")
            End If

            GoodGames = 0
            GoodEngines = 0
            Investments = 0
            Consoles = 0
            Stocks = 0
            Loans = 0
            BadGames = 0
            Reputation = 0

            With FMain
                .Timer1.Enabled = False

                For Each itm In .OldGames.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then
                        If GetGame(itm, "Rating") >= 9 Then GoodGames = GoodGames + 1
                        If GetGame(itm, "Rating") < 5 Then BadGames = BadGames + 1
                    End If
                Next itm

                For Each itm In .NewGames.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then
                        If GetGame(itm, "Rating") >= 9 Then GoodGames = GoodGames + 1
                        If GetGame(itm, "Rating") < 5 Then BadGames = BadGames + 1
                    End If
                Next itm

                For Each itm In .OldEngines.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then GoodEngines = GoodEngines + 1
                Next itm

                For Each itm In .NewEngines.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then GoodEngines = GoodEngines + 1
                Next itm

                For Each itm In .OldConsoles.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then Consoles = Consoles + 1
                Next itm

                For Each itm In .NewConsoles.Items
                    If InStr(itm, .YourCo.Text) <> 0 Then Consoles = Consoles + 1
                Next itm

                For Each itm In .Investments.Items
                    Investments = Math.Round(GetInvestments(itm, "Dollar") + Investments)
                Next itm

                For Each itm In .Loans.Items
                    Loans = Math.Round(GetLoans(itm, "Dollar") + Loans)
                Next itm

                Stocks = .OwnedStocks.Items.Count

                Reputation = .Reputation.Text
            End With

            Select Case TheReason
                Case Is = "Suicide"
                    Call MsgBox("You committed suicide from overworking." & vbNewLine & "Next time, take some time off once in a while.", vbCritical)
                Case Is = "Retire"
                    Call MsgBox("You have retired from the game industry.", vbInformation)
                Case Is = "Cash"
                    Call MsgBox("You have gone bankrupt.", vbCritical)
                Case Is = "Acquisition"
                    Call MsgBox("You have been acquired by another studio and closed.", vbInformation)
            End Select

            With fGameOver
                .MostCash.Text = FMain.CashMax.Text
                .GoodGames.Text = GoodGames
                .GoodEngines.Text = GoodEngines
                .Investments.Text = Investments
                .Consoles.Text = Consoles
                .Stocks.Text = Stocks
                .Loans.Text = Loans
                .BadGames.Text = BadGames
                .Reputation.Text = Reputation

                .FinalScore.Text = Math.Round(.MostCash.Text + (GoodGames * 1000) + (GoodEngines * 10) + Investments + (Stocks * 100000) + (Consoles * 10000) - Loans - (BadGames * 5000) + Reputation)

                FMain.Hide()
                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.bankrupt, AudioPlayMode.Background)
                .Show()

                'hide all forms
                For Each frm As Form In My.Application.OpenForms
                    If frm.Name <> fGameOver.Name Then frm.Hide()
                Next

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub MarketingForm()

        Try
            With fMarketing
                .ComboBox1.Items.Clear()

                If Val(FMain.TheYear.Text) < 2000 Then
                    .ComboBox1.Items.Add("Magazine")
                    .ComboBox1.Items.Add("Radio")
                    .ComboBox1.Items.Add("Television")
                Else
                    .ComboBox1.Items.Add("Magazine")
                    .ComboBox1.Items.Add("Radio")
                    .ComboBox1.Items.Add("Review Sites")
                    .ComboBox1.Items.Add("Social Media")
                    .ComboBox1.Items.Add("Television")
                    .ComboBox1.Items.Add("Trailer")
                End If

                .Label9.Text = 0
                .Label10.Text = 0

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Function SimExpo(TheData As String) As String
        'company,exponame,month,visitors 
        Dim temp As String, x As Integer
        Dim TheCompany As String, ExpoName As String, TheMonth As String, Visitors As Long

        Try
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '                                       Grabbing the data
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            ExpoName = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheMonth = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Visitors = Int(temp)

            'return full data 
            'company,exponame,month,visitors 
            Visitors = Math.Round(Visitors + (Visitors * (GetRandom(10, 30) / 100))) 'more visitors than last time 
            If Visitors > 50000 Then Visitors = 50000
            SimExpo = TheCompany & "," & ExpoName & "," & TheMonth & "," & Visitors
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Function
    Public Sub GenExpo(TheMonth As String)
        'company,exponame,month,visitors 
        Dim SaveCo As String, y As Integer, x As Integer, TheCash As Long


        y = GetRandom(1, 26)
        If y < 25 Then Exit Sub
        Try

            With FMain
                .Companies.Refresh()
                x = .Companies.Items.Count - 1
                If x = -1 Then Exit Sub
                y = .Companies.Items.Count - 1

                Do
                    TheCash = Val(GetCompany(.Companies.Items(y), "Cash"))
                    SaveCo = GetCompany(.Companies.Items(y), "Company")

                    If .ExpoList.FindString(SaveCo) <> ListBox.NoMatches Then GoTo Nexty 'prevent duplicates

                    If TheCash > 1000000 Then GoTo CreateExpo
Nexty:
                    y = y - 1
                Loop Until y = -1
                Exit Sub

CreateExpo:
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        Finally
            'company,exponame,month,visitors 
            FMain.ExpoList.Items.Add(SaveCo & "," & Left(SaveCo, 4) & "Con" & "," & TheMonth & "," & GetRandom(500, 3000))
        End Try
    End Sub
    Public Function GetExpo(TheData As String) As String
        'company,exponame,month,visitors 
        Dim temp As String, x As Integer
        Dim TheCompany As String, ExpoName As String, TheMonth As String, Visitors As Long

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            ExpoName = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheMonth = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            Visitors = Int(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        'return full data 
        'company,exponame,month,visitors 
        Visitors = Math.Round(Visitors + (Visitors * (GetRandom(10, 30) / 100))) 'more visitors than last time 
        If Visitors > 50000 Then Visitors = 50000
        GetExpo = TheCompany & "," & ExpoName & "," & TheMonth & "," & Visitors

        'run popup 
        With fDiagExpo
            .ConName.Text = ExpoName
            .ConVisitors.Text = Visitors
            .TrackBar1.Value = 1
            .Cost.Text = Math.Round(Visitors * 1.4)
            .Label1.Text = "The " & ExpoName & " has started. Would you like to make an appearance?"

            My.Computer.Audio.Stop()
            If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
            .Show()
        End With

        FMain.Timer1.Enabled = False
        Return GetExpo
    End Function
    Public Sub SetLoans()
        Dim x As Long, y As Integer, tmpName As String, tmpDollar As Long, tmpRate As Double

        Try
            fBank.Loan1.Items.Clear()
            fBank.Loan1Data.Items.Clear()
            fBank.Loan2.Items.Clear()
            fBank.Loan2Data.Items.Clear()


            'load pre-existing loans
            x = FMain.Loans.Items.Count - 1

            If x <> -1 Then
                Do
                    fBank.Loan1Data.Items.Add(FMain.Loans.Items(x))
                    fBank.Loan1.Items.Add("You owe " & GetLoans(FMain.Loans.Items(x), "Name") & " " & FormatCurrency(GetLoans(FMain.Loans.Items(x), "Dollar")) & ".")
                    x = x - 1
                Loop Until x = -1
            End If

            'too many loans? then don't provide new options!
            If fBank.Loan1Data.Items.Count >= 5 Then Exit Sub

            'generate new loans
            x = GetRandom(2, 15)
            Do
                With FMain
                    If Val(.Cash.Text) < 500000 Then
                        tmpDollar = GetRandom(25000, 100000)
                    End If

                    If Val(.Cash.Text) > 500000 And Val(.Cash.Text) < 2000000 Then
                        tmpDollar = GetRandom(250000, 500000)
                    End If

                    If Val(.Cash.Text) > 2000000 And Val(.Cash.Text) < 10000000 Then
                        tmpDollar = GetRandom(500000, 3000000)
                    End If

                    If Val(.Cash.Text) > 10000000 Then
                        tmpDollar = GetRandom(2000000, 5000000)
                    End If
                End With

                tmpDollar = Math.Round(tmpDollar / 100, 0) * 100 'rounding for realism


                'name the engine
                tmpName = FMain.EngineNames.Items(GetRandom(1, FMain.EngineNames.Items.Count - 1))

                y = GetRandom(1, 8)

                Select Case y
                    Case Is = 1
                        tmpName = tmpName & " Bank"
                    Case Is = 2
                        tmpName = tmpName & " Bank"
                    Case Is = 3
                        tmpName = tmpName & " Bank"
                    Case Is = 4
                        tmpName = tmpName & " Credit Union"
                    Case Is = 5
                        tmpName = tmpName & " Credit Union"
                    Case Is = 6
                        tmpName = tmpName & " Financial"
                    Case Is = 7
                        tmpName = tmpName & " Express"
                    Case Is = 8
                        tmpName = tmpName & " Services"
                End Select

                'more loans = higher interest rate 
                Select Case fBank.Loan1.Items.Count
                    Case Is = 0
                        tmpRate = GetRandom(4, 7)
                    Case Is = 1
                        tmpRate = GetRandom(5, 8)
                    Case Is = 2
                        tmpRate = GetRandom(6, 9)
                    Case Is = 3
                        tmpRate = GetRandom(7, 10)
                    Case Is >= 4
                        tmpRate = GetRandom(8, 12)
                End Select

                'add decimal
                tmpRate = tmpRate & "." & GetRandom(1, 99)

                'add to lists
                fBank.Loan2Data.Items.Add(tmpName & "," & tmpDollar & "," & tmpRate)
                fBank.Loan2.Items.Add(tmpName & " is offering a loan for " & FormatCurrency(tmpDollar, 0) & " at a " & tmpRate & "% interest rate.")
                x = x - 1
            Loop Until x = 0
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Function GetLoans(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'BankName,DollarAmount,TheRate
        Dim BankName As String, DollarAmount As Long, TheRate As Double
        Dim temp As String, x As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            BankName = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            DollarAmount = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheRate = Int(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Name"
                If ChangeTo <> "" Then
                    BankName = Val(ChangeTo)
                Else
                    GetLoans = BankName
                    Return GetLoans
                End If

            Case Is = "Dollar"
                If ChangeTo <> "" Then
                    DollarAmount = Val(ChangeTo)
                Else
                    GetLoans = DollarAmount
                    Return GetLoans
                End If

            Case Is = "Rate"
                If ChangeTo <> "" Then
                    TheRate = Val(ChangeTo)
                Else
                    GetLoans = TheRate
                    Return GetLoans
                End If
        End Select

        'return full engine data if a change is needed
        'BankName,DollarAmount,TheRate
        GetLoans = BankName & "," & DollarAmount & "," & TheRate
        Return GetLoans
    End Function
    Public Sub SetInvestments()
        Dim x As Long, y As Long, tmpDollar As Long, tmpName As String, tmpRate As Double

        Try
            x = FMain.Investments.Items.Count - 1

            fBank.Invest1Data.Items.Clear()
            fBank.Invest1.Items.Clear()
            fBank.Invest2.Items.Clear()
            fBank.Invest2Data.Items.Clear()

            If x <> -1 Then
                Do
                    fBank.Invest1Data.Items.Add(FMain.Investments.Items(x))
                    fBank.Invest1.Items.Add("Investments in " & GetLoans(FMain.Investments.Items(x), "Name") & " are worth " & FormatCurrency(GetLoans(FMain.Investments.Items(x), "Dollar")) & ".")
                    x = x - 1
                Loop Until x = -1
            End If

            'generate new investments
            x = GetRandom(2, 15)
            Do
                With FMain
                    If Val(.Cash.Text) < 500000 Then
                        tmpDollar = GetRandom(10000, 25000)
                    End If

                    If Val(.Cash.Text) > 500000 And Val(.Cash.Text) < 2000000 Then
                        tmpDollar = GetRandom(10000, 250000)
                    End If

                    If Val(.Cash.Text) > 2000000 And Val(.Cash.Text) < 10000000 Then
                        tmpDollar = GetRandom(10000, 1500000)
                    End If

                    If Val(.Cash.Text) > 10000000 Then
                        tmpDollar = GetRandom(10000, 7500000)
                    End If

                    If Val(.Cash.Text) > 100000000 Then
                        tmpDollar = GetRandom(100000, 75000000)
                    End If
                End With

                tmpDollar = Math.Round(tmpDollar / 100, 0) * 100 'rounding for realism


                'name the engine
                tmpName = FMain.EngineNames.Items(GetRandom(1, FMain.EngineNames.Items.Count - 1))

                y = GetRandom(1, 8)

                Select Case y
                    Case Is = 1
                        tmpName = tmpName & " Bank"
                    Case Is = 2
                        tmpName = tmpName & " Bank"
                    Case Is = 3
                        tmpName = tmpName & " Bank"
                    Case Is = 4
                        tmpName = tmpName & " Credit Union"
                    Case Is = 5
                        tmpName = tmpName & " Credit Union"
                    Case Is = 6
                        tmpName = tmpName & " Financial"
                    Case Is = 7
                        tmpName = tmpName & " Express"
                    Case Is = 8
                        tmpName = tmpName & " Services"
                End Select

                'determine interest rate
                tmpRate = GetRandom(2, 5)

                'add decimal
                tmpRate = tmpRate & "." & GetRandom(1, 99)

                'add to lists
                fBank.Invest2Data.Items.Add(tmpName & "," & tmpDollar & "," & tmpRate)
                fBank.Invest2.Items.Add(tmpName & " wants a loan for " & FormatCurrency(tmpDollar, 0) & " at a " & tmpRate & "% interest rate.")
                x = x - 1
            Loop Until x = 0
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Function GetInvestments(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        'BankName,DollarAmount,TheRate
        Dim BankName As String, DollarAmount As Long, TheRate As Double
        Dim temp As String, x As Integer

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            BankName = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            DollarAmount = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheRate = Int(temp)
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Name"
                If ChangeTo <> "" Then
                    BankName = Val(ChangeTo)
                Else
                    GetInvestments = BankName
                    Return GetInvestments
                End If

            Case Is = "Dollar"
                If ChangeTo <> "" Then
                    DollarAmount = Val(ChangeTo)
                Else
                    GetInvestments = DollarAmount
                    Return GetInvestments
                End If

            Case Is = "Rate"
                If ChangeTo <> "" Then
                    TheRate = Val(ChangeTo)
                Else
                    GetInvestments = TheRate
                    Return GetInvestments
                End If

        End Select

        'return full engine data if a change is needed
        'BankName,DollarAmount,TheRate
        GetInvestments = BankName & "," & DollarAmount & "," & TheRate
        Return GetInvestments
    End Function
    Public Sub DefineStocks()
        Try
            'this code will be totally different than the loans/investments
            '1. function should load all companies first
            '2. it will determine their stock price based on cash amount
            '3. it will check owned stock and update loaded stocks based on owned amount / cost price 
            Dim TheCo As String, TheCash As Long, SalesPer As Integer, TheRating As Integer, CurPub As String, CurCash As Long
            Dim tmp As Integer

            FMain.Stocks.Items.Clear()

            For Each itm In FMain.Companies.Items
                'How often are companies willing to sell their publishing deal?
                Dim y As Integer = GetRandom(1, My.Settings.WillingnessToPublish)
                If y <> 1 Then GoTo SkipNext

                TheCo = GetCompany(itm, "Company")
                CurPub = GetCompany(itm, "Publisher")
                CurCash = GetCompany(itm, "Cash")

                'Should they selfpublish?
                If CurCash > 5000000 And CurPub <> TheCo Then
                    y = GetRandom(1, 2)
                    If y = 1 Then
                        itm = GetCompany(itm, "Publisher", TheCo)
                        GoTo SkipNext
                    End If
                End If

                'Already published by another company?
                If CurPub <> "0" Or CurPub <> TheCo Then
                    'reduce chances of it going for sell
                    y = GetRandom(1, 2)
                    If y = 2 Then GoTo SkipNext
                End If

                If CurPub = FMain.YourCo.Text Then GoTo SkipNext

                'get the ratings
                tmp = 0
                TheRating = 0
                For Each game In FMain.OldGames.Items
                    If GetGame(game, "Company") = TheCo Then
                        TheRating = TheRating + GetGame(game, "Rating")
                        tmp = tmp + 1
                    End If
                Next
                If TheRating = 0 Or tmp = 0 Then GoTo skipnext
                TheRating = Math.Round(TheRating / tmp)

                'define cash amount
                TheCash = Math.Round(GetCompany(itm, "Cash") * My.Settings.UpStock)

                'define the sales percentage
                SalesPer = 0
                Select Case TheRating
                    Case Is <= 5
                        SalesPer = GetRandom(40, 60)
                    Case Is = 6
                        SalesPer = GetRandom(35, 45)
                    Case Is = 7
                        SalesPer = GetRandom(30, 40)
                    Case Is = 8
                        SalesPer = GetRandom(25, 35)
                    Case Is = 9
                        SalesPer = GetRandom(20, 30)
                    Case Is = 10
                        SalesPer = GetRandom(15, 25)
                End Select

                If SalesPer <= 0 Or SalesPer > 60 Then SalesPer = GetRandom(30, 50)

                FMain.Stocks.Items.Add(TheCo & "," & SalesPer & "," & TheRating & "," & TheCash)

SkipNext:
            Next
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub SetStocks()

        Try
            With fBank
                .StockData.Items.Clear()

                For Each itm In FMain.Stocks.Items
                    .StockData.Items.Add(itm)
                    '.Stocks.Items.Add(GetStocks(itm, "Company") & " has released games with an average rating of " & GetStocks(itm, "Rating") & ". Buyout costs " & GetStocks(itm, "Cash") & " with " & GetStocks(itm, "Sales") & "% of sales.")
                Next

                If .StockData.Items.Count <> 0 Then
                    .lbl_Selected.Text = "1 / " & .StockData.Items.Count
                    .txt_AvailStocks.Text = GetStocks(.StockData.Items(0), "Company") & " is willing to sell their company for " & FormatCurrency(GetStocks(.StockData.Items(0), "Cash"), 0) & ". The average rating of their games is " & GetStocks(.StockData.Items(0), "Rating") & " and they're willing to give " & GetStocks(.StockData.Items(0), "Sales") & "% of sales."
                    .lst_ReleasedGames.Items.Clear()
                Else
                    .lbl_Selected.Text = "0 / 0"
                    .txt_AvailStocks.Text = "No companies available."
                    .lst_ReleasedGames.Items.Clear()
                End If

                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Function GetStocks(TheData As String, WhatData As String, Optional ByRef ChangeTo As String = "") As String
        Dim TheCompany As String, TheCash As Long, SalesPer As Integer, TheRating As Integer
        Dim x As Integer, temp As String
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       Grabbing the data
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            x = InStr(TheData, ",") - 1
            TheCompany = Left(TheData, x)
            temp = Mid(TheData, x + 2)

            x = InStr(temp, ",") - 1
            SalesPer = Left(temp, x)
            temp = Mid(temp, x + 2)

            x = InStr(temp, ",") - 1
            TheRating = Left(temp, x)
            temp = Mid(temp, x + 2)

            TheCash = temp
        Catch ex As Exception
            Call WriteLog(ex.ToString)
            Return TheData
        End Try

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                                       What data is needed
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Select Case WhatData
            Case Is = "Company"
                GetStocks = TheCompany
                Return GetStocks

            Case Is = "Sales"
                If ChangeTo <> "" Then
                    SalesPer = Val(ChangeTo)
                Else
                    GetStocks = SalesPer
                    Return GetStocks
                End If

            Case Is = "Rating"
                If ChangeTo <> "" Then
                    TheRating = Val(ChangeTo)
                Else
                    GetStocks = TheRating
                    Return GetStocks
                End If

            Case Is = "Cash"
                If ChangeTo <> "" Then
                    TheCash = Val(ChangeTo)
                Else
                    GetStocks = TheCash
                    Return GetStocks
                End If

        End Select

        'return full company data if a change is needed
        'Company Name, Sales percentage, average rating, cash amount
        GetStocks = TheCompany & "," & SalesPer & "," & TheRating & "," & TheCash
        Return GetStocks
    End Function
    Public Sub GenContracts()
        Dim TheNeed As String, TheCost As Long, TimeFrame As Integer, ArtTime As Long, TechTime As Long, Reputation As Long, tmpName As String
        Dim x As Integer, y As Integer, TheFocus As String
        'name, cost, timeframe, arttime, techtime

        Try
            'generate new contracts
            x = GetRandom(3, 10)
            Reputation = FMain.Reputation.Text
            With fContract

                'clear contracts
                .TheContractData.Items.Clear()

                Do
                    'Cleanup
                    TheFocus = Nothing
                    TheNeed = Nothing

                    'define cost
                    If Reputation < 100 Then TheCost = GetRandom(My.Settings.ContractCostMin, My.Settings.ContractCostMax)
                    If Reputation >= 100 And Reputation < 300 Then TheCost = GetRandom(My.Settings.ContractCostMin * 3, My.Settings.ContractCostMax * 3)
                    If Reputation >= 300 And Reputation < 600 Then TheCost = GetRandom(My.Settings.ContractCostMin * 5, My.Settings.ContractCostMax * 5)
                    If Reputation >= 600 And Reputation < 1000 Then TheCost = GetRandom(My.Settings.ContractCostMin * 10, My.Settings.ContractCostMax * 10)
                    If Reputation >= 1000 Then TheCost = GetRandom(My.Settings.ContractMax * 15, My.Settings.ContractCostMax * 15)

                    TimeFrame = GetRandom(5, 25)

                    'shorter timelines bring in more cash
                    TheCost = Math.Round(TheCost * ((130 - TimeFrame) / 100))

                    'name the company 
                    tmpName = FMain.EngineNames.Items(GetRandom(1, FMain.EngineNames.Items.Count - 1))

                    y = GetRandom(1, 20)
                    Select Case y
                        Case Is = 1
                            tmpName = tmpName & " Software"
                        Case Is = 2
                            tmpName = tmpName & "Soft"
                        Case Is = 3
                            tmpName = tmpName & " Software"
                        Case Is = 4
                            tmpName = tmpName & " Global"
                        Case Is = 5
                            tmpName = tmpName & " Labs"
                        Case Is = 6
                            tmpName = tmpName & " Consulting"
                        Case Is = 7
                            tmpName = tmpName & " Technologies"
                        Case Is = 8
                            tmpName = tmpName & " Technologies"
                        Case Is = 9
                            tmpName = tmpName & " Solutions"
                        Case Is = 10
                            tmpName = tmpName & " IT"
                        Case Is = 11
                            tmpName = tmpName & " Systems"
                        Case Is = 12
                            tmpName = tmpName & " Partners"
                        Case Is = 13
                            tmpName = tmpName & " Software"
                        Case Is = 14
                            tmpName = tmpName & "ware"
                        Case Is = 15
                            tmpName = tmpName & " Logic"
                        Case Is = 16
                            tmpName = tmpName & " Development"
                        Case Is = 17
                            tmpName = tmpName & " Interactive"
                        Case Is = 18
                            tmpName = tmpName & " Technology"
                        Case Is = 19
                            tmpName = tmpName & " Computers"
                        Case Is = 20
                            tmpName = tmpName & " Group"
                    End Select

                    'define the need
                    x = GetRandom(1, 19)
                    Select Case x
                        Case Is = 1
                            TheNeed = "A one-time deployment is required. "
                            TheFocus = "Tech"
                        Case Is = 2
                            TheNeed = "Managed services are needed. "
                            TheFocus = "Tech"
                        Case Is = 3
                            TheNeed = "Some User Interface is needed. "
                            TheFocus = "Art"
                        Case Is = 4
                            TheNeed = "Software maintenance is required. "
                            TheFocus = "Tech"
                        Case Is = 5
                            TheNeed = "A company needs some art assets. "
                            TheFocus = "Art"
                        Case Is = 6
                            TheNeed = "Animation needs to get completed. "
                            TheFocus = "Art"
                        Case Is = 7
                            TheNeed = "Modeling is required to complete a project. "
                            TheFocus = "Art"
                        Case Is = 8
                            TheNeed = "A new logo is needed. "
                            TheFocus = "Art"
                        Case Is = 9
                            TheNeed = "Application needs to be created. "
                            TheFocus = "Both"
                        Case Is = 10
                            TheNeed = "An application requires some rewriting. "
                            TheFocus = "Tech"
                        Case Is = 11
                            TheNeed = "An application needs to be rebuilt. "
                            TheFocus = "Tech"
                        Case Is = 12
                            TheNeed = "Need networking programming. "
                            TheFocus = "Tech"
                        Case Is = 13
                            TheNeed = "Test performance on some software. "
                            TheFocus = "Tech"
                        Case Is = 14
                            TheNeed = "Automation required for a process. "
                            TheFocus = "Tech"
                        Case Is = 15 And FMain.TheYear.Text > 1995
                            TheNeed = "Website design is required. "
                            TheFocus = "Art"
                            x = GetRandom(1, 19)
                        Case Is = 16 And FMain.TheYear.Text > 1995
                            TheNeed = "Build a website. "
                            TheFocus = "Both"
                            x = GetRandom(1, 19)
                        Case Is = 17
                            TheNeed = "Write test cases. "
                            TheFocus = "Tech"
                        Case Is = 18
                            TheNeed = "Build a database. "
                            TheFocus = "Tech"
                        Case Is = 19
                            TheNeed = "Data entry is needed. "
                            TheFocus = "Tech"
                    End Select

                    'define skill requirements 
                    If TheFocus = "Art" Then
                        If Reputation < 100 Then ArtTime = GetRandom(My.Settings.ContractMin, My.Settings.ContractMax)
                        If Reputation >= 100 And Reputation < 300 Then ArtTime = GetRandom(My.Settings.ContractMin * 3, My.Settings.ContractMax * 3)
                        If Reputation >= 300 And Reputation < 600 Then ArtTime = GetRandom(My.Settings.ContractMin * 5, My.Settings.ContractMax * 5)
                        If Reputation >= 600 And Reputation < 1000 Then ArtTime = GetRandom(My.Settings.ContractMin * 10, My.Settings.ContractMax * 10)
                        If Reputation >= 1000 Then ArtTime = GetRandom(My.Settings.ContractMin * 15, My.Settings.ContractMax * 15)

                        If Reputation < 100 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2), Math.Round(My.Settings.ContractMax / 2))
                        If Reputation >= 100 And Reputation < 300 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 3, Math.Round(My.Settings.ContractMax / 2) * 3)
                        If Reputation >= 300 And Reputation < 600 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 5, Math.Round(My.Settings.ContractMax / 2) * 5)
                        If Reputation >= 600 And Reputation < 1000 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 10, Math.Round(My.Settings.ContractMax / 2) * 10)
                        If Reputation >= 1000 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 15, Math.Round(My.Settings.ContractMax / 2) * 15)
                    End If

                    If TheFocus = "Tech" Then
                        If Reputation < 100 Then TechTime = GetRandom(My.Settings.ContractMin, My.Settings.ContractMax)
                        If Reputation >= 100 And Reputation < 300 Then TechTime = GetRandom(My.Settings.ContractMin * 3, My.Settings.ContractMax * 3)
                        If Reputation >= 300 And Reputation < 600 Then TechTime = GetRandom(My.Settings.ContractMin * 5, My.Settings.ContractMax * 5)
                        If Reputation >= 600 And Reputation < 1000 Then TechTime = GetRandom(My.Settings.ContractMin * 10, My.Settings.ContractMax * 10)
                        If Reputation >= 1000 Then TechTime = GetRandom(My.Settings.ContractMin * 15, My.Settings.ContractMax * 15)

                        If Reputation < 100 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2), Math.Round(My.Settings.ContractMax / 2))
                        If Reputation >= 100 And Reputation < 300 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 3, Math.Round(My.Settings.ContractMax / 2) * 3)
                        If Reputation >= 300 And Reputation < 600 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 5, Math.Round(My.Settings.ContractMax / 2) * 5)
                        If Reputation >= 600 And Reputation < 1000 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 10, Math.Round(My.Settings.ContractMax / 2) * 10)
                        If Reputation >= 1000 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 15, Math.Round(My.Settings.ContractMax / 2) * 15)
                    End If

                    If TheFocus = "Both" Then
                        If Reputation < 100 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2), Math.Round(My.Settings.ContractMax / 2))
                        If Reputation >= 100 And Reputation < 300 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 3, Math.Round(My.Settings.ContractMax / 2) * 3)
                        If Reputation >= 300 And Reputation < 600 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 5, Math.Round(My.Settings.ContractMax / 2) * 5)
                        If Reputation >= 600 And Reputation < 1000 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 10, Math.Round(My.Settings.ContractMax / 2) * 10)
                        If Reputation >= 1000 Then TechTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 15, Math.Round(My.Settings.ContractMax / 2) * 15)

                        If Reputation < 100 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2), Math.Round(My.Settings.ContractMax / 2))
                        If Reputation >= 100 And Reputation < 300 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 3, Math.Round(My.Settings.ContractMax / 2) * 3)
                        If Reputation >= 300 And Reputation < 600 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 5, Math.Round(My.Settings.ContractMax / 2) * 5)
                        If Reputation >= 600 And Reputation < 1000 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 10, Math.Round(My.Settings.ContractMax / 2) * 10)
                        If Reputation >= 1000 Then ArtTime = GetRandom(Math.Round(My.Settings.ContractMin / 2) * 15, Math.Round(My.Settings.ContractMax / 2) * 15)
                    End If

                    TheNeed = TheNeed & "This requires [" & FormatNumber(ArtTime, 0) & "] art production and [" & FormatNumber(TechTime, 0) & "] technical production. " & tmpName & " is giving you " & TimeFrame & " weeks and a reward of " & FormatCurrency(TheCost, 0) & "."

                    'add to lists.
                    'name, cost, timeframe, arttime, techtime
                    .TheContractData.Items.Add(tmpName & "," & TheCost & "," & TimeFrame & "," & ArtTime & "," & TechTime & "^" & TheNeed)

                    x = x - 1
                Loop Until x = 0

                'Setup first contract
                .txt_TheJob.Text = TheNeed
                .lbl_Selected.Text = "1 / " & .TheContractData.Items.Count

                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub SetPublishers()
        'name, timeframe, reward, percent
        Dim x As Integer, y As Integer, Counter As Long
        Dim CoName As String, TimeFrame As Integer, CashAward As Long, TotCash As Long, ThePer As Integer, Reputation As String, TheDeal As String

        Try
Restart:
            'generate new contracts
            x = GetRandom(3, 10)
            Reputation = FMain.Reputation.Text

            With fPublisher
                Do
                    'define cost
                    If FMain.TheYear.Text < 1990 Then TotCash = 50000 * Val(FMain.GameSize.Text)
                    If FMain.TheYear.Text >= 1990 And FMain.TheYear.Text < 2000 Then TotCash = 75000 * Val(FMain.GameSize.Text)
                    If FMain.TheYear.Text >= 2000 And FMain.TheYear.Text < 2010 Then TotCash = 100000 * Val(FMain.GameSize.Text)
                    If FMain.TheYear.Text >= 2010 Then TotCash = 125000 * Val(FMain.GameSize.Text)

                    TimeFrame = GetRandom(5, 25)

                    'get the company name
                    Counter = 0
Next_Publisher:
                    y = FMain.Companies.Items.Count - 1
                    y = GetRandom(0, y)

                    If Val(GetCompany(FMain.Companies.Items(y), "Cash")) > TotCash Then
                        CashAward = Val(GetRandom(10000, TotCash)) * Val(FMain.GameSize.Text)

                        'percent based on reputation
                        If Reputation < 100 Then ThePer = GetRandom(40, 70)
                        If Reputation >= 100 And Reputation < 300 Then ThePer = GetRandom(30, 50)
                        If Reputation >= 300 And Reputation < 600 Then ThePer = GetRandom(20, 40)
                        If Reputation >= 600 And Reputation < 1000 Then ThePer = GetRandom(15, 30)
                        If Reputation >= 1000 Then ThePer = GetRandom(10, 20)

                        'set company name
                        CoName = GetCompany(FMain.Companies.Items(x), "Company")

                        'set timeframe
                        TimeFrame = GetRandom(40, 65)

                        'reset counter 
                        Counter = 0

                        'add to lists.
                        'name, timeframe, reward, percent
                        TheDeal = CoName & " offers a down payment of " & FormatCurrency(CashAward, 0) & " with a cut of " & ThePer & "%. You have " & TimeFrame & " weeks to complete it."
                        '.ThePublisher.Items.Add(CoName & " offers a down payment of " & FormatCurrency(CashAward, 0) & " with a cut of " & ThePer & "%. You have " & TimeFrame & " weeks to complete it.")
                        .ThePublisherData.Items.Add(CoName & "," & TimeFrame & "," & CashAward & "," & ThePer & "^" & TheDeal)
                    Else
                        'if it tries 25 companies and can't find one, then quit early
                        Counter = Counter + 1
                        If Counter = 25 Then
                            GoTo End_Publisher
                        Else
                            GoTo Next_Publisher
                        End If
                    End If

                    x = x - 1
                Loop Until x = 0

                .txt_ThePublisher.Text = Mid(.ThePublisherData.Items(0), InStr(.ThePublisherData.Items(0), "^") + 2)
                .lbl_Selected.Text = " 1 / " & .ThePublisherData.Items.Count

                If .ThePublisherData.Items.Count = 0 Then GoTo Restart
End_Publisher:
                If My.Settings.SettingsSound = True Then My.Computer.Audio.Play(My.Resources.openwindow, AudioPlayMode.Background)
                .Show()
                .lbl_Selected.Update()
                .txt_ThePublisher.Update()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub WriteList(Data As String, TheList As ListBox)
        Try
            If File.Exists(Application.StartupPath & "\Saves\" & Data & ".dat") = True Then File.Delete(Application.StartupPath & "\Saves\" & Data & ".dat")

            Dim sw As New IO.StreamWriter(Application.StartupPath & "\Saves\" & Data & ".dat")
            For Each itm In TheList.Items
                sw.WriteLine(itm)
            Next

            sw.Flush()
            sw.Close()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub SaveGame()
        Try
            With FMain
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                               Listboxes
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                If Directory.Exists(Application.StartupPath & "\Saves") = False Then Directory.CreateDirectory(Application.StartupPath & "\Saves")

                Call WriteList("Companies", .Companies)
                Call WriteList("NewConsoles", .NewConsoles)
                Call WriteList("OldConsoles", .OldConsoles)
                Call WriteList("NewEngines", .NewEngines)
                Call WriteList("Employees", .EmployeeData)
                Call WriteList("ExpoList", .ExpoList)
                Call WriteList("NewGames", .NewGames)
                Call WriteList("OldGames", .OldGames)
                Call WriteList("DevelopStages", .DevelopStages)
                Call WriteList("lstSeq", .lstSeq)
                Call WriteList("Loans", .Loans)
                Call WriteList("Investments", .Investments)
                Call WriteList("Stocks", .Stocks)
                Call WriteList("OwnedStocks", .OwnedStocks)

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                               Data
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim list(66) As String

                If File.Exists(Application.StartupPath & "\Saves\Data.dat") = True Then File.Delete(Application.StartupPath & "\Saves\Data.dat")

                'basics
                list(1) = .YourCo.Text
                list(2) = .Cash.Text
                list(3) = .CashMax.Text
                list(4) = .Stage.Text
                list(5) = .TheYear.Text
                list(6) = .TheWeek.Text
                list(7) = .Hrs.Text
                list(8) = .TheMonth.Text

                'contracts
                list(9) = .Contract.CheckState
                list(10) = .cArt.Text
                list(11) = .cTech.Text
                list(12) = .ConCash.Text

                'engines
                list(13) = .Engine.CheckState

                'development info
                list(14) = .Overtime.Text
                list(15) = .GameFocus.Text
                list(16) = .RandomCounter.Text
                list(17) = .ThePublisher.Text
                list(18) = .OwedCut.Text
                list(19) = .DownPayment.Text
                list(20) = .AllWeeks.Text
                list(21) = .Marketing.Text
                list(22) = .Reputation.Text
                list(23) = .SetPublisher.CheckState
                list(24) = .SetPublisher.Text

                'development
                list(25) = .uDesign.Text
                list(26) = .uArt.Text
                list(27) = .uGameplay.Text
                list(28) = .uStory.Text
                list(29) = .uReplay.Text
                list(30) = .uMusic.Text
                list(31) = .uBugs.Text
                list(32) = .uInput.Text
                list(33) = .uGraphics.Text
                list(34) = .uSound.Text
                list(35) = .uNetwork.Text
                list(36) = .uPhysics.Text
                list(37) = .uGUI.Text
                list(38) = .uScripts.Text
                list(39) = .Trend.Text
                list(40) = .DevTeam.Text
                list(41) = .Develop.CheckState
                list(42) = .GameSize.Text
                list(43) = .EngConsole.Text
                list(44) = .EngName.Text
                list(45) = .GameName.Text
                list(46) = .GameInterest.Text
                list(47) = .GameEngine.Text
                list(48) = .GameGenre.Text
                list(49) = .SubGenre.Text
                list(50) = .GameConsole.Text

                'progress bars
                list(51) = .RadialBar1.Maximum
                list(52) = .RadialBar1.Value
                list(53) = .RadialBar2.Maximum
                list(54) = .RadialBar2.Value

                'console
                list(55) = .uCPU.Text
                list(56) = .uMemory.Text
                list(57) = .uSoftware.Text
                list(58) = .uProgramming.Text
                list(59) = .uStorage.Text
                list(60) = .uVideo.Text
                list(61) = .uAudio.Text
                list(62) = .ConsoleName.Text
                list(63) = .Console.CheckState
                list(64) = .CoMarketing.Text

                'game engine
                list(65) = .EngTech.Text
                list(66) = .EngUse.Text

                Dim sw = New IO.StreamWriter(Application.StartupPath & "\Saves\Data.dat")
                For Each itm In list
                    sw.WriteLine(itm)
                Next

                sw.Flush()
                sw.Close()

                Call MsgBox("Game successfully saved!", MsgBoxStyle.Information)

            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub ReadList(Data As String, TheList As ListBox)
        Try
            If File.Exists(Application.StartupPath & "\Saves\" & Data & ".dat") = False Then Exit Sub

            Dim fs As FileStream = New FileStream(Application.StartupPath & "\Saves\" & Data & ".dat", FileMode.Open)
            Dim sr As StreamReader = New StreamReader(fs)
            Do While sr.Peek <> -1
                TheList.Items.Add(sr.ReadLine)
            Loop

            sr.Close()
            fs.Close()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub LoadGame()

        Try
            If File.Exists(Application.StartupPath & "\Saves\Data.dat") = False Then
                Call MsgBox("No saved game found.", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Call NewGame(True)

            With FMain

                Call ReadList("Companies", .Companies)
                Call ReadList("NewConsoles", .NewConsoles)
                Call ReadList("OldConsoles", .OldConsoles)
                Call ReadList("NewEngines", .NewEngines)
                Call ReadList("Employees", .EmployeeData)
                Call ReadList("ExpoList", .ExpoList)
                Call ReadList("NewGames", .NewGames)
                Call ReadList("OldGames", .OldGames)
                Call ReadList("DevelopStages", .DevelopStages)
                Call ReadList("lstSeq", .lstSeq)
                Call ReadList("Loans", .Loans)
                Call ReadList("Investments", .Investments)
                Call ReadList("Stocks", .Stocks)
                Call ReadList("OwnedStocks", .OwnedStocks)

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '                                               Data
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Dim List(66) As String, i As Integer

                Dim fs As FileStream = New FileStream(Application.StartupPath & "\Saves\Data.dat", FileMode.Open)
                Dim sr As StreamReader = New StreamReader(fs)
                i = 0
                Do While sr.Peek <> -1
                    List(i) = sr.ReadLine
                    i = i + 1
                Loop

                sr.Close()

                fs.Close()

                'basics
                .YourCo.Text = List(1)
                .Cash.Text = List(2)
                .CashMax.Text = List(3)
                .Stage.Text = List(4)
                .TheYear.Text = List(5)
                .TheWeek.Text = List(6)
                .Hrs.Text = List(7)
                .TheMonth.Text = List(8)
                'contracts
                .Contract.CheckState = List(9)
                .cArt.Text = List(10)
                .cTech.Text = List(11)
                .ConCash.Text = List(12)

                'engines
                .Engine.CheckState = List(13)

                'development info
                .Overtime.Text = List(14)
                .GameFocus.Text = List(15)
                .RandomCounter.Text = List(16)
                .ThePublisher.Text = List(17)
                .OwedCut.Text = List(18)
                .DownPayment.Text = List(19)
                .AllWeeks.Text = List(20)
                .Marketing.Text = List(21)
                .Reputation.Text = List(22)
                .SetPublisher.CheckState = List(23)
                .SetPublisher.Text = List(24)

                'development
                .uDesign.Text = List(25)
                .uArt.Text = List(26)
                .uGameplay.Text = List(27)
                .uStory.Text = List(28)
                .uReplay.Text = List(29)
                .uMusic.Text = List(30)
                .uBugs.Text = List(31)
                .uInput.Text = List(32)
                .uGraphics.Text = List(33)
                .uSound.Text = List(34)
                .uNetwork.Text = List(35)
                .uPhysics.Text = List(36)
                .uGUI.Text = List(37)
                .uScripts.Text = List(38)

                .Trend.Text = List(39)
                .DevTeam.Text = List(40)
                .Develop.CheckState = List(41)
                .GameSize.Text = List(42)
                .EngConsole.Text = List(43)
                .EngName.Text = List(44)
                .GameName.Text = List(45)
                .GameInterest.Text = List(46)
                .GameEngine.Text = List(47)
                .GameGenre.Text = List(48)
                .SubGenre.Text = List(49)
                .GameConsole.Text = List(50)

                'progress bars
                .RadialBar1.Maximum = List(51)
                .RadialBar1.Value = List(52)
                .RadialBar2.Maximum = List(53)
                .RadialBar2.Value = List(54)

                'console
                .uCPU.Text = List(55)
                .uMemory.Text = List(56)
                .uSoftware.Text = List(57)
                .uProgramming.Text = List(58)
                .uStorage.Text = List(59)
                .uVideo.Text = List(60)
                .uAudio.Text = List(61)
                .ConsoleName.Text = List(62)
                .Console.CheckState = List(63)
                .CoMarketing.Text = List(64)

                .EngTech.Text = List(65)
                .EngUse.Text = List(66)

                .Show()
                .Timer1.Enabled = True

                If fSplash.Visible = True Then fSplash.Hide()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub QuitDev()
        Try
            With FMain
                .Timer1.Enabled = True
                .Stage.Text = "Idle"

                .Develop.Checked = False
                .AllWeeks.Text = -1

                .RadialBar1.Value = 0
                .RadialBar2.Value = 0

                .Panel2.Visible = False
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub GenAwards()
        Dim x As Long
        Dim intBest As Long, TheBest As String, BestSales As Long, BestCo As String, SetX As Long
        Dim GOTYGame As String, NewSales As Long, NewGame As String

        Try
            With FMain
                'get list of new games
                fAwards.lst_Awards.Items.Clear()
                x = .NewGames.Items.Count - 1
                If x = -1 Then GoTo OldGames

                Do
                    fAwards.lst_Awards.Items.Add(.NewGames.Items(x))
                    x = x - 1
                Loop Until x = -1

OldGames:
                'get old games within the year
                x = .OldGames.Items.Count - 1
                If x = -1 Then GoTo FindBest
                Do
                    If GetGame(.OldGames.Items(x), "Release") = .TheYear.Text Then
                        If .OldGames.Items(x).ToString.Contains("GOTY") = False Then 'No previous GOTY
                            fAwards.lst_Awards.Items.Add(.OldGames.Items(x))
                        End If
                    End If

                    x = x - 1
                Loop Until x = -1

                .Timer1.Enabled = False
            End With

FindBest:
            Dim Genre() As String = {"Adventure", "Action", "RPG", "Simulation", "Strategy", "Casual", "Party", "Puzzle", "Sports"}

            With fAwards
                '.ListBox1.Items.Clear()
                '.ListBox2.Items.Clear()
                .Label1.Text = ""
                .Label1.Top = 380
                .ListBox3.Items.Clear()

                For Each TheGen As String In Genre
                    x = fAwards.lst_Awards.Items.Count - 1
                    intBest = 0
                    TheBest = ""
                    BestSales = 0
                    BestCo = ""

                    Do
                        'Best rating?
                        If GetGame(fAwards.lst_Awards.Items(x), "Rating") > intBest And GetGame(fAwards.lst_Awards.Items(x), "Genre") = TheGen Then
                            intBest = GetGame(fAwards.lst_Awards.Items(x), "Rating")
                            TheBest = GetGame(fAwards.lst_Awards.Items(x), "Name")
                            BestSales = GetGame(fAwards.lst_Awards.Items(x), "Sales")
                            BestCo = GetGame(fAwards.lst_Awards.Items(x), "Company")
                            SetX = x
                            'What about sales?
                        ElseIf GetGame(fAwards.lst_Awards.Items(x), "Rating") = intBest And GetGame(fAwards.lst_Awards.Items(x), "Genre") = TheGen Then
                            If GetGame(fAwards.lst_Awards.Items(x), "Sales") > BestSales Then
                                intBest = GetGame(fAwards.lst_Awards.Items(x), "Rating")
                                TheBest = GetGame(fAwards.lst_Awards.Items(x), "Name")
                                BestSales = GetGame(fAwards.lst_Awards.Items(x), "Sales")
                                BestCo = GetGame(fAwards.lst_Awards.Items(x), "Company")
                                SetX = x
                            End If
                        End If
                        x = x - 1
                    Loop Until x = -1

                    'If TheBest <> "" Then .ListBox3.Items.Add("Best " & TheGen & ": " & TheBest & " (" & BestCo & ")")

                    If TheBest <> "" Then .Label1.Text = .Label1.Text & vbNewLine & "Best " & TheGen & ": " & TheBest & " (" & BestCo & ")"

                    'release game of the year edition if it isn't there
                    For Each itm In FMain.NewGames.Items
                        If InStr(itm, TheBest) <> 0 Then
                            If InStr(itm, "GOTY") <> 0 Then
                                GoTo SkipGOTY
                            Else
                                GoTo GenGOTY1
                            End If

                        End If
                    Next

GenGOTY1:
                    GOTYGame = TheBest & ": GOTY"
                    NewSales = Math.Round(BestSales * (GetRandom(5, 20) / 100))

                    NewGame = fAwards.lst_Awards.Items(SetX)
                    NewGame = GetGame(NewGame, "Name", GOTYGame)
                    NewGame = GetGame(NewGame, "PreviousSales", NewSales)
                    NewGame = GetGame(NewGame, "Sales", Math.Round(NewSales + BestSales))
                    NewGame = GetGame(NewGame, "Release", 1)
                    FMain.NewGames.Items.Add(NewGame)

SkipGOTY:
                    'if the player wins an award then add reputation
                    If BestCo = FMain.YourCo.Text Then FMain.Reputation.Text = Math.Round(FMain.Reputation.Text + GetRandom(200, 500))
                Next TheGen

FindMore:
                'Get the best categories
                Dim Category() As String = {"Design", "Art", "Gameplay", "Story", "Replay", "Audio"}

                For Each TheCat As String In Category
                    x = fAwards.lst_Awards.Items.Count - 1
                    intBest = 0
                    TheBest = ""
                    BestSales = 0
                    BestCo = ""

                    Do
                        'Best rating?
                        If GetGame(fAwards.lst_Awards.Items(x), TheCat) > intBest Then
                            intBest = GetGame(fAwards.lst_Awards.Items(x), TheCat)
                            TheBest = GetGame(fAwards.lst_Awards.Items(x), "Name")
                            BestSales = GetGame(fAwards.lst_Awards.Items(x), "Sales")
                            BestCo = GetGame(fAwards.lst_Awards.Items(x), "Company")
                            SetX = x
                            'What about sales?
                        ElseIf GetGame(fAwards.lst_Awards.Items(x), TheCat) = intBest And GetGame(fAwards.lst_Awards.Items(x), "Sales") > BestSales Then
                            intBest = GetGame(fAwards.lst_Awards.Items(x), TheCat)
                            TheBest = GetGame(fAwards.lst_Awards.Items(x), "Name")
                            BestSales = GetGame(fAwards.lst_Awards.Items(x), "Sales")
                            BestCo = GetGame(fAwards.lst_Awards.Items(x), "Company")
                            SetX = x
                        End If
                        x = x - 1
                    Loop Until x = -1

                    'rename for user's sake
                    If TheCat = "Design" Then TheCat = "Level Design"
                    If TheCat = "Replay" Then TheCat = "Replayability"
                    If TheCat = "Audio" Then TheCat = "Music"

                    '.ListBox3.Items.Add("Best " & TheCat & ": " & TheBest & " (" & BestCo & ")")
                    .Label1.Text = .Label1.Text & vbNewLine & "Best " & TheCat & ": " & TheBest & " (" & BestCo & ")"

                    'release game of the year edition
                    GOTYGame = TheBest & ": GOTY"
                    NewSales = Math.Round(BestSales * (GetRandom(5, 20) / 100))

                    'Scan to see if it's there or not
                    For Each itm In FMain.NewGames.Items
                        If InStr(itm, "GOTY") <> 0 Then
                            GoTo SkipGOTY2
                        Else
                            GoTo GenGOTY2
                        End If
                    Next

GenGOTY2:
                    NewGame = fAwards.lst_Awards.Items(SetX)
                    NewGame = GetGame(NewGame, "Name", GOTYGame)
                    NewGame = GetGame(NewGame, "PreviousSales", NewSales)
                    NewGame = GetGame(NewGame, "Sales", Math.Round(NewSales + BestSales))
                    NewGame = GetGame(NewGame, "Release", 1)
                    FMain.NewGames.Items.Add(NewGame)

SkipGOTY2:
                    'if the player wins an award then add reputation
                    If BestCo = FMain.YourCo.Text Then FMain.Reputation.Text = Math.Round(FMain.Reputation.Text + GetRandom(50, 150))
                Next TheCat

                .lst_Awards.Update()
                .Button2.Enabled = False
                .Timer1.Enabled = True
                .Show()
            End With

            FMain.OldGames.Update()
            FMain.NewGames.Update()
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try
    End Sub
    Public Sub Staffing()
        Dim TheSeat As Integer = 1
        Dim TempSeat As Integer

        Try
            With fHire
                'clear stuff
                .ListBox1.Items.Clear()
                .ListBox2.Items.Clear()

                .StaffList.Items.Clear()
                .StaffData.Items.Clear()

                'Load current staff
                For Each itm In FMain.EmployeeData.Items
                    .StaffData.Items.Add(itm)
                    .StaffList.Items.Add(GetEmployee(itm, "Name"))
                Next

                'Fill default values
                .txt_Position.Text = GetEmployee(.StaffData.Items(0), "Position")
                .txt_Salary.Text = GetEmployee(.StaffData.Items(0), "Salary")

                .ArtBar.Value = GetEmployee(.StaffData.Items(0), "Artist")
                .TechBar.Value = GetEmployee(.StaffData.Items(0), "Tech")
                .SpeedBar.Value = GetEmployee(.StaffData.Items(0), "Speed")
                .StressBar.Value = GetEmployee(.StaffData.Items(0), "StressMax")

                'Finds the first vacated seat
                Dim tmpList As ListBox = New ListBox
                Dim x As Integer = 2

                Do
                    tmpList.Items.Add(x)
                    x = x + 1
                Loop Until x = 22

                For Each itm In FMain.EmployeeData.Items
                    TempSeat = GetEmployee(itm, "Seat")
                    Dim y As Integer = tmpList.FindStringExact(TempSeat)
                    If y <> -1 Then tmpList.Items.RemoveAt(y)
                Next

                .Seat.Text = tmpList.Items(0)

                .Show()
            End With
        Catch ex As Exception
            Call WriteLog(ex.ToString)
        End Try

    End Sub
    Public Sub WriteLog(txt As String)
        Dim sw = New IO.StreamWriter(Application.StartupPath & "\Errors\log.txt")
        sw.WriteLine(Now & " - " & txt)

        sw.Flush()
        sw.Close()
    End Sub
End Module
