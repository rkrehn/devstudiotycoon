<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fBank
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fBank))
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.DotNetBarTabcontrol1 = New dsTycoon.DotNetBarTabcontrol()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.HScrollBar1 = New dsTycoon.BaWGUITrackBar()
        Me.SlCbtn2 = New dsTycoon.SLCbtn()
        Me.Loan1 = New System.Windows.Forms.ListBox()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Loan1Data = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Loan2Data = New System.Windows.Forms.ListBox()
        Me.Loan2 = New System.Windows.Forms.ListBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.SlCbtn4 = New dsTycoon.SLCbtn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SlCbtn3 = New dsTycoon.SLCbtn()
        Me.Invest1 = New System.Windows.Forms.ListBox()
        Me.Invest2Data = New System.Windows.Forms.ListBox()
        Me.Invest1Data = New System.Windows.Forms.ListBox()
        Me.Invest2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.SlCbtn7 = New dsTycoon.SLCbtn()
        Me.SlCbtn8 = New dsTycoon.SLCbtn()
        Me.lbl_Selected = New dsTycoon.SLCLabel()
        Me.lst_ReleasedGames = New System.Windows.Forms.ListBox()
        Me.SlCbtn6 = New dsTycoon.SLCbtn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_AvailStocks = New dsTycoon.SLCTextBox()
        Me.StockData = New System.Windows.Forms.ListBox()
        Me.SlCbtn5 = New dsTycoon.SLCbtn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SlcTheme1.SuspendLayout()
        Me.DotNetBarTabcontrol1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(557, 282)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 1
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(534, 2)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 2
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'DotNetBarTabcontrol1
        '
        Me.DotNetBarTabcontrol1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.DotNetBarTabcontrol1.Controls.Add(Me.TabPage4)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.TabPage5)
        Me.DotNetBarTabcontrol1.Controls.Add(Me.TabPage6)
        Me.DotNetBarTabcontrol1.ItemSize = New System.Drawing.Size(35, 85)
        Me.DotNetBarTabcontrol1.Location = New System.Drawing.Point(12, 22)
        Me.DotNetBarTabcontrol1.Multiline = True
        Me.DotNetBarTabcontrol1.Name = "DotNetBarTabcontrol1"
        Me.DotNetBarTabcontrol1.SelectedIndex = 0
        Me.DotNetBarTabcontrol1.Size = New System.Drawing.Size(534, 238)
        Me.DotNetBarTabcontrol1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.DotNetBarTabcontrol1.TabIndex = 1
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage4.Controls.Add(Me.HScrollBar1)
        Me.TabPage4.Controls.Add(Me.SlCbtn2)
        Me.TabPage4.Controls.Add(Me.Loan1)
        Me.TabPage4.Controls.Add(Me.SlCbtn1)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.Loan1Data)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label2)
        Me.TabPage4.Controls.Add(Me.Loan2Data)
        Me.TabPage4.Controls.Add(Me.Loan2)
        Me.TabPage4.Location = New System.Drawing.Point(89, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(441, 230)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "Loans"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.BackColor = System.Drawing.Color.Transparent
        Me.HScrollBar1.Location = New System.Drawing.Point(10, 84)
        Me.HScrollBar1.Maximum = 10
        Me.HScrollBar1.Minimum = 0
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(305, 37)
        Me.HScrollBar1.TabIndex = 14
        Me.HScrollBar1.Value = 0
        '
        'SlCbtn2
        '
        Me.SlCbtn2.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn2.Customization = ""
        Me.SlCbtn2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn2.Image = Nothing
        Me.SlCbtn2.Location = New System.Drawing.Point(388, 206)
        Me.SlCbtn2.Name = "SlCbtn2"
        Me.SlCbtn2.NoRounding = False
        Me.SlCbtn2.Size = New System.Drawing.Size(46, 23)
        Me.SlCbtn2.TabIndex = 13
        Me.SlCbtn2.Text = "Take"
        Me.SlCbtn2.Transparent = False
        '
        'Loan1
        '
        Me.Loan1.FormattingEnabled = True
        Me.Loan1.Location = New System.Drawing.Point(10, 25)
        Me.Loan1.Name = "Loan1"
        Me.Loan1.Size = New System.Drawing.Size(425, 56)
        Me.Loan1.TabIndex = 1
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(388, 85)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(46, 23)
        Me.SlCbtn1.TabIndex = 12
        Me.SlCbtn1.Text = "Pay"
        Me.SlCbtn1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Outstanding loans:"
        '
        'Loan1Data
        '
        Me.Loan1Data.FormattingEnabled = True
        Me.Loan1Data.Location = New System.Drawing.Point(271, 25)
        Me.Loan1Data.Name = "Loan1Data"
        Me.Loan1Data.Size = New System.Drawing.Size(163, 56)
        Me.Loan1Data.TabIndex = 2
        Me.Loan1Data.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "$100,000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Available loans:"
        '
        'Loan2Data
        '
        Me.Loan2Data.FormattingEnabled = True
        Me.Loan2Data.Location = New System.Drawing.Point(271, 146)
        Me.Loan2Data.Name = "Loan2Data"
        Me.Loan2Data.Size = New System.Drawing.Size(164, 56)
        Me.Loan2Data.TabIndex = 5
        Me.Loan2Data.Visible = False
        '
        'Loan2
        '
        Me.Loan2.FormattingEnabled = True
        Me.Loan2.Location = New System.Drawing.Point(10, 146)
        Me.Loan2.Name = "Loan2"
        Me.Loan2.Size = New System.Drawing.Size(425, 56)
        Me.Loan2.TabIndex = 4
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage5.Controls.Add(Me.SlCbtn4)
        Me.TabPage5.Controls.Add(Me.Label3)
        Me.TabPage5.Controls.Add(Me.SlCbtn3)
        Me.TabPage5.Controls.Add(Me.Invest1)
        Me.TabPage5.Controls.Add(Me.Invest2Data)
        Me.TabPage5.Controls.Add(Me.Invest1Data)
        Me.TabPage5.Controls.Add(Me.Invest2)
        Me.TabPage5.Controls.Add(Me.Label4)
        Me.TabPage5.Location = New System.Drawing.Point(89, 4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(441, 230)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "Invest"
        '
        'SlCbtn4
        '
        Me.SlCbtn4.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn4.Customization = ""
        Me.SlCbtn4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn4.Image = Nothing
        Me.SlCbtn4.Location = New System.Drawing.Point(387, 203)
        Me.SlCbtn4.Name = "SlCbtn4"
        Me.SlCbtn4.NoRounding = False
        Me.SlCbtn4.Size = New System.Drawing.Size(46, 23)
        Me.SlCbtn4.TabIndex = 18
        Me.SlCbtn4.Text = "Buy"
        Me.SlCbtn4.Transparent = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Current Investments:"
        '
        'SlCbtn3
        '
        Me.SlCbtn3.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn3.Customization = ""
        Me.SlCbtn3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn3.Image = Nothing
        Me.SlCbtn3.Location = New System.Drawing.Point(387, 84)
        Me.SlCbtn3.Name = "SlCbtn3"
        Me.SlCbtn3.NoRounding = False
        Me.SlCbtn3.Size = New System.Drawing.Size(46, 23)
        Me.SlCbtn3.TabIndex = 17
        Me.SlCbtn3.Text = "Sell"
        Me.SlCbtn3.Transparent = False
        '
        'Invest1
        '
        Me.Invest1.FormattingEnabled = True
        Me.Invest1.Location = New System.Drawing.Point(9, 19)
        Me.Invest1.Name = "Invest1"
        Me.Invest1.Size = New System.Drawing.Size(425, 56)
        Me.Invest1.TabIndex = 9
        '
        'Invest2Data
        '
        Me.Invest2Data.FormattingEnabled = True
        Me.Invest2Data.Location = New System.Drawing.Point(387, 143)
        Me.Invest2Data.Name = "Invest2Data"
        Me.Invest2Data.Size = New System.Drawing.Size(48, 56)
        Me.Invest2Data.TabIndex = 15
        Me.Invest2Data.Visible = False
        '
        'Invest1Data
        '
        Me.Invest1Data.FormattingEnabled = True
        Me.Invest1Data.Location = New System.Drawing.Point(387, 19)
        Me.Invest1Data.Name = "Invest1Data"
        Me.Invest1Data.Size = New System.Drawing.Size(48, 56)
        Me.Invest1Data.TabIndex = 10
        Me.Invest1Data.Visible = False
        '
        'Invest2
        '
        Me.Invest2.FormattingEnabled = True
        Me.Invest2.Location = New System.Drawing.Point(9, 143)
        Me.Invest2.Name = "Invest2"
        Me.Invest2.Size = New System.Drawing.Size(425, 56)
        Me.Invest2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Available investments:"
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage6.Controls.Add(Me.SlCbtn7)
        Me.TabPage6.Controls.Add(Me.SlCbtn8)
        Me.TabPage6.Controls.Add(Me.lbl_Selected)
        Me.TabPage6.Controls.Add(Me.lst_ReleasedGames)
        Me.TabPage6.Controls.Add(Me.SlCbtn6)
        Me.TabPage6.Controls.Add(Me.Label7)
        Me.TabPage6.Controls.Add(Me.txt_AvailStocks)
        Me.TabPage6.Controls.Add(Me.StockData)
        Me.TabPage6.Controls.Add(Me.SlCbtn5)
        Me.TabPage6.Controls.Add(Me.Label5)
        Me.TabPage6.Location = New System.Drawing.Point(89, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(441, 230)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "Buyout"
        '
        'SlCbtn7
        '
        Me.SlCbtn7.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn7.Customization = ""
        Me.SlCbtn7.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn7.Image = Nothing
        Me.SlCbtn7.Location = New System.Drawing.Point(411, 130)
        Me.SlCbtn7.Name = "SlCbtn7"
        Me.SlCbtn7.NoRounding = False
        Me.SlCbtn7.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn7.TabIndex = 53
        Me.SlCbtn7.Text = ">"
        Me.SlCbtn7.Transparent = False
        '
        'SlCbtn8
        '
        Me.SlCbtn8.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn8.Customization = ""
        Me.SlCbtn8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn8.Image = Nothing
        Me.SlCbtn8.Location = New System.Drawing.Point(326, 130)
        Me.SlCbtn8.Name = "SlCbtn8"
        Me.SlCbtn8.NoRounding = False
        Me.SlCbtn8.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn8.TabIndex = 52
        Me.SlCbtn8.Text = "<"
        Me.SlCbtn8.Transparent = False
        '
        'lbl_Selected
        '
        Me.lbl_Selected.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Selected.Location = New System.Drawing.Point(357, 130)
        Me.lbl_Selected.Name = "lbl_Selected"
        Me.lbl_Selected.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Selected.TabIndex = 51
        Me.lbl_Selected.Text = "1 / 1"
        '
        'lst_ReleasedGames
        '
        Me.lst_ReleasedGames.FormattingEnabled = True
        Me.lst_ReleasedGames.Location = New System.Drawing.Point(11, 166)
        Me.lst_ReleasedGames.Name = "lst_ReleasedGames"
        Me.lst_ReleasedGames.Size = New System.Drawing.Size(373, 56)
        Me.lst_ReleasedGames.TabIndex = 25
        '
        'SlCbtn6
        '
        Me.SlCbtn6.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn6.Customization = ""
        Me.SlCbtn6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn6.Image = Nothing
        Me.SlCbtn6.Location = New System.Drawing.Point(11, 130)
        Me.SlCbtn6.Name = "SlCbtn6"
        Me.SlCbtn6.NoRounding = False
        Me.SlCbtn6.Size = New System.Drawing.Size(55, 23)
        Me.SlCbtn6.TabIndex = 24
        Me.SlCbtn6.Text = "Details"
        Me.SlCbtn6.Transparent = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Released Games:"
        '
        'txt_AvailStocks
        '
        Me.txt_AvailStocks.Location = New System.Drawing.Point(11, 29)
        Me.txt_AvailStocks.MaxLength = 32767
        Me.txt_AvailStocks.Multiline = True
        Me.txt_AvailStocks.Name = "txt_AvailStocks"
        Me.txt_AvailStocks.ReadOnly = True
        Me.txt_AvailStocks.Size = New System.Drawing.Size(425, 95)
        Me.txt_AvailStocks.TabIndex = 22
        Me.txt_AvailStocks.Text = "txt_AvailStocks"
        Me.txt_AvailStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AvailStocks.UseSystemPasswordChar = False
        '
        'StockData
        '
        Me.StockData.FormattingEnabled = True
        Me.StockData.Location = New System.Drawing.Point(316, 29)
        Me.StockData.Name = "StockData"
        Me.StockData.Size = New System.Drawing.Size(120, 95)
        Me.StockData.TabIndex = 21
        Me.StockData.Visible = False
        '
        'SlCbtn5
        '
        Me.SlCbtn5.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn5.Customization = ""
        Me.SlCbtn5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn5.Image = Nothing
        Me.SlCbtn5.Location = New System.Drawing.Point(390, 199)
        Me.SlCbtn5.Name = "SlCbtn5"
        Me.SlCbtn5.NoRounding = False
        Me.SlCbtn5.Size = New System.Drawing.Size(46, 23)
        Me.SlCbtn5.TabIndex = 19
        Me.SlCbtn5.Text = "Buy"
        Me.SlCbtn5.Transparent = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Available Companies:"
        '
        'fBank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 282)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fBank"
        Me.Text = "Bank"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.DotNetBarTabcontrol1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Loan2Data As System.Windows.Forms.ListBox
    Friend WithEvents Loan2 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Loan1Data As System.Windows.Forms.ListBox
    Friend WithEvents Loan1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Invest2Data As System.Windows.Forms.ListBox
    Friend WithEvents Invest2 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Invest1Data As System.Windows.Forms.ListBox
    Friend WithEvents Invest1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents DotNetBarTabcontrol1 As dsTycoon.DotNetBarTabcontrol
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn2 As dsTycoon.SLCbtn
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents SlCbtn3 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn4 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn5 As dsTycoon.SLCbtn
    Friend WithEvents HScrollBar1 As dsTycoon.BaWGUITrackBar
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
    Friend WithEvents StockData As System.Windows.Forms.ListBox
    Friend WithEvents lst_ReleasedGames As System.Windows.Forms.ListBox
    Friend WithEvents SlCbtn6 As dsTycoon.SLCbtn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_AvailStocks As dsTycoon.SLCTextBox
    Friend WithEvents SlCbtn7 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn8 As dsTycoon.SLCbtn
    Friend WithEvents lbl_Selected As dsTycoon.SLCLabel
End Class
