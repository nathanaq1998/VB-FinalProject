Module Math
    ' Nathan Quinn
    ' CS 201 Project

    ' Variable to keep track
    ' how many games have been recorded
    ' with a max of five games
    Dim intGameNumber As Integer = 0

    ' String arrays to store game data
    ' for five games
    Dim strGameOne(10) As String
    Dim strGameTwo(10) As String
    Dim strGameThree(10) As String
    Dim strGameFour(10) As String
    Dim strGameFive(10) As String

    ' Store kills, deaths, assists, and items in an array
    ' Add nickname of game to lstGames on MainMenu form
    ' Display message if max number of games recorded
    Sub RecordGameData(ByVal strNickname As String, ByVal strKills As String, ByVal strDeaths As String, ByVal strAssists As String,
                       ByVal strItemOne As String, ByVal strItemTwo As String, ByVal strItemThree As String, ByVal strItemFour As String,
                       ByVal strItemFive As String, ByVal strItemSix As String)
        Select Case intGameNumber
            Case 0
                intGameNumber += 1
                strGameOne(0) = strNickname
                strGameOne(1) = strKills
                strGameOne(2) = strDeaths
                strGameOne(3) = strAssists
                strGameOne(4) = strItemOne
                strGameOne(5) = strItemTwo
                strGameOne(6) = strItemThree
                strGameOne(7) = strItemFour
                strGameOne(8) = strItemFive
                strGameOne(9) = strItemSix

                MainMenu.lstGames.Items.Add(strGameOne(0))
            Case 1
                intGameNumber += 1
                strGameTwo(0) = strNickname
                strGameTwo(1) = strKills
                strGameTwo(2) = strDeaths
                strGameTwo(3) = strAssists
                strGameTwo(4) = strItemOne
                strGameTwo(5) = strItemTwo
                strGameTwo(6) = strItemThree
                strGameTwo(7) = strItemFour
                strGameTwo(8) = strItemFive
                strGameTwo(9) = strItemSix

                MainMenu.lstGames.Items.Add(strGameTwo(0))
            Case 2
                intGameNumber += 1
                strGameThree(0) = strNickname
                strGameThree(1) = strKills
                strGameThree(2) = strDeaths
                strGameThree(3) = strAssists
                strGameThree(4) = strItemOne
                strGameThree(5) = strItemTwo
                strGameThree(6) = strItemThree
                strGameThree(7) = strItemFour
                strGameThree(8) = strItemFive
                strGameThree(9) = strItemSix

                MainMenu.lstGames.Items.Add(strGameThree(0))
            Case 3
                intGameNumber += 1
                strGameFour(0) = strNickname
                strGameFour(1) = strKills
                strGameFour(2) = strDeaths
                strGameFour(3) = strAssists
                strGameFour(4) = strItemOne
                strGameFour(5) = strItemTwo
                strGameFour(6) = strItemThree
                strGameFour(7) = strItemFour
                strGameFour(8) = strItemFive
                strGameFour(9) = strItemSix

                MainMenu.lstGames.Items.Add(strGameFour(0))
            Case 4
                intGameNumber += 1
                strGameFive(0) = strNickname
                strGameFive(1) = strKills
                strGameFive(2) = strDeaths
                strGameFive(3) = strAssists
                strGameFive(4) = strItemOne
                strGameFive(5) = strItemTwo
                strGameFive(6) = strItemThree
                strGameFive(7) = strItemFour
                strGameFive(8) = strItemFive
                strGameFive(9) = strItemSix

                MainMenu.lstGames.Items.Add(strGameFive(0))
            Case Else
                MessageBox.Show("Max number of games recorded.")
        End Select
    End Sub

    ' Return game data for selected game from MainMenu form
    Function ReturnGameData(ByVal intGame As Integer) As String()
        Select Case intGame
            Case 0
                Return strGameOne
            Case 1
                Return strGameTwo
            Case 2
                Return strGameThree
            Case 3
                Return strGameFour
            Case 4
                Return strGameFive
        End Select
    End Function

    ' Converts kills and deaths to double from string
    ' calculates and returns how many kills to deaths
    Function KillsPerDeath(ByVal strKills As String, ByVal strDeaths As String) As Double
        Dim dblKills As Double = CDbl(strKills)
        Dim dblDeaths As Double = CDbl(strDeaths)

        ' Kills per death
        Dim dblKillsPerDeath As Double = (dblKills / dblDeaths)

        Return dblKillsPerDeath
    End Function

    ' Converts assists and deaths to double from string
    ' calculates and returns how many assists to deaths
    Function AssistsPerDeath(ByVal strAssists As String, ByVal strDeaths As String) As Double
        Dim intDeaths As Integer
        Dim intAssists As Integer

        Integer.TryParse(strDeaths, intDeaths)
        Integer.TryParse(strAssists, intAssists)

        ' Assists per death
        Dim dblAssistsPerDeath As Double = (intAssists / intDeaths)

        Return dblAssistsPerDeath
    End Function

    ' Converts kills and assists to integer from string
    ' calculates and returns how much gold was earned
    Function GoldEarned(ByVal strKills As String, ByVal strAssists As String) As Integer
        ' Constants for worth of kill and assist
        Const intKILL_GOLD As Integer = 300
        Const intAssist_GOLD As Integer = 150

        Dim intKills As Integer
        Dim intAssists As Integer

        Integer.TryParse(strKills, intKills)
        Integer.TryParse(strAssists, intAssists)

        ' Total gold from kills and assists
        Dim intTotal As Integer = (intKills * intKILL_GOLD) + (intAssists * intAssist_GOLD)

        Return intTotal
    End Function

    ' Takes string array containing the items that were bought
    ' calculates and returns total cost of items bought
    Function CostOfItems(ByVal strItems() As String) As Integer
        ' Constants for value of each item
        Const intBOOTS_OF_SWIFTNESS As Integer = 450
        Const intBOOTS_OF_MOBILITY As Integer = 450
        Const intSORCERER_SHOES As Integer = 550
        Const intBLADE_OF_THE_RUINED_KING As Integer = 1600
        Const intDUSKBLADE_OF_DRAKTHARR As Integer = 1450
        Const intINFINITY_EDGE As Integer = 1700
        Const intLICH_BANE As Integer = 1600
        Const intRABADONS_DEATHCAP As Integer = 1800
        Const intZHONYAS_HOURGLASS As Integer = 1450
        Const intRANDUINS_OMEN As Integer = 1450
        Const intTHORNMAIL As Integer = 1450
        Const intSUNFIRE_CAPE As Integer = 1375
        Const intNONE As Integer = 0

        ' Total of gold spent
        Dim intGoldSpent As Integer = 0

        ' Go through array and add cost of each
        ' purchased item to intGoldSpent
        For intCounter As Integer = 4 To 9 Step 1
            Select Case strItems(intCounter)
                Case "Boots of Swiftness"
                    intGoldSpent += intBOOTS_OF_SWIFTNESS
                Case "Boots of Mobility"
                    intGoldSpent += intBOOTS_OF_MOBILITY
                Case "Sorcerer's Shoes"
                    intGoldSpent += intSORCERER_SHOES
                Case "Blade of the Ruined King"
                    intGoldSpent += intBLADE_OF_THE_RUINED_KING
                Case "Duskblade of Draktharr"
                    intGoldSpent += intDUSKBLADE_OF_DRAKTHARR
                Case "Infinity Edge"
                    intGoldSpent += intINFINITY_EDGE
                Case "Lich Bane"
                    intGoldSpent += intLICH_BANE
                Case "Rabadon's Deathcap"
                    intGoldSpent += intRABADONS_DEATHCAP
                Case "Zhonya's Hourglass"
                    intGoldSpent += intZHONYAS_HOURGLASS
                Case "Randuin's Omen"
                    intGoldSpent += intRANDUINS_OMEN
                Case "Thronmail"
                    intGoldSpent += intTHORNMAIL
                Case "Sunfire Cape"
                    intGoldSpent += intSUNFIRE_CAPE
                Case "None"
                    intGoldSpent += intNONE
            End Select
        Next intCounter

        Return intGoldSpent
    End Function
End Module
