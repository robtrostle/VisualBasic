Public Class MainForm

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		' Clear the list box.
		lstOutput.Items.Clear()
	End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnShowModal_Click(sender As Object, e As EventArgs) Handles btnShowModal.Click
        Dim intCount As Integer 'Counter
        Dim frmMessage As New MessageForm  'instance of message form

        'Show the message form in the modal style. 
        frmMessage.ShowDialog()

        'Display some numbers in the list box on the mainform. 
        'This will happen AFTER the user closes the messageform. 
        For intCount = 1 To 10
            lstOutput.Items.Add(intCount.ToString())
        Next
    End Sub

    Private Sub btnShowModeless_Click(sender As Object, e As EventArgs) Handles btnShowModeless.Click
        Dim intCount As Integer  'Counter
        Dim frmMessage As New MessageForm 'Instance of Message Form

        'Show the message form in the modeless style. 
        frmMessage.Show()

        'Display some numbers in the list box on the MainForm. 
        'This will happen while the MessageForm is still on the screen. 
        For intCount = 1 To 10
            lstOutput.Items.Add(intCount.ToString())
        Next
    End Sub
End Class
