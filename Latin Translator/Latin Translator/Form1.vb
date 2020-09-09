Public Class Form1
    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblAnswer.Text = "Left"
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblAnswer.Text = "Middle"
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblAnswer.Text = "Right"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
