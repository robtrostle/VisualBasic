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
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnGerman = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnItalian
        '
        Me.btnItalian.Location = New System.Drawing.Point(24, 114)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(75, 23)
        Me.btnItalian.TabIndex = 0
        Me.btnItalian.Text = "Italian"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.Location = New System.Drawing.Point(140, 114)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(75, 23)
        Me.btnSpanish.TabIndex = 1
        Me.btnSpanish.Text = "Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnGerman
        '
        Me.btnGerman.Location = New System.Drawing.Point(256, 114)
        Me.btnGerman.Name = "btnGerman"
        Me.btnGerman.Size = New System.Drawing.Size(75, 23)
        Me.btnGerman.TabIndex = 2
        Me.btnGerman.Text = "German"
        Me.btnGerman.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a language and I will say Good Morning"
        '
        'lblTranslation
        '
        Me.lblTranslation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTranslation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTranslation.Location = New System.Drawing.Point(69, 69)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(243, 23)
        Me.lblTranslation.TabIndex = 4
        Me.lblTranslation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 171)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGerman)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnItalian)
        Me.Name = "Form1"
        Me.Text = "Language Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnItalian As Button
    Friend WithEvents btnSpanish As Button
    Friend WithEvents btnGerman As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTranslation As Label
End Class
