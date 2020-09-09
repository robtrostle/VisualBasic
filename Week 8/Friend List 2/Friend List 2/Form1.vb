Public Class Form1
    Private lstNames As New List(Of String)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'add the name to the list
        lstNames.Add(txtName.Text)

        'Clear the txt box. 
        txtName.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'display all names in the list box
        Dim strName As String

        lstFriends.Items.Clear()

        For Each strName In lstNames
            lstFriends.Items.Add(strName) 'Add to the list box
        Next

    End Sub
End Class
