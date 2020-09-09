Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click

        'Declare Variables
        Dim decGallonsOfGas As Decimal  'Gallons of gas the car can hold
            Dim decNumberOfMiles As Decimal 'Number of miles the car can travel
            Dim decMilesPerGallon As Decimal 'Miles per gallon calculated
        Try
            'Calculate and display the miles per gallon
            decMilesPerGallon = CDec(txtNumberOfMiles.Text) / CDec(txtGallonsOfGas.Text)
            lblMilesPerGallon.Text = decMilesPerGallon.ToString("n1")

        Catch ex As DivideByZeroException
            'Zero was entered in Gallons of gas field
            MessageBox.Show("Error: Enter nonzero values.")

        Catch ex As InvalidCastException
            MessageBox.Show("Input must be numeric")

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the fields and return the focus to Gallons of gas
        txtGallonsOfGas.Clear()
        txtNumberOfMiles.Clear()

        'Clear the MPG field
        lblMilesPerGallon.Text = String.Empty

        'Reset the focus to MPG
        txtGallonsOfGas.Focus()

    End Sub
End Class
