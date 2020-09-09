Public Class Form1
    'Declare class level variables
    Const decPerDayCharge As Decimal = 350D
    Dim decTotalCost As Decimal
    Dim decMiscCharges As Decimal
    Dim decCostofStay As Decimal
    Dim decMedication As Decimal
    Dim decSurgicalCharges As Decimal
    Dim decLabFees As Decimal
    Dim decPhysicalRehab As Decimal
    Dim intLengthOfStay As Integer


    Function ValidateInputFields() As Boolean
        'Try to convert each of the input fields. Return false if any field is invalid and display error message box
        If Not Integer.TryParse(txtLengthOfStay.Text, intLengthOfStay) Then
            lblTotalCost.Text = "Please enter numeric integer value in Length of Stay field"
            Return False
        End If
        If Not Decimal.TryParse(txtMedication.Text, decMedication) Then
            lblTotalCost.Text = "Please enter numeric value in Medication field"
            Return False
        End If
        If Not Decimal.TryParse(txtSurgicalCharges.Text, decSurgicalCharges) Then
            lblTotalCost.Text = "Please enter numeric value in Surgical Charges field"
            Return False
        End If
        If Not Decimal.TryParse(txtLabFees.Text, decLabFees) Then
            lblTotalCost.Text = "Please enter numeric value in Lab Fees field"
            Return False
        End If
        If Not Decimal.TryParse(txtPhysicalRehab.Text, decPhysicalRehab) Then
            lblTotalCost.Text = "Please enter numeric value in Physical Rehab field"
            Return False
        End If
        If (intLengthOfStay < 0) Then
            lblTotalCost.Text = "Please enter non-negative number in Length of Stay field"
            Return False
        ElseIf (decMedication < 0) Then
            lblTotalCost.Text = "Please enter non-negative number in Medication field"
            Return False
        ElseIf (decSurgicalCharges < 0) Then
            lblTotalCost.Text = "Please enter non-negative number in Surgical Charges field"
            Return False
        ElseIf (decLabFees < 0) Then
            lblTotalCost.Text = "Please enter non-negative number in Lab Fees field"
            Return False
        ElseIf (decPhysicalRehab < 0) Then
            lblTotalCost.Text = "Please enter non-negative number in Physical Rehab field"
            Return False
        End If
        Return True
    End Function

    Function CalcStayCharges() As Decimal

        decCostofStay = intLengthOfStay * decPerDayCharge

        Return decCostofStay
    End Function

    Function CalcMiscCharges() As Decimal

        decMiscCharges = decMedication + decSurgicalCharges + decLabFees + decPhysicalRehab

        Return decMiscCharges
    End Function

    Function CalcTotalCharges(ByVal decMisc As Decimal, ByVal decStay As Decimal) As Decimal
        'Calculate total cost by calling CalcMiscCharges and CalcStayCharges and adding them together. 
        decTotalCost = CalcMiscCharges() + CalcStayCharges()

        Return decTotalCost

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decGrandTotal As Decimal
        'Clear the total cost label
        lblTotalCost.Text = String.Empty
        'Validate user input and calculate grand total by calling CalcTotal Charges Function. 
        If ValidateInputFields() Then
            decGrandTotal = CalcTotalCharges(decCostofStay, decMiscCharges)
            lblTotalCost.Text = "Total Cost: " & decGrandTotal.ToString("c")
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the text boxes
        txtLengthOfStay.Clear()
        txtMedication.Clear()
        txtSurgicalCharges.Clear()
        txtLabFees.Clear()
        txtPhysicalRehab.Clear()
        lblTotalCost.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit
        Me.Close()
    End Sub
End Class
