<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fContract
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fContract))
        Me.SlcTheme1 = New dsTycoon.SLCTheme()
        Me.SlcClose1 = New dsTycoon.SLCClose()
        Me.TheContractData = New System.Windows.Forms.ListBox()
        Me.SlCbtn3 = New dsTycoon.SLCbtn()
        Me.SlCbtn2 = New dsTycoon.SLCbtn()
        Me.SlCbtn1 = New dsTycoon.SLCbtn()
        Me.lbl_Selected = New dsTycoon.SLCLabel()
        Me.txt_TheJob = New dsTycoon.SLCTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.TheContractData)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn3)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn2)
        Me.SlcTheme1.Controls.Add(Me.SlCbtn1)
        Me.SlcTheme1.Controls.Add(Me.lbl_Selected)
        Me.SlcTheme1.Controls.Add(Me.txt_TheJob)
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
        Me.SlcTheme1.Size = New System.Drawing.Size(334, 168)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 48
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(311, 4)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(20, 20)
        Me.SlcClose1.TabIndex = 52
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'TheContractData
        '
        Me.TheContractData.FormattingEnabled = True
        Me.TheContractData.Location = New System.Drawing.Point(195, 26)
        Me.TheContractData.Name = "TheContractData"
        Me.TheContractData.Size = New System.Drawing.Size(126, 82)
        Me.TheContractData.TabIndex = 45
        Me.TheContractData.Visible = False
        '
        'SlCbtn3
        '
        Me.SlCbtn3.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn3.Customization = ""
        Me.SlCbtn3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn3.Image = Nothing
        Me.SlCbtn3.Location = New System.Drawing.Point(267, 139)
        Me.SlCbtn3.Name = "SlCbtn3"
        Me.SlCbtn3.NoRounding = False
        Me.SlCbtn3.Size = New System.Drawing.Size(54, 23)
        Me.SlCbtn3.TabIndex = 51
        Me.SlCbtn3.Text = "Accept"
        Me.SlCbtn3.Transparent = False
        '
        'SlCbtn2
        '
        Me.SlCbtn2.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn2.Customization = ""
        Me.SlCbtn2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn2.Image = Nothing
        Me.SlCbtn2.Location = New System.Drawing.Point(97, 131)
        Me.SlCbtn2.Name = "SlCbtn2"
        Me.SlCbtn2.NoRounding = False
        Me.SlCbtn2.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn2.TabIndex = 50
        Me.SlCbtn2.Text = ">"
        Me.SlCbtn2.Transparent = False
        '
        'SlCbtn1
        '
        Me.SlCbtn1.Colors = New dsTycoon.Bloom(-1) {}
        Me.SlCbtn1.Customization = ""
        Me.SlCbtn1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlCbtn1.Image = Nothing
        Me.SlCbtn1.Location = New System.Drawing.Point(12, 131)
        Me.SlCbtn1.Name = "SlCbtn1"
        Me.SlCbtn1.NoRounding = False
        Me.SlCbtn1.Size = New System.Drawing.Size(25, 15)
        Me.SlCbtn1.TabIndex = 49
        Me.SlCbtn1.Text = "<"
        Me.SlCbtn1.Transparent = False
        '
        'lbl_Selected
        '
        Me.lbl_Selected.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.lbl_Selected.Location = New System.Drawing.Point(43, 131)
        Me.lbl_Selected.Name = "lbl_Selected"
        Me.lbl_Selected.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Selected.TabIndex = 48
        Me.lbl_Selected.Text = "1 / 1"
        '
        'txt_TheJob
        '
        Me.txt_TheJob.Location = New System.Drawing.Point(12, 26)
        Me.txt_TheJob.MaxLength = 32767
        Me.txt_TheJob.Multiline = True
        Me.txt_TheJob.Name = "txt_TheJob"
        Me.txt_TheJob.ReadOnly = True
        Me.txt_TheJob.Size = New System.Drawing.Size(309, 107)
        Me.txt_TheJob.TabIndex = 47
        Me.txt_TheJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TheJob.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(13, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Available Contracts:"
        '
        'fContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(334, 168)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "fContract"
        Me.Text = "Contract Offers"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TheContractData As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_TheJob As dsTycoon.SLCTextBox
    Friend WithEvents SlcTheme1 As dsTycoon.SLCTheme
    Friend WithEvents SlCbtn3 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn2 As dsTycoon.SLCbtn
    Friend WithEvents SlCbtn1 As dsTycoon.SLCbtn
    Friend WithEvents lbl_Selected As dsTycoon.SLCLabel
    Friend WithEvents SlcClose1 As dsTycoon.SLCClose
End Class
