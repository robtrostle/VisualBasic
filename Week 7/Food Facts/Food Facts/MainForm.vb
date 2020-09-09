Public Class MainForm
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Create an instance of the Nutrition Form 
        Dim frmNutrition As New NutritionForm

        'Find the selected radio button
        If radBanana.Checked = True Then
            frmNutrition.lblFood.Text = "1 banana"
            frmNutrition.lblCalories.Text = "100"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "27"
        ElseIf radPopcorn.Checked = True Then
            frmNutrition.lblFood.Text = "1 cup air-popped popcorn"
            frmNutrition.lblCalories.Text = "31"
            frmNutrition.lblFat.Text = "0.4"
            frmNutrition.lblCarb.Text = "6"
        ElseIf radMuffin.Checked = True Then
            frmNutrition.lblFood.Text = "1 large blueberry muffin"
            frmNutrition.lblCalories.Text = "385"
            frmNutrition.lblFat.Text = "9"
            frmNutrition.lblCarb.Text = "67"
        End If
        'Display the NutritionForm
        frmNutrition.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
