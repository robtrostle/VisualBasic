<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnViewDecks = New System.Windows.Forms.Button()
        Me.btnViewTrucks = New System.Windows.Forms.Button()
        Me.btnViewWheels = New System.Windows.Forms.Button()
        Me.btnViewMisc = New System.Windows.Forms.Button()
        Me.btnClearMisc = New System.Windows.Forms.Button()
        Me.Configuration = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMisc = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Trucks = New System.Windows.Forms.Label()
        Me.lblWheels = New System.Windows.Forms.Label()
        Me.lblTrucks = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDeck = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Configuration.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnViewDecks
        '
        Me.btnViewDecks.Location = New System.Drawing.Point(309, 19)
        Me.btnViewDecks.Name = "btnViewDecks"
        Me.btnViewDecks.Size = New System.Drawing.Size(84, 31)
        Me.btnViewDecks.TabIndex = 0
        Me.btnViewDecks.Text = "View Decks"
        Me.btnViewDecks.UseVisualStyleBackColor = True
        '
        'btnViewTrucks
        '
        Me.btnViewTrucks.Location = New System.Drawing.Point(309, 56)
        Me.btnViewTrucks.Name = "btnViewTrucks"
        Me.btnViewTrucks.Size = New System.Drawing.Size(84, 31)
        Me.btnViewTrucks.TabIndex = 1
        Me.btnViewTrucks.Text = "View Trucks"
        Me.btnViewTrucks.UseVisualStyleBackColor = True
        '
        'btnViewWheels
        '
        Me.btnViewWheels.Location = New System.Drawing.Point(309, 93)
        Me.btnViewWheels.Name = "btnViewWheels"
        Me.btnViewWheels.Size = New System.Drawing.Size(84, 31)
        Me.btnViewWheels.TabIndex = 2
        Me.btnViewWheels.Text = "View Wheels"
        Me.btnViewWheels.UseVisualStyleBackColor = True
        '
        'btnViewMisc
        '
        Me.btnViewMisc.Location = New System.Drawing.Point(309, 130)
        Me.btnViewMisc.Name = "btnViewMisc"
        Me.btnViewMisc.Size = New System.Drawing.Size(84, 31)
        Me.btnViewMisc.TabIndex = 3
        Me.btnViewMisc.Text = "View Misc"
        Me.btnViewMisc.UseVisualStyleBackColor = True
        '
        'btnClearMisc
        '
        Me.btnClearMisc.Location = New System.Drawing.Point(309, 167)
        Me.btnClearMisc.Name = "btnClearMisc"
        Me.btnClearMisc.Size = New System.Drawing.Size(84, 31)
        Me.btnClearMisc.TabIndex = 4
        Me.btnClearMisc.Text = "Clear Misc"
        Me.btnClearMisc.UseVisualStyleBackColor = True
        '
        'Configuration
        '
        Me.Configuration.Controls.Add(Me.Label2)
        Me.Configuration.Controls.Add(Me.lstMisc)
        Me.Configuration.Controls.Add(Me.Label3)
        Me.Configuration.Controls.Add(Me.Trucks)
        Me.Configuration.Controls.Add(Me.lblWheels)
        Me.Configuration.Controls.Add(Me.lblTrucks)
        Me.Configuration.Controls.Add(Me.Label1)
        Me.Configuration.Controls.Add(Me.lblDeck)
        Me.Configuration.Controls.Add(Me.btnViewDecks)
        Me.Configuration.Controls.Add(Me.btnClearMisc)
        Me.Configuration.Controls.Add(Me.btnViewTrucks)
        Me.Configuration.Controls.Add(Me.btnViewMisc)
        Me.Configuration.Controls.Add(Me.btnViewWheels)
        Me.Configuration.Location = New System.Drawing.Point(12, 12)
        Me.Configuration.Name = "Configuration"
        Me.Configuration.Size = New System.Drawing.Size(425, 234)
        Me.Configuration.TabIndex = 5
        Me.Configuration.TabStop = False
        Me.Configuration.Text = "Configuration"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Misc"
        '
        'lstMisc
        '
        Me.lstMisc.FormattingEnabled = True
        Me.lstMisc.Location = New System.Drawing.Point(90, 130)
        Me.lstMisc.Name = "lstMisc"
        Me.lstMisc.Size = New System.Drawing.Size(199, 95)
        Me.lstMisc.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Wheels"
        '
        'Trucks
        '
        Me.Trucks.AutoSize = True
        Me.Trucks.Location = New System.Drawing.Point(22, 74)
        Me.Trucks.Name = "Trucks"
        Me.Trucks.Size = New System.Drawing.Size(40, 13)
        Me.Trucks.TabIndex = 10
        Me.Trucks.Text = "Trucks"
        '
        'lblWheels
        '
        Me.lblWheels.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWheels.Location = New System.Drawing.Point(90, 93)
        Me.lblWheels.Name = "lblWheels"
        Me.lblWheels.Size = New System.Drawing.Size(199, 31)
        Me.lblWheels.TabIndex = 9
        Me.lblWheels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTrucks
        '
        Me.lblTrucks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTrucks.Location = New System.Drawing.Point(90, 56)
        Me.lblTrucks.Name = "lblTrucks"
        Me.lblTrucks.Size = New System.Drawing.Size(199, 31)
        Me.lblTrucks.TabIndex = 8
        Me.lblTrucks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Deck"
        '
        'lblDeck
        '
        Me.lblDeck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeck.Location = New System.Drawing.Point(90, 19)
        Me.lblDeck.Name = "lblDeck"
        Me.lblDeck.Size = New System.Drawing.Size(199, 31)
        Me.lblDeck.TabIndex = 6
        Me.lblDeck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.l)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblTax)
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 261)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 126)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Charges"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(108, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tax"
        '
        'l
        '
        Me.l.AutoSize = True
        Me.l.Location = New System.Drawing.Point(87, 21)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(46, 13)
        Me.l.TabIndex = 7
        Me.l.Text = "Subtotal"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(149, 84)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 2
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(149, 51)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 1
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(149, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 0
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(102, 417)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 31)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 417)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(84, 31)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 478)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Configuration)
        Me.Name = "MainForm"
        Me.Text = "Skateboard Designer"
        Me.Configuration.ResumeLayout(False)
        Me.Configuration.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewDecks As Button
    Friend WithEvents btnViewTrucks As Button
    Friend WithEvents btnViewWheels As Button
    Friend WithEvents btnViewMisc As Button
    Friend WithEvents btnClearMisc As Button
    Friend WithEvents Configuration As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstMisc As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Trucks As Label
    Friend WithEvents lblWheels As Label
    Friend WithEvents lblTrucks As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDeck As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents l As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
