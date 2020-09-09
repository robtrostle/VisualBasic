Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksDataSet3.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksDataSet3.KayakTypes)





    End Sub
End Class
