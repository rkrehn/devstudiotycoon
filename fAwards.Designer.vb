<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fAwards
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
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.lst_Awards = New System.Windows.Forms.ListBox()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New dsTycoon.SLCbtn()
        Me.SlcTheme1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(565, 430)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(97, 56)
        Me.ListBox3.TabIndex = 12
        Me.ListBox3.Visible = False
        '
        'lst_Awards
        '
        Me.lst_Awards.FormattingEnabled = True
        Me.lst_Awards.Location = New System.Drawing.Point(12, 430)
        Me.lst_Awards.Name = "lst_Awards"
        Me.lst_Awards.Size = New System.Drawing.Size(59, 30)
        Me.lst_Awards.TabIndex = 109
        Me.lst_Awards.Visible = False
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.GroupBox1)
        Me.SlcTheme1.Controls.Add(Me.Button2)
        Me.SlcTheme1.Controls.Add(Me.ListBox3)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(681, 472)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 110
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.BackgroundImage = Global.dsTycoon.My.Resources.Resources.gameawards1
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 400)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 379)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 357)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button2.Customization = ""
        Me.Button2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button2.Image = Nothing
        Me.Button2.Location = New System.Drawing.Point(313, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.NoRounding = False
        Me.Button2.Size = New System.Drawing.Size(78, 22)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "   Accept"
        Me.Button2.Transparent = False
        '
        'fAwards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(681, 472)
        Me.Controls.Add(Me.lst_Awards)
        Me.Controls.Add(Me.SlcTheme1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "fAwards"
        Me.Text = "Dev Studio Tycoon Awards"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents lst_Awards As System.Windows.Forms.ListBox
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents Button2 As dsTycoon.SLCbtn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
