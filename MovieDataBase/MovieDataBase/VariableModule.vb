Imports System.IO

Module VariableModule
    'Structure to hold movie data
    Structure MovieInfo
        Dim strMovieName As String
        Dim strYearProduced As String
        Dim strRunningTime As String
        Dim strRating As String
    End Structure

    'File variables
    Dim strFilename As String
    Dim movieFile As StreamWriter

End Module
