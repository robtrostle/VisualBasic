Public Class Form1
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Const intMAX_SUBSCRIPT As Integer = 4 'Maximum subscript
        Dim intLottery(intMAX_SUBSCRIPT) As Integer 'Lottery array
        Dim intCount As Integer 'Loop Counter

        'Create a random object 
        Dim rand As New Random

        'Fill the array with random numbers
        'Each number will be in the range 0 - 99
        For intCount = 0 To intMAX_SUBSCRIPT
            intLottery(intCount) = rand.Next(100)
        Next

        'Display the array elements in the labels. 
        lblFirst.Text = intLottery(0).ToString()
        lblSecond.Text = intLottery(1).ToString()
        lblThird.Text = intLottery(2).ToString()
        lblFourth.Text = intLottery(3).ToString()
        lblFifth.Text = intLottery(4).ToString()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()
    End Sub
End Class
