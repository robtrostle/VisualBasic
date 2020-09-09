Public Class Form1
    'Class level constants for the coin values
    Dim decFive_CENTS_VALUE As Decimal = 0.05D
    Dim decTEN_CENTS_VALUE As Decimal = 0.1D
    Dim decTWENTY_FIVE_CENTS_VALUE As Decimal = 0.25D
    Dim decFIFTY_CENTS_VALUE As Decimal = 0.5D

    'Class-level constants for the total
    'initialized with 0. 
    Dim decTotal As Decimal = 0.0D

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'Add the value of 5 cents to the total
        decTotal = decTotal + decTWENTY_FIVE_CENTS_VALUE

        'Display the total, formatted as currency
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        'Add the value of 10 cents to the total. 
        decTotal = decTotal + decTEN_CENTS_VALUE

        'Dislplay the total as currency
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        'Add the value of 25 cents to the total. 
        decTotal = decTotal + decTWENTY_FIVE_CENTS_VALUE

        'Dislplay the total as currency
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        'Add the value of 50 cents to the total. 
        decTotal = decTotal + decFIFTY_CENTS_VALUE

        'Dislplay the total as currency
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'End progrom
        Me.Close()
    End Sub
End Class
