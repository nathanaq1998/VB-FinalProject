Public Class GameStats
    ' Nathan Quinn
    ' CS 201 Project

    Private Sub GameStats_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Clear form of any previous data
        ClearForm()

        ' Based on selected game (from MainMenu Form) display statistics from that game
        Select Case MainMenu.intSelectedGame
            Case 0
                DisplayGame()

            Case 1
                DisplayGame()

            Case 2
                DisplayGame()

            Case 3
                DisplayGame()

            Case 4
                DisplayGame()
        End Select
    End Sub

    ' Clear labels and listbox on form
    Sub ClearForm()
        lblKills.Text = String.Empty
        lblDeaths.Text = String.Empty
        lblAssists.Text = String.Empty
        lblKillsPerDeath.Text = String.Empty
        lblAssistsPerDeath.Text = String.Empty
        lblGoldEarned.Text = String.Empty
        lblGoldSpent.Text = String.Empty

        lstItems.Items.Clear()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Explains purpose of form
        MessageBox.Show("Displays statistics about selected game.")
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close form
        Me.Close()
    End Sub

    Sub DisplayGame()
        ' Call ReturnGameData function from RecordAndCalculateGame module
        ' Returns game data about nickname, kills, deaths, assists, and items returned in string array
        Dim strGame() As String = ReturnGameData(MainMenu.intSelectedGame)

        ' Display nickname, kills, deaths, assists
        lblGameNickname.Text = strGame(0)
        lblKills.Text = strGame(1)
        lblDeaths.Text = strGame(2)
        lblAssists.Text = strGame(3)

        ' Display items
        For intCounter As Integer = 4 To 9 Step 1
            lstItems.Items.Add(strGame(intCounter))
        Next intCounter

        ' Call functions from RecordAndCalculateGame module
        ' KillsPerDeath function returns kills per death
        lblKillsPerDeath.Text = KillsPerDeath(strGame(1), strGame(2)).ToString("n2")
        ' AssistsPerDeath function returns assists per death
        lblAssistsPerDeath.Text = AssistsPerDeath(strGame(3), strGame(2)).ToString("n2")
        ' GoldEarned function returns how much gold was earned
        lblGoldEarned.Text = GoldEarned(strGame(1), strGame(3)).ToString("c")
        ' GoldSpent function returns how much gold was spent
        lblGoldSpent.Text = CostOfItems(strGame).ToString("c")
    End Sub
End Class