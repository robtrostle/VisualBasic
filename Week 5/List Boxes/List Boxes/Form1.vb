Public Class lstYears
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim strInput As String 'Holds selected month and year

        If lstMonths.SelectedIndex = -1 Then
            'No month is selected
            MessageBox.Show("Select a month.")
        ElseIf lstYear.SelectedIndex = -1 Then
            MessageBox.Show("Select a year.")
        Else
            'Get the selected month and year
            strInput = lstMonths.SelectedItem.ToString() &
                " " & lstYear.SelectedItem.ToString()
            MessageBox.Show("You selected " & strInput)
        End If


    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset the list boxes. 
        lstMonths.SelectedIndex = -1
        lstYear.SelectedIndex = -1
    End Sub
End Class
