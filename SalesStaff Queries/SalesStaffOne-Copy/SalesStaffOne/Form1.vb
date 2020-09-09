Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)
        'TODO: This line of code loads data into the 'CompanyDataSet.SalesStaff' table. You can move, or remove it, as needed.
        Me.SalesStaffTableAdapter.Fill(Me.CompanyDataSet.SalesStaff)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SalesStaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SalesStaffBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SalesStaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CompanyDataSet)

    End Sub

    Private Sub Full_TimeToolStripButton_Click(sender As Object, e As EventArgs) Handles Full_TimeToolStripButton.Click
        Try
            Me.SalesStaffTableAdapter.Full_Time(Me.CompanyDataSet.SalesStaff)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub AllRowsToolStripButton_Click(sender As Object, e As EventArgs) Handles AllRowsToolStripButton.Click
        Try
            Me.SalesStaffTableAdapter.AllRows(Me.CompanyDataSet.SalesStaff)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
