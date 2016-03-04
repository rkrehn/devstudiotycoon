<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDirection
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcGroupBox1 = New dsTycoon.SLCGroupBox()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.SlcProgrssBar2 = New dsTycoon.SLCProgrssBar()
        Me.Max2 = New dsTycoon.SLCLabel()
        Me.SlcProgrssBar1 = New dsTycoon.SLCProgrssBar()
        Me.Max1 = New dsTycoon.SLCLabel()
        Me.SlcLabel2 = New dsTycoon.SLCLabel()
        Me.SlcLabel1 = New dsTycoon.SLCLabel()
        Me.StaffData = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SlCbtn2 = New dsTycoon.SLCbtn()
        Me.TechBar = New dsTycoon.SLCProgrssBar()
        Me.ArtBar = New dsTycoon.SLCProgrssBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Position = New System.Windows.Forms.Label()
        Me.StaffList = New System.Windows.Forms.ListBox()
        Me.SlcTheme1.SuspendLayout()
        Me.SlcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcGroupBox1)
        Me.SlcTheme1.Controls.Add(Me.StaffData)
        Me.SlcTheme1.Controls.Add(Me.Label1)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn2)
        Me.SlcTheme1.Controls.Add(Me.TechBar)
        Me.SlcTheme1.Controls.Add(Me.ArtBar)
        Me.SlcTheme1.Controls.Add(Me.Label10)
        Me.SlcTheme1.Controls.Add(Me.Label11)
        Me.SlcTheme1.Controls.Add(Me.Label12)
        Me.SlcTheme1.Controls.Add(Me.txt_Position)
        Me.SlcTheme1.Controls.Add(Me.StaffList)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(337, 274)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 0
        Me.SlcTheme1.Text = "Select Leader"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcGroupBox1
        '
        Me.SlcGroupBox1.Controls.Add(Me.SlCbtn1)
        Me.SlcGroupBox1.Controls.Add(Me.SlcProgrssBar2)
        Me.SlcGroupBox1.Controls.Add(Me.Max2)
        Me.SlcGroupBox1.Controls.Add(Me.SlcProgrssBar1)
        Me.SlcGroupBox1.Controls.Add(Me.Max1)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel2)
        Me.SlcGroupBox1.Controls.Add(Me.SlcLabel1)
        Me.SlcGroupBox1.DrawSeperator = False
        Me.SlcGroupBox1.Location = New System.Drawing.Point(15, 66)
        Me.SlcGroupBox1.Name = "SlcGroupBox1"
        Me.SlcGroupBox1.Size = New System.Drawing.Size(310, 185)
        Me.SlcGroupBox1.SubTitle = "How your decision reflects the game's outcome"
        Me.SlcGroupBox1.TabIndex = 59
        Me.SlcGroupBox1.Text = "SlcGroupBox1"
        Me.SlcGroupBox1.Title = "Reward"
        Me.SlcGroupBox1.Visible = False
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(115, 145)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(75, 23)
        Me.SlCbtn1.TabIndex = 4
        Me.SlCbtn1.Text = "   Close"
        Me.SlCbtn1.Transparent = False
        '
        'SlcProgrssBar2
        '
        Me.SlcProgrssBar2.Location = New System.Drawing.Point(15, 108)
        Me.SlcProgrssBar2.Maximum = 100
        Me.SlcProgrssBar2.Minimum = 0
        Me.SlcProgrssBar2.Name = "SlcProgrssBar2"
        Me.SlcProgrssBar2.Size = New System.Drawing.Size(286, 23)
        Me.SlcProgrssBar2.TabIndex = 3
        Me.SlcProgrssBar2.Text = "SlcProgrssBar2"
        Me.SlcProgrssBar2.Value = 0
        '
        'Max2
        '
        Me.Max2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Max2.Location = New System.Drawing.Point(261, 89)
        Me.Max2.Name = "Max2"
        Me.Max2.Size = New System.Drawing.Size(39, 13)
        Me.Max2.TabIndex = 61
        Me.Max2.Text = "SlcLabel4"
        Me.Max2.Visible = False
        '
        'SlcProgrssBar1
        '
        Me.SlcProgrssBar1.Location = New System.Drawing.Point(14, 60)
        Me.SlcProgrssBar1.Maximum = 100
        Me.SlcProgrssBar1.Minimum = 0
        Me.SlcProgrssBar1.Name = "SlcProgrssBar1"
        Me.SlcProgrssBar1.Size = New System.Drawing.Size(286, 23)
        Me.SlcProgrssBar1.TabIndex = 2
        Me.SlcProgrssBar1.Text = "SlcProgrssBar1"
        Me.SlcProgrssBar1.Value = 0
        '
        'Max1
        '
        Me.Max1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Max1.Location = New System.Drawing.Point(261, 41)
        Me.Max1.Name = "Max1"
        Me.Max1.Size = New System.Drawing.Size(39, 13)
        Me.Max1.TabIndex = 60
        Me.Max1.Text = "SlcLabel3"
        Me.Max1.Visible = False
        '
        'SlcLabel2
        '
        Me.SlcLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcLabel2.Location = New System.Drawing.Point(14, 89)
        Me.SlcLabel2.Name = "SlcLabel2"
        Me.SlcLabel2.Size = New System.Drawing.Size(176, 13)
        Me.SlcLabel2.TabIndex = 1
        Me.SlcLabel2.Text = "SlcLabel2"
        '
        'SlcLabel1
        '
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcLabel1.Location = New System.Drawing.Point(14, 39)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(135, 15)
        Me.SlcLabel1.TabIndex = 0
        Me.SlcLabel1.Text = "SlcLabel1"
        '
        'StaffData
        '
        Me.StaffData.FormattingEnabled = True
        Me.StaffData.Location = New System.Drawing.Point(195, 66)
        Me.StaffData.Name = "StaffData"
        Me.StaffData.Size = New System.Drawing.Size(120, 95)
        Me.StaffData.TabIndex = 58
        Me.StaffData.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Who will lead the next part of this project?"
        '
        'SlCbtn2
        '
        Me.SlCbtn2.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn2.Customization = ""
        Me.SlCbtn2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn2.Image = Nothing
        Me.SlCbtn2.Location = New System.Drawing.Point(241, 211)
        Me.SlCbtn2.Name = "SlCbtn2"
        Me.SlCbtn2.NoRounding = False
        Me.SlCbtn2.Size = New System.Drawing.Size(75, 23)
        Me.SlCbtn2.TabIndex = 54
        Me.SlCbtn2.Text = "   Select"
        Me.SlCbtn2.Transparent = False
        '
        'TechBar
        '
        Me.TechBar.Location = New System.Drawing.Point(122, 228)
        Me.TechBar.Maximum = 100
        Me.TechBar.Minimum = 0
        Me.TechBar.Name = "TechBar"
        Me.TechBar.Size = New System.Drawing.Size(109, 23)
        Me.TechBar.TabIndex = 52
        Me.TechBar.Text = "SlcProgrssBar2"
        Me.TechBar.Value = 0
        '
        'ArtBar
        '
        Me.ArtBar.Location = New System.Drawing.Point(122, 203)
        Me.ArtBar.Maximum = 100
        Me.ArtBar.Minimum = 0
        Me.ArtBar.Name = "ArtBar"
        Me.ArtBar.Size = New System.Drawing.Size(109, 23)
        Me.ArtBar.TabIndex = 51
        Me.ArtBar.Text = "ArtBar"
        Me.ArtBar.Value = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(60, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Art Skills"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(23, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Technical Skills:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(26, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Position:"
        '
        'txt_Position
        '
        Me.txt_Position.AutoSize = True
        Me.txt_Position.BackColor = System.Drawing.Color.Transparent
        Me.txt_Position.Location = New System.Drawing.Point(88, 190)
        Me.txt_Position.Name = "txt_Position"
        Me.txt_Position.Size = New System.Drawing.Size(37, 13)
        Me.txt_Position.TabIndex = 46
        Me.txt_Position.Text = "Artist"
        '
        'StaffList
        '
        Me.StaffList.FormattingEnabled = True
        Me.StaffList.Location = New System.Drawing.Point(29, 66)
        Me.StaffList.Name = "StaffList"
        Me.StaffList.Size = New System.Drawing.Size(286, 121)
        Me.StaffList.TabIndex = 43
        '
        'FDirection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 274)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FDirection"
        Me.Text = "FDirection"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.SlcGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents SlCbtn2 As dsTycoon.SLCbtn
    Friend WithEvents TechBar As dsTycoon.SLCProgrssBar
    Friend WithEvents ArtBar As dsTycoon.SLCProgrssBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Position As System.Windows.Forms.Label
    Friend WithEvents StaffList As System.Windows.Forms.ListBox
    Friend WithEvents StaffData As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SlcGroupBox1 As dsTycoon.SLCGroupBox
    Friend WithEvents SlcProgrssBar2 As dsTycoon.SLCProgrssBar
    Friend WithEvents SlcProgrssBar1 As dsTycoon.SLCProgrssBar
    Friend WithEvents SlcLabel2 As dsTycoon.SLCLabel
    Friend WithEvents SlcLabel1 As dsTycoon.SLCLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents Max2 As dsTycoon.SLCLabel
    Friend WithEvents Max1 As dsTycoon.SLCLabel
End Class
