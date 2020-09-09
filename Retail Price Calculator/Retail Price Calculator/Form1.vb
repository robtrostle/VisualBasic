Public Class Form1
    Private dblCost As Double      ' To hold the wholesale cost 
    Private dblMarkup As Double    ' To hold markup percentage

    Private Function CalculateRetail(ByVal decCost As Double, ByVal dblMarkup As Double) As Double
        ' Calculate and return the retail price
        Dim dblPrice As Double
        dblPrice = dblCost + (dblCost * (dblMarkup * 0.01))
        Return dblPrice
    End Function

    Private Sub btnGetRetail_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Dim dblPrice As Double
        If Double.TryParse(txtCost.Text, dblCost) Then
            If Double.TryParse(txtMarkup.Text, dblMarkup) Then
                If dblCost >= 0 Then
                    If dblMarkup >= 0 Then
                        dblPrice = CalculateRetail(dblCost, dblMarkup)
                        lblPrice.Text = dblPrice.ToString("c")
                    Else
                        MessageBox.Show("Enter a positive value for markup percentage.")
                    End If
                Else
                    MessageBox.Show("Enter a positive value for wholesale cost of item.")
                End If
            Else
                MessageBox.Show("Enter a numeric value for markup percentage.")
            End If
        Else
            MessageBox.Show("Enter a numeric value for wholesale cost of item.")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
