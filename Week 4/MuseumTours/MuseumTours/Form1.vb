Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the program
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare language Variables.
        Const decArabic As Decimal = 5D
        Const decChinese As Decimal = 5D
        Const decEnglish As Decimal = 3D
        Const decFrench As Decimal = 4D
        Const decGerman As Decimal = 6D


        'Declare Feature Sections Cost Variables.
        Const decAncientChina As Decimal = 2D
        Const decAncientEurope As Decimal = 2D
        Const decAncientEgypt As Decimal = 4D
        Const decMesopotamia As Decimal = 3D
        Const decMedievalEurope As Decimal = 2D
        Dim decSectionTotal As Decimal 'Total fees for languages and sections. 
        Dim display As String 'Create a string variable to store featured sections & display them. 


        'Determine Cost of Featured Sections
        If chkAncientChina.Checked = True Then
            decSectionTotal += decAncientChina
            display += chkAncientChina.Text & ", "
        End If
        If chkAncientEurope.Checked = True Then
            decSectionTotal += decAncientEurope
            display += chkAncientEurope.Text & ", "
        End If
        If chkAncientEgypt.Checked = True Then
            decSectionTotal += decAncientEgypt
            display += chkAncientEgypt.Text & ", "
        End If
        If chkMesopotamia.Checked = True Then
            decSectionTotal += decMesopotamia
            display += chkMesopotamia.Text & ", "
        End If
        If chkMedievalEurope.Checked = True Then
            decSectionTotal += decMedievalEurope
            display += chkMedievalEurope.Text & ", "
        End If

        'Determine language selection and display output
        If radArabic.Checked = True Then
            decSectionTotal += decArabic
            MessageBox.Show("You have selected the following museum sections to be guided in the " & radArabic.Text & " language:" & ControlChars.CrLf &
                            ControlChars.CrLf & display & ControlChars.CrLf & ControlChars.CrLf &
                            "The total tour cost is " & decSectionTotal.ToString("c"))
        ElseIf radChinese.Checked = True Then
            decSectionTotal += decChinese
            MessageBox.Show("You have selected the following museum sections to be guided in the " & radChinese.Text & " language:" & ControlChars.CrLf &
                            ControlChars.CrLf & display & ControlChars.CrLf & ControlChars.CrLf &
                            "The total tour cost is " & decSectionTotal.ToString("c"))
        ElseIf radEnglish.Checked = True Then
            decSectionTotal += decEnglish
            MessageBox.Show("You have selected the following museum sections to be guided in the " & radEnglish.Text & " language:" & ControlChars.CrLf &
                            ControlChars.CrLf & display & ControlChars.CrLf & ControlChars.CrLf &
                            "The total tour cost is " & decSectionTotal.ToString("c"))
        ElseIf radFrench.Checked = True Then
            decSectionTotal += decFrench
            MessageBox.Show("You have selected the following museum sections to be guided in the " & radFrench.Text & " language:" & ControlChars.CrLf &
                            ControlChars.CrLf & display & ControlChars.CrLf & ControlChars.CrLf &
                            "The total tour cost is " & decSectionTotal.ToString("c"))
        ElseIf radGerman.Checked = True Then
            decSectionTotal += decGerman
            MessageBox.Show("You have selected the following museum sections to be guided in the " & radGerman.Text & " language:" & ControlChars.CrLf &
                            ControlChars.CrLf & display & ControlChars.CrLf & ControlChars.CrLf &
                            "The total tour cost is " & decSectionTotal.ToString("c"))
        End If


    End Sub
End Class
