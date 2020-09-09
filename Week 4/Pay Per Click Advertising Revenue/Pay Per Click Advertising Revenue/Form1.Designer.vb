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
        Me.txtCostPerWeek = New System.Windows.Forms.TextBox()
        Me.txtWeekOne = New System.Windows.Forms.TextBox()
        Me.txtWeekTwo = New System.Windows.Forms.TextBox()
        Me.txtWeekThree = New System.Windows.Forms.TextBox()
        Me.txtWeekFour = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblWeekOne = New System.Windows.Forms.Label()
        Me.lblWeekTwo = New System.Windows.Forms.Label()
        Me.lblWeekThree = New System.Windows.Forms.Label()
        Me.lblWeekFour = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.163636!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(470, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "This application calculates the amount of advertising revenue paid to a Web site " &
    "that displays links to a selected vendor."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Advertising cost per week:"
        '
        'txtCostPerWeek
        '
        Me.txtCostPerWeek.Location = New System.Drawing.Point(350, 136)
        Me.txtCostPerWeek.Name = "txtCostPerWeek"
        Me.txtCostPerWeek.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerWeek.TabIndex = 2
        '
        'txtWeekOne
        '
        Me.txtWeekOne.Location = New System.Drawing.Point(255, 220)
        Me.txtWeekOne.Name = "txtWeekOne"
        Me.txtWeekOne.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekOne.TabIndex = 3
        '
        'txtWeekTwo
        '
        Me.txtWeekTwo.Location = New System.Drawing.Point(255, 258)
        Me.txtWeekTwo.Name = "txtWeekTwo"
        Me.txtWeekTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekTwo.TabIndex = 4
        '
        'txtWeekThree
        '
        Me.txtWeekThree.Location = New System.Drawing.Point(255, 301)
        Me.txtWeekThree.Name = "txtWeekThree"
        Me.txtWeekThree.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekThree.TabIndex = 5
        '
        'txtWeekFour
        '
        Me.txtWeekFour.Location = New System.Drawing.Point(255, 342)
        Me.txtWeekFour.Name = "txtWeekFour"
        Me.txtWeekFour.Size = New System.Drawing.Size(100, 20)
        Me.txtWeekFour.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(215, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(215, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 342)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.12727!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(571, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Revenue"
        '
        'lblWeekOne
        '
        Me.lblWeekOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekOne.Location = New System.Drawing.Point(561, 217)
        Me.lblWeekOne.Name = "lblWeekOne"
        Me.lblWeekOne.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekOne.TabIndex = 12
        Me.lblWeekOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeekTwo
        '
        Me.lblWeekTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekTwo.Location = New System.Drawing.Point(561, 258)
        Me.lblWeekTwo.Name = "lblWeekTwo"
        Me.lblWeekTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekTwo.TabIndex = 13
        Me.lblWeekTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeekThree
        '
        Me.lblWeekThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekThree.Location = New System.Drawing.Point(561, 298)
        Me.lblWeekThree.Name = "lblWeekThree"
        Me.lblWeekThree.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekThree.TabIndex = 14
        Me.lblWeekThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeekFour
        '
        Me.lblWeekFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekFour.Location = New System.Drawing.Point(561, 339)
        Me.lblWeekFour.Name = "lblWeekFour"
        Me.lblWeekFour.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekFour.TabIndex = 15
        Me.lblWeekFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(34, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 58)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number of Ad Clicks during the past 4 weekly periods"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(124, 397)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(360, 397)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(561, 397)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 501)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(682, 22)
        Me.StatusStrip1.TabIndex = 20
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(682, 523)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblWeekFour)
        Me.Controls.Add(Me.lblWeekThree)
        Me.Controls.Add(Me.lblWeekTwo)
        Me.Controls.Add(Me.lblWeekOne)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWeekFour)
        Me.Controls.Add(Me.txtWeekThree)
        Me.Controls.Add(Me.txtWeekTwo)
        Me.Controls.Add(Me.txtWeekOne)
        Me.Controls.Add(Me.txtCostPerWeek)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCostPerWeek As TextBox
    Friend WithEvents txtWeekOne As TextBox
    Friend WithEvents txtWeekTwo As TextBox
    Friend WithEvents txtWeekThree As TextBox
    Friend WithEvents txtWeekFour As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblWeekOne As Label
    Friend WithEvents lblWeekTwo As Label
    Friend WithEvents lblWeekThree As Label
    Friend WithEvents lblWeekFour As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
