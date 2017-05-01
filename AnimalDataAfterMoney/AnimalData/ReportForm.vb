Public Class ReportForm

    Private Sub ReportForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ClientTableTableAdapter.DeleteQuery("Vaccination")
        ClientTableTableAdapter.DeleteQuery("Rabies Vaccination")
        ClientTableTableAdapter.DeleteQuery("Distemper Vaccination")
        ClientTableTableAdapter.DeleteQuery("Bordetella Vaccination")
        ClientTableTableAdapter.DeleteQuery("Feline Leukemia Test")
        Me.ReportViewer1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AllDataDataSet.CostReport' table. You can move, or remove it, as needed.
        Me.CostReportTableAdapter.Fill(Me.AllDataDataSet.CostReport)
        'TODO: This line of code loads data into the 'AllDataDataSet.OtherClientReport' table. You can move, or remove it, as needed.
        Me.OtherClientReportTableAdapter.Fill(Me.AllDataDataSet.OtherClientReport)
        'TODO: This line of code loads data into the 'AllDataDataSet.ClientTable' table. You can move, or remove it, as needed.
        Me.ClientTableTableAdapter.Fill(Me.AllDataDataSet.ClientTable)
        'TODO: This line of code loads data into the 'AllDataDataSet.animalMaster' table. You can move, or remove it, as needed.
        Me.animalMasterTableAdapter.Fill(Me.AllDataDataSet.animalMaster)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = IndividualReportSelectForm.StrReportPath
        'Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.CatDogReportColor.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class