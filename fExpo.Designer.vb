<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fExpo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fExpo))
        Me.MaxVisitors = New System.Windows.Forms.Label()
        Me.HypeBuild = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BoothVisitors = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ConVisitors = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.Button4 = New dsTycoon.SLCbtn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaxVisitors
        '
        Me.MaxVisitors.AutoSize = True
        Me.MaxVisitors.BackColor = System.Drawing.Color.Transparent
        Me.MaxVisitors.Location = New System.Drawing.Point(147, 416)
        Me.MaxVisitors.Name = "MaxVisitors"
        Me.MaxVisitors.Size = New System.Drawing.Size(14, 13)
        Me.MaxVisitors.TabIndex = 18
        Me.MaxVisitors.Text = "0"
        Me.MaxVisitors.Visible = False
        '
        'HypeBuild
        '
        Me.HypeBuild.AutoSize = True
        Me.HypeBuild.BackColor = System.Drawing.Color.Transparent
        Me.HypeBuild.Location = New System.Drawing.Point(516, 436)
        Me.HypeBuild.Name = "HypeBuild"
        Me.HypeBuild.Size = New System.Drawing.Size(14, 13)
        Me.HypeBuild.TabIndex = 19
        Me.HypeBuild.Text = "0"
        Me.HypeBuild.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Your Visitors:"
        '
        'BoothVisitors
        '
        Me.BoothVisitors.AutoSize = True
        Me.BoothVisitors.BackColor = System.Drawing.Color.Transparent
        Me.BoothVisitors.Location = New System.Drawing.Point(116, 416)
        Me.BoothVisitors.Name = "BoothVisitors"
        Me.BoothVisitors.Size = New System.Drawing.Size(14, 13)
        Me.BoothVisitors.TabIndex = 21
        Me.BoothVisitors.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'ConVisitors
        '
        Me.ConVisitors.AutoSize = True
        Me.ConVisitors.BackColor = System.Drawing.Color.Transparent
        Me.ConVisitors.Location = New System.Drawing.Point(485, 416)
        Me.ConVisitors.Name = "ConVisitors"
        Me.ConVisitors.Size = New System.Drawing.Size(44, 13)
        Me.ConVisitors.TabIndex = 22
        Me.ConVisitors.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(29, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 386)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(372, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Total Con Visitors:"
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.Button4)
        Me.SlcTheme1.Controls.Add(Me.HypeBuild)
        Me.SlcTheme1.Controls.Add(Me.Label1)
        Me.SlcTheme1.Controls.Add(Me.PictureBox1)
        Me.SlcTheme1.Controls.Add(Me.ConVisitors)
        Me.SlcTheme1.Controls.Add(Me.BoothVisitors)
        Me.SlcTheme1.Controls.Add(Me.MaxVisitors)
        Me.SlcTheme1.Controls.Add(Me.Label2)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(547, 463)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 24
        Me.SlcTheme1.Text = "Expo"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'Button4
        '
        Me.Button4.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button4.Customization = ""
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button4.Image = Nothing
        Me.Button4.Location = New System.Drawing.Point(246, 416)
        Me.Button4.Name = "Button4"
        Me.Button4.NoRounding = False
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "   Close"
        Me.Button4.Transparent = False
        '
        'fExpo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(547, 463)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fExpo"
        Me.Text = "Expo"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MaxVisitors As System.Windows.Forms.Label
    Friend WithEvents HypeBuild As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BoothVisitors As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ConVisitors As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents Button4 As dsTycoon.SLCbtn
End Class
