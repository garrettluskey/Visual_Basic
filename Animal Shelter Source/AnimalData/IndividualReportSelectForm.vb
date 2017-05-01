Public Class IndividualReportSelectForm
    Public StrReportPath As String
    Private ReportPathBeginning As String = "FurryFriendsAnimalShelter."
    Private ReportPathEnding As String = ".rdlc"
    Private Sub BtnContinue_Click(sender As Object, e As EventArgs) Handles BtnContinue.Click
        ReportForm.ReportViewer1.LocalReport.DataSources.Clear()
        Dim RDS = New Microsoft.Reporting.WinForms.ReportDataSource

        If RdioCost.Checked = True Then
            RDS.Name = "DataSet1"
            RDS.Value = ReportForm.CostReportTableAdapter.GetData
            ReportForm.ReportViewer1.LocalReport.DataSources.Add(RDS)
            If RdioColor.Checked = True Then
                StrReportPath = ReportPathBeginning + "CostReportColor" + ReportPathEnding
            ElseIf RdioBlackAndWhite.Checked = True Then
                StrReportPath = ReportPathBeginning + "CostReportBW" + ReportPathEnding
            End If

        ElseIf RdioClient.Checked = True Then
            RDS.Name = "DataSet1"
            If EditForm.StrReport = "CatDogReport" Then
                RDS.Value = ReportForm.ClientTableTableAdapter.GetData
            ElseIf EditForm.StrReport = "OtherClientReport" Then
                RDS.Value = ReportForm.OtherClientReportTableAdapter.GetData
            End If
            ReportForm.ReportViewer1.LocalReport.DataSources.Add(RDS)
            If RdioColor.Checked = True Then
                StrReportPath = ReportPathBeginning + EditForm.StrReport + "Color" + ReportPathEnding
            ElseIf RdioBlackAndWhite.Checked = True Then
                StrReportPath = ReportPathBeginning + EditForm.StrReport + "BW" + ReportPathEnding
            End If
        End If
        If RdioCost.Checked = True Or RdioClient.Checked = True Then
            ReportForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancle_Click(sender As Object, e As EventArgs) Handles BtnCancle.Click
        Me.Close()
    End Sub
End Class