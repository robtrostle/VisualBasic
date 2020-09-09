Public Class Miscellaneous
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If chkGripTape.Checked = True Then
            frmMainForm.lstMisc.Items.Add(strGripTape)
            g_decSubTotal += decGripTape
            g_decTaxTotal += decGripTape * g_decTaxRate
        End If
        If chkBearings.Checked = True Then
            frmMainForm.lstMisc.Items.Add(strBearings)
            g_decSubTotal += decBearings
            g_decTaxTotal += decBearings * g_decTaxRate
        End If
        If chkRiserPads.Checked = True Then
            frmMainForm.lstMisc.Items.Add(strRiserPads)
            g_decSubTotal += decRiserPads
            g_decTaxTotal += decRiserPads * g_decTaxRate
        End If
        If chkNutsAndBolts.Checked = True Then
            frmMainForm.lstMisc.Items.Add(strNutsAndBolts)
            g_decSubTotal += decNutsAndBolts
            g_decTaxTotal += decNutsAndBolts * g_decTaxRate
        End If
        If chkAssembly.Checked = True Then
            frmMainForm.lstMisc.Items.Add(strAssembly)
            g_decSubTotal += decAssembly  'Do not include taxes for assembly.
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        frmMainForm.lblTax.Text = g_decTaxTotal.ToString("c")

        CalculateTotal()

        'Close this form and show mainform
        strSelectedString = ""
        Me.Hide()
        frmMainForm.Show()
    End Sub

    Private Sub Miscellaneous_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Uncheck the boxes upon opening and re-opening. 
        chkGripTape.Checked = False
        chkBearings.Checked = False
        chkNutsAndBolts.Checked = False
        chkRiserPads.Checked = False
        chkAssembly.Checked = False

    End Sub
End Class