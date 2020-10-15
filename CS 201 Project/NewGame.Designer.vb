<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewGame
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSubmit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAssists = New System.Windows.Forms.TextBox()
        Me.txtDeaths = New System.Windows.Forms.TextBox()
        Me.txtKills = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbItemSix = New System.Windows.Forms.ComboBox()
        Me.cmbItemFive = New System.Windows.Forms.ComboBox()
        Me.cmbItemFour = New System.Windows.Forms.ComboBox()
        Me.cmbItemThree = New System.Windows.Forms.ComboBox()
        Me.cmbItemTwo = New System.Windows.Forms.ComboBox()
        Me.cmbItemOne = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNickname = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(563, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileReset, Me.mnuFileSubmit, Me.ToolStripMenuItem1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileReset
        '
        Me.mnuFileReset.Name = "mnuFileReset"
        Me.mnuFileReset.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileReset.Text = "&Reset"
        '
        'mnuFileSubmit
        '
        Me.mnuFileSubmit.Name = "mnuFileSubmit"
        Me.mnuFileSubmit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSubmit.Text = "&Submit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(177, 6)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtAssists)
        Me.GroupBox2.Controls.Add(Me.txtDeaths)
        Me.GroupBox2.Controls.Add(Me.txtKills)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(32, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 86)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kills/Deaths/Assists"
        '
        'txtAssists
        '
        Me.txtAssists.Location = New System.Drawing.Point(367, 35)
        Me.txtAssists.Name = "txtAssists"
        Me.txtAssists.Size = New System.Drawing.Size(100, 20)
        Me.txtAssists.TabIndex = 2
        '
        'txtDeaths
        '
        Me.txtDeaths.Location = New System.Drawing.Point(212, 35)
        Me.txtDeaths.Name = "txtDeaths"
        Me.txtDeaths.Size = New System.Drawing.Size(100, 20)
        Me.txtDeaths.TabIndex = 1
        '
        'txtKills
        '
        Me.txtKills.Location = New System.Drawing.Point(52, 35)
        Me.txtKills.Name = "txtKills"
        Me.txtKills.Size = New System.Drawing.Size(100, 20)
        Me.txtKills.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(319, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Assists:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Deaths:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kills:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbItemSix)
        Me.GroupBox1.Controls.Add(Me.cmbItemFive)
        Me.GroupBox1.Controls.Add(Me.cmbItemFour)
        Me.GroupBox1.Controls.Add(Me.cmbItemThree)
        Me.GroupBox1.Controls.Add(Me.cmbItemTwo)
        Me.GroupBox1.Controls.Add(Me.cmbItemOne)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 202)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'cmbItemSix
        '
        Me.cmbItemSix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemSix.FormattingEnabled = True
        Me.cmbItemSix.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemSix.Location = New System.Drawing.Point(329, 123)
        Me.cmbItemSix.Name = "cmbItemSix"
        Me.cmbItemSix.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemSix.TabIndex = 5
        '
        'cmbItemFive
        '
        Me.cmbItemFive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemFive.FormattingEnabled = True
        Me.cmbItemFive.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemFive.Location = New System.Drawing.Point(174, 123)
        Me.cmbItemFive.Name = "cmbItemFive"
        Me.cmbItemFive.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemFive.TabIndex = 4
        '
        'cmbItemFour
        '
        Me.cmbItemFour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemFour.FormattingEnabled = True
        Me.cmbItemFour.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemFour.Location = New System.Drawing.Point(14, 123)
        Me.cmbItemFour.Name = "cmbItemFour"
        Me.cmbItemFour.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemFour.TabIndex = 3
        '
        'cmbItemThree
        '
        Me.cmbItemThree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemThree.FormattingEnabled = True
        Me.cmbItemThree.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemThree.Location = New System.Drawing.Point(329, 49)
        Me.cmbItemThree.Name = "cmbItemThree"
        Me.cmbItemThree.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemThree.TabIndex = 2
        '
        'cmbItemTwo
        '
        Me.cmbItemTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemTwo.FormattingEnabled = True
        Me.cmbItemTwo.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemTwo.Location = New System.Drawing.Point(174, 49)
        Me.cmbItemTwo.Name = "cmbItemTwo"
        Me.cmbItemTwo.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemTwo.TabIndex = 1
        '
        'cmbItemOne
        '
        Me.cmbItemOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemOne.FormattingEnabled = True
        Me.cmbItemOne.Items.AddRange(New Object() {"Boots of Swiftness", "Boots of Mobility", "Sorcerer's Shoes", "Blade of the Ruined King", "Duskblade of Draktharr", "Infinity Edge", "Lich Bane", "Rabadon's Deathcap", "Zhonya's Hourglass", "Randuin's Omen", "Thornmail", "Sunfire Cape", "None"})
        Me.cmbItemOne.Location = New System.Drawing.Point(14, 49)
        Me.cmbItemOne.Name = "cmbItemOne"
        Me.cmbItemOne.Size = New System.Drawing.Size(121, 21)
        Me.cmbItemOne.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nickname:"
        '
        'txtNickname
        '
        Me.txtNickname.Location = New System.Drawing.Point(216, 28)
        Me.txtNickname.Name = "txtNickname"
        Me.txtNickname.Size = New System.Drawing.Size(100, 20)
        Me.txtNickname.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNickname)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 41)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 63)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Game Nickname"
        '
        'NewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 404)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "NewGame"
        Me.Text = "New Game"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileReset As ToolStripMenuItem
    Friend WithEvents mnuFileSubmit As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtAssists As TextBox
    Friend WithEvents txtDeaths As TextBox
    Friend WithEvents txtKills As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbItemSix As ComboBox
    Friend WithEvents cmbItemFive As ComboBox
    Friend WithEvents cmbItemFour As ComboBox
    Friend WithEvents cmbItemThree As ComboBox
    Friend WithEvents cmbItemTwo As ComboBox
    Friend WithEvents cmbItemOne As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNickname As TextBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
