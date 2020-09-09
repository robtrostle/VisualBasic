Public Class Form1
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub mnuColorRed_Click(sender As Object, e As EventArgs) Handles mnuColorRed.Click
        'Set the lable's foreground color to red. 
        lblMessage.ForeColor = Color.Red
    End Sub

    Private Sub mnuColorGreen_Click(sender As Object, e As EventArgs) Handles mnuColorGreen.Click
        lblMessage.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(sender As Object, e As EventArgs) Handles mnuColorBlue.Click
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(sender As Object, e As EventArgs) Handles mnuColorBlack.Click
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisible_Click(sender As Object, e As EventArgs) Handles mnuColorVisible.Click
        If mnuColorVisible.Checked = True Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("A Simple Menu System Demo")
    End Sub
End Class
