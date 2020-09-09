<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lstYears
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
        Me.lstMonths = New System.Windows.Forms.ListBox()
        Me.lstYear = New System.Windows.Forms.ListBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMonths
        '
        Me.lstMonths.FormattingEnabled = True
        Me.lstMonths.Items.AddRange(New Object() {"January", "February", "March", "April ", "May", "June ", "July ", "August ", "September", "October", "November", "December"})
        Me.lstMonths.Location = New System.Drawing.Point(82, 59)
        Me.lstMonths.Name = "lstMonths"
        Me.lstMonths.Size = New System.Drawing.Size(120, 95)
        Me.lstMonths.TabIndex = 0
        '
        'lstYear
        '
        Me.lstYear.FormattingEnabled = True
        Me.lstYear.Items.AddRange(New Object() {"2016", "2017", "2018", "2019", "2020"})
        Me.lstYear.Location = New System.Drawing.Point(277, 59)
        Me.lstYear.Name = "lstYear"
        Me.lstYear.Size = New System.Drawing.Size(120, 95)
        Me.lstYear.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(106, 233)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(302, 233)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lstYears
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 320)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lstYear)
        Me.Controls.Add(Me.lstMonths)
        Me.Name = "lstYears"
        Me.Text = "List Box Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMonths As ListBox
    Friend WithEvents lstYear As ListBox
    Friend WithEvents btnOk As Button
    Friend WithEvents btnReset As Button
End Class
