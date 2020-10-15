Public Class NewGame
    ' Nathan Quinn
    ' CS 201 Project

    Private Sub mnuFileSubmit_Click(sender As Object, e As EventArgs) Handles mnuFileSubmit.Click
        ' Declare variables
        ' blnError indicates that the form is missing data
        ' or recieved the wrong data type
        Dim blnError As Boolean = False

        ' Name of game assigned by user
        Dim strNickname As String

        ' Kills, deaths, assists of the game
        Dim strKills As String
        Dim strDeaths As String
        Dim strAssists As String

        ' Variables to check if kills, deaths, assists
        ' were entered as integers
        Dim intKills As Integer
        Dim intDeaths As Integer
        Dim intAssists As Integer



        ' Items purchased that game
        Dim strItemOne As String
        Dim strItemTwo As String
        Dim strItemThree As String
        Dim strItemFour As String
        Dim strItemFive As String
        Dim strItemSix As String


        ' Check if user has given the game a nickname
        If txtNickname.Text <> String.Empty Then
            strNickname = txtNickname.Text
        Else
            ' Let user know that the game
            ' needs a nickname
            MessageBox.Show("Please give the game a nickname.")
            blnError = True
        End If

        ' Validate kills, deaths, assists can be converted to integer
        ' And store in strings
        ' Displays message if they can't and chnages blnError to True
        If Integer.TryParse(txtKills.Text, intKills) Then
            strKills = txtKills.Text

            If Integer.TryParse(txtDeaths.Text, intKills) Then
                strDeaths = txtDeaths.Text

                If Integer.TryParse(txtAssists.Text, intKills) Then
                    strAssists = txtAssists.Text

                Else
                    MessageBox.Show("Please enter an integer for assists.")
                    blnError = True
                End If
            Else
                MessageBox.Show("Please enter an integer for Deaths.")
                blnError = True
            End If
        Else
            MessageBox.Show("Please enter an integer for kills.")
            blnError = True
        End If

        ' Check if all item combo boxs have a selected value
        ' Displays message if one or more doesn't and chnages blnError to True
        If cmbItemOne.SelectedItem.ToString <> String.Empty Or cmbItemTwo.SelectedItem.ToString <> String.Empty Or
            cmbItemThree.SelectedItem.ToString <> String.Empty Or cmbItemFour.SelectedItem.ToString <> String.Empty Or
            cmbItemFive.SelectedItem.ToString <> String.Empty Or cmbItemSix.SelectedItem.ToString <> String.Empty Then

            strItemOne = cmbItemOne.SelectedItem.ToString
            strItemTwo = cmbItemTwo.SelectedItem.ToString
            strItemThree = cmbItemThree.SelectedItem.ToString
            strItemFour = cmbItemFour.SelectedItem.ToString
            strItemFive = cmbItemFive.SelectedItem.ToString
            strItemSix = cmbItemSix.SelectedItem.ToString
        Else
            MessageBox.Show("Please fill all the items (Select none if you didn't have a full item set).")
            blnError = True
        End If

        ' If no errors pass kills, deaths, assists, and item string variables
        ' to RecordGameData function in RecordedAndCalculateGame module
        If blnError = False Then
            RecordGameData(strNickname, strKills, strDeaths, strAssists, strItemOne,
                            strItemTwo, strItemThree, strItemFour, strItemFive, strItemSix)

            ' Clear form
            ClearForm()
            ' Close form
            Me.Close()
        End If
    End Sub

    ' Clears all text boxes
    ' and resets combo boxes
    Sub ClearForm()
        txtNickname.Text = String.Empty
        txtKills.Text = String.Empty
        txtDeaths.Text = String.Empty
        txtAssists.Text = String.Empty

        cmbItemOne.SelectedIndex = -1
        cmbItemTwo.SelectedIndex = -1
        cmbItemThree.SelectedIndex = -1
        cmbItemFour.SelectedIndex = -1
        cmbItemFive.SelectedIndex = -1
        cmbItemSix.SelectedIndex = -1
    End Sub

    ' Clears form if user
    ' confrims the reseting of the form
    Private Sub mnuFileReset_Click(sender As Object, e As EventArgs) Handles mnuFileReset.Click
        Dim strAnswer As String = InputBox("Reset the form, Y/N?", "Reset New Game Form", "")

        If (strAnswer = "Y") Or (strAnswer = "y") Then
            ClearForm()
        ElseIf (strAnswer = "N") Or (strAnswer = "n") Then
        Else
            MessageBox.Show("Please select a valid option.")
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close form
        Me.Close()
    End Sub

    ' Displays what the user needs to do
    ' to submit game data
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Fill out all the boxes then submit to save game data.")
    End Sub
End Class