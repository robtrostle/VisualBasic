Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Determine which radio button is selected. 
        If radCoffee.Checked = True Then
            lblResult.Text = "You selected Coffee"
        ElseIf radTea.Checked = True Then
            lblResult.Text = "You selected Tea"
        ElseIf radSoftDrink.Checked = True Then
            lblResult.Text = "You selected Soft Drink"

        End If
        'Determine which check boxes are selected. 
        If chkWhipped.Checked = True Then
            lblResult.Text &= ", and Whipped Cream"
        ElseIf chkMoca.Checked = True Then
            lblResult.Text &= ", and Mocha"
        ElseIf chkAmaretto.Checked = True Then
            lblResult.Text &= ", and Amaretto"
        End If
    End Sub
End Class
