Public Class TotalCostReportViewer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: This line of code loads data into the 'AllDataDataSet.OtherClientReport' table. You can move, or remove it, as needed.
            Me.OtherClientReportTableAdapter.Fill(Me.AllDataDataSet.OtherClientReport)
            'TODO: This line of code loads data into the 'AllDataDataSet.DataTable1' table. You can move, or remove it, as needed.

            Me.DataTable1TableAdapter.Fill(Me.AllDataDataSet.DataTable1)
        Catch ex As Exception
        End Try
        Me.ReportViewer2.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class