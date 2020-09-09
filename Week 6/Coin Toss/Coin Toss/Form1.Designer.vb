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
        Me.components = New System.ComponentModel.Container()
        Me.btnToss = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnToss
        '
        Me.btnToss.Location = New System.Drawing.Point(71, 236)
        Me.btnToss.Name = "btnToss"
        Me.btnToss.Size = New System.Drawing.Size(82, 23)
        Me.btnToss.TabIndex = 2
        Me.btnToss.Text = "&Toss the Coin"
        Me.ToolTip1.SetToolTip(Me.btnToss, "Click to toss the coin")
        Me.btnToss.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(280, 236)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picTails
        '
        Me.picTails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTails.Image = Global.Coin_Toss.My.Resources.Resources.Tails
        Me.picTails.Location = New System.Drawing.Point(239, 35)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(152, 152)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTails.TabIndex = 1
        Me.picTails.TabStop = False
        Me.picTails.Visible = False
        '
        'picHeads
        '
        Me.picHeads.Image = Global.Coin_Toss.My.Resources.Resources.Heads
        Me.picHeads.Location = New System.Drawing.Point(34, 35)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(155, 152)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHeads.TabIndex = 0
        Me.picHeads.TabStop = False
        Me.picHeads.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 331)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnToss)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Name = "Form1"
        Me.Text = "Coin Toss"
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picHeads As PictureBox
    Friend WithEvents picTails As PictureBox
    Friend WithEvents btnToss As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
