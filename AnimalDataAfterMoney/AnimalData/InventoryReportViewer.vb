Public Class InventoryReportViewerForm

    Private Sub InventoryReportViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllDataDataSet.animalMaster' table. You can move, or remove it, as needed.
        Me.animalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class