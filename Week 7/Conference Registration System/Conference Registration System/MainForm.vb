Public Class MainForm
    Dim frmConferenceOptions As New ConferenceOptionsForm
    Public Sub btnSelectConferenceOptions_Click(sender As Object, e As EventArgs) Handles btnSelectConferenceOptions.Click

        'Display the conference options form and hide this form

        Me.Hide()

        frmConferenceOptions.ShowDialog()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        'Clear the text box and the display lables
        txtName.Clear()
        txtCompany.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        txtState.Clear()
        txtZip.Clear()
        lblTotal.Text = String.Empty

        'Reset the focus
        txtName.Focus()

        'Reset Grand Total
        decGrandTotal = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close the forms
        Me.Close()
        frmConferenceOptions.Close()

    End Sub
End Class
