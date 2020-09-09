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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SalesStaffBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalesStaffBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesStaffDataGridView = New System.Windows.Forms.DataGridView()
        Me.Full_TimeToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Full_TimeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesStaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDataSet = New SalesStaffOne.CompanyDataSet()
        Me.SalesStaffTableAdapter = New SalesStaffOne.CompanyDataSetTableAdapters.SalesStaffTableAdapter()
        Me.TableAdapterManager = New SalesStaffOne.CompanyDataSetTableAdapters.TableAdapterManager()
        Me.AllRowsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AllRowsToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesStaffBindingNavigator.SuspendLayout()
        CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Full_TimeToolStrip.SuspendLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AllRowsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SalesStaffBindingNavigator
        '
        Me.SalesStaffBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesStaffBindingNavigator.BindingSource = Me.SalesStaffBindingSource
        Me.SalesStaffBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesStaffBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesStaffBindingNavigator.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.SalesStaffBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesStaffBindingNavigatorSaveItem})
        Me.SalesStaffBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesStaffBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesStaffBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesStaffBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesStaffBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesStaffBindingNavigator.Name = "SalesStaffBindingNavigator"
        Me.SalesStaffBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesStaffBindingNavigator.Size = New System.Drawing.Size(808, 26)
        Me.SalesStaffBindingNavigator.TabIndex = 0
        Me.SalesStaffBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(41, 23)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 26)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(26, 23)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'SalesStaffBindingNavigatorSaveItem
        '
        Me.SalesStaffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesStaffBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesStaffBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesStaffBindingNavigatorSaveItem.Name = "SalesStaffBindingNavigatorSaveItem"
        Me.SalesStaffBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 23)
        Me.SalesStaffBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SalesStaffDataGridView
        '
        Me.SalesStaffDataGridView.AutoGenerateColumns = False
        Me.SalesStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesStaffDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.SalesStaffDataGridView.DataSource = Me.SalesStaffBindingSource
        Me.SalesStaffDataGridView.Location = New System.Drawing.Point(0, 31)
        Me.SalesStaffDataGridView.Name = "SalesStaffDataGridView"
        Me.SalesStaffDataGridView.RowHeadersWidth = 47
        Me.SalesStaffDataGridView.Size = New System.Drawing.Size(788, 407)
        Me.SalesStaffDataGridView.TabIndex = 1
        '
        'Full_TimeToolStrip
        '
        Me.Full_TimeToolStrip.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.Full_TimeToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Full_TimeToolStripButton})
        Me.Full_TimeToolStrip.Location = New System.Drawing.Point(0, 26)
        Me.Full_TimeToolStrip.Name = "Full_TimeToolStrip"
        Me.Full_TimeToolStrip.Size = New System.Drawing.Size(808, 26)
        Me.Full_TimeToolStrip.TabIndex = 2
        Me.Full_TimeToolStrip.Text = "Full_TimeToolStrip"
        '
        'Full_TimeToolStripButton
        '
        Me.Full_TimeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Full_TimeToolStripButton.Name = "Full_TimeToolStripButton"
        Me.Full_TimeToolStripButton.Size = New System.Drawing.Size(69, 23)
        Me.Full_TimeToolStripButton.Text = "Full_Time"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 115
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 115
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 115
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Full_Time"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Full_Time"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 6
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 115
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hire_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hire_Date"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 115
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Salary"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 115
        '
        'SalesStaffBindingSource
        '
        Me.SalesStaffBindingSource.DataMember = "SalesStaff"
        Me.SalesStaffBindingSource.DataSource = Me.CompanyDataSet
        '
        'CompanyDataSet
        '
        Me.CompanyDataSet.DataSetName = "CompanyDataSet"
        Me.CompanyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesStaffTableAdapter
        '
        Me.SalesStaffTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.SalesStaffTableAdapter = Me.SalesStaffTableAdapter
        Me.TableAdapterManager.UpdateOrder = SalesStaffOne.CompanyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AllRowsToolStrip
        '
        Me.AllRowsToolStrip.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.AllRowsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRowsToolStripButton})
        Me.AllRowsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.AllRowsToolStrip.Name = "AllRowsToolStrip"
        Me.AllRowsToolStrip.Size = New System.Drawing.Size(112, 25)
        Me.AllRowsToolStrip.TabIndex = 3
        Me.AllRowsToolStrip.Text = "AllRowsToolStrip"
        '
        'AllRowsToolStripButton
        '
        Me.AllRowsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AllRowsToolStripButton.Name = "AllRowsToolStripButton"
        Me.AllRowsToolStripButton.Size = New System.Drawing.Size(60, 22)
        Me.AllRowsToolStripButton.Text = "AllRows"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 458)
        Me.Controls.Add(Me.AllRowsToolStrip)
        Me.Controls.Add(Me.Full_TimeToolStrip)
        Me.Controls.Add(Me.SalesStaffDataGridView)
        Me.Controls.Add(Me.SalesStaffBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Company Sales Staff Table"
        CType(Me.SalesStaffBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesStaffBindingNavigator.ResumeLayout(False)
        Me.SalesStaffBindingNavigator.PerformLayout()
        CType(Me.SalesStaffDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Full_TimeToolStrip.ResumeLayout(False)
        Me.Full_TimeToolStrip.PerformLayout()
        CType(Me.SalesStaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AllRowsToolStrip.ResumeLayout(False)
        Me.AllRowsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CompanyDataSet As CompanyDataSet
    Friend WithEvents SalesStaffBindingSource As BindingSource
    Friend WithEvents SalesStaffTableAdapter As CompanyDataSetTableAdapters.SalesStaffTableAdapter
    Friend WithEvents TableAdapterManager As CompanyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesStaffBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SalesStaffBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SalesStaffDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Full_TimeToolStrip As ToolStrip
    Friend WithEvents Full_TimeToolStripButton As ToolStripButton
    Friend WithEvents AllRowsToolStrip As ToolStrip
    Friend WithEvents AllRowsToolStripButton As ToolStripButton
End Class
