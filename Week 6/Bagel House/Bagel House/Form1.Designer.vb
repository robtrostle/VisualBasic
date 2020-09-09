<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWhite = New System.Windows.Forms.RadioButton()
        Me.radWheat = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkBlueberry = New System.Windows.Forms.CheckBox()
        Me.chkRasberry = New System.Windows.Forms.CheckBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.radRegCoffee = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.21818!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(149, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brandi's Bagel House"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(30, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(294, 379)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(355, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(294, 208)
        Me.Panel2.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radWheat)
        Me.GroupBox1.Controls.Add(Me.radWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pick a Bagel"
        '
        'radWhite
        '
        Me.radWhite.AutoSize = True
        Me.radWhite.Checked = True
        Me.radWhite.Location = New System.Drawing.Point(16, 29)
        Me.radWhite.Name = "radWhite"
        Me.radWhite.Size = New System.Drawing.Size(89, 17)
        Me.radWhite.TabIndex = 0
        Me.radWhite.TabStop = True
        Me.radWhite.Text = "White ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radWhite, "Click here to choose a white bagel.")
        Me.radWhite.UseVisualStyleBackColor = True
        '
        'radWheat
        '
        Me.radWheat.AutoSize = True
        Me.radWheat.Location = New System.Drawing.Point(16, 64)
        Me.radWheat.Name = "radWheat"
        Me.radWheat.Size = New System.Drawing.Size(127, 17)
        Me.radWheat.TabIndex = 1
        Me.radWheat.TabStop = True
        Me.radWheat.Text = "Whole Wheat ($1.50)"
        Me.radWheat.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPeach)
        Me.GroupBox2.Controls.Add(Me.chkRasberry)
        Me.GroupBox2.Controls.Add(Me.chkBlueberry)
        Me.GroupBox2.Controls.Add(Me.chkButter)
        Me.GroupBox2.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 195)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick Your Toppings"
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(16, 30)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(125, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese ($.50)"
        Me.ToolTip1.SetToolTip(Me.chkCreamCheese, "Click here to choose cream cheese")
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(16, 63)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(84, 17)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter ($.25)"
        Me.ToolTip1.SetToolTip(Me.chkButter, "Click here to choose butter")
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkBlueberry
        '
        Me.chkBlueberry.AutoSize = True
        Me.chkBlueberry.Location = New System.Drawing.Point(16, 101)
        Me.chkBlueberry.Name = "chkBlueberry"
        Me.chkBlueberry.Size = New System.Drawing.Size(122, 17)
        Me.chkBlueberry.TabIndex = 2
        Me.chkBlueberry.Text = "Blueberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkBlueberry, "Click here to choose blueberry jam")
        Me.chkBlueberry.UseVisualStyleBackColor = True
        '
        'chkRasberry
        '
        Me.chkRasberry.AutoSize = True
        Me.chkRasberry.Location = New System.Drawing.Point(16, 137)
        Me.chkRasberry.Name = "chkRasberry"
        Me.chkRasberry.Size = New System.Drawing.Size(120, 17)
        Me.chkRasberry.TabIndex = 3
        Me.chkRasberry.Text = "Rasberry Jam ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkRasberry, "Click here to choose rasberry jam.")
        Me.chkRasberry.UseVisualStyleBackColor = True
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(16, 172)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(110, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly ($.75)"
        Me.ToolTip1.SetToolTip(Me.chkPeach, "Click here to choose peach jelly")
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(355, 302)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(294, 165)
        Me.Panel3.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox3.Controls.Add(Me.radCappuccino)
        Me.GroupBox3.Controls.Add(Me.radRegCoffee)
        Me.GroupBox3.Controls.Add(Me.radNoCoffee)
        Me.GroupBox3.Location = New System.Drawing.Point(22, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 173)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Want Coffee with that?"
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(19, 29)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(51, 17)
        Me.radNoCoffee.TabIndex = 0
        Me.radNoCoffee.Text = "None"
        Me.ToolTip1.SetToolTip(Me.radNoCoffee, "Click here to choose no coffee")
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'radRegCoffee
        '
        Me.radRegCoffee.AutoSize = True
        Me.radRegCoffee.Checked = True
        Me.radRegCoffee.Location = New System.Drawing.Point(19, 64)
        Me.radRegCoffee.Name = "radRegCoffee"
        Me.radRegCoffee.Size = New System.Drawing.Size(132, 17)
        Me.radRegCoffee.TabIndex = 1
        Me.radRegCoffee.TabStop = True
        Me.radRegCoffee.Text = "Regular Coffee ($1.25)"
        Me.ToolTip1.SetToolTip(Me.radRegCoffee, "Click here to choose regular coffee")
        Me.radRegCoffee.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(19, 101)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(118, 17)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.Text = "Cappuccino ($2.00)"
        Me.ToolTip1.SetToolTip(Me.radCappuccino, "Click here to choose cappuccino")
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(19, 141)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(114, 17)
        Me.radCafeAuLait.TabIndex = 3
        Me.radCafeAuLait.Text = "Cafe au lait ($1.75)"
        Me.ToolTip1.SetToolTip(Me.radCafeAuLait, "Click here to choose Cafe au lait")
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Total)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Location = New System.Drawing.Point(22, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(251, 132)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Price"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(115, 16)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 0
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(115, 58)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 1
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(115, 103)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Subtotal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tax"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(49, 113)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(31, 13)
        Me.Total.TabIndex = 5
        Me.Total.Text = "Total"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(116, 484)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(88, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate Total"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Click here to calculate total")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(303, 484)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "&Reset Form"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Clear here to start over")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(493, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 530)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents chkRasberry As CheckBox
    Friend WithEvents chkBlueberry As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radWheat As RadioButton
    Friend WithEvents radWhite As RadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radCafeAuLait As RadioButton
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radRegCoffee As RadioButton
    Friend WithEvents radNoCoffee As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Total As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
