Public Class TotalCostReportOptions

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RdioBW.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RdioBW.Checked = True Then
            TotalCostReportViewer.ReportViewer2.Show()
            TotalCostReportViewer.ReportViewer1.Hide()
            Me.Hide()
            TotalCostReportViewer.Show()
        ElseIf RdioColor.Checked = True Then
            TotalCostReportViewer.ReportViewer1.Show()
            TotalCostReportViewer.ReportViewer2.Hide()
            Me.Close()
            TotalCostReportViewer.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class