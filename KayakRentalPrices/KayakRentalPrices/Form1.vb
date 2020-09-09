Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet2.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet2.KayakTypes)

    End Sub
End Class
