Public Class Form1
    Private Sub btnShowName_Click(sender As Object, e As EventArgs) Handles btnShowName.Click
        'Declare a strnig variable to hold the full name. 
        Dim strFullName As String

        '/Combine the first and last names and assign the result to StrFullName. 
        strFullName = txtFirstName.Text & " " & txtLastName.Text

        'Display the full name in the lblFullName label
        lblFullName.Text = strFullName

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear TextBox controls and the Label. 
        txtFirstName.Clear()
        txtLastName.Clear()
        lblFullName.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form. 
        Me.Close()
    End Sub
End Class
