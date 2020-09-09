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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGallonsOfGas = New System.Windows.Forms.TextBox()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.lblMilesPerGallon = New System.Windows.Forms.Label()
        Me.btnCalculateMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(74, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gallons of gas the card can hold:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(74, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Miles Per Gallon:"
        '
        'txtGallonsOfGas
        '
        Me.txtGallonsOfGas.Location = New System.Drawing.Point(214, 53)
        Me.txtGallonsOfGas.Name = "txtGallonsOfGas"
        Me.txtGallonsOfGas.Size = New System.Drawing.Size(100, 20)
        Me.txtGallonsOfGas.TabIndex = 3
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(214, 147)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfMiles.TabIndex = 4
        '
        'lblMilesPerGallon
        '
        Me.lblMilesPerGallon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMilesPerGallon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMilesPerGallon.Location = New System.Drawing.Point(211, 212)
        Me.lblMilesPerGallon.Name = "lblMilesPerGallon"
        Me.lblMilesPerGallon.Size = New System.Drawing.Size(100, 23)
        Me.lblMilesPerGallon.TabIndex = 5
        '
        'btnCalculateMPG
        '
        Me.btnCalculateMPG.Location = New System.Drawing.Point(34, 289)
        Me.btnCalculateMPG.Name = "btnCalculateMPG"
        Me.btnCalculateMPG.Size = New System.Drawing.Size(75, 34)
        Me.btnCalculateMPG.TabIndex = 6
        Me.btnCalculateMPG.Text = "Calculate MPG"
        Me.btnCalculateMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(145, 289)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 359)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateMPG)
        Me.Controls.Add(Me.lblMilesPerGallon)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.txtGallonsOfGas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGallonsOfGas As TextBox
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents lblMilesPerGallon As Label
    Friend WithEvents btnCalculateMPG As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
