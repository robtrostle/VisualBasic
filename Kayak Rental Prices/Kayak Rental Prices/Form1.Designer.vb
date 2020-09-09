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
        Me.KayaksDataSet = New Kayak_Rental_Prices.KayaksDataSet()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesTableAdapter = New Kayak_Rental_Prices.KayaksDataSetTableAdapters.KayakTypesTableAdapter()
        Me.RentalPricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalPricesTableAdapter = New Kayak_Rental_Prices.KayaksDataSetTableAdapters.RentalPricesTableAdapter()
        Me.KayaksDataSet1 = New Kayak_Rental_Prices.KayaksDataSet()
        Me.RentalPricesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Kayak_Rental_Prices.KayaksDataSetTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KayaksDataSet2 = New Kayak_Rental_Prices.KayaksDataSet()
        Me.KayakTypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksDataSet3 = New Kayak_Rental_Prices.KayaksDataSet()
        Me.KayaksDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayakTypesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalPricesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KayaksDataSet
        '
        Me.KayaksDataSet.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksDataSet
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'RentalPricesBindingSource
        '
        Me.RentalPricesBindingSource.DataMember = "RentalPrices"
        Me.RentalPricesBindingSource.DataSource = Me.KayaksDataSet
        '
        'RentalPricesTableAdapter
        '
        Me.RentalPricesTableAdapter.ClearBeforeFill = True
        '
        'KayaksDataSet1
        '
        Me.KayaksDataSet1.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalPricesBindingSource1
        '
        Me.RentalPricesBindingSource1.DataMember = "RentalPrices"
        Me.RentalPricesBindingSource1.DataSource = Me.KayaksDataSet1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.RentalPricesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Kayak_Rental_Prices.KayaksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.DailyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.KayakTypesBindingSource2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 47
        Me.DataGridView1.Size = New System.Drawing.Size(658, 372)
        Me.DataGridView1.TabIndex = 0
        '
        'KayaksDataSet2
        '
        Me.KayaksDataSet2.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesBindingSource1
        '
        Me.KayakTypesBindingSource1.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource1.DataSource = Me.KayaksDataSet2
        '
        'KayaksDataSet3
        '
        Me.KayaksDataSet3.DataSetName = "KayaksDataSet"
        Me.KayaksDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayaksDataSet3BindingSource
        '
        Me.KayaksDataSet3BindingSource.DataSource = Me.KayaksDataSet3
        Me.KayaksDataSet3BindingSource.Position = 0
        '
        'KayakTypesBindingSource2
        '
        Me.KayakTypesBindingSource2.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource2.DataSource = Me.KayaksDataSet3
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameDataGridViewTextBoxColumn.Width = 115
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly_Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly_Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        Me.HourlyRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.HourlyRateDataGridViewTextBoxColumn.Width = 115
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily_Rate"
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily_Rate"
        Me.DailyRateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        Me.DailyRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DailyRateDataGridViewTextBoxColumn.Width = 115
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly_Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly_Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        Me.WeeklyRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.WeeklyRateDataGridViewTextBoxColumn.Width = 115
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 372)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Kayak Rental Prices"
        CType(Me.KayaksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalPricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalPricesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KayaksDataSet As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents RentalPricesBindingSource As BindingSource
    Friend WithEvents RentalPricesTableAdapter As KayaksDataSetTableAdapters.RentalPricesTableAdapter
    Friend WithEvents KayaksDataSet1 As KayaksDataSet
    Friend WithEvents RentalPricesBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As KayaksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KayaksDataSet2 As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource1 As BindingSource
    Friend WithEvents KayaksDataSet3BindingSource As BindingSource
    Friend WithEvents KayaksDataSet3 As KayaksDataSet
    Friend WithEvents KayakTypesBindingSource2 As BindingSource
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
