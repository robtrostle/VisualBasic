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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblFourth = New System.Windows.Forms.Label()
        Me.lblFifth = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirst.Location = New System.Drawing.Point(30, 74)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(70, 23)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecond
        '
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecond.Location = New System.Drawing.Point(133, 74)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(70, 23)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThird
        '
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThird.Location = New System.Drawing.Point(238, 74)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(70, 23)
        Me.lblThird.TabIndex = 2
        Me.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFourth
        '
        Me.lblFourth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFourth.Location = New System.Drawing.Point(332, 74)
        Me.lblFourth.Name = "lblFourth"
        Me.lblFourth.Size = New System.Drawing.Size(70, 23)
        Me.lblFourth.TabIndex = 3
        Me.lblFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFifth
        '
        Me.lblFifth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFifth.Location = New System.Drawing.Point(428, 74)
        Me.lblFifth.Name = "lblFifth"
        Me.lblFifth.Size = New System.Drawing.Size(70, 23)
        Me.lblFifth.TabIndex = 4
        Me.lblFifth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(157, 122)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 38)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "&Generate Numbers"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 122)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 196)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.lblFifth)
        Me.Controls.Add(Me.lblFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "Form1"
        Me.Text = "Lottery Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblThird As Label
    Friend WithEvents lblFourth As Label
    Friend WithEvents lblFifth As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnExit As Button
End Class
