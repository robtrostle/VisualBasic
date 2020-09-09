Imports System.IO

Public Class Form1
    'Class level variables
    Dim strFilename As String  'file name
    Dim empFile As StreamWriter 'object variable
    Dim intCount As Integer  'loop counter 

    'Structure to hold employee information
    Structure EmpInfo
        Dim strFirst As String   ' To hold a first name
        Dim strLast As String  'To hold last name
        Dim strMiddle As String 'To hold middle name
        Dim strEmpNumber As String 'To hold employee number
        Dim strDepartment As String 'To hold department
        Dim strPhone As String 'To hold phone number
        Dim strExtension As String 'To hold extension
        Dim strEmail As String 'To hold email address
    End Structure
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strFilename = InputBox("Enter the filename.")
        'If the file exists, append new data to it. 
        Try
            empFile = File.AppendText(strFilename)
        Catch
            ' Error message
            MessageBox.Show("That file cannot be created.")
        End Try

    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        Dim myEmployee As EmpInfo 'Structure variable
        'write data to the file 
        myEmployee.strFirst = txtFirstName.Text
        empFile.WriteLine(myEmployee.strFirst)

        myEmployee.strMiddle = txtMiddleName.Text
        empFile.WriteLine(myEmployee.strMiddle)

        myEmployee.strLast = txtLastName.Text
        empFile.WriteLine(myEmployee.strLast)

        myEmployee.strEmpNumber = txtEmployeeNumber.Text
        empFile.WriteLine(myEmployee.strEmpNumber)

        myEmployee.strDepartment = cboDepartment.Text
        empFile.WriteLine(myEmployee.strDepartment)

        myEmployee.strPhone = txtTelephone.Text
        empFile.WriteLine(myEmployee.strPhone)

        myEmployee.strExtension = txtExtension.Text
        empFile.WriteLine(myEmployee.strExtension)

        myEmployee.strEmail = txtEmail.Text
        empFile.WriteLine(myEmployee.strEmail)

        'Confirm creation of file. 
        MessageBox.Show("Employee Data has been added to the file.")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the file.
        empFile.Close()
        'Close the program
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear the form
        cboDepartment.SelectedIndex = -1
        cboDepartment.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtMiddleName.Text = String.Empty
        txtEmployeeNumber.Text = String.Empty
        txtTelephone.Text = String.Empty
        txtExtension.Text = String.Empty
        txtEmail.Text = String.Empty
    End Sub
End Class
