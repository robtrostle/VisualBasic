﻿Public Class Form1
    Private Sub btnFifteen_Click(sender As Object, e As EventArgs) Handles btnFifteen.Click
        ' Variable declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        'Get the amount of the bill.
        dblBill = CDbl(txtBillAmount.Text)

        'Calculate the tip
        dblTip = dblBill * 0.15

        'Display the Tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwenty_Click(sender As Object, e As EventArgs) Handles btnTwenty.Click
        ' Variable declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        'Get the amount of the bill.
        dblBill = CDbl(txtBillAmount.Text)

        'Calculate the tip
        dblTip = dblBill * 0.2

        'Display the Tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnTwentyFive_Click(sender As Object, e As EventArgs) Handles btnTwentyFive.Click
        ' Variable declarations
        Dim dblBill As Double = 0.0
        Dim dblTip As Double = 0.0

        'Get the amount of the bill.
        dblBill = CDbl(txtBillAmount.Text)

        'Calculate the tip
        dblTip = dblBill * 0.25

        'Display the Tip
        lblTip.Text = CStr(dblTip)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'End program
        Me.Close()
    End Sub
End Class
