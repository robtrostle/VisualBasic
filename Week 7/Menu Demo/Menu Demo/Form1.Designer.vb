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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorGreen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlue = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColorBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuColorVisible = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.70909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(115, 88)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(151, 29)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Hello World!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuColor, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(373, 27)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(43, 23)
        Me.mnuFile.Text = "&File"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(206, 24)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuColor
        '
        Me.mnuColor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColorRed, Me.mnuColorGreen, Me.mnuColorBlue, Me.mnuColorBlack, Me.ToolStripMenuItem1, Me.mnuColorVisible})
        Me.mnuColor.Name = "mnuColor"
        Me.mnuColor.Size = New System.Drawing.Size(56, 23)
        Me.mnuColor.Text = "&Color"
        '
        'mnuColorRed
        '
        Me.mnuColorRed.Name = "mnuColorRed"
        Me.mnuColorRed.Size = New System.Drawing.Size(206, 24)
        Me.mnuColorRed.Text = "&Red"
        '
        'mnuColorGreen
        '
        Me.mnuColorGreen.Name = "mnuColorGreen"
        Me.mnuColorGreen.Size = New System.Drawing.Size(206, 24)
        Me.mnuColorGreen.Text = "&Green"
        '
        'mnuColorBlue
        '
        Me.mnuColorBlue.Name = "mnuColorBlue"
        Me.mnuColorBlue.Size = New System.Drawing.Size(206, 24)
        Me.mnuColorBlue.Text = "&Blue"
        '
        'mnuColorBlack
        '
        Me.mnuColorBlack.Name = "mnuColorBlack"
        Me.mnuColorBlack.Size = New System.Drawing.Size(206, 24)
        Me.mnuColorBlack.Text = "Blac&k"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(203, 6)
        '
        'mnuColorVisible
        '
        Me.mnuColorVisible.Checked = True
        Me.mnuColorVisible.CheckOnClick = True
        Me.mnuColorVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuColorVisible.Name = "mnuColorVisible"
        Me.mnuColorVisible.Size = New System.Drawing.Size(206, 24)
        Me.mnuColorVisible.Text = "Visible"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(51, 23)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(206, 24)
        Me.mnuHelpAbout.Text = "&About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 234)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu Demo"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents mnuColorRed As ToolStripMenuItem
    Friend WithEvents mnuColorGreen As ToolStripMenuItem
    Friend WithEvents mnuColorBlue As ToolStripMenuItem
    Friend WithEvents mnuColorBlack As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnuColorVisible As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class
