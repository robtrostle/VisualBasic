Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decWeekOne As Decimal
        Dim decWeekTwo As Decimal
        Dim decWeekThree As Decimal
        Dim decWeekFour As Decimal
        Dim decCostPerWeek As Decimal
        Dim blnInputOk As Boolean = True
        Dim decWeekOneRevenue As Decimal
        Dim decWeekTwoRevenue As Decimal
        Dim decWeekThreeRevenue As Decimal
        Dim decWeekFourRevenue As Decimal

        'Validate the user input
        If Decimal.TryParse(txtWeekOne.Text, decWeekOne) = False Then
            lblStatus.Text = "Input must be integers"
            blnInputOk = False

        ElseIf Decimal.TryParse(txtWeekTwo.Text, decWeekTwo) = False Then
            lblStatus.Text = "Input must be integers"
            blnInputOk = False

        ElseIf Decimal.TryParse(txtWeekThree.Text, decWeekThree) = False Then
            lblStatus.Text = "Input must be integers"
            blnInputOk = False

        ElseIf Decimal.TryParse(txtWeekFour.Text, decWeekFour) = False Then
            lblStatus.Text = "Input must be integers"
            blnInputOk = False

        ElseIf Decimal.TryParse(txtCostPerWeek.Text, decCostPerWeek) = False Then
            lblStatus.Text = "Input must be integers"
            blnInputOk = False
        End If


        If blnInputOk = True Then
            Try
                'Get and convert userinput
                decWeekOne = CDec(txtWeekOne.Text)
                decWeekTwo = CDec(txtWeekTwo.Text)
                decWeekThree = CDec(txtWeekThree.Text)
                decWeekFour = CDec(txtWeekFour.Text)
                decCostPerWeek = CDec(txtCostPerWeek.Text)
                'Display results
                decWeekOneRevenue = decCostPerWeek / decWeekOne
                lblWeekOne.Text = decWeekOneRevenue.ToString("c")

                decWeekTwoRevenue = decCostPerWeek / decWeekTwo
                lblWeekTwo.Text = decWeekTwoRevenue.ToString("c")

                decWeekThreeRevenue = decCostPerWeek / decWeekThree
                lblWeekThree.Text = decWeekThreeRevenue.ToString("c")

                decWeekFourRevenue = decCostPerWeek / decWeekFour
                lblWeekFour.Text = decWeekFourRevenue.ToString("c")

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the App
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the weekly text boxes. 
        txtWeekOne.Text = String.Empty
        txtWeekTwo.Text = String.Empty
        txtWeekThree.Text = String.Empty
        txtWeekFour.Text = String.Empty

        'Clear the labels
        lblWeekOne.Text = String.Empty
        lblWeekTwo.Text = String.Empty
        lblWeekThree.Text = String.Empty
        lblWeekFour.Text = String.Empty
        lblStatus.Text = String.Empty

        'return focus to cost per week
        txtCostPerWeek.Text = String.Empty
        txtCostPerWeek.Focus()

    End Sub
End Class
