Public Class MainForm
    Private Sub btnViewDecks_Click(sender As Object, e As EventArgs) Handles btnViewDecks.Click
        'Show Decks form
        Me.Hide()
        frmDecks.ShowDialog()
    End Sub

    Private Sub btnViewTrucks_Click(sender As Object, e As EventArgs) Handles btnViewTrucks.Click
        'Show Trucks form
        Me.Hide()
        frmTrucks.ShowDialog()
    End Sub

    Private Sub btnViewWheels_Click(sender As Object, e As EventArgs) Handles btnViewWheels.Click
        'Show Wheels form
        Me.Hide()
        frmWheels.ShowDialog()
    End Sub

    Private Sub btnViewMisc_Click(sender As Object, e As EventArgs) Handles btnViewMisc.Click
        'Show Misc form
        Me.Hide()
        frmMiscellaneous.ShowDialog()
    End Sub

    Private Sub btnClearMisc_Click(sender As Object, e As EventArgs) Handles btnClearMisc.Click
        'Call ClearMisc Method

        ClearMisc()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clear labels 
        lblDeck.Text = String.Empty
        lblTrucks.Text = String.Empty
        lblWheels.Text = String.Empty
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
        'Clear the list box
        lstMisc.Items.Clear()
        'Reset Variables
        g_decSubTotal = 0
        g_decTaxTotal = 0
        g_decTotal = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program

        Application.Exit()
    End Sub
End Class
