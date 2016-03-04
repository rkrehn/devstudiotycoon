<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDiagExpo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDiagExpo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConName = New System.Windows.Forms.Label()
        Me.ConVisitors = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cost = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.TrackBar1 = New dsTycoon.BaWGUITrackBar()
        Me.Button1 = New dsTycoon.SLCbtn()
        Me.Button4 = New dsTycoon.SLCbtn()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convention has started. Would you like to attend?"
        '
        'ConName
        '
        Me.ConName.AutoSize = True
        Me.ConName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ConName.Location = New System.Drawing.Point(5, 9)
        Me.ConName.Name = "ConName"
        Me.ConName.Size = New System.Drawing.Size(64, 13)
        Me.ConName.TabIndex = 1
        Me.ConName.Text = "KrehnCon"
        Me.ConName.Visible = False
        '
        'ConVisitors
        '
        Me.ConVisitors.AutoSize = True
        Me.ConVisitors.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ConVisitors.Location = New System.Drawing.Point(65, 9)
        Me.ConVisitors.Name = "ConVisitors"
        Me.ConVisitors.Size = New System.Drawing.Size(35, 13)
        Me.ConVisitors.TabIndex = 2
        Me.ConVisitors.Text = "1000"
        Me.ConVisitors.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(295, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Large"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(15, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Small"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(14, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cost:"
        '
        'Cost
        '
        Me.Cost.AutoSize = True
        Me.Cost.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Cost.Location = New System.Drawing.Point(58, 149)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(35, 13)
        Me.Cost.TabIndex = 10
        Me.Cost.Text = "1000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(14, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Booth size:"
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.TrackBar1)
        Me.SlcTheme1.Controls.Add(Me.Button1)
        Me.SlcTheme1.Controls.Add(Me.Button4)
        Me.SlcTheme1.Controls.Add(Me.ConVisitors)
        Me.SlcTheme1.Controls.Add(Me.ConName)
        Me.SlcTheme1.Controls.Add(Me.Label5)
        Me.SlcTheme1.Controls.Add(Me.Cost)
        Me.SlcTheme1.Controls.Add(Me.Label2)
        Me.SlcTheme1.Controls.Add(Me.Label1)
        Me.SlcTheme1.Controls.Add(Me.Label4)
        Me.SlcTheme1.Controls.Add(Me.Label3)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(407, 197)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 19
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.Color.Transparent
        Me.TrackBar1.Location = New System.Drawing.Point(12, 76)
        Me.TrackBar1.Maximum = 5
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(383, 37)
        Me.TrackBar1.TabIndex = 21
        Me.TrackBar1.Value = 1
        '
        'Button1
        '
        Me.Button1.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button1.Customization = ""
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(336, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(59, 35)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Decline"
        Me.Button1.Transparent = False
        '
        'Button4
        '
        Me.Button4.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button4.Customization = ""
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button4.Image = Nothing
        Me.Button4.Location = New System.Drawing.Point(258, 139)
        Me.Button4.Name = "Button4"
        Me.Button4.NoRounding = False
        Me.Button4.Size = New System.Drawing.Size(59, 35)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = " Accept"
        Me.Button4.Transparent = False
        '
        'fDiagExpo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(407, 197)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fDiagExpo"
        Me.Text = "Expo Attendance"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConName As System.Windows.Forms.Label
    Friend WithEvents ConVisitors As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cost As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents Button1 As dsTycoon.SLCbtn
    Friend WithEvents Button4 As dsTycoon.SLCbtn
    Friend WithEvents TrackBar1 As dsTycoon.BaWGUITrackBar
End Class
