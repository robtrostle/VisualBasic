Imports System.IO


Public Class Form1
    Dim empFile As StreamReader  'object variable
    Dim strFilename As String  'filename
    Dim fileValid As Boolean = False
    Dim recordNumber As Integer = 1 'to hold record number

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Upon load, ask for the file name

        Do
            strFilename = InputBox("Enter the file name.")

            'Open the file. Check if it exists first. 
            If File.Exists(strFilename) Then
                empFile = File.OpenText(strFilename)
                fileValid = True
            Else
                MessageBox.Show(strFilename & " does not exist.") 'If it doesnt exist, throw this message. 
                fileValid = False
            End If
        Loop Until fileValid = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If empFile.EndOfStream = True Then
            MessageBox.Show("End of file")
            empFile.Close()
        Else
            lblRecordNumber.Text = CStr(recordNumber)
            lblFirstName.Text = empFile.ReadLine()
            lblMiddleName.Text = empFile.ReadLine()
            lblLastName.Text = empFile.ReadLine()
            lblEmployeeNumber.Text = empFile.ReadLine()
            lblDepartment.Text = empFile.ReadLine()
            lblTelephone.Text = empFile.ReadLine()
            lblExtension.Text = empFile.ReadLine()
            lblEmail.Text = empFile.ReadLine()
            recordNumber += 1
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblRecordNumber.Text = String.Empty
        lblFirstName.Text = String.Empty
        lblMiddleName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblEmployeeNumber.Text = String.Empty
        lblDepartment.Text = String.Empty
        lblTelephone.Text = String.Empty
        lblExtension.Text = String.Empty
        lblEmail.Text = String.Empty
    End Sub
End Class
