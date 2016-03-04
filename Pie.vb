Imports System.Drawing
Imports System.IO

Public Class Pie
    Private img As Bitmap
    Private vData As Dictionary(Of String, PieData)
    Private vVertical As Boolean = False

#Region "Properties"
    Public ReadOnly Property Image() As Bitmap
        Get
            Return img
        End Get
    End Property
#End Region

#Region "Public Functions"
    Public Sub WriteStream(ImageType As ImageType, ByRef Output As Stream)
        Select Case ImageType
            Case Main.ImageType.JPEG
                img.Save(Output, Imaging.ImageFormat.Jpeg)
            Case Main.ImageType.GIF
                img.Save(Output, Imaging.ImageFormat.Gif)
            Case Main.ImageType.BMP
                img.Save(Output, Imaging.ImageFormat.Bmp)
            Case Else
                img.Save(Output, Imaging.ImageFormat.Png)
        End Select
    End Sub

    Public Function GetFile(ImageType As ImageType) As Byte()
        Dim rc(0) As Byte

        Dim st As MemoryStream = New MemoryStream
        Dim g As New Guid

        Select Case ImageType
            Case Main.ImageType.JPEG
                img.Save(st, Imaging.ImageFormat.Jpeg)
            Case Main.ImageType.GIF
                img.Save(st, Imaging.ImageFormat.Gif)
            Case Main.ImageType.BMP
                img.Save(st, Imaging.ImageFormat.Bmp)
            Case Else
                img.Save(st, Imaging.ImageFormat.Png)
        End Select

        st.Position = 0
        Dim count As Integer = 0
        ReDim rc(st.Length - 1)
        While (count < st.Length)
            rc(count) = Convert.ToByte(st.ReadByte())
            count += 1
        End While

        Return rc
    End Function
#End Region

#Region "Private Functions"
    ' X = Width
    ' Y = Height
    Private Sub DoBorders()
        Dim g As Graphics = Graphics.FromImage(img)

        g.DrawRectangle(Pens.Black, 0, 0, img.Width - Pens.Black.Width, img.Height - Pens.Black.Width)
    End Sub

    Private Sub DoGraph()
        Dim g As Graphics = Graphics.FromImage(img)
        Dim cnt As Integer = -1, curAngle As Integer = 0
        Dim totalValue As Long = 0, angleValue As Single = 3.6

        For Each kvp As KeyValuePair(Of String, PieData) In vData
            totalValue += kvp.Value.Value
        Next

        angleValue = 360 / totalValue

        For Each kvp As KeyValuePair(Of String, PieData) In vData
            cnt += 1
            Dim sw As Integer = (kvp.Value.Value * angleValue)
            g.FillPie(kvp.Value.Color, 10, 10, img.Width - 20, img.Height - 20, curAngle, sw)
            curAngle += sw
        Next
    End Sub
#End Region

#Region "Initialisation"
    Public Sub New(Width As Integer, Height As Integer, Data As Dictionary(Of String, PieData))
        img = New Bitmap(Width, Height)
        vData = Data
        DoGraph()
        'DoBorders()
    End Sub
#End Region

#Region "Internal Structures"
    Public Structure PieData
        Private vValue As Long
        Private vBrush As Brush

        Public ReadOnly Property Value As Long
            Get
                Return vValue
            End Get
        End Property

        Public ReadOnly Property Color As Brush
            Get
                Return vBrush
            End Get
        End Property

        Public Sub New(Value As Long, Brush As Brush)
            vValue = Value
            vBrush = Brush
        End Sub
    End Structure
#End Region
End Class
