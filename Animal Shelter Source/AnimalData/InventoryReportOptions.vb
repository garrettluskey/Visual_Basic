Public Class InventoryReportOptions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RdioBW.Checked = True Then
            InventoryReportViewerForm.ReportViewerBW.Show()
            InventoryReportViewerForm.ReportViewer1.Hide()
            Me.Hide()
            InventoryReportViewerForm.Show()
        ElseIf RdioColor.Checked = True Then
            InventoryReportViewerForm.ReportViewer1.Show()
            InventoryReportViewerForm.ReportViewerBW.Hide()
            Me.Hide()
            InventoryReportViewerForm.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class