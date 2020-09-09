Public Class Form1
    'integer arrays to hold digits. 
    Dim intMinimum() As Integer = {7, 5, 0, 0, 6, 3, 4}
    Dim intMaximum() As Integer = {9, 7, 4, 9, 9, 6, 8}
    'Variables to hold user's input
    Dim intOne As Integer
    Dim intTwo As Integer
    Dim intThree As Integer
    Dim intFour As Integer
    Dim intFive As Integer
    Dim intSix As Integer
    Dim intSeven As Integer

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        'Call Validate Input fields function. If True, the account is unlocked. Else, tell user to try again. 
        If ValidateInputFields() Then
            MessageBox.Show("You entered a valid PIN. Account unlocked!")
        Else MessageBox.Show("Invalid PIN! Try Again.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear text boxes and reset inputok to false
        txtOne.Clear()
        txtTwo.Clear()
        txtThree.Clear()
        txtFour.Clear()
        txtFive.Clear()
        txtSix.Clear()
        txtSeven.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub

    Function ValidateInputFields() As Boolean

        'Verify each digit the user enters against the intMin and intMax arrays. Return True if it passes each test. 
        intOne = CInt(txtOne.Text)
        If Not intOne >= intMinimum(0) And intOne <= intMaximum(0) Then
            Return False
        End If
        intTwo = CInt(txtTwo.Text)
        If Not intTwo >= intMinimum(1) And intTwo <= intMaximum(1) Then
            Return False
        End If
        intThree = CInt(txtThree.Text)
        If Not intThree >= intMinimum(2) And intThree <= intMaximum(2) Then
            Return False
        End If
        intFour = CInt(txtFour.Text)
        If Not intFour >= intMinimum(3) And intFour <= intMaximum(3) Then
            Return False
        End If
        intFive = CInt(txtFive.Text)
        If Not intFive >= intMinimum(4) And intFive <= intMaximum(4) Then
            Return False
        End If
        intSix = CInt(txtSix.Text)
        If Not intSix >= intMinimum(5) And intSix <= intMaximum(5) Then
            Return False
        End If
        intSeven = CInt(txtSeven.Text)
        If Not intSeven >= intMinimum(6) And intSeven <= intMaximum(6) Then
            Return False
        End If
        Return True
    End Function
End Class
