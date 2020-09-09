Public Class MainForm
    Private Sub btnDisplayForm_Click(sender As Object, e As EventArgs) Handles btnDisplayForm.Click
        'Creat an instance of MessageForm
        Dim frmMessage As New MessageForm

        'Display the form in the modal style
        frmMessage.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
