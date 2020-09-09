Public Class Form1
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim intCount As Integer 'loop counter
        'move the image across the sreen
        For intCount = 1 To 475
            picSpaceShip.Left = intCount
        Next
    End Sub
End Class
