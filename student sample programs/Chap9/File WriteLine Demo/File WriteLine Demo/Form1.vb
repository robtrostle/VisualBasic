Imports System.IO

Public Class Form1
    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        'Constant for the number of friends
        Const intNUM_FRIENDS As Integer = 3

        'local variables
        Dim strFilename As String       'File name
        Dim strFriend As String    'Name of friend
        Dim strPhone As String    'To hold phone number
        Dim intCount As Integer   'Loop Counter
        Dim friendFile As StreamWriter    'Object variable

        'Ge tthe file name from the user. 
        strFilename = InputBox("Enter the filename.")

        Try
            'open the file
            friendFile = File.CreateText(strFilename)

            'Get the data and write it to the file. 
            For intCount = 1 To intNUM_FRIENDS
                'Get the friends name
                strFriend = InputBox("Enter the name of friend " & "number " & intCount.ToString())

                'Get a friends phone number 
                strPhone = InputBox("Enter that friend's " & "phone number.")

                'Write the data to the file
                friendFile.WriteLine(strFriend)
                friendFile.WriteLine(strPhone)
            Next
            'Close the file
            friendFile.Close()
        Catch
            'Error message
            MessageBox.Show("That file cannot be created.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
