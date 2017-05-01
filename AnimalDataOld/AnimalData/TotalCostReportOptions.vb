Public Class TotalCostReportOptions

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton2.Checked = True Then
            TotalCostReportViewer.ReportViewer2.Show()
            TotalCostReportViewer.ReportViewer1.Hide()
            Me.Hide()
            TotalCostReportViewer.Show()
        ElseIf RadioButton1.Checked = True Then
            TotalCostReportViewer.ReportViewer1.Show()
            TotalCostReportViewer.ReportViewer2.Hide()
            Me.Hide()
            TotalCostReportViewer.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub TotalCostReportOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class