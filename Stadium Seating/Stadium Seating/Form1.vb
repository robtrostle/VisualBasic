Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click

        'Declare constant variables for the calculations
        Const decClassACost As Decimal = 15 'Class A seats
        Const decClassBCost As Decimal = 12 'Class B seats
        Const decClassCCost As Decimal = 9 'Class C seats
        'Declare revenue variables for the calculations
        Dim decClassARevenue As Decimal     'Class A revenue
        Dim decClassBRevenue As Decimal     'Class B revenue
        Dim decClassCRevenue As Decimal     'Class C revenue
        Dim decTotalRevenue As Decimal      'Total revenue

        'Calculate and display Revenue
        Try
            decClassARevenue = CDec(txtClassA.Text) * decClassACost
            lblClassA.Text = decClassARevenue.ToString("c")

            decClassBRevenue = CDec(txtClassB.Text) * decClassBCost
            lblClassB.Text = decClassBRevenue.ToString("c")

            decClassCRevenue = CDec(txtClassC.Text) * decClassCCost
            lblClassC.Text = decClassCRevenue.ToString("c")

            decTotalRevenue = decClassARevenue + decClassBRevenue + decClassCRevenue
            lblTotalRevenue.Text = decTotalRevenue.ToString("c")
        Catch ex As InvalidCastException
            'An invalid value as entered
            MessageBox.Show("Error: Input must be numeric.")

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'End Program
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Clear the text boxes
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        'Clear the labels
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
        'Return focus to class A 
        txtClassA.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
