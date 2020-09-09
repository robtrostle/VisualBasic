Module CalcModule
    'Constant Deck Price Variables
    Public Const decMasterThrasher As Decimal = 60D
    Public Const decDictatorOfGrind As Decimal = 45D
    Public Const decStreetKing As Decimal = 50D

    'Constant Truck Assembly Price Variables
    Public Const decSevenPointSevenFiveAxle As Decimal = 35D
    Public Const decEightAxle As Decimal = 40D
    Public Const decEightPointFive As Decimal = 45D

    'Constant Wheel Set Prices
    Public Const decFiftyOneMM As Decimal = 20D
    Public Const decFiftyFiveMM As Decimal = 22D
    Public Const decFiftyEightMM As Decimal = 24D
    Public Const decSixtyOneMM As Decimal = 28D

    'Constant Miscellaneous Product Prices
    Public Const decGripTape As Decimal = 10D
    Public Const decBearings As Decimal = 30D
    Public Const decRiserPads As Decimal = 2D
    Public Const decNutsAndBolts As Decimal = 3D
    Public Const decAssembly As Decimal = 10D

    'Global Financial Variables
    Public Const g_decTaxRate As Decimal = 0.06D
    Public g_decSubTotal As Decimal
    Public g_decTaxTotal As Decimal
    Public g_decTotal As Decimal

    'Global Form Variables
    Dim frmMainForm As New MainForm
    Dim frmDecks As New Decks
    Dim frmWheels As New Wheels
    Dim frmTrucks As New Trucks
    Dim frmMiscellaneous As New Miscellaneous

    Public Sub CalculateTotal() 'Global function for calculating totals
        'Display sub total
        frmMainForm.lblSubTotal.Text = g_decSubTotal.ToString("c")
        'Calculate and display Taxes
        g_decTaxTotal = g_decSubTotal * g_decTaxRate
        frmMainForm.lblTax.Text = g_decTaxTotal.ToString("c")
        'Calculate and display Total
        g_decTotal = g_decTaxTotal + g_decSubTotal
        frmMainForm.lblTotal.Text = g_decTotal.ToString("c")

    End Sub




End Module
