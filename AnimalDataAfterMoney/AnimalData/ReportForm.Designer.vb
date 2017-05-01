<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportForm
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
        Me.ClientTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.OtherClientReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.animalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.animalMasterTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.ClientTableTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.ClientTableTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.OtherClientReportTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.OtherClientReportTableAdapter()
        Me.CostReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostReportTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.CostReportTableAdapter()
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.animalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientTableBindingSource
        '
        Me.ClientTableBindingSource.DataMember = "ClientTable"
        Me.ClientTableBindingSource.DataSource = Me.AllDataDataSet
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OtherClientReportBindingSource
        '
        Me.OtherClientReportBindingSource.DataMember = "OtherClientReport"
        Me.OtherClientReportBindingSource.DataSource = Me.AllDataDataSet
        '
        'animalMasterBindingSource
        '
        Me.animalMasterBindingSource.DataMember = "animalMaster"
        Me.animalMasterBindingSource.DataSource = Me.AllDataDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ClientTableBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.CatDogReportColor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1431, 752)
        Me.ReportViewer1.TabIndex = 0
        '
        'animalMasterTableAdapter
        '
        Me.animalMasterTableAdapter.ClearBeforeFill = True
        '
        'ClientTableTableAdapter
        '
        Me.ClientTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Me.animalMasterTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Me.ClientTableTableAdapter
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'OtherClientReportTableAdapter
        '
        Me.OtherClientReportTableAdapter.ClearBeforeFill = True
        '
        'CostReportBindingSource
        '
        Me.CostReportBindingSource.DataMember = "CostReport"
        Me.CostReportBindingSource.DataSource = Me.AllDataDataSet
        '
        'CostReportTableAdapter
        '
        Me.CostReportTableAdapter.ClearBeforeFill = True
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1431, 752)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ReportForm"
        Me.Text = "Client Report"
        CType(Me.ClientTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherClientReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.animalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents animalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents animalMasterTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents ClientTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTableTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.ClientTableTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OtherClientReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherClientReportTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.OtherClientReportTableAdapter
    Friend WithEvents CostReportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CostReportTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.CostReportTableAdapter
End Class
