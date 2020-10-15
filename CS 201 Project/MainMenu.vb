Public Class MainMenu
    ' Nathan Quinn
    ' CS 201 Project

    ' Global variable to select one of the prerecorded games
    Public Shared intSelectedGame As Integer

    ' Setup class objects for NewGame Form and GameStats Form
    Dim frmNewGame As New NewGame
    Dim frmGameStats As New GameStats

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Select game from lstGames to display
        ' Change intSelectedGame to selected game's index
        ' Open GameStats Form
        Select Case lstGames.SelectedIndex
            Case 0
                intSelectedGame = lstGames.SelectedIndex
                frmGameStats.ShowDialog()
            Case 1
                intSelectedGame = lstGames.SelectedIndex
                frmGameStats.ShowDialog()
            Case 2
                intSelectedGame = lstGames.SelectedIndex
                frmGameStats.ShowDialog()
            Case 3
                intSelectedGame = lstGames.SelectedIndex
                frmGameStats.ShowDialog()
            Case 4
                intSelectedGame = lstGames.SelectedIndex
                frmGameStats.ShowDialog()
            Case Else
                ' No game selected
                MessageBox.Show("Select an game from the list.")
        End Select
    End Sub

    Private Sub mnuGamesAddGame_Click(sender As Object, e As EventArgs) Handles mnuGamesAddGame.Click
        ' Open NewGame Form
        frmNewGame.ShowDialog()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close program
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Shows who made the program
        MessageBox.Show("Store data for five games and display statistics of stored games.")
    End Sub
End Class
