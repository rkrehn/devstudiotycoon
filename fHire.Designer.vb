<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fHire))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Seat = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PositionTitle = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.DotNetBarTabcontrol1 = New dsTycoon.DotNetBarTabcontrol()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_Cost = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New dsTycoon.SLCComboBox()
        Me.Button1 = New dsTycoon.SLCbtn()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.ProgressBar3 = New dsTycoon.SLCProgrssBar()
        Me.ProgressBar2 = New dsTycoon.SLCProgrssBar()
        Me.ProgressBar1 = New dsTycoon.SLCProgrssBar()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SpeedBar = New dsTycoon.SLCProgrssBar()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.SlCbtn3 = New dsTycoon.SLCbtn()
        Me.SlCbtn2 = New dsTycoon.SLCbtn()
        Me.StressBar = New dsTycoon.SLCProgrssBar()
        Me.TechBar = New dsTycoon.SLCProgrssBar()
        Me.ArtBar = New dsTycoon.SLCProgrssBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Position = New System.Windows.Forms.Label()
        Me.txt_Salary = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.StaffData = New System.Windows.Forms.ListBox()
        Me.StaffList = New System.Windows.Forms.ListBox()
        Me.SlcTheme1.SuspendLayout()
        Me.DotNetBarTabcontrol1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(78, 53)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(198, 108)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Names:"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(260, 88)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(50, 43)
        Me.ListBox2.TabIndex = 8
        Me.ListBox2.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(18, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Technical Skills:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(16, 241)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Stress Handling:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(16, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Select Position:"
        '
        'Seat
        '
        Me.Seat.AutoSize = True
        Me.Seat.BackColor = System.Drawing.Color.Transparent
        Me.Seat.Location = New System.Drawing.Point(277, 134)
        Me.Seat.Name = "Seat"
        Me.Seat.Size = New System.Drawing.Size(44, 13)
        Me.Seat.TabIndex = 19
        Me.Seat.Text = "Label8"
        Me.Seat.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(21, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Position:"
        '
        'PositionTitle
        '
        Me.PositionTitle.AutoSize = True
        Me.PositionTitle.BackColor = System.Drawing.Color.Transparent
        Me.PositionTitle.Location = New System.Drawing.Point(74, 164)
        Me.PositionTitle.Name = "PositionTitle"
        Me.PositionTitle.Size = New System.Drawing.Size(37, 13)
        Me.PositionTitle.TabIndex = 11
        Me.PositionTitle.Text = "Artist"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(277, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(227, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Salary:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(55, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Art Skills"
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.DotNetBarTabcontrol1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = False
        Me.SlcTheme1.Size = New System.Drawing.Size(465, 335)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 26
        Me.SlcTheme1.Text = "Employee Screen"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(443, 8)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 27
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'DotNetBarTabcontrol1
        '
        Me.DotNetBarTabcontrol1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DotNetBarTabcontrol1.Controls.Add(Me.TabPage1)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.TabPage2)
        Me.DotNetBarTabcontrol1.ItemSize = New System.Drawing.Size(35, 85)
        Me.DotNetBarTabcontrol1.Location = New System.Drawing.Point(12, 34)
        Me.DotNetBarTabcontrol1.Multiline = True
        Me.DotNetBarTabcontrol1.Name = "DotNetBarTabcontrol1"
        Me.DotNetBarTabcontrol1.SelectedIndex = 0
        Me.DotNetBarTabcontrol1.Size = New System.Drawing.Size(426, 274)
        Me.DotNetBarTabcontrol1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DotNetBarTabcontrol1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.lbl_Cost)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.ComboBox2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.SlCbtn1)
        Me.TabPage1.Controls.Add(Me.ProgressBar3)
        Me.TabPage1.Controls.Add(Me.ProgressBar2)
        Me.TabPage1.Controls.Add(Me.ProgressBar1)
        Me.TabPage1.Controls.Add(Me.ListBox2)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Seat)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.PositionTitle)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Location = New System.Drawing.Point(89, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(333, 266)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hire"
        '
        'lbl_Cost
        '
        Me.lbl_Cost.AutoSize = True
        Me.lbl_Cost.Location = New System.Drawing.Point(279, 237)
        Me.lbl_Cost.Name = "lbl_Cost"
        Me.lbl_Cost.Size = New System.Drawing.Size(14, 13)
        Me.lbl_Cost.TabIndex = 33
        Me.lbl_Cost.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(243, 236)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(38, 13)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Cost:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"All", "Artist", "Designer", "Programmer", "Writer", "Audio", "Tester"})
        Me.ComboBox2.Location = New System.Drawing.Point(117, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(159, 21)
        Me.ComboBox2.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button1.Customization = ""
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(246, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "  Accept"
        Me.Button1.Transparent = False
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(285, 13)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(36, 23)
        Me.SlCbtn1.TabIndex = 29
        Me.SlCbtn1.Text = "Go"
        Me.SlCbtn1.Transparent = False
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(117, 237)
        Me.ProgressBar3.Maximum = 100
        Me.ProgressBar3.Minimum = 0
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(109, 23)
        Me.ProgressBar3.TabIndex = 28
        Me.ProgressBar3.Text = "ProgressBar3"
        Me.ProgressBar3.Value = 0
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(117, 212)
        Me.ProgressBar2.Maximum = 100
        Me.ProgressBar2.Minimum = 0
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(109, 23)
        Me.ProgressBar2.TabIndex = 27
        Me.ProgressBar2.Text = "ProgressBar2"
        Me.ProgressBar2.Value = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(117, 187)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Minimum = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(110, 23)
        Me.ProgressBar1.TabIndex = 26
        Me.ProgressBar1.Text = "ProgressBar1"
        Me.ProgressBar1.Value = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.SpeedBar)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.SlCbtn3)
        Me.TabPage2.Controls.Add(Me.SlCbtn2)
        Me.TabPage2.Controls.Add(Me.StressBar)
        Me.TabPage2.Controls.Add(Me.TechBar)
        Me.TabPage2.Controls.Add(Me.ArtBar)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txt_Position)
        Me.TabPage2.Controls.Add(Me.txt_Salary)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.StaffData)
        Me.TabPage2.Controls.Add(Me.StaffList)
        Me.TabPage2.Location = New System.Drawing.Point(89, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(333, 266)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Staff"
        '
        'SpeedBar
        '
        Me.SpeedBar.Location = New System.Drawing.Point(107, 204)
        Me.SpeedBar.Maximum = 100
        Me.SpeedBar.Minimum = 0
        Me.SpeedBar.Name = "SpeedBar"
        Me.SpeedBar.Size = New System.Drawing.Size(109, 23)
        Me.SpeedBar.TabIndex = 42
        Me.SpeedBar.Text = "SlcProgrssBar4"
        Me.SpeedBar.Value = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(19, 214)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Speed Skills:"
        '
        'SlCbtn3
        '
        Me.SlCbtn3.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn3.Customization = ""
        Me.SlCbtn3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn3.Image = Nothing
        Me.SlCbtn3.Location = New System.Drawing.Point(240, 190)
        Me.SlCbtn3.Name = "SlCbtn3"
        Me.SlCbtn3.NoRounding = False
        Me.SlCbtn3.Size = New System.Drawing.Size(75, 23)
        Me.SlCbtn3.TabIndex = 40
        Me.SlCbtn3.Text = "   Raise"
        Me.SlCbtn3.Transparent = False
        '
        'SlCbtn2
        '
        Me.SlCbtn2.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn2.Customization = ""
        Me.SlCbtn2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn2.Image = Nothing
        Me.SlCbtn2.Location = New System.Drawing.Point(240, 226)
        Me.SlCbtn2.Name = "SlCbtn2"
        Me.SlCbtn2.NoRounding = False
        Me.SlCbtn2.Size = New System.Drawing.Size(75, 23)
        Me.SlCbtn2.TabIndex = 39
        Me.SlCbtn2.Text = "     Fire"
        Me.SlCbtn2.Transparent = False
        '
        'StressBar
        '
        Me.StressBar.Location = New System.Drawing.Point(107, 232)
        Me.StressBar.Maximum = 100
        Me.StressBar.Minimum = 0
        Me.StressBar.Name = "StressBar"
        Me.StressBar.Size = New System.Drawing.Size(109, 23)
        Me.StressBar.TabIndex = 38
        Me.StressBar.Text = "SlcProgrssBar1"
        Me.StressBar.Value = 0
        '
        'TechBar
        '
        Me.TechBar.Location = New System.Drawing.Point(107, 180)
        Me.TechBar.Maximum = 100
        Me.TechBar.Minimum = 0
        Me.TechBar.Name = "TechBar"
        Me.TechBar.Size = New System.Drawing.Size(109, 23)
        Me.TechBar.TabIndex = 37
        Me.TechBar.Text = "SlcProgrssBar2"
        Me.TechBar.Value = 0
        '
        'ArtBar
        '
        Me.ArtBar.Location = New System.Drawing.Point(107, 155)
        Me.ArtBar.Maximum = 100
        Me.ArtBar.Minimum = 0
        Me.ArtBar.Name = "ArtBar"
        Me.ArtBar.Size = New System.Drawing.Size(109, 23)
        Me.ArtBar.TabIndex = 36
        Me.ArtBar.Text = "ArtBar"
        Me.ArtBar.Value = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(6, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Stress Handling:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(45, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Art Skills"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(8, 188)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Technical Skills:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(11, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Position:"
        '
        'txt_Position
        '
        Me.txt_Position.AutoSize = True
        Me.txt_Position.BackColor = System.Drawing.Color.Transparent
        Me.txt_Position.Location = New System.Drawing.Point(64, 142)
        Me.txt_Position.Name = "txt_Position"
        Me.txt_Position.Size = New System.Drawing.Size(37, 13)
        Me.txt_Position.TabIndex = 31
        Me.txt_Position.Text = "Artist"
        '
        'txt_Salary
        '
        Me.txt_Salary.AutoSize = True
        Me.txt_Salary.BackColor = System.Drawing.Color.Transparent
        Me.txt_Salary.Location = New System.Drawing.Point(272, 142)
        Me.txt_Salary.Name = "txt_Salary"
        Me.txt_Salary.Size = New System.Drawing.Size(28, 13)
        Me.txt_Salary.TabIndex = 35
        Me.txt_Salary.Text = "100"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(227, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Salary:"
        '
        'StaffData
        '
        Me.StaffData.FormattingEnabled = True
        Me.StaffData.Location = New System.Drawing.Point(204, 18)
        Me.StaffData.Name = "StaffData"
        Me.StaffData.Size = New System.Drawing.Size(120, 95)
        Me.StaffData.TabIndex = 1
        Me.StaffData.Visible = False
        '
        'StaffList
        '
        Me.StaffList.FormattingEnabled = True
        Me.StaffList.Location = New System.Drawing.Point(14, 18)
        Me.StaffList.Name = "StaffList"
        Me.StaffList.Size = New System.Drawing.Size(286, 121)
        Me.StaffList.TabIndex = 0
        '
        'fHire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 335)
        Me.Controls.Add(Me.SlcTheme1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fHire"
        Me.Text = "Hire Employees"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.DotNetBarTabcontrol1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Seat As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PositionTitle As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents DotNetBarTabcontrol1 As dsTycoon.DotNetBarTabcontrol
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
    Friend WithEvents ProgressBar3 As dsTycoon.SLCProgrssBar
    Friend WithEvents ProgressBar2 As dsTycoon.SLCProgrssBar
    Friend WithEvents ProgressBar1 As dsTycoon.SLCProgrssBar
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents Button1 As dsTycoon.SLCbtn
    Friend WithEvents ComboBox2 As dsTycoon.SLCComboBox
    Friend WithEvents StaffData As System.Windows.Forms.ListBox
    Friend WithEvents StaffList As System.Windows.Forms.ListBox
    Friend WithEvents StressBar As dsTycoon.SLCProgrssBar
    Friend WithEvents TechBar As dsTycoon.SLCProgrssBar
    Friend WithEvents ArtBar As dsTycoon.SLCProgrssBar
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Position As System.Windows.Forms.Label
    Friend WithEvents txt_Salary As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SlCbtn3 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn2 As dsTycoon.SLCbtn
    Friend WithEvents SpeedBar As dsTycoon.SLCProgrssBar
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lbl_Cost As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
