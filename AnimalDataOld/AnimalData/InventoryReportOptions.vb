Public Class InventoryReportOptions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked = True Then
            InventoryReportViewerForm.ReportViewer2.Show()
            InventoryReportViewerForm.ReportViewer1.Hide()
            Me.Hide()
            InventoryReportViewerForm.Show()
        ElseIf RadioButton1.Checked = True Then
            InventoryReportViewerForm.ReportViewer1.Show()
            InventoryReportViewerForm.ReportViewer2.Hide()
            Me.Hide()
            InventoryReportViewerForm.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class