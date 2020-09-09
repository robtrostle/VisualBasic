Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pic8OfDiamonds.Click
        'Click event for 8 of diamonds
        lblAnswer.Text = "8 of Diamonds"
    End Sub

    Private Sub pic2OfSpades_Click(sender As Object, e As EventArgs) Handles pic2OfSpades.Click
        'Click event for 2 of Spades
        lblAnswer.Text = "2 of Spades"
    End Sub

    Private Sub picKingOfSpades_Click(sender As Object, e As EventArgs) Handles picKingOfSpades.Click
        'Click event for king of Spades
        lblAnswer.Text = "King of Spades"
    End Sub

    Private Sub picAceOfSpades_Click(sender As Object, e As EventArgs) Handles picAceOfSpades.Click
        'Click event for Ace of Spades
        lblAnswer.Text = "Ace of Spades"
    End Sub

    Private Sub picJoker_Click(sender As Object, e As EventArgs) Handles picJoker.Click
        'Click event for Joker
        lblAnswer.Text = "Black Joker"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Click even for exit button
        Me.Close()
    End Sub
End Class
