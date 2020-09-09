Public Class Wheels
    Private Sub Wheels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear Decks List
        ClearWheels()

        'Adds items to the wheels list
        lstWheels.Items.Add(strFiftyOneMM)
        lstWheels.Items.Add(strFiftyFiveMM)
        lstWheels.Items.Add(strFiftyEightMM)
        lstWheels.Items.Add(strSixtyOneMM)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'If an item is selected....
        If lstWheels.SelectedIndex <> -1 Then
            'Call the AddWheels Function which will add the selected item to the wheels lable on the mainForm
            AddWheels()
        End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Calculate the total 
        If lstWheels.SelectedIndex = 0 Then
            CalculateTotal()
        ElseIf lstWheels.SelectedIndex = 1 Then
            CalculateTotal()
        End If


        'CalculateTax()


        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()

    End Sub
End Class