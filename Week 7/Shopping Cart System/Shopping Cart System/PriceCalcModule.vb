Module PriceCalcModule
    'Global book price Constants
    Public Const g_decIdidItYourWay As Decimal = 11.95D
    Public Const g_decTheHistoryOfScotland As Decimal = 14.5D
    Public Const g_decLearnCalculusInOneDay As Decimal = 29.95D
    Public Const g_decLearnCalculusInOneDayAudio As Decimal = 29.95D
    Public Const g_decFeelTheStress As Decimal = 18.5D
    Public Const g_decTheScienceOfBodyLanguage As Decimal = 12.95D
    Public Const g_decRelaxationTechniques As Decimal = 11.5D
    'Global Charges constants
    Public Const g_decShipping_Charge As Decimal = 2D
    Public Const g_decSales_Tax As Decimal = 0.06D
    'Global Totals 
    Public g_decTotal As Decimal
    Public g_decSubTotal As Decimal
    Public g_decTaxTotal As Decimal
    Public g_decShippingTotal As Decimal

    'Global string to hold selected book
    Public strSelectedString As String

    'Global variables for Print book names
    Public g_strWayPrint As String = "I Did It Your Way (Print)"
    Public g_strHistoryPrint As String = "The History of Scotland (Print)"
    Public g_strCalculusPrint As String = "Learn Calculus in One Day (Print)"
    Public g_strStress As String = "Feel the Stress (Print)"

    'Global variables for Audio book names
    Public g_strCalculusAudio As String = "Learn Calculus in One Day (Audio)"
    Public g_strRelaxation As String = "Relaxation Techniques (Audio)"
    Public g_strHistoryAudio As String = "The History of Scotland (Audio)"
    Public g_strScience As String = "The Science of Body Language (Audio)"


    Public Sub Recalculate() 'A global function for recalcuating items when items are removed from the shopping cart. 
        CalculateTax()
        CalculateTotal()
    End Sub

    Public Sub CalculateTax() 'Global function for calculating taxes
        g_decTaxTotal = g_decSubTotal * g_decSales_Tax
        frmMainForm.lblTax.Text = g_decTaxTotal.ToString("c")
    End Sub

    Public Sub CalculateTotal() 'Global function for calculating totals
        frmMainForm.lblShipping.Text = g_decShippingTotal.ToString("c")
        frmMainForm.lblSubTotal.Text = g_decSubTotal.ToString("c")
        g_decTotal = g_decTaxTotal + g_decSubTotal + g_decShippingTotal
        frmMainForm.lblTotal.Text = g_decTotal.ToString("c")
    End Sub

    Public Sub ClearAudioBooks() 'Global method for clearing the Book list

        frmAudioBooks.lstAudioBooks.Items.Clear()

    End Sub

    Public Sub ClearPrintBooks() 'Global method for clearing the Book list

        frmPrintBooks.lstPrintBooks.Items.Clear()

    End Sub 'Module level global variables for Forms

    Public frmAudioBooks As New AudioBooks
    Public frmMainForm As New MainForm
    Public frmPrintBooks As New PrintBooks

    Public Sub AddAudioBook()  'Module level function for adding audio books using case statements

        Select Case frmAudioBooks.lstAudioBooks.SelectedIndex

            Case 0
                strSelectedString = g_strCalculusAudio
                g_decSubTotal += g_decLearnCalculusInOneDay
                g_decShippingTotal += g_decShipping_Charge
                frmMainForm.lstProducts.Items.Add(g_strCalculusAudio)

            Case 1
                strSelectedString = g_strRelaxation
                g_decSubTotal += g_decRelaxationTechniques
                g_decShippingTotal += g_decShipping_Charge
                frmMainForm.lstProducts.Items.Add(g_strRelaxation)
            Case 2
                strSelectedString = g_strHistoryAudio
                g_decSubTotal += g_decTheHistoryOfScotland
                g_decShippingTotal += g_decShipping_Charge
                frmMainForm.lstProducts.Items.Add(g_strHistoryAudio)
            Case 3
                strSelectedString = g_strScience
                g_decSubTotal += g_decTheScienceOfBodyLanguage
                g_decShippingTotal += g_decShipping_Charge
                frmMainForm.lstProducts.Items.Add(g_strScience)
        End Select

    End Sub
    'The below function was not used


    'Public Sub AddPrintBook()

    '    Select Case frmPrintBooks.lstPrintBooks.SelectedIndex

    '        Case 0
    '            strSelectedString = g_strWayPrint
    '            g_decSubTotal += g_decIdidItYourWay
    '            g_decShippingTotal += g_decShipping_Charge
    '            frmMainForm.lstProducts.Items.Add(g_strWayPrint)
    '        Case 1
    '            strSelectedString = g_strHistoryPrint
    '            g_decSubTotal += g_decTheHistoryOfScotland
    '            g_decShippingTotal += g_decShipping_Charge
    '            frmMainForm.lstProducts.Items.Add(g_strHistoryPrint)
    '        Case 2
    '            strSelectedString = g_strCalculusPrint
    '            g_decSubTotal += g_decLearnCalculusInOneDay
    '            g_decShippingTotal += g_decShipping_Charge
    '            frmMainForm.lstProducts.Items.Add(g_strCalculusPrint)
    '        Case 3
    '            strSelectedString = g_strStress
    '            g_decSubTotal += g_decFeelTheStress
    '            g_decShippingTotal += g_decShipping_Charge
    '            frmMainForm.lstProducts.Items.Add(g_strStress)
    '    End Select

    'End Sub

End Module
