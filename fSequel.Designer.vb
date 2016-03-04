<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSequel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.Button2 = New dsTycoon.SLCbtn()
        Me.SlCbtn2 = New dsTycoon.SLCbtn()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.lst_Games = New System.Windows.Forms.ListBox()
        Me.lbl_Selected = New dsTycoon.SLCLabel()
        Me.txt_Game = New dsTycoon.SLCTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.Button2)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn2)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn1)
        Me.SlcTheme1.Controls.Add(Me.lst_Games)
        Me.SlcTheme1.Controls.Add(Me.lbl_Selected)
        Me.SlcTheme1.Controls.Add(Me.txt_Game)
        Me.SlcTheme1.Controls.Add(Me.Label2)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = False
        Me.SlcTheme1.Size = New System.Drawing.Size(339, 207)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 56
        Me.SlcTheme1.Text = "New Game"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'Button2
        '
        Me.Button2.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button2.Customization = ""
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(246, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "   Accept"
        Me.Button2.Transparent = False
        '
        'SlCbtn2
        '
        Me.SlCbtn2.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn2.Customization = ""
        Me.SlCbtn2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn2.Image = Nothing
        Me.SlCbtn2.Location = New System.Drawing.Point(97, 170)
        Me.SlCbtn2.Name = "SlCbtn2"
        Me.SlCbtn2.NoRounding = False
        Me.SlCbtn2.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn2.TabIndex = 54
        Me.SlCbtn2.Text = ">"
        Me.SlCbtn2.Transparent = False
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(12, 170)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn1.TabIndex = 53
        Me.SlCbtn1.Text = "<"
        Me.SlCbtn1.Transparent = False
        '
        'lst_Games
        '
        Me.lst_Games.FormattingEnabled = True
        Me.lst_Games.HorizontalScrollbar = True
        Me.lst_Games.Location = New System.Drawing.Point(38, 208)
        Me.lst_Games.Name = "lst_Games"
        Me.lst_Games.Size = New System.Drawing.Size(289, 43)
        Me.lst_Games.TabIndex = 48
        Me.lst_Games.Visible = False
        '
        'lbl_Selected
        '
        Me.lbl_Selected.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Selected.Location = New System.Drawing.Point(43, 170)
        Me.lbl_Selected.Name = "lbl_Selected"
        Me.lbl_Selected.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Selected.TabIndex = 52
        Me.lbl_Selected.Text = "1 / 1"
        '
        'txt_Game
        '
        Me.txt_Game.Location = New System.Drawing.Point(12, 57)
        Me.txt_Game.MaxLength = 32767
        Me.txt_Game.Multiline = True
        Me.txt_Game.Name = "txt_Game"
        Me.txt_Game.ReadOnly = True
        Me.txt_Game.Size = New System.Drawing.Size(309, 107)
        Me.txt_Game.TabIndex = 51
        Me.txt_Game.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Game.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Select a game you want to follow up:"
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(314, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 56
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'fSequel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 207)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "fSequel"
        Me.Text = "fSequel"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents Button2 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn2 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents lbl_Selected As dsTycoon.SLCLabel
    Friend WithEvents txt_Game As dsTycoon.SLCTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lst_Games As System.Windows.Forms.ListBox
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
End Class
