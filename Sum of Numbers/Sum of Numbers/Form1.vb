Public Class Form1
    Private Sub btnEnterNumber_Click(sender As Object, e As EventArgs) Handles btnEnterNumber.Click
        Dim intCount As Integer = 1 ' Loop counter
        Dim intNumber As Integer    ' To hold the user's input
        Dim intTotal As Integer = 0 ' To hold the total
        Dim strInput As String      ' To hold string input

        ' Get a number from the user
        strInput = InputBox("Enter a positive integer value", "Input Needed", "10")

        ' Convert the input to an Integer
        If Integer.TryParse(strInput, intNumber) Then
            ' Display error message if the input is a negative integer
            If intNumber < 0 Then
                MessageBox.Show("Enter a positive integer")
            Else
                ' Do a validation loop
                Do While intCount <= intNumber
                    ' Do the calculation
                    intTotal += intCount
                    ' Add 1 to the loop counter
                    intCount += 1
                Loop
                ' Diplay the total sum of numbers
                MessageBox.Show("The sum of numbers 1 through " & strInput & " is " & intTotal.ToString("d"))
            End If
        Else
            ' Display an error message if input is not an integer
            MessageBox.Show("Enter an integer value")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
