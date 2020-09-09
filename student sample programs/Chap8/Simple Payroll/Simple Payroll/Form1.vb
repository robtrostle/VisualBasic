﻿Public Class Form1
    Private Sub btnCalcPay_Click(sender As Object, e As EventArgs) Handles btnCalcPay.Click
        Const decHOURLY_PAY_RATE As Decimal = 15D
        Const intMAX_SUBSCRIPT As Integer = 5

        'Array and other variables. 
        Dim dblHoursArray(intMAX_SUBSCRIPT) As Double
        Dim intCount As Integer = 0
        Dim decEmpPay As Decimal 'to hold gross pay

        'Prepar the user to enter each employee's hours. 
        MessageBox.Show("I'm going to ask you for each " & "emplyee's hours worked.")

        'Get the hours worked by the employees. 
        Do While intCount < dblHoursArray.Length
            Try
                dblHoursArray(intCount) =
                    CDbl(InputBox("Emplyee number " & (intCount + 1).ToString()))
                intCount += 1
            Catch
                'Display an error message for invalid hours. 
                MessageBox.Show("Enter a valid number of " & "hours for that employee.")
            End Try
        Loop
        'Clear the list box
        lstOutput.Items.Clear()

        'Calculate and display each employee's gross pay. 
        For intCount = 0 To dblHoursArray.Length - 1
            decEmpPay = CDec(dblHoursArray(intCount) * decHOURLY_PAY_RATE)

            lstOutput.Items.Add("Employee " & (intCount + 1).ToString() &
                " earned " & decEmpPay.ToString("c"))
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
