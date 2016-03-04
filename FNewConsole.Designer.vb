<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FNewConsole
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
        Me.DefinedWeeks = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ConsoleName = New dsTycoon.SLCTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BaWGUITrackBar1 = New dsTycoon.BaWGUITrackBar()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TheVideoandAudio = New System.Windows.Forms.Label()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.TrackBar4 = New dsTycoon.BaWGUITrackBar()
        Me.TrackBar3 = New dsTycoon.BaWGUITrackBar()
        Me.TrackBar2 = New dsTycoon.BaWGUITrackBar()
        Me.SlcGroupBox2 = New dsTycoon.SLCGroupBox()
        Me.HScrollBar1 = New dsTycoon.BaWGUITrackBar()
        Me.TextBox1 = New dsTycoon.SLCTextBox()
        Me.Button1 = New dsTycoon.SLCbtn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TheHardware = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TheProgramming = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TheSoftware = New System.Windows.Forms.Label()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.SlcTheme1.SuspendLayout()
        Me.SlcGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.DefinedWeeks)
        Me.SlcTheme1.Controls.Add(Me.Label8)
        Me.SlcTheme1.Controls.Add(Me.ConsoleName)
        Me.SlcTheme1.Controls.Add(Me.Button3)
        Me.SlcTheme1.Controls.Add(Me.BaWGUITrackBar1)
        Me.SlcTheme1.Controls.Add(Me.Label23)
        Me.SlcTheme1.Controls.Add(Me.Label2)
        Me.SlcTheme1.Controls.Add(Me.TheVideoandAudio)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn1)
        Me.SlcTheme1.Controls.Add(Me.TrackBar4)
        Me.SlcTheme1.Controls.Add(Me.TrackBar3)
        Me.SlcTheme1.Controls.Add(Me.TrackBar2)
        Me.SlcTheme1.Controls.Add(Me.SlcGroupBox2)
        Me.SlcTheme1.Controls.Add(Me.Label5)
        Me.SlcTheme1.Controls.Add(Me.TheHardware)
        Me.SlcTheme1.Controls.Add(Me.Label7)
        Me.SlcTheme1.Controls.Add(Me.TheProgramming)
        Me.SlcTheme1.Controls.Add(Me.Label3)
        Me.SlcTheme1.Controls.Add(Me.TheSoftware)
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(514, 399)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 31
        Me.SlcTheme1.Text = "New Console"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'DefinedWeeks
        '
        Me.DefinedWeeks.AutoSize = True
        Me.DefinedWeeks.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DefinedWeeks.Location = New System.Drawing.Point(473, 361)
        Me.DefinedWeeks.Name = "DefinedWeeks"
        Me.DefinedWeeks.Size = New System.Drawing.Size(14, 13)
        Me.DefinedWeeks.TabIndex = 73
        Me.DefinedWeeks.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(369, 361)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "Defined Weeks:"
        '
        'ConsoleName
        '
        Me.ConsoleName.Location = New System.Drawing.Point(31, 66)
        Me.ConsoleName.MaxLength = 32767
        Me.ConsoleName.Multiline = False
        Me.ConsoleName.Name = "ConsoleName"
        Me.ConsoleName.ReadOnly = False
        Me.ConsoleName.Size = New System.Drawing.Size(225, 24)
        Me.ConsoleName.TabIndex = 29
        Me.ConsoleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ConsoleName.UseSystemPasswordChar = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Image = Global.dsTycoon.My.Resources.Resources.dice
        Me.Button3.Location = New System.Drawing.Point(270, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 38)
        Me.Button3.TabIndex = 28
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BaWGUITrackBar1
        '
        Me.BaWGUITrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.BaWGUITrackBar1.Location = New System.Drawing.Point(281, 305)
        Me.BaWGUITrackBar1.Maximum = 312
        Me.BaWGUITrackBar1.Minimum = 0
        Me.BaWGUITrackBar1.Name = "BaWGUITrackBar1"
        Me.BaWGUITrackBar1.Size = New System.Drawing.Size(216, 37)
        Me.BaWGUITrackBar1.TabIndex = 71
        Me.BaWGUITrackBar1.Text = "TrackBar5"
        Me.BaWGUITrackBar1.Value = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(28, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(280, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Video and Audio:"
        '
        'TheVideoandAudio
        '
        Me.TheVideoandAudio.AutoSize = True
        Me.TheVideoandAudio.BackColor = System.Drawing.Color.Transparent
        Me.TheVideoandAudio.Location = New System.Drawing.Point(389, 287)
        Me.TheVideoandAudio.Name = "TheVideoandAudio"
        Me.TheVideoandAudio.Size = New System.Drawing.Size(14, 13)
        Me.TheVideoandAudio.TabIndex = 70
        Me.TheVideoandAudio.Text = "1"
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(217, 351)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(75, 23)
        Me.SlCbtn1.TabIndex = 68
        Me.SlCbtn1.Text = "    Start"
        Me.SlCbtn1.Transparent = False
        '
        'TrackBar4
        '
        Me.TrackBar4.BackColor = System.Drawing.Color.Transparent
        Me.TrackBar4.Location = New System.Drawing.Point(279, 239)
        Me.TrackBar4.Maximum = 312
        Me.TrackBar4.Minimum = 0
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(216, 37)
        Me.TrackBar4.TabIndex = 67
        Me.TrackBar4.Text = "BaWGUITrackBar3"
        Me.TrackBar4.Value = 0
        '
        'TrackBar3
        '
        Me.TrackBar3.BackColor = System.Drawing.Color.Transparent
        Me.TrackBar3.Location = New System.Drawing.Point(36, 305)
        Me.TrackBar3.Maximum = 312
        Me.TrackBar3.Minimum = 0
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(216, 37)
        Me.TrackBar3.TabIndex = 66
        Me.TrackBar3.Text = "BaWGUITrackBar2"
        Me.TrackBar3.Value = 0
        '
        'TrackBar2
        '
        Me.TrackBar2.BackColor = System.Drawing.Color.Transparent
        Me.TrackBar2.Location = New System.Drawing.Point(36, 239)
        Me.TrackBar2.Maximum = 312
        Me.TrackBar2.Minimum = 0
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(216, 37)
        Me.TrackBar2.TabIndex = 65
        Me.TrackBar2.Text = "BaWGUITrackBar1"
        Me.TrackBar2.Value = 0
        '
        'SlcGroupBox2
        '
        Me.SlcGroupBox2.Controls.Add(Me.HScrollBar1)
        Me.SlcGroupBox2.Controls.Add(Me.TextBox1)
        Me.SlcGroupBox2.Controls.Add(Me.Button1)
        Me.SlcGroupBox2.Controls.Add(Me.Label6)
        Me.SlcGroupBox2.Controls.Add(Me.Label4)
        Me.SlcGroupBox2.Controls.Add(Me.Label1)
        Me.SlcGroupBox2.DrawSeperator = False
        Me.SlcGroupBox2.Location = New System.Drawing.Point(31, 96)
        Me.SlcGroupBox2.Name = "SlcGroupBox2"
        Me.SlcGroupBox2.Size = New System.Drawing.Size(464, 113)
        Me.SlcGroupBox2.SubTitle = "What is the risk level you're willing to take?"
        Me.SlcGroupBox2.TabIndex = 58
        Me.SlcGroupBox2.Text = "Project Timeframe"
        Me.SlcGroupBox2.Title = "Project Timeframe"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.HScrollBar1.Location = New System.Drawing.Point(15, 38)
        Me.HScrollBar1.Maximum = 312
        Me.HScrollBar1.Minimum = 208
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(421, 37)
        Me.HScrollBar1.TabIndex = 50
        Me.HScrollBar1.Text = "HScrollBar1"
        Me.HScrollBar1.Value = 260
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 78)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(75, 24)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = "260"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Button1
        '
        Me.Button1.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button1.Customization = ""
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(276, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "   Accept"
        Me.Button1.Transparent = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(376, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "High Risk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(12, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Low Risk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(84, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Define Timeline:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(33, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Hardware Design:"
        '
        'TheHardware
        '
        Me.TheHardware.AutoSize = True
        Me.TheHardware.BackColor = System.Drawing.Color.Transparent
        Me.TheHardware.Location = New System.Drawing.Point(149, 221)
        Me.TheHardware.Name = "TheHardware"
        Me.TheHardware.Size = New System.Drawing.Size(14, 13)
        Me.TheHardware.TabIndex = 60
        Me.TheHardware.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(35, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Programming:"
        '
        'TheProgramming
        '
        Me.TheProgramming.AutoSize = True
        Me.TheProgramming.BackColor = System.Drawing.Color.Transparent
        Me.TheProgramming.Location = New System.Drawing.Point(129, 283)
        Me.TheProgramming.Name = "TheProgramming"
        Me.TheProgramming.Size = New System.Drawing.Size(14, 13)
        Me.TheProgramming.TabIndex = 62
        Me.TheProgramming.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(276, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Software Design:"
        '
        'TheSoftware
        '
        Me.TheSoftware.AutoSize = True
        Me.TheSoftware.BackColor = System.Drawing.Color.Transparent
        Me.TheSoftware.Location = New System.Drawing.Point(389, 221)
        Me.TheSoftware.Name = "TheSoftware"
        Me.TheSoftware.Size = New System.Drawing.Size(14, 13)
        Me.TheSoftware.TabIndex = 64
        Me.TheSoftware.Text = "1"
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(491, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 30
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'FNewConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 399)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FNewConsole"
        Me.Text = "FNewConsole"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.SlcGroupBox2.ResumeLayout(False)
        Me.SlcGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ConsoleName As dsTycoon.SLCTextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
    Friend WithEvents BaWGUITrackBar1 As dsTycoon.BaWGUITrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TheVideoandAudio As System.Windows.Forms.Label
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents TrackBar4 As dsTycoon.BaWGUITrackBar
    Friend WithEvents TrackBar3 As dsTycoon.BaWGUITrackBar
    Friend WithEvents TrackBar2 As dsTycoon.BaWGUITrackBar
    Friend WithEvents SlcGroupBox2 As dsTycoon.SLCGroupBox
    Friend WithEvents HScrollBar1 As dsTycoon.BaWGUITrackBar
    Friend WithEvents TextBox1 As dsTycoon.SLCTextBox
    Friend WithEvents Button1 As dsTycoon.SLCbtn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TheHardware As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TheProgramming As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TheSoftware As System.Windows.Forms.Label
    Friend WithEvents DefinedWeeks As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
