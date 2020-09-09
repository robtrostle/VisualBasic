Public Class Form1
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim strUserIntegers As String 'Initial string input
        Dim intIntegers As Integer 'Holds the user's input
        Dim intResult As Integer = 0 'Results total
        Dim intCount As Integer = 1 'To hold String input
        Dim blnInputOk As Boolean = True
        'Disply Options to Enter a positive integer number or quit
        strUserIntegers = InputBox("Enter a positive Integer Value", "Input Needed", "10")
        'validate input is an integer
        If Not Integer.TryParse(strUserIntegers, intIntegers) Then
            MessageBox.Show("Enter an integer value")
            blnInputOk = False
            'Validate number is neither 0 or negative
        ElseIf intIntegers <= 0 Then
            MessageBox.Show("Enter a positive integer value")
            blnInputOk = False
        End If
        'If tests pass...
        If blnInputOk = True Then
            'Convert input to integers
            intIntegers = CInt(strUserIntegers)
            'Start counting loops 
            Do While intCount <= intIntegers
                'Calculte results
                intResult += intCount
                'Increment counter
                intCount += 1
            Loop
            'Display results
            MessageBox.Show("The sum of numbers 1 through " & strUserIntegers & " is " & intResult.ToString("d"))
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Close program
    End Sub
End Class
