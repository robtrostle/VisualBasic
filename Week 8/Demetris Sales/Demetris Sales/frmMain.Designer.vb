﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstSalesData = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalRevenue = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportData = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstSalesData)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 296)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales Data"
        '
        'lstSalesData
        '
        Me.lstSalesData.FormattingEnabled = True
        Me.lstSalesData.Location = New System.Drawing.Point(6, 19)
        Me.lstSalesData.Name = "lstSalesData"
        Me.lstSalesData.Size = New System.Drawing.Size(460, 264)
        Me.lstSalesData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Revenue"
        '
        'lblTotalRevenue
        '
        Me.lblTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalRevenue.Location = New System.Drawing.Point(356, 339)
        Me.lblTotalRevenue.Name = "lblTotalRevenue"
        Me.lblTotalRevenue.Size = New System.Drawing.Size(122, 23)
        Me.lblTotalRevenue.TabIndex = 2
        Me.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuReport, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(496, 27)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(43, 23)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(206, 24)
        Me.mnuFileExit.Text = "E&xit "
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportData, Me.mnuReportDisplay})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(64, 23)
        Me.mnuReport.Text = "&Report"
        '
        'mnuReportData
        '
        Me.mnuReportData.Name = "mnuReportData"
        Me.mnuReportData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.mnuReportData.Size = New System.Drawing.Size(260, 24)
        Me.mnuReportData.Text = "&Enter Sales Data"
        '
        'mnuReportDisplay
        '
        Me.mnuReportDisplay.Name = "mnuReportDisplay"
        Me.mnuReportDisplay.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.mnuReportDisplay.Size = New System.Drawing.Size(260, 24)
        Me.mnuReportDisplay.Text = "&Display Sales Report"
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
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 380)
        Me.Controls.Add(Me.lblTotalRevenue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Demetris Leadership Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstSalesData As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalRevenue As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuReportData As ToolStripMenuItem
    Friend WithEvents mnuReportDisplay As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
End Class
