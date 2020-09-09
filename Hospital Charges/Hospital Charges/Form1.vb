Public Class Form1
    Const decChargePerDay As Decimal = 350 ' Hospital charges per day
    Dim intDays As Integer          ' Number of days spent in the hospital
    Dim decMedication As Decimal    ' Amount of medication charges
    Dim decSurgical As Decimal      ' Amount of surgical charges
    Dim decLab As Decimal           ' Amount of lab charges
    Dim decRehab As Decimal         ' Amount of physical rehabilitation charges

    Private Function ValidateInputFields() As Boolean
        'Try to convert each of the input fields. Return False if and field 
        'is invalid, and display a suitable error message
        If Not Integer.TryParse(txtDays.Text, intDays) Then
            lblTotal.Text = "Number of days must be an integer"
            Return False
        End If
        If Not Decimal.TryParse(txtMedication.Text, decMedication) Then
            lblTotal.Text = "Amount of medication charges must be numeric"
            Return False
        End If
        If Not Decimal.TryParse(txtSurgical.Text, decSurgical) Then
            lblTotal.Text = "Amount of surgical charges must be numeric"
            Return False
        End If
        If Not Decimal.TryParse(txtLab.Text, decLab) Then
            lblTotal.Text = "Amount of lab charges must be numeric"
            Return False
        End If
        If Not Decimal.TryParse(txtRehab.Text, decRehab) Then
            lblTotal.Text = "Amount of physical rehabilitation charges must be numeric"
            Return False
        End If

        If (intDays < 0) Then
            lblTotal.Text = "Number of days must be non-negative number"
            Return False
        End If
        If (decMedication < 0) Then
            lblTotal.Text = "Amount of medication charges must be non-negative number"
            Return False
        End If
        If (decSurgical < 0) Then
            lblTotal.Text = "Amount of surgical charges must be non-negative number"
            Return False
        End If
        If (decLab < 0) Then
            lblTotal.Text = "Amount of lab charges must be non-negative number"
            Return False
        End If
        If (decRehab < 0) Then
            lblTotal.Text = "Amount of physical rehabilitation charges must be non-negative number"
            Return False
        End If
        Return True
    End Function

    Function CalcStayCharges(ByVal decChargePerDay As Decimal, ByVal intDays As Integer) As Decimal
        ' Calculate and return the base charges for the hospital stay
        Dim decStayCharge As Decimal
        decStayCharge = decChargePerDay * intDays
        Return decStayCharge
    End Function

    Function CalcMiscCharges(ByVal decMedication As Decimal, ByVal decSurgical As Decimal,
                             ByVal decLab As Decimal, ByVal decRehab As Decimal) As Decimal
        ' Calculate and return the total for medication, surgical, lab, and rehab charges
        Dim decMiscCharge As Decimal
        decMiscCharge = decMedication + decSurgical + decLab + decRehab
        Return decMiscCharge
    End Function

    Function CalcTotalCharges(ByVal decStayCharge As Decimal, ByVal decMiscCharge As Decimal) As Decimal
        ' Calculate abd return the total charges
        Dim decTotalCharge As Decimal
        decTotalCharge = decStayCharge + decMiscCharge
        Return decTotalCharge
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalCharge As Decimal
        Dim decStayCharge As Decimal
        Dim decMiscCharge As Decimal

        ' If the input is valid, display the total charges
        If ValidateInputFields() Then
            decStayCharge = CalcStayCharges(decChargePerDay, intDays)
            decMiscCharge = CalcMiscCharges(decMedication, decSurgical, decLab, decRehab)
            decTotalCharge = CalcTotalCharges(decStayCharge, decMiscCharge)
            lblTotal.Text = "Total Cost: " & decTotalCharge.ToString("c")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the text boxes and lblTotal
        txtDays.Clear()
        txtMedication.Clear()
        txtSurgical.Clear()
        txtLab.Clear()
        txtRehab.Clear()
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class

