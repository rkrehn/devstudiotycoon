<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRandom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRandom))
        Me.Approve = New System.Windows.Forms.Label()
        Me.Reject = New System.Windows.Forms.Label()
        Me.SuccessRate = New System.Windows.Forms.Label()
        Me.Affected = New System.Windows.Forms.Label()
        Me.Cost = New System.Windows.Forms.Label()
        Me.Impact = New System.Windows.Forms.Label()
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.Button1 = New dsTycoon.SLCbtn()
        Me.Button4 = New dsTycoon.SLCbtn()
        Me.RichTextBox1 = New dsTycoon.SLCTextBox()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Approve
        '
        Me.Approve.AutoSize = True
        Me.Approve.BackColor = System.Drawing.Color.Transparent
        Me.Approve.Location = New System.Drawing.Point(48, 108)
        Me.Approve.Name = "Approve"
        Me.Approve.Size = New System.Drawing.Size(55, 13)
        Me.Approve.TabIndex = 18
        Me.Approve.Text = "Approve"
        Me.Approve.Visible = False
        '
        'Reject
        '
        Me.Reject.AutoSize = True
        Me.Reject.BackColor = System.Drawing.Color.Transparent
        Me.Reject.Location = New System.Drawing.Point(238, 103)
        Me.Reject.Name = "Reject"
        Me.Reject.Size = New System.Drawing.Size(43, 13)
        Me.Reject.TabIndex = 19
        Me.Reject.Text = "Reject"
        Me.Reject.Visible = False
        '
        'SuccessRate
        '
        Me.SuccessRate.AutoSize = True
        Me.SuccessRate.BackColor = System.Drawing.Color.Transparent
        Me.SuccessRate.Location = New System.Drawing.Point(251, 67)
        Me.SuccessRate.Name = "SuccessRate"
        Me.SuccessRate.Size = New System.Drawing.Size(21, 13)
        Me.SuccessRate.TabIndex = 20
        Me.SuccessRate.Text = "50"
        Me.SuccessRate.Visible = False
        '
        'Affected
        '
        Me.Affected.AutoSize = True
        Me.Affected.BackColor = System.Drawing.Color.Transparent
        Me.Affected.Location = New System.Drawing.Point(287, 92)
        Me.Affected.Name = "Affected"
        Me.Affected.Size = New System.Drawing.Size(65, 13)
        Me.Affected.TabIndex = 21
        Me.Affected.Text = "Gameplay"
        Me.Affected.Visible = False
        '
        'Cost
        '
        Me.Cost.AutoSize = True
        Me.Cost.BackColor = System.Drawing.Color.Transparent
        Me.Cost.Location = New System.Drawing.Point(296, 105)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(35, 13)
        Me.Cost.TabIndex = 22
        Me.Cost.Text = "1000"
        Me.Cost.Visible = False
        '
        'Impact
        '
        Me.Impact.AutoSize = True
        Me.Impact.BackColor = System.Drawing.Color.Transparent
        Me.Impact.Location = New System.Drawing.Point(137, 66)
        Me.Impact.Name = "Impact"
        Me.Impact.Size = New System.Drawing.Size(14, 13)
        Me.Impact.TabIndex = 23
        Me.Impact.Text = "0"
        Me.Impact.Visible = False
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.Button1)
        Me.SlcTheme1.Controls.Add(Me.Button4)
        Me.SlcTheme1.Controls.Add(Me.Affected)
        Me.SlcTheme1.Controls.Add(Me.RichTextBox1)
        Me.SlcTheme1.Controls.Add(Me.Impact)
        Me.SlcTheme1.Controls.Add(Me.Cost)
        Me.SlcTheme1.Controls.Add(Me.Approve)
        Me.SlcTheme1.Controls.Add(Me.Reject)
        Me.SlcTheme1.Controls.Add(Me.SuccessRate)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = True
        Me.SlcTheme1.Size = New System.Drawing.Size(355, 125)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 24
        Me.SlcTheme1.Text = "Random event"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(329, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 27
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'Button1
        '
        Me.Button1.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button1.Customization = ""
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = Nothing
        Me.Button1.Location = New System.Drawing.Point(206, 81)
        Me.Button1.Name = "Button1"
        Me.Button1.NoRounding = False
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "   Reject"
        Me.Button1.Transparent = False
        '
        'Button4
        '
        Me.Button4.Colors = New dsTycoon.Bloom(-1) {}
        Me.Button4.Customization = ""
        Me.Button4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button4.Image = Nothing
        Me.Button4.Location = New System.Drawing.Point(76, 82)
        Me.Button4.Name = "Button4"
        Me.Button4.NoRounding = False
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.Text = "  Approve"
        Me.Button4.Transparent = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 28)
        Me.RichTextBox1.MaxLength = 32767
        Me.RichTextBox1.Multiline = True
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(331, 52)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = "You had a brilliant idea over night and want to give it a try."
        Me.RichTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RichTextBox1.UseSystemPasswordChar = False
        '
        'fRandom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 125)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fRandom"
        Me.Opacity = 0.9R
        Me.Text = "Random Event!"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Approve As System.Windows.Forms.Label
    Friend WithEvents Reject As System.Windows.Forms.Label
    Friend WithEvents SuccessRate As System.Windows.Forms.Label
    Friend WithEvents Affected As System.Windows.Forms.Label
    Friend WithEvents Cost As System.Windows.Forms.Label
    Friend WithEvents Impact As System.Windows.Forms.Label
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents Button1 As dsTycoon.SLCbtn
    Friend WithEvents Button4 As dsTycoon.SLCbtn
    Friend WithEvents RichTextBox1 As dsTycoon.SLCTextBox
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
End Class
