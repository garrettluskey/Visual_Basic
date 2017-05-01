<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TotalCostReportViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable1TableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.DataTable1TableAdapter()
        Me.OtherClientReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherClientReportTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.OtherClientReportTableAdapter()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.AllDataDataSet
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.TotalExpencesReportColor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(643, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'OtherClientReportBindingSource
        '
        Me.OtherClientReportBindingSource.DataMember = "OtherClientReport"
        Me.OtherClientReportBindingSource.DataSource = Me.AllDataDataSet
        '
        'OtherClientReportTableAdapter
        '
        Me.OtherClientReportTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DataTable1BindingSource
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "WindowsApplication1.TotalExpencesReportBW.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(643, 427)
        Me.ReportViewer2.TabIndex = 1
        '
        'TotalCostReportViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 427)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "TotalCostReportViewer"
        Me.Text = "Total Expences"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents DataTable1TableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents OtherClientReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherClientReportTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.OtherClientReportTableAdapter
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
End Class
