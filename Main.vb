Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Module Main
    Public Enum ImageType As Integer
        PNG = 0
        JPEG = 1
        BMP = 2
        GIF = 3
    End Enum

    Public Function GetRndBrush(width As Integer, height As Integer, Optional RndAlpha As Boolean = False) As Brush
        Randomize() : Dim ch As Integer = CInt(Int(1000 * Rnd()))
        If ch < 500 Then
            Return New SolidBrush(GetRndColor(RndAlpha))
        Else
            Return New LinearGradientBrush(New Point(0, 0), New Point(width, height), GetRndColor(RndAlpha), GetRndColor(RndAlpha))
        End If
    End Function

    Public Function GetRndColor(Optional RndAlpha As Boolean = False) As Color
        Randomize() : Dim r1 As Integer = CInt(Int(10000 * Rnd()))
        Randomize() : Dim rnd1 As Integer = CInt(Int(255 * Rnd()))
        Randomize() : Dim rnd2 As Integer = CInt(Int(255 * Rnd()))
        Randomize() : Dim rnd3 As Integer = CInt(Int(255 * Rnd()))
        Randomize() : Dim rnd4 As Integer = CInt(Int(155 * Rnd()) + 100)

        If r1 > 5000 Then
            If RndAlpha Then
                Return Color.FromArgb(rnd4, 255 - rnd1, 255 - rnd2, 255 - rnd3)
            Else
                Return Color.FromArgb(255 - rnd1, 255 - rnd2, 255 - rnd3)
            End If
        Else
            If RndAlpha Then
                Return Color.FromArgb(rnd4, rnd1, rnd2, rnd3)
            Else
                Return Color.FromArgb(rnd1, rnd2, rnd3)
            End If
        End If
    End Function
End Module
