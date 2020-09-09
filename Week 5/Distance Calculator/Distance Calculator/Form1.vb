Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim strSpeed As String
        Dim intSpeed As Integer
        Dim blnInputOk As Boolean = True
        Dim intCount As Integer
        Dim strHours As String
        Dim intHours As Integer = 1
        Dim intDistance As Integer
        Dim strOut As String
        Dim strHeader As String


        'Validate input
        strSpeed = InputBox("Enter a speed in miles per hour", "Input Needed")
        If Not Integer.TryParse(strSpeed, intSpeed) Then
            MessageBox.Show("Enter an integer value")
            blnInputOk = False
        End If

        strHours = InputBox("Enter the amount of time in hours", "Input Needed")
        If Not Integer.TryParse(strHours, intHours) Then
            MessageBox.Show("Enter an integer value")
            blnInputOk = False
        End If
        'Assign and convert input
        If blnInputOk = True Then
            intSpeed = CInt(strSpeed)
            intHours = CInt(strHours)
        End If
        'Display header
        strHeader = "Vehicle Speed: " & strSpeed
        With lstOutput.Items
            .Add("Vehicle Speed: " & intSpeed.ToString & "MPH")
            .Add("Time Traveled: " & intHours.ToString & " Hours")
            .Add("Hours     " & "Distance Traveled")
            .Add("------------------------------------")
        End With

        'Start loop with calculation 
        For intCount = 1 To intHours

            intDistance = intSpeed * intCount

            strOut = intCount.ToString("d")
            strOut &= "          " & intDistance.ToString("d")

            lstOutput.Items.Add(strOut)
        Next
        'Display total distance
        lstOutput.Items.Add("Total Distance: " & intDistance.ToString("d"))
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
