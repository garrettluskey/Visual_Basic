Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllDataDataSet.DataTable1' table. You can move, or remove it, as needed.
        Me.DataTable1TableAdapter.Fill(Me.AllDataDataSet.DataTable1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class