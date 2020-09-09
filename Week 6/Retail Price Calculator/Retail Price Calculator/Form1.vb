Public Class Form1

    Private decWholesale As Decimal 'Holds the retail price
    Private decPercentage As Decimal 'Holds the markup percentage
    Private Function ValidateInputFields() As Boolean
        'Tro to convert each of the input fields. Return false if any field is invalidd, and display error message.
        If Not Decimal.TryParse(txtWholeSaleCost.Text, decWholesale) Then
            MessageBox.Show("Retail price must be numeric")
            Return False
        End If
        If Not Decimal.TryParse(txtMarkup.Text, decPercentage) Then
            MessageBox.Show("Markup % must be numeric")
            Return False
        End If
        If (decWholesale < 0) Then
            MessageBox.Show("Please enter Non-negative numbers")
        ElseIf (decPercentage < 0) Then
            MessageBox.Show("Please enter Non-negative numbers")
        End If

        Return True
    End Function

    Function CalculateRetail(ByVal decWholeSale As Decimal, ByVal decPercentage As Decimal) As Decimal
        'Calculate and return the retail price
        Dim decRetailPrice As Decimal
        decRetailPrice = decWholeSale + (decWholeSale * decPercentage)
        Return decRetailPrice
    End Function

    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim decRetailPrice As Decimal
        'Clear ny previous message
        lblRetailPrice.Text = String.Empty

        'If the input is valid, disply the retail price
        If ValidateInputFields() Then
            decRetailPrice = CalculateRetail(decWholesale, decPercentage)
            lblRetailPrice.Text = decRetailPrice.ToString("c")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the program
        Me.Close()
    End Sub
End Class
