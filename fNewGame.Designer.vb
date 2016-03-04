<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNewGame
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fNewGame))
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.GroupBox3 = New dsTycoon.SLCGroupBox()
        Me.Button2 = New dsTycoon.SLCbtn()
        Me.GameName = New dsTycoon.SLCTextBox()
        Me.GameSize = New dsTycoon.BaWGUITrackBar()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.SlcGroupBox1 = New dsTycoon.SLCGroupBox()
        Me.cmbo_Engine = New dsTycoon.SLCComboBox()
        Me.cmbo_Platform = New dsTycoon.SLCComboBox()
        Me.cmbo_Interest = New dsTycoon.SLCComboBox()
        Me.cmbo_Subgenre = New dsTycoon.SLCComboBox()
        Me.txt_Genre = New dsTycoon.SLCTextBox()
        Me.Button1 = New dsTycoon.SLCbtn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_ExpectedSales = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ConsoleSales = New System.Windows.Forms.ListBox()
        Me.ConsoleNames = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SlcTheme1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SlcGroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.GroupBox3)
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.SlcGroupBox1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(535, 275)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 17
        Me.SlcTheme1.Text = "New Game"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.GameName)
        Me.GroupBox3.Controls.Add(Me.GameSize)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.DrawSeperator = False
        Me.GroupBox3.Location = New System.Drawing.Point(15, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 225)
        Me.GroupBox3.SubTitle = "Determine the name and size of the game"
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.Text = "SlcGroupBox1"
        Me.GroupBox3.Title = "Build New Game"
        '
        'Button2
        '
        Me.Button2.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button2.Customization = ""
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(209, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "   Accept"
        Me.Button2.Transparent = False
        '
        'GameName
        '
        Me.GameName.Location = New System.Drawing.Point(16, 65)
        Me.GameName.MaxLength = 32767
        Me.GameName.Multiline = False
        Me.GameName.Name = "GameName"
        Me.GameName.ReadOnly = False
        Me.GameName.Size = New System.Drawing.Size(268, 24)
        Me.GameName.TabIndex = 31
        Me.GameName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.GameName.UseSystemPasswordChar = False
        '
        'GameSize
        '
        Me.GameSize.BackColor = System.Drawing.Color.Transparent
        Me.GameSize.Location = New System.Drawing.Point(16, 113)
        Me.GameSize.Maximum = 5
        Me.GameSize.Minimum = 1
        Me.GameSize.Name = "GameSize"
        Me.GameSize.Size = New System.Drawing.Size(465, 37)
        Me.GameSize.TabIndex = 30
        Me.GameSize.Value = 1
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.Image = Global.dsTycoon.My.Resources.Resources.dice
        Me.Button3.Location = New System.Drawing.Point(290, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(38, 38)
        Me.Button3.TabIndex = 29
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(13, 51)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 13)
        Me.Label23.TabIndex = 3
        Me.Label23.Text = "Game name:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Location = New System.Drawing.Point(453, 150)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(31, 13)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "AAA"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(13, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Select game size"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Location = New System.Drawing.Point(344, 150)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(39, 13)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Large"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Location = New System.Drawing.Point(225, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(51, 13)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "Medium"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(121, 150)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(39, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Small"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Location = New System.Drawing.Point(13, 150)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(36, 13)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Indie"
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(509, 4)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 17
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'SlcGroupBox1
        '
        Me.SlcGroupBox1.Controls.Add(Me.cmbo_Engine)
        Me.SlcGroupBox1.Controls.Add(Me.cmbo_Platform)
        Me.SlcGroupBox1.Controls.Add(Me.cmbo_Interest)
        Me.SlcGroupBox1.Controls.Add(Me.cmbo_Subgenre)
        Me.SlcGroupBox1.Controls.Add(Me.txt_Genre)
        Me.SlcGroupBox1.Controls.Add(Me.Button1)
        Me.SlcGroupBox1.Controls.Add(Me.Label1)
        Me.SlcGroupBox1.Controls.Add(Me.GroupBox1)
        Me.SlcGroupBox1.Controls.Add(Me.GroupBox2)
        Me.SlcGroupBox1.Controls.Add(Me.Label2)
        Me.SlcGroupBox1.Controls.Add(Me.Label5)
        Me.SlcGroupBox1.Controls.Add(Me.Label3)
        Me.SlcGroupBox1.Controls.Add(Me.Label4)
        Me.SlcGroupBox1.DrawSeperator = False
        Me.SlcGroupBox1.Location = New System.Drawing.Point(15, 30)
        Me.SlcGroupBox1.Name = "SlcGroupBox1"
        Me.SlcGroupBox1.Size = New System.Drawing.Size(500, 225)
        Me.SlcGroupBox1.SubTitle = "Specify the game you're making"
        Me.SlcGroupBox1.TabIndex = 16
        Me.SlcGroupBox1.Title = "Build New Game"
        '
        'cmbo_Engine
        '
        Me.cmbo_Engine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_Engine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_Engine.FormattingEnabled = True
        Me.cmbo_Engine.Location = New System.Drawing.Point(82, 178)
        Me.cmbo_Engine.Name = "cmbo_Engine"
        Me.cmbo_Engine.Size = New System.Drawing.Size(142, 21)
        Me.cmbo_Engine.TabIndex = 38
        '
        'cmbo_Platform
        '
        Me.cmbo_Platform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_Platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_Platform.FormattingEnabled = True
        Me.cmbo_Platform.Location = New System.Drawing.Point(82, 141)
        Me.cmbo_Platform.Name = "cmbo_Platform"
        Me.cmbo_Platform.Size = New System.Drawing.Size(142, 21)
        Me.cmbo_Platform.TabIndex = 37
        '
        'cmbo_Interest
        '
        Me.cmbo_Interest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_Interest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_Interest.FormattingEnabled = True
        Me.cmbo_Interest.Items.AddRange(New Object() {"Drama", "Fairy Tale", "Fantasy", "Fiction", "Folklore", "History", "Horror", "Humor", "Legend", "Mystery", "Mythology", "Realistic Fiction", "Science Finction", "Tall Tale"})
        Me.cmbo_Interest.Location = New System.Drawing.Point(82, 105)
        Me.cmbo_Interest.Name = "cmbo_Interest"
        Me.cmbo_Interest.Size = New System.Drawing.Size(142, 21)
        Me.cmbo_Interest.TabIndex = 36
        '
        'cmbo_Subgenre
        '
        Me.cmbo_Subgenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbo_Subgenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbo_Subgenre.FormattingEnabled = True
        Me.cmbo_Subgenre.Location = New System.Drawing.Point(82, 70)
        Me.cmbo_Subgenre.Name = "cmbo_Subgenre"
        Me.cmbo_Subgenre.Size = New System.Drawing.Size(142, 21)
        Me.cmbo_Subgenre.TabIndex = 35
        '
        'txt_Genre
        '
        Me.txt_Genre.Location = New System.Drawing.Point(82, 35)
        Me.txt_Genre.MaxLength = 32767
        Me.txt_Genre.Multiline = False
        Me.txt_Genre.Name = "txt_Genre"
        Me.txt_Genre.ReadOnly = True
        Me.txt_Genre.Size = New System.Drawing.Size(142, 24)
        Me.txt_Genre.TabIndex = 34
        Me.txt_Genre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Genre.UseSystemPasswordChar = False
        '
        'Button1
        '
        Me.Button1.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button1.Customization = ""
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(310, 186)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "   Accept"
        Me.Button1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(26, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Genre:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_ExpectedSales)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.ConsoleSales)
        Me.GroupBox1.Controls.Add(Me.ConsoleNames)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 165)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Console Sales"
        '
        'lbl_ExpectedSales
        '
        Me.lbl_ExpectedSales.AutoSize = True
        Me.lbl_ExpectedSales.Location = New System.Drawing.Point(136, 143)
        Me.lbl_ExpectedSales.Name = "lbl_ExpectedSales"
        Me.lbl_ExpectedSales.Size = New System.Drawing.Size(132, 13)
        Me.lbl_ExpectedSales.TabIndex = 39
        Me.lbl_ExpectedSales.Text = "*** = Expected Sales"
        Me.lbl_ExpectedSales.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.DarkOrchid
        Me.Label21.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label21.Location = New System.Drawing.Point(139, 98)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 13)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "   "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.DarkBlue
        Me.Label20.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label20.Location = New System.Drawing.Point(139, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "   "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.DarkOrange
        Me.Label19.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label19.Location = New System.Drawing.Point(139, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "   "
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DarkGreen
        Me.Label18.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label18.Location = New System.Drawing.Point(139, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "   "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(161, 98)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(51, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Label17"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(161, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Label16"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(161, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Label15"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(161, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(161, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.DarkRed
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(139, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "   "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 139)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'ConsoleSales
        '
        Me.ConsoleSales.FormattingEnabled = True
        Me.ConsoleSales.Location = New System.Drawing.Point(202, 129)
        Me.ConsoleSales.Name = "ConsoleSales"
        Me.ConsoleSales.Size = New System.Drawing.Size(41, 30)
        Me.ConsoleSales.TabIndex = 15
        Me.ConsoleSales.Visible = False
        '
        'ConsoleNames
        '
        Me.ConsoleNames.FormattingEnabled = True
        Me.ConsoleNames.Location = New System.Drawing.Point(139, 126)
        Me.ConsoleNames.Name = "ConsoleNames"
        Me.ConsoleNames.Size = New System.Drawing.Size(45, 30)
        Me.ConsoleNames.TabIndex = 14
        Me.ConsoleNames.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ProgressBar1)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(230, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(265, 160)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Engine Ratings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(51, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Cost"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Name:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Cost:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Usability"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(10, 101)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(249, 18)
        Me.ProgressBar2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Technology"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 58)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(249, 18)
        Me.ProgressBar1.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(198, 113)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(41, 30)
        Me.ListBox1.TabIndex = 11
        Me.ListBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(3, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sub-Genre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(23, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Engine:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Interest:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(13, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Platform:"
        '
        'fNewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(535, 275)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fNewGame"
        Me.Text = "New Game"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SlcGroupBox1.ResumeLayout(False)
        Me.SlcGroupBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ConsoleSales As System.Windows.Forms.ListBox
    Friend WithEvents ConsoleNames As System.Windows.Forms.ListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As dsTycoon.SLCGroupBox
    Friend WithEvents GameSize As dsTycoon.BaWGUITrackBar
    Friend WithEvents Button2 As dsTycoon.SLCbtn
    Friend WithEvents GameName As dsTycoon.SLCTextBox
    Friend WithEvents Button1 As dsTycoon.SLCbtn
    Friend WithEvents cmbo_Subgenre As dsTycoon.SLCComboBox
    Friend WithEvents txt_Genre As dsTycoon.SLCTextBox
    Friend WithEvents cmbo_Interest As dsTycoon.SLCComboBox
    Friend WithEvents cmbo_Engine As dsTycoon.SLCComboBox
    Friend WithEvents cmbo_Platform As dsTycoon.SLCComboBox
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents SlcGroupBox1 As dsTycoon.SLCGroupBox
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
    Friend WithEvents lbl_ExpectedSales As System.Windows.Forms.Label
End Class
