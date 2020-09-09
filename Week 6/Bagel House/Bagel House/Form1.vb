Public Class Form1
    'Class level declarations
    Const decTAX_RATE As Decimal = 0.06D
    Const decWHITE_BAGEL As Decimal = 1.25D
    Const decWHEAT_BAGEL As Decimal = 1.5D
    Const decCREAM_CHEESE As Decimal = 0.5D
    Const decBUTTER As Decimal = 0.25D
    Const decBLUEBERRY As Decimal = 0.75D
    Const decRASBERRY As Decimal = 0.75D
    Const decPEACH As Decimal = 2D
    Const decREG_COFFEE As Decimal = 1.25D
    Const decCAPPUCCINO As Decimal = 2D
    Const decCAFE_AU_LAIT As Decimal = 1.75D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This procedure calculates the total of an order. 
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        decSubtotal = CalcBagelCost() + CalcToppingCost() + CalcCoffeeCost()
        decTax = CalcTax(decSubtotal)
        decTotal = decSubtotal + decTax

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This procedure resets the cotrol to default values
        ResetBagels()
        ResetToppings()
        ResetCoffee()
        ResetPrice()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Function CalcBagelCost() As Decimal
        'This function returns the cost of the selected bagel. 
        Dim decBagel As Decimal

        If radWhite.Checked = True Then
            decBagel = decWHITE_BAGEL
        Else
            decBagel = decWHEAT_BAGEL
        End If
        Return decBagel
    End Function

    Function CalcToppingCost() As Decimal
        'This function returns the cost of the toppings.
        Dim decCostOfTopping As Decimal = 0D

        If chkCreamCheese.Checked = True Then
            decCostOfTopping += decCREAM_CHEESE
        End If

        If chkButter.Checked = True Then
            decCostOfTopping += decBUTTER
        End If

        If chkBlueberry.Checked = True Then
            decCostOfTopping += decBLUEBERRY
        End If

        If chkRasberry.Checked = True Then
            decCostOfTopping += decRASBERRY
        End If

        If chkPeach.Checked = True Then
            decCostOfTopping += decPEACH
        End If

        Return decCostOfTopping
    End Function

    Function CalcCoffeeCost() As Decimal
        'This function returns the cost of the selected coffee. 
        Dim decCoffee As Decimal

        If radNoCoffee.Checked = True Then
            decCoffee = 0D
        ElseIf radRegCoffee.Checked = True Then
            decCoffee += decREG_COFFEE
        ElseIf radCappuccino.Checked = True Then
            decCoffee += decCAPPUCCINO
        ElseIf radCafeAuLait.Checked = True Then
            decCoffee += decCAFE_AU_LAIT
        End If

        Return decCoffee
    End Function

    Function CalcTax(ByVal decAmount As Decimal) As Decimal
        Return decAmount * decTAX_RATE
    End Function

    Sub ResetBagels()
        radWhite.Checked = True
    End Sub

    Sub ResetToppings()
        'This procedure resets the topping selection. 
        chkCreamCheese.Checked = False
        chkButter.Checked = False
        chkBlueberry.Checked = False
        chkRasberry.Checked = False
        chkPeach.Checked = False
    End Sub

    Sub ResetCoffee()
        radRegCoffee.Checked = True
    End Sub

    Sub ResetPrice()
        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
