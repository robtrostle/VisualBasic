﻿Public Class Form1

    Private Sub btnEnterSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnterSales.Click
        Const intNUM_DAYS As Integer = 5 'The number of days
        Dim intCount As Integer = 1
        Dim decSales As Decimal = 0
        Dim decTotal As Decimal = 0
        Dim strInput As String

        'Get the sales for each day
        Do While intCount <= intNUM_DAYS
            'Get a daily sales amount from the user
            strInput = InputBox("Enter the sales for day " & intCount.ToString())
            'Convert the input to a decimal
            If Decimal.TryParse(strInput, decSales) Then
                'Add the daily sales to the total sales. 
                decTotal += decSales
                'increment the counter
                intCount += 1
            Else
                'Display and error message for invalid input. 
                MessageBox.Show("Enter a numeric value.")
            End If
        Loop

        'Disply the total sales. 
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub
End Class
