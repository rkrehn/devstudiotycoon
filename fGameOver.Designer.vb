<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGameOver
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinalScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MostCash = New System.Windows.Forms.Label()
        Me.GoodGames = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GoodEngines = New System.Windows.Forms.Label()
        Me.Loans = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Investments = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Stocks = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BadGames = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Consoles = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Reputation = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(276, 459)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Accept"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 26)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Final Score:"
        '
        'FinalScore
        '
        Me.FinalScore.AutoSize = True
        Me.FinalScore.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalScore.Location = New System.Drawing.Point(201, 277)
        Me.FinalScore.Name = "FinalScore"
        Me.FinalScore.Size = New System.Drawing.Size(23, 26)
        Me.FinalScore.TabIndex = 14
        Me.FinalScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 329)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Most Cash:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Good Games:"
        '
        'MostCash
        '
        Me.MostCash.AutoSize = True
        Me.MostCash.Location = New System.Drawing.Point(225, 329)
        Me.MostCash.Name = "MostCash"
        Me.MostCash.Size = New System.Drawing.Size(13, 13)
        Me.MostCash.TabIndex = 17
        Me.MostCash.Text = "0"
        '
        'GoodGames
        '
        Me.GoodGames.AutoSize = True
        Me.GoodGames.Location = New System.Drawing.Point(225, 354)
        Me.GoodGames.Name = "GoodGames"
        Me.GoodGames.Size = New System.Drawing.Size(13, 13)
        Me.GoodGames.TabIndex = 18
        Me.GoodGames.Text = "0"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.dsTycoon.My.Resources.Resources.gameover
        Me.PictureBox1.Location = New System.Drawing.Point(79, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Engines:"
        '
        'GoodEngines
        '
        Me.GoodEngines.AutoSize = True
        Me.GoodEngines.Location = New System.Drawing.Point(225, 379)
        Me.GoodEngines.Name = "GoodEngines"
        Me.GoodEngines.Size = New System.Drawing.Size(13, 13)
        Me.GoodEngines.TabIndex = 22
        Me.GoodEngines.Text = "0"
        '
        'Loans
        '
        Me.Loans.AutoSize = True
        Me.Loans.Location = New System.Drawing.Point(475, 379)
        Me.Loans.Name = "Loans"
        Me.Loans.Size = New System.Drawing.Size(13, 13)
        Me.Loans.TabIndex = 24
        Me.Loans.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(430, 379)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Loans: -"
        '
        'Investments
        '
        Me.Investments.AutoSize = True
        Me.Investments.Location = New System.Drawing.Point(225, 404)
        Me.Investments.Name = "Investments"
        Me.Investments.Size = New System.Drawing.Size(13, 13)
        Me.Investments.TabIndex = 26
        Me.Investments.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 404)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 13)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = "Investments:"
        '
        'Stocks
        '
        Me.Stocks.AutoSize = True
        Me.Stocks.Location = New System.Drawing.Point(473, 329)
        Me.Stocks.Name = "Stocks"
        Me.Stocks.Size = New System.Drawing.Size(13, 13)
        Me.Stocks.TabIndex = 28
        Me.Stocks.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(430, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Stocks:"
        '
        'BadGames
        '
        Me.BadGames.AutoSize = True
        Me.BadGames.Location = New System.Drawing.Point(475, 404)
        Me.BadGames.Name = "BadGames"
        Me.BadGames.Size = New System.Drawing.Size(13, 13)
        Me.BadGames.TabIndex = 30
        Me.BadGames.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(404, 404)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "Bad Games: -"
        '
        'Consoles
        '
        Me.Consoles.AutoSize = True
        Me.Consoles.Location = New System.Drawing.Point(475, 354)
        Me.Consoles.Name = "Consoles"
        Me.Consoles.Size = New System.Drawing.Size(13, 13)
        Me.Consoles.TabIndex = 32
        Me.Consoles.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(422, 354)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Consoles:"
        '
        'Reputation
        '
        Me.Reputation.AutoSize = True
        Me.Reputation.Location = New System.Drawing.Point(341, 431)
        Me.Reputation.Name = "Reputation"
        Me.Reputation.Size = New System.Drawing.Size(13, 13)
        Me.Reputation.TabIndex = 34
        Me.Reputation.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 431)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Reputation:"
        '
        'fGameOver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(654, 494)
        Me.Controls.Add(Me.Reputation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Consoles)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BadGames)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Stocks)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Investments)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Loans)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GoodEngines)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GoodGames)
        Me.Controls.Add(Me.MostCash)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FinalScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "fGameOver"
        Me.Text = "Game Over"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FinalScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MostCash As System.Windows.Forms.Label
    Friend WithEvents GoodGames As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GoodEngines As System.Windows.Forms.Label
    Friend WithEvents Loans As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Investments As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Stocks As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BadGames As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Consoles As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Reputation As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
