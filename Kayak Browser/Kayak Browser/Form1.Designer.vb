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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstKayaks = New System.Windows.Forms.ListBox()
        Me.KayaksTypesDataSet = New Kayak_Browser.KayaksTypesDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Kayak_Browser.KayaksTypesDataSetTableAdapters.KayakTypesTableAdapter()
        Me.TableAdapterManager = New Kayak_Browser.KayaksTypesDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.KayaksTypesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a kayak to view a description"
        '
        'lstKayaks
        '
        Me.lstKayaks.DataSource = Me.KayakTypesBindingSource
        Me.lstKayaks.DisplayMember = "Name"
        Me.lstKayaks.FormattingEnabled = True
        Me.lstKayaks.Location = New System.Drawing.Point(30, 103)
        Me.lstKayaks.Name = "lstKayaks"
        Me.lstKayaks.Size = New System.Drawing.Size(125, 134)
        Me.lstKayaks.TabIndex = 1
        '
        'KayaksTypesDataSet
        '
        Me.KayaksTypesDataSet.DataSetName = "KayaksTypesDataSet"
        Me.KayaksTypesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksTypesDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.KayakTypesTableAdapter = Me.KayakTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kayak_Browser.KayaksTypesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KayakTypesBindingSource, "Description", True))
        Me.Label2.Location = New System.Drawing.Point(291, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(363, 134)
        Me.Label2.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 358)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstKayaks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kayak Browser"
        CType(Me.KayaksTypesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstKayaks As ListBox
    Friend WithEvents KayaksTypesDataSet As KayaksTypesDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksTypesDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents TableAdapterManager As KayaksTypesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
End Class
