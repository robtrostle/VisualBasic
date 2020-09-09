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
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(12, 12)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(139, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "Step 1: Input the Integers"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 62)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(139, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Step 2: Display Min/Max"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(12, 208)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(370, 23)
        Me.lblResult.TabIndex = 3
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.Location = New System.Drawing.Point(157, 12)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(225, 186)
        Me.lstNumbers.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 258)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Name = "Form1"
        Me.Text = "Largest / Smallest Values"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnInput As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents lstNumbers As ListBox
End Class
