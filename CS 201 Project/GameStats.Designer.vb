<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameStats
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAssists = New System.Windows.Forms.Label()
        Me.lblDeaths = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblKills = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblGoldEarned = New System.Windows.Forms.Label()
        Me.lblAssistsPerDeath = New System.Windows.Forms.Label()
        Me.lblKillsPerDeath = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lstItems = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblGoldSpent = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblGameNickname = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAssists)
        Me.GroupBox1.Controls.Add(Me.lblDeaths)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblKills)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kills/Deaths/Assists"
        '
        'lblAssists
        '
        Me.lblAssists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAssists.Location = New System.Drawing.Point(371, 38)
        Me.lblAssists.Name = "lblAssists"
        Me.lblAssists.Size = New System.Drawing.Size(100, 23)
        Me.lblAssists.TabIndex = 9
        Me.lblAssists.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDeaths
        '
        Me.lblDeaths.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDeaths.Location = New System.Drawing.Point(206, 38)
        Me.lblDeaths.Name = "lblDeaths"
        Me.lblDeaths.Size = New System.Drawing.Size(100, 23)
        Me.lblDeaths.TabIndex = 8
        Me.lblDeaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Assists:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Deaths:"
        '
        'lblKills
        '
        Me.lblKills.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKills.Location = New System.Drawing.Point(45, 38)
        Me.lblKills.Name = "lblKills"
        Me.lblKills.Size = New System.Drawing.Size(100, 23)
        Me.lblKills.TabIndex = 3
        Me.lblKills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kills:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblGoldEarned)
        Me.GroupBox2.Controls.Add(Me.lblAssistsPerDeath)
        Me.GroupBox2.Controls.Add(Me.lblKillsPerDeath)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 240)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Game Stats"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = " Gold Earned:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Assists per Death:"
        '
        'lblGoldEarned
        '
        Me.lblGoldEarned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldEarned.Location = New System.Drawing.Point(105, 151)
        Me.lblGoldEarned.Name = "lblGoldEarned"
        Me.lblGoldEarned.Size = New System.Drawing.Size(100, 23)
        Me.lblGoldEarned.TabIndex = 6
        Me.lblGoldEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAssistsPerDeath
        '
        Me.lblAssistsPerDeath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAssistsPerDeath.Location = New System.Drawing.Point(105, 102)
        Me.lblAssistsPerDeath.Name = "lblAssistsPerDeath"
        Me.lblAssistsPerDeath.Size = New System.Drawing.Size(100, 23)
        Me.lblAssistsPerDeath.TabIndex = 5
        Me.lblAssistsPerDeath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblKillsPerDeath
        '
        Me.lblKillsPerDeath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKillsPerDeath.Location = New System.Drawing.Point(105, 51)
        Me.lblKillsPerDeath.Name = "lblKillsPerDeath"
        Me.lblKillsPerDeath.Size = New System.Drawing.Size(100, 23)
        Me.lblKillsPerDeath.TabIndex = 4
        Me.lblKillsPerDeath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Kills per Death:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.lstItems)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.lblGoldSpent)
        Me.GroupBox3.Location = New System.Drawing.Point(232, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 240)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Items Stats"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(30, 194)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Gold Spent on Items:"
        '
        'lstItems
        '
        Me.lstItems.FormattingEnabled = True
        Me.lstItems.Location = New System.Drawing.Point(86, 41)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(179, 121)
        Me.lstItems.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(35, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Items:"
        '
        'lblGoldSpent
        '
        Me.lblGoldSpent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGoldSpent.Location = New System.Drawing.Point(142, 193)
        Me.lblGoldSpent.Name = "lblGoldSpent"
        Me.lblGoldSpent.Size = New System.Drawing.Size(100, 23)
        Me.lblGoldSpent.TabIndex = 7
        Me.lblGoldSpent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "&Exit"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuHelpAbout.Text = "&About"
        '
        'lblGameNickname
        '
        Me.lblGameNickname.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameNickname.Location = New System.Drawing.Point(12, 41)
        Me.lblGameNickname.Name = "lblGameNickname"
        Me.lblGameNickname.Size = New System.Drawing.Size(500, 33)
        Me.lblGameNickname.TabIndex = 2
        Me.lblGameNickname.Text = "Label2"
        Me.lblGameNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 449)
        Me.Controls.Add(Me.lblGameNickname)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GameStats"
        Me.Text = "Game Statistics"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblAssists As Label
    Friend WithEvents lblDeaths As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblKills As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblGoldEarned As Label
    Friend WithEvents lblAssistsPerDeath As Label
    Friend WithEvents lblKillsPerDeath As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lstItems As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lblGoldSpent As Label
    Friend WithEvents lblGameNickname As Label
End Class
