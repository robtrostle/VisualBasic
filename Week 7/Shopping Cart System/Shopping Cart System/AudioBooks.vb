Public Class AudioBooks

    Private Sub btnAddPrintBook_Click(sender As Object, e As EventArgs) Handles btnAddPrintBook.Click
        'If a book is selected, call add audio book function
        If lstAudioBooks.SelectedIndex <> -1 Then

            AddAudioBook()

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Call module functions to calculate the totals
        CalculateTax()
        CalculateTotal()

        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()

    End Sub

    Private Sub AudioBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Calls the ClearBooks sub to clear the list then adds items back to the list
        ClearAudioBooks()

        lstAudioBooks.Items.Add(g_strCalculusAudio)
        lstAudioBooks.Items.Add(g_strRelaxation)
        lstAudioBooks.Items.Add(g_strHistoryAudio)
        lstAudioBooks.Items.Add(g_strScience)

    End Sub
End Class