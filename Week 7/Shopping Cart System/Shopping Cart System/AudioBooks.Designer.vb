<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBooks
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
        Me.btnAddPrintBook = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lstPrintBooks = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstAudioBooks = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddPrintBook
        '
        Me.btnAddPrintBook.Location = New System.Drawing.Point(74, 186)
        Me.btnAddPrintBook.Name = "btnAddPrintBook"
        Me.btnAddPrintBook.Size = New System.Drawing.Size(94, 43)
        Me.btnAddPrintBook.TabIndex = 2
        Me.btnAddPrintBook.Text = "Add Book to Cart"
        Me.btnAddPrintBook.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(295, 186)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 43)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lstPrintBooks
        '
        Me.lstPrintBooks.FormattingEnabled = True
        Me.lstPrintBooks.Items.AddRange(New Object() {"I Did it Your Way (Print)", "The History of Scotland (Print)", "Learn Calculus in One Day (Print)", "Feel the Stress (Print)"})
        Me.lstPrintBooks.Location = New System.Drawing.Point(46, 55)
        Me.lstPrintBooks.Name = "lstPrintBooks"
        Me.lstPrintBooks.Size = New System.Drawing.Size(369, 108)
        Me.lstPrintBooks.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstAudioBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(381, 138)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Audio Book"
        '
        'lstAudioBooks
        '
        Me.lstAudioBooks.FormattingEnabled = True
        Me.lstAudioBooks.Location = New System.Drawing.Point(6, 19)
        Me.lstAudioBooks.Name = "lstAudioBooks"
        Me.lstAudioBooks.Size = New System.Drawing.Size(369, 108)
        Me.lstAudioBooks.TabIndex = 0
        '
        'AudioBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 258)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstPrintBooks)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddPrintBook)
        Me.Name = "AudioBooks"
        Me.Text = "Audio Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPrintBook As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstPrintBooks As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstAudioBooks As ListBox
End Class
