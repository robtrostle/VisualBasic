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
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.picJoker = New System.Windows.Forms.PictureBox()
        Me.picAceOfSpades = New System.Windows.Forms.PictureBox()
        Me.picKingOfSpades = New System.Windows.Forms.PictureBox()
        Me.pic2OfSpades = New System.Windows.Forms.PictureBox()
        Me.pic8OfDiamonds = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picJoker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAceOfSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKingOfSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2OfSpades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic8OfDiamonds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click a Card to See Its Name"
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.74545!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(91, 257)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(325, 34)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picJoker
        '
        Me.picJoker.Image = Global.Card_Identifier.My.Resources.Resources.Joker_Black
        Me.picJoker.Location = New System.Drawing.Point(400, 122)
        Me.picJoker.Name = "picJoker"
        Me.picJoker.Size = New System.Drawing.Size(88, 101)
        Me.picJoker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJoker.TabIndex = 6
        Me.picJoker.TabStop = False
        '
        'picAceOfSpades
        '
        Me.picAceOfSpades.Image = Global.Card_Identifier.My.Resources.Resources.Ace_Spades
        Me.picAceOfSpades.Location = New System.Drawing.Point(306, 122)
        Me.picAceOfSpades.Name = "picAceOfSpades"
        Me.picAceOfSpades.Size = New System.Drawing.Size(88, 101)
        Me.picAceOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAceOfSpades.TabIndex = 5
        Me.picAceOfSpades.TabStop = False
        '
        'picKingOfSpades
        '
        Me.picKingOfSpades.Image = Global.Card_Identifier.My.Resources.Resources.King_Spades
        Me.picKingOfSpades.Location = New System.Drawing.Point(212, 122)
        Me.picKingOfSpades.Name = "picKingOfSpades"
        Me.picKingOfSpades.Size = New System.Drawing.Size(88, 101)
        Me.picKingOfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKingOfSpades.TabIndex = 4
        Me.picKingOfSpades.TabStop = False
        '
        'pic2OfSpades
        '
        Me.pic2OfSpades.Image = Global.Card_Identifier.My.Resources.Resources._2_Spades
        Me.pic2OfSpades.Location = New System.Drawing.Point(115, 122)
        Me.pic2OfSpades.Name = "pic2OfSpades"
        Me.pic2OfSpades.Size = New System.Drawing.Size(88, 101)
        Me.pic2OfSpades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2OfSpades.TabIndex = 3
        Me.pic2OfSpades.TabStop = False
        '
        'pic8OfDiamonds
        '
        Me.pic8OfDiamonds.Image = Global.Card_Identifier.My.Resources.Resources._8_Diamonds
        Me.pic8OfDiamonds.Location = New System.Drawing.Point(21, 122)
        Me.pic8OfDiamonds.Name = "pic8OfDiamonds"
        Me.pic8OfDiamonds.Size = New System.Drawing.Size(88, 101)
        Me.pic8OfDiamonds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic8OfDiamonds.TabIndex = 2
        Me.pic8OfDiamonds.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(201, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 372)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.picJoker)
        Me.Controls.Add(Me.picAceOfSpades)
        Me.Controls.Add(Me.picKingOfSpades)
        Me.Controls.Add(Me.pic2OfSpades)
        Me.Controls.Add(Me.pic8OfDiamonds)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Card Identifier"
        CType(Me.picJoker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAceOfSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKingOfSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2OfSpades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic8OfDiamonds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents pic8OfDiamonds As PictureBox
    Friend WithEvents pic2OfSpades As PictureBox
    Friend WithEvents picKingOfSpades As PictureBox
    Friend WithEvents picAceOfSpades As PictureBox
    Friend WithEvents picJoker As PictureBox
    Friend WithEvents btnExit As Button
End Class
