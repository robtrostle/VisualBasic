Public Class MainForm


    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'Clear all items from the list
        lstProducts.Items.Clear()

        'Clear all labels. 
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblShipping.Text = String.Empty
        lblTotal.Text = String.Empty

        'Reset Sub and shipping total
        g_decSubTotal = 0
        g_decShippingTotal = 0

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'Exit/Close the program
        'Application.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Display a message
        MessageBox.Show("Trostle Enterprises Shopping Cart System Version 1.0")
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click

        'Display PrintBooks
        Me.Hide()
        frmPrintBooks.ShowDialog()

    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click

        'Display AudioBooks
        Me.Hide()
        frmAudioBooks.ShowDialog()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If lstProducts.SelectedItem.ToString() = g_strCalculusAudio Then
            g_decSubTotal -= g_decLearnCalculusInOneDayAudio
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        ElseIf lstProducts.SelectedItem.ToString() = g_strCalculusPrint Then
            g_decSubTotal -= g_decLearnCalculusInOneDay
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        ElseIf lstProducts.SelectedItem.ToString() = g_strHistoryAudio Then
            g_decSubTotal -= g_decTheHistoryOfScotland
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        ElseIf lstProducts.SelectedItem.ToString() = g_strHistoryPrint Then
            g_decSubTotal -= g_decTheHistoryOfScotland
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        ElseIf lstProducts.SelectedItem.ToString() = g_strRelaxation Then
            g_decSubTotal -= g_decRelaxationTechniques
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        ElseIf lstProducts.SelectedItem.ToString() = g_strScience Then
            g_decSubTotal -= g_decTheScienceOfBodyLanguage
            g_decShippingTotal -= g_decShipping_Charge
            UpdateForm()
        End If


        lstProducts.Items.Remove(lstProducts.SelectedItem)

    End Sub

    Private Sub UpdateForm()
        Recalculate()
        lblSubTotal.Text = g_decSubTotal.ToString("c")
        lblTax.Text = g_decTaxTotal.ToString("c")
        lblShipping.Text = g_decShippingTotal.ToString("c")
        lblTotal.Text = g_decTotal.ToString("c")
    End Sub
End Class
