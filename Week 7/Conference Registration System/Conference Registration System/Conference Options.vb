Public Class ConferenceOptionsForm

    'Dim frmMainForm As New MainForm

    Const decEcommerce = 295D
    Const decFutureOfWeb = 295D
    Const decAdvancedVB = 395D
    Const decNetworkSecurity = 395D

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Uncheck the boxes
        chkConferenceRegistration.Checked = False
        chkOpeningNight.Checked = False

        'Reset the list boxes
        lstOptions.SelectedIndex = -1
    End Sub

    Public Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim frmMainForm As New MainForm

        If chkConferenceRegistration.Checked = True Then
            decGrandTotal += decConferenceRegistration 'increment GrandTotal with every new item checked. 
        ElseIf chkConferenceRegistration.Checked = False Then  'Ensure conference registration is checked. 
            MessageBox.Show("Must select conference registration to proceed.")
        End If

        If chkOpeningNight.Checked = True Then
            decGrandTotal += decOpeningNightDinner 'increment GrandTotal with every new item checked. 
        End If

        If lstOptions.SelectedIndex = 0 Then
            decGrandTotal += decEcommerce
        End If

        If lstOptions.SelectedIndex = 1 Then
            decGrandTotal += decFutureOfWeb
        End If

        If lstOptions.SelectedIndex = 2 Then
            decGrandTotal += decAdvancedVB
        End If

        If lstOptions.SelectedIndex = 3 Then
            decGrandTotal += decNetworkSecurity
        End If

        'Display total on mainForm 
        frmMainForm.lblTotal.Text = decGrandTotal.ToString("c")

        'Uncheck the boxes
        chkConferenceRegistration.Checked = False
        chkOpeningNight.Checked = False

        'Reset the list boxes
        lstOptions.SelectedIndex = -1

        'Close This form
        Me.Hide()

        'Show the mainform
        frmMainForm.Show()

        'Reset Grand Total to zero. 
        decGrandTotal = 0

    End Sub


End Class