Public Class Form1
    'Class - level declarations
    Const intMAX_SUBSCRIPT As Integer = 9                  'upper subscript
    Dim intNumbers(intMAX_SUBSCRIPT) As Integer      'Array to hold user's numbers
    Dim intMax As Integer 'To hold the max number
    Dim intMin As Integer 'To hold the min number


    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Dim intCount As Integer = 0 'loop counter set to 0

        'Fill the intNumbers array with user's input
        Do While intCount < intNumbers.Length
            Try
                'Get the numbers from user
                intNumbers(intCount) = CInt(InputBox("Enter Integer number " & (intCount + 1).ToString()))
                'increment intCount
                intCount += 1

            Catch
                'display an error message for invalid input
                MessageBox.Show("Enter a valid numeric integer value.")
            End Try
        Loop

    End Sub

    Function Max(ByVal intValues() As Integer) As Integer
        Dim intCount As Integer 'loop counter

        'Get the first value in the array
        intMax = intValues(0)

        'Search for the max value
        For intCount = 1 To (intValues.Length - 1)
            If intValues(intCount) > intMax Then
                intMax = intValues(intCount)
            End If
        Next
        'Return the max value. 
        Return intMax
    End Function

    Function Min(ByVal intValues() As Integer) As Integer
        Dim intCount As Integer 'loop counter

        'Get the first value in the array
        intMin = intValues(0)

        'Search for the min value
        For intCount = 1 To (intValues.Length - 1)
            If intValues(intCount) < intMin Then
                intMin = intValues(intCount)
            End If
        Next
        'Return the min value. 
        Return intMin
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intCount As Integer 'loop counter

        'Clear the list box 
        lstNumbers.Items.Clear()
        'Display header
        lstNumbers.Items.Add("Input Values")
        'display the numbers in the list box 
        For intCount = 0 To intMAX_SUBSCRIPT
            lstNumbers.Items.Add(intNumbers(intCount).ToString)
        Next

        'Display the results in the label. 
        lblResult.Text = "The largest value is " & Max(intNumbers).ToString & " and the lowest value is " & Min(intNumbers).ToString
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the list box and label
        lstNumbers.Items.Clear()
        lblResult.Text = String.Empty
    End Sub
End Class
