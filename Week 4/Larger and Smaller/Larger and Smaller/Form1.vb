Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Exit the progrom
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare Variables
        Dim intA As Integer
        Dim intB As Integer
        Dim blnInputOk As Boolean = True

        'Validate the user input
        If Integer.TryParse(txtA.Text, intA) = False Then
            lblResult.Text = "Input must be integers"
            blnInputOk = False
        ElseIf Integer.TryParse(txtB.Text, intB) = False Then
            lblResult.Text = "Input must be integers"
            blnInputOk = False
        End If

        If blnInputOk = True Then

            Try
                'Get and convert user input
                intA = CInt(txtA.Text)
                intB = CInt(txtB.Text)

                'Compare the two inputs
                If intA > intB Then
                    lblResult.Text = "Value A is Greatest"
                ElseIf intA < intB Then
                    lblResult.Text = "Value B is Greatest"
                ElseIf intA = intB Then
                    lblResult.Text = "A is equal to B"

                End If
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class
