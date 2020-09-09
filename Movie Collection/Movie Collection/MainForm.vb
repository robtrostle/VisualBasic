Imports System.IO

Public Class MainForm
    'Structure to hold movie data
    Structure MovieInfo
        Dim strMovieName As String
        Dim strYearProduced As String
        Dim strRunningTime As String
        Dim strRating As String
    End Structure

    Dim myMovie As MovieInfo 'Structure Variable

    'File variables
    Dim strFilename As String
    Dim movieFile As StreamWriter
    Dim movieFileIn As StreamReader

    Public Sub mnuFileSaveRecord_Click(sender As Object, e As EventArgs) Handles mnuFileSaveRecord.Click
        ' Dim myMovie As MovieInfo 'Structure Variable
        'write data to the file
        myMovie.strMovieName = txtMovieName.Text
        movieFile.WriteLine(myMovie.strMovieName)

        myMovie.strYearProduced = txtYearProduced.Text
        movieFile.WriteLine(myMovie.strYearProduced)

        myMovie.strRunningTime = txtRunningTime.Text
        movieFile.WriteLine(myMovie.strRunningTime)

        myMovie.strRating = txtRating.Text
        movieFile.WriteLine(myMovie.strRating)

        'Confirm creation of New record
        MessageBox.Show("New movie added to the file.")
        'Clear the labels for another movie
        txtMovieName.Text = String.Empty
        txtYearProduced.Text = String.Empty
        txtRating.Text = String.Empty
        txtRunningTime.Text = String.Empty


    End Sub

    Public Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strFilename = InputBox("Enter the filename of your movie data file.")
        Try
            movieFile = File.AppendText(strFilename)
        Catch ex As Exception
            MessageBox.Show("That file cannot be created.")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close the file
        movieFile.Close()
        'Close the program.
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'About the program
        MessageBox.Show("Movie Collection Creator 1.0 - A convenient place to store your movie collection.")
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        movieFile.Close()
        'Print the content of the file
        Dim intX As Integer = 10
        Dim intY As Integer = 10
        Try
            'open the file
            movieFileIn = File.OpenText("C:\Users\robtr\source\repos\Movie Collection\MyFlicks.txt")
            'Read all the lines in the file
            Do While Not movieFileIn.EndOfStream
                'print a line from the file
                e.Graphics.DrawString(movieFileIn.ReadLine(), New Font("Courier", 10, FontStyle.Regular), Brushes.Black, intX, intY)
                intY += 12
            Loop
            'Close the file
            movieFileIn.Close()
        Catch
            MessageBox.Show("Error: Could not open file.")
        End Try
    End Sub

    Private Sub PrintReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintReportToolStripMenuItem.Click
        'Open the print Dialog
        If pddPrintDialog.ShowDialog() = DialogResult.OK Then
            'Get the printer settings. 
            pdPrint.PrinterSettings = pddPrintDialog.PrinterSettings
            'Print the document. 
            pdPrint.Print()
        End If
    End Sub

    Public Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click

        'Close the file
        movieFile.Close()

        Dim sFileContents As String = String.Empty
        Dim searchMovie As String  'To hold user's searched movie

        'Open the file and read the entire contents of it
        If System.IO.File.Exists("C:\Users\robtr\source\repos\Movie Collection\MyFlicks.txt") Then
            movieFileIn = File.OpenText("C:\Users\robtr\source\repos\Movie Collection\MyFlicks.txt")
            sFileContents = System.IO.File.ReadAllText("C:\Users\robtr\source\repos\Movie Collection\MyFlicks.txt")
        Else
            MessageBox.Show("That files doesn't exist.")
        End If
        'Ask the user the name of the movie
        searchMovie = InputBox("Enter the name of the movie.")
        If sFileContents.Contains(searchMovie) Then 'If the file contains the searched movie
            MessageBox.Show("Movie details will now be listed.")
            'Loop through the file until the end
            Do Until movieFileIn.EndOfStream
                If movieFileIn.ReadLine = searchMovie Then
                    txtMovieName.Text = searchMovie
                    txtYearProduced.Text = movieFileIn.ReadLine()
                    txtRunningTime.Text = movieFileIn.ReadLine()
                    txtRating.Text = movieFileIn.ReadLine()
                End If
            Loop

        Else
            MessageBox.Show("That movie does not exist.")
            movieFileIn.Close()
        End If

    End Sub
End Class
