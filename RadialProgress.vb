'Creator: Aeonhack
'Release: January 6th, 2010
'Version: 1.0.0.0
'Website: www.elitevs.net
'Colors modified by Zer0, original was green and is lost.

Imports System.Drawing.Drawing2D
Public Class RadialBar : Inherits Control

    Sub New()
        Size = New Size(150, 150)
        Font = New Font("Verdana", 14.0!)
    End Sub

    'Notice in our properties, in the set routine we call 'Invalidate()' this will cause the
    'control to redraw anytime the values are changed.

    Private _Value As Long
    Public Property Value() As Long
        Get
            Return _Value
        End Get
        Set(ByVal v As Long)
            If v > _Maximum Then v = _Maximum
            _Value = v : Invalidate()
        End Set
    End Property

    Private _Maximum As Long = 100
    Public Property Maximum() As Long
        Get
            Return _Maximum
        End Get
        Set(ByVal v As Long)
            If v < 1 Then v = 1
            _Maximum = v : Invalidate()
        End Set
    End Property

    Private _Thickness As Integer = 20
    Public Property Thickness() As Integer
        Get
            Return _Thickness
        End Get
        Set(ByVal v As Integer)
            _Thickness = v : Invalidate()
        End Set
    End Property

    'Handle PaintBackground to prevent flicker
    Protected Overrides Sub OnPaintBackground(ByVal p As PaintEventArgs)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        'Create image buffer
        Using B As New Bitmap(Width, Height)
            Using G As Graphics = Graphics.FromImage(B)
                'Enable anti-aliasing to prevent rough edges
                G.SmoothingMode = SmoothingMode.HighQuality

                'Fill background color
                G.Clear(BackColor)

                'Draw progress background
                Using T As New LinearGradientBrush(ClientRectangle, Color.White, Color.White, LinearGradientMode.Vertical)
                    Using P As New Pen(T, Thickness)
                        G.DrawArc(P, CInt(Thickness / 2), CInt(Thickness / 2), Width - Thickness - 1, Height - Thickness - 1, 0, 360)
                    End Using
                End Using

                'Draw progress
                Using T As New LinearGradientBrush(ClientRectangle, Color.FromArgb(38, 138, 201), Color.FromArgb(108, 137, 184), LinearGradientMode.Vertical)
                    Using P As New Pen(T, Thickness)
                        P.StartCap = LineCap.Round : P.EndCap = LineCap.Round
                        G.DrawArc(P, CInt(Thickness / 2), CInt(Thickness / 2), Width - Thickness - 1, Height - Thickness - 1, -90, CInt((360 / _Maximum) * _Value))
                    End Using
                End Using

                'Draw center
                Using T As New LinearGradientBrush(ClientRectangle, Color.FromArgb(108, 137, 184), Color.Black, LinearGradientMode.Vertical)
                    G.FillEllipse(T, Thickness, Thickness, Width - Thickness * 2 - 1, Height - Thickness * 2 - 1)
                End Using

                'Draw progress string
                Dim S As SizeF = G.MeasureString(CStr(CInt((100 / _Maximum) * _Value)), Font)
                G.DrawString(CStr(CInt((100 / _Maximum) * _Value)), Font, Brushes.White, CInt(Width / 2 - S.Width / 2), CInt(Height / 2 - S.Height / 2))

                'Draw outter border
                G.DrawEllipse(Pens.Black, 0, 0, Width - 1, Height - 1)

                'Draw inner border
                G.DrawEllipse(Pens.Black, Thickness, Thickness, Width - Thickness * 2 - 1, Height - Thickness * 2 - 1)

                'Output the buffered image
                e.Graphics.DrawImage(B, 0, 0)
            End Using
        End Using

    End Sub

End Class
