Public Class Decks
    Private Sub Decks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear Decks List
        ClearDecks()

        'Adds items to the decks list
        lstDecks.Items.Add(strMasterThrasher)
        lstDecks.Items.Add(strDictatorOfGrind)
        lstDecks.Items.Add(strStreetKing)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CalculateTax()
        CalculateTotal()

        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If an item is selected....
        If lstDecks.SelectedIndex <> -1 Then
            'Call the AddDecks Function which will add the selected item to the decks lable on the mainForm

            AddDecks()

        End If
    End Sub
End Class