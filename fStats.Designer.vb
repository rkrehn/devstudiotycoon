<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fStats))
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.SlcGroupBox2 = New dsTycoon.SLCGroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.SlcGroupBox1 = New dsTycoon.SLCGroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SlcTheme1.SuspendLayout()
        Me.SlcGroupBox2.SuspendLayout()
        Me.SlcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.SlcGroupBox2)
        Me.SlcTheme1.Controls.Add(Me.SlcGroupBox1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = False
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = False
        Me.SlcTheme1.Size = New System.Drawing.Size(442, 415)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 77
        Me.SlcTheme1.Text = "Statistics"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(419, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 77
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'SlcGroupBox2
        '
        Me.SlcGroupBox2.Controls.Add(Me.ListView2)
        Me.SlcGroupBox2.DrawSeperator = False
        Me.SlcGroupBox2.Location = New System.Drawing.Point(25, 214)
        Me.SlcGroupBox2.Name = "SlcGroupBox2"
        Me.SlcGroupBox2.Size = New System.Drawing.Size(400, 175)
        Me.SlcGroupBox2.SubTitle = "Consoles currently available for sale"
        Me.SlcGroupBox2.TabIndex = 76
        Me.SlcGroupBox2.Text = "SlcGroupBox2"
        Me.SlcGroupBox2.Title = "Consoles"
        '
        'ListView2
        '
        Me.ListView2.Location = New System.Drawing.Point(17, 39)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(368, 121)
        Me.ListView2.TabIndex = 1
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'SlcGroupBox1
        '
        Me.SlcGroupBox1.Controls.Add(Me.ListView1)
        Me.SlcGroupBox1.DrawSeperator = False
        Me.SlcGroupBox1.Location = New System.Drawing.Point(25, 33)
        Me.SlcGroupBox1.Name = "SlcGroupBox1"
        Me.SlcGroupBox1.Size = New System.Drawing.Size(400, 175)
        Me.SlcGroupBox1.SubTitle = "Games currently available for sale"
        Me.SlcGroupBox1.TabIndex = 75
        Me.SlcGroupBox1.Text = "SlcGroupBox1"
        Me.SlcGroupBox1.Title = "Games"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(17, 38)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(368, 121)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'fStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(442, 415)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fStats"
        Me.Text = "Statistics"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcGroupBox2.ResumeLayout(False)
        Me.SlcGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents SlcGroupBox2 As dsTycoon.SLCGroupBox
    Friend WithEvents SlcGroupBox1 As dsTycoon.SLCGroupBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
End Class
