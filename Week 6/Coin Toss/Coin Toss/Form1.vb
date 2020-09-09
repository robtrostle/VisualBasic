Public Class Form1
    Private Sub btnToss_Click(sender As Object, e As EventArgs) Handles btnToss.Click
        Dim intSideUp As Integer 'To indicate which side is up
        Dim rand As New Random

        intSideUp = rand.Next(2)

        If intSideUp = 0 Then
            picTails.Visible = True
            picHeads.Visible = False
        Else
            picHeads.Visible = True
            picTails.Visible = False

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
