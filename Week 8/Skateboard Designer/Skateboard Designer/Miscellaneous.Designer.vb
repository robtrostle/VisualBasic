<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Miscellaneous
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkAssembly = New System.Windows.Forms.CheckBox()
        Me.chkNutsAndBolts = New System.Windows.Forms.CheckBox()
        Me.chkRiserPads = New System.Windows.Forms.CheckBox()
        Me.chkBearings = New System.Windows.Forms.CheckBox()
        Me.chkGripTape = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(41, 252)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 40)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(138, 252)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 40)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAssembly)
        Me.GroupBox1.Controls.Add(Me.chkNutsAndBolts)
        Me.GroupBox1.Controls.Add(Me.chkRiserPads)
        Me.GroupBox1.Controls.Add(Me.chkBearings)
        Me.GroupBox1.Controls.Add(Me.chkGripTape)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 234)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Products and Services"
        '
        'chkAssembly
        '
        Me.chkAssembly.AutoSize = True
        Me.chkAssembly.Location = New System.Drawing.Point(23, 176)
        Me.chkAssembly.Name = "chkAssembly"
        Me.chkAssembly.Size = New System.Drawing.Size(127, 17)
        Me.chkAssembly.TabIndex = 4
        Me.chkAssembly.Text = "Assembly           ($10)"
        Me.chkAssembly.UseVisualStyleBackColor = True
        '
        'chkNutsAndBolts
        '
        Me.chkNutsAndBolts.AutoSize = True
        Me.chkNutsAndBolts.Location = New System.Drawing.Point(23, 140)
        Me.chkNutsAndBolts.Name = "chkNutsAndBolts"
        Me.chkNutsAndBolts.Size = New System.Drawing.Size(125, 17)
        Me.chkNutsAndBolts.TabIndex = 3
        Me.chkNutsAndBolts.Text = "Nuts && Bolts Kit   ($3)"
        Me.chkNutsAndBolts.UseVisualStyleBackColor = True
        '
        'chkRiserPads
        '
        Me.chkRiserPads.AutoSize = True
        Me.chkRiserPads.Location = New System.Drawing.Point(23, 106)
        Me.chkRiserPads.Name = "chkRiserPads"
        Me.chkRiserPads.Size = New System.Drawing.Size(125, 17)
        Me.chkRiserPads.TabIndex = 2
        Me.chkRiserPads.Text = "Riser Pads          ($2)"
        Me.chkRiserPads.UseVisualStyleBackColor = True
        '
        'chkBearings
        '
        Me.chkBearings.AutoSize = True
        Me.chkBearings.Location = New System.Drawing.Point(23, 69)
        Me.chkBearings.Name = "chkBearings"
        Me.chkBearings.Size = New System.Drawing.Size(127, 17)
        Me.chkBearings.TabIndex = 1
        Me.chkBearings.Text = "Bearings            ($30)"
        Me.chkBearings.UseVisualStyleBackColor = True
        '
        'chkGripTape
        '
        Me.chkGripTape.AutoSize = True
        Me.chkGripTape.Location = New System.Drawing.Point(23, 31)
        Me.chkGripTape.Name = "chkGripTape"
        Me.chkGripTape.Size = New System.Drawing.Size(127, 17)
        Me.chkGripTape.TabIndex = 0
        Me.chkGripTape.Text = "Grip Tape          ($10)"
        Me.chkGripTape.UseVisualStyleBackColor = True
        '
        'Miscellaneous
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 317)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Miscellaneous"
        Me.Text = "Miscellaneous"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkAssembly As CheckBox
    Friend WithEvents chkNutsAndBolts As CheckBox
    Friend WithEvents chkRiserPads As CheckBox
    Friend WithEvents chkBearings As CheckBox
    Friend WithEvents chkGripTape As CheckBox
End Class
