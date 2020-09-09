Module StringModule
    'String Variables for Deck List 
    Public strMasterThrasher As String = "The Master Thrasher     ($60)"
    Public strDictatorOfGrind As String = "The Dictator of Grind      ($45)"
    Public strStreetKing As String = "The Street King     ($50)"

    Public Sub ClearDecks() 'Global method for clearing the Truck list
        frmDecks.lstDecks.Items.Clear()
    End Sub

    'Function for adding Decks
    Public Sub AddDecks()  'Module level function for adding decks using case statements

        Select Case frmDecks.lstDecks.SelectedIndex

            Case 0
                strSelectedString = strMasterThrasher
                g_decSubTotal += decMasterThrasher
                frmMainForm.lblDeck.Text = strMasterThrasher
            Case 1
                strSelectedString = strDictatorOfGrind
                g_decSubTotal += decDictatorOfGrind
                frmMainForm.lblDeck.Text = strDictatorOfGrind
            Case 2
                strSelectedString = strStreetKing
                g_decSubTotal += decStreetKing
                frmMainForm.lblDeck.Text = strStreetKing
        End Select

    End Sub

    'String Variables for Trucks list
    Public strSevenPointSevenFiveAxle As String = "7.75 axle    ($35)"
    Public strEightAxle As String = "8 axle     ($40)"
    Public strEightPointFive As String = "8.5 axle      ($45)"

    Public Sub ClearTrucks() 'Global method for clearing the Truck list
        frmTrucks.lstTrucks.Items.Clear()
    End Sub

    Public Sub AddTrucks()  'Module level function for adding trucks using case statements

        Select Case frmTrucks.lstTrucks.SelectedIndex

            Case 0
                strSelectedString = strSevenPointSevenFiveAxle
                g_decSubTotal += decSevenPointSevenFiveAxle
                frmMainForm.lblTrucks.Text = strSevenPointSevenFiveAxle
            Case 1
                strSelectedString = strEightAxle
                g_decSubTotal += decEightAxle
                frmMainForm.lblTrucks.Text = strEightAxle
            Case 2
                strSelectedString = strEightPointFive
                g_decSubTotal += decEightPointFive
                frmMainForm.lblTrucks.Text = strEightPointFive
        End Select

    End Sub
    'String variables for wheels list
    Public strFiftyOneMM As String = "51 mm     ($20)"
    Public strFiftyFiveMM As String = "55 mm     ($22)"
    Public strFiftyEightMM As String = "58 mm     ($24)"
    Public strSixtyOneMM As String = "61 mm     ($28)"

    Public Sub ClearWheels() 'Global method for clearing the Wheels list
        frmWheels.lstWheels.Items.Clear()
    End Sub

    Public Sub AddWheels()  'Module level function for adding wheels using case statements

        Select Case frmWheels.lstWheels.SelectedIndex

            Case 0
                strSelectedString = strFiftyOneMM
                g_decSubTotal += decFiftyOneMM
                frmMainForm.lblWheels.Text = strFiftyOneMM
            Case 1
                strSelectedString = strFiftyFiveMM
                g_decSubTotal += decFiftyFiveMM
                frmMainForm.lblWheels.Text = strFiftyFiveMM
            Case 2
                strSelectedString = strFiftyEightMM
                g_decSubTotal += decFiftyEightMM
                frmMainForm.lblWheels.Text = strFiftyEightMM
            Case 3
                strSelectedString = strSixtyOneMM
                g_decSubTotal += decSixtyOneMM
                frmMainForm.lblWheels.Text = strSixtyOneMM
        End Select

    End Sub

    'String variables for misc list
    Public strGripTape As String = "Grip Tape"
    Public strBearings As String = "Bearings"
    Public strRiserPads As String = "Riser Pads"
    Public strNutsAndBolts As String = "Nuts & Bolts Kit"
    Public strAssembly As String = "Assembly"

    Public Sub ClearMisc() 'Global method for clearing the misc list
        frmMainForm.lstMisc.Items.Clear()
    End Sub


End Module
