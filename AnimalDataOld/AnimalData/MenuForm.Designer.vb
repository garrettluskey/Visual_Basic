<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Me.AllDataDataSet = New WindowsApplication1.AllDataDataSet()
        Me.AnimalMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalMasterTableAdapter = New WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AllDataDataSet
        '
        Me.AllDataDataSet.DataSetName = "AllDataDataSet"
        Me.AllDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnimalMasterBindingSource
        '
        Me.AnimalMasterBindingSource.DataMember = "animalMaster"
        Me.AnimalMasterBindingSource.DataSource = Me.AllDataDataSet
        '
        'AnimalMasterTableAdapter
        '
        Me.AnimalMasterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.animalMasterTableAdapter = Me.AnimalMasterTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CatInfoTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableTableAdapter = Nothing
        Me.TableAdapterManager.CostReportTableAdapter = Nothing
        Me.TableAdapterManager.dogInfoTableAdapter = Nothing
        Me.TableAdapterManager.OtherClientReportTableAdapter = Nothing
        Me.TableAdapterManager.OtherInfoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add New Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 41)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit Existing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(194, 30)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(96, 23)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Location = New System.Drawing.Point(191, 13)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(44, 13)
        Me.lblReports.TabIndex = 4
        Me.lblReports.Text = "Reports"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(194, 58)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Total Expences"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 90)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Help"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(299, 123)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblReports)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MenuForm"
        Me.Text = "Animal Log"
        CType(Me.AllDataDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AllDataDataSet As WindowsApplication1.AllDataDataSet
    Friend WithEvents AnimalMasterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnimalMasterTableAdapter As WindowsApplication1.AllDataDataSetTableAdapters.animalMasterTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.AllDataDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
