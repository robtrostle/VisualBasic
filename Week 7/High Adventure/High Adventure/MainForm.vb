Public Class MainForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close the form
        Me.Close()
    End Sub

    Private Sub mnuPackagesScuba_Click(sender As Object, e As EventArgs) Handles mnuPackagesScuba.Click
        'Create an instance of the scuba form
        Dim frmScuba As New ScubaForm
        'Display the ScubaForm in modal style
        frmScuba.ShowDialog()
    End Sub

    Private Sub mnuPackagesSkyDiving_Click(sender As Object, e As EventArgs) Handles mnuPackagesSkyDiving.Click
        'Creat an instance of the skydiving form
        Dim frmSkyDive As New SkyDiveForm

        'Display 
        frmSkyDive.ShowDialog()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'Display a message
        MessageBox.Show("High Adventure Travel Price Quote System Version 1.0")
    End Sub
End Class
