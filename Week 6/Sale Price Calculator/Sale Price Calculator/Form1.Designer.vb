﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDiscountPercent = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSalePrice = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSalePrice)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDiscountPercent)
        Me.Panel1.Controls.Add(Me.txtRetailPrice)
        Me.Panel1.Location = New System.Drawing.Point(36, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 203)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sale Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Discount Percentage:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Retail Price:"
        '
        'txtDiscountPercent
        '
        Me.txtDiscountPercent.Location = New System.Drawing.Point(185, 82)
        Me.txtDiscountPercent.Name = "txtDiscountPercent"
        Me.txtDiscountPercent.Size = New System.Drawing.Size(100, 20)
        Me.txtDiscountPercent.TabIndex = 1
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.Location = New System.Drawing.Point(185, 34)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailPrice.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMessage.Location = New System.Drawing.Point(36, 252)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(340, 23)
        Me.lblMessage.TabIndex = 6
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(70, 289)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(129, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate Sale Price"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(259, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSalePrice
        '
        Me.lblSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalePrice.Location = New System.Drawing.Point(185, 128)
        Me.lblSalePrice.Name = "lblSalePrice"
        Me.lblSalePrice.Size = New System.Drawing.Size(100, 23)
        Me.lblSalePrice.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 324)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Sale Price Calculator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtDiscountPercent As TextBox
    Friend WithEvents txtRetailPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblSalePrice As Label
End Class
