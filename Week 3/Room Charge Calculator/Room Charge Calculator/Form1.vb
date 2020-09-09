﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get today's date from the system and display it
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the system and display it. 
        lblTimeToday.Text = Now.ToString("T")

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNightlyCharge.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables for the calculation
        Dim decRoomCharges As Decimal 'Room charges total
        Dim decAddCharges As Decimal 'Additional charges
        Dim decSubtotal As Decimal 'Subtotal
        Dim decTax As Decimal 'Tax
        Dim decTotal As Decimal 'Total of all charges
        Const decTax_Rate As Decimal = 0.08D 'Tax Rate
        Try
            'Calculate and display the room charges
            decRoomCharges = CDec(txtNights.Text) * CDec(txtNightlyCharge.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            'Calculate and display the additional charges
            decAddCharges = CDec(txtRoomService.Text) + CDec(txtTelephone.Text) + CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            'Calculate and display the sub total
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            'Calculate and display the tax
            decTax = decSubtotal * decTax_Rate
            lblTax.Text = decTax.ToString("c")

            'Calculate and display the total
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

            'Change the colors for the total charges
            lblTotal.BackColor = Color.Blue
            lblTotal.ForeColor = Color.White


        Catch
            'error message
            MessageBox.Show("A11 input must be valid numeric values.")

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the room info fields
        txtNights.Clear()
        txtNightlyCharge.Clear()

        'Clear the additional charges fields 
        txtRoomService.Clear()
        txtTelephone.Clear()
        txtMisc.Clear()

        'Clear the decTotal fields
        lblRoomCharges.Text = String.Empty
        lblAddCharges.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty

        'Get today's date from the operating system and display it. 
        lblDateToday.Text = Now.ToString("D")

        'Get the current time from the operating system and display it. 
        lblTimeToday.Text = Now.ToString("T")

        'Reset the lblTotal control's property
        lblTotal.BackColor = SystemColors.Control
        lblTotal.ForeColor = SystemColors.ControlText


        'Reset the focus to the first field
        txtNights.Focus()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
