Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MembersDataSet.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.MembersDataSet.Members)

    End Sub

    Private Sub PhoneLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Date_JoinedDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Date_JoinedDateTimePicker.ValueChanged

    End Sub
End Class
