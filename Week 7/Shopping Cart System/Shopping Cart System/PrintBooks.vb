Public Class PrintBooks

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        CalculateTax()
        CalculateTotal()

        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()

    End Sub

    Private Sub btnAddPrintBook_Click(sender As Object, e As EventArgs) Handles btnAddPrintBook.Click

        'Use alternate method for adding print books

        If lstPrintBooks.SelectedIndex = 0 Then
            frmMainForm.lstProducts.Items.Add(g_strWayPrint)
            g_decSubTotal += g_decIdidItYourWay
            g_decShippingTotal += g_decShipping_Charge
        End If
        If lstPrintBooks.SelectedIndex = 1 Then
            frmMainForm.lstProducts.Items.Add(g_strHistoryPrint)
            g_decSubTotal += g_decTheHistoryOfScotland
            g_decShippingTotal += g_decShipping_Charge
        End If
        If lstPrintBooks.SelectedIndex = 2 Then
            frmMainForm.lstProducts.Items.Add(g_strCalculusPrint)
            g_decSubTotal += g_decLearnCalculusInOneDay
            g_decShippingTotal += g_decShipping_Charge
        End If
        If lstPrintBooks.SelectedIndex = 3 Then
            frmMainForm.lstProducts.Items.Add(g_strStress)
            g_decSubTotal += g_decFeelTheStress
            g_decShippingTotal += g_decShipping_Charge
        End If


    End Sub

    Private Sub PrintBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls the ClearBooks sub to clear the list then adds items back to the list
        ClearPrintBooks()

        lstPrintBooks.Items.Add(g_strWayPrint)
        lstPrintBooks.Items.Add(g_strHistoryPrint)
        lstPrintBooks.Items.Add(g_strCalculusPrint)
        lstPrintBooks.Items.Add(g_strStress)

    End Sub
End Class