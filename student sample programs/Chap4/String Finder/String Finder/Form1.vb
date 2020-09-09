﻿Public Class Form1
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Variable Declarations
        Dim intStartIndex As Integer 'Starting index of the string
        Dim intFoundIndex As Integer 'Index of the found substring

        'Determine whether the starting index is numeric
        If IsNumeric(txtStartIndex.Text) Then

            'Determine whether a string to search for was entered. 
            If txtToFind.Text.Length > 0 Then
                'Get the starting index for the search. 
                intStartIndex = CInt(txtStartIndex.Text)

                'Search for the substring 
                intFoundIndex = lblString.Text.IndexOf(txtToFind.Text, intStartIndex)

                'Indicat whether the search string was found. 
                If intFoundIndex = -1 Then
                    lblResults.Text = "The string was not found."
                Else
                    lblResults.Text = "The string was found at index " & intFoundIndex
                End If
            Else
                'Display an error message for an empty search string. 
                MessageBox.Show("Enter a string to search for.")
            End If
        Else
            'Display an error message for non-numeric index. 
            MessageBox.Show("The index must be a number.")
        End If
    End Sub
End Class
