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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radArabic = New System.Windows.Forms.RadioButton()
        Me.radChinese = New System.Windows.Forms.RadioButton()
        Me.radEnglish = New System.Windows.Forms.RadioButton()
        Me.radFrench = New System.Windows.Forms.RadioButton()
        Me.radGerman = New System.Windows.Forms.RadioButton()
        Me.chkAncientChina = New System.Windows.Forms.CheckBox()
        Me.chkAncientEurope = New System.Windows.Forms.CheckBox()
        Me.chkAncientEgypt = New System.Windows.Forms.CheckBox()
        Me.chkMesopotamia = New System.Windows.Forms.CheckBox()
        Me.chkMedievalEurope = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.radGerman)
        Me.GroupBox1.Controls.Add(Me.radFrench)
        Me.GroupBox1.Controls.Add(Me.radEnglish)
        Me.GroupBox1.Controls.Add(Me.radChinese)
        Me.GroupBox1.Controls.Add(Me.radArabic)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 109)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Language"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.chkMedievalEurope)
        Me.GroupBox2.Controls.Add(Me.chkMesopotamia)
        Me.GroupBox2.Controls.Add(Me.chkAncientEgypt)
        Me.GroupBox2.Controls.Add(Me.chkAncientEurope)
        Me.GroupBox2.Controls.Add(Me.chkAncientChina)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 109)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 170)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Featured Sections"
        '
        'radArabic
        '
        Me.radArabic.AutoSize = True
        Me.radArabic.Location = New System.Drawing.Point(19, 33)
        Me.radArabic.Name = "radArabic"
        Me.radArabic.Size = New System.Drawing.Size(55, 17)
        Me.radArabic.TabIndex = 1
        Me.radArabic.TabStop = True
        Me.radArabic.Text = "Arabic"
        Me.radArabic.UseVisualStyleBackColor = True
        '
        'radChinese
        '
        Me.radChinese.AutoSize = True
        Me.radChinese.Location = New System.Drawing.Point(19, 56)
        Me.radChinese.Name = "radChinese"
        Me.radChinese.Size = New System.Drawing.Size(63, 17)
        Me.radChinese.TabIndex = 2
        Me.radChinese.TabStop = True
        Me.radChinese.Text = "Chinese"
        Me.radChinese.UseVisualStyleBackColor = True
        '
        'radEnglish
        '
        Me.radEnglish.AutoSize = True
        Me.radEnglish.Location = New System.Drawing.Point(19, 79)
        Me.radEnglish.Name = "radEnglish"
        Me.radEnglish.Size = New System.Drawing.Size(59, 17)
        Me.radEnglish.TabIndex = 3
        Me.radEnglish.TabStop = True
        Me.radEnglish.Text = "English"
        Me.radEnglish.UseVisualStyleBackColor = True
        '
        'radFrench
        '
        Me.radFrench.AutoSize = True
        Me.radFrench.Location = New System.Drawing.Point(19, 102)
        Me.radFrench.Name = "radFrench"
        Me.radFrench.Size = New System.Drawing.Size(58, 17)
        Me.radFrench.TabIndex = 4
        Me.radFrench.TabStop = True
        Me.radFrench.Text = "French"
        Me.radFrench.UseVisualStyleBackColor = True
        '
        'radGerman
        '
        Me.radGerman.AutoSize = True
        Me.radGerman.Location = New System.Drawing.Point(19, 125)
        Me.radGerman.Name = "radGerman"
        Me.radGerman.Size = New System.Drawing.Size(62, 17)
        Me.radGerman.TabIndex = 5
        Me.radGerman.TabStop = True
        Me.radGerman.Text = "German"
        Me.radGerman.UseVisualStyleBackColor = True
        '
        'chkAncientChina
        '
        Me.chkAncientChina.AutoSize = True
        Me.chkAncientChina.Location = New System.Drawing.Point(24, 33)
        Me.chkAncientChina.Name = "chkAncientChina"
        Me.chkAncientChina.Size = New System.Drawing.Size(92, 17)
        Me.chkAncientChina.TabIndex = 0
        Me.chkAncientChina.Text = "Ancient China"
        Me.chkAncientChina.UseVisualStyleBackColor = True
        '
        'chkAncientEurope
        '
        Me.chkAncientEurope.AutoSize = True
        Me.chkAncientEurope.Location = New System.Drawing.Point(24, 56)
        Me.chkAncientEurope.Name = "chkAncientEurope"
        Me.chkAncientEurope.Size = New System.Drawing.Size(99, 17)
        Me.chkAncientEurope.TabIndex = 1
        Me.chkAncientEurope.Text = "Ancient Europe"
        Me.chkAncientEurope.UseVisualStyleBackColor = True
        '
        'chkAncientEgypt
        '
        Me.chkAncientEgypt.AutoSize = True
        Me.chkAncientEgypt.Location = New System.Drawing.Point(24, 79)
        Me.chkAncientEgypt.Name = "chkAncientEgypt"
        Me.chkAncientEgypt.Size = New System.Drawing.Size(92, 17)
        Me.chkAncientEgypt.TabIndex = 2
        Me.chkAncientEgypt.Text = "Ancient Egypt"
        Me.chkAncientEgypt.UseVisualStyleBackColor = True
        '
        'chkMesopotamia
        '
        Me.chkMesopotamia.AutoSize = True
        Me.chkMesopotamia.Location = New System.Drawing.Point(24, 102)
        Me.chkMesopotamia.Name = "chkMesopotamia"
        Me.chkMesopotamia.Size = New System.Drawing.Size(89, 17)
        Me.chkMesopotamia.TabIndex = 3
        Me.chkMesopotamia.Text = "Mesopotamia"
        Me.chkMesopotamia.UseVisualStyleBackColor = True
        '
        'chkMedievalEurope
        '
        Me.chkMedievalEurope.AutoSize = True
        Me.chkMedievalEurope.Location = New System.Drawing.Point(24, 125)
        Me.chkMedievalEurope.Name = "chkMedievalEurope"
        Me.chkMedievalEurope.Size = New System.Drawing.Size(106, 17)
        Me.chkMedievalEurope.TabIndex = 4
        Me.chkMedievalEurope.Text = "Medieval Europe"
        Me.chkMedievalEurope.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "This application lets the user select various options for tours at our museum. Wh" &
    "en you click the Calculate Cost button, it will calculate and display the tour c" &
    "ost."
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(77, 319)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Cost"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(276, 319)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close Window"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 390)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Museum Tours"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radGerman As RadioButton
    Friend WithEvents radFrench As RadioButton
    Friend WithEvents radEnglish As RadioButton
    Friend WithEvents radChinese As RadioButton
    Friend WithEvents radArabic As RadioButton
    Friend WithEvents chkMedievalEurope As CheckBox
    Friend WithEvents chkMesopotamia As CheckBox
    Friend WithEvents chkAncientEgypt As CheckBox
    Friend WithEvents chkAncientEurope As CheckBox
    Friend WithEvents chkAncientChina As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClose As Button
End Class
