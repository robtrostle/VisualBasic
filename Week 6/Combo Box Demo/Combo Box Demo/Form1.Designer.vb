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
        Me.cboCountries = New System.Windows.Forms.ComboBox()
        Me.cboPlays = New System.Windows.Forms.ComboBox()
        Me.cboArtists = New System.Windows.Forms.ComboBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.lblPlay = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboCountries
        '
        Me.cboCountries.FormattingEnabled = True
        Me.cboCountries.Items.AddRange(New Object() {"England", "Ireland", "Scotland", "Wales"})
        Me.cboCountries.Location = New System.Drawing.Point(49, 27)
        Me.cboCountries.Name = "cboCountries"
        Me.cboCountries.Size = New System.Drawing.Size(121, 21)
        Me.cboCountries.Sorted = True
        Me.cboCountries.TabIndex = 0
        '
        'cboPlays
        '
        Me.cboPlays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cboPlays.FormattingEnabled = True
        Me.cboPlays.Items.AddRange(New Object() {"A Comedy of Errors", "Hamlet", "Much Ado about Nothing", "Romeo and Juliet", "The Merchant of Venice"})
        Me.cboPlays.Location = New System.Drawing.Point(49, 124)
        Me.cboPlays.Name = "cboPlays"
        Me.cboPlays.Size = New System.Drawing.Size(121, 59)
        Me.cboPlays.Sorted = True
        Me.cboPlays.TabIndex = 1
        '
        'cboArtists
        '
        Me.cboArtists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboArtists.FormattingEnabled = True
        Me.cboArtists.Items.AddRange(New Object() {"Michaleangelo", "Raphael", "da Vinci"})
        Me.cboArtists.Location = New System.Drawing.Point(49, 215)
        Me.cboArtists.Name = "cboArtists"
        Me.cboArtists.Size = New System.Drawing.Size(121, 21)
        Me.cboArtists.TabIndex = 2
        '
        'lblCountry
        '
        Me.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCountry.Location = New System.Drawing.Point(336, 35)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(100, 23)
        Me.lblCountry.TabIndex = 3
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlay
        '
        Me.lblPlay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlay.Location = New System.Drawing.Point(336, 124)
        Me.lblPlay.Name = "lblPlay"
        Me.lblPlay.Size = New System.Drawing.Size(100, 23)
        Me.lblPlay.TabIndex = 4
        Me.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArtist
        '
        Me.lblArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArtist.Location = New System.Drawing.Point(336, 213)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(100, 23)
        Me.lblArtist.TabIndex = 5
        Me.lblArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(70, 276)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 38)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "&Show Selections"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(211, 276)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 38)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 276)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 326)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblArtist)
        Me.Controls.Add(Me.lblPlay)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.cboArtists)
        Me.Controls.Add(Me.cboPlays)
        Me.Controls.Add(Me.cboCountries)
        Me.Name = "Form1"
        Me.Text = "Combo Box Demo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboCountries As ComboBox
    Friend WithEvents cboPlays As ComboBox
    Friend WithEvents cboArtists As ComboBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents lblPlay As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
