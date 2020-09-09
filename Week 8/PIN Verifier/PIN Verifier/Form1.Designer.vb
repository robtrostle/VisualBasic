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
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.txtTwo = New System.Windows.Forms.TextBox()
        Me.txtThree = New System.Windows.Forms.TextBox()
        Me.txtFour = New System.Windows.Forms.TextBox()
        Me.txtFive = New System.Windows.Forms.TextBox()
        Me.txtSix = New System.Windows.Forms.TextBox()
        Me.txtSeven = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(32, 98)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 35)
        Me.btnVerify.TabIndex = 0
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(113, 98)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 98)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 35)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSeven)
        Me.GroupBox1.Controls.Add(Me.txtSix)
        Me.GroupBox1.Controls.Add(Me.txtFive)
        Me.GroupBox1.Controls.Add(Me.txtFour)
        Me.GroupBox1.Controls.Add(Me.txtThree)
        Me.GroupBox1.Controls.Add(Me.txtTwo)
        Me.GroupBox1.Controls.Add(Me.txtOne)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 69)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the PIN"
        '
        'txtOne
        '
        Me.txtOne.Location = New System.Drawing.Point(6, 28)
        Me.txtOne.Name = "txtOne"
        Me.txtOne.Size = New System.Drawing.Size(28, 20)
        Me.txtOne.TabIndex = 0
        '
        'txtTwo
        '
        Me.txtTwo.Location = New System.Drawing.Point(40, 28)
        Me.txtTwo.Name = "txtTwo"
        Me.txtTwo.Size = New System.Drawing.Size(28, 20)
        Me.txtTwo.TabIndex = 1
        '
        'txtThree
        '
        Me.txtThree.Location = New System.Drawing.Point(74, 28)
        Me.txtThree.Name = "txtThree"
        Me.txtThree.Size = New System.Drawing.Size(28, 20)
        Me.txtThree.TabIndex = 2
        '
        'txtFour
        '
        Me.txtFour.Location = New System.Drawing.Point(108, 28)
        Me.txtFour.Name = "txtFour"
        Me.txtFour.Size = New System.Drawing.Size(28, 20)
        Me.txtFour.TabIndex = 3
        '
        'txtFive
        '
        Me.txtFive.Location = New System.Drawing.Point(142, 28)
        Me.txtFive.Name = "txtFive"
        Me.txtFive.Size = New System.Drawing.Size(28, 20)
        Me.txtFive.TabIndex = 4
        '
        'txtSix
        '
        Me.txtSix.Location = New System.Drawing.Point(176, 28)
        Me.txtSix.Name = "txtSix"
        Me.txtSix.Size = New System.Drawing.Size(28, 20)
        Me.txtSix.TabIndex = 5
        '
        'txtSeven
        '
        Me.txtSeven.Location = New System.Drawing.Point(209, 28)
        Me.txtSeven.Name = "txtSeven"
        Me.txtSeven.Size = New System.Drawing.Size(28, 20)
        Me.txtSeven.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 159)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVerify)
        Me.Name = "Form1"
        Me.Text = "PIN Verifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVerify As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSeven As TextBox
    Friend WithEvents txtSix As TextBox
    Friend WithEvents txtFive As TextBox
    Friend WithEvents txtFour As TextBox
    Friend WithEvents txtThree As TextBox
    Friend WithEvents txtTwo As TextBox
    Friend WithEvents txtOne As TextBox
End Class
