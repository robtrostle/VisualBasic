Public Class Trucks
    Private Sub Trucks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear Decks List
        ClearTrucks()

        'Adds items to the decks list
        lstTrucks.Items.Add(strSevenPointSevenFiveAxle)
        lstTrucks.Items.Add(strEightAxle)
        lstTrucks.Items.Add(strEightPointFive)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If an item is selected....
        If lstTrucks.SelectedIndex <> -1 Then
            'Call the AddTrucks Function which will add the selected item to the Trucks lable on the mainForm

            AddTrucks()

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CalculateTax()
        CalculateTotal()

        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()
    End Sub
End Class