Imports System.IO

Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        'Constant for the number of friends.
        Const intNUM_FRIENDS As Integer = 3

        'local variables
        Dim friendFile As StreamReader    'Object variable
        Dim StrFilename As String    'File name
        Dim strFriend As String     'Name of a friend
        Dim strPhone As String     'To hold a phone number
        Dim inCount As Integer      'Loop counter

        'Get the file name from the user. 
        StrFilename = InputBox("Enter the filename.")

        Try
            'open the file
            friendFile = File.OpenText(StrFilename)
            'Read the data
            For intCount = 1 To intNUM_FRIENDS
                'Read a name and phone number from the file. 
                strFriend = friendFile.ReadLine()
                strPhone = friendFile.ReadLine()

                'Display the data in the list box. 
                lstFriends.Items.Add("Friend Number " & intCount.ToString())
                lstFriends.Items.Add("Name: " & strFriend)
                lstFriends.Items.Add("Phone: " & strPhone)
                lstFriends.Items.Add("") 'Add a blank line

            Next intCount
            'Close the file
            friendFile.Close()
        Catch
            MessageBox.Show("That file cannot be opened.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstFriends.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
